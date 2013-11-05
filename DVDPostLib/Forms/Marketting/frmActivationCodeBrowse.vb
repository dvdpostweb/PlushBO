Imports System.IO
Public Class frmActivationCodeBrowse
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
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkOnlyUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DS As DVDPostLib.dsMarketting
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivationCodeBrowse))
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.cmbGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.DS = New DVDPostLib.dsMarketting
        Me.chkOnlyUsed = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
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
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
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
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.cmbGroup)
        Me.TabParameters.Controls.Add(Me.lblYear)
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
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        Me.HelpProvider1.SetShowHelp(Me.lblYear, CType(resources.GetObject("lblYear.ShowHelp"), Boolean))
        '
        'cmbGroup
        '
        resources.ApplyResources(Me.cmbGroup, "cmbGroup")
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroup.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)), New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroup.Properties.Buttons1"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("activation_group_id", "group_id", 199, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("activation_group_name", "name", 204, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbGroup.Properties.DataSource = Me.DS.activation_group
        Me.cmbGroup.Properties.DisplayMember = "activation_group_name"
        Me.cmbGroup.Properties.NullText = resources.GetString("cmbGroup.Properties.NullText")
        Me.cmbGroup.Properties.ValueMember = "activation_group_id"
        '
        'DS
        '
        Me.DS.DataSetName = "dsMarketting"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkOnlyUsed
        '
        resources.ApplyResources(Me.chkOnlyUsed, "chkOnlyUsed")
        Me.chkOnlyUsed.Name = "chkOnlyUsed"
        Me.chkOnlyUsed.Properties.Caption = resources.GetString("chkOnlyUsed.Properties.Caption")
        Me.chkOnlyUsed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Controls.Add(Me.chkOnlyUsed)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'frmActivationCodeBrowse
        '
        resources.ApplyResources(Me, "$this")
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmActivationCodeBrowse"
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
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsMarketting" 'The Dataset used 
    Dim CurrentCodeType As String
    Public WithEvents cmbLeverancier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit


    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New dvdpostbuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Show Activation Expiration"

        Try
            objDS = DS
            TableName = "activation_code" '_view1"
            IDField = "activation_id"
            NameField = "activation_code"
            SQLTxt1 = "SELECT * FROM activatin_code "
            WhereClause = "  "
            OrderByClause = " "
            MaintenanceMenuID = -1
            CanNew = False
            CanEdit = False
            CanSave = False
            CanDelete = False
            Me.AutoLoadData = False
            btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            MyBase.StartUp()
            LoadBKComboSet()
            'GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            'GridView1.OptionsBehavior.Editable = True
            TabParameters.PageVisible = True
            TabAnalyse.PageVisible = True
            TabChart.PageVisible = False
            TabControl1.SelectedTabPage = TabParameters
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, eLoad)
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub
    Public Overrides Sub LoadDataSet()

        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"

        Me.WhereClause = "WHERE 1 "
        If cmbGroup.EditValue & "" <> "" Then
            Me.WhereClause = Me.WhereClause & " AND activation_group = " & cmbGroup.EditValue
        Else

        End If
        If chkOnlyUsed.Checked = True Then
            Me.WhereClause = Me.WhereClause & " AND customers_id <> 0 "
            If txtFromDate.ToString & "" <> "" Then
                Me.WhereClause = Me.WhereClause & " AND activation_date >= '" & _DateFromTxt & "' "
            End If
            If txtToDate.ToString & "" <> "" Then
                Me.WhereClause = Me.WhereClause & " AND activation_date <= '" & _DateToTxt & "' "
            End If
        End If
        Dim _SQLTxt As String = "SELECT * FROM activation_code ac LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group "
        'If IsNothing(objDS.Tables(TableName)) Then
        '    objDS.Tables.Add(TableName)
        'Else
        objDS.Tables(TableName).Clear()
        'End If
        Try
            BKFilter.ApplyFilter(_SQLTxt, IsFiltered, CurrentFilterID, WhereClause & "", StatusBar1.Panels(1))
            Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt & " " & OrderByClause)
        Catch eFillDataSet As System.Exception
            'Add your error handling code here.
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eFillDataSet)
            ' Throw eFillDataSet
        End Try
        Try
            'Empty the old records from the dataset.
            'objDS.Clear()
            'Merge the records into the main dataset.
            'objDS.Merge(objDataSetTemp)
        Catch eLoadMerge As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eLoadMerge)
            'Add your error handling code here.
            ' Throw eLoadMerge
        End Try
        objDS.Tables(TableName).DefaultView.Sort = NameField
        Grid1.DataSource = objDS.Tables(TableName)
        UcPivotGrid1.PivotGrid1.DataSource = objDS.Tables(TableName)
        UcPivotGrid1.SetFields()
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "activation_group", "activation_group_id", "SELECT * FROM activation_group")
            BKCombo.GetCombo(objDS, "products", "products_id", "SELECT products_id, products_title FROM products where products_type = 'ABO' ")
            BKCombo.GetCombo(objDS, "activation_validity_type", "validity_type_id", "SELECT * FROM  activation_validity_type")
            BKCombo.GetCombo(objDS, "discount_code", "discount_code_id", "SELECT * FROM  discount_code")
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            Throw ex
        End Try
    End Sub

    Private Sub cmbGroup_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbGroup.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
            cmbGroup.EditValue = DBNull.Value
        End If
    End Sub

    'by gauthier
    Private Sub btnActivationExp_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        loadActivationExpiration()
        TabControl1.SelectedTabPage = TabResult
    End Sub

    'by gauthier
    Private Sub loadActivationExpiration()
        Dim dt As DataTable
        Dim sqlActivationExp As String = DvdPostData.clsActivationCode.GetActivationExpiration()
        dt = DvdPostData.clsConnection.FillDataSet(sqlActivationExp)
        Grid1.DataSource = dt
    End Sub


    'change color of the row by gauthier
    'Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
    '    Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
    '    If (e.RowHandle >= 0) Then
    '        Dim validitytoString As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("activation_code_validto_date")).ToString
    '        If validitytoString <> "" Then
    '            Dim validityToDate As Date = CType(validitytoString, Date)
    '            If validityToDate >= Date.Now Then
    '                e.Appearance.BackColor = Drawing.Color.LightGreen
    '                e.Appearance.BackColor2 = Drawing.Color.SeaShell
    '            End If

    '            If validityToDate < Date.Now Then
    '                e.Appearance.BackColor = Drawing.Color.LightSalmon
    '                e.Appearance.BackColor2 = Drawing.Color.SeaShell
    '            End If

    '        End If
    '    End If
    'End Sub


End Class
