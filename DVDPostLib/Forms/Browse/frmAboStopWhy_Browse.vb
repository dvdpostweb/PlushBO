
Public Class frmAboStopWhy_Browse
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
    Friend WithEvents chkPreviousAvtion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnExportXls As System.Windows.Forms.Button
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboStopWhy_Browse))
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLimit = New System.Windows.Forms.TextBox
        Me.ProgressBar1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkPreviousAvtion = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.lbl1 = New System.Windows.Forms.Label
        Me.btnExportXls = New System.Windows.Forms.Button
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
        CType(Me.chkPreviousAvtion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.btnExportXls)
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
        Me.GroupControl1.Controls.Add(Me.chkPreviousAvtion)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtToDate)
        Me.GroupControl1.Controls.Add(Me.txtFromDate)
        Me.GroupControl1.Name = "GroupControl1"
        Me.HelpProvider1.SetShowHelp(Me.GroupControl1, CType(resources.GetObject("GroupControl1.ShowHelp"), Boolean))
        '
        'chkPreviousAvtion
        '
        resources.ApplyResources(Me.chkPreviousAvtion, "chkPreviousAvtion")
        Me.chkPreviousAvtion.Name = "chkPreviousAvtion"
        Me.chkPreviousAvtion.Properties.Caption = resources.GetString("chkPreviousAvtion.Properties.Caption")
        Me.chkPreviousAvtion.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkPreviousAvtion, CType(resources.GetObject("chkPreviousAvtion.ShowHelp"), Boolean))
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
        'btnExportXls
        '
        resources.ApplyResources(Me.btnExportXls, "btnExportXls")
        Me.btnExportXls.Name = "btnExportXls"
        Me.btnExportXls.UseVisualStyleBackColor = True
        '
        'frmAboStopWhy_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "frmAboStopWhy_Browse"
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
        CType(Me.chkPreviousAvtion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim _Limit As String = " limit 0, 100 "

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New dsAboRent
        TabParameters.PageVisible = True
        CanNew = False
        CanEdit = False
        CanDelete = False
        CanSave = False
        MyBase.TableName = "abo_stop_why_view1"
        MyBase.IDField = "abo_stop_why_id"
        MyBase.NameField = "abo_stop_why_id"
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

    Public Overrides Sub LoadDataSet()
        Dim _SQLTxt As String
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue)
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"
        'Clear Table
        objDS.Tables(TableName).Clear()
        '_SQLTxt = " SELECT abo_stop_why_id, customers_id, date as Stop_Date, 0 as ReasonNbr, " & _
        '    " whystopother AS ReasonTxt FROM abo_stop_why a " & _
        '    " where a.date >= '" & _DateFromTxt & "' and a.date <= '" & _DateToTxt & "' and whystopother <> '' "
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        'Dim _i As Integer
        'For _i = 1 To 28
        '    _SQLTxt = " SELECT abo_stop_why_id, customers_id, date as Stop_Date, " & _i.ToString & " as ReasonNbr, " & _
        '        " aex.explained AS ReasonTxt FROM abo_stop_why a " & _
        '        " left join abo_stop_why_explained aex on aex.whystop = 'whystop" & _i.ToString & "' " & _
        '        " where a.date >= '" & _DateFromTxt & "' and a.date <= '" & _DateToTxt & "' and whystop" & _i.ToString & " = 1 "
        '     DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        'Next


        '_SQLTxt = "select cs.id  , cs.customers_id , cs.date_stop  , cr.reason , cs.comment , cs.comment_users,cs.prevent_users " & _
        '          "from customers_abo_stop cs left join customers_abo_stop_reason cr on cr.id = cs.reason_id" & _
        '          " where cs.date_stop >= '" & _DateFromTxt & "' and cs.date_stop <= '" & _DateToTxt & " ' "
        DvdPostData.clsConnection.FillDataSet(objDS.Tables(TableName), DvdPostData.clsAboStopWhy.getAboStop(_DateFromTxt, _DateToTxt))

        Dim _FilterTxt As String = BKFilter.FilterGenerateSQL(CurrentFilterID)
        Dim _View As New DataView(objDS.Tables(TableName), _FilterTxt, "", DataViewRowState.CurrentRows)
        If chkPreviousAvtion.Checked = True Then
            LoadPreviousAction()
        End If
        Grid1.DataSource = _View 'objDS.Tables(TableName).DefaultView
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Public Sub LoadPreviousAction()
        Dim _row As DataRow
        Dim _Curr_CustID As Integer = -1
        Dim _SQLTxt As String
        Dim _DS As New DataSet
        Dim _previous_action_id As Integer
        Dim _previous_action_name As String
        Dim _previous_action_activation_id As Integer
        Dim _previous_action_activation_group_id As Integer
        Dim _previous_action_activation_group_name As String
        Dim _previous_action_activation_type As String
        Dim _previous_action_date As DateTime

        _DS.Tables.Add("abo")
        If chkPreviousAvtion.Checked = True Then
            lbl1.Text = "Loading Previous ABO Action"
            lbl1.Refresh()
            ProgressBar1.Properties.Minimum = 1
            ProgressBar1.Properties.Maximum = objDS.Tables(TableName).Rows.Count
            ProgressBar1.EditValue = 1
            For Each _row In objDS.Tables(TableName).Rows
                ProgressBar1.EditValue += 1
                ProgressBar1.Refresh()
                If Not IsDBNull(_row("customers_id")) Then
                    'If _Curr_CustID <> _row("customers_id") Then
                    '_Curr_CustID = _row("customers_id")
                    _DS.Tables("abo").Clear()
                    '_SQLTxt = "SELECT abo.`Date` as abo_date, abo.`action` as action_id , a.name as action_name, " & _
                    '     " ac.activation_id, ac.activation_group, ag.activation_group_name, " & _
                    '     " dc.discount_code_id, dc.discount_code " & _
                    '     " FROM abo " & _
                    '     " LEFT JOIN abo_action a on a.id = abo.action" & _
                    '     " LEFT JOIN activation_code ac on ac.activation_id = abo.code_id and abo.action = 8 " & _
                    '     " LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group " & _
                    '     " LEFT JOIN discount_code dc on dc.discount_code_id = abo.code_id and abo.action = 6 " & _
                    '     " where customerid = " & _row("customers_id") & _
                    '     "  and `Date` < '" & Year(_row("date_stop")) & "-" & Month(_row("date_stop")) & "-" & Day(_row("date_stop")) & _
                    '     " " & Hour(_row("date_stop")) & ":" & Minute(_row("date_stop")) & ":" & Second(_row("date_stop")) & "' " & _
                    '     " AND abo.`Action` in (1,5,6,8,9) " & _
                    '     " order by date desc limit 1 "
                    '_SQLTxt = "SELECT abo.`Date` as abo_date, abo.`action` as action_id , a.name as action_name, " & _
                    '" ac.activation_id, ac.activation_group, ag.activation_group_name, " & _
                    '" LEFT JOIN abo_action a on a.id = abo.action " & _
                    '" LEFT JOIN activation_code ac on ac.activation_id = a.code_id " & _
                    '" LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group" & _
                    '" LEFT JOIN discount_code dc on dc.discount_code_id = a.code_id" & _
                    '" where abo.customerid = " & _row("customers_id") & " and abo.abo_id <> (select a.abo_id from  abo a where  customerid = " & _row("customers_id") & " order by a.date desc limit 1 ) order by a.date desc limit 1"
                    '                    _SQLTxt = "SELECT abo.`Date` as abo_date, abo.`action` as action_id , a.name as action_name, " & _
                    '"ac.activation_id, ac.activation_group, ag.activation_group_name ,dc.discount_code_id, dc.discount_code from abo " & _
                    '"LEFT JOIN abo_action a on a.id = abo.action " & _
                    '"LEFT JOIN activation_code ac on ac.activation_id = abo.code_id " & _
                    '"LEFT JOIN activation_group ag on ag.activation_group_id = ac.activation_group " & _
                    '"LEFT JOIN discount_code dc on dc.discount_code_id = abo.code_id " & _
                    '"where abo.customerid = " & _row("customers_id") & " and abo_id <> (select abo_id from  abo  where  customerid = " & _row("customers_id") & " order by date desc limit 1 ) order by date desc limit 1"


                    DvdPostData.clsConnection.FillDataSet(_DS.Tables("abo"), DvdPostData.clsAboStopWhy.getPreviousAction(_row("customers_id")))
                    If _DS.Tables("abo").Rows.Count = 1 Then
                        _previous_action_id = _DS.Tables("abo").Rows(0)("action_id")
                        _previous_action_name = _DS.Tables("abo").Rows(0)("action_name") & ""
                        _previous_action_date = _DS.Tables("abo").Rows(0)("abo_date") & ""
                        Select Case CInt(_DS.Tables("abo").Rows(0)("action_id"))
                            Case 6 'From Discount
                                _previous_action_activation_id = CInt("0" & _DS.Tables("abo").Rows(0)("discount_code_id"))
                                _previous_action_activation_group_id = CInt("0" & _DS.Tables("abo").Rows(0)("discount_code_id"))
                                _previous_action_activation_group_name = _DS.Tables("abo").Rows(0)("discount_code") & ""
                                _previous_action_activation_type = "D"
                            Case 8 'From Activation
                                _previous_action_activation_id = CInt("0" & _DS.Tables("abo").Rows(0)("activation_id"))
                                _previous_action_activation_group_id = CInt("0" & _DS.Tables("abo").Rows(0)("activation_group"))
                                _previous_action_activation_group_name = _DS.Tables("abo").Rows(0)("activation_group_name") & ""
                                _previous_action_activation_type = "A"
                            Case Else
                                _previous_action_activation_id = 0
                                _previous_action_activation_group_id = 0
                                _previous_action_activation_group_name = ""
                                _previous_action_activation_type = ""
                        End Select
                    Else
                        _previous_action_id = 0
                        _previous_action_name = ""
                        _previous_action_activation_id = 0
                        _previous_action_activation_group_id = 0
                        _previous_action_activation_group_name = ""
                        _previous_action_activation_type = ""
                        _previous_action_date = Nothing
                    End If
                    'End If
                    _row("Previous_Action_ID") = _previous_action_id
                    _row("Previous_Action_Name") = _previous_action_name
                    _row("Previous_Action_Activation_Type") = _previous_action_activation_type
                    _row("Previous_Action_Activation_ID") = _previous_action_activation_id
                    _row("Previous_Action_Activation_group_id") = _previous_action_activation_group_id
                    _row("Previous_Action_Activation_group_name") = _previous_action_activation_group_name
                    _row("Previous_Action_date") = _previous_action_date
                End If
            Next
        End If
    End Sub

    Public Sub export()
        Dim fB As New Windows.Forms.FolderBrowserDialog

        fB.RootFolder = Environment.SpecialFolder.Desktop

        fB.Description = "Sélectionner un répertoire"

        fB.ShowDialog()
        If fB.SelectedPath = String.Empty Then

            MsgBox("Pas de sélection")
        Else
            Grid1.ExportToXls(fB.SelectedPath + "\abo_stop.xls")
        End If
    End Sub

    Private Sub btnExportXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportXls.Click
        export()
    End Sub
End Class
