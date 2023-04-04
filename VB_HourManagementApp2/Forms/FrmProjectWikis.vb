Public Class FrmProjectWikis

    'ログインユーザID
    Private ReadOnly loginUserID As Long

    Public Sub New(ByVal loginUserID As Long)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'ログインユーザID設定
        Me.loginUserID = loginUserID

    End Sub

    Private Sub FrmProjectWikis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnUpdateWiki_Click(sender As Object, e As EventArgs) Handles BtnUpdateWiki.Click

        Try
            'プロジェクト名
            Dim projectName As String = Me.CmbProject.Text
            'Wiki
            Dim wiki As String = Me.TxtWiki.Text

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

            '文字数チェック(Wiki)
            If Not CommonProc.IsFitInText(wiki, Constant.WIKI_MAX_LENGTH) Then
                'メッセージボックス
                MessageBox.Show(Constant.INVALID_WIKI_LENGTH,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            'プロジェクト名をIDに変換する
            Dim projectID As Long = Project.ProjectNameToID(projectName)

            '更新
            If Not Project.UpdateWiki(wiki, projectID) Then
                'メッセージボックス
                MessageBox.Show(Constant.FAILED_UPDATE_WIKI,
                                Constant.CONFIRM,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
                Return
            End If

            '成功メッセージ
            MessageBox.Show(Constant.SUCCESS_UPDATE_WIKI,
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

    Private Sub CmbProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProject.SelectedIndexChanged

        Try
            'プロジェクト名
            Dim projectName As String = Me.CmbProject.Text

            'Wikiを設定
            SetWiki(projectName)

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

        'プロジェクトリストを取得
        Dim projectList As List(Of ProjectData) = Project.GetProjectsList

        '文字列のリストに変換する
        Dim cmbTxtList As List(Of String) = Project.ProjectListToStringList(projectList)

        'コンボボックスに設定
        CommonProc.SetCmb(Me.CmbProject, cmbTxtList)

    End Sub


    ''' <summary>
    ''' Wikiを設定
    ''' </summary>
    ''' 2023/04/03
    Private Sub SetWiki(ByVal projectName As String)

        'プロジェクト名をIDに変換する
        Dim projectID As Long = Project.ProjectNameToID(projectName)

        '設定
        Me.TxtWiki.Text = Project.GetWiki(projectID)

    End Sub

End Class