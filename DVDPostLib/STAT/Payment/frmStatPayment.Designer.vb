<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatPayment
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
        Me.btnStatOgone = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDomPaid = New DevExpress.XtraEditors.SimpleButton
        Me.BtnBankTransferPaid = New DevExpress.XtraEditors.SimpleButton
        Me.btnUnpaidOgone = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelOgone = New DevExpress.XtraEditors.SimpleButton
        Me.BtnDroseliaSale = New DevExpress.XtraEditors.SimpleButton
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GCWithDate = New DevExpress.XtraEditors.GroupControl
        Me.btnVodStatusHistory = New DevExpress.XtraEditors.SimpleButton
        Me.btnViewVodHistory = New DevExpress.XtraEditors.SimpleButton
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
        'btnStatOgone
        '
        Me.btnStatOgone.Location = New System.Drawing.Point(26, 81)
        Me.btnStatOgone.Name = "btnStatOgone"
        Me.HelpProvider1.SetShowHelp(Me.btnStatOgone, False)
        Me.btnStatOgone.Size = New System.Drawing.Size(183, 44)
        Me.btnStatOgone.TabIndex = 27
        Me.btnStatOgone.Text = "Paid Ogone"
        Me.btnStatOgone.ToolTip = "View Paid Ogone"
        '
        'BtnDomPaid
        '
        Me.BtnDomPaid.Location = New System.Drawing.Point(627, 82)
        Me.BtnDomPaid.Name = "BtnDomPaid"
        Me.HelpProvider1.SetShowHelp(Me.BtnDomPaid, False)
        Me.BtnDomPaid.Size = New System.Drawing.Size(183, 43)
        Me.BtnDomPaid.TabIndex = 28
        Me.BtnDomPaid.Text = "Paid Dom"
        Me.BtnDomPaid.ToolTip = "View Paid Domiciliation"
        Me.BtnDomPaid.Visible = False
        '
        'BtnBankTransferPaid
        '
        Me.BtnBankTransferPaid.Location = New System.Drawing.Point(627, 131)
        Me.BtnBankTransferPaid.Name = "BtnBankTransferPaid"
        Me.HelpProvider1.SetShowHelp(Me.BtnBankTransferPaid, False)
        Me.BtnBankTransferPaid.Size = New System.Drawing.Size(183, 43)
        Me.BtnBankTransferPaid.TabIndex = 29
        Me.BtnBankTransferPaid.Text = "Paid BankTransfer"
        Me.BtnBankTransferPaid.ToolTip = "View Paid BankTransfer"
        Me.BtnBankTransferPaid.Visible = False
        '
        'btnUnpaidOgone
        '
        Me.btnUnpaidOgone.Location = New System.Drawing.Point(26, 131)
        Me.btnUnpaidOgone.Name = "btnUnpaidOgone"
        Me.HelpProvider1.SetShowHelp(Me.btnUnpaidOgone, False)
        Me.btnUnpaidOgone.Size = New System.Drawing.Size(183, 47)
        Me.btnUnpaidOgone.TabIndex = 30
        Me.btnUnpaidOgone.Text = "UnPaid Ogone"
        Me.btnUnpaidOgone.ToolTip = "View UnPaid Ogone"
        '
        'btnCancelOgone
        '
        Me.btnCancelOgone.Location = New System.Drawing.Point(26, 184)
        Me.btnCancelOgone.Name = "btnCancelOgone"
        Me.HelpProvider1.SetShowHelp(Me.btnCancelOgone, False)
        Me.btnCancelOgone.Size = New System.Drawing.Size(183, 46)
        Me.btnCancelOgone.TabIndex = 31
        Me.btnCancelOgone.Text = "Cancel Ogone"
        Me.btnCancelOgone.ToolTip = "View cancel Ogone"
        '
        'BtnDroseliaSale
        '
        Me.BtnDroseliaSale.Location = New System.Drawing.Point(627, 188)
        Me.BtnDroseliaSale.Name = "BtnDroseliaSale"
        Me.HelpProvider1.SetShowHelp(Me.BtnDroseliaSale, False)
        Me.BtnDroseliaSale.Size = New System.Drawing.Size(183, 42)
        Me.BtnDroseliaSale.TabIndex = 33
        Me.BtnDroseliaSale.Text = "droselia Sale"
        Me.BtnDroseliaSale.ToolTip = "View droselia sale"
        Me.BtnDroseliaSale.Visible = False
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
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, False)
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "To Date"
        '
        'GCWithDate
        '
        Me.GCWithDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCWithDate.Controls.Add(Me.btnVodStatusHistory)
        Me.GCWithDate.Controls.Add(Me.btnViewVodHistory)
        Me.GCWithDate.Controls.Add(Me.btnStatOgone)
        Me.GCWithDate.Controls.Add(Me.LabelControl2)
        Me.GCWithDate.Controls.Add(Me.BtnDomPaid)
        Me.GCWithDate.Controls.Add(Me.txtToDate)
        Me.GCWithDate.Controls.Add(Me.BtnBankTransferPaid)
        Me.GCWithDate.Controls.Add(Me.BtnDroseliaSale)
        Me.GCWithDate.Controls.Add(Me.LabelControl1)
        Me.GCWithDate.Controls.Add(Me.btnUnpaidOgone)
        Me.GCWithDate.Controls.Add(Me.txtFromDate)
        Me.GCWithDate.Controls.Add(Me.btnCancelOgone)
        Me.GCWithDate.Location = New System.Drawing.Point(23, 24)
        Me.GCWithDate.Name = "GCWithDate"
        Me.GCWithDate.Size = New System.Drawing.Size(815, 247)
        Me.GCWithDate.TabIndex = 38
        Me.GCWithDate.Text = "Stat With Date"
        '
        'btnVodStatusHistory
        '
        Me.btnVodStatusHistory.Location = New System.Drawing.Point(215, 82)
        Me.btnVodStatusHistory.Name = "btnVodStatusHistory"
        Me.HelpProvider1.SetShowHelp(Me.btnVodStatusHistory, False)
        Me.btnVodStatusHistory.Size = New System.Drawing.Size(183, 46)
        Me.btnVodStatusHistory.TabIndex = 42
        Me.btnVodStatusHistory.Text = "VOD Status History"
        Me.btnVodStatusHistory.ToolTip = "View VOD status History"
        '
        'btnViewVodHistory
        '
        Me.btnViewVodHistory.Location = New System.Drawing.Point(215, 132)
        Me.btnViewVodHistory.Name = "btnViewVodHistory"
        Me.HelpProvider1.SetShowHelp(Me.btnViewVodHistory, False)
        Me.btnViewVodHistory.Size = New System.Drawing.Size(183, 46)
        Me.btnViewVodHistory.TabIndex = 40
        Me.btnViewVodHistory.Text = "VOD History"
        Me.btnViewVodHistory.ToolTip = "View VOD History"
        '
        'frmStatPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmStatPayment"
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
    Friend WithEvents btnStatOgone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDomPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBankTransferPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUnpaidOgone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelOgone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDroseliaSale As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCWithDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnViewVodHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVodStatusHistory As DevExpress.XtraEditors.SimpleButton
End Class
