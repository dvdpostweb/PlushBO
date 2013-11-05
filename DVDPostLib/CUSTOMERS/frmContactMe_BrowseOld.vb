Public Class frmContactMe_BrowseOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContactMe_BrowseOld))
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
        'frmContactMe_BrowseOld
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmContactMe_BrowseOld"
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

    Dim _repos_WeekDay As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim _repos_Reason As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Dim _repos_Time As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsCustomers
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        '
        'WeekDay
        BKCombo.GetCombo(objDS, "weekdays", "codevalue", "SELECT CodeValue, CodeDesc FROM generalglobalcodeint as weekday where codetype = 'WeekDay'")
        _repos_WeekDay.DataSource = objDS.Tables("weekdays")
        _repos_WeekDay.DisplayMember = "CodeDesc"
        _repos_WeekDay.ValueMember = "CodeValue"
        Grid1.RepositoryItems.Add(_repos_WeekDay)
        'Reason
        BKCombo.GetCombo(objDS, "phone_request_reason", "codevalue", "SELECT CodeValue, CodeDesc FROM generalglobalcode as phone_request_reason where codetype = 'phone_request_reason'")
        _repos_Reason.DataSource = objDS.Tables("phone_request_reason")
        _repos_Reason.DisplayMember = "CodeDesc"
        _repos_Reason.ValueMember = "CodeValue"
        Grid1.RepositoryItems.Add(_repos_Reason)
        'Time
        BKCombo.GetCombo(objDS, "phone_request_hours", "codevalue", "SELECT CodeValue, CodeDesc FROM generalglobalcode as phone_request_hours where codetype = 'phone_request_time'")
        _repos_Time.DataSource = objDS.Tables("phone_request_hours")
        _repos_Time.DisplayMember = "CodeDesc"
        _repos_Time.ValueMember = "CodeValue"
        Grid1.RepositoryItems.Add(_repos_Time)

        MyBase.TableName = "phone_request"
        MyBase.IDField = "id"
        MyBase.NameField = "id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        btnUser1.Caption = "Set Answered"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)

        End If
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String


        objDS.Tables(TableName).Clear()
        _SQLTxt = " select  pr.id, pr.name, pr.phone, pr.customers_id, pr.language_id, pr.call_me_day, pr.call_me_hour, pr.call_me_reason,(select if(pr.call_me_day = 0 ,'Every day',(select from_unixtime(pr.call_me_day,'%Y %M %D')))) as call_day,pr.call_comment,call_answerd FROM phone_request pr LEFT JOIN customers c on c.customers_id = pr.customers_id"

        BKFilter.ApplyFilter(_SQLTxt, True, CurrentFilterID, "")
        PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        Grid1.DataSource = objDS.Tables(TableName).DefaultView

        GridView1.Columns("call_me_day").ColumnEdit = _repos_WeekDay
        GridView1.Columns("call_me_hour").ColumnEdit = _repos_Time
        GridView1.Columns("call_me_reason").ColumnEdit = _repos_Reason

        GridView1.RefreshData()
        TabControl1.SelectedTabPage = TabResult

    End Sub
    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        Dim _Comment As String
        Dim _id As Integer
        If GridView1.FocusedRowHandle < 0 Then Exit Sub
        _id = GridView1.GetDataRow(GridView1.FocusedRowHandle)("id")
        _Comment = InputBox("Add your comment", "Comment", "")
        Dim _SQLTXt As String = "UPDATE phone_request set call_answerd = 1, call_comment = '" & _Comment & "' " & _
              " WHERE id = " & _id
        PlushData.clsConnection.ExecuteNonQuery(_SQLTXt)
    End Sub
    Public Overrides Sub gridview1_doubleclick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.FocusedRowHandle < 0 Then
            Exit Sub
        End If
        Dim customers_id As Integer = GridView1.GetDataRow(GridView1.FocusedRowHandle)("customers_id")
        ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)

    End Sub

End Class
