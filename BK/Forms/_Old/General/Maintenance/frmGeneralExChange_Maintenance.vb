Imports BizzLib.clsGlobal.ObjectState
Imports DevExpress.XtraPrinting

Public Class frmGeneralExChange_Maintenance
    Inherits BizzLib.frmGeneral_Maintenance
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CurrLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BankTransactionTypeLookUp As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents objDS As BizzLib.dsGeneral
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents colCurrCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExRate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGeneralExChange_Maintenance))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.objDS = New BizzLib.dsGeneral
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCurrCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExRate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.CurrLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.BankTransactionTypeLookUp = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.txtDate = New DevExpress.XtraEditors.DateEdit
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankTransactionTypeLookUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.GridControl1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 418)
        Me.Panel1.TabIndex = 31
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.systemcurrencyexrate
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 48)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CurrLookUp, Me.BankTransactionTypeLookUp, Me.RepositoryItemCalcEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(616, 370)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.Text = "GridControl1"
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsGeneral"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCurrCode, Me.colExRate})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowGroupedColumns = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colCurrCode)
        Me.GridBand1.Columns.Add(Me.colExRate)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 754
        '
        'colCurrCode
        '
        Me.colCurrCode.Caption = "CurrCode"
        Me.colCurrCode.FieldName = "CurrCode"
        Me.colCurrCode.Name = "colCurrCode"
        Me.colCurrCode.Visible = True
        Me.colCurrCode.Width = 273
        '
        'colExRate
        '
        Me.colExRate.Caption = "ExRate"
        Me.colExRate.FieldName = "ExRate"
        Me.colExRate.Name = "colExRate"
        Me.colExRate.Visible = True
        Me.colExRate.Width = 481
        '
        'CurrLookUp
        '
        Me.CurrLookUp.AutoHeight = False
        Me.CurrLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CurrLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrCode", "Currency", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CurrLookUp.DisplayMember = "CurrCode"
        Me.CurrLookUp.Name = "CurrLookUp"
        Me.CurrLookUp.NullText = ""
        Me.CurrLookUp.ValueMember = "CurrCode"
        '
        'BankTransactionTypeLookUp
        '
        Me.BankTransactionTypeLookUp.AutoHeight = False
        Me.BankTransactionTypeLookUp.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BankTransactionTypeLookUp.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeValue", "Type", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "Description", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.BankTransactionTypeLookUp.DisplayMember = "CodeValue"
        Me.BankTransactionTypeLookUp.Name = "BankTransactionTypeLookUp"
        Me.BankTransactionTypeLookUp.NullText = ""
        Me.BankTransactionTypeLookUp.ValueMember = "CodeValue"
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.AutoHeight = False
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblInfo)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(616, 48)
        Me.Panel2.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(168, 16)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(144, 16)
        Me.lblInfo.TabIndex = 18
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(16, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 23)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.EditValue = New Date(CType(0, Long))
        Me.txtDate.Location = New System.Drawing.Point(64, 16)
        Me.txtDate.Name = "txtDate"
        '
        'txtDate.Properties
        '
        Me.txtDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDate.Size = New System.Drawing.Size(96, 20)
        Me.txtDate.TabIndex = 17
        '
        'frmGeneralExChange_Maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGeneralExChange_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankTransactionTypeLookUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim MainData As clsCurrency.clsData_Currency
    Dim AlreadySaving As Boolean = False
    Dim ExChangeType As String = "0" 'Default ExChangeType

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'SetUp of Variables
            KeyFieldName = "Name"
            IDField = "CurrCode"
            TableName = "systemcurrency"
            MainDataSet = objDS
            BarManager1.Bars("Misc_Bar2").Visible = False
            BarManager1.Bars("Filter_Bar").Visible = False
            BarManager1.Bars("DefaultSet_Bar").Visible = False
            BarManager1.Bars("QuickSearch_Bar").Visible = False
            'ToolBar1.Tools("btnSave").SharedProps.Visible = False
            btnSave.Enabled = True
            btnUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            BKCombo.GetCombo_Currency(objDS, "systemcurrency", "CurrCode")
            MainData = New clsCurrency.clsData_Currency(SessionInfo, objDS, KeyDataSet, "systemcurrency", "", "CurrCode")
            txtDate.DateTime = MainData.GetLastExRateDate(ExChangeType)
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            EnablingFields(True)
            OpenType = "EDIT"
        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
    Private Sub frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        SaveBeforeNavigating(sender, e)
    End Sub

    Private Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventNewRecord
        CreateExRates()
    End Sub
    Private Sub DeleteRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventDeleteRecord

        'Confirm Delete
        If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                GridView1.CloseEditor()
                GridView1.CancelUpdateCurrentRow()
                Do
                    If objDS.Tables("systemcurrencyexrate").DefaultView.Count > 0 Then
                        objDS.Tables("systemcurrencyexrate").DefaultView(0).Delete()
                    Else
                        Exit Do
                    End If
                Loop
                SaveChanges(Sender, e)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            MainData.SaveOnlyExRate()
        End If
    End Sub
    Private Sub CreateExRates()
        'Create Exrate Records that are Missing
        Dim _CurrView As DataView = objDS.Tables("systemcurrency").DefaultView
        Dim _ExRateView, _PrevExRateView As DataView
        Dim _objds As DataSet = objDS.Clone
        Dim _MainData As New clsCurrency.clsData_Currency(SessionInfo)
        _MainData.LoadExRates(_objds, KeyDataSet, MainData.GetLastExRateDate(ExChangeType), ExChangeType)
        _PrevExRateView = New DataView(_objds.Tables("systemcurrencyexrate"), "", "CurrCode", DataViewRowState.CurrentRows)
        _ExRateView = New DataView(objDS.Tables("systemcurrencyexrate"), "", "CurrCode", DataViewRowState.CurrentRows)
        Dim _CurrRow, _ExRateRow, _PrevExRateRow As DataRowView
        For Each _CurrRow In _CurrView
            If _ExRateView.Find(_CurrRow("CurrCode")) < 0 Then
                _ExRateRow = _ExRateView.AddNew
                _ExRateRow("ExChangeID") = BKGlobal.GetNextID("ExChangeID")
                _ExRateRow("ExChangeType") = ExChangeType
                _ExRateRow("FromDate") = txtDate.DateTime
                _ExRateRow("CurrCode") = _CurrRow("CurrCode")
                If _PrevExRateView.Find(_CurrRow("CurrCode")) >= 0 Then
                    _PrevExRateRow = _PrevExRateView(_PrevExRateView.Find(_CurrRow("CurrCode")))
                    _ExRateRow("ExRate") = _PrevExRateRow("ExRate")
                Else

                End If
                _ExRateRow.EndEdit()
            End If
        Next
        MainData.SaveOnlyExRate()
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventSaveChanges

        If AlreadySaving Then Exit Sub
        If GridView1.FocusedRowHandle < 0 Then Exit Sub
        If txtDate.EditValue & "" = "" Then Exit Sub

        AlreadySaving = True
        Dim _FocusedRow As Integer = GridView1.FocusedRowHandle
        Dim _RoW As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        Try
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            Me.UpdateDataSet()
        Catch eUpdate As System.Exception
            AlreadySaving = False
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
            GridView1.FocusedRowHandle = _FocusedRow
        End Try
        AlreadySaving = False
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        Me.BindingContext(objDS, "systemcurrencyexrate").EndCurrentEdit()
        MainData.SaveOnlyExRate()
        EnablingFields(True)
    End Sub

    Private Sub EnablingFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        'ToBeChecked ***
        txtDate.Enabled = Enabling
    End Sub

    Private Sub txtDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate.EditValueChanged
        SetDefaults()
    End Sub
    Private Sub SetDefaults()
        If txtDate.EditValue & "" <> "" Then
            GridControl1.Enabled = True
        Else
            GridControl1.Enabled = False
            Exit Sub
        End If

        If Not IsNothing(objDS.Tables("systemcurrencyexrate")) Then
            'Load ExRates
            If Not IsNothing(MainData) Then
                MainData.LoadExRates(objDS, KeyDataSet, txtDate.DateTime, ExChangeType)
            End If
            'objDS.Tables("CashBankAccountTransaction").Columns("DocID").DefaultValue = -1
            'objDS.Tables("CashBankAccountTransaction").Columns("DocType").DefaultValue = clsCash.OperationType.ManualEntry
            'objDS.Tables("CashBankAccountTransaction").Columns("TransactionDate").DefaultValue = txtDate.DateTime
            'objDS.Tables("CashBankAccountTransaction").Columns("StatementYear").DefaultValue = Year(txtDate.DateTime)
            'objDS.Tables("CashBankAccountTransaction").Columns("BankAccountID").DefaultValue = cmbBankAccount.EditValue
            'objDS.Tables("CashBankAccountTransaction").Columns("ForeignCurr").DefaultValue = txtAccountCurr.Text
            'objDS.Tables("CashBankAccountTransaction").Columns("ExRate").DefaultValue = 1
            'objDS.Tables("CashBankAccountTransaction").Columns("ForeignCurrAmt").DefaultValue() = 0
            'objDS.Tables("CashBankAccountTransaction").Columns("TransactionAmt").DefaultValue() = 0
            'objDS.Tables("CashBankAccountTransaction").Columns("BankTransactionID").DefaultValue = -1
        End If
    End Sub

    Private Sub NavToFirstEffDate(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventNavFirst
        SaveBeforeNavigating(Sender, e)
        Dim _FromDate As Date = MainData.GetFirstExRateDate(ExChangeType)
        txtDate.DateTime = _FromDate
    End Sub
    Private Sub NavToLastEffDate(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventNavLast
        SaveBeforeNavigating(Sender, e)
        Dim _Fromdate As Date = MainData.GetLastExRateDate(ExChangeType)
        txtDate.DateTime = _Fromdate
    End Sub
    Private Sub NavToPreviousEffDate(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventNavPrevious
        SaveBeforeNavigating(Sender, e)
        Dim _Fromdate As Date = MainData.GetPreviousExRateDate(txtDate.DateTime, ExChangeType)
        txtDate.DateTime = _Fromdate
    End Sub
    Private Sub NavToNextEffDate(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.EventNavNext
        SaveBeforeNavigating(Sender, e)
        Dim _Fromdate As Date = MainData.GetNextExRateDate(txtDate.DateTime, ExChangeType)
        txtDate.DateTime = _Fromdate
    End Sub
    Private Sub SaveBeforeNavigating(ByVal Sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNothing(GridView1.GetDataRow(GridView1.FocusedRowHandle)) Then
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()
            If GridView1.GetDataRow(GridView1.FocusedRowHandle).RowState <> DataRowState.Unchanged Then
                SaveChanges(Sender, e)
            End If
        End If
    End Sub

    'Private Sub GridView1_BeforeLeaveRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles GridView1.BeforeLeaveRow
    '    SaveChanges()
    'End Sub
    'Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
    '    If GridView1.GetDataRow(GridView1.FocusedRowHandle)("BankTransactionID") & "" = "" Then
    '        GridView1.GetDataRow(GridView1.FocusedRowHandle)("BankTransactionID") = BKGlobal.GetNextID("BankTransactionID")
    '    End If
    'End Sub
    'Private Sub GridView1_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.LostFocus
    '    SaveChanges()
    'End Sub
    Private Sub GridView1_CellValueChanging(ByVal sender As System.Object, _
            ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        Dim _Row As DataRow = GridView1.GetDataRow(e.RowHandle)
        If IsNothing(_Row) Then Exit Sub
        lblInfo.Text = e.Value & _
                 " " & _Row("CurrCode") & " = 1 " & SessionInfo.BaseCurrency
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim _Row As DataRow = GridView1.GetDataRow(e.FocusedRowHandle)
        If IsNothing(_Row) Then
            lblInfo.Text = ""
            Exit Sub
        Else
            lblInfo.Text = GridView1.GetRowCellValue(e.FocusedRowHandle, GridView1.Columns("ExRate")) & _
                             " " & _Row("CurrCode") & " = 1 " & SessionInfo.BaseCurrency
        End If
    End Sub

End Class
