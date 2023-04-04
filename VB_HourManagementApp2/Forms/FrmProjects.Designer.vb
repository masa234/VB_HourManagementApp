<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjects
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
        Me.DgvProjects = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSummary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnProjectDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnProjectUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnInsertTask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnTasks = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(531, 344)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 55
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvProjects
        '
        Me.DgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtID, Me.TxtProjectName, Me.TxtHour, Me.TxtSummary, Me.TxtStartDate, Me.EndDate, Me.TxtStatus, Me.BtnProjectDelete, Me.BtnProjectUpdate, Me.BtnInsertTask, Me.BtnTasks})
        Me.DgvProjects.Location = New System.Drawing.Point(126, 64)
        Me.DgvProjects.Name = "DgvProjects"
        Me.DgvProjects.RowHeadersWidth = 51
        Me.DgvProjects.RowTemplate.Height = 24
        Me.DgvProjects.Size = New System.Drawing.Size(548, 253)
        Me.DgvProjects.TabIndex = 54
        '
        'txtID
        '
        Me.txtID.DataPropertyName = "Id"
        Me.txtID.HeaderText = "ID"
        Me.txtID.MinimumWidth = 6
        Me.txtID.Name = "txtID"
        Me.txtID.Visible = False
        Me.txtID.Width = 125
        '
        'TxtProjectName
        '
        Me.TxtProjectName.DataPropertyName = "ProjectName"
        Me.TxtProjectName.HeaderText = "プロジェクト名"
        Me.TxtProjectName.MinimumWidth = 6
        Me.TxtProjectName.Name = "TxtProjectName"
        Me.TxtProjectName.Width = 125
        '
        'TxtHour
        '
        Me.TxtHour.DataPropertyName = "Hour"
        Me.TxtHour.HeaderText = "工数"
        Me.TxtHour.MinimumWidth = 6
        Me.TxtHour.Name = "TxtHour"
        Me.TxtHour.Width = 125
        '
        'TxtSummary
        '
        Me.TxtSummary.DataPropertyName = "Summary"
        Me.TxtSummary.HeaderText = "概要"
        Me.TxtSummary.MinimumWidth = 6
        Me.TxtSummary.Name = "TxtSummary"
        Me.TxtSummary.Width = 125
        '
        'TxtStartDate
        '
        Me.TxtStartDate.DataPropertyName = "StartDate"
        Me.TxtStartDate.HeaderText = "開始日時"
        Me.TxtStartDate.MinimumWidth = 6
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.Width = 125
        '
        'EndDate
        '
        Me.EndDate.DataPropertyName = "EndDate"
        Me.EndDate.HeaderText = "終了日時"
        Me.EndDate.MinimumWidth = 6
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Width = 125
        '
        'TxtStatus
        '
        Me.TxtStatus.DataPropertyName = "Status"
        Me.TxtStatus.HeaderText = "状態"
        Me.TxtStatus.MinimumWidth = 6
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Width = 125
        '
        'BtnProjectDelete
        '
        Me.BtnProjectDelete.HeaderText = "削除"
        Me.BtnProjectDelete.MinimumWidth = 6
        Me.BtnProjectDelete.Name = "BtnProjectDelete"
        Me.BtnProjectDelete.Width = 125
        '
        'BtnProjectUpdate
        '
        Me.BtnProjectUpdate.HeaderText = "更新"
        Me.BtnProjectUpdate.MinimumWidth = 6
        Me.BtnProjectUpdate.Name = "BtnProjectUpdate"
        Me.BtnProjectUpdate.Width = 125
        '
        'BtnInsertTask
        '
        Me.BtnInsertTask.HeaderText = "タスク追加"
        Me.BtnInsertTask.MinimumWidth = 6
        Me.BtnInsertTask.Name = "BtnInsertTask"
        Me.BtnInsertTask.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BtnInsertTask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BtnInsertTask.Width = 125
        '
        'BtnTasks
        '
        Me.BtnTasks.HeaderText = "タスク一覧"
        Me.BtnTasks.MinimumWidth = 6
        Me.BtnTasks.Name = "BtnTasks"
        Me.BtnTasks.Width = 125
        '
        'FrmProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvProjects)
        Me.Name = "FrmProjects"
        Me.Text = "FrmProjects"
        CType(Me.DgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvProjects As DataGridView
    Friend WithEvents txtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtProjectName As DataGridViewTextBoxColumn
    Friend WithEvents TxtHour As DataGridViewTextBoxColumn
    Friend WithEvents TxtSummary As DataGridViewTextBoxColumn
    Friend WithEvents TxtStartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtStatus As DataGridViewTextBoxColumn
    Friend WithEvents BtnProjectDelete As DataGridViewButtonColumn
    Friend WithEvents BtnProjectUpdate As DataGridViewButtonColumn
    Friend WithEvents BtnInsertTask As DataGridViewButtonColumn
    Friend WithEvents BtnTasks As DataGridViewButtonColumn
End Class
