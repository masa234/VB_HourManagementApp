Public Class FrmCalcHour

    'ログインユーザID
    Public ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmCalcHour_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub CmbProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProject.SelectedIndexChanged

        Try
            'プロジェクト名をIDに変換する
            Dim projectID As Long = Project.ProjectNameToID(Me.CmbProject.Text)

            'プロジェクトの合計工数を取得
            Dim sumHours As Integer = Project.GetSumProjectHours(projectID)

            '画面に設定
            Me.LblProjectHour.Text = sumHours.ToString() + "時間"

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
    ''' 2023/04/04
    Private Sub InitForm()

        'コンボボックスの設定
        SetCmb()

    End Sub


    ''' <summary>
    ''' コンボボックスの設定
    ''' </summary>
    ''' 2023/04/04
    Private Sub SetCmb()

        'プロジェクトリストを取得
        Dim projectList As List(Of ProjectData) = Project.GetProjectsList

        '文字列のリストに変換する
        Dim cmbTxtList As List(Of String) = Project.ProjectListToStringList(projectList)

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbProject, cmbTxtList)

    End Sub

End Class