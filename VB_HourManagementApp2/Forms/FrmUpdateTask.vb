Public Class FrmUpdateTask

    'ログインユーザID
    Private ReadOnly loginUserID As Long
    'プロジェクトID
    Private ReadOnly projectID As Long
    '更新対象タスクID
    Private ReadOnly updateTaskID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal projectID As Long,
                   ByVal updateTaskID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '設定
        'ログインユーザID
        Me.loginUserID = loginUserID
        'プロジェクトID
        Me.projectID = projectID
        '更新対象タスクID
        Me.updateTaskID = updateTaskID

    End Sub

    Private Sub FrmUpdateTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnUpdateTask_Click(sender As Object, e As EventArgs) Handles BtnUpdateTask.Click

        Try
            'タスク名
            Dim taskName As String = Me.TxtTaskName.Text
            '工数
            Dim hour As Integer = CommonProc.SafeCastInt(Me.TxtHour.Text)
            '概要
            Dim summary As String = Me.TxtSummary.Text
            '状態
            Dim status As String = Me.CmbStatus.Text

            '文字数チェック(タスク名)
            If Not CommonProc.IsFitInText(taskName, Constant.TASKNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_TASKNAME_LENGTH,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(工数)
            If Not CommonProc.IsInputed(hour) Then
                'メッセージボックス
                MessageBox.Show(Constant.HOUR_MUST_INPUT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '文字数チェック(概要)
            If Not CommonProc.IsFitInText(summary, Constant.SUMMARY_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_SUMMARY_LENGTH,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(状態)
            If Not CommonProc.IsInputed(status) Then
                'メッセージボックス
                MessageBox.Show(Constant.STATUS_MUST_INPUT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'コンボボックスの選択肢内かどうか?(状態)
            If Not CommonProc.IsTextInCmb(Me.CmbStatus, status) Then
                'メッセージボックス
                MessageBox.Show(Constant.STATUS_MUST_IN_CMB,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '更新
            If Not Task.UpdateTask(taskName,
                                   hour,
                                   summary,
                                   status,
                                   Me.projectID,
                                   Me.updateTaskID) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_UPDATE_TASK,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_UPDATE_TASK,
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


    ''' <summary>
    ''' フォーム初期化
    ''' </summary>
    ''' 2023/03/30
    Private Sub InitForm()

        'コンボボックスの設定
        SetCmb()

        'タスク情報取得
        SetTask()

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/03/30
    Private Sub SetCmb()

        '状態のリストを取得
        Dim statusList As List(Of String) = OtherProc.GetStatusList()

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbStatus, statusList)

    End Sub



    ''' <summary>
    ''' タスク情報を画面に設定する
    ''' </summary>
    ''' 2023/03/31
    Private Sub SetTask()

        'タスク情報を取得
        Dim taskdata As TaskData = Task.GetTask(Me.updateTaskID)

        '画面に設定
        'タスク名
        Me.TxtTaskName.Text = taskdata.TaskName
        '工数
        Me.TxtHour.Text = taskdata.Hour
        '概要
        Me.TxtSummary.Text = taskdata.Summary
        '状態
        Me.CmbStatus.Text = taskdata.Status

    End Sub

End Class