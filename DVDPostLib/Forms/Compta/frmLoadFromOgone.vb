Imports System.Windows.Forms.Application
Public Class frmLoadFromOgone
    Inherits BizzLib.frmBKForm

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
    Friend WithEvents tabLoadOgoneExpiration As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelSelection As System.Windows.Forms.Panel
    Friend WithEvents SpinProcessCounter As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtExcelFile As System.Windows.Forms.TextBox
    Friend WithEvents lblExcelFile As System.Windows.Forms.Label
    Friend WithEvents PanelDataDetail As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelCommands As System.Windows.Forms.Panel
    Friend WithEvents btnProcess As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClearData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFile1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents _DS As DVDPostLib.dsCompta
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcard_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcard_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexpiration_date As DevExpress.XtraGrid.Columns.GridColumn

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabLoadOgoneExpiration = New DevExpress.XtraTab.XtraTabPage
        Me.PanelDataDetail = New System.Windows.Forms.Panel
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me._DS = New DVDPostLib.dsCompta
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colcustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcard_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colcard_no = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colexpiration_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelCommands = New System.Windows.Forms.Panel
        Me.btnProcess = New DevExpress.XtraEditors.SimpleButton
        Me.btnClearData = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadData = New DevExpress.XtraEditors.SimpleButton
        Me.PanelSelection = New System.Windows.Forms.Panel
        Me.SpinProcessCounter = New DevExpress.XtraEditors.SpinEdit
        Me.btnBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.txtExcelFile = New System.Windows.Forms.TextBox
        Me.lblExcelFile = New System.Windows.Forms.Label
        Me.OpenFile1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabLoadOgoneExpiration.SuspendLayout()
        Me.PanelDataDetail.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCommands.SuspendLayout()
        Me.PanelSelection.SuspendLayout()
        CType(Me.SpinProcessCounter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabLoadOgoneExpiration
        Me.XtraTabControl1.Size = New System.Drawing.Size(1040, 442)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabLoadOgoneExpiration})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabLoadOgoneExpiration
        '
        Me.tabLoadOgoneExpiration.Controls.Add(Me.PanelDataDetail)
        Me.tabLoadOgoneExpiration.Controls.Add(Me.PanelSelection)
        Me.tabLoadOgoneExpiration.Name = "tabLoadOgoneExpiration"
        Me.tabLoadOgoneExpiration.Size = New System.Drawing.Size(1031, 411)
        Me.tabLoadOgoneExpiration.Text = "Load Ogone Expiration"
        '
        'PanelDataDetail
        '
        Me.PanelDataDetail.Controls.Add(Me.GridControl1)
        Me.PanelDataDetail.Controls.Add(Me.PanelCommands)
        Me.PanelDataDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDataDetail.Location = New System.Drawing.Point(0, 40)
        Me.PanelDataDetail.Name = "PanelDataDetail"
        Me.PanelDataDetail.Size = New System.Drawing.Size(1031, 371)
        Me.PanelDataDetail.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "OgoneExp"
        Me.GridControl1.DataSource = Me._DS
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(943, 371)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        '_DS
        '
        Me._DS.DataSetName = "dsCompta"
        Me._DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcustomers_id, Me.colcard_type, Me.colcard_no, Me.colexpiration_date})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1086, 229, 208, 360)
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView1.GroupPanelText = "..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colcustomers_id
        '
        Me.colcustomers_id.Caption = "customers_id"
        Me.colcustomers_id.FieldName = "customers_id"
        Me.colcustomers_id.Name = "colcustomers_id"
        Me.colcustomers_id.Visible = True
        Me.colcustomers_id.VisibleIndex = 0
        '
        'colcard_type
        '
        Me.colcard_type.Caption = "card_type"
        Me.colcard_type.FieldName = "card_type"
        Me.colcard_type.Name = "colcard_type"
        Me.colcard_type.Visible = True
        Me.colcard_type.VisibleIndex = 1
        '
        'colcard_no
        '
        Me.colcard_no.Caption = "card_no"
        Me.colcard_no.FieldName = "card_no"
        Me.colcard_no.Name = "colcard_no"
        Me.colcard_no.Visible = True
        Me.colcard_no.VisibleIndex = 2
        '
        'colexpiration_date
        '
        Me.colexpiration_date.Caption = "expiration_date"
        Me.colexpiration_date.FieldName = "expiration_date"
        Me.colexpiration_date.Name = "colexpiration_date"
        Me.colexpiration_date.Visible = True
        Me.colexpiration_date.VisibleIndex = 3
        '
        'PanelCommands
        '
        Me.PanelCommands.Controls.Add(Me.btnProcess)
        Me.PanelCommands.Controls.Add(Me.btnClearData)
        Me.PanelCommands.Controls.Add(Me.btnLoadData)
        Me.PanelCommands.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelCommands.Location = New System.Drawing.Point(943, 0)
        Me.PanelCommands.Name = "PanelCommands"
        Me.PanelCommands.Size = New System.Drawing.Size(88, 371)
        Me.PanelCommands.TabIndex = 3
        '
        'btnProcess
        '
        Me.btnProcess.ImageIndex = 13
        Me.btnProcess.Location = New System.Drawing.Point(8, 72)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(72, 24)
        Me.btnProcess.TabIndex = 20
        Me.btnProcess.Text = "&Process"
        '
        'btnClearData
        '
        Me.btnClearData.ImageIndex = 13
        Me.btnClearData.Location = New System.Drawing.Point(8, 8)
        Me.btnClearData.Name = "btnClearData"
        Me.btnClearData.Size = New System.Drawing.Size(72, 24)
        Me.btnClearData.TabIndex = 19
        Me.btnClearData.Text = "&Clear Data"
        '
        'btnLoadData
        '
        Me.btnLoadData.ImageIndex = 13
        Me.btnLoadData.Location = New System.Drawing.Point(8, 40)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(72, 24)
        Me.btnLoadData.TabIndex = 18
        Me.btnLoadData.Text = "&Load Data"
        '
        'PanelSelection
        '
        Me.PanelSelection.Controls.Add(Me.SpinProcessCounter)
        Me.PanelSelection.Controls.Add(Me.btnBrowse)
        Me.PanelSelection.Controls.Add(Me.txtExcelFile)
        Me.PanelSelection.Controls.Add(Me.lblExcelFile)
        Me.PanelSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSelection.Location = New System.Drawing.Point(0, 0)
        Me.PanelSelection.Name = "PanelSelection"
        Me.PanelSelection.Size = New System.Drawing.Size(1031, 40)
        Me.PanelSelection.TabIndex = 1
        '
        'SpinProcessCounter
        '
        Me.SpinProcessCounter.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinProcessCounter.Location = New System.Drawing.Point(605, 7)
        Me.SpinProcessCounter.Name = "SpinProcessCounter"
        Me.SpinProcessCounter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinProcessCounter.Size = New System.Drawing.Size(100, 20)
        Me.SpinProcessCounter.TabIndex = 20
        Me.SpinProcessCounter.Visible = False
        '
        'btnBrowse
        '
        Me.btnBrowse.ImageIndex = 13
        Me.btnBrowse.Location = New System.Drawing.Point(504, 8)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(56, 24)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "&Browse"
        '
        'txtExcelFile
        '
        Me.txtExcelFile.Location = New System.Drawing.Point(120, 8)
        Me.txtExcelFile.Name = "txtExcelFile"
        Me.txtExcelFile.Size = New System.Drawing.Size(368, 20)
        Me.txtExcelFile.TabIndex = 2
        '
        'lblExcelFile
        '
        Me.lblExcelFile.Location = New System.Drawing.Point(8, 16)
        Me.lblExcelFile.Name = "lblExcelFile"
        Me.lblExcelFile.Size = New System.Drawing.Size(112, 16)
        Me.lblExcelFile.TabIndex = 1
        Me.lblExcelFile.Text = "Excel File to Import"
        '
        'OpenFile1
        '
        Me.OpenFile1.DefaultExt = "xls"
        Me.OpenFile1.Filter = "Excel File|*.xls|All files|*.*"
        '
        'frmLoadFromOgone
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 472)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmLoadFromOgone"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabLoadOgoneExpiration.ResumeLayout(False)
        Me.PanelDataDetail.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCommands.ResumeLayout(False)
        Me.PanelSelection.ResumeLayout(False)
        Me.PanelSelection.PerformLayout()
        CType(Me.SpinProcessCounter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
    Dim Date1 As Date
    Dim TableName As String = "OgoneExp"
    Dim ExcelFileName As String

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        OpenFile1.ShowDialog()
        ExcelFileName = OpenFile1.FileName
        txtExcelFile.Text = ExcelFileName
    End Sub
    Private Sub btnClearData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearData.Click
        _DS.Tables(TableName).Clear()
    End Sub
    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        'Dim ExcelApp As Object
        'Dim WB As Excel.Workbook
        'Dim _XWorkSheet As New Excel.Worksheet
        Dim _Row As DataRow
        Dim i As Integer
        Dim _strCustID As String
        Dim _frm As New BizzLib.frmProgressBarPopUP(SessionInfo)

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        _frm.MemoEdit1.Text = ""
        _frm.Show()
        _frm.MemoEdit1.Text += "Connecting To Excel" & vbCrLf
        _frm.Refresh()
        _DS.Tables(TableName).Clear()
        Dim EXCELConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtExcelFile.Text & ";Extended Properties=""Excel 8.0;HDR=No""")
        EXCELConn.Open()
        Dim _SQLTxt As String = "SELECT * FROM [Sheet1$A1:A1]"
        Dim _ole As New OleDb.OleDbDataAdapter(_SQLTxt, EXCELConn)
        Dim _ExcelDS As New DataSet
        '_ExcelDS.Tables.Add("Date1")
        ''_ExcelDS.Tables("Date1").Columns.Add("Date1")
        ''TT Date1 = _XWorkSheet.Range("B1").Value
        '_ole.Fill(_ExcelDS.Tables("Date1"))
        'If _ExcelDS.Tables("Date1").Rows.Count = 0 Then
        '    MsgBox("Cannot Find Excel Info in Cell A1", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        i = 3
        _frm.MemoEdit1.Text += "Loading Data from Excel" & vbCrLf
        _frm.Refresh()

        Do
            _ExcelDS.Tables.Add("ExcelRow")
            _SQLTxt = "SELECT * FROM [Sheet1$A" & i & ":R" & i & "]"
            _ole.SelectCommand.CommandText = _SQLTxt
            'TT Date1 = _XWorkSheet.Range("B1").Value
            _ole.Fill(_ExcelDS.Tables("ExcelRow"))
            If _ExcelDS.Tables("ExcelRow").Rows.Count = 0 Then
                Exit Do
            End If
            If IsDBNull(_ExcelDS.Tables("ExcelRow").Rows(0)(0)) Then
                Exit Do
            End If
            _Row = _DS.Tables(TableName).NewRow()
            _strCustID = _ExcelDS.Tables("ExcelRow").Rows(0)(1) & ""
            If _strCustID & "" <> "" Then
                If Mid(_strCustID, 1, 1) = "b" Then
                    _Row("customers_id") = Mid(_strCustID, InStr(_strCustID, "c", CompareMethod.Text) + 1)
                Else
                    _strCustID = CLng(_ExcelDS.Tables("ExcelRow").Rows(0)(1) / 100000).ToString
                    _Row("customers_id") = Mid(_strCustID, 1, InStr(_strCustID, "2008", CompareMethod.Text) - 1)
                End If
                _Row("card_type") = _ExcelDS.Tables("ExcelRow").Rows(0)(15)
                _Row("card_no") = _ExcelDS.Tables("ExcelRow").Rows(0)(16)
                _Row("expiration_date") = _ExcelDS.Tables("ExcelRow").Rows(0)(17)
                _DS.Tables(TableName).Rows.Add(_Row)
            End If
            i += 1
            _ExcelDS.Tables("ExcelRow").Clear()
            _ExcelDS.Tables.Remove("ExcelRow")
        Loop
        EXCELConn.Close()


        '_frm.MemoEdit1.Text += "Retreiving Customers ID / Payment ID" & vbCrLf
        '_frm.Refresh()
        'SpinProcessCounter.EditValue = _DS.Tables(TableName).Rows.Count
        'SpinProcessCounter.Visible = True
        'SpinProcessCounter.Refresh()
        'For Each _Row In _DS.Tables(TableName).Rows
        '    _DS.Tables("payment_offline_request").Clear()
        '    'Searching By Communication
        '     DvdPostData.clsConnection.FillDataSet(_DS.Tables("payment_offline_request"), "SELECT * FROM payment_offline_request p WHERE communication = '" & _Row("NotreRef") & "'")
        '    If _DS.Tables("payment_offline_request").Rows.Count = 0 Then
        '        'Searching By CustomerID
        '         DvdPostData.clsConnection.FillDataSet(_DS.Tables("payment_offline_request"), _
        '             "SELECT * FROM payment_offline_request p WHERE customers_id = '" & _Row("NotreRef") & "' and " & _
        '             " payment_offline_status = 9 and amount = " & _Row("Du_Principal") & " ORDER BY payment_offline_request_id LIMIT 1")
        '        If _DS.Tables("payment_offline_request").Rows.Count = 0 Then
        '            _Row("process_comment") = "Cannot Find OffLine Request"
        '            _Row("customers_id") = DBNull.Value
        '            _Row("payment_offline_request_id") = DBNull.Value
        '        Else
        '            _Row("process_comment") = ""
        '            _Row("customers_id") = _DS.Tables("payment_offline_request").Rows(0)("customers_id")
        '            _Row("payment_offline_request_id") = _DS.Tables("payment_offline_request").Rows(0)("payment_offline_request_id")
        '        End If
        '    Else
        '        If _DS.Tables("payment_offline_request").Rows.Count > 1 Then
        '            _Row("process_comment") = "More than 1 OffLine Request"
        '            _Row("customers_id") = DBNull.Value
        '            _Row("payment_offline_request_id") = DBNull.Value
        '        Else
        '            _Row("process_comment") = ""
        '            _Row("customers_id") = _DS.Tables("payment_offline_request").Rows(0)("customers_id")
        '            _Row("payment_offline_request_id") = _DS.Tables("payment_offline_request").Rows(0)("payment_offline_request_id")
        '        End If
        '    End If
        '    SpinProcessCounter.EditValue -= 1
        '    SpinProcessCounter.Refresh()
        'Next
        'SpinProcessCounter.Visible = False
        _frm.MemoEdit1.Text += "Closing Excel" & vbCrLf
        _frm.Refresh()
        _frm.Close()
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

    End Sub
    Private Sub btnCreateTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim _row As DataRow
        Dim _custRow As DataRow
        Dim _SQLTxt As String
        _DS.Tables.Add("TmpTable")
        SpinProcessCounter.EditValue = _DS.Tables(TableName).Rows.Count
        SpinProcessCounter.Visible = True
        SpinProcessCounter.Refresh()
        For Each _row In _DS.Tables(TableName).Rows
            _SQLTxt = "SELECT customers_id, ogone_card_no FROM customers where customers_id = " & _row("customers_id")
            _DS.Tables("TmpTable").Clear()
            DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
            If _DS.Tables("TmpTable").Rows.Count = 1 Then
                _custRow = _DS.Tables("TmpTable").Rows(0)
                If _custRow("ogone_card_no") & "" <> "" Or IsDBNull(_custRow("ogone_card_no")) Then
                    'Update Credit Card Info
                    _SQLTxt = "update customers set " & _
                              " ogone_card_type = '" & _row("card_type") & "', " & _
                              " ogone_card_no = '" & _row("card_no") & "', " & _
                              " ogone_exp_date = '" & Replace(_row("expiration_date"), " ", "") & "', " & _
                              " ogone_cc_expiration_status = 0 " & _
                              " WHERE customers_id = " & _row("customers_id")
                    DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
                End If
            End If
            SpinProcessCounter.EditValue -= 1
            SpinProcessCounter.Refresh()
            DoEvents()
        Next
        SpinProcessCounter.Visible = False
        _DS.Tables.Remove("TmpTable")
    End Sub

    Private Sub frmLoadFromOgone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip
    End Sub
End Class
