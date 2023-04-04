<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReleaseLock
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.DgvLockedUsers = New System.Windows.Forms.DataGridView()
        Me.txtUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReleaseLock = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvLockedUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(482, 337)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 44
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvLockedUsers
        '
        Me.DgvLockedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLockedUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtUserName, Me.txtPassword, Me.btnReleaseLock, Me.txtID})
        Me.DgvLockedUsers.Location = New System.Drawing.Point(176, 70)
        Me.DgvLockedUsers.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvLockedUsers.Name = "DgvLockedUsers"
        Me.DgvLockedUsers.RowHeadersWidth = 62
        Me.DgvLockedUsers.RowTemplate.Height = 27
        Me.DgvLockedUsers.Size = New System.Drawing.Size(436, 223)
        Me.DgvLockedUsers.TabIndex = 43
        '
        'txtUserName
        '
        Me.txtUserName.DataPropertyName = "UserName"
        Me.txtUserName.HeaderText = "ユーザ名"
        Me.txtUserName.MinimumWidth = 8
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Width = 150
        '
        'txtPassword
        '
        Me.txtPassword.DataPropertyName = "Password"
        Me.txtPassword.HeaderText = "パスワード"
        Me.txtPassword.MinimumWidth = 8
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Visible = False
        Me.txtPassword.Width = 150
        '
        'btnReleaseLock
        '
        Me.btnReleaseLock.HeaderText = "ロック解除"
        Me.btnReleaseLock.MinimumWidth = 8
        Me.btnReleaseLock.Name = "btnReleaseLock"
        Me.btnReleaseLock.Width = 150
        '
        'txtID
        '
        Me.txtID.DataPropertyName = "Id"
        Me.txtID.HeaderText = "ID"
        Me.txtID.MinimumWidth = 8
        Me.txtID.Name = "txtID"
        Me.txtID.Visible = False
        Me.txtID.Width = 150
        '
        'FrmReleaseLock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvLockedUsers)
        Me.Name = "FrmReleaseLock"
        Me.Text = "FrmReleaseLock"
        CType(Me.DgvLockedUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvLockedUsers As DataGridView
    Friend WithEvents txtUserName As DataGridViewTextBoxColumn
    Friend WithEvents txtPassword As DataGridViewTextBoxColumn
    Friend WithEvents btnReleaseLock As DataGridViewButtonColumn
    Friend WithEvents txtID As DataGridViewTextBoxColumn
End Class
