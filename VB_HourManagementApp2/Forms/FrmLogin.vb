Public Class FrmLogin

    'ログインカウント
    Private loginCount As Long

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインカウント初期化
        Me.loginCount = 0

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Try
            'ユーザ名
            Dim userName As String = Me.TxtUserName.Text
            'パスワード
            Dim password As String = Me.TxtPassword.Text

            '文字数チェック(ユーザ名)
            If Not CommonProc.IsFitInText(userName, Constant.USERNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_USERNAME_LENGTH,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(パスワード)
            If Not CommonProc.IsFitInText(password, Constant.PASSWORD_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_PASSWORD_LENGTH,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'ユーザ名が存在するかどうか?
            If Not User.IsExistsUserName(userName) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_LOGIN,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'アカウントがロックされているか？
            If User.IsLockedUserName(userName) Then
                'メッセージボックス
                MessageBox.Show(Constant.USER_IS_LOCKED,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'ユーザが存在するかどうか?
            If Not User.IsExistsUser(userName, password) Then
                'ログインカウントをカウントアップ
                Me.loginCount += 1
                'ログインカウントが指定回数を超えた場合、アカウントロック
                If Constant.LOCK_COUNT <= Me.loginCount Then
                    'アカウントロック
                    User.UpdateLock(userName, EnumValue.IsLock.Locked)
                    'メッセージボックス
                    MessageBox.Show(Constant.USER_IS_LOCK,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    Return
                End If
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_LOGIN,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'ユーザIDを取得
            Dim loginUserID As Long = User.GetUserID(userName, password)

            'メイン画面に遷移
            CommonProc.HideAndOpen(Me, New FrmMain(loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub
End Class
