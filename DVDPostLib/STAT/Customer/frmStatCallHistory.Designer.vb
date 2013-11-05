<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatCallHistory
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GCWithDate = New DevExpress.XtraEditors.GroupControl
        Me.btnRetention = New DevExpress.XtraEditors.SimpleButton
        Me.btnNodeMain = New DevExpress.XtraEditors.SimpleButton
        Me.BtnAboStop = New DevExpress.XtraEditors.SimpleButton
        Me.BtnCallHistoryContactUser = New DevExpress.XtraEditors.SimpleButton
        Me.btnAllValue = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCWithDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 548)
        Me.StatusBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusBar1.Size = New System.Drawing.Size(1472, 30)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Size = New System.Drawing.Size(1472, 513)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.SelectedTabPage = Me.TabResult
        Me.TabControl1.Size = New System.Drawing.Size(1472, 513)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.GCWithDate)
        Me.TabParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.TabParameters.Size = New System.Drawing.Size(1463, 479)
        '
        'TabResult
        '
        Me.TabResult.Margin = New System.Windows.Forms.Padding(4)
        Me.TabResult.Size = New System.Drawing.Size(1463, 479)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Margin = New System.Windows.Forms.Padding(4)
        Me.TabAnalyse.Size = New System.Drawing.Size(1463, 479)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1463, 479)
        '
        'UcChart1
        '
        Me.UcChart1.Margin = New System.Windows.Forms.Padding(4)
        Me.UcChart1.Size = New System.Drawing.Size(1463, 479)
        '
        'TabChart
        '
        Me.TabChart.Margin = New System.Windows.Forms.Padding(4)
        Me.TabChart.Size = New System.Drawing.Size(1463, 479)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 32)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, False)
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "From Date"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(128, 28)
        Me.txtFromDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, False)
        Me.txtFromDate.Size = New System.Drawing.Size(133, 22)
        Me.txtFromDate.TabIndex = 3
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(128, 60)
        Me.txtToDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, False)
        Me.txtToDate.Size = New System.Drawing.Size(133, 22)
        Me.txtToDate.TabIndex = 35
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 64)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, False)
        Me.LabelControl2.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "To Date"
        '
        'GCWithDate
        '
        Me.GCWithDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCWithDate.Controls.Add(Me.btnAllValue)
        Me.GCWithDate.Controls.Add(Me.btnRetention)
        Me.GCWithDate.Controls.Add(Me.btnNodeMain)
        Me.GCWithDate.Controls.Add(Me.BtnAboStop)
        Me.GCWithDate.Controls.Add(Me.BtnCallHistoryContactUser)
        Me.GCWithDate.Controls.Add(Me.LabelControl2)
        Me.GCWithDate.Controls.Add(Me.txtToDate)
        Me.GCWithDate.Controls.Add(Me.LabelControl1)
        Me.GCWithDate.Controls.Add(Me.txtFromDate)
        Me.GCWithDate.Location = New System.Drawing.Point(31, 30)
        Me.GCWithDate.Margin = New System.Windows.Forms.Padding(4)
        Me.GCWithDate.Name = "GCWithDate"
        Me.GCWithDate.Size = New System.Drawing.Size(836, 256)
        Me.GCWithDate.TabIndex = 38
        Me.GCWithDate.Text = "Stat With Date"
        '
        'btnRetention
        '
        Me.btnRetention.Location = New System.Drawing.Point(287, 193)
        Me.btnRetention.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetention.Name = "btnRetention"
        Me.HelpProvider1.SetShowHelp(Me.btnRetention, False)
        Me.btnRetention.Size = New System.Drawing.Size(244, 57)
        Me.btnRetention.TabIndex = 41
        Me.btnRetention.Text = "Retention"
        '
        'btnNodeMain
        '
        Me.btnNodeMain.Location = New System.Drawing.Point(17, 193)
        Me.btnNodeMain.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNodeMain.Name = "btnNodeMain"
        Me.HelpProvider1.SetShowHelp(Me.btnNodeMain, False)
        Me.btnNodeMain.Size = New System.Drawing.Size(244, 57)
        Me.btnNodeMain.TabIndex = 40
        Me.btnNodeMain.Text = "Raison Principale"
        '
        'BtnAboStop
        '
        Me.BtnAboStop.Location = New System.Drawing.Point(287, 107)
        Me.BtnAboStop.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAboStop.Name = "BtnAboStop"
        Me.HelpProvider1.SetShowHelp(Me.BtnAboStop, False)
        Me.BtnAboStop.Size = New System.Drawing.Size(244, 57)
        Me.BtnAboStop.TabIndex = 39
        Me.BtnAboStop.Text = "Abo Stop"
        Me.BtnAboStop.ToolTip = "Abo Stop"
        '
        'BtnCallHistoryContactUser
        '
        Me.BtnCallHistoryContactUser.Location = New System.Drawing.Point(17, 107)
        Me.BtnCallHistoryContactUser.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCallHistoryContactUser.Name = "BtnCallHistoryContactUser"
        Me.HelpProvider1.SetShowHelp(Me.BtnCallHistoryContactUser, False)
        Me.BtnCallHistoryContactUser.Size = New System.Drawing.Size(244, 57)
        Me.BtnCallHistoryContactUser.TabIndex = 38
        Me.BtnCallHistoryContactUser.Text = "Contact User"
        '
        'btnAllValue
        '
        Me.btnAllValue.Location = New System.Drawing.Point(554, 107)
        Me.btnAllValue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAllValue.Name = "btnAllValue"
        Me.HelpProvider1.SetShowHelp(Me.btnAllValue, False)
        Me.btnAllValue.Size = New System.Drawing.Size(244, 57)
        Me.btnAllValue.TabIndex = 42
        Me.btnAllValue.Text = "All Value"
        Me.btnAllValue.ToolTip = "All Value"
        '
        'frmStatCallHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 578)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStatCallHistory"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "FrmStat"
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
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCWithDate.ResumeLayout(False)
        Me.GCWithDate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCWithDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnCallHistoryContactUser As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAboStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNodeMain As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRetention As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAllValue As DevExpress.XtraEditors.SimpleButton
End Class
