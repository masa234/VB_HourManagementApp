<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnReleaseLock = New System.Windows.Forms.Button()
        Me.BtnInsertProject = New System.Windows.Forms.Button()
        Me.BtnProjects = New System.Windows.Forms.Button()
        Me.BtnArchivedTasks = New System.Windows.Forms.Button()
        Me.BtnRequestProject = New System.Windows.Forms.Button()
        Me.BtnProjectWikis = New System.Windows.Forms.Button()
        Me.BtnCalcHour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(603, 355)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(129, 55)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "ログアウト"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnReleaseLock
        '
        Me.BtnReleaseLock.Location = New System.Drawing.Point(29, 36)
        Me.BtnReleaseLock.Name = "BtnReleaseLock"
        Me.BtnReleaseLock.Size = New System.Drawing.Size(129, 55)
        Me.BtnReleaseLock.TabIndex = 4
        Me.BtnReleaseLock.Text = "アカウントロック解除"
        Me.BtnReleaseLock.UseVisualStyleBackColor = True
        '
        'BtnInsertProject
        '
        Me.BtnInsertProject.Location = New System.Drawing.Point(29, 115)
        Me.BtnInsertProject.Name = "BtnInsertProject"
        Me.BtnInsertProject.Size = New System.Drawing.Size(129, 55)
        Me.BtnInsertProject.TabIndex = 5
        Me.BtnInsertProject.Text = "プロジェクト登録"
        Me.BtnInsertProject.UseVisualStyleBackColor = True
        '
        'BtnProjects
        '
        Me.BtnProjects.Location = New System.Drawing.Point(175, 115)
        Me.BtnProjects.Name = "BtnProjects"
        Me.BtnProjects.Size = New System.Drawing.Size(129, 55)
        Me.BtnProjects.TabIndex = 6
        Me.BtnProjects.Text = "プロジェクト一覧"
        Me.BtnProjects.UseVisualStyleBackColor = True
        '
        'BtnArchivedTasks
        '
        Me.BtnArchivedTasks.Location = New System.Drawing.Point(322, 115)
        Me.BtnArchivedTasks.Name = "BtnArchivedTasks"
        Me.BtnArchivedTasks.Size = New System.Drawing.Size(129, 55)
        Me.BtnArchivedTasks.TabIndex = 7
        Me.BtnArchivedTasks.Text = "アーカイブしたタスク一覧"
        Me.BtnArchivedTasks.UseVisualStyleBackColor = True
        '
        'BtnRequestProject
        '
        Me.BtnRequestProject.Location = New System.Drawing.Point(29, 205)
        Me.BtnRequestProject.Name = "BtnRequestProject"
        Me.BtnRequestProject.Size = New System.Drawing.Size(129, 55)
        Me.BtnRequestProject.TabIndex = 8
        Me.BtnRequestProject.Text = "プロジェクト応募"
        Me.BtnRequestProject.UseVisualStyleBackColor = True
        '
        'BtnProjectWikis
        '
        Me.BtnProjectWikis.Location = New System.Drawing.Point(29, 289)
        Me.BtnProjectWikis.Name = "BtnProjectWikis"
        Me.BtnProjectWikis.Size = New System.Drawing.Size(129, 55)
        Me.BtnProjectWikis.TabIndex = 9
        Me.BtnProjectWikis.Text = "Wiki一覧"
        Me.BtnProjectWikis.UseVisualStyleBackColor = True
        '
        'BtnCalcHour
        '
        Me.BtnCalcHour.Location = New System.Drawing.Point(175, 289)
        Me.BtnCalcHour.Name = "BtnCalcHour"
        Me.BtnCalcHour.Size = New System.Drawing.Size(129, 55)
        Me.BtnCalcHour.TabIndex = 10
        Me.BtnCalcHour.Text = "工数計算"
        Me.BtnCalcHour.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCalcHour)
        Me.Controls.Add(Me.BtnProjectWikis)
        Me.Controls.Add(Me.BtnRequestProject)
        Me.Controls.Add(Me.BtnArchivedTasks)
        Me.Controls.Add(Me.BtnProjects)
        Me.Controls.Add(Me.BtnInsertProject)
        Me.Controls.Add(Me.BtnReleaseLock)
        Me.Controls.Add(Me.BtnLogout)
        Me.Name = "FrmMain"
        Me.Text = "FrmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnReleaseLock As Button
    Friend WithEvents BtnInsertProject As Button
    Friend WithEvents BtnProjects As Button
    Friend WithEvents BtnArchivedTasks As Button
    Friend WithEvents BtnRequestProject As Button
    Friend WithEvents BtnProjectWikis As Button
    Friend WithEvents BtnCalcHour As Button
End Class
