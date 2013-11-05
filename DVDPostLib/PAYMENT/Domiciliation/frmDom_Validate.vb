Imports System.Windows.Forms.Application

Public Class frmDom_Validate
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OFDFileDom As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnPrintActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnChangeStatus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LBFiles As System.Windows.Forms.ListBox
    Friend WithEvents btnMatchDom As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMatching As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RTBBatch As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDom_Validate))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.lbl1 = New System.Windows.Forms.Label
        Me.RTBBatch = New System.Windows.Forms.RichTextBox
        Me.btnReconduction = New DevExpress.XtraEditors.SimpleButton
        Me.BtnActivation = New DevExpress.XtraEditors.SimpleButton
        Me.BtnImport = New DevExpress.XtraEditors.SimpleButton
        Me.OFDFileDom = New System.Windows.Forms.OpenFileDialog
        Me.BtnPrintActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnChangeStatus = New DevExpress.XtraEditors.SimpleButton
        Me.LBFiles = New System.Windows.Forms.ListBox
        Me.btnMatchDom = New DevExpress.XtraEditors.SimpleButton
        Me.btnMatching = New DevExpress.XtraEditors.SimpleButton
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
        Me.TabParameters.Controls.Add(Me.btnMatching)
        Me.TabParameters.Controls.Add(Me.btnMatchDom)
        Me.TabParameters.Controls.Add(Me.LBFiles)
        Me.TabParameters.Controls.Add(Me.btnChangeStatus)
        Me.TabParameters.Controls.Add(Me.BtnPrintActivation)
        Me.TabParameters.Controls.Add(Me.BtnImport)
        Me.TabParameters.Controls.Add(Me.BtnActivation)
        Me.TabParameters.Controls.Add(Me.btnReconduction)
        Me.TabParameters.Controls.Add(Me.RTBBatch)
        Me.TabParameters.Controls.Add(Me.Label6)
        Me.TabParameters.Controls.Add(Me.txtLimit)
        Me.TabParameters.Controls.Add(Me.ProgressBar1)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.lbl1)
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
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        Me.HelpProvider1.SetShowHelp(Me.Label6, CType(resources.GetObject("Label6.ShowHelp"), Boolean))
        '
        'txtLimit
        '
        resources.ApplyResources(Me.txtLimit, "txtLimit")
        Me.txtLimit.Name = "txtLimit"
        Me.HelpProvider1.SetShowHelp(Me.txtLimit, CType(resources.GetObject("txtLimit.ShowHelp"), Boolean))
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.HelpProvider1.SetShowHelp(Me.ProgressBar1, CType(resources.GetObject("ProgressBar1.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
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
        'lbl1
        '
        resources.ApplyResources(Me.lbl1, "lbl1")
        Me.lbl1.Name = "lbl1"
        Me.HelpProvider1.SetShowHelp(Me.lbl1, CType(resources.GetObject("lbl1.ShowHelp"), Boolean))
        '
        'RTBBatch
        '
        resources.ApplyResources(Me.RTBBatch, "RTBBatch")
        Me.RTBBatch.Name = "RTBBatch"
        Me.HelpProvider1.SetShowHelp(Me.RTBBatch, CType(resources.GetObject("RTBBatch.ShowHelp"), Boolean))
        '
        'btnReconduction
        '
        resources.ApplyResources(Me.btnReconduction, "btnReconduction")
        Me.btnReconduction.Name = "btnReconduction"
        Me.HelpProvider1.SetShowHelp(Me.btnReconduction, CType(resources.GetObject("btnReconduction.ShowHelp"), Boolean))
        '
        'BtnActivation
        '
        resources.ApplyResources(Me.BtnActivation, "BtnActivation")
        Me.BtnActivation.Name = "BtnActivation"
        Me.HelpProvider1.SetShowHelp(Me.BtnActivation, CType(resources.GetObject("BtnActivation.ShowHelp"), Boolean))
        '
        'BtnImport
        '
        resources.ApplyResources(Me.BtnImport, "BtnImport")
        Me.BtnImport.Name = "BtnImport"
        Me.HelpProvider1.SetShowHelp(Me.BtnImport, CType(resources.GetObject("BtnImport.ShowHelp"), Boolean))
        '
        'OFDFileDom
        '
        Me.OFDFileDom.InitialDirectory = """z:\finance\coda"""
        Me.OFDFileDom.Multiselect = True
        '
        'BtnPrintActivation
        '
        resources.ApplyResources(Me.BtnPrintActivation, "BtnPrintActivation")
        Me.BtnPrintActivation.Name = "BtnPrintActivation"
        Me.HelpProvider1.SetShowHelp(Me.BtnPrintActivation, CType(resources.GetObject("BtnPrintActivation.ShowHelp"), Boolean))
        '
        'btnChangeStatus
        '
        resources.ApplyResources(Me.btnChangeStatus, "btnChangeStatus")
        Me.btnChangeStatus.Name = "btnChangeStatus"
        Me.HelpProvider1.SetShowHelp(Me.btnChangeStatus, CType(resources.GetObject("btnChangeStatus.ShowHelp"), Boolean))
        '
        'LBFiles
        '
        Me.LBFiles.FormattingEnabled = True
        resources.ApplyResources(Me.LBFiles, "LBFiles")
        Me.LBFiles.Name = "LBFiles"
        '
        'btnMatchDom
        '
        resources.ApplyResources(Me.btnMatchDom, "btnMatchDom")
        Me.btnMatchDom.Name = "btnMatchDom"
        Me.HelpProvider1.SetShowHelp(Me.btnMatchDom, CType(resources.GetObject("btnMatchDom.ShowHelp"), Boolean))
        '
        'btnMatching
        '
        resources.ApplyResources(Me.btnMatching, "btnMatching")
        Me.btnMatching.Name = "btnMatching"
        Me.HelpProvider1.SetShowHelp(Me.btnMatching, CType(resources.GetObject("btnMatching.ShowHelp"), Boolean))
        '
        'frmDom_Validate
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmDom_Validate"
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
    Public Const CREDITOR_NAME_HES As String = "HOME ENTERTAINMENT SERVICES"
    Public Const FINANCIAL_INSTITUTE_ID As String = "300" 'Code ING
    Public Shared DVDPOST_BANK_ACCOUNT_ING_1 As String = "310168751895"
    Public Shared DVDPOST_BANK_ACCOUNT_ING_2 As String = "310191369467"
    Public Shared DOM80_DATA_NATURE_CODE_REFUND As String = "1"
    Public Shared DOM80_DATA_NATURE_CODE_PAYMENT As String = "0"
    Public Const PAYMENT_DOMICILIATION_COMMUNICATION_TRAILER As String = "0"
    Public Const PAYMENT_OFFLINE_REQUEST_COMMUNICATION_TRAILER As String = "3"

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        objDS.Tables.Add("AboInfo")
        MyBase.TableName = "domiciliation_payment_Validate"
        MyBase.IDField = "domiciliation_payment_id"
        MyBase.NameField = "domiciliation_payment_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()


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

    'Public Overrides Sub LoadDataSet()
    '    Dim _SQLTxt As String
    '    Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
    '    Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
    '    'Clear Table
    '    objDS.Tables(TableName).Clear()
    '    _SQLTxt = "SELECT d.*, c.activation_discount_code_id as current_discount_code_id FROM domiciliation_payment d " & _
    '        " LEFT JOIN customers c on c.customers_id = d.customers_id " & _
    '        " where domiciliation_payment_date >= '" & _DateFromTxt & " 00:00:00' and domiciliation_payment_date <= '" & _DateToTxt & " 23:59:59'"

    '     DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

    '    'Load extra Info
    '    LoadPreviousMonthAmount()
    '    LoadAboInfo()

    '    Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
    '    Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
    '    Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
    '    TabControl1.SelectedTabPage = TabResult
    'End Sub
    'Private Sub LoadAboInfo()
    '    Dim _SQLTxt As String
    '    Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
    '    Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
    '    Dim _row As DataRow
    '    Dim _Curr_CustID As Integer = -1


    '    _SQLTxt = "SELECT p.products_model as products_model, a.abo_id as abo_id, a.customerid,a.code_id as Code_Id, a.Action as Abo_Action, aa.Name as Abo_Action_Name," & _
    '              " a.`date` as Abo_Date, p.products_title as Abo_Type, p.products_price as Abo_Amount," & _
    '              " ac.validity_type as validity_type, ac.validity_value as validity_value, dta.discount_explained as activation_explained," & _
    '              " dc.discount_type as discount_type, dc.discount_value as discount_value, dtd.discount_explained as discount_explained," & _
    '              " customers_firstname, customers_lastname, domiciliation_debiter_name, domiciliation_number," & _
    '              " entry_street_address" & _
    '              " FROM abo a" & _
    '              " LEFT JOIN customers c on a.customerid = c.customers_id" & _
    '              " LEFT JOIN address_book ab on ab.customers_id = c.customers_id and ab.address_book_id = c.customers_default_address_id" & _
    '              " LEFT JOIN abo_action aa on a.`action` = aa.id" & _
    '              " LEFT JOIN Products p on a.product_id = p.products_id" & _
    '              " LEFT JOIN discount_code dc on dc.discount_code_id = a.code_id" & _
    '              " LEFT JOIN activation_code ac on ac.activation_id = a.code_id" & _
    '              " LEFT JOIN discount_type dta on ac.validity_type = dta.discount_type" & _
    '              " LEFT JOIN discount_type dtd on dc.discount_type = dtd.discount_type" & _
    '              " where a.`Date` >= '" & _DateFromTxt & " 00:00:00' and a.`Date` <= '" & _DateToTxt & " 23:59:59';"
    '    '                  " AND a.`Action` in (6,7,8,9)" & _
    '    lbl1.Text = "Loading ABO Info"
    '    ProgressBar1.EditValue = 0
    '     DvdPostData.clsConnection.FillDataSet(objDS.Tables("AboInfo"), _SQLTxt)
    '    'objDS.Tables("AboInfo").PrimaryKey = New DataColumn() {objDS.Tables("AboInfo").Columns("customerid")}
    '    Dim _ViewAboInfo As New DataView(objDS.Tables("AboInfo"), "", "abo_id", DataViewRowState.CurrentRows)
    '    Dim _ViewAboInfoUpDow As New DataView(objDS.Tables("AboInfo"), "", "customerid", DataViewRowState.CurrentRows)
    '    For Each _row In objDS.Tables(TableName).Rows
    '        ProgressBar1.EditValue += 1
    '        ProgressBar1.Refresh()
    '        If Not IsDBNull(_row("customers_id")) Then
    '            _Curr_CustID = _row("customers_id")
    '            Dim _Curr_Row As DataRowView = _ViewAboInfo(_ViewAboInfo.Find(New Object() {_row("abo_id")}))
    '            Dim _RowUpDown As DataRowView
    '            For Each _RowUpDown In _ViewAboInfoUpDow.FindRows(_Curr_CustID)
    '                If _RowUpDown("Abo_Action") = 2 Or _RowUpDown("Abo_Action") = 3 Then
    '                    _row("UpgradeDownGrade") = _RowUpDown("Abo_Action")
    '                    Exit For
    '                End If
    '            Next
    '            'objDS.Tables("AboInfo").Select("customerid = " & _Curr_CustID) 'objDS.Tables("AboInfo").Rows(0)
    '            _row("Abo_Type") = _Curr_Row("Abo_Type")
    '            _row("Abo_Amount") = _Curr_Row("Abo_Amount")
    '            _row("Abo_Date") = _Curr_Row("Abo_Date")
    '            _row("Abo_Action_Name") = _Curr_Row("Abo_Action_Name")
    '            _row("products_model") = _Curr_Row("products_model")
    '            Select Case _Curr_Row("Abo_Action").ToString
    '                Case "8"
    '                    _row("Discount_Type") = _Curr_Row("validity_type")
    '                    _row("Discount_Value") = _Curr_Row("validity_value")
    '                    _row("Discount_Explained") = _Curr_Row("validity_explained")

    '                Case Else
    '                    _row("Discount_Type") = _Curr_Row("discount_type")
    '                    _row("Discount_Value") = _Curr_Row("discount_value")
    '                    _row("Discount_Explained") = _Curr_Row("discount_explained")
    '            End Select
    '            If Not IsDBNull(_row("Discount_Type")) Then
    '                Select Case _row("Discount_Type").ToString
    '                    Case "1"
    '                        _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount") * (1 - _Curr_Row("discount_value") / 100)
    '                    Case "2"
    '                        _row("Abo_Amount_Discounted") = _Curr_Row("discount_value")
    '                    Case "3"
    '                        _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount") - _Curr_Row("discount_value")
    '                End Select
    '            Else
    '                _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount")
    '            End If
    '            _row("Diff") = _row("amount") - _row("Abo_Amount_Discounted")

    '            _row("customers_firstname") = _Curr_Row("customers_firstname")
    '            _row("customers_lastname") = _Curr_Row("customers_lastname")
    '            _row("domiciliation_debiter_name") = _Curr_Row("domiciliation_debiter_name")
    '            _row("domiciliation_number") = _Curr_Row("domiciliation_number")
    '            _row("entry_street_address") = _Curr_Row("entry_street_address")
    '        End If
    '    Next
    'End Sub
    'Private Sub LoadPreviousMonthAmount()
    '    Dim _SQLTxt As String
    '    Dim _Date1 As Date = CDate(txtFromDate.EditValue).AddMonths(-1)
    '    Dim _Date2 As Date = CDate(txtToDate.EditValue).AddMonths(-1)
    '    Dim _DateFromTxt As String = Year(_Date1) & "-" & Month(_Date1) & "-" & DateAndTime.Day(_Date1)
    '    Dim _DateToTxt As String = Year(_Date2) & "-" & Month(_Date2) & "-" & DateAndTime.Day(_Date2)
    '    Dim _row As DataRow
    '    Dim _i As Integer
    '    Dim _PrevRow As DataRowView
    '    Dim _DS As New dsAboRent
    '    _DS.Tables(TableName).Clear()
    '    _SQLTxt = "SELECT * FROM domiciliation_payment " & _
    '        " where domiciliation_payment_date >= '" & _DateFromTxt & " 00:00:00' and domiciliation_payment_date <= '" & _DateToTxt & " 23:59:59'"
    '     DvdPostData.clsConnection.FillDataSet(_DS.Tables(TableName), _SQLTxt)
    '    Dim _View As New DataView(_DS.Tables(TableName), "", "customers_id", DataViewRowState.CurrentRows)
    '    ProgressBar1.EditValue = 0
    '    For Each _row In objDS.Tables(TableName).Rows
    '        ProgressBar1.EditValue += 1
    '        ProgressBar1.Refresh()
    '        If Not IsDBNull(_row("customers_id")) Then
    '            _i = _View.Find(_row("customers_id"))
    '            If _i <> -1 Then
    '                _PrevRow = _View(_i)
    '                If Not IsNothing(_PrevRow) Then
    '                    _row("previous_month_amount") = _PrevRow("amount")
    '                    _row("Diff_Month") = _row("previous_month_amount") - _row("amount")
    '                End If
    '            End If
    '        End If
    '    Next
    'End Sub

    'Private Function getBlanks(ByVal length As Integer) As String
    '    Dim result As String = ""
    '    Return result.PadLeft(length, " ")
    'End Function

    'Private Function validateSequenceNumber(ByRef value As String) As Boolean
    '    If value.Length() <> 4 Then
    '        Throw New Exception("validation error: length=4? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    'Private Function validatedomiciliationNumber(ByRef value As String) As Boolean
    '    If value.Length() <> 12 Then
    '        Throw New Exception("validation error: length=12? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    'Private Function validatenatureCode(ByRef value As String) As Boolean
    '    If value.Length() <> 1 Then
    '        Throw New Exception("validation error: length=1? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    ''N Montant de la facture (voir annexe 1.8).
    'Private Function validateamount(ByRef value As String) As Boolean
    '    If value.Length() <> 12 Then
    '        Throw New Exception("validation error: length=12? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    ''AN Nom du créancier.
    'Private Function validateCreditorName(ByRef value As String) As Boolean
    '    If value.Length() <> 26 Then
    '        Throw New Exception("validation error: length=26? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    ''AN Communication au payeur, 1ère partie.
    'Private Function validatedebtorCommunication1(ByRef value As String) As Boolean
    '    If value.Length() <> 15 Then
    '        Throw New Exception("validation error: length=15? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    ''AN Communication au payeur, 2e partie.
    'Private Function validatedebtorCommunication2(ByRef value As String) As Boolean
    '    If value.Length() <> 15 Then
    '        Throw New Exception("validation error: length=15? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    ''N Référence du créancier ou zéros Les deux derniers chiffres de cette référence forment le nombre contrôle des dix premiers chiffres.
    'Private Function validatecreditorReference(ByRef value As String) As Boolean
    '    If value.Length() <> 12 Then
    '        Throw New Exception("validation error: length=12? '" & value & "'")
    '    End If
    '    Return True
    'End Function

    'Private Function createDataLine(ByVal SequenceNumber As String, ByVal domiciliationNumber As String, ByVal natureCode As String, ByVal amount As String, ByVal debtorCommunication1 As String, ByVal debtorCommunication2 As String, ByRef creditorReference As String) As String
    '    Dim creditorName As String = CREDITOR_NAME_HES.PadRight(26, " ").Substring(0, 26)
    '    If Not (validateSequenceNumber(SequenceNumber) And validatedomiciliationNumber(domiciliationNumber) And validatenatureCode(natureCode) And validateamount(amount) And validateCreditorName(creditorName) And validatedebtorCommunication1(debtorCommunication1) And validatedebtorCommunication2(debtorCommunication2) And validatecreditorReference(creditorReference)) Then
    '        Throw New Exception("validation error in create Data Line")
    '    End If
    '    Return "1" & SequenceNumber.PadLeft(4, "0") & domiciliationNumber & natureCode & amount.ToString().PadLeft(12, "0") & creditorName & debtorCommunication1 & debtorCommunication2 & creditorReference & getBlanks(30)
    'End Function

    'Public Shared Function buildCommunication(ByRef domiciliation_payment_id As Integer) As String
    '    Dim intmod As Integer = domiciliation_payment_id Mod 97
    '    If intmod = 0 Then intmod = 97
    '    Dim strmod As String = CType(intmod, String)
    '    strmod = strmod.PadLeft(2, "0")
    '    Dim strpaymessage As String = domiciliation_payment_id & strmod
    '    strpaymessage = strpaymessage.PadLeft(11, "0")
    '    Return PAYMENT_DOMICILIATION_COMMUNICATION_TRAILER & strpaymessage
    'End Function


    'Public Function createDomiciliationPaymentForDVDAtHome(ByRef customers_id As String, ByRef customers_address As String, ByRef debiter_name As String, ByRef customers_name As String, ByRef amount As String, ByRef domiciliation_number As String, ByRef abo_stopped_with_dvdathome_id As Integer) As Integer
    '    Dim sql As String
    '    sql = "INSERT INTO domiciliation_payment ( domiciliation_payment_id,"
    '    sql = sql & " domiciliation_payment_date,"
    '    sql = sql & " abo_id,"
    '    sql = sql & " customers_id,"
    '    sql = sql & " customers_name,"
    '    sql = sql & " customers_address,"
    '    sql = sql & " amount,"
    '    sql = sql & " strdomiciliation_debiter_name,"
    '    sql = sql & " strdomiciliation_number,"
    '    sql = sql & " communication,"
    '    sql = sql & " first_payment,"
    '    sql = sql & " reconduction,"
    '    sql = sql & " payment_status,"
    '    sql = sql & " domiciliation_payment_isabel_date,"
    '    sql = sql & " domiciliation_unpaid_id,"
    '    sql = sql & " batch_immatriculation_number,"
    '    sql = sql & " last_modified,"
    '    sql = sql & " abo_stopped_with_dvdathome_id ) "
    '    sql = sql & " VALUES ("
    '    sql = sql & " null,"
    '    sql = sql & " now(),"
    '    sql = sql & " '0',"
    '    sql = sql & " " & customers_id & ","
    '    sql = sql & " '" & customers_name & "',"
    '    sql = sql & " '" & customers_address & "',"
    '    sql = sql & " " & amount.ToString.Replace(",", ".") & ","
    '    sql = sql & " '" & debiter_name & "',"
    '    sql = sql & " '" & domiciliation_number & "',"
    '    sql = sql & " '',"
    '    sql = sql & " '0',"
    '    sql = sql & " '0',"
    '    sql = sql & " '0',"
    '    sql = sql & " '0000-00-00 00:00:00',"
    '    sql = sql & " '0',"
    '    sql = sql & " NULL ,"
    '    sql = sql & " now(),"
    '    sql = sql & " NULL "
    '    sql = sql & " )"

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    sql = "select max(domiciliation_payment_id) as domiciliation_payment_id from domiciliation_payment"
    '    objDS.Tables("BatchTmpNewId").Clear()
    '     DvdPostData.clsConnection.FillDataSet(objDS.Tables("BatchTmpNewId"), sql)
    '    Dim domiciliation_payment_id As Integer = objDS.Tables("BatchTmpNewId").Rows(0)("domiciliation_payment_id")



    '    sql = "update domiciliation_payment set communication='" & buildCommunication(domiciliation_payment_id) & "' where domiciliation_payment_id=" & domiciliation_payment_id
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    Return domiciliation_payment_id

    'End Function

    'Public Shared Function buildCommunicationOfflineRequest(ByRef payment_offline_request_id As Integer) As String
    '    Dim comm As String = payment_offline_request_id.ToString
    '    comm = comm.PadLeft(9, "0")
    '    comm = PAYMENT_OFFLINE_REQUEST_COMMUNICATION_TRAILER & comm
    '    Dim commInt As Long = Long.Parse(comm)
    '    comm = comm & getMOD97OnTwoChars(commInt)
    '    Return comm
    'End Function

    'Public Shared Function getMOD97OnTwoChars(ByRef value As Long) As String
    '    Dim modulo As Integer = value Mod 97
    '    If modulo = 0 Then modulo = 97
    '    Dim stringModulo As String = CType(modulo, String)
    '    stringModulo = stringModulo.PadLeft(2, "0")
    '    Return stringModulo
    'End Function


    'Private Sub btnCreateBatch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim i As Integer
    '    Dim _row As DataRow

    '    If Not objDS.Tables.Contains("BatchTmp") Then
    '        objDS.Tables.Add("BatchTmp")
    '    End If
    '    If Not objDS.Tables.Contains("BatchTmpNewId") Then
    '        objDS.Tables.Add("BatchTmpNewId")
    '    End If

    '    RTBBatch.Text = ""
    '    Dim TotalAmount As Double = 0
    '    Dim totalPaymentDomNumbers As Long = 0
    '    'header
    '    RTBBatch.AppendText("0" & "0000" & Now().ToString("ddMMyy") & "300" & "02" & DateTime.Now.ToString("yyMMddHHmm") & "00478510502" & "00478510502" & "310191369467" & "5" & " " & Date.Now.ToString("ddMMyy") & getBlanks(60) & vbLf)

    '    For i = 0 To GridView1.RowCount - 1
    '        _row = GridView1.GetDataRow(i)

    '        Dim decprice As Double
    '        decprice = -1 * _row("Diff")
    '        TotalAmount += decprice
    '        'decprice = _row("Diff_Month")
    '        decprice = Math.Round(decprice, 2)

    '        Dim domiciliation_payment_id As Integer = createDomiciliationPaymentForDVDAtHome(_row("customers_id"), _row("entry_street_address"), _row("domiciliation_debiter_name"), _row("customers_firstname") & " " & _row("customers_lastname"), Replace(decprice, ",", ""), _row("domiciliation_number"), 1)

    '        '1 Identification de l'enregistrement : 1 (annexe 1.1).
    '        '4 Numéro de séquence : commence par 0001 et augmente d'une unité par opération.
    '        '12 Numéro de domiciliation.
    '        '1 Code nature : 0 = recouvrement; 1 = remboursement.
    '        '12 Montant de la facture (voir annexe 1.8).
    '        '26 Nom du créancier.
    '        '15 Communication au payeur, 1ère partie.
    '        '15 Communication au payeur, 2e partie.
    '        '12 Référence du créancier ou zéros Les deux derniers chiffres de cette référence forment le nombre contrôle des dix premiers chiffres.
    '        '30 Blancs.                                                                  
    '        RTBBatch.AppendText(createDataLine((i + 1).ToString().PadLeft(4, "0"), ("" & _row("domiciliation_number")).PadLeft(12, "0"), 0, Replace(decprice, ",", "").PadLeft(12, "0"), ("" & "").PadLeft(15, " "), ("" & "").PadLeft(15, " "), buildCommunicationOfflineRequest(domiciliation_payment_id)) & vbLf)


    '        'Insert a record in payment_error_recovery to trace 
    '        Dim _sql As String = ""
    '        _sql = "insert into payment_error_recovery  (customers_id, correct_amount, bad_amount, transaction_date, payment_type, payment_id) values (" & _row("customers_id") & ", " & _
    '            Replace(_row("abo_amount"), ",", ".") & ", " & Replace(_row("amount"), ",", ".") & ", now(), 1, " & domiciliation_payment_id & ")"
    '        DvdPostData.clsConnection.ExecuteNonQuery(_sql)


    '        totalPaymentDomNumbers += _row("domiciliation_number")
    '    Next

    '    ' footer 
    '    '1 Identification de l'enregistrement : 9 (annexe 1.1).
    '    '4 Nombre de recouvrements.
    '    '12 Montant total des recouvrements.
    '    '15 Total des numéros de domiciliation pour les recouvrements (si les 3 premiers chiffres sont des zéros, le contrôle se limite aux 12 derniers chiffres).
    '    '4 Nombre de remboursements.
    '    '12 Montant total des remboursements.
    '    '15 Total des numéros de domiciliation pour les remboursements (si les 3 premiers chiffres sont des zéros, le contrôle se limite aux 12 premiers chiffres).
    '    '65 Blancs.
    '    RTBBatch.AppendText("9" & i.ToString().PadLeft(4, "0") & TotalAmount.ToString().PadLeft(12, "0") & Replace(totalPaymentDomNumbers.ToString(), ",", "").PadLeft(15, "0") & ("0").ToString().PadLeft(4, "0") & ("0").ToString().PadLeft(12, "0") & ("0").ToString().PadLeft(15, "0") & getBlanks(65) & vbLf)
    '    'sSQL = "insert into ogone_batch (ogone_batch_date, ogone_batch_output) values (now(), '" & RTBBatch.Text & "')"

    'End Sub

    Private Sub btnReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReconduction.Click
        Dim cust As New PlushBuziness.ClsCustomers()

        AddHandler cust.initMapping_Event, AddressOf InitProgressBar
        AddHandler cust.stepMapping_event, AddressOf StepProgressBar
        AddHandler cust.ReInitProgressbar_event, AddressOf ReInitProgressbar

        Dim ok As Boolean
        ok = cust.ReconductionDomiciliation(PlushData.ClsCustomersData.Country.BELGIUM)
        If ok Then
            MsgBox("Reconduction OK")

        Else
            MsgBox("Error Reconduction", MsgBoxStyle.Critical)
        End If


    End Sub
    Private Sub ReInitProgressbar()
        ProgressBar1.EditValue = 0
        ProgressBar1.Refresh()

    End Sub

    Private Sub InitProgressBar(ByVal cpt As Integer)

        ProgressBar1.Properties.Step = 1
        ProgressBar1.Properties.PercentView = True
        ProgressBar1.Properties.Maximum = cpt
        ProgressBar1.Properties.Minimum = 0
        ProgressBar1.Show()

    End Sub
    Private Sub StepProgressBar(ByVal index As Integer)

        If index Mod 10 = 0 Then
            DoEvents()

        End If
        ProgressBar1.EditValue = index
        ProgressBar1.Refresh()


    End Sub

    Private Sub BtnActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActivation.Click
        Dim cust As New PlushBuziness.ClsCustomers()

        AddHandler cust.initMapping_Event, AddressOf InitProgressBar
        AddHandler cust.stepMapping_event, AddressOf StepProgressBar
        AddHandler cust.ReInitProgressbar_event, AddressOf ReInitProgressbar

        If cust.ActivationDom70Domiciliation() Then
            MsgBox("Activation OK", MsgBoxStyle.Information)
        Else
            MsgBox("Error Activation", MsgBoxStyle.Critical)

        End If


    End Sub


    Private Function importCoda(ByVal file As String) As Boolean
        Dim ok As Boolean
        If file.Length = 0 Then
            Return False
        Else
            Dim BatchDomiciliation As PlushBuziness.ClsBatchDomiciliation = New PlushBuziness.ClsBatchDomiciliation()
            ' AddHandler BatchDomiciliation.initMapping_Event, AddressOf InitProgressBar
            ' AddHandler BatchDomiciliation.stepMapping_event, AddressOf StepProgressBar

            ok = BatchDomiciliation.ImportCoda(file)


            'ReInitProgressbar()
            Return ok
        End If

    End Function
    Private Sub BtnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImport.Click
        Dim ok As Boolean
        Dim msg As String = ""
        InitProgressBar(LBFiles.Items.Count)
        Dim index As Integer = 0
        For Each file As String In LBFiles.Items

            ok = importCoda(file)

            If Not ok Then
                msg += "File " & file & " already import !!!" & vbNewLine
            Else
                msg += "Import " & file & "Finish" & vbNewLine
            End If
            index += 1
            StepProgressBar(index)
        Next
        '  DVDPostBuziness.ClsBankTransfer.matching()
        PlushBuziness.clsOffLinePayments.matchingOffline()
        If msg IsNot String.Empty Then
            MsgBox(msg)
            LBFiles.Items.Clear()
        End If
    End Sub
    Private Sub LBFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBFiles.Click
        ' OFDFileDom.Filter = "csv|*.csv|text|*.txt"
        If OFDFileDom.ShowDialog() = Windows.Forms.DialogResult.OK Then

            LBFiles.Items.Clear()
            For Each file As String In OFDFileDom.FileNames
                LBFiles.Items.Add(file)
            Next

        End If
    End Sub

    Private Sub BtnPrintActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintActivation.Click

        Dim sql As String

        sql = PlushData.ClsBatchDomiciliation.PrintActivation _
                        (PlushData.ClsCustomersData.Payment_Method.DOMICILIATION, _
                        PlushData.ClsCustomersData.Country.BELGIUM, _
                        PlushData.ClsCustomersData.DomiciliationStatus.SENDLETTER, _
                        PlushData.ClsCustomersData.StepRegistrationStatus.CREATE_DOMICILIATION & "," & PlushData.ClsCustomersData.StepRegistrationStatus.OK)
        Dim dt As DataTable
        ' Dim dv As DataView

        dt = PlushData.clsConnection.FillDataSet(sql)

        'Dim _rpt As rptMSActivationDomiciliation

        'For lang As Integer = 1 To 3
        '    dv = New DataView(dt, "languages_id = " & lang, "customers_id", DataViewRowState.CurrentRows)
        '    If dv.Count > 0 Then
        '        _rpt = New rptMSActivationDomiciliation
        '        _rpt.DataSource = dv.ToTable()
        '        _rpt.ShowPreview()

        '    End If
        'Next
        '' _rpt.objDS = dt.DataSet
        '' _rpt.DataMember = ""



    End Sub

    Private Sub btnChangeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeStatus.Click
        Dim sql As String
        Dim cpt As Integer
        sql = PlushData.ClsBatchDomiciliation.UpdateActivation( _
        PlushData.ClsCustomersData.Payment_Method.DOMICILIATION, _
        PlushData.ClsCustomersData.Country.BELGIUM, _
        PlushData.ClsCustomersData.DomiciliationStatus.SENDLETTER, _
        PlushData.ClsCustomersData.StepRegistrationStatus.CREATE_DOMICILIATION, _
        PlushData.ClsCustomersData.DomiciliationStatus.SENT)

        cpt = PlushData.clsConnection.ExecuteNonQuery(sql)

        MsgBox("Update ok " & cpt.ToString() & " customers ")

    End Sub


    Private Sub btnMatchDom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatchDom.Click

        ' DVDPostBuziness.ClsBatchDomiciliation.GetMatchingDomiciliation()

        Grid1.DataSource = PlushBuziness.ClsBatchDomiciliation.GetMatchingDomiciliation()
        TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub btnMatching_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatching.Click

        PlushBuziness.clsOffLinePayments.matchingOffline()
    End Sub
End Class
