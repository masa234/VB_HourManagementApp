<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTasks
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
        Me.DgvTasks = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSummary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtInsertDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtUpdateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnDeleteTask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnUpdateTask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnArchive = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LbllTaskName = New System.Windows.Forms.Label()
        Me.TxtSearchTaskName = New System.Windows.Forms.TextBox()
        Me.LblSearchCount = New System.Windows.Forms.Label()
        Me.BtnOutputCSV = New System.Windows.Forms.Button()
        Me.BtnSortStatus = New System.Windows.Forms.Button()
        CType(Me.DgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(543, 481)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 57
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvTasks
        '
        Me.DgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtID, Me.TxtTaskName, Me.TxtHour, Me.TxtSummary, Me.TxtInsertDate, Me.TxtUpdateDate, Me.TxtStatus, Me.BtnDeleteTask, Me.BtnUpdateTask, Me.BtnArchive})
        Me.DgvTasks.Location = New System.Drawing.Point(138, 185)
        Me.DgvTasks.Name = "DgvTasks"
        Me.DgvTasks.RowHeadersWidth = 51
        Me.DgvTasks.RowTemplate.Height = 24
        Me.DgvTasks.Size = New System.Drawing.Size(548, 253)
        Me.DgvTasks.TabIndex = 56
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
        'TxtTaskName
        '
        Me.TxtTaskName.DataPropertyName = "TaskName"
        Me.TxtTaskName.HeaderText = "タスク名"
        Me.TxtTaskName.MinimumWidth = 6
        Me.TxtTaskName.Name = "TxtTaskName"
        Me.TxtTaskName.Width = 125
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
        'TxtInsertDate
        '
        Me.TxtInsertDate.DataPropertyName = "InsertDate"
        Me.TxtInsertDate.HeaderText = "投稿日時"
        Me.TxtInsertDate.MinimumWidth = 6
        Me.TxtInsertDate.Name = "TxtInsertDate"
        Me.TxtInsertDate.Width = 125
        '
        'TxtUpdateDate
        '
        Me.TxtUpdateDate.DataPropertyName = "UpdateDate"
        Me.TxtUpdateDate.HeaderText = "更新日時"
        Me.TxtUpdateDate.MinimumWidth = 6
        Me.TxtUpdateDate.Name = "TxtUpdateDate"
        Me.TxtUpdateDate.Width = 125
        '
        'TxtStatus
        '
        Me.TxtStatus.DataPropertyName = "Status"
        Me.TxtStatus.HeaderText = "状態"
        Me.TxtStatus.MinimumWidth = 6
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Width = 125
        '
        'BtnDeleteTask
        '
        Me.BtnDeleteTask.HeaderText = "削除"
        Me.BtnDeleteTask.MinimumWidth = 6
        Me.BtnDeleteTask.Name = "BtnDeleteTask"
        Me.BtnDeleteTask.Width = 125
        '
        'BtnUpdateTask
        '
        Me.BtnUpdateTask.HeaderText = "更新"
        Me.BtnUpdateTask.MinimumWidth = 6
        Me.BtnUpdateTask.Name = "BtnUpdateTask"
        Me.BtnUpdateTask.Width = 125
        '
        'BtnArchive
        '
        Me.BtnArchive.HeaderText = "アーカイブ化"
        Me.BtnArchive.MinimumWidth = 6
        Me.BtnArchive.Name = "BtnArchive"
        Me.BtnArchive.Width = 125
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(543, 119)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(143, 43)
        Me.BtnSearch.TabIndex = 61
        Me.BtnSearch.Text = "検索"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LbllTaskName
        '
        Me.LbllTaskName.AutoSize = True
        Me.LbllTaskName.Location = New System.Drawing.Point(137, 51)
        Me.LbllTaskName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbllTaskName.Name = "LbllTaskName"
        Me.LbllTaskName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbllTaskName.Size = New System.Drawing.Size(53, 15)
        Me.LbllTaskName.TabIndex = 60
        Me.LbllTaskName.Text = "タスク名"
        '
        'TxtSearchTaskName
        '
        Me.TxtSearchTaskName.Location = New System.Drawing.Point(138, 79)
        Me.TxtSearchTaskName.Name = "TxtSearchTaskName"
        Me.TxtSearchTaskName.Size = New System.Drawing.Size(548, 22)
        Me.TxtSearchTaskName.TabIndex = 59
        '
        'LblSearchCount
        '
        Me.LblSearchCount.AutoSize = True
        Me.LblSearchCount.Location = New System.Drawing.Point(693, 85)
        Me.LblSearchCount.Name = "LblSearchCount"
        Me.LblSearchCount.Size = New System.Drawing.Size(0, 15)
        Me.LblSearchCount.TabIndex = 62
        '
        'BtnOutputCSV
        '
        Me.BtnOutputCSV.Location = New System.Drawing.Point(374, 481)
        Me.BtnOutputCSV.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOutputCSV.Name = "BtnOutputCSV"
        Me.BtnOutputCSV.Size = New System.Drawing.Size(143, 43)
        Me.BtnOutputCSV.TabIndex = 63
        Me.BtnOutputCSV.Text = "CSV出力"
        Me.BtnOutputCSV.UseVisualStyleBackColor = True
        '
        'BtnSortStatus
        '
        Me.BtnSortStatus.Location = New System.Drawing.Point(374, 119)
        Me.BtnSortStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSortStatus.Name = "BtnSortStatus"
        Me.BtnSortStatus.Size = New System.Drawing.Size(143, 43)
        Me.BtnSortStatus.TabIndex = 64
        Me.BtnSortStatus.Text = "状態でソート"
        Me.BtnSortStatus.UseVisualStyleBackColor = True
        '
        'FrmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 553)
        Me.Controls.Add(Me.BtnSortStatus)
        Me.Controls.Add(Me.BtnOutputCSV)
        Me.Controls.Add(Me.LblSearchCount)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.LbllTaskName)
        Me.Controls.Add(Me.TxtSearchTaskName)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvTasks)
        Me.Name = "FrmTasks"
        Me.Text = "FrmTasks"
        CType(Me.DgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvTasks As DataGridView
    Friend WithEvents txtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtTaskName As DataGridViewTextBoxColumn
    Friend WithEvents TxtHour As DataGridViewTextBoxColumn
    Friend WithEvents TxtSummary As DataGridViewTextBoxColumn
    Friend WithEvents TxtInsertDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtUpdateDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtStatus As DataGridViewTextBoxColumn
    Friend WithEvents BtnDeleteTask As DataGridViewButtonColumn
    Friend WithEvents BtnUpdateTask As DataGridViewButtonColumn
    Friend WithEvents BtnArchive As DataGridViewButtonColumn
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LbllTaskName As Label
    Friend WithEvents TxtSearchTaskName As TextBox
    Friend WithEvents LblSearchCount As Label
    Friend WithEvents BtnOutputCSV As Button
    Friend WithEvents BtnSortStatus As Button
End Class
