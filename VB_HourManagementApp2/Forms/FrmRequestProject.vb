Public Class FrmRequestProject

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmRequestProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnRequestProject_Click(sender As Object, e As EventArgs) Handles BtnRequestProject.Click

        Try
            '管理者の場合
            If User.IsAdmin(Me.loginUserID) Then
                '終了
                Return
            End If

            'プロジェクト名
            Dim projectName As String = Me.CmbProject.Text

            '入力チェック(プロジェクト名)
            If Not CommonProc.IsInputed(projectName) Then
                'メッセージボックス
                MessageBox.Show(Constant.PROJECTNAME_MUST_INPUT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'コンボボックスの選択肢内かどうか?(プロジェクト名)
            If Not CommonProc.IsTextInCmb(Me.CmbProject, projectName) Then
                'メッセージボックス
                MessageBox.Show(Constant.PROJECTNAME_MUST_IN_CMB,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '応募
            If Not Request.InsertRequest(projectName, Me.loginUserID) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_REQUEST_PROJECT,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_REQUEST_PROJECT,
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
    ''' 2023/04/03
    Private Sub InitForm()

        'コンボボックスの設定
        SetCmb()

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/04/03
    Private Sub SetCmb()

        'プロジェクトのリストを取得
        Dim projectList As List(Of ProjectData) = Project.GetProjectsList

        'プロジェクト名のリストに変換
        Dim projectNameList As List(Of String) = Project.ProjectListToStringList(projectList)

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbProject, projectNameList)

    End Sub

End Class