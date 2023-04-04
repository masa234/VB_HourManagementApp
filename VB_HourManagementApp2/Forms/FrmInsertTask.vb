Public Class FrmInsertTask

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

    Private Sub FrmInsertTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnInsertTask_Click(sender As Object, e As EventArgs) Handles BtnInsertTask.Click

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

            '登録
            If Not Task.InsertTask(taskName,
                                    hour,
                                    summary,
                                    status,
                                    Me.projectID) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_INSERT_TASK,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_INSERT_TASK,
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

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/03/30
    Private Sub SetCmb()

        '状態のリストを取得
        Dim statusList As List(Of String) = OtherProc.GetStatusList()

        'コンボボックス設定
        CommonProc.SetCmb(Me.CmbStatus, statusList)

    End Sub

End Class