Imports System.Data.SqlClient

Public Class User

    ''' <summary>
    ''' ユーザが存在するどうか?
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function IsExistsUser(ByVal userName As String,
                                       ByVal password As String) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password)
        })

        'SQL取得
        Dim sql As String = Constant.GET_USER_COUNT_SQL

        'インスタンス化
        Dim db As New DB

        '実行結果(件数)を取得
        Dim userCount As Long = db.ExecuteScalar(sql, paramList)

        '1件を超えているかどうか?
        If 1 <= userCount Then
            Return True
        End If

        Return False

    End Function


    ''' <summary>
    ''' ユーザ名が存在するどうか?
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function IsExistsUserName(ByVal userName As String) As Boolean

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_USERNAME_COUNT_SQL

        'インスタンス化
        Dim db As New DB

        '実行結果(件数)を取得
        Dim userCount As Long = db.ExecuteScalar(sql, paramList)

        '件数が1件以上かどうか?
        If 1 <= userCount Then
            Return True
        End If

        Return False

    End Function


    ''' <summary>
    ''' ユーザID取得
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function GetUserID(ByVal userName As String,
                                       ByVal password As String) As Long

        Dim result As Long

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("UserName", userName),
            New SqlParameter("Password", password)
        })

        'SQL取得
        Dim sql As String = Constant.GET_USERID_SQL

        'インスタンス化
        Dim db As New DB

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
    ''' ロック状態を更新
    ''' </summary>
    ''' 2023/03/28
    Public Shared Sub UpdateLock(ByVal userName As String,
                                      ByVal updateIsLock As Integer)

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("LockFlag", updateIsLock),
            New SqlParameter("UserName", userName)
        })

        'SQL取得
        Dim sql As String = Constant.UPDATE_LOCKFLAG_SQL

        'インスタンス化
        Dim db As New DB

        'SQL実行
        db.ExecuteNonQuery(sql, paramList)

    End Sub


    ''' <summary>
    ''' ロックされているかどうか?
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function IsLockedUserName(ByVal userName As String) As Boolean

        Dim result As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("LockFlag", EnumValue.IsLock.Locked),
            New SqlParameter("UserName", userName)
        })

        'SQL取得
        Dim sql As String = Constant.GET_LOCKFLAG_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'Int型に変換
                Integer.TryParse(reader(0).ToString(), result)
                'ロックされているかどうか?
                If result = EnumValue.IsLock.Locked Then
                    Return True
                End If
            End While
        End Using

        Return False

    End Function


    ''' <summary>
    ''' 管理者かどうか?
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function IsAdmin(ByVal userID As Long) As Boolean

        Dim result As Integer

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", userID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_ADMIN_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(リーダー)を取得
        Using reader = db.ExecuteReader(sql, paramList)
            '読み込める間、繰り返す
            While reader.Read()
                'Int型に変換
                Integer.TryParse(reader(0).ToString(), result)
                '管理者かどうか？
                If result = EnumValue.UserType.Admin Then
                    Return True
                End If
            End While
        End Using

        Return False

    End Function


    ''' <summary>
    ''' ロックされているユーザ一覧を取得
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function GetLockedUsers() As DataTable

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("LockFlag", EnumValue.IsLock.Locked)
        })

        'SQL取得
        Dim sql As String = Constant.GET_LOCKED_USERS_SQL

        'インスタンス化
        Dim db As New DB()

        '実行結果(データテーブル)を取得
        Return db.GetDt(sql, paramList)

    End Function


    ''' <summary>
    ''' IDをユーザ名に変換する
    ''' </summary>
    ''' 2023/04/03
    Public Shared Function IDToUserName(ByVal userID As Long) As String

        'パラム設定
        Dim paramList As New List(Of SqlParameter)(New SqlParameter() {
            New SqlParameter("Id", userID)
        })

        'SQL取得
        Dim sql As String = Constant.GET_USERNAME_SQL

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

End Class
