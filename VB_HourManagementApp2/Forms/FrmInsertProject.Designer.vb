<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertProject
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
        Me.TxtProjectName = New System.Windows.Forms.TextBox()
        Me.LblProjectName = New System.Windows.Forms.Label()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.DateEndDate = New System.Windows.Forms.DateTimePicker()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.DateStartDate = New System.Windows.Forms.DateTimePicker()
        Me.LblStartDate = New System.Windows.Forms.Label()
        Me.TxtSummary = New System.Windows.Forms.TextBox()
        Me.LblSummary = New System.Windows.Forms.Label()
        Me.TxtHour = New System.Windows.Forms.TextBox()
        Me.LblHour = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtntInsertProject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtProjectName
        '
        Me.TxtProjectName.Location = New System.Drawing.Point(84, 115)
        Me.TxtProjectName.Name = "TxtProjectName"
        Me.TxtProjectName.Size = New System.Drawing.Size(432, 22)
        Me.TxtProjectName.TabIndex = 66
        '
        'LblProjectName
        '
        Me.LblProjectName.AutoSize = True
        Me.LblProjectName.Location = New System.Drawing.Point(81, 72)
        Me.LblProjectName.Name = "LblProjectName"
        Me.LblProjectName.Size = New System.Drawing.Size(86, 15)
        Me.LblProjectName.TabIndex = 65
        Me.LblProjectName.Text = "プロジェクト名"
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Location = New System.Drawing.Point(84, 641)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(121, 23)
        Me.CmbStatus.TabIndex = 64
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(81, 603)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 15)
        Me.LblStatus.TabIndex = 63
        Me.LblStatus.Text = "状態"
        '
        'DateEndDate
        '
        Me.DateEndDate.Location = New System.Drawing.Point(84, 552)
        Me.DateEndDate.Name = "DateEndDate"
        Me.DateEndDate.Size = New System.Drawing.Size(200, 22)
        Me.DateEndDate.TabIndex = 62
        '
        'LblEndDate
        '
        Me.LblEndDate.AutoSize = True
        Me.LblEndDate.Location = New System.Drawing.Point(81, 503)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(67, 15)
        Me.LblEndDate.TabIndex = 61
        Me.LblEndDate.Text = "終了日時"
        '
        'DateStartDate
        '
        Me.DateStartDate.Location = New System.Drawing.Point(84, 446)
        Me.DateStartDate.Name = "DateStartDate"
        Me.DateStartDate.Size = New System.Drawing.Size(200, 22)
        Me.DateStartDate.TabIndex = 60
        '
        'LblStartDate
        '
        Me.LblStartDate.AutoSize = True
        Me.LblStartDate.Location = New System.Drawing.Point(81, 402)
        Me.LblStartDate.Name = "LblStartDate"
        Me.LblStartDate.Size = New System.Drawing.Size(67, 15)
        Me.LblStartDate.TabIndex = 59
        Me.LblStartDate.Text = "開始日時"
        '
        'TxtSummary
        '
        Me.TxtSummary.Location = New System.Drawing.Point(84, 289)
        Me.TxtSummary.Multiline = True
        Me.TxtSummary.Name = "TxtSummary"
        Me.TxtSummary.Size = New System.Drawing.Size(432, 100)
        Me.TxtSummary.TabIndex = 58
        '
        'LblSummary
        '
        Me.LblSummary.AutoSize = True
        Me.LblSummary.Location = New System.Drawing.Point(81, 243)
        Me.LblSummary.Name = "LblSummary"
        Me.LblSummary.Size = New System.Drawing.Size(37, 15)
        Me.LblSummary.TabIndex = 57
        Me.LblSummary.Text = "概要"
        '
        'TxtHour
        '
        Me.TxtHour.Location = New System.Drawing.Point(84, 195)
        Me.TxtHour.Name = "TxtHour"
        Me.TxtHour.Size = New System.Drawing.Size(432, 22)
        Me.TxtHour.TabIndex = 56
        '
        'LblHour
        '
        Me.LblHour.AutoSize = True
        Me.LblHour.Location = New System.Drawing.Point(81, 158)
        Me.LblHour.Name = "LblHour"
        Me.LblHour.Size = New System.Drawing.Size(37, 15)
        Me.LblHour.TabIndex = 55
        Me.LblHour.Text = "工数"
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(183, 701)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 68
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtntInsertProject
        '
        Me.BtntInsertProject.Location = New System.Drawing.Point(373, 701)
        Me.BtntInsertProject.Margin = New System.Windows.Forms.Padding(2)
        Me.BtntInsertProject.Name = "BtntInsertProject"
        Me.BtntInsertProject.Size = New System.Drawing.Size(143, 43)
        Me.BtntInsertProject.TabIndex = 67
        Me.BtntInsertProject.Text = "登録"
        Me.BtntInsertProject.UseVisualStyleBackColor = True
        '
        'FrmInsertProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 855)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtntInsertProject)
        Me.Controls.Add(Me.TxtProjectName)
        Me.Controls.Add(Me.LblProjectName)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.DateEndDate)
        Me.Controls.Add(Me.LblEndDate)
        Me.Controls.Add(Me.DateStartDate)
        Me.Controls.Add(Me.LblStartDate)
        Me.Controls.Add(Me.TxtSummary)
        Me.Controls.Add(Me.LblSummary)
        Me.Controls.Add(Me.TxtHour)
        Me.Controls.Add(Me.LblHour)
        Me.Name = "FrmInsertProject"
        Me.Text = "FrmInsertProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtProjectName As TextBox
    Friend WithEvents LblProjectName As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents DateEndDate As DateTimePicker
    Friend WithEvents LblEndDate As Label
    Friend WithEvents DateStartDate As DateTimePicker
    Friend WithEvents LblStartDate As Label
    Friend WithEvents TxtSummary As TextBox
    Friend WithEvents LblSummary As Label
    Friend WithEvents TxtHour As TextBox
    Friend WithEvents LblHour As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtntInsertProject As Button
End Class
