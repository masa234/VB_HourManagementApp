Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class Task

    ''' <summary>
    ''' タスク登録
    ''' </summary>
    ''' 2023/03/30
    Public Shared Function InsertTask(ByVal taskName As String,
                                       ByVal hour As Integer,
                                       ByVal summary As String,
                                       ByVal strStatus As String,
                                       ByVal projectID As Long) As Boolean

        '状態をInt型にする
        Dim intStatus As Integer = OtherProc.StatusToInt(strStatus)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("TaskName", taskName),
            New SqlParameter("Hour", hour),
            New SqlParameter("Summary", summary),
            New SqlParameter("InsertDate", DateTime.Today),
            New SqlParameter("UpdateDate", DateTime.Today),
            New SqlParameter("Status", intStatus),
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible),
            New SqlParameter("Project_Id", projectID)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_TASK_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' タスク一覧取得
    ''' </summary>
    ''' 2023/03/30
    Public Shared Function GetProjectTaskList(ByVal projectID As Long) As List(Of TaskData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
        })

        'SQL取得
        Dim sql As String = Constant.GET_TASKS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'タスクリストに変換する
            Dim taskList As List(Of TaskData) = DtToTaskList(dt)

            Return taskList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルをタスクリストに変換する
    ''' </summary>
    ''' 2023/03/30
    Private Shared Function DtToTaskList(ByVal dt As DataTable) As List(Of TaskData)

        Dim id As Integer
        Dim hour As Integer
        Dim insertDate As Date
        Dim updateDate As Date
        Dim status As Integer

        'リスト作成
        Dim taskList As New List(Of TaskData)

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim taskData As New TaskData

            '設定
            'ID
            Integer.TryParse(row("Id").ToString(), id)
            taskData.Id = id
            'タスク名
            taskData.TaskName = row("TaskName").ToString
            '工数
            Integer.TryParse(row("Hour").ToString(), hour)
            taskData.Hour = hour
            '概要
            taskData.Summary = row("Summary").ToString()
            '投稿日時
            Date.TryParse(row("InsertDate").ToString(), insertDate)
            taskData.InsertDate = insertDate
            '更新日時
            Date.TryParse(row("UpdateDate").ToString(), updateDate)
            taskData.UpdateDate = updateDate
            '状態
            Integer.TryParse(row("Status").ToString(), status)
            taskData.Status = OtherProc.StatusToString(status)

            'リストに追加
            taskList.Add(taskData)
        Next row

        Return taskList

    End Function


    ''' <summary>
    ''' タスク削除
    ''' </summary>
    ''' 2023/03/30
    Public Shared Function DeleteTask(ByVal deleteTaskID As Long) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", deleteTaskID)
        })

        'SQL取得
        Dim sql As String = Constant.DELETE_TASK_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' タスク取得
    ''' </summary>
    ''' 2023/03/30
    Public Shared Function GetTask(ByVal taskID As Long) As TaskData

        Dim id As Integer
        Dim hour As Integer
        Dim insertDate As Date
        Dim updateDate As Date
        Dim status As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", taskID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_TASK_SQL

        'インスタンス化
        Dim taskData As New TaskData

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                '設定
                'ID
                Integer.TryParse(reader(0).ToString(), id)
                taskData.Id = id
                'タスク名
                taskData.TaskName = reader(1).ToString()
                '工数
                Integer.TryParse(reader(2).ToString(), hour)
                taskData.Hour = hour
                '概要
                taskData.Summary = reader(3).ToString()
                '投稿日時
                Date.TryParse(reader(4).ToString(), insertDate)
                taskData.InsertDate = insertDate
                '更新日時
                Date.TryParse(reader(5).ToString(), updateDate)
                taskData.UpdateDate = updateDate
                '状態
                Integer.TryParse(reader(6).ToString(), status)
                taskData.Status = OtherProc.StatusToString(status)
            End While
        End Using

        Return taskData

    End Function


    ''' <summary>
    ''' タスク更新
    ''' </summary>
    ''' 2023/03/31
    Public Shared Function UpdateTask(ByVal taskName As String,
                                       ByVal hour As Integer,
                                       ByVal summary As String,
                                       ByVal strStatus As String,
                                       ByVal projectID As Long,
                                       ByVal updateTaskID As Long) As Boolean

        '状態をInt型にする
        Dim intStatus As Integer = OtherProc.StatusToInt(strStatus)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("TaskName", taskName),
            New SqlParameter("Hour", hour),
            New SqlParameter("Summary", summary),
            New SqlParameter("UpdateDate", DateTime.Today),
            New SqlParameter("Status", intStatus),
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("Id", updateTaskID)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_TASK_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' 検索件数を取得
    ''' </summary>
    ''' 2023/03/31
    Public Shared Function GetSearchCount(ByVal projectID As Long,
                                          ByVal searchTaskName As String) As Long

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("TaskName", searchTaskName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_TASK_SEARCH_COUNT_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(件数)を取得
        Return db.ExecuteScalar(sql, paramList)

    End Function


    ''' <summary>
    ''' タスク検索
    ''' </summary>
    ''' 2023/03/31
    Public Shared Function FilterTaskList(ByVal projectID As Long,
                                          ByVal searchTaskName As String) As List(Of TaskData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("TaskName", searchTaskName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_SEARCH_TASK_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'タスクリストに変換
            Dim taskList As List(Of TaskData) = DtToTaskList(dt)

            Return taskList
        End Using

    End Function


    ''' <summary>
    ''' CSV出力
    ''' </summary>
    ''' 2023/03/31
    Public Shared Function OutputCSV(ByVal outputTaskList As List(Of TaskData),
                                     ByVal outputCSVPath As String) As Boolean

        'タスクリストを文字列のリストに変換
        Dim outputList As List(Of String) = TaskListToStringList(outputTaskList)

        '区切り文字で区切る
        String.Join(",", outputList)

        '出力
        File.WriteAllLines(outputCSVPath, outputList)

        Return True

    End Function


    ''' <summary>
    ''' CSV出力
    ''' </summary>
    ''' 2023/03/31
    Private Shared Function TaskListToStringList(ByVal taskList As List(Of TaskData)) As List(Of String)

        'リストを作成
        Dim retList As New List(Of String)

        'タスクリストの要素数だけ繰り返す
        For Each task In taskList
            'タスク名を追加
            retList.Add(task.TaskName)
        Next task

        Return retList

    End Function


    ''' <summary>
    ''' ソート済みタスクリストを取得
    ''' </summary>
    ''' 2023/03/31
    Public Shared Function GetSortedProjectTaskList(ByVal projectID) As List(Of TaskData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("Display_Flag", EnumValue.IsVisible.Visible)
        })

        'SQL取得
        Dim sql As String = Constant.GET_SORTED_TASKS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'タスクリストに変換する
            Dim taskList As List(Of TaskData) = DtToTaskList(dt)

            Return taskList
        End Using

    End Function


    ''' <summary>
    ''' アーカイブ
    ''' </summary>
    ''' 2023/04/03
    Public Shared Sub Archive(ByVal taskID)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Display_Flag", EnumValue.IsVisible.NotVisible),
            New SqlParameter("Id", taskID)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_DISPLAY_FLAG_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

    End Sub


    ''' <summary>
    ''' アーカイブ一覧取得
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function GetAllArchivedTaskList() As List(Of TaskData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Display_Flag", EnumValue.IsVisible.NotVisible)
        })

        'SQL取得
        Dim sql As String = Constant.GET_ARCHIVED_TASKS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'タスクリストに変換
            Dim taskList As List(Of TaskData) = DtToTaskList(dt)

            Return taskList
        End Using

    End Function

End Class
