Imports System.Data.SqlClient

Public Class DB
    Implements IDisposable

    ''' <summary>
    ''' コネクション
    ''' </summary>
    Private Property Con As SqlConnection

    ''' <summary>
    ''' トランザクション
    ''' </summary>
    Private Property Tran As SqlTransaction

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' 2023/03/28
    Public Sub New()

        'コネクションを開く
        ConOpen(Constant.CONNECTION_STRING)

        'トランザクション開始
        BeginTran()

    End Sub


    ''' <summary>
    ''' コネクションを開く
    ''' </summary>
    ''' 2023/03/28
    Private Sub ConOpen(ByVal conStr As String)

        'コネクションが存在しない場合
        If Me.Con Is Nothing Then
            'コネクションを作成
            Me.Con = New SqlConnection With {
                .ConnectionString = conStr
            }

            'コネクションを開く
            Me.Con.Open()
        End If

    End Sub


    ''' <summary>
    ''' トランザクション開始
    ''' </summary>
    ''' 2023/03/28
    Private Sub BeginTran()

        'トランザクションが存在しない場合
        If Me.Tran Is Nothing Then
            'トランザクション開始
            Me.Tran = Me.Con.BeginTransaction()
        End If

    End Sub


    ''' <summary>
    ''' ロールバック
    ''' </summary>
    ''' 2023/03/28
    Private Sub RollBack()

        'トランザクションが存在する場合
        If Me.Tran IsNot Nothing Then
            'ロールバック
            Me.Tran.Rollback()
        End If

    End Sub


    ''' <summary>
    ''' コミット
    ''' </summary>
    ''' 2023/03/28
    Private Sub Commit()

        'トランザクションが存在する場合
        If Me.Tran IsNot Nothing Then
            'コミット
            Me.Tran.Commit()
        End If

    End Sub


    ''' <summary>
    ''' コマンドを取得
    ''' </summary>
    ''' 2023/03/28
    Private Function GetCmd(ByVal sql As String) As SqlCommand

        'コマンドを取得
        Return New SqlCommand(sql, Me.Con, Me.Tran)

    End Function


    ''' <summary>
    ''' INSERT, UPDATE, DELETE用
    ''' </summary>
    ''' 2023/03/28
    Public Sub ExecuteNonQuery(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing)

        Try
            'コマンド作成
            Using cmd = GetCmd(sql)
                'パラメータが存在する場合
                If paramList IsNot Nothing Then
                    'パラメータ追加
                    cmd.Parameters.AddRange(paramList.ToArray)
                End If

                'SQL実行
                cmd.ExecuteNonQuery()

                'コミット
                Commit()

            End Using

        Catch ex As Exception

            'ロールバック
            RollBack()

            '例外を投げる
            Throw

        End Try

    End Sub



    ''' <summary>
    ''' SELECT COUNT用
    ''' </summary>
    ''' 2023/03/28
    Public Function ExecuteScalar(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As Long

        Dim result As Long

        'コマンド作成
        Using cmd = GetCmd(sql)
            'パラメータが存在する場合
            If paramList IsNot Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray)
            End If

            '実行結果(件数)を取得
            Long.TryParse(cmd.ExecuteScalar().ToString(), result)
            Return result
        End Using

    End Function


    ''' <summary>
    ''' SELECT用
    ''' </summary>
    ''' 2023/03/28
    Public Function ExecuteReader(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As SqlDataReader

        'コマンド作成
        Using cmd = GetCmd(sql)
            'パラメータが存在しない場合
            If paramList IsNot Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray)
            End If

            '実行結果(リーダー)を取得
            Return cmd.ExecuteReader()
        End Using

    End Function


    ''' <summary>
    ''' SELECT用
    ''' </summary>
    ''' 2023/03/28
    Public Function GetDt(ByVal sql As String,
                               Optional ByVal paramList As List(Of SqlParameter) = Nothing) As DataTable

        'コマンド作成
        Using cmd = GetCmd(sql)
            'パラメータが存在しない場合
            If paramList IsNot Nothing Then
                'パラメータ追加
                cmd.Parameters.AddRange(paramList.ToArray)
            End If

            'アダプター作成
            Using adapter = New SqlDataAdapter(cmd)
                Dim dt As New DataTable

                adapter.Fill(dt)

                Return dt
            End Using

        End Using

    End Function

    '自動生成コード
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: マネージド状態を破棄します (マネージド オブジェクト)
            End If

            ' TODO: アンマネージド リソース (アンマネージド オブジェクト) を解放し、ファイナライザーをオーバーライドします
            ' TODO: 大きなフィールドを null に設定します
            disposedValue = True
        End If
    End Sub

    ' ' TODO: 'Dispose(disposing As Boolean)' にアンマネージド リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします
    ' Protected Overrides Sub Finalize()
    '     ' このコードを変更しないでください。クリーンアップ コードを 'Dispose(disposing As Boolean)' メソッドに記述します
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose

        'コネクションが存在する場合
        If Me.Con IsNot Nothing Then
            'コネクションが開いている場合
            If Me.Con.State = ConnectionState.Connecting Then
                'コネクションを閉じる
                Me.Con.Close()
                '破棄
                Me.Con = Nothing
            End If
        End If

        'トランザクションが存在する場合
        If Me.Tran Is Nothing Then
            '破棄
            Me.Tran = Nothing
        End If

        ' このコードを変更しないでください。クリーンアップ コードを 'Dispose(disposing As Boolean)' メソッドに記述します
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
