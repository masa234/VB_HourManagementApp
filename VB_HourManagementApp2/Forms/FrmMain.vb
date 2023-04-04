Public Class FrmMain

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub BtnReleaseLock_Click(sender As Object, e As EventArgs) Handles BtnReleaseLock.Click

        Try
            'アカウントロック解除画面に遷移
            CommonProc.HideAndOpen(Me, New FrmReleaseLock(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Try
            'ログイン画面に遷移
            CommonProc.HideAndOpen(Me, New FrmLogin)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnInsertProject_Click(sender As Object, e As EventArgs) Handles BtnInsertProject.Click

        Try
            'プロジェクト登録画面に遷移
            CommonProc.HideAndOpen(Me, New FrmInsertProject(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnProjects_Click(sender As Object, e As EventArgs) Handles BtnProjects.Click

        Try
            'プロジェクト一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmProjects(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnArchivedTasks_Click(sender As Object, e As EventArgs) Handles BtnArchivedTasks.Click

        Try
            'アーカイブ一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmArchiveTasks(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnRequestProject_Click(sender As Object, e As EventArgs) Handles BtnRequestProject.Click

        Try
            'プロジェクト応募画面に遷移
            CommonProc.HideAndOpen(Me, New FrmRequestProject(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                    Constant.WARNING,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnProjectWikis_Click(sender As Object, e As EventArgs) Handles BtnProjectWikis.Click

        Try
            'Wiki一覧画面に遷移
            CommonProc.HideAndOpen(Me, New FrmProjectWikis(Me.loginUserID))

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnCalcHour_Click(sender As Object, e As EventArgs) Handles BtnCalcHour.Click

        Try
            '工数計算画面に遷移
            CommonProc.HideAndOpen(Me, New FrmCalcHour(Me.loginUserID))

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
    ''' 2023/03/28
    Private Sub InitForm()

        'ボタンの表示非表示を設定
        SetBtnVisible()

        '管理者の場合
        If User.IsAdmin(Me.loginUserID) Then
            'プロジェクト応募が存在する場合
            If Request.IsExistsRequest() Then
                '通知
                Request.Notification()
                '通知状態を更新
                Request.UpdateNotification()
            End If

            '通知していない、本日のプロジェクトが存在する場合
            If Project.IsExistsTodayProject() Then
                'TODO: 動作しない
                '通知
                Project.Notification()
                '通知状態を更新
                Project.UpdateNotification()
            End If
        End If

    End Sub


    ''' <summary>
    ''' ボタンの表示非表示を設定
    ''' </summary>
    ''' 2023/03/28
    Private Sub SetBtnVisible()

        '管理者でない場合
        If Not User.IsAdmin(Me.loginUserID) Then
            'ボタンを非表示にする
            'アカウントロック解除ボタン
            Me.BtnReleaseLock.Visible = False
        Else
            '管理者の場合
            'ボタンを非表示にする
            'プロジェクト応募ボタン
            Me.BtnRequestProject.Visible = False
        End If

    End Sub

End Class