Imports System.Data.SqlClient

Public Class Request

    ''' <summary>
    ''' リクエスト登録
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function InsertRequest(ByVal projectName As String,
                                         ByVal loginUserID As Long) As Boolean

        'プロジェクト名をプロジェクトIDにする
        Dim projectID As Long = Project.ProjectNameToID(projectName)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Project_Id", projectID),
            New SqlParameter("ProjectName", projectName),
            New SqlParameter("User_Id", loginUserID),
            New SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
        })

        'SQL取得
        Dim sql As String = Constant.INSERT_REQUEST_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

        Return True

    End Function


    ''' <summary>
    ''' リクエストが存在するかどうか?
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function IsExistsRequest() As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
        })

        'SQL取得
        Dim sql As String = Constant.GET_REQUEST_COUNT_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(件数)を取得
        Dim requestCount As Long = db.ExecuteScalar(sql, paramList)

        '件数が1件以上の場合
        If 1 <= requestCount Then
            Return True
        End If

        Return False

    End Function


    ''' <summary>
    ''' 通知
    ''' </summary>
    ''' 2023/04/03
    Public Shared Sub Notification()

        'リクエストリストを取得
        Dim requestList As List(Of RequestData) = GetRequestList()

        '通知文言を作成
        Dim messageStr As String = GetNotificationStr(requestList)

        '通知
        MessageBox.Show(messageStr,
                        Constant.CONFIRM,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub


    ''' <summary>
    ''' リクエストリスト取得
    ''' </summary>
    ''' 2023/04/03
    Private Shared Function GetRequestList() As List(Of RequestData)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("IsNotification", EnumValue.IsNotification.NotNotified)
        })

        'SQL取得
        Dim sql As String = Constant.GET_NOT_NOTIFIED_REQUEST_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データ)を取得
        Using dt = db.GetDt(sql, paramList)
            'リクエストリストに変換
            Dim requestList As List(Of RequestData) = DtToRequestList(dt)

            Return requestList
        End Using

    End Function


    ''' <summary>
    ''' データテーブルをリクエストリストに変換する
    ''' </summary>
    ''' 2023/04/03
    Private Shared Function DtToRequestList(ByVal dt As DataTable) As List(Of RequestData)

        'リスト作成
        Dim requestList As New List(Of RequestData)

        'データテーブルの行数分繰り返す
        For Each row In dt.Rows
            'インスタンス化
            Dim requestData As New RequestData With {
                .UserName = User.IDToUserName(row("User_Id").ToString()), 'ユーザ名
                .ProjectName = row("ProjectName").ToString()              'プロジェクト名
            }

            'リストに追加
            requestList.Add(requestData)
        Next row

        Return requestList

    End Function


    ''' <summary>
    ''' 通知文言を作成
    ''' </summary>
    ''' 2023/04/03
    Private Shared Function GetNotificationStr(ByVal requestList) As String

        '文言初期化
        Dim retStr As String = String.Empty

        retStr = retStr + "プロジェクト応募が届いています。" + Environment.NewLine
        retStr = retStr + "【" + requestList.Count.ToString() + "件】" + Environment.NewLine

        'リクエストリストの要素数だけ繰り返す
        For Each request In requestList
            '文言追加
            retStr = retStr + "【プロジェクト名】" + request.ProjectName + Environment.NewLine
            retStr = retStr + "【ユーザ名】" + request.UserName + Environment.NewLine
        Next request

        Return retStr

    End Function


    ''' <summary>
    ''' 通知状態を更新
    ''' </summary>
    ''' 2023/04/03
    Public Shared Sub UpdateNotification()

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("IsNotification", EnumValue.IsNotification.Notified)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_ALL_NOTIFICATION_SQL

        'インスタンス化
        Dim db As New DB()

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

    End Sub

End Class
