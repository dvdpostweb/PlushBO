Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Public Class frmDVDatHomeStep
    Inherits BizzLib.frmGeneral_Browse


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
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDVDatHomeStep))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        '
        'TabParameters
        '
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'frmPaymentOffLineStep
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmDVDatHomeStep"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    'Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = ""
    Dim mvarsite As String = ""
    Dim mvarLogo As String = ""
    Dim _ds As dsCompta

    'Dim _clsPaymentOfflineData As DvdPostData.PaymentOfflineData
    Dim _parameters As DVDPostBuziness.clsSingleton
    Dim _DVDatHome As DVDPostBuziness.clsDVDatHome
    Dim _ListActionUser() As DevExpress.XtraBars.BarButtonItem = {btnUser1, btnUser2, btnUser3, btnUser4, btnUser5}

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        grid1.ContextMenuStrip = menuStrip


        _parameters = DVDPostBuziness.clsSingleton.Instance()
        _ds = New dsCompta()

        objDS = _ds

        CanNew = False
        CanEdit = False
        MyBase.TableName = "DVDatHome_Step_View"

        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()



        CurrentDefaultSetID = cmbDefaultList.EditValue

        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            LoadDataSet()
            TabControl1.SelectedTabPage = TabResult

        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
        TabResult.Name = _parameters.StrTypeStepPaymentOffline
        TabResult.Text = _parameters.StrTypeStepPaymentOffline

        _DVDatHome = New DVDPostBuziness.clsDVDatHome()

        loadAction(_DVDatHome.GetStep(_parameters.TypeStepPaymentOffline))
    End Sub

    Private Sub loadAction(ByVal listAction As String())

        If listAction Is Nothing Then Return
        For index As Integer = 0 To listAction.Length - 1
            _ListActionUser(index).Caption = listAction(index)
            _ListActionUser(index).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Next


    End Sub


    Public Overrides Sub LoadDataSet()

        If Not objDS.Tables.Contains(TableName) Then
            objDS.Tables.Add(TableName)
        Else
            objDS.Tables(TableName).Clear()
        End If

        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), DvdPostData.PaymentOfflineData.GetStepPayment(_parameters.TypeStepPaymentOffline))
        _DVDatHome = New DVDPostBuziness.clsDVDatHome()

        Grid1.DataSource = _DVDatHome.addProductsTitles(objDS.Tables(TableName))
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub

    Private Sub btnUser1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick

        _DVDatHome.ExecuteStep(GridView1, btnUser1.Caption)
        LoadDataSet()
    End Sub

    Private Sub btnUser2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
      
        _DVDatHome.ExecuteStep(GridView1, btnUser2.Caption)
        LoadDataSet()
    End Sub

    Private Sub btnUser3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser3.ItemClick

        _DVDatHome.ExecuteStep(GridView1, btnUser3.Caption)
        LoadDataSet()
    End Sub

    Private Sub btnUser4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser4.ItemClick

        _DVDatHome.ExecuteStep(GridView1, btnUser4.Caption)
        LoadDataSet()
    End Sub


    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim customers_id As Integer = GridView1.GetDataRow(GridView1.FocusedRowHandle)("customers_id")
        ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
        'Dim _frm As New frmCustomers_Maint(SessionInfo)
        '_frm.MdiParent = Me.ParentForm
        '_frm.Text = "Cust. Maint"
        '_frm.Show()
        '_frm.txtQuickSearch.EditValue = GridView1.GetDataRow(GridView1.FocusedRowHandle)("customers_id")
        '_frm._CurrentCustomerID = _frm.txtQuickSearch.EditValue
        '_frm.LoadCustomerInfo()
        '_frm.XtraTabControl1.SelectedTabPage = _frm.tabMain
    End Sub

End Class
