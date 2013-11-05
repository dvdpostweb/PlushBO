Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Public Class frmOffLineDetail
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffLineDetail))
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
        'frmOffLineDetail
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmOffLineDetail"
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

    Dim _Limit As String = " limit 0, 100 "
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim mvarLogo As String = ""

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objDS = New dsCompta
        'TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "Offline_Payment_Step_View1"
        MyBase.IDField = "payment_offline_request_id"
        MyBase.NameField = "payment_offline_request_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        'mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("languages"), "SELECT * from languages ")
        BKGlobal.Cls1.FillDataSet(objDS.Tables("site"), "SELECT * from site ")
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Close Selected"
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        'Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        'Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT * FROM payment_offline_request por left join customers c on c.customers_id = por.customers_id " & _
            "  LEFT JOIN address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id "
        BKFilter.ApplyFilter(_SQLTxt, False, cmbFilterList.EditValue, WhereClause)
        BKGlobal.Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        'Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        'Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim _frm As New frmCustomers_Maint(SessionInfo)
        _frm.MdiParent = Me.ParentForm
        _frm.Text = "Cust. Maint"
        _frm.Show()
        _frm.txtQuickSearch.EditValue = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("customers_id")
        _frm.CurrentCustomerID = _frm.txtQuickSearch.EditValue
        _frm.LoadCustomerInfo()
        _frm.XtraTabControl1.SelectedTabPage = _frm.tabMain
    End Sub

    Public Sub btnuser1_Itemclick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        MsgBox("IF status is already given to EuroFides, the system will not close the OffLine Payment", MsgBoxStyle.OkOnly)
        Dim _i As Integer
        Dim _OffLineRow As DataRow
        Dim _OffLineID As Integer = 0
        Dim _objOffline As clsOffLinePayments
        For _i = 0 To GridView1.SelectedRowsCount - 1
            _OffLineRow = GridView1.GetDataRow(GridView1.GetSelectedRows(_i))
            _OffLineID = _OffLineRow.Item("payment_offline_request_id")
            If _OffLineRow.Item("offline_status") = 9 Or _OffLineRow.Item("offline_status") = 18 Then
                MsgBox("Cannot Change status of Payment ID = " & _OffLineID & " beacause it is already given to EuroFides", MsgBoxStyle.Information)
            Else
                _objOffline = New clsOffLinePayments(SessionInfo)
                _objOffline.CurrentOffLineID = _OffLineID
                _objOffline.UpdatePaymentOfflineStatus(False, False, "", clsOffLinePayments.PAYMENT_OFFLINE_STATUS_CANCELED)
            End If
        Next
    End Sub
End Class
