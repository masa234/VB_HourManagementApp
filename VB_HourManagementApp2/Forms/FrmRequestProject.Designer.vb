<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequestProject
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
        Me.BtnRequestProject = New System.Windows.Forms.Button()
        Me.LblProject = New System.Windows.Forms.Label()
        Me.CmbProject = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(178, 301)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 69
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnRequestProject
        '
        Me.BtnRequestProject.Location = New System.Drawing.Point(348, 301)
        Me.BtnRequestProject.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRequestProject.Name = "BtnRequestProject"
        Me.BtnRequestProject.Size = New System.Drawing.Size(143, 43)
        Me.BtnRequestProject.TabIndex = 68
        Me.BtnRequestProject.Text = "応募"
        Me.BtnRequestProject.UseVisualStyleBackColor = True
        '
        'LblProject
        '
        Me.LblProject.AutoSize = True
        Me.LblProject.Location = New System.Drawing.Point(324, 148)
        Me.LblProject.Name = "LblProject"
        Me.LblProject.Size = New System.Drawing.Size(86, 15)
        Me.LblProject.TabIndex = 67
        Me.LblProject.Text = "プロジェクト名"
        '
        'CmbProject
        '
        Me.CmbProject.FormattingEnabled = True
        Me.CmbProject.Location = New System.Drawing.Point(324, 196)
        Me.CmbProject.Name = "CmbProject"
        Me.CmbProject.Size = New System.Drawing.Size(167, 23)
        Me.CmbProject.TabIndex = 66
        '
        'FrmRequestProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnRequestProject)
        Me.Controls.Add(Me.LblProject)
        Me.Controls.Add(Me.CmbProject)
        Me.Name = "FrmRequestProject"
        Me.Text = "FrmRequestProject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnRequestProject As Button
    Friend WithEvents LblProject As Label
    Friend WithEvents CmbProject As ComboBox
End Class
