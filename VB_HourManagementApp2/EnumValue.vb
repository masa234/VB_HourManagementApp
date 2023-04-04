Public Class EnumValue

    ''' <summary>
    ''' ユーザ種類
    ''' </summary>
    Public Enum UserType
        Admin = 1
        Normal = 2
    End Enum


    ''' <summary>
    ''' ロックタイプ
    ''' </summary>
    Public Enum IsLock
        NotLock = 0
        Locked = 1
    End Enum


    ''' <summary>
    ''' 表示非表示
    ''' </summary>
    Public Enum IsVisible
        NotVisible = 0
        Visible = 1
    End Enum


    ''' <summary>
    ''' 状態
    ''' </summary>
    Public Enum Status
        NotBegin = 1
        Begin = 2
        Done = 3
    End Enum


    ''' <summary>
    ''' 通知したかどうか
    ''' </summary>
    Public Enum IsNotification
        NotNotified = 0
        Notified = 1
    End Enum

End Class
