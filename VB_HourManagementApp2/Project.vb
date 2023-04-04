Imports System.Data.SqlClient
Imports System.Net.NetworkInformation

Public Class Project

    ''' <summary>
    ''' プロジェクト登録
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function InsertProject(ByVal projectName As String,
                                        ByVal hour As Integer,
                                        ByVal summary As String,
                                        ByVal startDate As Date,
                                        ByVal endDate As Date,
                                        ByVal strStatus As String) As Boolean

        '状態をInt型に変換する
        Dim intStatus As Integer = OtherProc.StatusToInt(strStatus)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("ProjectName", projectName),
            New SqlParameter("Hour", hour),
            New SqlParameter("Summary", summary),
            New SqlParameter("StartDate", startDate),
            New SqlParameter("EndDate", endDate),
            New SqlParameter("Status", intStatus),
            New SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified),
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_PROJECT_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' プロジェクトリストを取得する
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function GetProjectsList() As List(Of ProjectData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
        })

        'SQL取得
        Dim sql As String = Constant.GET_PROJECTS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'タスクリストに変換する
            Dim projectList As List(Of ProjectData) = DtToProjectList(dt)

            Return projectList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルをプロジェクトリストに変換する
    ''' </summary>
    ''' 2023/03/29
    Private Shared Function DtToProjectList(ByVal dt As DataTable) As List(Of ProjectData)

        Dim id As Integer
        Dim hour As Integer
        Dim startDate As Date
        Dim endDate As Date
        Dim status As Integer

        'リスト作成
        Dim projectList As New List(Of ProjectData)

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim projectData As New ProjectData

            '設定
            'ID
            Integer.TryParse(row("Id").ToString(), id)
            projectData.Id = id
            'プロジェクト名
            projectData.ProjectName = row("ProjectName").ToString()
            '工数
            Integer.TryParse(row("Hour").ToString(), hour)
            projectData.Hour = hour
            '概要
            projectData.Summary = row("Summary").ToString()
            '開始日時
            Date.TryParse(row("StartDate").ToString(), startDate)
            projectData.StartDate = startDate
            '終了日時
            Date.TryParse(row("EndDate").ToString(), endDate)
            projectData.EndDate = endDate
            '状態
            Integer.TryParse(row("Status").ToString(), status)
            projectData.Status = OtherProc.StatusToString(status)

            'リストに追加
            projectList.Add(projectData)
        Next row

        Return projectList

    End Function


    ''' <summary>
    ''' プロジェクト削除
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function DeleteProject(ByVal deleteProjectID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteProjectID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_PROJECT_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' プロジェクト情報を取得
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function GetProject(ByVal projectID As Long) As ProjectData

        Dim id As Integer
        Dim hour As Integer
        Dim startDate As Date
        Dim endDate As Date
        Dim status As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", projectID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_PROJECT_SQL

        'インスタンス化
        Dim db As New DB()

        'インスタンス化
        Dim projectData As New ProjectData

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                '設定
                'ID
                Integer.TryParse(reader(0).ToString(), id)
                projectData.Id = id
                'プロジェクト名
                projectData.ProjectName = reader(1).ToString()
                '工数
                Integer.TryParse(reader(2).ToString(), hour)
                projectData.Hour = hour
                '概要
                projectData.Summary = reader(3).ToString()
                '開始日時
                Date.TryParse(reader(4).ToString(), startDate)
                projectData.StartDate = startDate
                '終了日時
                Date.TryParse(reader(5).ToString(), endDate)
                projectData.EndDate = endDate
                '状態
                Integer.TryParse(reader(6).ToString(), status)
                projectData.Status = OtherProc.StatusToString(status)
            End While
        End Using

        Return projectData

    End Function


    ''' <summary>
    ''' プロジェクト更新
    ''' </summary>
    ''' 2023/03/30
    Public Shared Function UpdateProject(ByVal projectName As String,
                                       ByVal hour As Integer,
                                       ByVal summary As String,
                                       ByVal startDate As Date,
                                       ByVal endDate As Date,
                                       ByVal strStatus As String,
                                       ByVal updateProjectID As Long) As Boolean

        '状態をInt型にする
        Dim intStatus As Integer = OtherProc.StatusToInt(strStatus)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("ProjectName", projectName),
            New SqlParameter("Hour", hour),
            New SqlParameter("Summary", summary),
            New SqlParameter("StartDate", startDate),
            New SqlParameter("EndDate", endDate),
            New SqlParameter("Status", intStatus),
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible),
            New SqlParameter("Id", updateProjectID)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_PROJECT_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(Sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' プロジェクトリストを文字列のリストに変換する
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function ProjectListToStringList(ByVal projectList As List(Of ProjectData)) As List(Of String)

        'リスト作成
        Dim retList As New List(Of String)

        'プロジェクトリストの要素数だけ繰り返す
        For Each project In projectList
            'リストに追加(プロジェクト名)
            retList.Add(project.ProjectName)
        Next project

        Return retList

    End Function


    ''' <summary>
    ''' プロジェクト名をプロジェクトIDに変換する
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function ProjectNameToID(ByVal projectName As String) As Long

        Dim result As Long

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("ProjectName", projectName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_PROJECTID_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'Long型に変換
                Long.TryParse(reader(0).ToString(), result)

                Return result
            End While
        End Using

        Return 0

    End Function


    ''' <summary>
    ''' Wiki情報を取得
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function GetWiki(ByVal projectID As Long) As String

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", projectID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_PROJECTWIKI_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                Return reader(0).ToString()
            End While
        End Using

        Return String.Empty

    End Function


    ''' <summary>
    ''' Wiki情報を更新
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function UpdateWiki(ByVal wiki As String,
                                      ByVal projectID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Wiki", wiki),
            New SqlParameter("Id", projectID)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_PROJECTWIKI_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 通知していない、本日のプロジェクトが存在するかどうか?
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function IsExistsTodayProject() As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("EndDate", DateTime.Today),
            New SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified)
        })

        'SQL取得
        Dim sql As String = Constant.GET_TODAY_PROJECT_COUNT_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(件数)を取得
        Dim projectCount As Long = db.ExecuteScalar(sql, paramList)

        '件数が1件を超えているかどうか?
        If 1 <= projectCount Then
            Return True
        End If

        Return False

    End Function


    ''' <summary>
    ''' 通知
    ''' </summary>
    ''' 2023/04/03
    Public Shared Sub Notification()

        'プロジェクトリストを取得
        Dim projectList As List(Of ProjectData) = GetTodayProjectList()

        '通知文言を作成
        Dim messageStr = GetNotificationStr(projectList)

        '通知
        MessageBox.Show(messageStr,
                        Constant.CONFIRM,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub


    ''' <summary>
    ''' 通知していない、本日のプロジェクトを取得
    ''' </summary>
    ''' 2023/04/03
    Private Shared Function GetTodayProjectList() As List(Of ProjectData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("EndDate", DateTime.Today),
            New SqlParameter("Notification_Flag", EnumValue.IsNotification.NotNotified)
        })

        'SQL取得
        Dim sql As String = Constant.GET_TODAY_PROJECT_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'プロジェクトリストに変換する
            Dim projectList As List(Of ProjectData) = DtToProjectList(dt)

            Return projectList
        End Using

    End Function


    ''' <summary>
    ''' 通知文言を作成
    ''' </summary>
    ''' 2023/04/03
    Private Shared Function GetNotificationStr(ByVal projectList As List(Of ProjectData)) As String

        '文言初期化
        Dim retStr As String = String.Empty

        retStr = retStr + "本日の案件をお知らせします。" + Environment.NewLine

        'プロジェクトリストの要素数だけ繰り返す
        For Each project In projectList
            'プロジェクト名を出力
            retStr = retStr + "案件名" + project.ProjectName + Environment.NewLine
        Next project

        Return retStr

    End Function


    ''' <summary>
    ''' 通知状態を更新
    ''' </summary>
    ''' 2023/04/04
    Public Shared Sub UpdateNotification()

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Notification_Flag", EnumValue.IsNotification.Notified)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_ALL_PROJECT_NORTICATION_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

    End Sub


    ''' <summary>
    ''' 合計工数を取得
    ''' </summary>
    ''' 2023/04/04
    Public Shared Function GetSumProjectHours(ByVal projectID As Long) As Integer

        Dim result As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_SUM_PROJECT_HOURS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'Int型に変換
                Integer.TryParse(reader(0).ToString(), result)

                Return result
            End While
        End Using

        Return 0

    End Function

End Class
