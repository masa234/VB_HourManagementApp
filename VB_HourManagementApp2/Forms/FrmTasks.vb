Public Class FrmTasks

    'ログインユーザID
    Private ReadOnly loginUserID As Long
    'プロジェクトID
    Private ReadOnly projectID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal projectID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '設定
        'ログインユーザID
        Me.loginUserID = loginUserID
        'プロジェクトID
        Me.projectID = projectID

    End Sub

    Private Sub FrmTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub DgvTasks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTasks.CellContentClick

        Dim taskID As Long

        Try
            'タスクID
            Long.TryParse(DgvTasks.Rows(e.RowIndex).Cells(3).Value.ToString(), taskID)

            '削除ボタンが押されている場合
            If DgvTasks.Columns(e.ColumnIndex).Name = "BtnDeleteTask" Then
                '削除
                If Not Task.DeleteTask(taskID) Then
                    'メッセージボックス
                    MessageBox.Show(Constant.FAILED_DELETE_TASK,
                                    Constant.CONFIRM,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                    Return
                End If

                'データソースの再設定
                SetDataSource()
            End If

            '更新ボタンが押されている場合
            If DgvTasks.Columns(e.ColumnIndex).Name = "BtnUpdateTask" Then
                'タスク更新画面に遷移
                CommonProc.HideAndOpen(Me, New FrmUpdateTask(Me.loginUserID, Me.projectID, taskID))
            End If

            'アーカイブ化ボタンが押されている場合
            If DgvTasks.Columns(e.ColumnIndex).Name = "BtnArchive" Then
                'アーカイブ
                Task.Archive(taskID)

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


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Try
            'タスク名
            Dim searchTaskName As String = Me.TxtSearchTaskName.Text

            '件数を取得
            Dim taskCount As Long = Task.GetSearchCount(Me.projectID, searchTaskName)

            '画面に件数を設定
            Me.LblSearchCount.Text = taskCount.ToString() + "件"

            '検索用データソース設定
            SetSearchDataSource(searchTaskName)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BtnOutputCSV_Click(sender As Object, e As EventArgs) Handles BtnOutputCSV.Click

        Try
            'タスクリストを取得
            Dim taskList As List(Of TaskData) = Task.GetProjectTaskList(Me.projectID)

            'CSV出力
            If Not Task.OutputCSV(taskList, Constant.OUTPUT_CSV_PATH) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_OUTPUT_CSV,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_OUTPUT_CSV,
                            Constant.CONFIRM,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            'メッセージボックス
            MessageBox.Show(ex.Message,
                            Constant.WARNING,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnSortStatus_Click(sender As Object, e As EventArgs) Handles BtnSortStatus.Click

        Try
            'ソート済みデータソースを設定
            SetSortedDataSource()

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
    ''' 2023/03/30
    Private Sub InitForm()

        'データソースの設定
        SetDataSource()

    End Sub


    ''' <summary>
    ''' データソースの設定
    ''' </summary>
    ''' 2023/03/30
    Private Sub SetDataSource()

        'データソースの設定
        Me.DgvTasks.DataSource = Task.GetProjectTaskList(Me.projectID)

    End Sub


    ''' <summary>
    ''' 検索用データソースの設定
    ''' </summary>
    ''' 2023/03/31
    Private Sub SetSearchDataSource(ByVal searchTaskName As String)

        'データソースの設定
        Me.DgvTasks.DataSource = Task.FilterTaskList(Me.projectID, searchTaskName)

    End Sub


    ''' <summary>
    ''' ソート済みデータソースを取得
    ''' </summary>
    ''' 2023/03/31
    Private Sub SetSortedDataSource()

        'データソースの設定
        Me.DgvTasks.DataSource = Task.GetSortedProjectTaskList(Me.projectID)

    End Sub

End Class