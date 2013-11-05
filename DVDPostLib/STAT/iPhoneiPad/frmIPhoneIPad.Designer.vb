<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIPhoneIPad
    Inherits BizzLib.frmGeneral_Browse

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAppUsedByCustomers = New DevExpress.XtraEditors.SimpleButton
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.GCWithDate = New DevExpress.XtraEditors.GroupControl
        Me.brnVODWatchedByCust = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.btnMostWatched = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCWithDate.SuspendLayout()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Size = New System.Drawing.Size(1104, 416)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        Me.TabControl1.Size = New System.Drawing.Size(1104, 416)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GCWithDate)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Size = New System.Drawing.Size(1095, 385)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1095, 385)
        '
        'UcChart1
        '
        Me.UcChart1.Size = New System.Drawing.Size(1095, 385)
        '
        'TabChart
        '
        Me.TabChart.Size = New System.Drawing.Size(1095, 385)
        '
        'btnAppUsedByCustomers
        '
        Me.btnAppUsedByCustomers.Location = New System.Drawing.Point(13, 87)
        Me.btnAppUsedByCustomers.Name = "btnAppUsedByCustomers"
        Me.HelpProvider1.SetShowHelp(Me.btnAppUsedByCustomers, False)
        Me.btnAppUsedByCustomers.Size = New System.Drawing.Size(183, 46)
        Me.btnAppUsedByCustomers.TabIndex = 38
        Me.btnAppUsedByCustomers.Text = "Application used by customers"
        Me.btnAppUsedByCustomers.ToolTip = "List of customers who used application"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(96, 49)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, False)
        Me.txtToDate.Size = New System.Drawing.Size(100, 20)
        Me.txtToDate.TabIndex = 35
        '
        'GCWithDate
        '
        Me.GCWithDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCWithDate.Controls.Add(Me.btnMostWatched)
        Me.GCWithDate.Controls.Add(Me.brnVODWatchedByCust)
        Me.GCWithDate.Controls.Add(Me.btnAppUsedByCustomers)
        Me.GCWithDate.Controls.Add(Me.LabelControl2)
        Me.GCWithDate.Controls.Add(Me.txtToDate)
        Me.GCWithDate.Controls.Add(Me.LabelControl1)
        Me.GCWithDate.Controls.Add(Me.txtFromDate)
        Me.GCWithDate.Location = New System.Drawing.Point(9, 14)
        Me.GCWithDate.Name = "GCWithDate"
        Me.GCWithDate.Size = New System.Drawing.Size(892, 168)
        Me.GCWithDate.TabIndex = 39
        Me.GCWithDate.Text = "Stat With Date"
        '
        'brnVODWatchedByCust
        '
        Me.brnVODWatchedByCust.Location = New System.Drawing.Point(227, 87)
        Me.brnVODWatchedByCust.Name = "brnVODWatchedByCust"
        Me.HelpProvider1.SetShowHelp(Me.brnVODWatchedByCust, False)
        Me.brnVODWatchedByCust.Size = New System.Drawing.Size(183, 46)
        Me.brnVODWatchedByCust.TabIndex = 39
        Me.brnVODWatchedByCust.Text = "VOD watched by customers"
        Me.brnVODWatchedByCust.ToolTip = "List of customers who used application"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, False)
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "To Date"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, False)
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "From Date"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(96, 23)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, False)
        Me.txtFromDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDate.TabIndex = 3
        '
        'btnMostWatched
        '
        Me.btnMostWatched.Location = New System.Drawing.Point(442, 87)
        Me.btnMostWatched.Name = "btnMostWatched"
        Me.HelpProvider1.SetShowHelp(Me.btnMostWatched, False)
        Me.btnMostWatched.Size = New System.Drawing.Size(183, 46)
        Me.btnMostWatched.TabIndex = 40
        Me.btnMostWatched.Text = "Most watched movies"
        Me.btnMostWatched.ToolTip = "List of most watched movies"
        '
        'frmIPhoneIPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmIPhoneIPad"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "frmIPhoneIPad"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCWithDate.ResumeLayout(False)
        Me.GCWithDate.PerformLayout()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GCWithDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAppUsedByCustomers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents brnVODWatchedByCust As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMostWatched As DevExpress.XtraEditors.SimpleButton
End Class
