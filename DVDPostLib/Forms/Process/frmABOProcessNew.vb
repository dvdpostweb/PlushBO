Imports System.Windows.Forms.Application

Public Class frmABOProcessNew
    Inherits BizzLib.frmBKForm

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblTotalCustomers As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCustomers As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLoadInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtToCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNormToSend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultToSend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpNotServed As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersServed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersNotServed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtXCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXSuspended As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXTooManyHome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtXDvdNotFound As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCustResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridViewCust As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents DS As DVDPostLib.dsABOProcess
    'Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_home_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_home_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_rank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_multishipment As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents coluse_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colthrottling As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_suspended As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNormToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colAdultToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNormAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colAdultAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colInNeed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNotServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNotEnoughtCredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNoDVDFound As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colTooManyAtHome As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNormCompensation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultCompensation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnStartABO2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStartTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEndTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtRankTooLow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRankTooLow As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDvdAvailable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtError As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblError As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDvdHighSent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDvdMediumSent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtDvdLowSent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtWishListAdultEmpty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtWishListAdultLess20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtWishListNormLess20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtCustomServedRating As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPriorityRating As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDvdSentRating As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtWishListNormEmpty As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.lblTotalCustomers = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalCustomers = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersToProcess = New DevExpress.XtraEditors.TextEdit
        Me.txtNormToSend = New DevExpress.XtraEditors.TextEdit
        Me.txtAdultToSend = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.btnLoadInfo = New DevExpress.XtraEditors.SimpleButton
        Me.txtToCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.gpNotServed = New DevExpress.XtraEditors.GroupControl
        Me.TxtError = New DevExpress.XtraEditors.TextEdit
        Me.LblError = New DevExpress.XtraEditors.LabelControl
        Me.TxtRankTooLow = New DevExpress.XtraEditors.TextEdit
        Me.lblRankTooLow = New DevExpress.XtraEditors.LabelControl
        Me.txtXDvdNotFound = New DevExpress.XtraEditors.TextEdit
        Me.txtXTooManyHome = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtXSuspended = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtXCredit = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersServed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersNotServed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.TxtCustomServedRating = New DevExpress.XtraEditors.TextEdit
        Me.TxtPriorityRating = New DevExpress.XtraEditors.TextEdit
        Me.TxtDvdSentRating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.TxtWishListAdultEmpty = New DevExpress.XtraEditors.TextEdit
        Me.TxtWishListAdultLess20 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.TxtWishListNormEmpty = New DevExpress.XtraEditors.TextEdit
        Me.TxtWishListNormLess20 = New DevExpress.XtraEditors.TextEdit
        Me.TxtDvdHighSent = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.TxtDvdMediumSent = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.TxtDvdLowSent = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TxtDvdAvailable = New DevExpress.XtraEditors.TextEdit
        Me.txtEndTime = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtStartTime = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.btnStartABO2 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtNormCompensation = New DevExpress.XtraEditors.TextEdit
        Me.txtAdultCompensation = New DevExpress.XtraEditors.TextEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridCustResult = New DevExpress.XtraGrid.GridControl
        Me.GridViewCust = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DS = New DVDPostLib.dsABOProcess
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormToSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultToSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpNotServed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpNotServed.SuspendLayout()
        CType(Me.TxtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRankTooLow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXDvdNotFound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXTooManyHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXSuspended.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersServed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersNotServed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.TxtCustomServedRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPriorityRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDvdSentRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtWishListAdultEmpty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtWishListAdultLess20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtWishListNormEmpty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtWishListNormLess20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDvdHighSent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDvdMediumSent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDvdLowSent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDvdAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormCompensation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultCompensation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.Location = New System.Drawing.Point(40, 124)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(78, 13)
        Me.lblTotalCustomers.TabIndex = 1
        Me.lblTotalCustomers.Text = "Total Customers"
        '
        'txtTotalCustomers
        '
        Me.txtTotalCustomers.Enabled = False
        Me.txtTotalCustomers.Location = New System.Drawing.Point(155, 121)
        Me.txtTotalCustomers.Name = "txtTotalCustomers"
        Me.txtTotalCustomers.Properties.ReadOnly = True
        Me.txtTotalCustomers.Size = New System.Drawing.Size(129, 20)
        Me.txtTotalCustomers.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Customers to Process"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(319, 195)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "DVD Norm to Send"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(319, 224)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "DVD Adult to Send"
        '
        'txtCustomersToProcess
        '
        Me.txtCustomersToProcess.Enabled = False
        Me.txtCustomersToProcess.Location = New System.Drawing.Point(155, 90)
        Me.txtCustomersToProcess.Name = "txtCustomersToProcess"
        Me.txtCustomersToProcess.Properties.ReadOnly = True
        Me.txtCustomersToProcess.Size = New System.Drawing.Size(129, 20)
        Me.txtCustomersToProcess.TabIndex = 7
        '
        'txtNormToSend
        '
        Me.txtNormToSend.EditValue = 0
        Me.txtNormToSend.Enabled = False
        Me.txtNormToSend.Location = New System.Drawing.Point(444, 195)
        Me.txtNormToSend.Name = "txtNormToSend"
        Me.txtNormToSend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormToSend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormToSend.Properties.ReadOnly = True
        Me.txtNormToSend.Size = New System.Drawing.Size(100, 20)
        Me.txtNormToSend.TabIndex = 9
        '
        'txtAdultToSend
        '
        Me.txtAdultToSend.EditValue = 0
        Me.txtAdultToSend.Enabled = False
        Me.txtAdultToSend.Location = New System.Drawing.Point(444, 221)
        Me.txtAdultToSend.Name = "txtAdultToSend"
        Me.txtAdultToSend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultToSend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultToSend.Properties.ReadOnly = True
        Me.txtAdultToSend.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultToSend.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(319, 105)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Total DVDs Available"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(40, 227)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "DVD Sent Rating"
        '
        'btnLoadInfo
        '
        Me.btnLoadInfo.Location = New System.Drawing.Point(376, 48)
        Me.btnLoadInfo.Name = "btnLoadInfo"
        Me.btnLoadInfo.Size = New System.Drawing.Size(168, 37)
        Me.btnLoadInfo.TabIndex = 25
        Me.btnLoadInfo.Text = "LOAD"
        '
        'txtToCustomerID
        '
        Me.txtToCustomerID.EditValue = 9999999
        Me.txtToCustomerID.Location = New System.Drawing.Point(408, 24)
        Me.txtToCustomerID.Name = "txtToCustomerID"
        Me.txtToCustomerID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtToCustomerID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtToCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtToCustomerID.TabIndex = 29
        '
        'txtFromCustomerID
        '
        Me.txtFromCustomerID.EditValue = 0
        Me.txtFromCustomerID.Location = New System.Drawing.Point(192, 24)
        Me.txtFromCustomerID.Name = "txtFromCustomerID"
        Me.txtFromCustomerID.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromCustomerID.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFromCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtFromCustomerID.TabIndex = 28
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(304, 24)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl12.TabIndex = 27
        Me.LabelControl12.Text = "To Customer ID"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(48, 24)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl13.TabIndex = 26
        Me.LabelControl13.Text = "From Customer ID"
        '
        'gpNotServed
        '
        Me.gpNotServed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.gpNotServed.Controls.Add(Me.TxtError)
        Me.gpNotServed.Controls.Add(Me.LblError)
        Me.gpNotServed.Controls.Add(Me.TxtRankTooLow)
        Me.gpNotServed.Controls.Add(Me.lblRankTooLow)
        Me.gpNotServed.Controls.Add(Me.txtXDvdNotFound)
        Me.gpNotServed.Controls.Add(Me.txtXTooManyHome)
        Me.gpNotServed.Controls.Add(Me.LabelControl20)
        Me.gpNotServed.Controls.Add(Me.txtXSuspended)
        Me.gpNotServed.Controls.Add(Me.LabelControl17)
        Me.gpNotServed.Controls.Add(Me.LabelControl15)
        Me.gpNotServed.Controls.Add(Me.txtXCredit)
        Me.gpNotServed.Controls.Add(Me.LabelControl14)
        Me.gpNotServed.Location = New System.Drawing.Point(591, 101)
        Me.gpNotServed.Name = "gpNotServed"
        Me.gpNotServed.Size = New System.Drawing.Size(264, 192)
        Me.gpNotServed.TabIndex = 30
        Me.gpNotServed.Text = "Customers NOT Served because :"
        '
        'TxtError
        '
        Me.TxtError.EditValue = 0
        Me.TxtError.Enabled = False
        Me.TxtError.Location = New System.Drawing.Point(160, 152)
        Me.TxtError.Name = "TxtError"
        Me.TxtError.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtError.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtError.Properties.ReadOnly = True
        Me.TxtError.Size = New System.Drawing.Size(100, 20)
        Me.TxtError.TabIndex = 24
        '
        'LblError
        '
        Me.LblError.Location = New System.Drawing.Point(16, 152)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(24, 13)
        Me.LblError.TabIndex = 23
        Me.LblError.Text = "Error"
        '
        'TxtRankTooLow
        '
        Me.TxtRankTooLow.EditValue = 0
        Me.TxtRankTooLow.Enabled = False
        Me.TxtRankTooLow.Location = New System.Drawing.Point(160, 126)
        Me.TxtRankTooLow.Name = "TxtRankTooLow"
        Me.TxtRankTooLow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtRankTooLow.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtRankTooLow.Properties.ReadOnly = True
        Me.TxtRankTooLow.Size = New System.Drawing.Size(100, 20)
        Me.TxtRankTooLow.TabIndex = 22
        '
        'lblRankTooLow
        '
        Me.lblRankTooLow.Location = New System.Drawing.Point(16, 126)
        Me.lblRankTooLow.Name = "lblRankTooLow"
        Me.lblRankTooLow.Size = New System.Drawing.Size(62, 13)
        Me.lblRankTooLow.TabIndex = 21
        Me.lblRankTooLow.Text = "Rank too low"
        '
        'txtXDvdNotFound
        '
        Me.txtXDvdNotFound.EditValue = 0
        Me.txtXDvdNotFound.Enabled = False
        Me.txtXDvdNotFound.Location = New System.Drawing.Point(160, 73)
        Me.txtXDvdNotFound.Name = "txtXDvdNotFound"
        Me.txtXDvdNotFound.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXDvdNotFound.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXDvdNotFound.Properties.ReadOnly = True
        Me.txtXDvdNotFound.Size = New System.Drawing.Size(100, 20)
        Me.txtXDvdNotFound.TabIndex = 20
        '
        'txtXTooManyHome
        '
        Me.txtXTooManyHome.EditValue = 0
        Me.txtXTooManyHome.Enabled = False
        Me.txtXTooManyHome.Location = New System.Drawing.Point(160, 100)
        Me.txtXTooManyHome.Name = "txtXTooManyHome"
        Me.txtXTooManyHome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXTooManyHome.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXTooManyHome.Properties.ReadOnly = True
        Me.txtXTooManyHome.Size = New System.Drawing.Size(100, 20)
        Me.txtXTooManyHome.TabIndex = 19
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 100)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = "Too many DVD @ Home"
        '
        'txtXSuspended
        '
        Me.txtXSuspended.EditValue = 0
        Me.txtXSuspended.Enabled = False
        Me.txtXSuspended.Location = New System.Drawing.Point(160, 21)
        Me.txtXSuspended.Name = "txtXSuspended"
        Me.txtXSuspended.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXSuspended.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXSuspended.Properties.ReadOnly = True
        Me.txtXSuspended.Size = New System.Drawing.Size(100, 20)
        Me.txtXSuspended.TabIndex = 17
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 21)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl17.TabIndex = 16
        Me.LabelControl17.Text = "ABO Suspended"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(16, 73)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl15.TabIndex = 12
        Me.LabelControl15.Text = "DVD not found"
        '
        'txtXCredit
        '
        Me.txtXCredit.EditValue = 0
        Me.txtXCredit.Enabled = False
        Me.txtXCredit.Location = New System.Drawing.Point(160, 47)
        Me.txtXCredit.Name = "txtXCredit"
        Me.txtXCredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXCredit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXCredit.Properties.ReadOnly = True
        Me.txtXCredit.Size = New System.Drawing.Size(100, 20)
        Me.txtXCredit.TabIndex = 11
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 47)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = "Not Enought Credit"
        '
        'txtCustomersServed
        '
        Me.txtCustomersServed.EditValue = 0
        Me.txtCustomersServed.Enabled = False
        Me.txtCustomersServed.Location = New System.Drawing.Point(444, 128)
        Me.txtCustomersServed.Name = "txtCustomersServed"
        Me.txtCustomersServed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersServed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersServed.Properties.ReadOnly = True
        Me.txtCustomersServed.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersServed.TabIndex = 32
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(319, 128)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl18.TabIndex = 31
        Me.LabelControl18.Text = "Customers Served"
        '
        'txtCustomersNotServed
        '
        Me.txtCustomersNotServed.EditValue = 0
        Me.txtCustomersNotServed.Enabled = False
        Me.txtCustomersNotServed.Location = New System.Drawing.Point(444, 154)
        Me.txtCustomersNotServed.Name = "txtCustomersNotServed"
        Me.txtCustomersNotServed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersNotServed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersNotServed.Properties.ReadOnly = True
        Me.txtCustomersNotServed.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersNotServed.TabIndex = 34
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(319, 157)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl19.TabIndex = 33
        Me.LabelControl19.Text = "Customers NOT Served"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1284, 408)
        Me.XtraTabControl1.TabIndex = 36
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "TabControlABO"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.TxtCustomServedRating)
        Me.XtraTabPage1.Controls.Add(Me.TxtPriorityRating)
        Me.XtraTabPage1.Controls.Add(Me.TxtDvdSentRating)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage1.Controls.Add(Me.TxtWishListAdultEmpty)
        Me.XtraTabPage1.Controls.Add(Me.TxtWishListAdultLess20)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage1.Controls.Add(Me.TxtWishListNormEmpty)
        Me.XtraTabPage1.Controls.Add(Me.TxtWishListNormLess20)
        Me.XtraTabPage1.Controls.Add(Me.TxtDvdHighSent)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.TxtDvdMediumSent)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.TxtDvdLowSent)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.TxtDvdAvailable)
        Me.XtraTabPage1.Controls.Add(Me.txtEndTime)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage1.Controls.Add(Me.txtStartTime)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage1.Controls.Add(Me.btnStartABO2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage1.Controls.Add(Me.txtNormCompensation)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultCompensation)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.lblTotalCustomers)
        Me.XtraTabPage1.Controls.Add(Me.btnLoadInfo)
        Me.XtraTabPage1.Controls.Add(Me.txtToCustomerID)
        Me.XtraTabPage1.Controls.Add(Me.txtFromCustomerID)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.gpNotServed)
        Me.XtraTabPage1.Controls.Add(Me.txtTotalCustomers)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersToProcess)
        Me.XtraTabPage1.Controls.Add(Me.txtNormToSend)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultToSend)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersServed)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersNotServed)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1275, 377)
        Me.XtraTabPage1.Text = "Parameters / Process"
        '
        'TxtCustomServedRating
        '
        Me.TxtCustomServedRating.EditValue = 0
        Me.TxtCustomServedRating.Enabled = False
        Me.TxtCustomServedRating.Location = New System.Drawing.Point(167, 256)
        Me.TxtCustomServedRating.Name = "TxtCustomServedRating"
        Me.TxtCustomServedRating.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCustomServedRating.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCustomServedRating.Properties.ReadOnly = True
        Me.TxtCustomServedRating.Size = New System.Drawing.Size(100, 20)
        Me.TxtCustomServedRating.TabIndex = 72
        '
        'TxtPriorityRating
        '
        Me.TxtPriorityRating.EditValue = 0
        Me.TxtPriorityRating.Enabled = False
        Me.TxtPriorityRating.Location = New System.Drawing.Point(167, 291)
        Me.TxtPriorityRating.Name = "TxtPriorityRating"
        Me.TxtPriorityRating.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPriorityRating.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPriorityRating.Properties.ReadOnly = True
        Me.TxtPriorityRating.Size = New System.Drawing.Size(100, 20)
        Me.TxtPriorityRating.TabIndex = 73
        '
        'TxtDvdSentRating
        '
        Me.TxtDvdSentRating.EditValue = 0
        Me.TxtDvdSentRating.Enabled = False
        Me.TxtDvdSentRating.Location = New System.Drawing.Point(167, 224)
        Me.TxtDvdSentRating.Name = "TxtDvdSentRating"
        Me.TxtDvdSentRating.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdSentRating.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdSentRating.Properties.ReadOnly = True
        Me.TxtDvdSentRating.Size = New System.Drawing.Size(100, 20)
        Me.TxtDvdSentRating.TabIndex = 71
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(872, 237)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl11.TabIndex = 67
        Me.LabelControl11.Text = "Wishlist Adult Empty"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(872, 266)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl16.TabIndex = 68
        Me.LabelControl16.Text = "Wishlist Adult Less 20"
        '
        'TxtWishListAdultEmpty
        '
        Me.TxtWishListAdultEmpty.EditValue = 0
        Me.TxtWishListAdultEmpty.Enabled = False
        Me.TxtWishListAdultEmpty.Location = New System.Drawing.Point(995, 238)
        Me.TxtWishListAdultEmpty.Name = "TxtWishListAdultEmpty"
        Me.TxtWishListAdultEmpty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListAdultEmpty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListAdultEmpty.Properties.ReadOnly = True
        Me.TxtWishListAdultEmpty.Size = New System.Drawing.Size(100, 20)
        Me.TxtWishListAdultEmpty.TabIndex = 69
        '
        'TxtWishListAdultLess20
        '
        Me.TxtWishListAdultLess20.EditValue = 0
        Me.TxtWishListAdultLess20.Enabled = False
        Me.TxtWishListAdultLess20.Location = New System.Drawing.Point(995, 264)
        Me.TxtWishListAdultLess20.Name = "TxtWishListAdultLess20"
        Me.TxtWishListAdultLess20.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListAdultLess20.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListAdultLess20.Properties.ReadOnly = True
        Me.TxtWishListAdultLess20.Size = New System.Drawing.Size(100, 20)
        Me.TxtWishListAdultLess20.TabIndex = 70
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(872, 185)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl23.TabIndex = 63
        Me.LabelControl23.Text = "Wishlist Norm Empty"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(872, 214)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl24.TabIndex = 64
        Me.LabelControl24.Text = "WishList Norm Less 20"
        '
        'TxtWishListNormEmpty
        '
        Me.TxtWishListNormEmpty.EditValue = 0
        Me.TxtWishListNormEmpty.Enabled = False
        Me.TxtWishListNormEmpty.Location = New System.Drawing.Point(995, 186)
        Me.TxtWishListNormEmpty.Name = "TxtWishListNormEmpty"
        Me.TxtWishListNormEmpty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListNormEmpty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListNormEmpty.Properties.ReadOnly = True
        Me.TxtWishListNormEmpty.Size = New System.Drawing.Size(100, 20)
        Me.TxtWishListNormEmpty.TabIndex = 65
        '
        'TxtWishListNormLess20
        '
        Me.TxtWishListNormLess20.EditValue = 0
        Me.TxtWishListNormLess20.Enabled = False
        Me.TxtWishListNormLess20.Location = New System.Drawing.Point(995, 212)
        Me.TxtWishListNormLess20.Name = "TxtWishListNormLess20"
        Me.TxtWishListNormLess20.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListNormLess20.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtWishListNormLess20.Properties.ReadOnly = True
        Me.TxtWishListNormLess20.Size = New System.Drawing.Size(100, 20)
        Me.TxtWishListNormLess20.TabIndex = 66
        '
        'TxtDvdHighSent
        '
        Me.TxtDvdHighSent.EditValue = 0
        Me.TxtDvdHighSent.Enabled = False
        Me.TxtDvdHighSent.Location = New System.Drawing.Point(995, 102)
        Me.TxtDvdHighSent.Name = "TxtDvdHighSent"
        Me.TxtDvdHighSent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdHighSent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdHighSent.Properties.ReadOnly = True
        Me.TxtDvdHighSent.Size = New System.Drawing.Size(100, 20)
        Me.TxtDvdHighSent.TabIndex = 62
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(872, 101)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl6.TabIndex = 57
        Me.LabelControl6.Text = "Dvd High Sent"
        '
        'TxtDvdMediumSent
        '
        Me.TxtDvdMediumSent.EditValue = 0
        Me.TxtDvdMediumSent.Enabled = False
        Me.TxtDvdMediumSent.Location = New System.Drawing.Point(995, 128)
        Me.TxtDvdMediumSent.Name = "TxtDvdMediumSent"
        Me.TxtDvdMediumSent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdMediumSent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdMediumSent.Properties.ReadOnly = True
        Me.TxtDvdMediumSent.Size = New System.Drawing.Size(100, 20)
        Me.TxtDvdMediumSent.TabIndex = 59
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(872, 124)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl8.TabIndex = 58
        Me.LabelControl8.Text = "Dvd Medium Sent"
        '
        'TxtDvdLowSent
        '
        Me.TxtDvdLowSent.EditValue = 0
        Me.TxtDvdLowSent.Enabled = False
        Me.TxtDvdLowSent.Location = New System.Drawing.Point(995, 154)
        Me.TxtDvdLowSent.Name = "TxtDvdLowSent"
        Me.TxtDvdLowSent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdLowSent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdLowSent.Properties.ReadOnly = True
        Me.TxtDvdLowSent.Size = New System.Drawing.Size(100, 20)
        Me.TxtDvdLowSent.TabIndex = 61
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(872, 153)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl9.TabIndex = 60
        Me.LabelControl9.Text = "Dvd Low Sent"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 294)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Priority Rating"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 259)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl2.TabIndex = 53
        Me.LabelControl2.Text = "Custom Served Rating"
        '
        'TxtDvdAvailable
        '
        Me.TxtDvdAvailable.EditValue = 0
        Me.TxtDvdAvailable.Enabled = False
        Me.TxtDvdAvailable.Location = New System.Drawing.Point(444, 102)
        Me.TxtDvdAvailable.Name = "TxtDvdAvailable"
        Me.TxtDvdAvailable.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdAvailable.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDvdAvailable.Properties.ReadOnly = True
        Me.TxtDvdAvailable.Size = New System.Drawing.Size(100, 20)
        Me.TxtDvdAvailable.TabIndex = 52
        '
        'txtEndTime
        '
        Me.txtEndTime.EditValue = New Date(CType(0, Long))
        Me.txtEndTime.Enabled = False
        Me.txtEndTime.Location = New System.Drawing.Point(155, 178)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEndTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtEndTime.Size = New System.Drawing.Size(129, 20)
        Me.txtEndTime.TabIndex = 51
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(40, 179)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl26.TabIndex = 50
        Me.LabelControl26.Text = "End Time"
        '
        'txtStartTime
        '
        Me.txtStartTime.EditValue = New Date(CType(0, Long))
        Me.txtStartTime.Enabled = False
        Me.txtStartTime.Location = New System.Drawing.Point(155, 154)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStartTime.Size = New System.Drawing.Size(129, 20)
        Me.txtStartTime.TabIndex = 49
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(40, 155)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl25.TabIndex = 48
        Me.LabelControl25.Text = "Start Time"
        '
        'btnStartABO2
        '
        Me.btnStartABO2.Location = New System.Drawing.Point(648, 48)
        Me.btnStartABO2.Name = "btnStartABO2"
        Me.btnStartABO2.Size = New System.Drawing.Size(168, 37)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnStartABO2.SuperTip = SuperToolTip1
        Me.btnStartABO2.TabIndex = 43
        Me.btnStartABO2.Text = "START"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(319, 247)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl21.TabIndex = 38
        Me.LabelControl21.Text = "Norm Compensation"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(319, 276)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl22.TabIndex = 39
        Me.LabelControl22.Text = "Adult Compensation"
        '
        'txtNormCompensation
        '
        Me.txtNormCompensation.EditValue = 0
        Me.txtNormCompensation.Enabled = False
        Me.txtNormCompensation.Location = New System.Drawing.Point(444, 247)
        Me.txtNormCompensation.Name = "txtNormCompensation"
        Me.txtNormCompensation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormCompensation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormCompensation.Properties.ReadOnly = True
        Me.txtNormCompensation.Size = New System.Drawing.Size(100, 20)
        Me.txtNormCompensation.TabIndex = 40
        '
        'txtAdultCompensation
        '
        Me.txtAdultCompensation.EditValue = 0
        Me.txtAdultCompensation.Enabled = False
        Me.txtAdultCompensation.Location = New System.Drawing.Point(444, 273)
        Me.txtAdultCompensation.Name = "txtAdultCompensation"
        Me.txtAdultCompensation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultCompensation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultCompensation.Properties.ReadOnly = True
        Me.txtAdultCompensation.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultCompensation.TabIndex = 41
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridCustResult)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1275, 377)
        Me.XtraTabPage2.Text = "Customers Result"
        '
        'GridCustResult
        '
        Me.GridCustResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustResult.EmbeddedNavigator.Name = ""
        Me.GridCustResult.FormsUseDefaultLookAndFeel = False
        Me.GridCustResult.Location = New System.Drawing.Point(0, 0)
        Me.GridCustResult.MainView = Me.GridViewCust
        Me.GridCustResult.Name = "GridCustResult"
        Me.GridCustResult.Size = New System.Drawing.Size(1275, 377)
        Me.GridCustResult.TabIndex = 0
        Me.GridCustResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCust, Me.GridView1})
        '
        'GridViewCust
        '
        Me.GridViewCust.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewCust.FooterPanelHeight = 2
        Me.GridViewCust.GridControl = Me.GridCustResult
        Me.GridViewCust.Name = "GridViewCust"
        Me.GridViewCust.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1735
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridCustResult
        Me.GridView1.Name = "GridView1"
        '
        'DS
        '
        Me.DS.DataSetName = "dsABOProcess"
        Me.DS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmABOProcessNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1284, 438)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmABOProcessNew"
        Me.Text = "ABO Process"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormToSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultToSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpNotServed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpNotServed.ResumeLayout(False)
        Me.gpNotServed.PerformLayout()
        CType(Me.TxtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRankTooLow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXDvdNotFound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXTooManyHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXSuspended.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersServed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersNotServed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.TxtCustomServedRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPriorityRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDvdSentRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtWishListAdultEmpty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtWishListAdultLess20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtWishListNormEmpty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtWishListNormLess20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDvdHighSent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDvdMediumSent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDvdLowSent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDvdAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormCompensation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultCompensation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim DS As New dsABOProcess
    Dim SQLCustomers As String
    Dim SQLProducts_DVD As String
    Dim SQLWishList As String
    Dim SQLCompensation As String
    Dim WLView As DataView
    Dim CustView As DataView
    Dim tabError As New ArrayList 'prend les erreurs du try catch de la methode aboProcess

    Dim _MaxDVDSendByCustomers As Integer
    Dim _ProductView As DataView
    Dim _WLSerieViewAll As DataView
    Dim _WLSerieViewFiltered As DataView
    Dim _ProductRow As DataRowView
    Dim _ProductRows() As DataRowView

    Dim _IsDVDFound As Boolean
    Dim _IsCompensation As Boolean
    Dim _PRoductType As String = ""
    Const DVDNORM As String = "DVD_NORM"

    ' Dim _iStart, _iEnd, _iStep As Integer
    'Dim _AtLeastOneHasBeenServed As Boolean = False
    ' Dim _boolSerieNumberTooBig As Boolean = False


    'Dim _NormToSend As Integer = 0
    'Dim _AdultToSend As Integer = 0
    'Dim _NormCompensation As Integer = 0
    'Dim _AdultCompensation As Integer = 0
    ' Dim _IsCustInNeed As Boolean = False
    'Dim _WLRows() As DataRowView
    Dim _i As Integer = 0
    Dim _Current_Customer_Rank As Integer = 0
    Dim _Fully_Shipped As Boolean = False


    Dim _AboProcessData As DvdPostData.AboProcessData
    Dim _AboStat As DvdPostData.StatAbo

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub frmABOProcessV2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridCustResult.ContextMenuStrip = menuStrip

        'DS.Tables.Add("customers")
        DS.Tables.Add("products_dvd")
        DvdPostData.clsConnection.ExecuteNonQuery("update products_dvd p set last_admindate = now() where last_admindate = '0000-00-00 00:00:00'")
        _AboProcessData = New DvdPostData.AboProcessData()
        _AboStat = New DvdPostData.StatAbo()
    End Sub

    Private Sub cleanTable()
        DS.Tables("customers").Clear()
        DS.Tables("products_dvd").Clear()
        DS.Tables("wishlist").Clear()
    End Sub

    Private Sub AttributionDVDCustomer(ByRef CustomerStat As DvdPostData.Customer_stat, ByVal maxDVD As Integer, ByVal compensation As Integer, ByVal dv As DataView, ByVal customers_id As Integer)

        Dim dr As DataRowView
        Dim cptNoCompensation As Integer = maxDVD - compensation
        For index As Integer = 1 To maxDVD

            dr = dv(index - 1)
            AssignDVD(cptNoCompensation <= 0, dr("wl_id"), dr("products_id"), customers_id, dr("products_dvdid"))
            LockDVDProduct(dr("products_id"))
            StatAddDvdSend(CustomerStat, dr("ProductType").ToString(), Integer.Parse(dr("priority")), cptNoCompensation <= 0)
            cptNoCompensation -= 1
        Next


    End Sub

    Private Function FilterAvailableDVD(ByRef typeDvdCustomer As DvdPostData.Customer_TypeDvd, ByVal custRow As DataRowView, ByVal PRoductType As String) As DataView

        Dim dv_DVDWishlist As DataView = Nothing

        DS.Tables("customers_" & PRoductType).Clear()
        WLView = New DataView(DS.Tables("wishlist"), "wishlist_type = '" & PRoductType & "'", "imdb_id,products_series_id, products_series_number,priority,date_added", DataViewRowState.CurrentRows)
        StatAddWishlist(WLView.Count, PRoductType)
        typeDvdCustomer.dvd_wishlist = WLView.Count

        If WLView.Count > 0 Then
            ChooseDVDinWishlistInStock(custRow, PRoductType)
            dv_DVDWishlist = New DataView(DS.Tables("customers_" & PRoductType), " ", "priority,imdb_id,products_series_id, products_series_number", DataViewRowState.CurrentRows)
        End If
        Return dv_DVDWishlist

    End Function

    Private Sub loadGridCustomerStat()

        Dim aboprocess_id As Integer = GetAboprocess_id()
        Dim dtCustomersStat As DataTable = New DataTable()
        'CustView = New DataView(dtCustomersStat, "", "IsCompensation desc,customers_abo_rank desc, customers_id ", DataViewRowState.CurrentRows)
        Dim sql As String = _AboProcessData.GetCustomersAboprocessStats(aboprocess_id)
        DvdPostData.clsConnection.FillDataSet(dtCustomersStat, sql)

        Dim colStat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1.Columns.Clear()
        Me.GridViewCust.Columns.Clear()

        For Each col As DataColumn In dtCustomersStat.Columns
            colStat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

            colStat.Caption = col.ColumnName
            colStat.FieldName = col.ColumnName
            colStat.Name = col.ColumnName
            colStat.Visible = True
            colStat.OptionsColumn.ReadOnly = True


            Me.GridBand1.Columns.Add(colStat)
            'Me.GridViewCust.Columns.Add(colStat)


        Next

        Me.GridCustResult.DataSource = dtCustomersStat
        Me.GridCustResult.Views(0).PopulateColumns()



    End Sub

    Private Sub aboprocess_main(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Go through Customers ONE by ONE and assign all DVD Neede for the selected Customer
        'Then Move to next Customer

        _AboStat.clear()
        '' load Customer with abo
        loadInfoToProcess()

        txtStartTime.DateTime = Now()

        'Reset Customers.abo_not_Served_reason to ZERO
        ' a mediter 
        ' DvdPostData.clsConnection.ExecuteNonQuery("UPDATE customers set abo_not_served_reason = 0")


        CustView = New DataView(DS.Tables("customers"), "", "IsCompensation desc,customers_abo_rank desc, customers_id ", DataViewRowState.CurrentRows)
        _MaxDVDSendByCustomers = System.Configuration.ConfigurationManager.AppSettings("MaxDVDSendByCustomer")
        txtTotalCustomers.EditValue = CustView.Count
        Dim DVDAvailableInStock As Integer = DS.Tables("products_dvd").Rows.Count()
        TxtDvdAvailable.EditValue = DVDAvailableInStock
        If CustView.Count > 0 And DVDAvailableInStock > 0 And _MaxDVDSendByCustomers > 0 Then
            aboprocess()
            DvdPostData.clsConnection.ExecuteNonQuery(_AboStat.StrUpdateStat(txtStartTime.DateTime))
            ' update aboprocess_id 
            Dim aboprocess_id As Integer = GetAboprocess_id()
            DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.Customer_stat.StrUpdateAboprocessId(aboprocess_id))
            DisplayStat()
            loadGridCustomerStat()
        Else
            MsgBox("Error to process Abo Process", MsgBoxStyle.Exclamation)
        End If
        'Me.GridCustResult.DataSource = dtCustomersStat

        'End If
        MsgBox("ABO Process Complete", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub DisplayStat()

        txtTotalCustomers.EditValue = _AboStat.CptCustomer
        TxtDvdAvailable.EditValue = _AboStat.CptDVDAvailable
        txtEndTime.DateTime = _AboStat.EndTime

        txtNormToSend.EditValue = _AboStat.CptDVDSendNorm
        txtAdultToSend.EditValue = _AboStat.CptDVDSendAdult

        txtNormCompensation.EditValue = _AboStat.CptDVDSendCompNorm
        txtAdultCompensation.EditValue = _AboStat.CptDVDSendCompAdult


        txtCustomersNotServed.EditValue = _AboStat.CptCustomerNoServed
        txtCustomersServed.EditValue = _AboStat.CptCustomerServed

        txtXCredit.EditValue = _AboStat.CptCustomerNoServedNoCredit
        txtXDvdNotFound.EditValue = _AboStat.CptCustomerNoServedNotFindDVD
        txtXSuspended.EditValue = _AboStat.CptCustomerNoServedSuspended
        txtXTooManyHome.EditValue = _AboStat.CptCustomerNoServedAtHome
        TxtRankTooLow.EditValue = _AboStat.CPTCustomerNotServedAttributedRanktoolow
        TxtError.EditValue = _AboStat.CPTError

        TxtDvdHighSent.EditValue = _AboStat.CPTDVDSentHigh
        TxtDvdMediumSent.EditValue = _AboStat.CPTDVDSentMedium
        TxtDvdLowSent.EditValue = _AboStat.CPTDVDSentLow

        TxtWishListNormEmpty.EditValue = _AboStat.CptDVDWishlistNormEmpty
        TxtWishListNormLess20.EditValue = _AboStat.CptDVDWishlistNormLess20

        TxtWishListAdultEmpty.EditValue = _AboStat.CptDVDWishlistAdultEmpty
        TxtWishListAdultLess20.EditValue = _AboStat.CptDVDWishlistAdultLess20

        TxtDvdSentRating.EditValue = _AboStat.GetRate_DVD_Served & " %"
        TxtCustomServedRating.EditValue = _AboStat.GetRate_Cust_Served & " %"
        TxtPriorityRating.EditValue = _AboStat.GetMetricsFormat(_AboStat.GetMetricsPriority) & " %"


    End Sub


    Private Sub loadInfoToProcess()
        ResetCounters()
        LoadCustomersInProcess()
        loadCompensations()
        LoadAvailablesDVDList()
        loadGridCustomerStat()

    End Sub
    Private Sub btnLoadInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInfo.Click
        loadInfoToProcess()
    End Sub

    Private Sub loadCompensations()
        '' load compensation
        SQLCompensation = _AboProcessData.GetSqlCompensation
        DvdPostData.clsConnection.FillDataSet(DS.Tables("compensation_summary"), SQLCompensation)

    End Sub
    Private Sub LoadCustomersInProcess()
        cleanTable()

        If txtFromCustomerID.EditValue = 0 And txtToCustomerID.EditValue = 9999999 Then
            SQLCustomers = _AboProcessData.GetCustomerwithAbo

        Else
            SQLCustomers = _AboProcessData.GetCustomerwithAbo(Integer.Parse(txtFromCustomerID.EditValue), Integer.Parse(txtToCustomerID.EditValue))
        End If

        DvdPostData.clsConnection.FillDataSet(DS.Tables("customers"), SQLCustomers)


        txtTotalCustomers.EditValue = DS.Tables("customers").Rows.Count
        _AboStat.CptCustomer = txtTotalCustomers.EditValue
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue


    End Sub
    Private Sub LoadAvailablesDVDList()

        DS.Tables("products_dvd").Clear()
        '' load dvd in stock 
        SQLProducts_DVD = _AboProcessData.GetProductDVDAvailable

        DvdPostData.clsConnection.FillDataSet(DS.Tables("products_dvd"), SQLProducts_DVD)
        'DS.Tables("products_dvd").PrimaryKey = New DataColumn() {DS.Tables("products_dvd").Columns("products_id"), _
        '                                                         DS.Tables("products_dvd").Columns("products_dvdid")}

        _AboStat.CptDVDAvailable = DS.Tables("products_dvd").Rows.Count
        TxtDvdAvailable.EditValue = _AboStat.CptDVDAvailable
        _ProductView = New DataView(DS.Tables("products_dvd"), " ", "products_id, inout", DataViewRowState.CurrentRows)
        _ProductView.Sort = "products_id"
    End Sub

    Private Sub getDvdToSend(ByVal rank As Integer, _
                             ByVal credit As Integer, _
                            ByVal NormToSend As Integer, _
                            ByVal AdultToSend As Integer, _
                            ByRef NormCompensation As Integer, _
                            ByRef AdultCompensation As Integer, _
                            ByVal DVDNormfind As Integer, _
                            ByVal DVDAdultfind As Integer, _
                            ByVal Abo_monoship As Boolean, _
                            ByRef dvdNormResult As Integer, _
                            ByRef dvdAdultResult As Integer)
        Dim monoship As Boolean
        Dim nbMaxrank As Integer
        nbMaxrank = Configuration.ConfigurationManager.AppSettings("MaxRank")

        monoship = rank > nbMaxrank Or Abo_monoship Or NormCompensation > 0 Or AdultCompensation > 0

        ' don't depass the amount credit or if credit = 0 => customer is illimited

        If (NormToSend + AdultToSend > credit And credit > 0) Then
            Dim ok As Boolean = False
            Dim index As Integer = 0
            While (Not ok)
                If (NormToSend > 0) And ((index Mod 2 = 0) Or (AdultToSend = 0)) Then
                    NormToSend -= 1
                ElseIf (AdultToSend > 0) And ((index Mod 2 = 0) Or (NormToSend = 0)) Then
                    AdultToSend -= 1
                End If
                ok = (NormToSend + AdultToSend = credit) Or (NormToSend + AdultToSend = 0)
                index += 1
            End While
        End If

        dvdNormResult = Math.Min(NormToSend + NormCompensation, DVDNormfind)
        dvdAdultResult = Math.Min(AdultToSend + AdultCompensation, DVDAdultfind)



        Dim result As Integer
        If Not monoship Then

            result = dvdNormResult + dvdAdultResult
            ' si c'est impair (monoship) => transformer en pair 
            If result Mod 2 = 1 Then

                If dvdNormResult > dvdAdultResult Then
                    dvdNormResult -= 1
                Else
                    dvdAdultResult -= 1
                End If

            End If

        End If

        ' limiter le nombre de dvd a 4 par envoie par personne 
        ' souci comment savoir que le lendemain le customer a droit a encore X dvd 
        ' solution decompter les compensation a la fin 
        If (dvdNormResult + dvdAdultResult) > _MaxDVDSendByCustomers Then

            Dim ok As Boolean = False
            Dim index As Integer = 0
            While (Not ok)
                If (dvdNormResult > 0) And ((index Mod 2 = 0) Or (dvdAdultResult = 0)) Then
                    dvdNormResult -= 1
                    NormCompensation -= 1
                ElseIf (dvdAdultResult > 0) And ((index Mod 2 = 0) Or (dvdNormResult = 0)) Then
                    dvdAdultResult -= 1
                    AdultCompensation -= 1
                End If
                ok = (dvdNormResult + dvdAdultResult = _MaxDVDSendByCustomers)
                index += 1
            End While

        End If
    End Sub

    Private Sub aboprocess()

        Dim NormToSend As Integer = 0
        Dim AdultToSend As Integer = 0
        Dim NormCompensation As Integer = 0
        Dim AdultCompensation As Integer = 0

        Dim processCustom As Boolean
        Dim cptDVDNormRequest As Integer
        Dim cptDVDAdultRequest As Integer
        Dim customers_id As Integer

        Dim IsCustomerServed As Boolean

        Dim customerStat As DvdPostData.Customer_stat = Nothing

        Dim custRow As DataRowView

        Dim cptStockDVDNormFound As Integer
        Dim cptStockDVDAdultFound As Integer
        Dim dv_DVDWishlistNormFound As DataView
        Dim dv_DVDWishlistAdultFound As DataView
        Dim DVDNormCalculated As Integer
        Dim DVDAdultCalculated As Integer



        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        ' each customers that have a abo ok
        For Each custRow In CustView
            Try

                _i += 1
                txtCustomersToProcess.EditValue -= 1
                If _i Mod 100 = 0 Then
                    DoEvents()
                End If
                customers_id = custRow("customers_id")
                customerStat = New DvdPostData.Customer_stat(customers_id)
                customerStat.rank = custRow("customers_abo_rank")
                customerStat.credit = custRow("customers_abo_dvd_credit")

                'Cacl how many DVD to assin, Why Customer should not be served ....
                processCustom = CalcHowManyToAssign(customerStat, custRow, NormToSend, AdultToSend)

                NormCompensation = customerStat.dvd_norm.dvd_compensation
                AdultCompensation = customerStat.dvd_adult.dvd_compensation
                cptDVDNormRequest = NormToSend + NormCompensation
                cptDVDAdultRequest = AdultToSend + AdultCompensation

                If processCustom Then

                    _AboStat.CptDVDask += cptDVDNormRequest + cptDVDAdultRequest
                    DS.Tables("wishlist").Clear()

                    ' load dvd in wishlist customer 
                    SQLWishList = _AboProcessData.GetSqlWishList(customers_id)
                    DvdPostData.clsConnection.FillDataSet(DS.Tables("wishlist"), SQLWishList)
                    ' load dvd Series

                    _PRoductType = "DVD_NORM" 'Default

                    dv_DVDWishlistNormFound = Nothing
                    dv_DVDWishlistAdultFound = Nothing

                    cptStockDVDNormFound = 0
                    cptStockDVDAdultFound = 0

                    Dim wishlistEmpty As Boolean = False
                    If (customerStat.dvd_norm.dvd_abo + customerStat.dvd_norm.dvd_compensation > 0) Then
                        ' NORM DVD
                        _PRoductType = "DVD_NORM"
                        dv_DVDWishlistNormFound = FilterAvailableDVD(customerStat.dvd_norm, custRow, _PRoductType)
                        If dv_DVDWishlistNormFound IsNot Nothing Then
                            ' dv_DVDWishlistNorm.Count = 0 => dvdNotFound
                            cptStockDVDNormFound = dv_DVDWishlistNormFound.Count
                            customerStat.dvd_norm.dvd_Find = cptStockDVDNormFound
                        ElseIf customerStat.dvd_norm.dvd_wishlist = 0 Then
                            ' wishlist empty 
                            If cptDVDNormRequest > 0 Then wishlistEmpty = True
                        End If
                    End If
                    ' ADULT DVD
                    If (customerStat.dvd_adult.dvd_abo + customerStat.dvd_adult.dvd_compensation > 0) Then
                        _PRoductType = "DVD_ADULT"
                        dv_DVDWishlistAdultFound = FilterAvailableDVD(customerStat.dvd_adult, custRow, _PRoductType)
                        If dv_DVDWishlistAdultFound IsNot Nothing Then
                            cptStockDVDAdultFound = dv_DVDWishlistAdultFound.Count
                            customerStat.dvd_adult.dvd_Find = cptStockDVDAdultFound
                        ElseIf customerStat.dvd_adult.dvd_wishlist = 0 Then
                            ' wishlist empty 
                            If cptDVDAdultRequest > 0 Then wishlistEmpty = True
                        End If
                    End If



                    getDvdToSend(custRow("customers_abo_rank"), _
                                custRow("customers_abo_dvd_credit"), _
                                NormToSend, _
                                AdultToSend, _
                                NormCompensation, _
                                AdultCompensation, _
                                cptStockDVDNormFound, _
                                cptStockDVDAdultFound, IsMonoShippment(custRow), DVDNormCalculated, DVDAdultCalculated)

                    AttributionDVDCustomer(customerStat, DVDNormCalculated, NormCompensation, dv_DVDWishlistNormFound, customers_id)
                    AttributionDVDCustomer(customerStat, DVDAdultCalculated, AdultCompensation, dv_DVDWishlistAdultFound, customers_id)

                    customerStat.dvd_norm.dvd_send = DVDNormCalculated
                    customerStat.dvd_adult.dvd_send = DVDAdultCalculated

                    IsCustomerServed = (DVDNormCalculated + DVDAdultCalculated) > 0
                    If (Not wishlistEmpty) Then
                        manageRank(BKGlobal.Cls1, customers_id, IsCustomerServed)
                    End If

                    If IsCustomerServed Then

                        _AboStat.CptCustomerServed += 1

                        If (cptStockDVDNormFound < cptDVDNormRequest And cptDVDNormRequest > 0) _
                        Or (cptStockDVDAdultFound < cptDVDAdultRequest And cptDVDAdultRequest > 0) Then
                            _AboStat.CPTCustomerPartialServed += 1
                            customerStat.reason = DvdPostData.Customer_stat.TypeReason.PARTIAL_SERVED
                        End If
                    Else
                        _AboStat.CptCustomerNoServed += 1

                        If (wishlistEmpty) Then
                            customerStat.reason = DvdPostData.Customer_stat.TypeReason.WISHEMPTY
                        ElseIf (cptStockDVDNormFound = 0 And cptDVDNormRequest > 0) Or (cptStockDVDAdultFound = 0 And cptDVDAdultRequest > 0) Then
                            _AboStat.CptCustomerNoServedNotFindDVD += 1
                            customerStat.reason = DvdPostData.Customer_stat.TypeReason.NOTFOUNDDVD
                        ElseIf (cptDVDNormRequest > 0 And DVDNormCalculated = 0) Or (cptDVDAdultRequest > 0 And DVDAdultCalculated = 0) Then
                            _AboStat.CPTCustomerNotServedAttributedRanktoolow += 1
                            customerStat.reason = DvdPostData.Customer_stat.TypeReason.RANKTOOLOW
                        Else
                            customerStat.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
                        End If

                    End If


                End If

            Catch ex As System.Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Abo_Process, ex)
                tabError.Add("customer ID : " + custRow("customers_id").ToString + " " + ex.Message.ToString)
                customerStat.msgError = ex.Message
                customerStat.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
                _AboStat.CPTError += 1
            Finally
                DvdPostData.clsConnection.ExecuteNonQuery(customerStat.strUpdateStatCustomer())

            End Try


        Next 'Each Customers

    End Sub

    Private Sub UpdateCredit(ByVal ds As BizzLib.clsDataSet, ByVal maxDVDSEnd As Integer, ByVal customers_id As Integer)

    End Sub

    Private Sub manageRank(ByVal ds As BizzLib.clsDataSet, ByVal customers_id As Integer, ByVal iscustomerServed As Boolean)

        If iscustomerServed Then
            ds.ExecuteNonQuery("update customers set customers_abo_rank = 0 where customers_id = " & customers_id)
        Else
            ds.ExecuteNonQuery("update customers set customers_abo_rank = customers_abo_rank + 1 where customers_id = " & customers_id)
        End If
    End Sub

    ''' <summary>
    ''' delete the product of the view product
    ''' </summary>
    ''' <param name="product_id"></param>
    ''' <remarks></remarks>
    Private Sub LockDVDProduct(ByVal product_id As Integer)
        'Dim lstdrv As DataRowView()
        'lstdrv = _ProductView.FindRows(New Object() {product_id, 1})
        'Dim i As Integer = _ProductView.Find(New Object() {product_id, 1})
        Dim i As Integer = _ProductView.Find(product_id)
        _ProductView.Delete(i)
    End Sub

    Private Sub StatAddWishlist(ByVal cptDvd As Integer, ByVal PRoductType As String)

        Select Case PRoductType
            Case "DVD_NORM"

                If cptDvd = 0 Then
                    _AboStat.CptDVDWishlistNormEmpty += 1
                ElseIf cptDvd < 20 Then
                    _AboStat.CptDVDWishlistNormLess20 += 1
                End If
            Case "DVD_ADULT"
                If cptDvd = 0 Then
                    _AboStat.CptDVDWishlistAdultEmpty += 1
                ElseIf cptDvd < 20 Then
                    _AboStat.CptDVDWishlistAdultLess20 += 1
                End If
        End Select

    End Sub

    Private Sub StatAddDvdSend(ByRef CustomerStat As DvdPostData.Customer_stat, ByVal PRoductType As String, ByVal priority As Integer, ByVal isCompensation As Boolean)

        _AboStat.CptDVDSend += 1
        Select Case PRoductType
            Case "DVD_NORM"
                _AboStat.CptDVDSendNorm += 1
                If isCompensation Then
                    _AboStat.CptDVDSendCompNorm += 1
                End If
            Case "DVD_ADULT"
                _AboStat.CptDVDSendAdult += 1
                If isCompensation Then
                    _AboStat.CptDVDSendCompAdult += 1
                End If
        End Select

        _AboStat.addPriority(CustomerStat, priority)

    End Sub

    Private Sub AddDvdInTemporary(ByVal custRow As DataRowView, _
                                  ByVal customers_id As Integer, _
                                  ByVal products_id As Integer, _
                                  ByVal products_dvdid As Integer, _
                                  ByVal wl_id As Integer, _
                                  ByVal priority As Integer, _
                                  ByVal productType As String, _
                                  ByVal imdb_id As Integer, _
                                  ByVal products_series_id As Integer, _
                                  ByVal products_series_number As Integer)


        Dim __row As DataRow = DS.Tables("customers_" & productType).NewRow
        __row("customers_id") = customers_id
        __row("products_id") = products_id
        __row("products_dvdid") = products_dvdid
        __row("wl_id") = wl_id
        __row("priority") = priority
        __row("ProductType") = productType
        __row("imdb_id") = imdb_id
        __row("products_series_id") = products_series_id
        __row("products_series_number") = products_series_number
        DS.Tables("customers_" & productType).Rows.Add(__row)



    End Sub
    Private Function GetProductAvailable(ByVal product_id As Integer) As DataRowView()

        _ProductRows = _ProductView.FindRows(product_id)
        Return _ProductRows


    End Function

    Private Function IsSerieDVD(ByVal WLRow As DataRowView) As Boolean

        Return (Not WLRow("products_series_id") Is DBNull.Value) AndAlso (WLRow("products_series_id") <> 0)
    End Function
    ''' <summary>
    ''' save the dvd list of customer in the temporary table 
    ''' </summary>
    ''' <param name="PRoductType"></param>
    ''' <remarks></remarks>
    Private Sub ChooseDVDinWishlistInStock(ByVal custRow As DataRowView, ByVal PRoductType As String) '(ByVal _WLRows() As DataRowView)
        Dim _WLRow As DataRowView

        Dim lstDataRowView As DataRowView()
        Dim _IsPendingOrderExist As Boolean = False
        Dim customers_id As Integer = custRow("customers_id")
        Dim index As Integer = 0
        Dim prioritySerie As Integer

        While index < WLView.Count

            _WLRow = WLView(index)
            ' find dvd in stock 
            lstDataRowView = GetProductAvailable(_WLRow("product_id"))

            'Checking for the Serie
            If IsSerieDVD(_WLRow) Then

                If lstDataRowView.Length > 0 Then 'A Product Row is found.

                    _ProductRow = lstDataRowView(0)

                    Dim lstdr As DataRow() = DS.Tables("customers_" & PRoductType).Select("imdb_id = " & _ProductRow("imdb_id"))
                    If lstdr.Length > 0 Then
                        prioritySerie = lstdr(0)("priority")
                    Else
                        prioritySerie = _WLRow("priority")
                    End If
                    AddDvdInTemporary(custRow, _
                                      customers_id, _
                                      _ProductRow("products_id"), _
                                      _ProductRow("products_dvdid"), _
                                      _WLRow("wl_id"), _
                                      prioritySerie, _
                                      PRoductType, _
                                      _ProductRow("imdb_id"), _
                                      _ProductRow("products_series_id"), _
                                      _ProductRow("products_series_number"))

                Else
                    ' by pass the others dvd with the same imdb_id with number serie High to avoid receive dvd with more high number
                    Dim imdb_old As Integer
                    imdb_old = _WLRow("imdb_id")
                    While index < WLView.Count AndAlso imdb_old = WLView(index)("imdb_id")
                        index += 1
                    End While
                    index -= 1

                End If

            Else ' not serie
                If lstDataRowView.Length > 0 Then 'A Product Row is found.
                    _ProductRow = lstDataRowView(0)
                    AddDvdInTemporary(custRow, _
                                      customers_id, _
                                     _ProductRow("products_id"), _
                                     _ProductRow("products_dvdid"), _
                                     _WLRow("wl_id"), _
                                     _WLRow("priority"), _
                                      PRoductType, _
                                     _ProductRow("imdb_id"), _
                                     _ProductRow("products_series_id"), _
                                     _ProductRow("products_series_number"))
                End If
            End If ' serial 

            index += 1
        End While 'Each WishList Entry


    End Sub

    Private Function GetCptDVDNorm(ByRef customerStat As DvdPostData.Customer_stat, ByVal vCustRow As DataRowView) As Integer
        Return GetCptDVD(customerStat.dvd_norm, vCustRow, "customers_abo_dvd_norm", "customers_abo_dvd_home_norm")
    End Function

    Private Function GetCptDVDadult(ByRef customerStat As DvdPostData.Customer_stat, ByVal vCustRow As DataRowView) As Integer
        Return GetCptDVD(customerStat.dvd_adult, vCustRow, "customers_abo_dvd_adult", "customers_abo_dvd_home_adult")
    End Function

    Private Function GetCptDVD(ByRef typeDvdCustomer As DvdPostData.Customer_TypeDvd, ByVal vCustRow As DataRowView, ByVal DVD As String, ByVal DVD_HOME As String) As Integer

        Dim cptdvd As Integer
        typeDvdCustomer.dvd_abo = vCustRow(DVD)
        typeDvdCustomer.dvd_home = vCustRow(DVD_HOME)

        cptdvd = typeDvdCustomer.dvd_abo - typeDvdCustomer.dvd_home
        '  If cptdvd < 0 Then cptdvd = 0

        Return cptdvd
    End Function

    Private Function IsSuspend(ByRef vCustRow As DataRowView) As Boolean

        Dim suspend As Boolean = vCustRow("customers_abo_suspended") > 0
        If suspend Then
            txtXSuspended.EditValue += 1
            txtCustomersNotServed.EditValue += 1
            _AboStat.CptCustomerNoServedSuspended += 1
            _AboStat.CptCustomerNoServed += 1

        End If
        Return suspend
    End Function

    Private Function IsMonoShippment(ByRef CustRow As DataRowView) As Boolean
        Return CustRow("customers_abo_type") < 17
    End Function

    Private Function IsCreditEnough(ByRef vCustRow As DataRowView) As Boolean
        Dim strcredit As String = "customers_abo_dvd_credit"
        Dim credit As Boolean = (vCustRow("Use_credit") = 1 And vCustRow(strcredit) > 0) Or (vCustRow("Use_credit") = 0)

        If Not credit Then
            vCustRow(strcredit) = 0
            txtXCredit.EditValue += 1
            ' _AboStat.CptCustomerNoServed += 1
            _AboStat.CptCustomerNoServedNoCredit += 1
            _AboStat.CptCustomerNoServed += 1
            txtCustomersNotServed.EditValue += 1
            '  vCustRow("NotServed") = 1
            ' vCustRow("NotEnoughtCredit") = 1

        End If
        Return credit
    End Function

    Private Function UpdateCreditCustomer(ByRef vCustRow As DataRowView, ByVal vToSend As Integer) As Integer
        Dim cptSend As Integer
        Dim strcredit As String = "customers_abo_dvd_credit"

        If (vCustRow("Use_credit") = 0) Then
            cptSend = vToSend
        Else
            cptSend = Math.Min(vToSend, vCustRow(strcredit))
            ' vCustRow(strcredit) = vCustRow(strcredit) - vToSend
        End If



        Return cptSend

    End Function

    Private Function GetCompensationNorm(ByVal customers_id As Integer) As Integer

        Return GetCompensation(customers_id, "DVD_NORM")

    End Function

    Private Function GetCompensationAdult(ByVal customers_id As Integer) As Integer
        Return GetCompensation(customers_id, "DVD_ADULT")

    End Function

    Private Function GetCompensation(ByVal customers_id As Integer, ByVal typeDvd As String) As Integer
        Dim _CompensationRow As DataRow
        Dim compensation As Integer = 0

        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {customers_id, typeDvd})
        If Not IsNothing(_CompensationRow) Then
            compensation = _CompensationRow("compensation_qty")
        End If
        Return compensation
    End Function

    Private Function GetAboprocess_id() As Integer
        Dim sql As String
        Dim aboprocess_id As Integer
        sql = "select max(aboprocess_id) aboprocess_id from aboprocess_stats "
        aboprocess_id = BKGlobal.ExecuteFindFieldValueINT("aboprocess_id", sql)
        Return aboprocess_id
    End Function
    Private Function CalcHowManyToAssign(ByRef customerStat As DvdPostData.Customer_stat, ByVal vCustRow As DataRowView, ByRef vNormToSend As Integer, ByRef vAdultToSend As Integer) As Boolean

        Dim compensation As Boolean

        Dim vNormCompensation As Integer
        Dim vAdultCompensation As Integer

        vNormToSend = GetCptDVDNorm(customerStat, vCustRow)
        vAdultToSend = GetCptDVDadult(customerStat, vCustRow)

        ' dvdnorm : 2 -> dvdnormHome : 0
        ' dvdadult : 0 -> dvdadulthome : 2
        ' how many dvdnorm and dvdadult ? 
        ' in this case 0 dvd sended but (2 norm and -2 adult) 

        Dim tmp As Integer = vNormToSend + vAdultToSend

        If tmp <= 0 Then
            vNormToSend = 0
            vNormToSend = 0
        End If

        vNormCompensation = 0
        vAdultCompensation = 0

        vNormCompensation = GetCompensationNorm(vCustRow("customers_id"))
        vAdultCompensation = GetCompensationAdult(vCustRow("customers_id"))

        customerStat.dvd_norm.dvd_compensation = vNormCompensation
        customerStat.dvd_adult.dvd_compensation = vAdultCompensation

        compensation = (vNormCompensation + vAdultCompensation) > 0
        'Check if suspended
        If IsSuspend(vCustRow) Then
            customerStat.reason = DvdPostData.Customer_stat.TypeReason.SUSPENDED
            Return False

        ElseIf (Not compensation) And Not IsCreditEnough(vCustRow) Then

            customerStat.reason = DvdPostData.Customer_stat.TypeReason.NOCREDIT
            Return False

        Else

            vNormToSend = UpdateCreditCustomer(vCustRow, vNormToSend)
            vAdultToSend = UpdateCreditCustomer(vCustRow, vAdultToSend)

            If vNormToSend + vNormCompensation + vAdultToSend + vAdultCompensation = 0 Then

                If (customerStat.dvd_norm.dvd_home + customerStat.dvd_adult.dvd_home > 0) Then
                    customerStat.reason = DvdPostData.Customer_stat.TypeReason.ATHOME
                    _AboStat.CptCustomerNoServedAtHome += 1
                Else
                    _AboStat.CPTError += 1
                    customerStat.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
                    customerStat.msgError = " 0 dvd At home and 0 dvd in rotation"

                End If ' customerStat.dvd_norm.dvd_home + customerStat.dvd_adult.dvd_home > 0

                _AboStat.CptCustomerNoServed += 1

                Return False

            End If ' vNormToSend + vAdultToSend = 0

        End If ' IsSuspend(vCustRow) 

        ' ok 

        Return (vNormToSend + vNormCompensation + vAdultToSend + vAdultCompensation) > 0
    End Function
    Private Sub ResetCounters()
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        txtTotalCustomers.EditValue = 0
        TxtDvdAvailable.EditValue = 0
        txtEndTime.DateTime = DateTime.MinValue

        txtNormToSend.EditValue = 0
        txtAdultToSend.EditValue = 0

        txtNormCompensation.EditValue = 0
        txtAdultCompensation.EditValue = 0


        txtCustomersNotServed.EditValue = 0
        txtCustomersServed.EditValue = 0

        txtXCredit.EditValue = 0
        txtXDvdNotFound.EditValue = 0
        txtXSuspended.EditValue = 0
        txtXTooManyHome.EditValue = 0
        TxtRankTooLow.EditValue = 0
        TxtError.EditValue = 0

        TxtDvdHighSent.EditValue = 0
        TxtDvdMediumSent.EditValue = 0
        TxtDvdLowSent.EditValue = 0

        TxtWishListNormEmpty.EditValue = 0
        TxtWishListNormLess20.EditValue = 0

        TxtWishListAdultEmpty.EditValue = 0
        TxtWishListAdultLess20.EditValue = 0

        TxtDvdSentRating.EditValue = 0 & " %"
        TxtCustomServedRating.EditValue = 0 & " %"
        TxtPriorityRating.EditValue = 0 & " %"

    End Sub
    Private Function AssignDVD(ByRef isCompensation As Boolean, ByRef wl_id As Integer, ByRef vProducts_id As Integer, ByRef customers_id As Integer, ByVal productDvD_id As Integer) As Integer
        Dim orders_id As Integer = 0
        Dim _DS As New dsProducts
        Dim _ObjProductsDvd As New clsProduct_DVD(SessionInfo, _DS, vProducts_id, productDvD_id)
        orders_id = _ObjProductsDvd.AssignDVD(isCompensation, wl_id, customers_id, DvdPostData.clsCreditHistory.ActionId.ABOPROCESS)
        Return orders_id
    End Function

    Private Sub btnStartABO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartABO2.Click
        aboprocess_main(sender, e)
    End Sub

End Class

