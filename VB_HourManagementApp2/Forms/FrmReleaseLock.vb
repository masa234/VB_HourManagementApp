Public Class FrmReleaseLock

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmReleaseLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'フォーム初期化
            InitForm()

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DgvLockedUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLockedUsers.CellContentClick

        Try
            'ロック解除ボタンが押されている場合
            If DgvLockedUsers.Columns(e.ColumnIndex).Name = "btnReleaseLock" Then
                '管理者でない場合
                If Not User.IsAdmin(Me.loginUserID) Then
                    '終了
                    Return
                End If

                'ユーザ名
                Dim lockedUserName As String = DgvLockedUsers.Rows(e.RowIndex).Cells(2).Value.ToString()

                'ロック解除
                User.UpdateLock(lockedUserName, EnumValue.IsLock.NotLock)

                'データソースの再設定
                SetDataSource()
            End If

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Try
            'メイン画面に遷移
            CommonProc.HideAndOpen(Me, New FrmMain(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/03/29
    Private Sub InitForm()

        'データソースの設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソースの設定
    ''' </summary>
    ''' 2023/03/29
    Private Sub SetDataSource()

        'データソースの設定
        Me.DgvLockedUsers.DataSource = User.GetLockedUsers()

    End Sub

End Class