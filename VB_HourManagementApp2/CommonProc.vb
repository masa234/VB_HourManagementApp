Imports System.Data.SqlClient

Public Class CommonProc


    ''' <summary>
    ''' 文字列がおさまっているかどうか
    ''' </summary>
    ''' 2023/03/28
    Public Shared Function IsFitInText(ByVal str As String,
                                        ByVal maxLength As Long) As Boolean

        '空の場合
        If String.IsNullOrEmpty(str) Then
            Return False
        End If

        '制限文字列を超えている場合
        If maxLength <= str.Length Then
            Return False
        End If

        Return True

    End Function


    ''' <summary>
    ''' 画面遷移
    ''' </summary>
    ''' 2023/03/28
    Public Shared Sub HideAndOpen(ByVal openedForm As Form,
                                  ByVal openForm As Form)

        '既に開いている画面を非表示にする
        openedForm.Hide()

        '画面を表示
        openForm.Show()

    End Sub


    ''' <summary>
    ''' コンボボックス設定
    ''' </summary>
    ''' 2023/03/29
    Public Shared Sub SetCmb(ByVal cmb As ComboBox,
                             ByVal cmbTxtList As List(Of String))

        'リストの要素数だけ繰り返す
        For Each cmbTxt In cmbTxtList
            'コンボボックスに追加
            cmb.Items.Add(cmbTxt)
        Next cmbTxt

    End Sub


    ''' <summary>
    ''' 安全にInt型に変換する
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function SafeCastInt(ByVal str As String) As Integer

        Dim result As Integer

        'Int型に変換
        Integer.TryParse(str, result)

        '0でない場合
        If result <> 0 Then
            Return result
        End If

        Return 0

    End Function


    ''' <summary>
    ''' 入力されているかどうか?
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function IsInputed(ByVal str As String) As Boolean

        '空の場合
        If String.IsNullOrEmpty(str) Then
            Return False
        End If

        Return True

    End Function


    ''' <summary>
    ''' コンボボックスの選択肢内かどうか?
    ''' </summary>
    ''' 2023/03/29
    Public Shared Function IsTextInCmb(ByVal cmb As ComboBox,
                                       ByVal str As String) As Boolean

        'リスト作成
        Dim cmbTxtList As New List(Of String)

        'コンボボックスの要素数だけ繰り返す
        For Each cmbTxt In cmb.Items
            'リストに追加
            cmbTxtList.Add(cmbTxt)
        Next cmbTxt

        'リストに存在するかどうか?
        If cmbTxtList.Contains(str) Then
            Return True
        End If

        Return False

    End Function

End Class
