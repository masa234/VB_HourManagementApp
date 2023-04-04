<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateTask
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
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.TxtSummary = New System.Windows.Forms.TextBox()
        Me.LblSummary = New System.Windows.Forms.Label()
        Me.TxtHour = New System.Windows.Forms.TextBox()
        Me.LblHour = New System.Windows.Forms.Label()
        Me.TxtTaskName = New System.Windows.Forms.TextBox()
        Me.LblTaskName = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnUpdateTask = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(106, 491)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(121, 23)
        Me.CmbStatus.TabIndex = 79
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(103, 453)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 15)
        Me.LblStatus.TabIndex = 78
        Me.LblStatus.Text = "状態"
        '
        'TxtSummary
        '
        Me.TxtSummary.Location = New System.Drawing.Point(106, 329)
        Me.TxtSummary.Multiline = True
        Me.TxtSummary.Name = "TxtSummary"
        Me.TxtSummary.Size = New System.Drawing.Size(432, 100)
        Me.TxtSummary.TabIndex = 77
        '
        'LblSummary
        '
        Me.LblSummary.AutoSize = True
        Me.LblSummary.Location = New System.Drawing.Point(103, 283)
        Me.LblSummary.Name = "LblSummary"
        Me.LblSummary.Size = New System.Drawing.Size(37, 15)
        Me.LblSummary.TabIndex = 76
        Me.LblSummary.Text = "概要"
        '
        'TxtHour
        '
        Me.TxtHour.Location = New System.Drawing.Point(106, 219)
        Me.TxtHour.Name = "TxtHour"
        Me.TxtHour.Size = New System.Drawing.Size(432, 22)
        Me.TxtHour.TabIndex = 75
        '
        'LblHour
        '
        Me.LblHour.AutoSize = True
        Me.LblHour.Location = New System.Drawing.Point(103, 182)
        Me.LblHour.Name = "LblHour"
        Me.LblHour.Size = New System.Drawing.Size(37, 15)
        Me.LblHour.TabIndex = 74
        Me.LblHour.Text = "工数"
        '
        'TxtTaskName
        '
        Me.TxtTaskName.Location = New System.Drawing.Point(106, 129)
        Me.TxtTaskName.Name = "TxtTaskName"
        Me.TxtTaskName.Size = New System.Drawing.Size(432, 22)
        Me.TxtTaskName.TabIndex = 73
        '
        'LblTaskName
        '
        Me.LblTaskName.AutoSize = True
        Me.LblTaskName.Location = New System.Drawing.Point(103, 88)
        Me.LblTaskName.Name = "LblTaskName"
        Me.LblTaskName.Size = New System.Drawing.Size(53, 15)
        Me.LblTaskName.TabIndex = 72
        Me.LblTaskName.Text = "タスク名"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(225, 535)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 81
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnUpdateTask
        '
        Me.BtnUpdateTask.Location = New System.Drawing.Point(395, 535)
        Me.BtnUpdateTask.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateTask.Name = "BtnUpdateTask"
        Me.BtnUpdateTask.Size = New System.Drawing.Size(143, 43)
        Me.BtnUpdateTask.TabIndex = 80
        Me.BtnUpdateTask.Text = "更新"
        Me.BtnUpdateTask.UseVisualStyleBackColor = True
        '
        'FrmUpdateTask
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 603)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnUpdateTask)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.TxtSummary)
        Me.Controls.Add(Me.LblSummary)
        Me.Controls.Add(Me.TxtHour)
        Me.Controls.Add(Me.LblHour)
        Me.Controls.Add(Me.TxtTaskName)
        Me.Controls.Add(Me.LblTaskName)
        Me.Name = "FrmUpdateTask"
        Me.Text = "FrmUpdateTask"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents TxtSummary As TextBox
    Friend WithEvents LblSummary As Label
    Friend WithEvents TxtHour As TextBox
    Friend WithEvents LblHour As Label
    Friend WithEvents TxtTaskName As TextBox
    Friend WithEvents LblTaskName As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnUpdateTask As Button
End Class
