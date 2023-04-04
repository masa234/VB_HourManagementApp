Public Class FrmProjects

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmProjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'フォームの初期化
            InitForm()

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                        Constant.WARNING,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DgvProjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProjects.CellContentClick

        Dim projectID As Long

        Try
            'プロジェクトID
            Long.TryParse(DgvProjects.Rows(e.RowIndex).Cells(4).Value.ToString(), projectID)

            '削除ボタンが押されている場合
            If DgvProjects.Columns(e.ColumnIndex).Name = "BtnProjectDelete" Then
                '管理者かどうか?
                If Not User.IsAdmin(Me.loginUserID) Then
                    '終了
                    Return
                End If

                '削除
                If Not Project.DeleteProject(projectID) Then
                    'メッセージボックス
                    MessageBox.Show(Constant.FAILED_DELETE_PROJECT,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    Return
                End If

                '成功メッセージ
                MessageBox.Show(Constant.SUCCESS_DELETE_PROJECT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                'データソースの再設定
                SetDataSource()
            End If

            '更新ボタンが押されている場合
            If DgvProjects.Columns(e.ColumnIndex).Name = "BtnProjectUpdate" Then
                'プロジェクト更新画面に遷移
                CommonProc.HideAndOpen(Me, New FrmUpdateProject(Me.loginUserID, projectID))
            End If

            'タスク登録ボタンが押されている場合
            If DgvProjects.Columns(e.ColumnIndex).Name = "BtnInsertTask" Then
                'タスク登録画面に遷移
                CommonProc.HideAndOpen(Me, New FrmInsertTask(Me.loginUserID, projectID))
            End If

            'タスク一覧ボタンが押されている場合
            If DgvProjects.Columns(e.ColumnIndex).Name = "BtnTasks" Then
                'タスク一覧画面に遷移
                CommonProc.HideAndOpen(Me, New FrmTasks(Me.loginUserID, projectID))
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
        Me.DgvProjects.DataSource = Project.GetProjectsList()

    End Sub

End Class