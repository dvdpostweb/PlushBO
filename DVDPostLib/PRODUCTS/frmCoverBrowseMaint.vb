Public Class frmCoverBrowseMaint
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoverBrowseMaint))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtBoxID = New DevExpress.XtraEditors.TextEdit
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.txtProductID)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.txtBoxID)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
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
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtBoxID
        '
        resources.ApplyResources(Me.txtBoxID, "txtBoxID")
        Me.txtBoxID.Name = "txtBoxID"
        Me.HelpProvider1.SetShowHelp(Me.txtBoxID, CType(resources.GetObject("txtBoxID.ShowHelp"), Boolean))
        '
        'txtProductID
        '
        resources.ApplyResources(Me.txtProductID, "txtProductID")
        Me.txtProductID.Name = "txtProductID"
        Me.HelpProvider1.SetShowHelp(Me.txtProductID, CType(resources.GetObject("txtProductID.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'frmCoverBrowseMaint
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmCoverBrowseMaint"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabParameters.PerformLayout()
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip



        objDS = New dsProducts
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        CanDelete = False
        CanSave = True
        MyBase.TableName = "products_cover_view1"
        MyBase.IDField = "products_id"
        MyBase.NameField = "products_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        btnUser1.Caption = "Search DVD"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        'btnOK
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        TabAnalyse.Visible = False
        TabChart.Visible = False
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            'LoadDataSet()
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If
        Grid1.UseEmbeddedNavigator = True
        GridView1.OptionsBehavior.Editable = True
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        If Not IsNumeric(txtBoxID.EditValue) Then txtBoxID.EditValue = ""
        If Not IsNumeric(txtProductID.EditValue) Then txtProductID.EditValue = ""
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT pc.products_id, cover_box_id, qty, p.products_model " & _
                    " FROM products_cover pc " & _
                    " LEFT JOIN products p on p.products_id = pc.products_id WHERE 1 "
        If txtBoxID.EditValue = "" Then

        Else
            _SQLTxt = _SQLTxt & " AND cover_box_id = " & txtBoxID.EditValue
        End If
        If txtProductID.EditValue = "" Then

        Else
            _SQLTxt = _SQLTxt & " AND pc.products_id = " & txtProductID.EditValue
        End If
        Try
            PlushData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
            Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
            Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
            Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
            If txtBoxID.EditValue <> "" Then objDS.Tables(TableName).Columns("cover_box_id").DefaultValue = txtBoxID.EditValue
            If txtProductID.EditValue <> "" Then objDS.Tables(TableName).Columns("products_id").DefaultValue = txtProductID.EditValue
            TabControl1.SelectedTabPage = TabResult
        Catch ex As Exception
            PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, ex)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Overrides Sub UpdateDataSet()
        If CanSave Then
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()
            'Create a new dataset to hold the changes that have been made to the main dataset.
            'Dim objDataSetChanges As BizzLib.dsGeneral = New BizzLib.dsGeneral
            Dim objDataSetChanges As DataSet
            objDataSetChanges = objDS.Clone
            'Stop any current edits.
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            'Get the changes that have been made to the main dataset.
            objDataSetChanges = objDS.GetChanges
            'Check to see if any changes have been made.
            If (Not (objDataSetChanges) Is Nothing) Then
                Try
                    'There are changes that need to be made, so attempt to update the datasource by
                    'calling the update method and passing the dataset and any parameters.
                    Cls1.UpdateDataSource(objDataSetChanges.Tables(TableName), "SELECT * from products_cover")
                    'objDS.Merge(objDataSetChanges)
                    objDS.AcceptChanges()
                Catch eUpdate As System.Exception
                    'Add your error handling code here.
                    PlushBuziness.clsMsgError.InsertLogMsg(PlushData.clsMsgError.processType.Stock, eUpdate)
                    System.Windows.Forms.MessageBox.Show(eUpdate.Message)
                End Try
                'Add your code to check the returned dataset for any errors that may have been
                'pushed into the row object's error.
            End If

        End If
        LoadDataSet()
    End Sub
    Private Sub btnUser1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        Dim _frm As New frmDiagFindProductID(SessionInfo)
        _frm.ShowDialog(Me)
        If _frm.DialogResult = Windows.Forms.DialogResult.OK Then
            If Not IsNumeric(_frm.Products_ID) Then Exit Sub
            GridView1.GetDataRow(GridView1.FocusedRowHandle)("products_id") = _frm.Products_ID
        End If
    End Sub

End Class
