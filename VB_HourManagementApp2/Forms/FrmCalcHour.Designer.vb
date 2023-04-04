<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalcHour
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
        Me.LblProjectHour = New System.Windows.Forms.Label()
        Me.LblHour = New System.Windows.Forms.Label()
        Me.LblProject = New System.Windows.Forms.Label()
        Me.CmbProject = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(355, 320)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 58
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblProjectHour
        '
        Me.LblProjectHour.AutoSize = True
        Me.LblProjectHour.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblProjectHour.Location = New System.Drawing.Point(401, 191)
        Me.LblProjectHour.Name = "LblProjectHour"
        Me.LblProjectHour.Size = New System.Drawing.Size(59, 20)
        Me.LblProjectHour.TabIndex = 57
        Me.LblProjectHour.Text = "0時間"
        '
        'LblHour
        '
        Me.LblHour.AutoSize = True
        Me.LblHour.Location = New System.Drawing.Point(392, 143)
        Me.LblHour.Name = "LblHour"
        Me.LblHour.Size = New System.Drawing.Size(37, 15)
        Me.LblHour.TabIndex = 56
        Me.LblHour.Text = "工数"
        '
        'LblProject
        '
        Me.LblProject.AutoSize = True
        Me.LblProject.Location = New System.Drawing.Point(173, 143)
        Me.LblProject.Name = "LblProject"
        Me.LblProject.Size = New System.Drawing.Size(86, 15)
        Me.LblProject.TabIndex = 55
        Me.LblProject.Text = "プロジェクト名"
        '
        'CmbProject
        '
        Me.CmbProject.FormattingEnabled = True
        Me.CmbProject.Location = New System.Drawing.Point(173, 191)
        Me.CmbProject.Name = "CmbProject"
        Me.CmbProject.Size = New System.Drawing.Size(167, 23)
        Me.CmbProject.TabIndex = 54
        '
        'FrmCalcHour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.LblProjectHour)
        Me.Controls.Add(Me.LblHour)
        Me.Controls.Add(Me.LblProject)
        Me.Controls.Add(Me.CmbProject)
        Me.Name = "FrmCalcHour"
        Me.Text = "FrmCalcHour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents LblProjectHour As Label
    Friend WithEvents LblHour As Label
    Friend WithEvents LblProject As Label
    Friend WithEvents CmbProject As ComboBox
End Class
