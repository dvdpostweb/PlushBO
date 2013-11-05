Imports System.IO
Imports System.Collections.Generic
Public Class frmMovieMaxInfo_Browse
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
    Friend WithEvents btnProcessMovieMax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMovieMAx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLoadOrdersGlobalData As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnGlobalDataProducts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadOrdersMoviemax As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDateMovieMax As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnGlobalDataProcess As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovieMaxInfo_Browse))
        Me.btnProcessMovieMax = New DevExpress.XtraEditors.SimpleButton
        Me.btnMovieMAx = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDateMovieMax = New DevExpress.XtraEditors.DateEdit
        Me.btnLoadOrdersMoviemax = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnGlobalDataProducts = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadOrdersGlobalData = New DevExpress.XtraEditors.SimpleButton
        Me.btnGlobalDataProcess = New DevExpress.XtraEditors.SimpleButton
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDateMovieMax.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateMovieMax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.TabParameters.Controls.Add(Me.GroupBox2)
        Me.TabParameters.Controls.Add(Me.GroupBox1)
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
        'btnProcessMovieMax
        '
        resources.ApplyResources(Me.btnProcessMovieMax, "btnProcessMovieMax")
        Me.btnProcessMovieMax.Name = "btnProcessMovieMax"
        Me.HelpProvider1.SetShowHelp(Me.btnProcessMovieMax, CType(resources.GetObject("btnProcessMovieMax.ShowHelp"), Boolean))
        '
        'btnMovieMAx
        '
        resources.ApplyResources(Me.btnMovieMAx, "btnMovieMAx")
        Me.btnMovieMAx.Name = "btnMovieMAx"
        Me.HelpProvider1.SetShowHelp(Me.btnMovieMAx, CType(resources.GetObject("btnMovieMAx.ShowHelp"), Boolean))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDateMovieMax)
        Me.GroupBox1.Controls.Add(Me.btnLoadOrdersMoviemax)
        Me.GroupBox1.Controls.Add(Me.btnMovieMAx)
        Me.GroupBox1.Controls.Add(Me.btnProcessMovieMax)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'txtDateMovieMax
        '
        Me.txtDateMovieMax.EditValue = Nothing
        resources.ApplyResources(Me.txtDateMovieMax, "txtDateMovieMax")
        Me.txtDateMovieMax.Name = "txtDateMovieMax"
        Me.txtDateMovieMax.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtDateMovieMax.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtDateMovieMax.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtDateMovieMax, CType(resources.GetObject("txtDateMovieMax.ShowHelp"), Boolean))
        '
        'btnLoadOrdersMoviemax
        '
        resources.ApplyResources(Me.btnLoadOrdersMoviemax, "btnLoadOrdersMoviemax")
        Me.btnLoadOrdersMoviemax.Name = "btnLoadOrdersMoviemax"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrdersMoviemax, CType(resources.GetObject("btnLoadOrdersMoviemax.ShowHelp"), Boolean))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnGlobalDataProducts)
        Me.GroupBox2.Controls.Add(Me.btnLoadOrdersGlobalData)
        Me.GroupBox2.Controls.Add(Me.btnGlobalDataProcess)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.HelpProvider1.SetShowHelp(Me.GroupBox2, CType(resources.GetObject("GroupBox2.ShowHelp"), Boolean))
        Me.GroupBox2.TabStop = False
        '
        'BtnGlobalDataProducts
        '
        resources.ApplyResources(Me.BtnGlobalDataProducts, "BtnGlobalDataProducts")
        Me.BtnGlobalDataProducts.Name = "BtnGlobalDataProducts"
        Me.HelpProvider1.SetShowHelp(Me.BtnGlobalDataProducts, CType(resources.GetObject("BtnGlobalDataProducts.ShowHelp"), Boolean))
        '
        'btnLoadOrdersGlobalData
        '
        resources.ApplyResources(Me.btnLoadOrdersGlobalData, "btnLoadOrdersGlobalData")
        Me.btnLoadOrdersGlobalData.Name = "btnLoadOrdersGlobalData"
        Me.HelpProvider1.SetShowHelp(Me.btnLoadOrdersGlobalData, CType(resources.GetObject("btnLoadOrdersGlobalData.ShowHelp"), Boolean))
        '
        'btnGlobalDataProcess
        '
        resources.ApplyResources(Me.btnGlobalDataProcess, "btnGlobalDataProcess")
        Me.btnGlobalDataProcess.Name = "btnGlobalDataProcess"
        Me.HelpProvider1.SetShowHelp(Me.btnGlobalDataProcess, CType(resources.GetObject("btnGlobalDataProcess.ShowHelp"), Boolean))
        '
        'frmMovieMaxInfo_Browse
        '
        resources.ApplyResources(Me, "$this")
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmMovieMaxInfo_Browse"
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
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtDateMovieMax.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateMovieMax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Const FILENAMEMOVIEMAX As String = "FEE0374-"
    Const FILENAMEGLABALDATA As String = "FEESHARING"
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    'Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    'Dim CurrentCodeType As String
    'Public WithEvents cmbLeverancier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    'Public Overrides Sub DeleteRecord(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim _Row As DataRow
    '    'Msg = 1 = Confirm Delete
    '    If MsgBox(BKGlobal.GetMsg(1, SessionInfo.UserLang), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        If ValidateBeforeDelete() Then
    '            Try
    '                _Row = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    '                'DeleteTranslations(TableName & "." & IDField, _Row(IDField))
    '                'DeleteComments(SessionInfo.EntityID, _Row(NameField))
    '                GridView1.DeleteRow(GridView1.FocusedRowHandle)
    '                Me.UpdateDataSet()
    '            Catch ex As Exception
    '                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
    '                MsgBox(ex.Message)
    '            End Try
    '        End If
    '    End If
    'End Sub
    'Private Function ValidateBeforeDelete() As Boolean
    '    Return True
    'End Function
    'Public Sub LoadBKComboSet()
    '    Try
    '        BKCombo.GetCombo(objDS, "feesharing_moviemax_leverancier", "leverancier", "SELECT * FROM feesharing_moviemax_leverancier")
    '    Catch ex As Exception
    '        DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'btnProcessMovieMax.Visible = False
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        Grid1.ContextMenuStrip = menuStrip

        txtDateMovieMax.EditValue = Date.Now




        Try
            'objDS = New dsFeeSharing
            'TableName = "feesharing_moviemax_input"
            'IDField = "products_id"
            'NameField = "title_name"
            'SQLTxt1 = "SELECT * FROM feesharing_moviemax_input "
            'WhereClause = "  "
            'OrderByClause = " "
            'MaintenanceMenuID = -1
            'CanNew = False
            'CanEdit = True
            'CanSave = True
            'CanDelete = True
            'txtYear.EditValue = Year(Now)
            'txtMonth.EditValue = Month(Now)
            'MyBase.StartUp()
            'CreateColumns()
            ' LoadBKComboSet()
            'Creatinf Midding Info
            'CreateMissingInfo()

            'GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            'GridView1.OptionsBehavior.Editable = True
            TabParameters.PageVisible = True
            TabAnalyse.PageVisible = False
            TabChart.PageVisible = False
            TabControl1.SelectedTabPage = TabParameters
        Catch eLoad As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, eLoad)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    'Public Sub CreateMissingInfo()
    '    Dim _SQLTxt As String = " select p.products_id, p.products_title from products p left join feesharing_moviemax_input f on p.products_id = f.products_id " & _
    '                            " where p.feesharing = 7 and f.products_id is null"
    '    Dim _DS As New DataSet 'dsFeeSharing
    '    _DS.Tables.Add("TmpTable")
    '     DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
    '    Dim _row, _newRow As DataRow
    '    For Each _row In _DS.Tables("TmpTable").Rows
    '        _newRow = objDS.Tables(TableName).NewRow
    '        _newRow("products_id") = _row("products_id")
    '        _newRow("title_name") = _row("products_title")
    '        _newRow("titelnr") = 0
    '        _newRow("maatschappij") = 0
    '        objDS.Tables(TableName).Rows.Add(_newRow)
    '    Next
    'End Sub

    Private Sub loadFeeSharingMovieMAx()
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsFeeSharing.getFeesharingMoviemax()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub

    'Public Sub CreateColumns()
    '    Me.cmbLeverancier = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    '    'Me.colproducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    '    'Me.coltitle_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    '    'Me.coltitelnr = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    '    'Me.colmaatschappij = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    '    Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLeverancier})
    '    '
    '    'cmbLeverancier
    '    '
    '    Me.cmbLeverancier.AutoHeight = False
    '    Me.cmbLeverancier.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
    '    Me.cmbLeverancier.DataSource = Me.objDS.Tables("feesharing_moviemax_leverancier")
    '    Me.cmbLeverancier.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Default
    '    Me.cmbLeverancier.Name = "cmbLeverancier"
    '    Me.cmbLeverancier.NullText = ""
    '    Me.cmbLeverancier.DisplayMember = "leverancier"
    '    Me.cmbLeverancier.ValueMember = "id"


    '    If Not IsNothing(GridView1.Columns("maatschappij")) Then
    '        GridView1.Columns("maatschappij").ColumnEdit = cmbLeverancier
    '    End If

    '    ''
    '    ''colproducts_id
    '    ''
    '    'Me.colproducts_id.Caption = "products_id"
    '    'Me.colproducts_id.Name = "colproducts_id"
    '    'Me.colproducts_id.Visible = True
    '    ''
    '    ''coltitle_name
    '    ''
    '    'Me.coltitle_name.Caption = Resources.GetString("coltitle_name.Caption")
    '    'Me.coltitle_name.CustomizationCaption = Resources.GetString("coltitle_name.CustomizationCaption")
    '    'Me.coltitle_name.ImageAlignment = CType(Resources.GetObject("coltitle_name.ImageAlignment"), System.Drawing.StringAlignment)
    '    'Me.coltitle_name.ImageIndex = CType(Resources.GetObject("coltitle_name.ImageIndex"), Integer)
    '    'Me.coltitle_name.Name = "coltitle_name"
    '    'Me.coltitle_name.ToolTip = Resources.GetString("coltitle_name.ToolTip")
    '    'Me.coltitle_name.Visible = CType(Resources.GetObject("coltitle_name.Visible"), Boolean)
    '    'Me.coltitle_name.Width = CType(Resources.GetObject("coltitle_name.Width"), Integer)
    '    ''
    '    ''coltitelnr
    '    ''
    '    'Me.coltitelnr.Caption = Resources.GetString("coltitelnr.Caption")
    '    'Me.coltitelnr.CustomizationCaption = Resources.GetString("coltitelnr.CustomizationCaption")
    '    'Me.coltitelnr.ImageAlignment = CType(Resources.GetObject("coltitelnr.ImageAlignment"), System.Drawing.StringAlignment)
    '    'Me.coltitelnr.ImageIndex = CType(Resources.GetObject("coltitelnr.ImageIndex"), Integer)
    '    'Me.coltitelnr.Name = "coltitelnr"
    '    'Me.coltitelnr.ToolTip = Resources.GetString("coltitelnr.ToolTip")
    '    'Me.coltitelnr.Visible = CType(Resources.GetObject("coltitelnr.Visible"), Boolean)
    '    'Me.coltitelnr.Width = CType(Resources.GetObject("coltitelnr.Width"), Integer)
    '    ''
    '    ''colmaatschappij
    '    ''
    '    'Me.colmaatschappij.Caption = Resources.GetString("colmaatschappij.Caption")
    '    'Me.colmaatschappij.CustomizationCaption = Resources.GetString("colmaatschappij.CustomizationCaption")
    '    'Me.colmaatschappij.ImageAlignment = CType(Resources.GetObject("colmaatschappij.ImageAlignment"), System.Drawing.StringAlignment)
    '    'Me.colmaatschappij.ImageIndex = CType(Resources.GetObject("colmaatschappij.ImageIndex"), Integer)
    '    'Me.colmaatschappij.Name = "colmaatschappij"
    '    'Me.colmaatschappij.ToolTip = Resources.GetString("colmaatschappij.ToolTip")
    '    'Me.colmaatschappij.Visible = CType(Resources.GetObject("colmaatschappij.Visible"), Boolean)
    '    'Me.colmaatschappij.Width = CType(Resources.GetObject("colmaatschappij.Width"), Integer)

    'End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessMovieMax.Click
        Dim cls As New DVDPostBuziness.feesharing()
        Dim strOuput As String
        Dim processOk As Boolean
        Dim dateMoviemax As Date


        dateMoviemax = txtDateMovieMax.EditValue

        Try
            SaveFileDialog1.FileName = FILENAMEMOVIEMAX & dateMoviemax.Year & "-" & Format(dateMoviemax.Month, "00") & ".txt"
            'SaveFileDialog1.ShowDialog()

            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then

                processOk = cls.processMovieMax()

                If processOk = False Then
                    MsgBox("MovieMax Data Info exist with TitelNr = 0")
                    Exit Sub
                End If
                strOuput = cls.BatchMovieMax(dateMoviemax)

                Dim okWrite As Boolean = DVDPostTools.clsFile.WriteFile(SaveFileDialog1.FileName, strOuput)
                If okWrite = False Then
                    MsgBox("the file is not record")
                End If

            End If
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
        End Try

        'processMovieMax()

        ''Dim ConnectionString As String = ConfigurationSettings.AppSettings("ConnectionString")
        ''Dim MyConnection = New OdbcConnection(ConnectionString)
        'Dim sSQL As String
        ''Dim mycommand As OdbcCommand
        ''Dim dr As OdbcDataReader
        ''Dim MyConnection2 = New OdbcConnection(ConnectionString)
        'Dim sSQL2 As String
        ''Dim mycommand2 As OdbcCommand
        ''Dim dr2 As OdbcDataReader
        ''Dim MyConnection3 = New OdbcConnection(ConnectionString)
        'Dim sSQL3 As String
        ''Dim mycommand3 As OdbcCommand
        ''Dim dr3 As OdbcDataReader
        'Dim _ds As New dsFeeSharing

        'Dim strtitelnr As String
        'Dim strdvd_id As String
        'Dim intmaatschappij As Integer
        'Dim strfield6 As String = ""
        'Dim strtime As String
        'Dim i As Integer
        'Dim _row, _row2, _row3 As DataRow

        'If IsNothing(_ds.Tables("orders_products")) Then
        '    _ds.Tables.Add("orders_products")
        'Else
        '    _ds.Tables("orders_products").Clear()
        'End If

        '_ds.Tables("feesharing_moviemax_leverancier").Clear()
        'sSQL3 = "SELECT * FROM feesharing_moviemax_leverancier"
        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("feesharing_moviemax_leverancier"), sSQL3)

        'sSQL3 = "SELECT * FROM feesharing_moviemax_input  "
        '_ds.Tables("feesharing_moviemax_input").Clear()
        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("feesharing_moviemax_input"), sSQL3)


        ''MyConnection.Open()
        ''mycommand = MyConnection.createcommand

        ''MyConnection2.Open()
        ''mycommand2 = MyConnection2.createcommand

        ''MyConnection3.Open()
        ''mycommand3 = MyConnection3.createcommand

        'sSQL = "SELECT * FROM products where feesharing = 7 order by products_id"
        '_ds.Tables("products").Clear()
        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("products"), sSQL)
        ''mycommand.CommandText = sSQL
        ''dr = mycommand.ExecuteReader
        ''Do Until Not dr.Read
        'ProgressBarControl1.Properties.Minimum = 0
        'ProgressBarControl1.Properties.Maximum = _ds.Tables("products").Rows.Count + 1
        'ProgressBarControl1.EditValue = 0
        'ProgressBarControl1.Visible = True
        'For Each _row In _ds.Tables("products").Rows
        '    ProgressBarControl1.EditValue += 1
        '    ProgressBarControl1.Refresh()
        '    _ds.Tables("orders_products").Clear()
        '    sSQL2 = "SELECT orders_products_id, products_dvd, date_purchased FROM orders_products op " & _
        '            " left join orders o on  o.orders_id = op.orders_id left join products p " & _
        '            " on op.products_id = p.products_id  WHERE p.feesharing = 7 and o.orders_status <> 9 and op.feesharing = 0 " & _
        '            " and o.date_purchased <  p.feesharing_end AND op.products_id = '" & _row("products_id") & "'"
        '    'mycommand2.CommandText = sSQL2
        '    'dr2 = mycommand2.ExecuteReader
        '     DvdPostData.clsConnection.FillDataSet(_ds.Tables("orders_products"), sSQL2)
        '    'Do Until Not dr2.Read
        '    For Each _row2 In _ds.Tables("orders_products").Rows
        '        strtitelnr = ""
        '        strdvd_id = ""
        '        intmaatschappij = 0
        '        strtime = ""
        '        i = i + 1
        '        strtime = i

        '        If _row2("products_dvd") < 10 Then
        '            strdvd_id = "00" & _row2("products_dvd")
        '        End If
        '        If _row2("products_dvd") > 9 And _row2("products_dvd") < 100 Then
        '            strdvd_id = "0" & _row2("products_dvd")
        '        End If
        '        If _row2("products_dvd") > 99 And _row2("products_dvd") < 1000 Then
        '            strdvd_id = _row2("products_dvd")
        '        End If



        '        'sSQL3 = "SELECT * FROM feesharing_moviemax_input  where  products_id= '" & _row("products_id") & "' "
        '        '_ds.Tables("feesharing_moviemax_input").Clear()
        '        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("feesharing_moviemax_input"), sSQL3)
        '        _row3 = _ds.Tables("feesharing_moviemax_input").Rows.Find(New Object() {_row("products_id")})
        '        'mycommand3.CommandText = sSQL3
        '        'dr3 = mycommand3.ExecuteReader
        '        'Do Until Not dr3.Read
        '        'For Each _row3 In _ds.Tables("feesharing_moviemax_input").Rows
        '        If Not IsNothing(_row3) Then
        '            strtitelnr = _row3("titelnr")
        '            intmaatschappij = _row3("maatschappij")
        '        End If
        '        'Next
        '        'Loop
        '        'dr3.Close()
        '        '_ds.Tables("feesharing_moviemax_leverancier").Clear()
        '        'sSQL3 = "SELECT * FROM feesharing_moviemax_leverancier    where   id= '" & intmaatschappij & "' "
        '        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("feesharing_moviemax_leverancier"), sSQL3)
        '        _row3 = _ds.Tables("feesharing_moviemax_leverancier").Rows.Find(New Object() {intmaatschappij})
        '        'mycommand3.CommandText = sSQL3
        '        'dr3 = mycommand3.ExecuteReader
        '        'Do Until Not dr3.Read
        '        'For Each _row3 In _ds.Tables("feesharing_moviemax_leverancier").Rows
        '        Dim _pct As Integer = 0
        '        If Not IsNothing(_row3) Then
        '            _pct = _row3("percentage")
        '            Select Case _pct
        '                Case 35
        '                    If DateDiff(DateInterval.Month, _row2("date_purchased"), _row("products_date_available")) < 3 Then
        '                        strfield6 = "   2.86"
        '                    Else
        '                        strfield6 = "   2.00"
        '                    End If
        '                Case 40
        '                    If DateDiff(DateInterval.Month, _row2("date_purchased"), _row("products_date_available")) < 3 Then
        '                        strfield6 = "   2.50"
        '                    Else
        '                        strfield6 = "   1.75"
        '                    End If
        '                Case 42
        '                    If DateDiff(DateInterval.Month, _row2("date_purchased"), _row("products_date_available")) < 3 Then
        '                        strfield6 = "   2.38"
        '                    Else
        '                        strfield6 = "   1.67"
        '                    End If
        '            End Select
        '        End If
        '        'Next
        '        'Loop

        '        sSQL3 = "insert into feesharing_moviemax_output ( field1 ,field2 ,date ,time , titlenr , field6 , field7 ,field8 , field9) values " & _
        '                " ('0001', '0374', '" & Year(_row2("date_purchased")) & "-" & Month(_row2("date_purchased")) & "-" & _
        '                DateAndTime.Day(_row2("date_purchased")) & "', '" & strtime & "', '" & strtitelnr & "', '" & _
        '                strfield6 & "', '1', '374" & strtitelnr & strdvd_id & "', 'D')"
        '        DvdPostData.clsConnection.ExecuteNonQuery(sSQL3)

        '        sSQL3 = "update orders_products set feesharing = 1 where orders_products_id =  '" & _row2("orders_products_id") & "'"
        '        DvdPostData.clsConnection.ExecuteNonQuery(sSQL3)

        '        'Loop
        '    Next

        '    'Loop
        'Next
        'ProgressBarControl1.Visible = False
        'MsgBox("Process Completed", MsgBoxStyle.Information)
    End Sub


    'by Gauthier
    'Private Sub processMovieMax()
    '    Dim dt As DataTable
    '    Dim sql As String = DvdPostData.clsFeeSharing.getFeeSharingMovieMax()
    '    Dim sqlValue As String
    '    Dim sqlInsert As String
    '    Dim dr As DataRow
    '    Dim valueInsert As String = String.Empty
    '    Dim strTime As Integer = 0
    '    Dim titelnr As Integer
    '    Dim orders_products_id As Integer
    '    Dim productsDvdId As Integer
    '    Dim rate As String
    '    Dim updateValues As String = String.Empty
    '    Dim updateSql As String
    '    Dim ok As Boolean

    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    ok = CheckValidMovieMaxInfo(dt)
    '    If ok = False Then
    '        Exit Sub
    '    End If

    '    For Each dr In dt.Rows
    '        orders_products_id = dr("orders_products_id")
    '        titelnr = dr("titelnr")
    '        rate = calculRate(dr("percentage"), dr("date_purchased"), dr("products_date_available"))
    '        productsDvdId = GetproductsDvdIdMovieMax(dr("products_dvd"))
    '        sqlValue = DvdPostData.clsFeeSharing.getInsertValue(dr("date_purchased"), strTime, titelnr, rate, productsDvdId)


    '        If valueInsert.Length > 0 Then
    '            valueInsert += "," & sqlValue
    '            updateValues += "," & orders_products_id
    '        Else
    '            valueInsert = sqlValue
    '            updateValues = orders_products_id
    '        End If
    '        strTime = strTime + 1


    '        If strTime Mod 200 = 0 Then
    '            sqlInsert = DvdPostData.clsFeeSharing.getFeeSharingMovieMax(valueInsert)
    '            'DvdPostData.clsConnection.ExecuteNonQuery(sqlInsert)
    '            valueInsert = String.Empty


    '        End If

    '    Next

    '    If valueInsert.Length > 0 Then
    '        sqlInsert = DvdPostData.clsFeeSharing.GetInsertMovieMaxOut(valueInsert)
    '        'DvdPostData.clsConnection.ExecuteNonQuery(sqlInsert)
    '        valueInsert = String.Empty

    '        updateSql = DvdPostData.clsFeeSharing.updateOdersProductsFee(updateValues, DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX)
    '        'DvdPostData.clsConnection.ExecuteNonQuery(updateValues)
    '        updateValues = String.Empty
    '    End If
    'End Sub


    'by Gauthier
    'Private Function calculRate(ByVal pct As Integer, ByVal date_purchased As DateTime, ByVal products_date_available As DateTime) As String

    '    Dim rate As String
    '    Dim intervalDate As Integer = DateDiff(DateInterval.Month, date_purchased, products_date_available)

    '    Select Case pct
    '        Case 35
    '            If intervalDate < 3 Then
    '                rate = "   2.86"
    '            Else
    '                rate = "   2.00"
    '            End If


    '        Case 40
    '            If intervalDate < 3 Then
    '                rate = "   2.50"
    '            Else
    '                rate = "   1.75"
    '            End If


    '        Case 42
    '            If intervalDate < 3 Then
    '                rate = "   2.38"
    '            Else
    '                rate = "   1.67"
    '            End If
    '    End Select

    '    Return rate
    'End Function

    'by Gauthier
    'Private Function GetproductsDvdIdMovieMax(ByVal products_dvdid As String) As String
    '    Dim productsDvdId As String
    '    productsDvdId = products_dvdid.PadLeft(4, "0")

    '    Return productsDvdId
    'End Function


    Private Sub btnCreateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim sSQL As String
        'Dim _ds As New DataSet
        '_ds.Tables.Add("feesharing_moviemax_output")
        'Dim _row As DataRow
        'Dim stroutput As String

        'Dim _FileStream As StreamWriter

        'If txtOutputFile.EditValue & "" = "" Then
        '    MsgBox("Output file is not specified", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        'If File.Exists(txtOutputFile.EditValue) = False Then
        '    File.Delete(txtOutputFile.EditValue)
        'End If
        '_FileStream = File.CreateText(txtOutputFile.EditValue)

        'sSQL = "SELECT * FROM feesharing_moviemax_output where  Year(date) = " & CInt(txtYear.EditValue) & " and Month(date) = " & txtMonth.EditValue & " "
        ''sSQL = "SELECT * FROM feesharing_moviemax_output  "
        ' DvdPostData.clsConnection.FillDataSet(_ds.Tables("feesharing_moviemax_output"), sSQL)
        ''mycommand.CommandText = sSQL
        ''dr = mycommand.ExecuteReader
        ''Do Until Not dr.Read
        'ProgressBarControl1.Properties.Minimum = 0
        'ProgressBarControl1.Properties.Maximum = _ds.Tables("feesharing_moviemax_output").Rows.Count + 1
        'ProgressBarControl1.EditValue = 0
        'ProgressBarControl1.Visible = True
        'For Each _row In _ds.Tables("feesharing_moviemax_output").Rows
        '    ProgressBarControl1.EditValue += 1
        '    ProgressBarControl1.Refresh()
        '    stroutput = ""
        '    stroutput = stroutput & ControlChars.Quote & _row("field1") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("field2") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & Year(_row("date"))
        '    If Month(_row("date")) < 10 Then
        '        stroutput = stroutput & "0" & Month(_row("date"))
        '    Else
        '        stroutput = stroutput & Month(_row("date"))
        '    End If
        '    If DateAndTime.Day(_row("date")) < 10 Then
        '        stroutput = stroutput & "0" & DateAndTime.Day(_row("date")) & ControlChars.Quote & ","
        '    Else
        '        stroutput = stroutput & DateAndTime.Day(_row("date")) & ControlChars.Quote & ","
        '    End If
        '    stroutput = stroutput & ControlChars.Quote & _row("time").ToString & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("titlenr") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("field6") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("field7") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("field8") & ControlChars.Quote & ","
        '    stroutput = stroutput & ControlChars.Quote & _row("field9") & ControlChars.Quote
        '    'stroutput = stroutput & ControlChars.CrLf
        '    _FileStream.WriteLine(stroutput)
        '    'Loop
        'Next
        '_FileStream.Close()
        'ProgressBarControl1.Visible = False
        'MsgBox("Process Completed", MsgBoxStyle.Information)

        'BatchMovieMax()

    End Sub


    'by Gauthier
    'Private Sub BatchMovieMax()
    '    Dim dt As DataTable
    '    Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxOutPut(Date.Now.Year, Date.Now.Month)
    '    Dim dr As DataRow
    '    Dim outPut As String = String.Empty
    '    Dim ok As Boolean

    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    For Each dr In dt.Rows
    '        outPut = outPut & ControlChars.Quote & dr("field1") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("field2") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & Year(dr("date"))
    '        If Month(dr("date")) < 10 Then
    '            outPut = outPut & "0" & Month(dr("date"))
    '        Else
    '            outPut = outPut & Month(dr("date"))
    '        End If
    '        If DateAndTime.Day(dr("date")) < 10 Then
    '            outPut = outPut & "0" & DateAndTime.Day(dr("date")) & ControlChars.Quote & ","
    '        Else
    '            outPut = outPut & DateAndTime.Day(dr("date")) & ControlChars.Quote & ","
    '        End If
    '        outPut = outPut & ControlChars.Quote & dr("time").ToString & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("titlenr") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("field6") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("field7") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("field8") & ControlChars.Quote & ","
    '        outPut = outPut & ControlChars.Quote & dr("field9") & ControlChars.Quote
    '    Next

    '    SaveFileDialog1.FileName = "FEE0374-" & Date.Now.Year & "-" & Format(Date.Now.Month, "00") & ".txt"
    '    SaveFileDialog1.ShowDialog()




    '    ok = DVDPostTools.clsFile.WriteFile(SaveFileDialog1.FileName, outPut)
    '    If ok = True Then
    '        MsgBox(" ok ")
    '    End If


    'End Sub





    'Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
    '    If TabControl1.SelectedTabPage.Name = "TabParameters" Then
    '        'CheckValidMovieMaxInfo()
    '    End If
    'End Sub
    'Public Sub CheckValidMovieMaxInfo()
    '    Dim _view As New DataView(objDS.Tables(TableName), "titelnr = 0 ", "", DataViewRowState.CurrentRows)
    '    If _view.Count > 0 Then
    '        btnProcess.Enabled = False
    '        lblWarning.Text = "MovieData Info exist with TitelNr = 0"
    '        lblWarning.Visible = True
    '    Else
    '        btnProcess.Enabled = True
    '        lblWarning.Visible = False
    '        lblWarning.Text = ""
    '    End If
    'End Sub

    'by Gauthier
    'Private Function CheckValidMovieMaxInfo(ByVal dt As DataTable) As Boolean
    '    Dim ok As Boolean
    '    Dim view As New DataView(dt, "titelnr = 0 ", "", DataViewRowState.CurrentRows)
    '    If view.Count > 0 Then
    '        ok = False
    '    Else
    '        ok = True
    '    End If

    '    Return ok
    'End Function
    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
    '    SaveFileDialog1.FileName = "FEE0374-" & txtYear.EditValue & "-" & Format(txtMonth.EditValue, "00") & ".txt"
    '    SaveFileDialog1.ShowDialog()
    '    txtOutputFile.EditValue = SaveFileDialog1.FileName
    'End Sub


    Private Sub btnGlobalDataProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobalDataProcess.Click
        'Dim fB As New Windows.Forms.FolderBrowserDialog
        Dim str As String
        Dim feesharing As New DVDPostBuziness.feesharing


        'fB.RootFolder = Environment.SpecialFolder.Desktop
        'fB.Description = "Choose a folder"
        'fB.ShowDialog()

        'If fB.SelectedPath = String.Empty Then
        '    MsgBox("Pas de sélection")
        '    Exit Sub
        'End If

        Try
            SaveFileDialog1.FileName = FILENAMEGLABALDATA & "_" & Date.Now.Year & "_" & Format(Date.Now.Month, "00") & ".txt"

            If (SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                str = feesharing.batchFeeSharing()

                If str = String.Empty Then
                    MsgBox("there are no orders In feesharing Global Data")
                    Exit Sub
                End If

                Dim okWrite As Boolean = DVDPostTools.clsFile.WriteFile(SaveFileDialog1.FileName, str)
                If okWrite = False Then
                    MsgBox("the file is not record")
                End If
            End If
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Feesharing, ex)
        End Try
    End Sub

    Private Sub btnMovieMAx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieMAx.Click
        loadFeeSharingMovieMAx()
        'TabControl1.SelectedTabPage = TabResult
    End Sub

    Private Sub btnLoadOrdersGlobalData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrdersGlobalData.Click
        LoadOrdersGlobalData()
    End Sub
    Private Sub BtnGlobalDataProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGlobalDataProducts.Click
        loadProductsGlobalData()
    End Sub
    Private Sub btnLoadOrdersMoviemax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOrdersMoviemax.Click
        loadOrdersMovieMax()
    End Sub
    Public Sub GridDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If GridView1.RowCount <> 0 Then
            Dim productsId As Integer
            Dim frm As New frmDVD_Maint(SessionInfo)

            Dim params As DVDPostBuziness.clsSingleton = Nothing
            params = DVDPostBuziness.clsSingleton.Instance()


            productsId = GridView1.GetDataRow(GridView1.FocusedRowHandle())("products_id")

            params.Products_dvd_id = productsId

            frm.Show(Me)
        End If
    End Sub




    Private Sub LoadGrid(ByVal dt As DataTable)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()
        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
    End Sub
    Private Sub LoadOrdersGlobalData()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsFeeSharing.getOrdersInFeeSharing()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub
    Private Sub loadProductsGlobalData()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsFeeSharing.GetProductsGlobalData()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub

    Private Sub loadOrdersMovieMax()
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsFeeSharing.getFeeSharingMovieMaxProccess()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        LoadGrid(dt)
    End Sub


End Class
