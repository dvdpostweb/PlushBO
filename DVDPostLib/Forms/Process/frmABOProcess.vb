Imports System.Windows.Forms.Application
Imports System.Threading
Imports BizzLib



Public Class frmABOProcess
    Inherits BizzLib.frmBKForm

    Private sem(4) As ManualResetEvent
    Private _AboProcess As New ClsABOProcess


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        _AboProcess.CustView = CustView
        _AboProcess.WLView = WLView
        _AboProcess.DS = DS
        _AboProcess.IsLoadComplete = IsLoadComplete
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
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalDVD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalWishList As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInfo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersToProcess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLoadInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtToCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromCustomerID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersInNeed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNormToSend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultToSend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpNotServed As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersServed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersNotServed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtXCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXThrotling As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXSuspended As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXTooManyHome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNormAssigned As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultAssigned As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultRating As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNormRating As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtXDvdNotFound As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkSimulation As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCustResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridViewCust As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents DS As DVDPostLib.dsABOProcess
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_dvd_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_dvd_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_dvd_home_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_dvd_home_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_dvd_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_rank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_multishipment As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coluse_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colthrottling As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo_suspended As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNormToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAdultToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNormAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAdultAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colInNeed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNotEnoughtCredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNoDVDFound As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTooManyAtHome As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnReOrderWhishList As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNormCompensation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAdultCompensation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnThrottling As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStartABO2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWLCount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtStartTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtEndTime As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnLoadInfo2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStartABO3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABOProcess))
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.lblTotalCustomers = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalCustomers = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersToProcess = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomersInNeed = New DevExpress.XtraEditors.TextEdit
        Me.txtNormToSend = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtAdultToSend = New DevExpress.XtraEditors.TextEdit
        Me.txtNormAssigned = New DevExpress.XtraEditors.TextEdit
        Me.txtAdultAssigned = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalDVD = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalWishList = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtAdultRating = New DevExpress.XtraEditors.TextEdit
        Me.txtNormRating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtInfo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.btnLoadInfo = New DevExpress.XtraEditors.SimpleButton
        Me.txtToCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.txtFromCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.gpNotServed = New DevExpress.XtraEditors.GroupControl
        Me.txtXDvdNotFound = New DevExpress.XtraEditors.TextEdit
        Me.txtXTooManyHome = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtXSuspended = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtXThrotling = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtXCredit = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersServed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersNotServed = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.chkSimulation = New DevExpress.XtraEditors.CheckEdit
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.btnStartABO3 = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadInfo2 = New DevExpress.XtraEditors.SimpleButton
        Me.txtEndTime = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtStartTime = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtWLCount = New DevExpress.XtraEditors.TextEdit
        Me.txtCustID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.btnStartABO2 = New DevExpress.XtraEditors.SimpleButton
        Me.btnThrottling = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtNormCompensation = New DevExpress.XtraEditors.TextEdit
        Me.txtAdultCompensation = New DevExpress.XtraEditors.TextEdit
        Me.btnReOrderWhishList = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridCustResult = New DevExpress.XtraGrid.GridControl
        Me.DS = New DVDPostLib.dsABOProcess
        Me.GridViewCust = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colcustomers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_dvd_norm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_dvd_adult = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_dvd_home_norm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_dvd_home_adult = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_dvd_credit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_rank = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_multishipment = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.coluse_credit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colthrottling = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colcustomers_abo_suspended = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNormToSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAdultToSend = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNormAssigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAdultAssigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colInNeed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colServed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNotServed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNotEnoughtCredit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNoDVDFound = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTooManyAtHome = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersInNeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormToSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultToSend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormAssigned.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultAssigned.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDVD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalWishList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpNotServed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpNotServed.SuspendLayout()
        CType(Me.txtXDvdNotFound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXTooManyHome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXSuspended.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXThrotling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtXCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersServed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersNotServed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSimulation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtEndTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWLCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNormCompensation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdultCompensation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.Location = New System.Drawing.Point(40, 128)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(78, 13)
        Me.lblTotalCustomers.TabIndex = 1
        Me.lblTotalCustomers.Text = "Total Customers"
        '
        'txtTotalCustomers
        '
        Me.txtTotalCustomers.Enabled = False
        Me.txtTotalCustomers.Location = New System.Drawing.Point(184, 128)
        Me.txtTotalCustomers.Name = "txtTotalCustomers"
        Me.txtTotalCustomers.Properties.ReadOnly = True
        Me.txtTotalCustomers.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCustomers.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 152)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Customers to Process"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(40, 176)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(121, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Customers Needing DVDs"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(40, 200)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "DVD Norm to Send"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(296, 200)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "DVD Adult to Send"
        '
        'txtCustomersToProcess
        '
        Me.txtCustomersToProcess.Enabled = False
        Me.txtCustomersToProcess.Location = New System.Drawing.Point(184, 152)
        Me.txtCustomersToProcess.Name = "txtCustomersToProcess"
        Me.txtCustomersToProcess.Properties.ReadOnly = True
        Me.txtCustomersToProcess.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersToProcess.TabIndex = 7
        '
        'txtCustomersInNeed
        '
        Me.txtCustomersInNeed.EditValue = 0
        Me.txtCustomersInNeed.Enabled = False
        Me.txtCustomersInNeed.Location = New System.Drawing.Point(184, 176)
        Me.txtCustomersInNeed.Name = "txtCustomersInNeed"
        Me.txtCustomersInNeed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersInNeed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersInNeed.Properties.ReadOnly = True
        Me.txtCustomersInNeed.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersInNeed.TabIndex = 8
        '
        'txtNormToSend
        '
        Me.txtNormToSend.EditValue = 0
        Me.txtNormToSend.Enabled = False
        Me.txtNormToSend.Location = New System.Drawing.Point(184, 200)
        Me.txtNormToSend.Name = "txtNormToSend"
        Me.txtNormToSend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormToSend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNormToSend.Properties.ReadOnly = True
        Me.txtNormToSend.Size = New System.Drawing.Size(100, 20)
        Me.txtNormToSend.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(40, 256)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "DVD Norm Assigned"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(296, 256)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "DVD Adult Assigned"
        '
        'txtAdultToSend
        '
        Me.txtAdultToSend.EditValue = 0
        Me.txtAdultToSend.Enabled = False
        Me.txtAdultToSend.Location = New System.Drawing.Point(448, 200)
        Me.txtAdultToSend.Name = "txtAdultToSend"
        Me.txtAdultToSend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultToSend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultToSend.Properties.ReadOnly = True
        Me.txtAdultToSend.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultToSend.TabIndex = 12
        '
        'txtNormAssigned
        '
        Me.txtNormAssigned.Enabled = False
        Me.txtNormAssigned.Location = New System.Drawing.Point(184, 256)
        Me.txtNormAssigned.Name = "txtNormAssigned"
        Me.txtNormAssigned.Properties.ReadOnly = True
        Me.txtNormAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtNormAssigned.TabIndex = 13
        '
        'txtAdultAssigned
        '
        Me.txtAdultAssigned.Enabled = False
        Me.txtAdultAssigned.Location = New System.Drawing.Point(448, 256)
        Me.txtAdultAssigned.Name = "txtAdultAssigned"
        Me.txtAdultAssigned.Properties.ReadOnly = True
        Me.txtAdultAssigned.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultAssigned.TabIndex = 14
        '
        'txtTotalDVD
        '
        Me.txtTotalDVD.Enabled = False
        Me.txtTotalDVD.Location = New System.Drawing.Point(704, 128)
        Me.txtTotalDVD.Name = "txtTotalDVD"
        Me.txtTotalDVD.Size = New System.Drawing.Size(112, 20)
        Me.txtTotalDVD.TabIndex = 16
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(560, 128)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Total DVDs Available"
        '
        'txtTotalWishList
        '
        Me.txtTotalWishList.Enabled = False
        Me.txtTotalWishList.Location = New System.Drawing.Point(448, 128)
        Me.txtTotalWishList.Name = "txtTotalWishList"
        Me.txtTotalWishList.Properties.ReadOnly = True
        Me.txtTotalWishList.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalWishList.TabIndex = 18
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(304, 128)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Total WishList Entries"
        '
        'txtAdultRating
        '
        Me.txtAdultRating.Enabled = False
        Me.txtAdultRating.Location = New System.Drawing.Point(448, 280)
        Me.txtAdultRating.Name = "txtAdultRating"
        Me.txtAdultRating.Properties.ReadOnly = True
        Me.txtAdultRating.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultRating.TabIndex = 22
        '
        'txtNormRating
        '
        Me.txtNormRating.Enabled = False
        Me.txtNormRating.Location = New System.Drawing.Point(184, 280)
        Me.txtNormRating.Name = "txtNormRating"
        Me.txtNormRating.Properties.ReadOnly = True
        Me.txtNormRating.Size = New System.Drawing.Size(100, 20)
        Me.txtNormRating.TabIndex = 21
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(296, 280)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "DVD Adult Rating"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(40, 280)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "DVD Norm Rating"
        '
        'txtInfo
        '
        Me.txtInfo.Enabled = False
        Me.txtInfo.Location = New System.Drawing.Point(184, 96)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(632, 20)
        Me.txtInfo.TabIndex = 24
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(40, 96)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl11.TabIndex = 23
        Me.LabelControl11.Text = "Process Info"
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
        Me.gpNotServed.Controls.Add(Me.txtXDvdNotFound)
        Me.gpNotServed.Controls.Add(Me.txtXTooManyHome)
        Me.gpNotServed.Controls.Add(Me.LabelControl20)
        Me.gpNotServed.Controls.Add(Me.txtXSuspended)
        Me.gpNotServed.Controls.Add(Me.LabelControl17)
        Me.gpNotServed.Controls.Add(Me.txtXThrotling)
        Me.gpNotServed.Controls.Add(Me.LabelControl16)
        Me.gpNotServed.Controls.Add(Me.LabelControl15)
        Me.gpNotServed.Controls.Add(Me.txtXCredit)
        Me.gpNotServed.Controls.Add(Me.LabelControl14)
        Me.gpNotServed.Location = New System.Drawing.Point(552, 200)
        Me.gpNotServed.Name = "gpNotServed"
        Me.gpNotServed.Size = New System.Drawing.Size(264, 168)
        Me.gpNotServed.TabIndex = 30
        Me.gpNotServed.Text = "Customers NOT Served because :"
        '
        'txtXDvdNotFound
        '
        Me.txtXDvdNotFound.EditValue = 0
        Me.txtXDvdNotFound.Enabled = False
        Me.txtXDvdNotFound.Location = New System.Drawing.Point(160, 56)
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
        Me.txtXTooManyHome.Location = New System.Drawing.Point(160, 128)
        Me.txtXTooManyHome.Name = "txtXTooManyHome"
        Me.txtXTooManyHome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXTooManyHome.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXTooManyHome.Properties.ReadOnly = True
        Me.txtXTooManyHome.Size = New System.Drawing.Size(100, 20)
        Me.txtXTooManyHome.TabIndex = 19
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 128)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl20.TabIndex = 18
        Me.LabelControl20.Text = "Too many DVD @ Home"
        '
        'txtXSuspended
        '
        Me.txtXSuspended.EditValue = 0
        Me.txtXSuspended.Enabled = False
        Me.txtXSuspended.Location = New System.Drawing.Point(160, 104)
        Me.txtXSuspended.Name = "txtXSuspended"
        Me.txtXSuspended.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXSuspended.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXSuspended.Properties.ReadOnly = True
        Me.txtXSuspended.Size = New System.Drawing.Size(100, 20)
        Me.txtXSuspended.TabIndex = 17
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 104)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl17.TabIndex = 16
        Me.LabelControl17.Text = "ABO Suspended"
        '
        'txtXThrotling
        '
        Me.txtXThrotling.EditValue = 0
        Me.txtXThrotling.Enabled = False
        Me.txtXThrotling.Location = New System.Drawing.Point(160, 80)
        Me.txtXThrotling.Name = "txtXThrotling"
        Me.txtXThrotling.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXThrotling.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXThrotling.Properties.ReadOnly = True
        Me.txtXThrotling.Size = New System.Drawing.Size(100, 20)
        Me.txtXThrotling.TabIndex = 15
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(16, 80)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl16.TabIndex = 14
        Me.LabelControl16.Text = "Throtling"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl15.TabIndex = 12
        Me.LabelControl15.Text = "DVD not found"
        '
        'txtXCredit
        '
        Me.txtXCredit.EditValue = 0
        Me.txtXCredit.Enabled = False
        Me.txtXCredit.Location = New System.Drawing.Point(160, 32)
        Me.txtXCredit.Name = "txtXCredit"
        Me.txtXCredit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXCredit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtXCredit.Properties.ReadOnly = True
        Me.txtXCredit.Size = New System.Drawing.Size(100, 20)
        Me.txtXCredit.TabIndex = 11
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = "Not Enought Credit"
        '
        'txtCustomersServed
        '
        Me.txtCustomersServed.EditValue = 0
        Me.txtCustomersServed.Enabled = False
        Me.txtCustomersServed.Location = New System.Drawing.Point(448, 176)
        Me.txtCustomersServed.Name = "txtCustomersServed"
        Me.txtCustomersServed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersServed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersServed.Properties.ReadOnly = True
        Me.txtCustomersServed.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomersServed.TabIndex = 32
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(296, 176)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl18.TabIndex = 31
        Me.LabelControl18.Text = "Customers Served"
        '
        'txtCustomersNotServed
        '
        Me.txtCustomersNotServed.EditValue = 0
        Me.txtCustomersNotServed.Enabled = False
        Me.txtCustomersNotServed.Location = New System.Drawing.Point(704, 176)
        Me.txtCustomersNotServed.Name = "txtCustomersNotServed"
        Me.txtCustomersNotServed.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersNotServed.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCustomersNotServed.Properties.ReadOnly = True
        Me.txtCustomersNotServed.Size = New System.Drawing.Size(112, 20)
        Me.txtCustomersNotServed.TabIndex = 34
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(560, 176)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl19.TabIndex = 33
        Me.LabelControl19.Text = "Customers NOT Served"
        '
        'chkSimulation
        '
        Me.chkSimulation.EditValue = True
        Me.chkSimulation.Location = New System.Drawing.Point(512, 24)
        Me.chkSimulation.Name = "chkSimulation"
        Me.chkSimulation.Properties.Caption = "Simulation Only"
        Me.chkSimulation.Size = New System.Drawing.Size(120, 19)
        Me.chkSimulation.TabIndex = 35
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
        Me.XtraTabPage1.Controls.Add(Me.btnStartABO3)
        Me.XtraTabPage1.Controls.Add(Me.btnLoadInfo2)
        Me.XtraTabPage1.Controls.Add(Me.txtEndTime)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage1.Controls.Add(Me.txtStartTime)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage1.Controls.Add(Me.txtWLCount)
        Me.XtraTabPage1.Controls.Add(Me.txtCustID)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage1.Controls.Add(Me.btnStartABO2)
        Me.XtraTabPage1.Controls.Add(Me.btnThrottling)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage1.Controls.Add(Me.txtNormCompensation)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultCompensation)
        Me.XtraTabPage1.Controls.Add(Me.btnReOrderWhishList)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage1.Controls.Add(Me.lblTotalCustomers)
        Me.XtraTabPage1.Controls.Add(Me.btnLoadInfo)
        Me.XtraTabPage1.Controls.Add(Me.txtToCustomerID)
        Me.XtraTabPage1.Controls.Add(Me.txtFromCustomerID)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage1.Controls.Add(Me.gpNotServed)
        Me.XtraTabPage1.Controls.Add(Me.chkSimulation)
        Me.XtraTabPage1.Controls.Add(Me.txtTotalCustomers)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersToProcess)
        Me.XtraTabPage1.Controls.Add(Me.txtNormToSend)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultToSend)
        Me.XtraTabPage1.Controls.Add(Me.txtNormAssigned)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultAssigned)
        Me.XtraTabPage1.Controls.Add(Me.txtTotalDVD)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersServed)
        Me.XtraTabPage1.Controls.Add(Me.txtTotalWishList)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage1.Controls.Add(Me.txtAdultRating)
        Me.XtraTabPage1.Controls.Add(Me.txtNormRating)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersNotServed)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage1.Controls.Add(Me.txtCustomersInNeed)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.txtInfo)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1275, 377)
        Me.XtraTabPage1.Text = "Parameters / Process"
        '
        'btnStartABO3
        '
        Me.btnStartABO3.Location = New System.Drawing.Point(743, 7)
        Me.btnStartABO3.Name = "btnStartABO3"
        Me.btnStartABO3.Size = New System.Drawing.Size(73, 37)
        ToolTipTitleItem1.Text = "ABO Flow"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnStartABO3.SuperTip = SuperToolTip1
        Me.btnStartABO3.TabIndex = 53
        Me.btnStartABO3.Text = "START (All Cust by ALL Cust)"
        '
        'btnLoadInfo2
        '
        Me.btnLoadInfo2.Location = New System.Drawing.Point(550, 48)
        Me.btnLoadInfo2.Name = "btnLoadInfo2"
        Me.btnLoadInfo2.Size = New System.Drawing.Size(60, 37)
        Me.btnLoadInfo2.TabIndex = 52
        Me.btnLoadInfo2.Text = "LOAD2"
        '
        'txtEndTime
        '
        Me.txtEndTime.EditValue = New Date(CType(0, Long))
        Me.txtEndTime.Enabled = False
        Me.txtEndTime.Location = New System.Drawing.Point(184, 328)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEndTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
        Me.txtEndTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtEndTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtEndTime.Size = New System.Drawing.Size(160, 20)
        Me.txtEndTime.TabIndex = 51
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(40, 328)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl26.TabIndex = 50
        Me.LabelControl26.Text = "Estimated End Time"
        '
        'txtStartTime
        '
        Me.txtStartTime.EditValue = New Date(CType(0, Long))
        Me.txtStartTime.Enabled = False
        Me.txtStartTime.Location = New System.Drawing.Point(184, 304)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtStartTime.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss"
        Me.txtStartTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtStartTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtStartTime.Size = New System.Drawing.Size(160, 20)
        Me.txtStartTime.TabIndex = 49
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(40, 304)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl25.TabIndex = 48
        Me.LabelControl25.Text = "Start Time"
        '
        'txtWLCount
        '
        Me.txtWLCount.Enabled = False
        Me.txtWLCount.Location = New System.Drawing.Point(448, 352)
        Me.txtWLCount.Name = "txtWLCount"
        Me.txtWLCount.Properties.ReadOnly = True
        Me.txtWLCount.Size = New System.Drawing.Size(100, 20)
        Me.txtWLCount.TabIndex = 47
        '
        'txtCustID
        '
        Me.txtCustID.Enabled = False
        Me.txtCustID.Location = New System.Drawing.Point(184, 352)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Properties.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustID.TabIndex = 46
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(296, 352)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl23.TabIndex = 45
        Me.LabelControl23.Text = "WishList Entries"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(40, 352)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl24.TabIndex = 44
        Me.LabelControl24.Text = "Customer ID"
        '
        'btnStartABO2
        '
        Me.btnStartABO2.Location = New System.Drawing.Point(648, 48)
        Me.btnStartABO2.Name = "btnStartABO2"
        Me.btnStartABO2.Size = New System.Drawing.Size(168, 37)
        ToolTipItem2.Text = resources.GetString("ToolTipItem2.Text")
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnStartABO2.SuperTip = SuperToolTip2
        Me.btnStartABO2.TabIndex = 43
        Me.btnStartABO2.Text = "START (Cust By Cust)"
        '
        'btnThrottling
        '
        Me.btnThrottling.Location = New System.Drawing.Point(208, 48)
        Me.btnThrottling.Name = "btnThrottling"
        Me.btnThrottling.Size = New System.Drawing.Size(168, 37)
        Me.btnThrottling.TabIndex = 42
        Me.btnThrottling.Text = "Throttling"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(40, 224)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl21.TabIndex = 38
        Me.LabelControl21.Text = "Norm Compensation"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(296, 224)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl22.TabIndex = 39
        Me.LabelControl22.Text = "Adult Compensation"
        '
        'txtNormCompensation
        '
        Me.txtNormCompensation.EditValue = 0
        Me.txtNormCompensation.Enabled = False
        Me.txtNormCompensation.Location = New System.Drawing.Point(184, 224)
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
        Me.txtAdultCompensation.Location = New System.Drawing.Point(448, 224)
        Me.txtAdultCompensation.Name = "txtAdultCompensation"
        Me.txtAdultCompensation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultCompensation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdultCompensation.Properties.ReadOnly = True
        Me.txtAdultCompensation.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultCompensation.TabIndex = 41
        '
        'btnReOrderWhishList
        '
        Me.btnReOrderWhishList.Location = New System.Drawing.Point(40, 48)
        Me.btnReOrderWhishList.Name = "btnReOrderWhishList"
        Me.btnReOrderWhishList.Size = New System.Drawing.Size(168, 37)
        Me.btnReOrderWhishList.TabIndex = 37
        Me.btnReOrderWhishList.Text = "Re-Order Wish List"
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
        Me.GridCustResult.DataSource = Me.DS.customers
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
        'DS
        '
        Me.DS.DataSetName = "dsABOProcess"
        Me.DS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridViewCust
        '
        Me.GridViewCust.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewCust.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_id, Me.colcustomers_abo, Me.colcustomers_abo_type, Me.colcustomers_abo_dvd_norm, Me.colcustomers_abo_dvd_adult, Me.colcustomers_abo_dvd_home_norm, Me.colcustomers_abo_dvd_home_adult, Me.colcustomers_abo_dvd_credit, Me.colcustomers_abo_rank, Me.colcustomers_abo_multishipment, Me.coluse_credit, Me.colthrottling, Me.colcustomers_abo_suspended, Me.colNormToSend, Me.colAdultToSend, Me.colNormAssigned, Me.colAdultAssigned, Me.colInNeed, Me.colServed, Me.colNotServed, Me.colNotEnoughtCredit, Me.colNoDVDFound, Me.colTooManyAtHome})
        Me.GridViewCust.GridControl = Me.GridCustResult
        Me.GridViewCust.Name = "GridViewCust"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colcustomers_id)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_type)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_dvd_norm)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_dvd_adult)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_dvd_home_norm)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_dvd_home_adult)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_dvd_credit)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_rank)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_multishipment)
        Me.GridBand1.Columns.Add(Me.coluse_credit)
        Me.GridBand1.Columns.Add(Me.colthrottling)
        Me.GridBand1.Columns.Add(Me.colcustomers_abo_suspended)
        Me.GridBand1.Columns.Add(Me.colNormToSend)
        Me.GridBand1.Columns.Add(Me.colAdultToSend)
        Me.GridBand1.Columns.Add(Me.colNormAssigned)
        Me.GridBand1.Columns.Add(Me.colAdultAssigned)
        Me.GridBand1.Columns.Add(Me.colInNeed)
        Me.GridBand1.Columns.Add(Me.colServed)
        Me.GridBand1.Columns.Add(Me.colNotServed)
        Me.GridBand1.Columns.Add(Me.colNotEnoughtCredit)
        Me.GridBand1.Columns.Add(Me.colNoDVDFound)
        Me.GridBand1.Columns.Add(Me.colTooManyAtHome)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1725
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        '
        'colcustomers_abo
        '
        Me.colcustomers_abo.Caption = "customers_abo"
        Me.colcustomers_abo.FieldName = "customers_abo"
        Me.colcustomers_abo.Name = "colcustomers_abo"
        Me.colcustomers_abo.Visible = True
        '
        'colcustomers_abo_type
        '
        Me.colcustomers_abo_type.Caption = "customers_abo_type"
        Me.colcustomers_abo_type.FieldName = "customers_abo_type"
        Me.colcustomers_abo_type.Name = "colcustomers_abo_type"
        Me.colcustomers_abo_type.Visible = True
        '
        'colcustomers_abo_dvd_norm
        '
        Me.colcustomers_abo_dvd_norm.Caption = "customers_abo_dvd_norm"
        Me.colcustomers_abo_dvd_norm.FieldName = "customers_abo_dvd_norm"
        Me.colcustomers_abo_dvd_norm.Name = "colcustomers_abo_dvd_norm"
        Me.colcustomers_abo_dvd_norm.Visible = True
        '
        'colcustomers_abo_dvd_adult
        '
        Me.colcustomers_abo_dvd_adult.Caption = "customers_abo_dvd_adult"
        Me.colcustomers_abo_dvd_adult.FieldName = "customers_abo_dvd_adult"
        Me.colcustomers_abo_dvd_adult.Name = "colcustomers_abo_dvd_adult"
        Me.colcustomers_abo_dvd_adult.Visible = True
        '
        'colcustomers_abo_dvd_home_norm
        '
        Me.colcustomers_abo_dvd_home_norm.Caption = "customers_abo_dvd_home_norm"
        Me.colcustomers_abo_dvd_home_norm.FieldName = "customers_abo_dvd_home_norm"
        Me.colcustomers_abo_dvd_home_norm.Name = "colcustomers_abo_dvd_home_norm"
        Me.colcustomers_abo_dvd_home_norm.Visible = True
        '
        'colcustomers_abo_dvd_home_adult
        '
        Me.colcustomers_abo_dvd_home_adult.Caption = "customers_abo_dvd_home_adult"
        Me.colcustomers_abo_dvd_home_adult.FieldName = "customers_abo_dvd_home_adult"
        Me.colcustomers_abo_dvd_home_adult.Name = "colcustomers_abo_dvd_home_adult"
        Me.colcustomers_abo_dvd_home_adult.Visible = True
        '
        'colcustomers_abo_dvd_credit
        '
        Me.colcustomers_abo_dvd_credit.Caption = "customers_abo_dvd_credit"
        Me.colcustomers_abo_dvd_credit.FieldName = "customers_abo_dvd_credit"
        Me.colcustomers_abo_dvd_credit.Name = "colcustomers_abo_dvd_credit"
        Me.colcustomers_abo_dvd_credit.Visible = True
        '
        'colcustomers_abo_rank
        '
        Me.colcustomers_abo_rank.Caption = "customers_abo_rank"
        Me.colcustomers_abo_rank.FieldName = "customers_abo_rank"
        Me.colcustomers_abo_rank.Name = "colcustomers_abo_rank"
        Me.colcustomers_abo_rank.Visible = True
        '
        'colcustomers_abo_multishipment
        '
        Me.colcustomers_abo_multishipment.Caption = "customers_abo_multishipment"
        Me.colcustomers_abo_multishipment.FieldName = "customers_abo_multishipment"
        Me.colcustomers_abo_multishipment.Name = "colcustomers_abo_multishipment"
        Me.colcustomers_abo_multishipment.Visible = True
        '
        'coluse_credit
        '
        Me.coluse_credit.Caption = "use_credit"
        Me.coluse_credit.FieldName = "use_credit"
        Me.coluse_credit.Name = "coluse_credit"
        Me.coluse_credit.Visible = True
        '
        'colthrottling
        '
        Me.colthrottling.Caption = "throttling"
        Me.colthrottling.FieldName = "throttling"
        Me.colthrottling.Name = "colthrottling"
        Me.colthrottling.Visible = True
        '
        'colcustomers_abo_suspended
        '
        Me.colcustomers_abo_suspended.Caption = "customers_abo_suspended"
        Me.colcustomers_abo_suspended.FieldName = "customers_abo_suspended"
        Me.colcustomers_abo_suspended.Name = "colcustomers_abo_suspended"
        Me.colcustomers_abo_suspended.Visible = True
        '
        'colNormToSend
        '
        Me.colNormToSend.Caption = "NormToSend"
        Me.colNormToSend.FieldName = "NormToSend"
        Me.colNormToSend.Name = "colNormToSend"
        Me.colNormToSend.Visible = True
        '
        'colAdultToSend
        '
        Me.colAdultToSend.Caption = "AdultToSend"
        Me.colAdultToSend.FieldName = "AdultToSend"
        Me.colAdultToSend.Name = "colAdultToSend"
        Me.colAdultToSend.Visible = True
        '
        'colNormAssigned
        '
        Me.colNormAssigned.Caption = "NormAssigned"
        Me.colNormAssigned.FieldName = "NormAssigned"
        Me.colNormAssigned.Name = "colNormAssigned"
        Me.colNormAssigned.Visible = True
        '
        'colAdultAssigned
        '
        Me.colAdultAssigned.Caption = "AdultAssigned"
        Me.colAdultAssigned.FieldName = "AdultAssigned"
        Me.colAdultAssigned.Name = "colAdultAssigned"
        Me.colAdultAssigned.Visible = True
        '
        'colInNeed
        '
        Me.colInNeed.Caption = "InNeed"
        Me.colInNeed.FieldName = "InNeed"
        Me.colInNeed.Name = "colInNeed"
        Me.colInNeed.Visible = True
        '
        'colServed
        '
        Me.colServed.Caption = "Served"
        Me.colServed.FieldName = "Served"
        Me.colServed.Name = "colServed"
        Me.colServed.Visible = True
        '
        'colNotServed
        '
        Me.colNotServed.Caption = "NotServed"
        Me.colNotServed.FieldName = "NotServed"
        Me.colNotServed.Name = "colNotServed"
        Me.colNotServed.Visible = True
        '
        'colNotEnoughtCredit
        '
        Me.colNotEnoughtCredit.Caption = "NotEnoughtCredit"
        Me.colNotEnoughtCredit.FieldName = "NotEnoughtCredit"
        Me.colNotEnoughtCredit.Name = "colNotEnoughtCredit"
        Me.colNotEnoughtCredit.Visible = True
        '
        'colNoDVDFound
        '
        Me.colNoDVDFound.Caption = "NoDVDFound"
        Me.colNoDVDFound.FieldName = "NoDVDFound"
        Me.colNoDVDFound.Name = "colNoDVDFound"
        Me.colNoDVDFound.Visible = True
        '
        'colTooManyAtHome
        '
        Me.colTooManyAtHome.Caption = "TooManyAtHome"
        Me.colTooManyAtHome.FieldName = "TooManyAtHome"
        Me.colTooManyAtHome.Name = "colTooManyAtHome"
        Me.colTooManyAtHome.Visible = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridCustResult
        Me.GridView1.Name = "GridView1"
        '
        'frmABOProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1284, 438)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmABOProcess"
        Me.Text = "ABO Process"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCustomers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersToProcess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersInNeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormToSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultToSend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormAssigned.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultAssigned.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDVD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalWishList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpNotServed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpNotServed.ResumeLayout(False)
        Me.gpNotServed.PerformLayout()
        CType(Me.txtXDvdNotFound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXTooManyHome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXSuspended.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXThrotling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtXCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersServed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersNotServed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSimulation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtEndTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWLCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNormCompensation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdultCompensation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim DS As New dsABOProcess
    Dim SQLCustomers As String
    Dim SQLProducts_DVD As String
    Dim SQLWishList As String
    Dim SQLCompensation As String
    Dim IsLoadComplete As Boolean = False
    Dim WLView As DataView
    Dim CustView As DataView

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub frmABOProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DS.Tables.Add("customers")
        DS.Tables.Add("products_dvd")
        Me.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub btnLoadInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInfo.Click
        DS.Tables("customers").Clear()
        DS.Tables("products_dvd").Clear()
        DS.Tables("wishlist").Clear()

        txtInfo.Text = "Loading Customer List"
        txtInfo.Refresh()
        SQLCustomers = "SELECT customers_id, customers_abo, customers_abo_type, customers_abo_dvd_norm, customers_abo_dvd_adult, " & _
                       " customers_abo_dvd_home_norm, customers_abo_dvd_home_adult, customers_abo_dvd_credit, customers_abo_rank, " & _
                       " customers_abo_multishipment, if(pa.qty_credit = 0, 0, 1) as use_credit, throttling, customers_abo_suspended, " & _
                       " 0 as InNeed, 0 as Served, 0 as NotServed, 0 as NotEnoughtCredit, 0 as NoDVDFound, 0 as TooManyAtHome, " & _
                       " 0 as NormToSend, 0 as AdultToSend, 0 as NormAssigned, 0 as AdultAssigned, 0 as NormCompensation, 0 AdultCompensation " & _
                       " from customers " & _
                       " left join products_abo pa on pa.products_id = customers_abo_type " & _
                       " where customers_abo = 1 " & _
                       " and customers_id >= " & txtFromCustomerID.EditValue & _
                       " AND customers_id <= " & txtToCustomerID.EditValue
        BKGlobal.Cls1.FillDataSet(DS.Tables("customers"), SQLCustomers)
        txtTotalCustomers.EditValue = DS.Tables("customers").Rows.Count
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue

        txtInfo.Text = "Loading available DVDs list"
        txtInfo.Refresh()
        SQLProducts_DVD = "SELECT pd.products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id, " & _
                          " products_series_aboprocess_id, products_series_aboprocess_number " & _
                          " FROM products_dvd pd " & _
                          " LEFT JOIN products p on p.products_id = pd.products_id" & _
                          " WHERE pd.products_dvd_status = 1 and pd.`inout` = 1 "
        BKGlobal.Cls1.FillDataSet(DS.Tables("products_dvd"), SQLProducts_DVD)
        DS.Tables("products_dvd").PrimaryKey = New DataColumn() {DS.Tables("products_dvd").Columns("products_id"), _
                                                                 DS.Tables("products_dvd").Columns("products_dvdid")}
        'DS.Tables("products_dvd").Constraints.Add("KEY1", New DataColumn() {DS.Tables("products_dvd").Columns("products_id"), _
        '                                        DS.Tables("products_dvd").Columns("inout")}, False)
        txtTotalDVD.EditValue = DS.Tables("products_dvd").Rows.Count

        txtInfo.Text = "Loading WishLists"
        txtInfo.Refresh()
        SQLWishList = "SELECT wl.wl_id, wl.customers_id, product_id, rank, wl.wishlist_type, p.products_series_aboprocess_id, p.products_series_aboprocess_number " & _
                          " FROM wishlist wl " & _
                          " LEFT JOIN customers c on c.customers_id = wl.customers_id " & _
                          " LEFT JOIN products p on p.products_id = wl.product_id" & _
                          " WHERE c.customers_abo = 1 and wl.customers_id >= " & txtFromCustomerID.EditValue & _
                          " AND wl.customers_id <= " & txtToCustomerID.EditValue & _
                          " ORDER BY wl.customers_id, wl.wishlist_type, wl.rank "
        BKGlobal.Cls1.FillDataSet(DS.Tables("wishlist"), SQLWishList)
        txtTotalWishList.EditValue = DS.Tables("wishlist").Rows.Count

        txtInfo.Text = "Loading Compensation"
        txtInfo.Refresh()
        SQLCompensation = "select customers_id , p.products_type , " & _
                          " count(*) as compensation_qty " & _
                          " FROM compensation c left join products p on ( c.products_id = p.products_id) " & _
                          " where compensation_date_setback IS NULL" & _
                          " group by customers_id, p.products_type having products_type is not NULL"
        BKGlobal.Cls1.FillDataSet(DS.Tables("compensation_summary"), SQLCompensation)

        'txtTotalWishList.EditValue = DS.Tables("compensation_summary").Rows.Count


        txtInfo.Text = "Load Complete - Ready to start!"
        IsLoadComplete = True

    End Sub

    Sub LoadCustomers(ByVal State As Object)
        '        Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.Unknown)
        'txtInfo.Text = "Loading Customer List"
        'txtInfo.Refresh()
        SQLCustomers = "SELECT c.customers_id, customers_abo, customers_abo_type, (customers_abo_dvd_norm+customers_abo_dvd_adult) as customers_abo_dvd, " & _
                       " customers_abo_dvd_credit, rank, " & _
                       " customers_abo_multishipment, if(pa.qty_credit = 0, 0, 1) as use_credit, throttling, customers_abo_suspended, " & _
                       " 0 as InNeed, 0 as Served, 0 as NotServed, 0 as NotEnoughtCredit, 0 as NoDVDFound, 0 as TooManyAtHome, " & _
                       " 0 as ToSend, 0 as dvd_Assigned, 0 as Compensation, " & _
                       " wishlist_master_id, wishlist_name, wishlist_type, customers_info_date_account_created, " & _
                       " dvd_home" & _
                       " from wishlist_master wm" & _
                       " left join customers c on c.customers_id = wm.customers_id" & _
                       " left join products_abo pa on pa.products_id = customers_abo_type " & _
                       " where customers_abo = 1 " & _
                       " and c.customers_id >= " & txtFromCustomerID.EditValue & _
                       " AND c.customers_id <= " & txtToCustomerID.EditValue
        BKGlobal.Cls1.FillDataSet(DS.Tables("customers"), SQLCustomers, False, True)
        'txtTotalCustomers.EditValue = DS.Tables("customers").Rows.Count
        'txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        sem(0).Set()

    End Sub

    Sub LoadAvailableDVD(ByVal State As Object)
        'Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.STA)
        'txtInfo.Text = "Loading available DVDs list"
        'txtInfo.Refresh()
        SQLProducts_DVD = "SELECT pd.products_id, products_dvdid, products_dvd_status, `inout`, box_id, pibox_id, " & _
                          " products_series_aboprocess_id, products_series_aboprocess_number " & _
                          " FROM products_dvd pd " & _
                          " LEFT JOIN products p on p.products_id = pd.products_id" & _
                          " WHERE pd.products_dvd_status = 1 and pd.`inout` = 1 "
        BKGlobal.Cls1.FillDataSet(DS.Tables("products_dvd"), SQLProducts_DVD, False, True)
        DS.Tables("products_dvd").PrimaryKey = New DataColumn() {DS.Tables("products_dvd").Columns("products_id"), _
                                                                 DS.Tables("products_dvd").Columns("products_dvdid")}
        'DS.Tables("products_dvd").Constraints.Add("KEY1", New DataColumn() {DS.Tables("products_dvd").Columns("products_id"), _
        '                                        DS.Tables("products_dvd").Columns("inout")}, False)
        'txtTotalDVD.EditValue = DS.Tables("products_dvd").Rows.Count
        sem(1).Set()
    End Sub

    Sub LoadWishList(ByVal State As Object)
        'Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.STA)
        'txtInfo.Text = "Loading WishLists"
        'txtInfo.Refresh()
        SQLWishList = "SELECT wl.wl_id, wl.customers_id, product_id, rank, wl.wishlist_type, p.products_series_aboprocess_id, p.products_series_aboprocess_number " & _
                          " FROM wishlist wl " & _
                          " LEFT JOIN customers c on c.customers_id = wl.customers_id " & _
                          " LEFT JOIN products p on p.products_id = wl.product_id" & _
                          " WHERE c.customers_abo = 1 and wl.customers_id >= " & txtFromCustomerID.EditValue & _
                          " AND wl.customers_id <= " & txtToCustomerID.EditValue & _
                          " ORDER BY wl.customers_id, wl.wishlist_type, wl.rank "
        BKGlobal.Cls1.FillDataSet(DS.Tables("wishlist"), SQLWishList, False, True)
        'txtTotalWishList.EditValue = DS.Tables("wishlist").Rows.Count
        sem(2).Set()
    End Sub

    Sub LoadCompensation(ByVal State As Object)
        'Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.STA)
        'txtInfo.Text = "Loading Compensation"
        'txtInfo.Refresh()
        SQLCompensation = "select customers_id , p.products_type , " & _
                          " count(*) as compensation_qty " & _
                          " FROM compensation c left join products p on ( c.products_id = p.products_id) " & _
                          " where compensation_date_setback IS NULL" & _
                          " group by customers_id, p.products_type having products_type is not NULL"
        BKGlobal.Cls1.FillDataSet(DS.Tables("compensation_summary"), SQLCompensation, False, True)
        'txtTotalWishList.EditValue = DS.Tables("compensation_summary").Rows.Count
        sem(3).Set()
    End Sub

    Dim _custRow As DataRowView
    Dim _ProductView As DataView
    Dim _WLSerieViewAll As DataView
    Dim _WLSerieViewFiltered As DataView
    Dim _ProductRow As DataRowView
    Dim _ProductRows() As DataRowView
    Dim _IsCustomerServed As Boolean
    Dim _IsDVDFound As Boolean
    Dim _IsCompensation As Boolean
    Dim _PRoductType As String = ""
    Dim _iStart, _iEnd, _iStep As Integer
    Dim _AtLeastOneHasBeenServed As Boolean = False
    Dim _boolSerieNumberTooBig As Boolean = False
    Dim _SQLTxt As String

    Private Sub aboprocess2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Go through Customers ONE by ONE and assign all DVD Neede for the selected Customer
        'Then Move to next Customer
        Dim _NormToSend As Integer = 0
        Dim _AdultToSend As Integer = 0
        Dim _NormCompensation As Integer = 0
        Dim _AdultCompensation As Integer = 0
        Dim _IsCustInNeed As Boolean = False
        Dim _WLRows() As DataRowView
        Dim _i As Integer = 0
        txtInfo.Text = "Sorting WishList"
        txtStartTime.DateTime = Now()
        DoEvents()
        CustView = New DataView(DS.Tables("customers"), "", "customers_abo_rank, customers_id ", DataViewRowState.CurrentRows)
        WLView = New DataView(DS.Tables("wishlist"), "", "customers_id, wishlist_type", DataViewRowState.CurrentRows)
        _ProductView = New DataView(DS.Tables("products_dvd"), " ", "products_id, `inout`", DataViewRowState.CurrentRows)
        '_WLSerieViewAll = New DataView(DS.Tables("wishlist"), " ", "customers_id, products_series_aboprocess_id, rank", DataViewRowState.CurrentRows)
        _WLSerieViewAll = New DataView(DS.Tables("wishlist"), " ", "customers_id, products_series_aboprocess_id, products_series_aboprocess_number", DataViewRowState.CurrentRows)

        If Not IsLoadComplete Then
            btnLoadInfo_Click(sender, e)
        End If

        ResetCounters()
        txtInfo.Text = "Calculating Whiwh custmer needs to be served"
        DoEvents()
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        For Each _custRow In CustView 'DS.Tables("customers").Rows
            _i += 1
            If _i Mod 100 = 0 Then
                txtEndTime.DateTime = DateAdd(DateInterval.Second, DateDiff(DateInterval.Second, txtStartTime.DateTime, Now()) / (txtTotalCustomers.EditValue - txtCustomersToProcess.EditValue) * txtTotalCustomers.EditValue, txtStartTime.DateTime)
            End If
            'Cacl how many DVD to assin, Why Customer should not be served ....
            CalcHowManyToAssign(_custRow, _NormToSend, _AdultToSend, _IsCustInNeed, _NormCompensation, _AdultCompensation)
            txtCustomersToProcess.EditValue -= 1
            DoEvents()
        Next
        'MsgBox("Part1 " & CustView.Count, MsgBoxStyle.Information)

        _iStart = 1
        _iEnd = 200
        _iStep = 1
        _AtLeastOneHasBeenServed = False
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        For Each _custRow In CustView 'DS.Tables("customers").Rows
            _i += 1
            If _i Mod 100 = 0 Then
                txtEndTime.DateTime = DateAdd(DateInterval.Second, DateDiff(DateInterval.Second, txtStartTime.DateTime, Now()) / (txtTotalCustomers.EditValue - txtCustomersToProcess.EditValue) * txtTotalCustomers.EditValue, txtStartTime.DateTime)
            End If
            _IsCustInNeed = (_custRow.Item("NormToSend") <> 0 Or _custRow.Item("AdultToSend") <> 0 Or _custRow.Item("NormCompensation") <> 0 Or _custRow.Item("AdultCompensation") <> 0)
            _IsCustomerServed = False
            _IsCompensation = False
            _IsDVDFound = False
            If _custRow.Item("NormToSend") > 0 Or _custRow.Item("NormCompensation") > 0 Then
                _WLRows = WLView.FindRows(New Object() {_custRow.Item("customers_id"), "DVD_NORM"})
                _PRoductType = "DVD_NORM"
                If _WLRows.GetLength(0) > 0 Then
                    LoopThroughWishList(_WLRows)
                End If
            End If
            If _custRow.Item("AdultToSend") > 0 Or _custRow.Item("AdultCompensation") > 0 Then
                _WLRows = WLView.FindRows(New Object() {_custRow.Item("customers_id"), "DVD_ADULT"})
                _PRoductType = "DVD_ADULT"
                If _WLRows.GetLength(0) > 0 Then
                    LoopThroughWishList(_WLRows)
                End If
            End If
            DoEvents()
            If Not _IsCustomerServed Then
                txtXDvdNotFound.EditValue += 1
                txtCustomersNotServed.EditValue += 1
                _custRow.Item("NotServed") = 1
                _custRow.Item("NoDVDFound") = 1
            Else
                txtCustomersServed.EditValue += 1
                _custRow.Item("Served") = 1
            End If
            'End If
            txtCustomersToProcess.EditValue -= 1
            DoEvents()
        Next 'Each Customers

        If Not chkSimulation.Checked Then
            Dim _Rate_DVD_Served As Decimal = (txtNormAssigned.EditValue + txtAdultAssigned.EditValue) / _
                                              (txtNormToSend.EditValue + txtAdultToSend.EditValue + txtNormCompensation.EditValue + txtAdultCompensation.EditValue) _
                                              * 100
            Dim _Rate_Cust_Served As Decimal = (txtCustomersServed.EditValue) / txtCustomersInNeed.EditValue * 100
            'Create Entry in aboprocess_stats
            _SQLTxt = "insert into aboprocess_stats (aboprocess_date, total_customers, total_wishlist_entries, total_dvd_available, " & _
            "cust_needing_dvd, cust_served, cust_not_served, dvd_norm_to_send, dvd_norm_sent, dvd_adult_to_send," & _
            " dvd_adult_sent, dvd_norm_compensation, dvd_adult_compensation, notserved_credit, notserved_no_dvd_found, " & _
            " notserved_throttling, notserved_suspended, notserved_too_many_at_home, rate_dvd_served, rate_cust_served " & _
            ") values ( '" & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "', " & txtTotalCustomers.EditValue & ", " & txtTotalWishList.EditValue & ", " & _
            txtTotalDVD.EditValue & ", " & txtCustomersInNeed.EditValue & ", " & txtCustomersServed.EditValue & ", " & _
            txtCustomersNotServed.EditValue & ", " & txtNormToSend.EditValue & ",  " & txtNormAssigned.EditValue & ", " & _
            txtAdultToSend.EditValue & ", " & txtAdultAssigned.EditValue & ", " & txtNormCompensation.EditValue & ", " & _
            txtAdultCompensation.EditValue & ", " & txtXCredit.EditValue & "," & txtXDvdNotFound.EditValue & "," & _
            txtXThrotling.EditValue & ", " & txtXSuspended.EditValue & ", " & txtXTooManyHome.EditValue & ", " & _
            _Rate_DVD_Served & ", " & _Rate_Cust_Served & _
            ")"
            BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)
            'Changing Customers Rank 
            'Set Rank = 2 if customers has been served
            'Set Rank = 1 if is not Served
            For Each _custRow In CustView
                If _custRow.Item("Served") = 1 Then
                    BKGlobal.Cls1.ExecuteNonQuery("update customers set customers_abo_rank = 2 where customers_id = " & _custRow.Item("customers_id"))
                Else
                    BKGlobal.Cls1.ExecuteNonQuery("update customers set customers_abo_rank = 1 where customers_id = " & _custRow.Item("customers_id"))
                End If
            Next
        End If
        MsgBox("ABO Process Complete", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub LoopThroughWishList(ByVal _WLRows() As DataRowView)
        Dim _WLRow As DataRowView
        Dim _WL_DS As New dsABOProcess
        txtCustID.EditValue = _custRow.Item("customers_id")
        txtWLCount.EditValue = _WLRows.GetLength(0)
        For Each _WLRow In _WLRows
            'Find the Product Info of the selected WishList Record - With INOUT = 1 (DVD is in stock)
            If _PRoductType = "DVD_NORM" Then
                If _custRow.Item("NormToSend") = 0 And _custRow.Item("NormCompensation") = 0 Then Exit For
                If _custRow.Item("NormCompensation") > 0 Then
                    _IsCompensation = True
                Else
                    _IsCompensation = False
                End If
            Else 'DVD_ADULT
                If _custRow.Item("AdultToSend") = 0 And _custRow.Item("AdultCompensation") = 0 Then Exit For
                If _custRow.Item("AdultCompensation") > 0 Then
                    _IsCompensation = True
                Else
                    _IsCompensation = False
                End If
            End If

            _ProductRows = _ProductView.FindRows(New Object() {_WLRow.Item("product_id"), 1})
            If _ProductRows.GetLength(0) > 0 Then 'A Product Row is found.
                _ProductRow = _ProductRows(0)
                'Checking for the Serie
                _boolSerieNumberTooBig = False
                If _ProductRow.Item("products_series_aboprocess_id") <> 0 Then
                    'Searching for an entry in the WishList for the Same Serie with a lower rank 
                    'WARNING : Using wishlist rank and not products_series_aboprocess_number
                    'So customer can order series in his own order
                    '_WLSerieViewAll.RowFilter = "customers_id = " & _custRow.Item("customers_id") & _
                    '      " AND products_series_aboprocess_id = " & _ProductRow.Item("products_series_aboprocess_id") & _
                    '      " AND rank < " & _WLRow.Item("rank")

                    '
                    Dim _txtFilter As String = "wl.customers_id = " & _custRow.Item("customers_id") & _
                          " AND p.products_series_aboprocess_id = " & _ProductRow.Item("products_series_aboprocess_id") & _
                          " AND p.products_series_aboprocess_number < " & _ProductRow.Item("products_series_aboprocess_number")
                    _WLSerieViewAll.RowFilter = "customers_id = " & _custRow.Item("customers_id") & _
                          " AND products_series_aboprocess_id = " & _ProductRow.Item("products_series_aboprocess_id") & _
                          " AND products_series_aboprocess_number < " & _ProductRow.Item("products_series_aboprocess_number")
                    'BKGlobal.Cls1.FillDataSet(_WL_DS.Tables("wishlist"), "SELECT wl_id from wishlist wl left join products p on p.products_id = wl.products_id where " & _txtFilter)
                    If _WLSerieViewAll.Count > 0 Then
                        'If _WL_DS.Tables("wishlist").Rows.Count > 0 Then
                        _boolSerieNumberTooBig = True
                    Else
                        _boolSerieNumberTooBig = False
                    End If
                Else
                    _boolSerieNumberTooBig = False
                End If
                If _boolSerieNumberTooBig = False Then 'Assign DVD to customer if no Series Problem
                    _ProductRow.Item("inout") = 2
                    Select Case _PRoductType
                        Case "DVD_NORM"
                            txtNormAssigned.EditValue += 1
                            _custRow.Item("NormAssigned") += 1
                            'Decreasing Qty needed by the Customer.
                            If _IsCompensation = True Then
                                _custRow.Item("NormCompensation") -= 1
                            Else
                                _custRow.Item("NormToSend") -= 1
                            End If
                        Case "DVD_ADULT"
                            txtAdultAssigned.EditValue += 1
                            _custRow.Item("AdultAssigned") += 1
                            'Decreasing Qty needed by the Customer.
                            If _IsCompensation = True Then
                                _custRow.Item("AdultCompensation") -= 1
                            Else
                                _custRow.Item("AdultToSend") -= 1
                            End If
                    End Select
                    If Not chkSimulation.Checked Then
                        'Create Orders and Assign OrderID to compensation record if needed
                        AssignDVD(_IsCompensation, _WLRow.Item("wl_id"), _ProductRow.Item("products_id"), _ProductRow.Item("products_dvdid"), _custRow.Item("customers_id"))
                    End If
                    'This WLRows has been assigned. Remove the products_series_aboprocess_id so it is not taken as a limitation in the next loop for series
                    _WLRow.BeginEdit()
                    '_WLRow.Delete()
                    _WLRow.Item("products_series_aboprocess_id") = 0
                    _WLRow.EndEdit()
                    _IsCustomerServed = True
                    _IsDVDFound = True
                    _AtLeastOneHasBeenServed = True
                End If 'IF Not Prob with the Series and The DVD has been assigned to customer
            End If 'If a Products_DVD was found in the Wish List
        Next 'Each WishList Entry
    End Sub


    Private Sub CalcHowManyToAssign(ByRef vCustRow As DataRowView, ByRef vNormToSend As Integer, ByRef vAdultToSend As Integer, ByRef vIsCustInNeed As Boolean, ByVal vNormCompensation As Integer, ByVal vAdultCompensation As Integer)
        'If IsDBNull(vCustRow.Item("qty_credit")) Then
        '    MsgBox("Customer : " & vCustRow.Item("customers_id") & " has a problem. Please check his data", MsgBoxStyle.Exclamation)
        '    vCustRow.Item("qty_credit") = 0
        'End If
        'If vCustRow.Item("qty_credit") > 0 Then
        '    vUseCredit = True
        'Else
        '    vUseCredit = False
        'End If
        Dim _CompensationRow As DataRow

        vNormToSend = vCustRow.Item("customers_abo_dvd_norm") - vCustRow.Item("customers_abo_dvd_home_norm")
        vAdultToSend = vCustRow.Item("customers_abo_dvd_adult") - vCustRow.Item("customers_abo_dvd_home_adult")
        If vNormToSend < 0 Then vNormToSend = 0
        If vAdultToSend < 0 Then vAdultToSend = 0
        'Check if Throtling
        If vCustRow.Item("throttling") = 1 Then
            txtXThrotling.EditValue += 1
            txtCustomersNotServed.EditValue += 1
            vCustRow.Item("NotServed") = 1
            vAdultToSend = 0
            vNormToSend = 0
            vNormCompensation = 0
            vAdultCompensation = 0
            Exit Sub
        End If

        'Check if suspended
        If vCustRow.Item("customers_abo_suspended") > 0 Then
            txtXSuspended.EditValue += 1
            txtCustomersNotServed.EditValue += 1
            vAdultToSend = 0
            vNormToSend = 0
            vCustRow.Item("NotServed") = 1
            vNormCompensation = 0
            vAdultCompensation = 0
            Exit Sub
        End If
        If vCustRow.Item("Use_credit") = 1 Then
            'Use Credit , then check that customers has enough credit
            If vCustRow.Item("customers_abo_dvd_credit") <= 0 Then
                vCustRow.Item("customers_abo_dvd_credit") = 0
                txtXCredit.EditValue += 1
                txtCustomersNotServed.EditValue += 1
                vCustRow.Item("NotServed") = 1
                vCustRow.Item("NotEnoughtCredit") = 1
                vNormToSend = 0
                vAdultToSend = 0
            Else
                vNormToSend = Math.Min(vNormToSend, vCustRow.Item("customers_abo_dvd_credit"))
                vCustRow.Item("customers_abo_dvd_credit") = vCustRow.Item("customers_abo_dvd_credit") - vNormToSend
                vAdultToSend = Math.Min(vAdultToSend, vCustRow.Item("customers_abo_dvd_credit"))
                vCustRow.Item("customers_abo_dvd_credit") = vCustRow.Item("customers_abo_dvd_credit") - vAdultToSend
                If vNormToSend + vAdultToSend = 0 Then
                    txtXTooManyHome.EditValue += 1
                    txtCustomersNotServed.EditValue += 1
                    vCustRow.Item("NotServed") = 1
                    vCustRow.Item("TooManyAtHome") = 1
                End If
            End If
        Else
            If vNormToSend + vAdultToSend = 0 Then
                txtXTooManyHome.EditValue += 1
                txtCustomersNotServed.EditValue += 1
                vCustRow.Item("NotServed") = 1
                vCustRow.Item("TooManyAtHome") = 1
            End If
            'Do not use credt then what has been calculated is orrect
        End If
        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {vCustRow.Item("customers_id"), "DVD_NORM"})
        If Not IsNothing(_CompensationRow) Then
            vNormCompensation = _CompensationRow.Item("compensation_qty")
        End If
        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {vCustRow.Item("customers_id"), "DVD_ADULT"})
        If Not IsNothing(_CompensationRow) Then
            vAdultCompensation = _CompensationRow.Item("compensation_qty")
        End If
        vCustRow.Item("NormCompensation") = vNormCompensation
        vCustRow.Item("AdultCompensation") = vAdultCompensation
        txtNormCompensation.EditValue += vNormCompensation
        txtAdultCompensation.EditValue += vAdultCompensation

        txtNormToSend.EditValue = txtNormToSend.EditValue + vNormToSend
        txtAdultToSend.EditValue = txtAdultToSend.EditValue + vAdultToSend
        vCustRow.Item("NormToSend") = vNormToSend
        vCustRow.Item("AdultToSend") = vAdultToSend
        If vNormToSend + vAdultToSend > 0 Then
            txtCustomersInNeed.EditValue += 1
            vIsCustInNeed = True
            vCustRow.Item("InNeed") = 1
        Else
            vIsCustInNeed = False
            vCustRow.Item("InNeed") = 0
        End If

    End Sub



    Private Sub ResetCounters()
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        txtAdultToSend.EditValue = 0
        txtAdultAssigned.EditValue = 0
        txtAdultRating.EditValue = 0
        txtCustomersInNeed.EditValue = 0
        txtCustomersNotServed.EditValue = 0
        txtCustomersServed.EditValue = 0
        txtNormToSend.EditValue = 0
        txtNormAssigned.EditValue = 0
        txtNormRating.EditValue = 0
        txtXCredit.EditValue = 0
        txtXDvdNotFound.EditValue = 0
        txtXSuspended.EditValue = 0
        txtXThrotling.EditValue = 0
        txtXTooManyHome.EditValue = 0
    End Sub
    Private Sub AssignDVD(ByRef isCompensation As Boolean, ByRef wl_id As Integer, ByRef vProducts_id As Integer, ByVal vDVDId As Integer, ByRef customers_id As Integer)
        Dim orders_id As Integer = 0
        Dim _DS As New dsProducts
        Dim _ObjProductsDvd As New clsProduct_DVD(SessionInfo, _DS, vProducts_id, vDVDId)
        _ObjProductsDvd.AssignDVD(isCompensation, wl_id, customers_id)
    End Sub
    Private Sub btnReOrderWhishList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReOrderWhishList.Click
        Dim _SQLTxt As String
        Dim _CustRow As DataRowView
        Dim _WLRow As DataRow
        Dim _DS As New DataSet
        Dim _i As Integer
        _DS.Tables.Add("TmpTable")
        CustView = New DataView(DS.Tables("customers"), "", "customers_id, customers_abo_rank ", DataViewRowState.CurrentRows)
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
        For Each _CustRow In CustView 'DS.Tables("customers").Rows
            _i = 1
            _SQLTxt = "SELECT wl_id, customers_id, product_id, rank from wishlist where customers_id = " & _CustRow.Item("customers_id") & " ORDER BY Rank "
            _DS.Tables("TmpTable").Clear()
            BKGlobal.Cls1.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
            For Each _WLRow In _DS.Tables("TmpTable").Rows
                _WLRow.Item("rank") = _i
                _i += 1
            Next
            BKGlobal.Cls1.UpdateDataSource(_DS.Tables("TmpTable"), _SQLTxt)
            txtCustomersToProcess.EditValue -= 1
            DoEvents()
        Next
        txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
    End Sub
    Private Sub btnThrottling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThrottling.Click
        MsgBox("Not YET. Please do it in BO", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnStartABO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartABO2.Click
        aboprocess2(sender, e)
    End Sub


    Private Sub XtraTabPage1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles XtraTabPage1.Paint

    End Sub

    Private Sub btnLoadInfo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInfo2.Click
        DS.Tables("customers").Clear()
        DS.Tables("products_dvd").Clear()
        DS.Tables("wishlist").Clear()


        Dim zz As Integer = 0
        For zz = 0 To 3
            sem(zz) = New ManualResetEvent(False)
        Next

        ThreadPool.QueueUserWorkItem(AddressOf WaitLoadCompleted, sem)
        ThreadPool.QueueUserWorkItem(AddressOf LoadCustomers, sem(0))
        ThreadPool.QueueUserWorkItem(AddressOf LoadAvailableDVD, sem(1))
        ThreadPool.QueueUserWorkItem(AddressOf LoadWishList, sem(2))
        ThreadPool.QueueUserWorkItem(AddressOf LoadCompensation, sem(3))

    End Sub

    Sub WaitLoadCompleted(ByVal state As Object)
        '        Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.STA)
        'WaitHandle.WaitAll(sem)
        sem(0).WaitOne()
        sem(1).WaitOne()
        sem(2).WaitOne()
        sem(3).WaitOne()

        txtInfo.Text = "Load Complete - Ready to start!"
        IsLoadComplete = True
    End Sub

    Private Sub btnStartABO3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartABO3.Click
        ThreadPool.QueueUserWorkItem(AddressOf _AboProcess.aboprocess3, Nothing)
    End Sub
End Class

