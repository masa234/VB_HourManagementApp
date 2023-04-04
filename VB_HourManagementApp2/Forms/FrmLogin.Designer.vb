<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(182, 257)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(385, 22)
        Me.TxtPassword.TabIndex = 18
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(182, 170)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(385, 22)
        Me.TxtUserName.TabIndex = 17
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(436, 318)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(131, 53)
        Me.BtnLogin.TabIndex = 16
        Me.BtnLogin.Text = "ログイン"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(179, 226)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(64, 15)
        Me.LblPassword.TabIndex = 15
        Me.LblPassword.Text = "パスワード"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(179, 137)
        Me.LblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(58, 15)
        Me.LblUserName.TabIndex = 14
        Me.LblUserName.Text = "ユーザ名"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUserName)
        Me.Name = "FrmLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUserName As Label
End Class
