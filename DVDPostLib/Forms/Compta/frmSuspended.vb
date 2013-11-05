Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Public Class frmSuspended
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuspended))
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
        'frmSuspended
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmSuspended"
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

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsCompta
        'TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "customersView1"
        MyBase.IDField = "customers_id"
        MyBase.NameField = "customers_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Check Payments"
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
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
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT * FROM customers c " & _
            "  LEFT JOIN address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id " & _
            " where customers_abo_suspended = 2 "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub btnUSer1_Itemclick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        Dim _Sql As String
        Dim _Row As DataRow
        Dim _PayExist As Boolean
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable1")
        _DS.Tables.Add("TmpTable2")
        'Suspend all Customers that Have Payment in Status 3,4,5,6,7,8
        _Sql = "select p.customers_id, p.payment_offline_status, c.customers_abo_suspended FROM payment_offline_request p left join customers c on c.customers_id = p.customers_id" & _
               "  where payment_offline_status in (3, 4, 5, 6, 7, 8, 9) and c.customers_abo_suspended <> 2 "
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable1"), _Sql)
        For Each _Row In _DS.Tables("TmpTable1").Rows
            _Sql = "update customers set customers_abo_suspended = 2 , last_suspension_date = now() where customers_id = " & _Row("customers_id")
            DvdPostData.clsConnection.ExecuteNonQuery(_Sql)
            _Sql = "INSERT INTO abo_suspended_history values (Null, " & _Row("customers_id") & _
                   ", now(), 1, 2, 'Payment' " & _
                   ") "
            DvdPostData.clsConnection.ExecuteNonQuery(_Sql)
        Next

        'Check that all suspended Customers still have a payment with status in 3,4,5,6,7,8
        _Sql = "select c.customers_id FROM customers c " & _
               " WHERE c.customers_abo_suspended = 2 "
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable2"), _Sql)
        For Each _Row In _DS.Tables("TmpTable2").Rows
            _Sql = "select count(*) FROM payment_offline_request p where customers_id = " & _Row("customers_id") & " AND payment_offline_status in (3, 4, 5, 6, 7, 8, 9)"
            _PayExist = BKGlobal.ExecuteExists(_Sql)
            If Not _PayExist Then
                _Sql = "update customers set customers_abo_suspended = 0 where customers_id = " & _Row("customers_id")
                DvdPostData.clsConnection.ExecuteNonQuery(_Sql)
                _Sql = "INSERT INTO abo_suspended_history values (Null, " & _Row("customers_id") & _
                       ", now(), 2, 2, 'Payment' " & _
                       ") "
                DvdPostData.clsConnection.ExecuteNonQuery(_Sql)
            End If
        Next


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
