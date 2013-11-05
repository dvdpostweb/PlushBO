<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatCustomer
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
        Me.BtnFreeTrial = New DevExpress.XtraEditors.SimpleButton
        Me.GCWithDate = New DevExpress.XtraEditors.GroupControl
        Me.btnCustomerStop = New DevExpress.XtraEditors.SimpleButton
        Me.btnFtAboStop = New DevExpress.XtraEditors.SimpleButton
        Me.BtnWelcomeCall = New DevExpress.XtraEditors.SimpleButton
        Me.BtnStep31_33 = New DevExpress.XtraEditors.SimpleButton
        Me.btnListCustomers = New DevExpress.XtraEditors.SimpleButton
        Me.btnWishlistCustomer = New DevExpress.XtraEditors.SimpleButton
        Me.btnProspect = New DevExpress.XtraEditors.SimpleButton
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
        Me.TabParameters.Controls.Add(Me.btnProspect)
        Me.TabParameters.Controls.Add(Me.btnWishlistCustomer)
        Me.TabParameters.Controls.Add(Me.btnListCustomers)
        Me.TabParameters.Controls.Add(Me.GCWithDate)
        Me.TabParameters.Controls.Add(Me.BtnFreeTrial)
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
        'BtnFreeTrial
        '
        Me.BtnFreeTrial.Location = New System.Drawing.Point(23, 272)
        Me.BtnFreeTrial.Name = "BtnFreeTrial"
        Me.HelpProvider1.SetShowHelp(Me.BtnFreeTrial, False)
        Me.BtnFreeTrial.Size = New System.Drawing.Size(183, 49)
        Me.BtnFreeTrial.TabIndex = 37
        Me.BtnFreeTrial.Text = "View FreeTrial"
        Me.BtnFreeTrial.ToolTip = "View FreeTrial"
        '
        'GCWithDate
        '
        Me.GCWithDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCWithDate.Controls.Add(Me.btnCustomerStop)
        Me.GCWithDate.Controls.Add(Me.btnFtAboStop)
        Me.GCWithDate.Controls.Add(Me.BtnWelcomeCall)
        Me.GCWithDate.Controls.Add(Me.BtnStep31_33)
        Me.GCWithDate.Controls.Add(Me.LabelControl2)
        Me.GCWithDate.Controls.Add(Me.txtToDate)
        Me.GCWithDate.Controls.Add(Me.LabelControl1)
        Me.GCWithDate.Controls.Add(Me.txtFromDate)
        Me.GCWithDate.Location = New System.Drawing.Point(23, 24)
        Me.GCWithDate.Name = "GCWithDate"
        Me.GCWithDate.Size = New System.Drawing.Size(434, 208)
        Me.GCWithDate.TabIndex = 38
        Me.GCWithDate.Text = "Stat With Date"
        '
        'btnCustomerStop
        '
        Me.btnCustomerStop.Location = New System.Drawing.Point(215, 26)
        Me.btnCustomerStop.Name = "btnCustomerStop"
        Me.HelpProvider1.SetShowHelp(Me.btnCustomerStop, False)
        Me.btnCustomerStop.Size = New System.Drawing.Size(183, 46)
        Me.btnCustomerStop.TabIndex = 43
        Me.btnCustomerStop.Text = "List Customers Stop"
        '
        'btnFtAboStop
        '
        Me.btnFtAboStop.Location = New System.Drawing.Point(13, 157)
        Me.btnFtAboStop.Name = "btnFtAboStop"
        Me.HelpProvider1.SetShowHelp(Me.btnFtAboStop, False)
        Me.btnFtAboStop.Size = New System.Drawing.Size(183, 46)
        Me.btnFtAboStop.TabIndex = 40
        Me.btnFtAboStop.Text = "FT AboStop"
        '
        'BtnWelcomeCall
        '
        Me.BtnWelcomeCall.Location = New System.Drawing.Point(215, 87)
        Me.BtnWelcomeCall.Name = "BtnWelcomeCall"
        Me.HelpProvider1.SetShowHelp(Me.BtnWelcomeCall, False)
        Me.BtnWelcomeCall.Size = New System.Drawing.Size(183, 46)
        Me.BtnWelcomeCall.TabIndex = 39
        Me.BtnWelcomeCall.Text = "Welcome Call"
        Me.BtnWelcomeCall.ToolTip = "welcome call"
        '
        'BtnStep31_33
        '
        Me.BtnStep31_33.Location = New System.Drawing.Point(13, 87)
        Me.BtnStep31_33.Name = "BtnStep31_33"
        Me.HelpProvider1.SetShowHelp(Me.BtnStep31_33, False)
        Me.BtnStep31_33.Size = New System.Drawing.Size(183, 46)
        Me.BtnStep31_33.TabIndex = 38
        Me.BtnStep31_33.Text = "Step 31-33"
        Me.BtnStep31_33.ToolTip = "View cancel Ogone"
        '
        'btnListCustomers
        '
        Me.btnListCustomers.Location = New System.Drawing.Point(238, 275)
        Me.btnListCustomers.Name = "btnListCustomers"
        Me.HelpProvider1.SetShowHelp(Me.btnListCustomers, False)
        Me.btnListCustomers.Size = New System.Drawing.Size(183, 46)
        Me.btnListCustomers.TabIndex = 41
        Me.btnListCustomers.Text = "List Customers"
        '
        'btnWishlistCustomer
        '
        Me.btnWishlistCustomer.Location = New System.Drawing.Point(23, 340)
        Me.btnWishlistCustomer.Name = "btnWishlistCustomer"
        Me.HelpProvider1.SetShowHelp(Me.btnWishlistCustomer, False)
        Me.btnWishlistCustomer.Size = New System.Drawing.Size(183, 46)
        Me.btnWishlistCustomer.TabIndex = 42
        Me.btnWishlistCustomer.Text = "Wishlist Customers"
        '
        'btnProspect
        '
        Me.btnProspect.Location = New System.Drawing.Point(238, 340)
        Me.btnProspect.Name = "btnProspect"
        Me.HelpProvider1.SetShowHelp(Me.btnProspect, False)
        Me.btnProspect.Size = New System.Drawing.Size(183, 46)
        Me.btnProspect.TabIndex = 43
        Me.btnProspect.Text = "Prospects"
        '
        'frmStatCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmStatCustomer"
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
    Friend WithEvents BtnFreeTrial As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCWithDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnStep31_33 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnWelcomeCall As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnFtAboStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnListCustomers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnWishlistCustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomerStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnProspect As DevExpress.XtraEditors.SimpleButton
End Class
