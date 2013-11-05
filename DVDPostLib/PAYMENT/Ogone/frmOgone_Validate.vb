Imports System.Windows.Forms.Application
Imports PlushData

Public Class frmOgone_Validate
    Inherits BizzLib.frmGeneral_Browse
    ' bo reconduction sample Partial Class domiciliation_reconduction_all


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
    Friend WithEvents ProgressBar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBatchReject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnMatching As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtSourceOgone As System.Windows.Forms.TextBox
    Friend WithEvents OFDFileOgone As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnReconductionBE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnChangeCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReconductionNL As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOgone_Validate))
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BtnChangeCard = New DevExpress.XtraEditors.SimpleButton
        Me.BtnMatching = New DevExpress.XtraEditors.SimpleButton
        Me.TxtSourceOgone = New System.Windows.Forms.TextBox
        Me.btnReconductionBE = New DevExpress.XtraEditors.SimpleButton
        Me.btnReconductionNL = New DevExpress.XtraEditors.SimpleButton
        Me.btnBatchReject = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.OFDFileOgone = New System.Windows.Forms.OpenFileDialog
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
        Me.TabParameters.Controls.Add(Me.GroupControl1)
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
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.HelpProvider1.SetShowHelp(Me.ProgressBar1, CType(resources.GetObject("ProgressBar1.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.BtnChangeCard)
        Me.GroupControl1.Controls.Add(Me.BtnMatching)
        Me.GroupControl1.Controls.Add(Me.TxtSourceOgone)
        Me.GroupControl1.Controls.Add(Me.btnReconductionBE)
        Me.GroupControl1.Controls.Add(Me.btnReconductionNL)
        Me.GroupControl1.Controls.Add(Me.ProgressBar1)
        Me.GroupControl1.Controls.Add(Me.btnBatchReject)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'BtnChangeCard
        '
        resources.ApplyResources(Me.BtnChangeCard, "BtnChangeCard")
        Me.BtnChangeCard.Name = "BtnChangeCard"
        Me.HelpProvider1.SetShowHelp(Me.BtnChangeCard, CType(resources.GetObject("BtnChangeCard.ShowHelp"), Boolean))
        '
        'BtnMatching
        '
        resources.ApplyResources(Me.BtnMatching, "BtnMatching")
        Me.BtnMatching.Name = "BtnMatching"
        Me.HelpProvider1.SetShowHelp(Me.BtnMatching, CType(resources.GetObject("BtnMatching.ShowHelp"), Boolean))
        '
        'TxtSourceOgone
        '
        resources.ApplyResources(Me.TxtSourceOgone, "TxtSourceOgone")
        Me.TxtSourceOgone.Name = "TxtSourceOgone"
        Me.TxtSourceOgone.ReadOnly = True
        '
        'btnReconductionBE
        '
        resources.ApplyResources(Me.btnReconductionBE, "btnReconductionBE")
        Me.btnReconductionBE.Name = "btnReconductionBE"
        Me.HelpProvider1.SetShowHelp(Me.btnReconductionBE, CType(resources.GetObject("btnReconductionBE.ShowHelp"), Boolean))
        '
        'btnReconductionNL
        '
        resources.ApplyResources(Me.btnReconductionNL, "btnReconductionNL")
        Me.btnReconductionNL.Name = "btnReconductionNL"
        Me.HelpProvider1.SetShowHelp(Me.btnReconductionNL, CType(resources.GetObject("btnReconductionNL.ShowHelp"), Boolean))
        '
        'btnBatchReject
        '
        resources.ApplyResources(Me.btnBatchReject, "btnBatchReject")
        Me.btnBatchReject.Name = "btnBatchReject"
        Me.HelpProvider1.SetShowHelp(Me.btnBatchReject, CType(resources.GetObject("btnBatchReject.ShowHelp"), Boolean))
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
        'OFDFileOgone
        '
        Me.OFDFileOgone.FileName = "OpenFileDialog1"
        '
        'frmOgone_Validate
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmOgone_Validate"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
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
    Dim _dtBatch As DataTable
    ' Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip


        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        'objDS.Tables.Add("AboInfo")
        MyBase.TableName = "ogone_payment_Validate"
        'MyBase.IDField = "ogone_payment_id"
        'MyBase.NameField = "ogone_payment_id"
        'MyBase.MaintenanceMenuID = -1
        'MyBase.WhereClause = ""
        MyBase.AutoLoadData = False
        MyBase.StartUp()
        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        ' txtToDate.Refresh()

        'MsgBox(DvdPostData.clsConnection.typeEnv)
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
    'Private Sub txtLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '   _Limit = "limit 0, " & txtLimit.Text
    'End Sub
    'Private Sub btnOK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOK.ItemClick
    '    LoadDataSetRejetOgone()
    '    Grid1.DataSource = _dtBatch.DefaultView
    '    TabControl1.SelectedTabPage = TabResult
    'End Sub


    '''' <summary>
    ''''  list of customers no paid with status payment_offline_request = CREATED
    '''' </summary>
    '''' <remarks></remarks>
    'Public Function LoadDataSetRejetOgone() As DateTime

    '    Dim sql As String
    '    'If (txtFromDate.EditValue Is Nothing Or txtToDate.EditValue Is Nothing) Then
    '    '    MsgBox("Please Choose date ", MsgBoxStyle.Information)
    '    'Else
    '    _dtBatch = New DataTable


    '    Dim x As DateTime
    '    Dim day As Integer = (DVDPostBuziness.clsOffLinePayments.DAYS_CALL - 1) * -1
    '    x = DateTime.Now.AddDays(Day)
    '    'x = DateTime.Now
    '    sql = DvdPostData.ClsBatchOgone.GetListCustomers(x, DvdPostData.PaymentOfflineData.StepPayment.RECOVERY, PaymentOfflineData.StepPayment.CREATE_RECOVERY)
    '    _dtBatch = DvdPostData.clsConnection.FillDataSet(sql)

    '    'End If


    '    Return x
    'End Function
    ''Public Overrides Sub LoadDataSet()
    ''    Dim _SQLTxt As String
    ''    Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
    ''    Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
    ''    'Clear Table
    ''    objDS.Tables(TableName).Clear()
    ''    _SQLTxt = "SELECT o.*, c.activation_discount_code_id as current_discount_code_id FROM ogone_payment o " & _
    ''        " LEFT JOIN customers c on c.customers_id = o.customers_id " & _
    ''        " where date_added >= '" & _DateFromTxt & " 00:00:00' and date_added <= '" & _DateToTxt & " 23:59:59'"

    ''     DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)

    ''    'Load extra Info
    ''    LoadPreviousMonthAmount()
    ''    LoadAboInfo()

    ''    Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
    ''    Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
    ''    Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
    ''    TabControl1.SelectedTabPage = TabResult
    ''End Sub
    ''Private Sub LoadAboInfo()
    ''    Dim _SQLTxt As String
    ''    Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
    ''    Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue)
    ''    Dim _row As DataRow
    ''    Dim _Curr_CustID As Integer = -1


    ''    _SQLTxt = "SELECT p.products_model as products_model, a.abo_id as abo_id, customerid,a.code_id as Code_Id, a.Action as Abo_Action, aa.Name as Abo_Action_Name," & _
    ''              " a.`date` as Abo_Date, p.products_title as Abo_Type, p.products_price as Abo_Amount," & _
    ''              " ac.validity_type as validity_type, ac.validity_value as validity_value, dta.discount_explained as activation_explained," & _
    ''              " dc.discount_type as discount_type, dc.discount_value as discount_value, dtd.discount_explained as discount_explained" & _
    ''              " FROM abo a" & _
    ''              " LEFT JOIN abo_action aa on a.`action` = aa.id" & _
    ''              " LEFT JOIN Products p on a.product_id = p.products_id" & _
    ''              " LEFT JOIN discount_code dc on dc.discount_code_id = a.code_id" & _
    ''              " LEFT JOIN activation_code ac on ac.activation_id = a.code_id" & _
    ''              " LEFT JOIN discount_type dta on ac.validity_type = dta.discount_type" & _
    ''              " LEFT JOIN discount_type dtd on dc.discount_type = dtd.discount_type" & _
    ''              " where a.`Date` >= '" & _DateFromTxt & " 00:00:00' and a.`Date` <= '" & _DateToTxt & " 23:59:59';"
    ''    '                  " AND a.`Action` in (6,7,8,9)" & _
    ''    lbl1.Text = "Loading ABO Info"
    ''    ProgressBar1.EditValue = 0
    ''     DvdPostData.clsConnection.FillDataSet(objDS.Tables("AboInfo"), _SQLTxt)
    ''    'objDS.Tables("AboInfo").PrimaryKey = New DataColumn() {objDS.Tables("AboInfo").Columns("customerid")}
    ''    Dim _ViewAboInfo As New DataView(objDS.Tables("AboInfo"), "", "abo_id", DataViewRowState.CurrentRows)
    ''    Dim _ViewAboInfoUpDow As New DataView(objDS.Tables("AboInfo"), "", "customerid", DataViewRowState.CurrentRows)
    ''    For Each _row In objDS.Tables(TableName).Rows
    ''        ProgressBar1.EditValue += 1
    ''        ProgressBar1.Refresh()
    ''        If Not IsDBNull(_row("customers_id")) Then
    ''            _Curr_CustID = _row("customers_id")
    ''            Dim _curr_row_index As Integer = _ViewAboInfo.Find(New Object() {_row("abo_id")})
    ''            If _curr_row_index <> -1 Then
    ''                Dim _Curr_Row As DataRowView = _ViewAboInfo(_curr_row_index)
    ''                Dim _RowUpDown As DataRowView
    ''                For Each _RowUpDown In _ViewAboInfoUpDow.FindRows(_Curr_CustID)
    ''                    If _RowUpDown("Abo_Action") = 2 Or _RowUpDown("Abo_Action") = 3 Then
    ''                        _row("UpgradeDownGrade") = _RowUpDown("Abo_Action")
    ''                        Exit For
    ''                    End If
    ''                Next
    ''                'objDS.Tables("AboInfo").Select("customerid = " & _Curr_CustID) 'objDS.Tables("AboInfo").Rows(0)
    ''                _row("Abo_Type") = _Curr_Row("Abo_Type")
    ''                _row("Abo_Amount") = _Curr_Row("Abo_Amount")
    ''                _row("Abo_Date") = _Curr_Row("Abo_Date")
    ''                _row("Abo_Action_Name") = _Curr_Row("Abo_Action_Name")
    ''                _row("products_model") = _Curr_Row("products_model")
    ''                Select Case _Curr_Row("Abo_Action").ToString
    ''                    Case "8"
    ''                        _row("Discount_Type") = _Curr_Row("validity_type")
    ''                        _row("Discount_Value") = _Curr_Row("validity_value")
    ''                        _row("Discount_Explained") = _Curr_Row("validity_explained")

    ''                    Case Else
    ''                        _row("Discount_Type") = _Curr_Row("discount_type")
    ''                        _row("Discount_Value") = _Curr_Row("discount_value")
    ''                        _row("Discount_Explained") = _Curr_Row("discount_explained")
    ''                End Select
    ''                If Not IsDBNull(_row("Discount_Type")) Then
    ''                    Select Case _row("Discount_Type").ToString
    ''                        Case "1"
    ''                            _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount") * (1 - _Curr_Row("discount_value") / 100)
    ''                        Case "2"
    ''                            _row("Abo_Amount_Discounted") = _Curr_Row("discount_value")
    ''                        Case "3"
    ''                            _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount") - _Curr_Row("discount_value")
    ''                    End Select
    ''                Else
    ''                    _row("Abo_Amount_Discounted") = _Curr_Row("Abo_Amount")
    ''                End If
    ''                If Not IsDBNull(_Curr_Row("Abo_Amount")) Then
    ''                    _row("Diff") = _row("amount") - _Curr_Row("Abo_Amount") '_row("Abo_Amount_Discounted")
    ''                End If
    ''            End If
    ''        End If
    ''    Next
    ''End Sub
    ''Private Sub LoadPreviousMonthAmount()
    ''    Dim _SQLTxt As String
    ''    Dim _Date1 As Date = CDate(txtFromDate.EditValue).AddMonths(-1)
    ''    Dim _Date2 As Date = CDate(txtToDate.EditValue).AddMonths(-1)
    ''    Dim _DateFromTxt As String = Year(_Date1) & "-" & Month(_Date1) & "-" & DateAndTime.Day(_Date1)
    ''    Dim _DateToTxt As String = Year(_Date2) & "-" & Month(_Date2) & "-" & DateAndTime.Day(_Date2)
    ''    Dim _row As DataRow
    ''    Dim _i As Integer
    ''    Dim _PrevRow As DataRowView
    ''    Dim _DS As New dsAboRent
    ''    _DS.Tables(TableName).Clear()
    ''    _SQLTxt = "SELECT * FROM ogone_payment " & _
    ''        " where date_added >= '" & _DateFromTxt & " 00:00:00' and date_added <= '" & _DateToTxt & " 23:59:59'"
    ''     DvdPostData.clsConnection.FillDataSet(_DS.Tables(TableName), _SQLTxt)
    ''    Dim _View As New DataView(_DS.Tables(TableName), "", "customers_id", DataViewRowState.CurrentRows)
    ''    ProgressBar1.EditValue = 0
    ''    For Each _row In objDS.Tables(TableName).Rows
    ''        ProgressBar1.EditValue += 1
    ''        ProgressBar1.Refresh()
    ''        If Not IsDBNull(_row("customers_id")) Then
    ''            _i = _View.Find(_row("customers_id"))
    ''            If _i <> -1 Then
    ''                _PrevRow = _View(_i)
    ''                If Not IsNothing(_PrevRow) Then
    ''                    _row("previous_month_amount") = _PrevRow("amount")
    ''                    _row("Diff_Month") = _row("previous_month_amount") - _row("amount")
    ''                End If
    ''            End If
    ''        End If
    ''    Next
    ''End Sub

    ''Private Sub previewbatch(ByVal clsBatchOgone As ClsBatchOgone, ByVal idcountry As DvdPostData.ClsCustomersData.Country)

    ''    Dim x As DateTime
    ''    x = LoadDataSetRejetOgone()
    ''    If Not _dtBatch Is Nothing And _dtBatch.Rows.Count > 0 Then
    ''        RTBBatch.AppendText()
    ''    Else
    ''        MsgBox("nothing customers for reject " & PlushTools.ClsDate.formatDate(x))
    ''    End If
    ''End Sub

    Private Sub btnBatchReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchReject.Click

        Dim cust As New PlushBuziness.ClsCustomers()

        AddHandler cust.initMapping_Event, AddressOf InitProgressBar
        AddHandler cust.stepMapping_event, AddressOf StepProgressBar
        AddHandler cust.ReInitProgressbar_event, AddressOf ReInitProgressbar

        Dim ok As Boolean
        ok = cust.RejetFileOgone()
        If ok Then
            MsgBox("Reject Ogone OK")
        Else
            MsgBox("Error Reject Ogone BE", MsgBoxStyle.Critical)
        End If

        ReInitProgressbar()



        'Dim clsBatchOgone As DVDPostBuziness.ClsBatchOgone = New DVDPostBuziness.ClsBatchOgone()
        'Dim batch As String
        'AddHandler clsBatchOgone.initMapping_Event, AddressOf InitProgressBar
        'AddHandler clsBatchOgone.stepMapping_event, AddressOf StepProgressBar
        'LoadDataSetRejetOgone()
        ''previewbatch(clsBatchOgone, dvdpostdata.ClsCustomersData.Country.BELGIQUE)
        'batch = clsBatchOgone.CreateBatchFile(_dtBatch, dvdpostdata.ClsCustomersData.Country.BELGIQUE)
        ''  If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        'If Not batch Is String.Empty Then
        '    Dim path As String
        '    path = clsBatchOgone.CreatePathFile(clsBatchOgone.TypeBatch.REJET_OGONE, dvdpostdata.ClsCustomersData.Country.BELGIQUE)
        '    PlushTools.clsFile.WriteFile(path, batch)
        '    DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.ClsBatchOgone.OgonePaymentBatch(batch))
        '    DVDPostBuziness.ClsBatchOgone.UpdateBatchId(_dtBatch)
        '    ReInitProgressbar()
        'End If
    End Sub

    'Private Sub btnCreateBatch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviewBatch.Click
    '    Dim i As Integer
    '    Dim _row As DataRow
    '    Dim sSQL As String = "SELECT max(ogone_batch_id) as obid FROM ogone_batch"
    '    objDS.Tables.Add("BatchTmp")
    '    objDS.Tables.Add("BatchTmpNewId")
    '     DvdPostData.clsConnection.FillDataSet(objDS.Tables("BatchTmp"), sSQL)
    '    Dim intogonebatchid As Integer = objDS.Tables("BatchTmp").Rows(0)("obid") + 1
    '    RTBBatch.Text = ""

    '    RTBBatch.AppendText("OHL" & ";" & "dvdpost" & ";" & "mulan2" & ";" & ";" & ";" & vbLf)
    '    RTBBatch.AppendText("OHF" & ";" & "batchogone" & intogonebatchid & ";" & "ATR" & ";" & ";" & GridView1.RowCount & ";" & vbLf)
    '    For i = 0 To GridView1.RowCount - 1
    '        _row = GridView1.GetDataRow(i)

    '        Dim decprice As Double
    '        decprice = -1 * _row("Diff")
    '        'decprice = _row("Diff_Month")
    '        decprice = Math.Round(decprice, 2)
    '        RTBBatch.AppendText(Replace(decprice, ",", "") & ";")    'amount
    '        RTBBatch.AppendText("EUR" & ";") 'currency
    '        RTBBatch.AppendText(";") 'card type
    '        RTBBatch.AppendText(";") 'card number
    '        RTBBatch.AppendText(";") 'exp date
    '        RTBBatch.AppendText("b" & intogonebatchid & "c" & _row("customers_id") & ";") 'ref 
    '        RTBBatch.AppendText("dvdpost subscription " & _row("products_model") & " from " & DateString() & ";") 'desc
    '        RTBBatch.AppendText(";") 'client name
    '        RTBBatch.AppendText(";") 'payment id
    '        RTBBatch.AppendText("SAL" & ";") 'operation code
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(";") '
    '        RTBBatch.AppendText(_row("customers_id") & ";") 'clientalias
    '        RTBBatch.AppendText(vbLf) 'ControlChars.CrLf

    '        'Insert a record in payment_error_recovery to trace 
    '        Dim _sql As String = ""
    '        _sql = "insert into payment_error_recovery  (customers_id, correct_amount, bad_amount, transaction_date, payment_type, payment_id) values (" & _row("customers_id") & ", " & _
    '            Replace(_row("abo_amount"), ",", ".") & ", " & Replace(_row("amount"), ",", ".") & ", now(), 0, " & _row("ogone_payment_id") & ")"
    '        DvdPostData.clsConnection.ExecuteNonQuery(_sql)

    '        Dim ogone_payment_id As Integer = createNewOgonePayment(_row("abo_id"), _row("customers_id"), decprice.ToString, intogonebatchid)

    '    Next

    '    'To Do by RCO
    '    RTBBatch.AppendText("OTF" & ";" & vbCrLf)
    '    sSQL = "insert into ogone_batch (ogone_batch_date, ogone_batch_output) values (now(), '" & RTBBatch.Text & "')"
    '    DvdPostData.clsConnection.ExecuteNonQuery(sSQL)

    'End Sub
    'Public Function createNewOgonePayment(ByRef abo_id As Integer, ByRef customers_id As Integer, ByRef amount As String, ByRef ogone_batch_id As Integer) As Integer
    '    Dim sql As String

    '    sql = "insert into ogone_payment "
    '    sql = sql & " (ogone_payment_id "
    '    sql = sql & ", date_added "
    '    sql = sql & ", abo_id "
    '    sql = sql & ", customers_id "
    '    sql = sql & ", amount "
    '    sql = sql & ", ogone_payment_status "
    '    sql = sql & ", ogone_batch_id "
    '    sql = sql & ", last_modified) "
    '    sql = sql & " values "
    '    sql = sql & " (null "
    '    sql = sql & ", now() "
    '    sql = sql & ", " & abo_id & " "
    '    sql = sql & ", " & customers_id & " "
    '    sql = sql & ", (" & amount.Replace(",", ".") & "/100) "
    '    sql = sql & ",0 "
    '    sql = sql & ", " & ogone_batch_id & " "
    '    sql = sql & ", now()) "

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    sql = "select max(ogone_payment_id) as ogone_payment_id from ogone_payment"
    '    objDS.Tables("BatchTmpNewId").Clear()
    '     DvdPostData.clsConnection.FillDataSet(objDS.Tables("BatchTmpNewId"), sql)
    '    Dim ogone_payment_id As Integer = objDS.Tables("BatchTmpNewId").Rows(0)("ogone_payment_id")

    '    updateOgonePaymentStatus(ogone_payment_id, 1)

    '    Return ogone_payment_id

    'End Function


    'Public Sub updateOgonePaymentStatus(ByRef ogone_payment_id As Integer, ByRef new_status As Integer)
    '    Dim sql As String

    '    sql = "insert into ogone_payment_status_history "
    '    sql = sql & " (ogone_payment_status_history_id,ogone_payment_id,new_status,old_status,date_added)"
    '    sql = sql & " select null, ogone_payment_id, " & new_status & ", ogone_payment_status, now()"
    '    sql = sql & " from ogone_payment dp "
    '    sql = sql & " where ogone_payment_id=" & ogone_payment_id

    '    Dim rows As Integer = DvdPostData.clsConnection.ExecuteNonQuery(sql)
    '    If rows <> 1 Then
    '        Throw New Exception("boum ogone_payment_id=" & ogone_payment_id & " to change to " & new_status & ": " & sql)
    '    End If

    '    sql = "update ogone_payment set "
    '    sql = sql & " ogone_payment_status=" & new_status & ", "
    '    sql = sql & " last_modified=now() "
    '    sql = sql & " where ogone_payment_id=" & ogone_payment_id

    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)

    'End Sub


    Private Sub TxtSourceOgone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSourceOgone.Click

        OFDFileOgone.Filter = "csv|*.csv|text|*.txt"
        OFDFileOgone.ShowDialog()
        TxtSourceOgone.Text = OFDFileOgone.FileName

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
    Private Sub BtnMatching_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatching.Click
        Dim ok As Boolean
        If TxtSourceOgone.Text.Length = 0 Then
            MsgBox("Choose a file ogone please ...", MsgBoxStyle.Information)
        Else
            Dim clsBatchOgone As PlushBuziness.ClsBatchOgone = New PlushBuziness.ClsBatchOgone()
            AddHandler clsBatchOgone.initMapping_Event, AddressOf InitProgressBar
            AddHandler clsBatchOgone.stepMapping_event, AddressOf StepProgressBar

            ok = clsBatchOgone.MappingOgoneFile(TxtSourceOgone.Text)

            If ok Then
                MsgBox("Matching Finish")
            Else
                MsgBox("Matching Error", MsgBoxStyle.Critical)
            End If
            ReInitProgressbar()

        End If

    End Sub

    Private Sub btnReconductionBE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReconductionBE.Click
        Dim cust As New PlushBuziness.ClsCustomers()

        AddHandler cust.initMapping_Event, AddressOf InitProgressBar
        AddHandler cust.stepMapping_event, AddressOf StepProgressBar
        AddHandler cust.ReInitProgressbar_event, AddressOf ReInitProgressbar

        Dim ok As Boolean
        ok = cust.ReconductionOgone(PlushData.ClsCustomersData.Country.BELGIUM)
        If ok Then
            MsgBox("Reconduction BE OK")
        Else
            MsgBox("Error Reconduction BE", MsgBoxStyle.Critical)
        End If

        ReInitProgressbar()



    End Sub

    Private Sub btnReconductionNL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReconductionNL.Click
        Dim cust As New PlushBuziness.ClsCustomers()

        AddHandler cust.initMapping_Event, AddressOf InitProgressBar
        AddHandler cust.stepMapping_event, AddressOf StepProgressBar
        AddHandler cust.ReInitProgressbar_event, AddressOf ReInitProgressbar

        Dim ok As Boolean
        ok = cust.ReconductionOgone(PlushData.ClsCustomersData.Country.NEDERLANDS)
        If ok Then
            MsgBox("Reconduction OK")
        Else
            MsgBox("Error Reconduction", MsgBoxStyle.Critical)
        End If

        ReInitProgressbar()

    End Sub


    Private Sub BtnChangeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangeCard.Click
        Dim clscust As New PlushBuziness.ClsCustomers()
        clscust.ChangeCard_customers(PlushData.ClsCustomersData.Country.BELGIUM)
        clscust.ChangeCard_customers(PlushData.ClsCustomersData.Country.NEDERLANDS)
    End Sub
End Class
