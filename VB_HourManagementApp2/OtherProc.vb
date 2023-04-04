Public Class OtherProc

    ''' <summary>
    ''' 状態のリストを取得
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function GetStatusList() As List(Of String)

        '状態のリスト
        Return New List(Of String)(New String() {
            "未着手",
            "着手中",
            "完了"
        })

    End Function


    ''' <summary>
    ''' 状態をInt型に変換する
    ''' </summary>
    ''' 2023/03/21
    Public Shared Function StatusToInt(ByVal strStatus As String) As Integer

        '値によって分岐させる
        Select Case strStatus
            Case "未着手"
                Return EnumValue.Status.NotBegin
            Case "着手中"
                Return EnumValue.Status.Begin
            Case "完了"
                Return EnumValue.Status.Done
        End Select

        Return 0

    End Function


    ''' <summary>
    ''' 状態をString型に変換する
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function StatusToString(ByVal intStatus As String) As String

        '値によって分岐させる
        Select Case intStatus
            Case EnumValue.Status.NotBegin
                Return "未着手"
            Case EnumValue.Status.Begin
                Return "着手中"
            Case EnumValue.Status.Done
                Return "完了"
        End Select

        Return 0

    End Function

End Class
