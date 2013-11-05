
Public Class frmOgone_Browse

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
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnall As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    '<System.Diagnostics.DebuggerStepThrough()> 
    Private Sub InitializeComponent()
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnall = New DevExpress.XtraEditors.SimpleButton
        Me.BtnReconduction = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.BtnReconduction)
        Me.TabParameters.Controls.Add(Me.btnall)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
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
        'txtLimit
        '
        Me.txtLimit.Location = New System.Drawing.Point(503, 23)
        Me.txtLimit.Name = "txtLimit"
        Me.HelpProvider1.SetShowHelp(Me.txtLimit, False)
        Me.txtLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtLimit.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(400, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.HelpProvider1.SetShowHelp(Me.ProgressBar1, False)
        Me.ProgressBar1.Size = New System.Drawing.Size(386, 18)
        Me.ProgressBar1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 20)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, False)
        Me.GroupControl1.Size = New System.Drawing.Size(340, 100)
        Me.GroupControl1.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, False)
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "To Date"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, False)
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "From Date"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(146, 57)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, False)
        Me.txtToDate.Size = New System.Drawing.Size(100, 20)
        Me.txtToDate.TabIndex = 2
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(146, 31)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, False)
        Me.txtFromDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDate.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(397, 23)
        Me.Label6.Name = "Label6"
        Me.HelpProvider1.SetShowHelp(Me.Label6, False)
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Limit"
        '
        'btnall
        '
        Me.btnall.Location = New System.Drawing.Point(14, 145)
        Me.btnall.Name = "btnall"
        Me.HelpProvider1.SetShowHelp(Me.btnall, False)
        Me.btnall.Size = New System.Drawing.Size(147, 23)
        Me.btnall.TabIndex = 27
        Me.btnall.Text = "all modified "
        Me.btnall.ToolTip = "all modified"
        '
        'BtnReconduction
        '
        Me.BtnReconduction.Location = New System.Drawing.Point(180, 145)
        Me.BtnReconduction.Name = "BtnReconduction"
        Me.HelpProvider1.SetShowHelp(Me.BtnReconduction, False)
        Me.BtnReconduction.Size = New System.Drawing.Size(147, 23)
        Me.BtnReconduction.TabIndex = 28
        Me.BtnReconduction.Text = "Reconduction"
        Me.BtnReconduction.ToolTip = "all modified"
        '
        'frmOgone_Browse
        '
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmOgone_Browse"
        Me.HelpProvider1.SetShowHelp(Me, False)
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
        CType(Me.ProgressBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        MyBase.TableName = "ogone_payment"
        '  MyBase.IDField = "ogone_payment_id"
        '  MyBase.NameField = "ogone_payment_id"
        '  MyBase.MaintenanceMenuID = -1
        '  MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        ' MyBase.StartUp()

        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)

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
    Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimit.TextChanged
        _Limit = "limit 0, " & txtLimit.Text
    End Sub
    Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
        LoadDataSet()
    End Sub


    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT * FROM ogone_payment " & _
            " where date(date_added) >= '" & _DateFromTxt & "' and date(date_added) <= '" & _DateToTxt & "'"

        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
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

    Private Sub btnall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnall.Click
        Dim _SQLTxt As String
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
        'Clear Table
        objDS.Tables(TableName).Clear()
        _SQLTxt = "SELECT * FROM ogone_payment " & _
            " where date(last_modified) >= '" & _DateFromTxt & "' and date(last_modified) <= '" & _DateToTxt & "'"

        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub BtnReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReconduction.Click
        LoadDataSet()
    End Sub
End Class
