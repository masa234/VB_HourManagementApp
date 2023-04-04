<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchiveTasks
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
        Me.DgvArchiveTasks = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTaskName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtHour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtSummary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtInsertDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtUpdateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvArchiveTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(531, 342)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(143, 43)
        Me.BtnBack.TabIndex = 66
        Me.BtnBack.Text = "戻る"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'DgvArchiveTasks
        '
        Me.DgvArchiveTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArchiveTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtID, Me.TxtTaskName, Me.TxtHour, Me.TxtSummary, Me.TxtInsertDate, Me.TxtUpdateDate, Me.TxtStatus})
        Me.DgvArchiveTasks.Location = New System.Drawing.Point(126, 65)
        Me.DgvArchiveTasks.Name = "DgvArchiveTasks"
        Me.DgvArchiveTasks.RowHeadersWidth = 51
        Me.DgvArchiveTasks.RowTemplate.Height = 24
        Me.DgvArchiveTasks.Size = New System.Drawing.Size(548, 253)
        Me.DgvArchiveTasks.TabIndex = 65
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
        'FrmArchiveTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.DgvArchiveTasks)
        Me.Name = "FrmArchiveTasks"
        Me.Text = "FrmArchiveTasks"
        CType(Me.DgvArchiveTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents DgvArchiveTasks As DataGridView
    Friend WithEvents txtID As DataGridViewTextBoxColumn
    Friend WithEvents TxtTaskName As DataGridViewTextBoxColumn
    Friend WithEvents TxtHour As DataGridViewTextBoxColumn
    Friend WithEvents TxtSummary As DataGridViewTextBoxColumn
    Friend WithEvents TxtInsertDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtUpdateDate As DataGridViewTextBoxColumn
    Friend WithEvents TxtStatus As DataGridViewTextBoxColumn
End Class
