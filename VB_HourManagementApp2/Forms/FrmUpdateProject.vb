Public Class FrmUpdateProject

    'ログインユーザID
    Private ReadOnly loginUserID As Long
    '更新対象プロジェクトID
    Private ReadOnly updateProjectID As Long

    Public Sub New(ByVal loginUserID As Long,
                   ByVal updateProjectID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        '設定
        'ログインユーザID
        Me.loginUserID = loginUserID
        'プロジェクトID
        Me.updateProjectID = updateProjectID

    End Sub

    Private Sub FrmUpdateProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnUpdateProject_Click(sender As Object, e As EventArgs) Handles BtnUpdateProject.Click

        Try
            'プロジェクト名
            Dim projectName As String = Me.TxtProjectName.Text
            '工数
            Dim hour As Integer = CommonProc.SafeCastInt(Me.TxtHour.Text)
            '概要
            Dim summary As String = Me.TxtSummary.Text
            '開始日時
            Dim startDate As Date = Me.DateStartDate.Text
            '終了日時
            Dim endDate As Date = Me.DateEndDate.Text
            '状態
            Dim status As String = Me.CmbStatus.Text

            '文字数チェック(プロジェクト名)
            If Not CommonProc.IsFitInText(projectName, Constant.PROJECTNAME_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_PROJECTNAME_LENGTH,
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

            '入力チェック(開始日時)
            If Not CommonProc.IsInputed(startDate) Then
                'メッセージボックス
                MessageBox.Show(Constant.START_DATE_MUST_INPUT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '入力チェック(終了日時)
            If Not CommonProc.IsInputed(endDate) Then
                'メッセージボックス
                MessageBox.Show(Constant.END_DATE_MUST_INPUT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '開始日時が終了日時を超えていないか?
            If endDate < startDate Then
                'メッセージボックス
                MessageBox.Show(Constant.START_DATE_MUST_BEFORE_END_DATE,
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
            If Not Project.UpdateProject(projectName,
                                         hour,
                                         summary,
                                         startDate,
                                         endDate,
                                         status,
                                         Me.updateProjectID) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_UPDATE_PROJECT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_UPDATE_PROJECT,
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

        'コンボボックスの設定
        SetCmb()

        'プロジェクト情報を画面に設定
        SetProject()

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/03/29
    Private Sub SetCmb()

        '状態のリストを取得
        Dim statusList As List(Of String) = OtherProc.GetStatusList()

        'コンボボックスの設定
        CommonProc.SetCmb(Me.CmbStatus, statusList)

    End Sub


    ''' <summary>
    ''' プロジェクト情報を設定
    ''' </summary>
    ''' 2023/03/29
    Private Sub SetProject()

        'プロジェクト情報を取得
        Dim projectData As ProjectData = Project.GetProject(Me.updateProjectID)

        '画面に設定
        'プロジェクト名
        Me.TxtProjectName.Text = projectData.ProjectName
        '工数
        Me.TxtHour.Text = projectData.Hour
        '概要
        Me.TxtSummary.Text = projectData.Summary
        '開始日時
        Me.DateStartDate.Text = projectData.StartDate
        '終了日時
        Me.DateEndDate.Text = projectData.EndDate
        '状態
        Me.CmbStatus.Text = projectData.Status

    End Sub

End Class