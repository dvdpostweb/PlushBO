Imports System.IO
Imports System.Collections.Generic
Imports PlushData
Imports PlushBuziness

Public Class frmPayPerViewMaint
    Inherits BizzLib.frmBKForm

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
        CHOOSEVOD
        DETAILED
    End Enum

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSearch.OptionsView.ColumnAutoWidth = False
        GridViewSearch.OptionsBehavior.Editable = False

        TabPPVMaint.SelectedTabPage = TabSearch
        ' Misc_Bar.Visible = True

        Misc_Bar.Visible = True
        Dim menuStrip As New PlushBuziness.contextMenu()
        GridPPV.ContextMenuStrip = menuStrip
        txtFromDate.DateTime = Nothing 'Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Nothing 'Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        dtSearchFrom.DateTime = Nothing 'Now().ToString(dtSearchFrom.Properties.EditFormat.FormatString)
        dtSearchTo.DateTime = Nothing 'Now().ToString(dtSearchTo.Properties.EditFormat.FormatString)

        LoadSearchCountries()
        LoadCountries()

    End Sub

    Private Sub LoadCountries()

        Dim dt As DataTable = New DataTable
        dt.Columns.Add("id", Type.GetType("System.Int32"))
        dt.Columns.Add("country", Type.GetType("System.String"))

        Dim dr As DataRow = dt.NewRow()
        dr(0) = PlushData.ClsCustomersData.Country.BELGIUM
        dr(1) = "Belgium"

        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = PlushData.ClsCustomersData.Country.NEDERLANDS
        dr(1) = "NeatherLand"

        dt.Rows.Add(dr)

        dt.AcceptChanges()

        cmbCountry.Properties.ValueMember = "id"
        cmbCountry.Properties.DisplayMember = "country"
        cmbCountry.Properties.DataSource = dt
    End Sub

    Private Sub LoadSearchCountries()

        Dim dt As DataTable = New DataTable
        dt.Columns.Add("id", Type.GetType("System.Int32"))
        dt.Columns.Add("country", Type.GetType("System.String"))

        Dim dr As DataRow = dt.NewRow()
        dr(0) = PlushData.ClsCustomersData.Country.BELGIUM
        dr(1) = "Belgium"

        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = PlushData.ClsCustomersData.Country.NEDERLANDS
        dr(1) = "NeatherLand"

        dt.Rows.Add(dr)

        dt.AcceptChanges()

        cmbSearchCountry.Properties.ValueMember = "id"
        cmbSearchCountry.Properties.DisplayMember = "country"
        cmbSearchCountry.Properties.DataSource = dt
    End Sub

    Private Sub TextEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPPVFolder.Click
        'OFDFilePPV.Filter = "csv|*.csv|text|*.txt"
        'OFDFilePPV.ShowDialog()
        'txtPPVFolder.Text = OFDFilePPV.FileName
        FolderBrowserDialog.ShowDialog()
        txtPPVFolder.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim sql As String
        Dim dt As DataTable = Nothing

        sql = " select c.customers_id, p.products_title, t.imdb_id, t.created_at, t.is_ppv, t.ppv_price amount from " & _
                " tokens t join customers c on t.customer_id = c.customers_id " & _
                " join products p on p.imdb_id = t.imdb_id where t.is_ppv = 1 "

        If cmbSearchCountry.Text <> String.Empty Then
            sql = sql & " and c.EntityID = " & cmbSearchCountry.EditValue
        End If
        If txtSearch_imdb_id.Text <> String.Empty Then
            sql = sql & " and t.imdb_id = " & txtSearch_imdb_id.Text
        End If
        If dtSearchFrom.DateTime <> Nothing Then
            sql = sql & " and t.created_at >= '" & PlushTools.ClsDate.formatDate(dtSearchFrom.EditValue) & "' "
        End If
        If dtSearchTo.DateTime <> Nothing Then
            sql = sql & " and t.created_at < '" & PlushTools.ClsDate.formatDate(dtSearchTo.EditValue) & "' "
        End If

        sql = sql & " group by c.customers_id, p.products_title, t.imdb_id, t.created_at"

        dt = PlushData.clsConnection.FillDataSet(sql)
        If Not dt Is Nothing Then
            GridPPV.DataSource = dt
            TabPPVMaint.SelectedTabPage = TabResult
        End If

    End Sub

    Private Sub btnCreateSummaryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSummaryReport.Click
        Dim clsPPV As clsPPV = New clsPPV
        If txtFromDate.DateTime = Nothing Or txtToDate.DateTime = Nothing Then
            System.Windows.Forms.MessageBox.Show("Country, 'FromDate' and ToDate' should be set !")
            Return
        End If
        clsPPV.CreatePPVPaymentsManager(cmbCountry.EditValue, txtFromDate.EditValue, txtToDate.EditValue, txtPPVFolder.Text)

    End Sub
End Class