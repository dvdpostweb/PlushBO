Imports System.Windows.Forms
Imports System.IO
Imports PlushData

Public Class frmBankTransfer
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
    Friend WithEvents Lblend As System.Windows.Forms.Label
    Friend WithEvents Lblstart As System.Windows.Forms.Label
    Friend WithEvents DeditEnd As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnchangeStatus As System.Windows.Forms.Button
    Friend WithEvents BtnMatching As System.Windows.Forms.Button
    Friend WithEvents BPrintSelected As System.Windows.Forms.Button
    Friend WithEvents DeditStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents BtnPrintletter As System.Windows.Forms.Button
    Friend WithEvents btnRecondBT As System.Windows.Forms.Button
    Friend WithEvents ButloadBankTransfert As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Lblend = New System.Windows.Forms.Label
        Me.Lblstart = New System.Windows.Forms.Label
        Me.DeditEnd = New DevExpress.XtraEditors.DateEdit
        Me.BtnchangeStatus = New System.Windows.Forms.Button
        Me.BtnMatching = New System.Windows.Forms.Button
        Me.BPrintSelected = New System.Windows.Forms.Button
        Me.DeditStart = New DevExpress.XtraEditors.DateEdit
        Me.BtnPrintletter = New System.Windows.Forms.Button
        Me.btnRecondBT = New System.Windows.Forms.Button
        Me.ButloadBankTransfert = New System.Windows.Forms.Button
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
        CType(Me.DeditEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeditStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 466)
        Me.StatusBar1.Size = New System.Drawing.Size(1040, 24)
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Size = New System.Drawing.Size(1040, 436)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        Me.TabControl1.Size = New System.Drawing.Size(1040, 436)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.Lblend)
        Me.TabParameters.Controls.Add(Me.Lblstart)
        Me.TabParameters.Controls.Add(Me.DeditEnd)
        Me.TabParameters.Controls.Add(Me.BtnchangeStatus)
        Me.TabParameters.Controls.Add(Me.BtnMatching)
        Me.TabParameters.Controls.Add(Me.BPrintSelected)
        Me.TabParameters.Controls.Add(Me.DeditStart)
        Me.TabParameters.Controls.Add(Me.BtnPrintletter)
        Me.TabParameters.Controls.Add(Me.btnRecondBT)
        Me.TabParameters.Controls.Add(Me.ButloadBankTransfert)
        Me.TabParameters.PageVisible = True
        Me.TabParameters.Size = New System.Drawing.Size(1031, 405)
        '
        'TabResult
        '
        Me.TabResult.Size = New System.Drawing.Size(1031, 405)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Size = New System.Drawing.Size(1031, 405)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1031, 405)
        '
        'UcChart1
        '
        Me.UcChart1.Size = New System.Drawing.Size(1031, 405)
        '
        'TabChart
        '
        Me.TabChart.Size = New System.Drawing.Size(1031, 405)
        '
        'Lblend
        '
        Me.Lblend.AutoSize = True
        Me.Lblend.Location = New System.Drawing.Point(10, 35)
        Me.Lblend.Name = "Lblend"
        Me.Lblend.Size = New System.Drawing.Size(49, 13)
        Me.Lblend.TabIndex = 37
        Me.Lblend.Text = "end date"
        '
        'Lblstart
        '
        Me.Lblstart.AutoSize = True
        Me.Lblstart.Location = New System.Drawing.Point(10, 6)
        Me.Lblstart.Name = "Lblstart"
        Me.Lblstart.Size = New System.Drawing.Size(51, 13)
        Me.Lblstart.TabIndex = 36
        Me.Lblstart.Text = "start date"
        '
        'DeditEnd
        '
        Me.DeditEnd.AllowDrop = True
        Me.DeditEnd.EditValue = Nothing
        Me.DeditEnd.Location = New System.Drawing.Point(67, 29)
        Me.DeditEnd.Name = "DeditEnd"
        Me.DeditEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditEnd.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DeditEnd.Size = New System.Drawing.Size(121, 20)
        Me.DeditEnd.TabIndex = 35
        '
        'BtnchangeStatus
        '
        Me.BtnchangeStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnchangeStatus.Location = New System.Drawing.Point(629, 20)
        Me.BtnchangeStatus.Name = "BtnchangeStatus"
        Me.BtnchangeStatus.Size = New System.Drawing.Size(96, 28)
        Me.BtnchangeStatus.TabIndex = 34
        Me.BtnchangeStatus.Text = "Change Status"
        Me.BtnchangeStatus.UseVisualStyleBackColor = True
        Me.BtnchangeStatus.Visible = False
        '
        'BtnMatching
        '
        Me.BtnMatching.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnMatching.Location = New System.Drawing.Point(893, 20)
        Me.BtnMatching.Name = "BtnMatching"
        Me.BtnMatching.Size = New System.Drawing.Size(96, 28)
        Me.BtnMatching.TabIndex = 33
        Me.BtnMatching.Text = "Matching"
        Me.BtnMatching.UseVisualStyleBackColor = True
        '
        'BPrintSelected
        '
        Me.BPrintSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BPrintSelected.Location = New System.Drawing.Point(527, 20)
        Me.BPrintSelected.Name = "BPrintSelected"
        Me.BPrintSelected.Size = New System.Drawing.Size(96, 28)
        Me.BPrintSelected.TabIndex = 32
        Me.BPrintSelected.Text = "Duplicata Print selected"
        Me.BPrintSelected.UseVisualStyleBackColor = True
        Me.BPrintSelected.Visible = False
        '
        'DeditStart
        '
        Me.DeditStart.AllowDrop = True
        Me.DeditStart.EditValue = Nothing
        Me.DeditStart.Location = New System.Drawing.Point(67, 3)
        Me.DeditStart.Name = "DeditStart"
        Me.DeditStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeditStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DeditStart.Size = New System.Drawing.Size(121, 20)
        Me.DeditStart.TabIndex = 31
        '
        'BtnPrintletter
        '
        Me.BtnPrintletter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPrintletter.Location = New System.Drawing.Point(416, 20)
        Me.BtnPrintletter.Name = "BtnPrintletter"
        Me.BtnPrintletter.Size = New System.Drawing.Size(96, 28)
        Me.BtnPrintletter.TabIndex = 30
        Me.BtnPrintletter.Text = "Print"
        Me.BtnPrintletter.UseVisualStyleBackColor = True
        Me.BtnPrintletter.Visible = False
        '
        'btnRecondBT
        '
        Me.btnRecondBT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRecondBT.Location = New System.Drawing.Point(791, 20)
        Me.btnRecondBT.Name = "btnRecondBT"
        Me.btnRecondBT.Size = New System.Drawing.Size(96, 28)
        Me.btnRecondBT.TabIndex = 29
        Me.btnRecondBT.Text = "Reconduction"
        Me.btnRecondBT.UseVisualStyleBackColor = True
        '
        'ButloadBankTransfert
        '
        Me.ButloadBankTransfert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButloadBankTransfert.Location = New System.Drawing.Point(287, 20)
        Me.ButloadBankTransfert.Name = "ButloadBankTransfert"
        Me.ButloadBankTransfert.Size = New System.Drawing.Size(123, 28)
        Me.ButloadBankTransfert.TabIndex = 28
        Me.ButloadBankTransfert.Text = "Load bank transfert"
        Me.ButloadBankTransfert.UseVisualStyleBackColor = True
        '
        'frmBankTransfer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 490)
        Me.Name = "frmBankTransfer"
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
        CType(Me.DeditEnd.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeditStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    '  Dim bank_transfert As aboReconduction
    Dim _dtBankTransfert As DataTable
    ' Dim _dtFollow As DataTable
    Dim taberror As New ArrayList
    Dim amount As String

    Enum Bank_Transfert_status
        PAYED
        PENDING
        PRINTED
        RECOVERY
    End Enum

    Const TYPE_PAYMENT_BANKTRANSFERT As String = "BANK_TRANSFER"
    Const REPORT_BANKTRANSFER As Integer = 1103


    Private Sub This_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim menuStrip As New PlushBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        objDS = New DataSet()
        'tabMain.PageVisible = True
        'tabBE_Ogone.PageVisible = True
        ' tabFollow.PageVisible = True
        'bank_transfert = New aboReconduction(SessionInfo)
        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)

        BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , , False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser1.Caption = "Print"
        btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser2.Caption = "Duplicata Print Selected"
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing
        btnUser3.Caption = "Change Status"
        btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser4.Caption = "Reconduction"
        btnUser5.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnUser5.Caption = "Matching"


        CurrentDefaultSetID = cmbDefaultList.EditValue

        MyBase.TableName = "payment"

        '  MyBase.IDField = "status_id"
        '  MyBase.NameField = "status_id"
        MyBase.MaintenanceMenuID = -1
        MyBase.WhereClause = ""
        MyBase.AutoLoadData = True
        MyBase.StartUp()

        TabControl1.SelectedTabPage = TabParameters
        ' Grid1 = vi

        '_ds.Tables.Add("id")
        '_ds.Tables.Add("bank_transfert_check")
        '_ds.Tables.Add("followBank_transfert")
        Me.DeditStart.EditValue = Now().ToString(DeditStart.Properties.EditFormat.FormatString)
        Me.DeditEnd.EditValue = Now().ToString(DeditEnd.Properties.EditFormat.FormatString)
    End Sub
    Private Sub loadBankTRansfert()
        Dim sql As String

        If Me.DeditStart.Text = "" Then
            MsgBox("you must choose a date")
        Else
            Dim cls As PlushBuziness.clsOffLinePayments = New PlushBuziness.clsOffLinePayments()
            sql = PlushData.clsBatchBankTransfert.GetDataPaymentCustomerDetail(Me.DeditStart.DateTime, DeditEnd.DateTime, PlushData.clsBatchBankTransfert.LIMIT_DAYPAID, PaymentOfflineData.GetListRecovery, False)
            Me.afficheBankTransfer(sql)
        End If
    End Sub
    Private Sub ButloadBankTransfert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButloadBankTransfert.Click
        loadBankTRansfert()

    End Sub
    Public Sub afficheBankTransfer(ByVal sql As String)


        If objDS.Tables.Contains(TableName) Then
            objDS.Tables.Remove(TableName)
        End If
        _dtBankTransfert = PlushData.clsConnection.FillDataSet(sql)
        _dtBankTransfert.TableName = TableName
        objDS.Tables.Add(_dtBankTransfert)

        Grid1.DataSource = objDS.Tables(TableName).DefaultView
        Grid1.RefreshDataSource()
        GridView1.OptionsView.ShowFooter = True
        TabControl1.SelectedTabPage = TabResult
        ' Me.vi.RefreshDataSource()
    End Sub
    Private Function GetDatePrint() As String

        Dim Date_print As String
        'Date_print = Me.DateEdit3.Text.Substring(0, Me.DateEdit3.Text.Length - 10) + "%"
        Date_print = Year(Me.DeditStart.Text) & "-" & Month(Me.DeditStart.Text) & "-" & DateAndTime.Day(Me.DeditStart.Text)
        Return Date_print
    End Function
    Public Sub print(Optional ByVal customer_id As Integer = 0)

        Dim chooseSql As String

        'strDatePrint = GetDatePrint()

        chooseSql = PlushData.clsBatchBankTransfert.GetDataPaymentCustomer(PlushData.clsBatchBankTransfert.LIMIT_DAYPAID, customer_id)
        afficheBankTransfer(chooseSql)

        Dim clscompta As PlushBuziness.clsCompta = New PlushBuziness.clsCompta()
        clscompta.sendLetter(_dtBankTransfert, REPORT_BANKTRANSFER)
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub
    Public Sub printDuplicata(Optional ByVal customer_id As Integer = 0)

        Dim chooseSql As String

        'strDatePrint = GetDatePrint()

        chooseSql = PlushData.clsBatchBankTransfert.GetDataPaymentCustomerDuplicata(DeditStart.DateTime, DeditEnd.DateTime, PlushData.clsBatchBankTransfert.LIMIT_DAYPAID, False, customer_id)
        afficheBankTransfer(chooseSql)

        Dim clscompta As PlushBuziness.clsCompta = New PlushBuziness.clsCompta()
        clscompta.sendLetter(_dtBankTransfert, REPORT_BANKTRANSFER)
        btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub
    Private Sub changeStatus()
        Dim list_id As String = ""
        Dim sql As String
        Dim cpt_result As Integer
        Dim cpt As Integer
        If MsgBox("Are you sur to change status print ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cpt = _dtBankTransfert.Rows.Count
            PlushData.clsConnection.CreateTransaction(True)
            For Each dr As DataRow In _dtBankTransfert.Rows
                If list_id = "" Then
                    list_id = list_id + dr("id").ToString()
                Else
                    list_id = list_id + "," & dr("id").ToString()
                End If
            Next

            sql = PlushData.clsBatchBankTransfert.UpdateStatusBankTransfert(list_id, PaymentOfflineData.StepPayment.PRINTED)
            PlushData.clsConnection.ExecuteNonQuery(sql)

            Try
                PlushData.clsConnection.ExecuteBulkQuery(PlushData.clsMsgError.processType.Matching, cpt_result)
                PlushData.clsConnection.CommitTransaction(True)
                MsgBox(cpt_result & "/" & cpt & " customers update status " & PaymentOfflineData.StepPayment.PRINTED)
                BtnchangeStatus.Visible = False
                btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Catch ex As Exception
                PlushData.clsConnection.CommitTransaction(False)
                MsgBox("ERROR changed status", MsgBoxStyle.Critical)
            End Try

        End If

    End Sub

    Private Sub BchangeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnchangeStatus.Click
        changeStatus()

    End Sub
    Private Sub _print()
        Me.print()
        BtnchangeStatus.Visible = True

        'BarManager1.Customize()
    End Sub
    Private Sub _printSelected()
        Dim LstSelected() As Integer
        LstSelected = GridView1.GetSelectedRows()

        If LstSelected.Length > 0 Then
            Dim customer_id As Integer
            Dim lang As Integer
            Dim item As Integer
            item = LstSelected(0)
            customer_id = GridView1.GetDataRow(item)("customers_id")
            lang = GridView1.GetDataRow(item)("Customers_language")
            printDuplicata(customer_id)

        End If
    End Sub
    Private Sub _reconduction()
        Dim clscust As PlushBuziness.ClsCustomers = New PlushBuziness.ClsCustomers()
        Dim ok As Boolean = True
        Dim msg As String
        'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.BELGIQUE)
        'msg = displayInfo(ok, ClsCustomersData.Payment_Method.VIREMENT, ClsCustomersData.Country.BELGIQUE)

        'clscust.ReconductionSms(ClsCustomersData.Country.BELGIQUE)
        'msg = msg + displayInfo(ok, DvdPostData.ClsCustomersData.Payment_Method.VIREMENT, DvdPostData.ClsCustomersData.Country.BELGIQUE)

        clscust.ReconductionVirement(PlushData.ClsCustomersData.Country.BELGIUM)
        msg = displayInfo(ok, PlushData.ClsCustomersData.Payment_Method.VIREMENT, PlushData.ClsCustomersData.Country.BELGIUM)

        'clscust.ReconductionPhone(DvdPostData.ClsCustomersData.Country.PAYSBAS)
        'msg = msg + displayInfo(ok, DvdPostData.ClsCustomersData.Payment_Method.VIREMENT, DvdPostData.ClsCustomersData.Country.PAYSBAS)

        'clscust.ReconductionSms(DvdPostData.ClsCustomersData.Country.PAYSBAS)
        'msg = msg + displayInfo(ok, DvdPostData.ClsCustomersData.Payment_Method.VIREMENT, DvdPostData.ClsCustomersData.Country.PAYSBAS)

        clscust.ReconductionVirement(PlushData.ClsCustomersData.Country.NEDERLANDS)
        msg = msg + displayInfo(ok, PlushData.ClsCustomersData.Payment_Method.VIREMENT, PlushData.ClsCustomersData.Country.NEDERLANDS)


        MsgBox(msg)
        matching()
        Me.DeditStart.EditValue = Now()
        loadBankTRansfert()
    End Sub
    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintletter.Click
        _print()
    End Sub
    Private Function displayInfo(ByVal ok As Boolean, ByVal status As PlushData.ClsCustomersData.Payment_Method, ByVal idcountry As PlushData.ClsCustomersData.Country) As String
        Dim msg As String
        If ok Then
            msg = " Reconduction " & PlushTools.clsEnum.getNameStrEnum(idcountry) & " " & status.ToString() & " OK "
        Else
            msg = " Error Reconduction " & PlushTools.clsEnum.getNameStrEnum(idcountry) & " " & status.ToString()
        End If

        Return msg & vbCrLf
    End Function
    Private Sub btnRecondBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecondBT.Click
        _reconduction()

    End Sub

    Private Sub matching()
        'Dim ok As Boolean
        'ok = DVDPostBuziness.ClsBankTransfer.matching()

        'If ok Then
        '    MsgBox("matching ok")
        'Else
        '    MsgBox("error matching")
        'End If
    End Sub
    Private Sub BtnMatching_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatching.Click
        matching()
    End Sub
    Public Sub BtnAllBankTRansfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadAll()
    End Sub
    Public Sub LoadAll()

        '  Dim sql As String

        'sql = "select customers_id , amount , status , DATE_FORMAT(add_date,'%Y/%m/%d') as date_entry from bank_transfert "
        '_dtFollow = DvdPostData.clsConnection.FillDataSet(sql)
        ' Me.GridFollow.DataSource = _dtFollow
    End Sub
    Private Sub BPrintSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintSelected.Click
        _printSelected()
    End Sub
#Region "Actions"

    Private Sub ActionPrint_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser1.ItemClick
        _print()
    End Sub

    Private Sub ActionPrintSelected_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser2.ItemClick
        _printSelected()
    End Sub

    Private Sub ActionChangeStatus_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser3.ItemClick
        changeStatus()
    End Sub

    Private Sub ActionReconduction_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser4.ItemClick
        _reconduction()
    End Sub

    Private Sub ActionMatching_Click(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUser5.ItemClick
        matching()
    End Sub
#End Region

End Class
