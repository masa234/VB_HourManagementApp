<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjectWikis
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
        Me.BtnUpdateWiki = New System.Windows.Forms.Button()
        Me.LblWiki = New System.Windows.Forms.Label()
        Me.TxtWiki = New System.Windows.Forms.TextBox()
        Me.LblProject = New System.Windows.Forms.Label()
        Me.CmbProject = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(393, 657)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 73
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnUpdateWiki
        '
        Me.BtnUpdateWiki.Location = New System.Drawing.Point(563, 657)
        Me.BtnUpdateWiki.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateWiki.Name = "BtnUpdateWiki"
        Me.BtnUpdateWiki.Size = New System.Drawing.Size(143, 43)
        Me.BtnUpdateWiki.TabIndex = 72
        Me.BtnUpdateWiki.Text = "更新"
        Me.BtnUpdateWiki.UseVisualStyleBackColor = True
        '
        'LblWiki
        '
        Me.LblWiki.AutoSize = True
        Me.LblWiki.Location = New System.Drawing.Point(94, 141)
        Me.LblWiki.Name = "LblWiki"
        Me.LblWiki.Size = New System.Drawing.Size(31, 15)
        Me.LblWiki.TabIndex = 71
        Me.LblWiki.Text = "Wiki"
        '
        'TxtWiki
        '
        Me.TxtWiki.Location = New System.Drawing.Point(94, 170)
        Me.TxtWiki.Multiline = True
        Me.TxtWiki.Name = "TxtWiki"
        Me.TxtWiki.Size = New System.Drawing.Size(612, 453)
        Me.TxtWiki.TabIndex = 70
        '
        'LblProject
        '
        Me.LblProject.AutoSize = True
        Me.LblProject.Location = New System.Drawing.Point(94, 52)
        Me.LblProject.Name = "LblProject"
        Me.LblProject.Size = New System.Drawing.Size(86, 15)
        Me.LblProject.TabIndex = 69
        Me.LblProject.Text = "プロジェクト名"
        '
        'CmbProject
        '
        Me.CmbProject.FormattingEnabled = True
        Me.CmbProject.Location = New System.Drawing.Point(94, 100)
        Me.CmbProject.Name = "CmbProject"
        Me.CmbProject.Size = New System.Drawing.Size(612, 23)
        Me.CmbProject.TabIndex = 68
        '
        'FrmProjectWikis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 753)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnUpdateWiki)
        Me.Controls.Add(Me.LblWiki)
        Me.Controls.Add(Me.TxtWiki)
        Me.Controls.Add(Me.LblProject)
        Me.Controls.Add(Me.CmbProject)
        Me.Name = "FrmProjectWikis"
        Me.Text = "FrmProjectWikis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnUpdateWiki As Button
    Friend WithEvents LblWiki As Label
    Friend WithEvents TxtWiki As TextBox
    Friend WithEvents LblProject As Label
    Friend WithEvents CmbProject As ComboBox
End Class
