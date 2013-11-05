Imports System.Windows.Forms.Application
Imports SSH
Imports System.Collections.Generic
Public Class frmABOProcessPerStep_type
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnLoadInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCustResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridViewCust As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents DS As DVDPostLib.dsABOProcess
    'Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_home_norm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_home_adult As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_dvd_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_rank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_multishipment As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents coluse_credit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colthrottling As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colcustomers_abo_suspended As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNormToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colAdultToSend As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNormAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colAdultAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colInNeed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNotServed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNotEnoughtCredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colNoDVDFound As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    'Friend WithEvents colTooManyAtHome As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnStartABO2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbTheme_event As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblProduct_list As DevExpress.XtraEditors.LabelControl
    Friend WithEvents progressBar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents GridAboprocess As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAboprocess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents chkActiveTheme As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.btnLoadInfo = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.progressBar = New DevExpress.XtraEditors.ProgressBarControl
        Me.GridAboprocess = New DevExpress.XtraGrid.GridControl
        Me.GridViewAboprocess = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.chkActiveTheme = New DevExpress.XtraEditors.CheckEdit
        Me.lblProduct_list = New DevExpress.XtraEditors.LabelControl
        Me.cmbTheme_event = New DevExpress.XtraEditors.LookUpEdit
        Me.btnStartABO2 = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridCustResult = New DevExpress.XtraGrid.GridControl
        Me.GridViewCust = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DS = New DVDPostLib.dsABOProcess
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAboprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewAboprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActiveTheme.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTheme_event.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadInfo
        '
        Me.btnLoadInfo.Location = New System.Drawing.Point(160, 58)
        Me.btnLoadInfo.Name = "btnLoadInfo"
        Me.btnLoadInfo.Size = New System.Drawing.Size(168, 37)
        Me.btnLoadInfo.TabIndex = 25
        Me.btnLoadInfo.Text = "LOAD"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1221, 408)
        Me.XtraTabControl1.TabIndex = 36
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "TabControlABO"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.progressBar)
        Me.XtraTabPage1.Controls.Add(Me.GridAboprocess)
        Me.XtraTabPage1.Controls.Add(Me.chkActiveTheme)
        Me.XtraTabPage1.Controls.Add(Me.lblProduct_list)
        Me.XtraTabPage1.Controls.Add(Me.cmbTheme_event)
        Me.XtraTabPage1.Controls.Add(Me.btnStartABO2)
        Me.XtraTabPage1.Controls.Add(Me.btnLoadInfo)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1212, 377)
        Me.XtraTabPage1.Text = "Parameters / Process"
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(147, 101)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(687, 18)
        Me.progressBar.TabIndex = 78
        '
        'GridAboprocess
        '
        Me.GridAboprocess.EmbeddedNavigator.Name = ""
        Me.GridAboprocess.FormsUseDefaultLookAndFeel = False
        Me.GridAboprocess.Location = New System.Drawing.Point(7, 133)
        Me.GridAboprocess.MainView = Me.GridViewAboprocess
        Me.GridAboprocess.Name = "GridAboprocess"
        Me.GridAboprocess.Size = New System.Drawing.Size(943, 174)
        Me.GridAboprocess.TabIndex = 77
        Me.GridAboprocess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAboprocess})
        '
        'GridViewAboprocess
        '
        Me.GridViewAboprocess.GridControl = Me.GridAboprocess
        Me.GridViewAboprocess.Name = "GridViewAboprocess"
        Me.GridViewAboprocess.OptionsView.ColumnAutoWidth = False
        Me.GridViewAboprocess.OptionsView.ShowFooter = True
        '
        'chkActiveTheme
        '
        Me.chkActiveTheme.Location = New System.Drawing.Point(577, 36)
        Me.chkActiveTheme.Name = "chkActiveTheme"
        Me.chkActiveTheme.Properties.Caption = "UNLOCK"
        Me.chkActiveTheme.Size = New System.Drawing.Size(75, 19)
        Me.chkActiveTheme.TabIndex = 76
        '
        'lblProduct_list
        '
        Me.lblProduct_list.Location = New System.Drawing.Point(536, 62)
        Me.lblProduct_list.Name = "lblProduct_list"
        Me.lblProduct_list.Size = New System.Drawing.Size(30, 13)
        Me.lblProduct_list.TabIndex = 75
        Me.lblProduct_list.Text = "theme"
        '
        'cmbTheme_event
        '
        Me.cmbTheme_event.Enabled = False
        Me.cmbTheme_event.Location = New System.Drawing.Point(578, 59)
        Me.cmbTheme_event.Name = "cmbTheme_event"
        Me.cmbTheme_event.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTheme_event.Properties.DisplayMember = "name"
        Me.cmbTheme_event.Properties.NullText = ""
        Me.cmbTheme_event.Properties.ValueMember = "id"
        Me.cmbTheme_event.Size = New System.Drawing.Size(151, 20)
        Me.cmbTheme_event.TabIndex = 74
        '
        'btnStartABO2
        '
        Me.btnStartABO2.Location = New System.Drawing.Point(356, 58)
        Me.btnStartABO2.Name = "btnStartABO2"
        Me.btnStartABO2.Size = New System.Drawing.Size(167, 37)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnStartABO2.SuperTip = SuperToolTip1
        Me.btnStartABO2.TabIndex = 43
        Me.btnStartABO2.Text = "START"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridCustResult)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1212, 377)
        Me.XtraTabPage2.Text = "Customers Result"
        '
        'GridCustResult
        '
        Me.GridCustResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustResult.EmbeddedNavigator.Name = ""
        Me.GridCustResult.FormsUseDefaultLookAndFeel = False
        Me.GridCustResult.Location = New System.Drawing.Point(0, 0)
        Me.GridCustResult.MainView = Me.GridViewCust
        Me.GridCustResult.Name = "GridCustResult"
        Me.GridCustResult.Size = New System.Drawing.Size(1212, 377)
        Me.GridCustResult.TabIndex = 0
        Me.GridCustResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCust, Me.GridView1})
        '
        'GridViewCust
        '
        Me.GridViewCust.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewCust.FooterPanelHeight = 2
        Me.GridViewCust.GridControl = Me.GridCustResult
        Me.GridViewCust.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridViewCust.Name = "GridViewCust"
        Me.GridViewCust.OptionsView.ShowBands = False
        Me.GridViewCust.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1735
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridCustResult
        Me.GridView1.Name = "GridView1"
        '
        'DS
        '
        Me.DS.DataSetName = "dsABOProcess"
        Me.DS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmABOProcessPerStep_type
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1221, 438)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmABOProcessPerStep_type"
        Me.Text = "ABO Process"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAboprocess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewAboprocess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActiveTheme.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTheme_event.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridCustResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim SQLCustomers As String
    Dim SQLProducts_DVD As String
    Dim SQLWishList As String
    Dim SQLCompensation As String

    Dim _CustView As DataView

    Dim _MaxDVDSendByCustomers As Integer
    Dim _ProductView As DataView
    Dim _WLSerieViewAll As DataView
    Dim _WLSerieViewFiltered As DataView
    Dim _ProductRow As DataRowView
    Dim _ProductRows() As DataRowView
    Dim _DicoProducts As New Dictionary(Of String, String)

    Dim _IsDVDFound As Boolean
    Dim _IsCompensation As Boolean
    Dim _PRoductType As String = ""

    Dim _FilterCustomer As String = "IsCompensation desc,customers_abo_rank desc,time_average asc, customers_id "
    Dim _FilterSeries As String = "imdb_id_serie,products_series_id, products_series_number,priority,date_added"
    Dim _FilterQty As String = "priority,theme desc,qty_in_stock "
    Dim _i As Integer = 0
    Dim dateStart As DateTime


    Dim _AboProcessSql As DvdPostData.AboProcessData
    Dim _AboStat As DVDPostBuziness.clsAboprocessStat

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub frmABOProcessPerStep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridCustResult.ContextMenuStrip = menuStrip

        DS.Tables.Add("products_dvd")
        _AboProcessSql = New DvdPostData.AboProcessData()
        loadTheme()
        _AboStat = New DVDPostBuziness.clsAboprocessStat()

    End Sub
    Private Sub loadTheme()
        Dim sql As String

        Dim dt As DataTable

        sql = _AboProcessSql.GetSqlListTheme_event()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        cmbTheme_event.Properties.DataSource = dt
    End Sub
    Private Sub cleanTable()
        DS.Tables("customers").Clear()
        DS.Tables("products_dvd").Clear()
        DS.Tables("wishlist").Clear()
    End Sub


    Private Sub deleteProducts(ByRef customer As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByRef wishlist As DataTable, ByVal imdb_id As Long, ByVal products_id As Integer, ByVal isSerie As Boolean)

        Dim dv As DataView = Nothing
        If isSerie Then
            dv = New DataView(wishlist, "imdb_id_serie = " & imdb_id, "", DataViewRowState.CurrentRows)
        Else
            If Not wishlist Is Nothing Then
                dv = New DataView(wishlist, "products_id = " & products_id, "", DataViewRowState.CurrentRows)
            End If
        End If

        If Not dv Is Nothing Then
            For Each drv As DataRowView In dv
                wishlist.Rows.Remove(drv.Row)
                customer.statSend.dvd_Find -= 1

            Next
        End If
    End Sub
    Private Function AssignDVDStepByType(ByRef customer As DVDPostBuziness.clsCustomer_Stat_TypeDVD, _
                                         ByVal iscompensation As Boolean, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean
        Dim served As Boolean = False
        Dim index As Integer = 0
        Dim dr As DataRow = Nothing
        Dim drvproduct As DataRowView
        Dim isIllimitedAbo As Boolean
        ' logiquement on recoit les series dans l'ordre 
        Try
            DvdPostData.clsConnection.CreateTransaction(False)
            While Not served And customer.dt_wishlist.Rows.Count > 0

                dr = customer.dt_wishlist.Rows(index)

                drvproduct = GetProductAvailable(dr("products_id"))
                If dr.RowState = DataRowState.Deleted Then
                    Continue While
                End If
                If drvproduct Is Nothing Then
                    deleteProducts(customer, customer.dt_wishlist, dr("imdb_id_serie"), dr("products_id"), IsSerieDVD(dr))

                    ' plus de copie => supprimer de toutes le wishlist toutes la series
                Else
                    '   Dim key As String = dr("products_id") & " - " & drvproduct("products_dvdid")
                    '   If Not _DicoProducts.ContainsKey(key) Then
                    '  _DicoProducts.Add(key, key)
                    isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(dr("customers_id"))
                    AssignDVD(isIllimitedAbo, iscompensation, dr("wl_id"), dr("products_id"), dr("customers_id"), drvproduct("products_dvdid"), DvdPostData.ClsCustomersData.OrdersType.ABOPROCESS)
                    LockDVDProduct(dr("products_id"))
                    StatAddDvdSend(customer, type_dvd, dr("priority"), iscompensation)
                    dr.Delete()
                    served = True
                    '    Else
                    '     MsgBox("doublon", MsgBoxStyle.Critical)
                    '   End If
                End If

            End While
            DvdPostData.clsConnection.CommitTransaction(True)
            Return served

        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Abo_Process, ex, dr("customers_id"))
            Return False
        End Try
    End Function
    Private Sub assignationStepByType(ByRef customer As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)
        Dim compensation As Boolean
        Dim served As Boolean
        If customer.statSend.dvd_send > 0 And Not customer.stop_process Then
            compensation = customer.statSend.dvd_compensation > 0

            served = AssignDVDStepByType(customer, compensation, type_dvd)
            If served Then
                If compensation Then
                    customer.nb_compensation -= 1
                Else
                    If Not customer.statSend.IllimitedCredit Then
                        customer.statSend.credit -= 1
                        'If customer.statSend Then
                        customer.statSend.remaindvd -= 1 ' ovo je npp
                    End If
                End If
                customer.nb_send += 1
                customer.statSend.dvd_send -= 1

            Else
                customer.stop_process = True
            End If
        End If
    End Sub


    Private Function FilterAvailableDVD(ByRef CustomerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal custRow As DataRowView, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As DataTable

        Dim dv_DVDWishlist As DataView = Nothing
        Dim WL_ViewSeries As DataView
        Dim WL_Viewquantity As DataView
        Dim dt As DataTable = Nothing
        Dim sortDisponibilite As String

        If custRow("quick") = 0 Then
            sortDisponibilite = "DESC"
        Else
            sortDisponibilite = "ASC"
        End If

        WL_ViewSeries = New DataView(DS.Tables("wishlist"), "", _FilterSeries, DataViewRowState.CurrentRows)
        WL_Viewquantity = New DataView(DS.Tables("wishlist"), "", _FilterQty & sortDisponibilite, DataViewRowState.CurrentRows)
        Dim empty As Boolean = StatAddWishlist(WL_Viewquantity.Count, type_dvd)
        If empty Then
            CustomerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.WISHEMPTY
        End If
        CustomerStat.statSend.dvd_wishlist = WL_Viewquantity.Count

        If WL_ViewSeries.Count > 0 Then
            dt = ChooseDVDinWishlistInStock(custRow, type_dvd, WL_ViewSeries, WL_Viewquantity)
        End If
        Return dt
    End Function

    Private Sub loadGridCustomerStat(ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)


        Dim dtCustomersStat As DataTable = New DataTable()
        Dim sql As String = _AboProcessSql.GetCustomersAboprocessStats(_AboStat.GetStat(type_dvd).AboProcess_id)
        DvdPostData.clsConnection.FillDataSet(dtCustomersStat, sql)

        Dim colStat As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand1.Columns.Clear()
        Me.GridViewCust.Columns.Clear()

        For Each col As DataColumn In dtCustomersStat.Columns
            colStat = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

            colStat.Caption = col.ColumnName
            colStat.FieldName = col.ColumnName
            colStat.Name = col.ColumnName
            colStat.Visible = True
            colStat.OptionsColumn.ReadOnly = True


            Me.GridBand1.Columns.Add(colStat)


        Next

        Me.GridCustResult.DataSource = dtCustomersStat
        Me.GridCustResult.Views(0).PopulateColumns()



    End Sub
    Private Sub InsertAvailabilityProduct()
        Dim sql As String
        sql = DvdPostData.clsProductDvd.getInsertAvailabilityProducts()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Private Sub UpdateQuantityStock()
        Dim sql As String
        sql = DvdPostData.clsProductDvd.GetUpdateQuantityDVDInStock()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub
    Private Sub manageTypeDvd(ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD, ByVal theme_event_id As Integer)
        _AboStat.GetStat(type_dvd).CreateStat(DateTime.Now(), type_dvd)
        LoadAvailablesDVDList(type_dvd)
        aboprocess(type_dvd, theme_event_id)
        ReInitProgressbar()
        ProcessByStep(_AboStat.GetStat(type_dvd).AboProcess_id, type_dvd)
        _AboStat.SaveStat(type_dvd)
        ReInitProgressbar()

    End Sub
    Private Sub aboprocess_main(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim main As New SSHMain
        If Not main.execBackupAboProcess() Then Return

        loadInfoToProcess()
        _CustView = New DataView(DS.Tables("customers"), "", _FilterCustomer, DataViewRowState.CurrentRows)
        _MaxDVDSendByCustomers = System.Configuration.ConfigurationManager.AppSettings("MaxDVDSendByCustomer")



        If _CustView.Count > 0 And _MaxDVDSendByCustomers > 0 Then

            Dim theme_event_id As Integer = Nothing
            If cmbTheme_event.Enabled = True And cmbTheme_event.EditValue > 0 Then
                theme_event_id = cmbTheme_event.EditValue
            End If

            manageTypeDvd(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM, theme_event_id)
            ReInitProgressbar()
            manageTypeDvd(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT, theme_event_id)
            ReInitProgressbar()
            GridAboprocess.DataSource = _AboStat.GetDataStat()
            ' DisplayStat()
            'loadGridCustomerStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)
            UpdateQuantityStock()
            InsertAvailabilityProduct()
        Else
            MsgBox("Error to process Abo Process", MsgBoxStyle.Exclamation)
        End If
        MsgBox("ABO Process Complete", MsgBoxStyle.Exclamation)
    End Sub
    'Private Sub DisplayStat()

    '    txtTotalCustomers.EditValue = _AboStat.CptCustomer
    '    TxtDvdAvailable.EditValue = _AboStat.CptDVDAvailable
    '    txtEndTime.DateTime = _AboStat.EndTime

    '    txtNormToSend.EditValue = _AboStat.CptDVDSendNorm
    '    txtAdultToSend.EditValue = _AboStat.CptDVDSendAdult

    '    txtNormCompensation.EditValue = _AboStat.CptDVDSendCompNorm
    '    txtAdultCompensation.EditValue = _AboStat.CptDVDSendCompAdult


    '    txtCustomersNotServed.EditValue = _AboStat.CptCustomerNoServed
    '    txtCustomersServed.EditValue = _AboStat.CptCustomerServed

    '    txtXCredit.EditValue = _AboStat.CptCustomerNoServedNoCredit
    '    txtXDvdNotFound.EditValue = _AboStat.CptCustomerNoServedNotFindDVD
    '    txtXSuspended.EditValue = _AboStat.CptCustomerNoServedSuspended
    '    txtXTooManyHome.EditValue = _AboStat.CptCustomerNoServedAtHome
    '    TxtRankTooLow.EditValue = _AboStat.CPTCustomerNotServedAttributedRanktoolow
    '    TxtError.EditValue = _AboStat.CPTError

    '    TxtDvdHighSent.EditValue = _AboStat.CPTDVDSentHigh
    '    TxtDvdMediumSent.EditValue = _AboStat.CPTDVDSentMedium
    '    TxtDvdLowSent.EditValue = _AboStat.CPTDVDSentLow

    '    TxtWishListNormEmpty.EditValue = _AboStat.CptDVDWishlistNormEmpty
    '    TxtWishListNormLess20.EditValue = _AboStat.CptDVDWishlistNormLess20

    '    TxtWishListAdultEmpty.EditValue = _AboStat.CptDVDWishlistAdultEmpty
    '    TxtWishListAdultLess20.EditValue = _AboStat.CptDVDWishlistAdultLess20

    '    TxtDvdSentRating.EditValue = _AboStat.GetRate_DVD_Served & " %"
    '    TxtCustomServedRating.EditValue = _AboStat.GetRate_Cust_Served & " %"
    '    TxtPriorityRating.EditValue = _AboStat.GetMetricsFormat(_AboStat.GetMetricsPriority) & " %"


    'End Sub

    Private Sub ReInitProgressbar()
        progressBar.EditValue = 0
        progressBar.Refresh()
        DoEvents()

    End Sub

    Private Sub InitProgressBar(ByVal cpt As Integer)

        progressBar.Properties.Step = 1
        progressBar.Properties.PercentView = True
        progressBar.Properties.Maximum = cpt
        progressBar.Properties.Minimum = 0
        progressBar.Show()

    End Sub
    Private Sub StepProgressBar(ByVal index As Integer)

        If index Mod 100 = 0 Then
            DoEvents()

        End If
        progressBar.EditValue = index
        progressBar.Refresh()


    End Sub
    Private Sub loadInfoToProcess()
        ' ResetCounters()
        LoadCustomersInProcess()
        loadCompensations()
        loadGridCustomerStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)

    End Sub
    Private Sub btnLoadInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadInfo.Click
        loadInfoToProcess()
    End Sub

    Private Sub loadCompensations()

        SQLCompensation = _AboProcessSql.GetSqlCompensation
        DvdPostData.clsConnection.FillDataSet(DS.Tables("compensation_summary"), SQLCompensation)

    End Sub
    Private Sub LoadCustomersInProcess()
        cleanTable()
        Dim sql As String
        sql = _AboProcessSql.GetCustomerwithAbo
        DvdPostData.clsConnection.FillDataSet(DS.Tables("customers"), sql)

        '  txtTotalCustomers.EditValue = DS.Tables("customers").Rows.Count
        '  _AboStat.CptCustomer = txtTotalCustomers.EditValue
        '  txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue


    End Sub
    Private Sub LoadAvailablesDVDList(ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)

        DS.Tables("products_dvd").Clear()
        SQLProducts_DVD = _AboProcessSql.GetProductDVDAvailable(type_dvd)

        DvdPostData.clsConnection.FillDataSet(DS.Tables("products_dvd"), SQLProducts_DVD)

        _AboStat.GetStat(type_dvd).CptDVDAvailable = DS.Tables("products_dvd").Rows.Count
        ' TxtDvdAvailable.EditValue = _AboStat.CptDVDAvailable
        _ProductView = New DataView(DS.Tables("products_dvd"), " ", "products_id", DataViewRowState.CurrentRows)

    End Sub


    Private Sub limitMaxCredit(ByRef ToSend As Integer, _
                               ByVal credit As Integer, ByVal dvdremain As Integer)


        ' credit < au nombre de dvd a envoye 
        If (ToSend > credit) Then
            Dim ok As Boolean = False
            Dim index As Integer = 0
            If (Not ok) Then
                ToSend = credit
            End If
        End If
        If (ToSend > dvdremain) Then
            Dim ok As Boolean = False
            Dim index As Integer = 0
            If (Not ok) Then
                ToSend = dvdremain
            End If
        End If


    End Sub

    Private Sub limitMaxDvdSend(ByRef stat As DVDPostBuziness.clsCustomer_Stat_TypeDVD)

        stat.nb_request_max = stat.nb_request
        If stat.nb_request_max > _MaxDVDSendByCustomers Then

            Dim ok As Boolean = False
            Dim index As Integer = 0
            While (Not ok)
                If (stat.nb_request_max > 0) Then
                    stat.nb_request_max -= 1
                    If stat.statSend.dvd_compensation > 0 Then
                        stat.statSend.dvd_compensation -= 1
                    End If
                End If

                ok = (stat.nb_request_max = _MaxDVDSendByCustomers)
                index += 1
            End While

        End If

    End Sub
    Private Sub CalcDvdToSend(ByVal customers As DVDPostBuziness.clsCustomer_stat, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)

        Dim ToSend As Integer = customers.GetStat(type_dvd).nb_request
        Dim stat As DVDPostBuziness.clsCustomer_Stat_TypeDVD

        stat = customers.GetStat(type_dvd)
        limitMaxDvdSend(customers.GetStat(type_dvd))

        ' quand on calcul par rapport aux credit il ne faut pas tenir compte des compensations (car gratuites)
        ToSend -= stat.statSend.dvd_compensation
        If Not stat.statSend.IllimitedCredit Then
            limitMaxCredit(ToSend, stat.statSend.credit, stat.statSend.remaindvd)
        End If
        stat.nb_request_max_credit = stat.nb_request_max
        stat.nb_request_max_credit += stat.statSend.dvd_compensation
        stat.nb_request_max_credit_findDvdWishlist = Math.Min(stat.nb_request_max_credit, stat.statSend.dvd_Find)


    End Sub

    Private Function searchDvdInWishlist(ByVal custRowV As DataRowView, _
                                         ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, _
                                         ByVal Type_dvd As DvdPostData.clsProductDvd.Type_DVD) As DataTable
        Dim dt As DataTable = Nothing

        If (customerStat.statSend.dvd_abo + customerStat.statSend.dvd_compensation > 0) Then
            ' _PRoductType = DVDNORM
            dt = FilterAvailableDVD(customerStat, custRowV, Type_dvd)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                customerStat.statSend.dvd_Find = dt.Rows.Count
            ElseIf customerStat.statSend.dvd_wishlist = 0 Then
                If customerStat.statSend.dvd_send > 0 Then customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.WISHEMPTY
            End If
        End If

        Return dt
    End Function


    Private Sub aboprocess(ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD, ByVal theme_event_id As Integer)

        Dim processCustom As Boolean
        Dim customers_id As Integer

        Dim statCurrent As DVDPostBuziness.clsAboprocessStatTypeDVD
        Dim customerCurrent As DVDPostBuziness.clsCustomer_stat = Nothing
        Dim customerstatcurrent As DVDPostBuziness.clsCustomer_Stat_TypeDVD = Nothing
        Dim custRow As DataRowView

        Dim dt_DVDWishlistFound As DataTable


        Dim position_current As Integer = 0
        Dim sql As String

        statCurrent = _AboStat.GetStat(type_dvd)
        InitProgressBar(_CustView.ToTable().Rows.Count)

        statCurrent.CptCustomer = _CustView.ToTable().Rows.Count

        For Each custRow In _CustView
            Try

                _i += 1

                customers_id = custRow("customers_id")
                customerCurrent = _AboStat.addCustomer(customers_id, custRow("sleep"))
                customerstatcurrent = customerCurrent.GetStat(type_dvd)
                customerstatcurrent.statSend.rank = custRow("customers_abo_rank")
                customerstatcurrent.statSend.credit = custRow("customers_abo_dvd_credit")
                customerstatcurrent.statSend.remaindvd = custRow("customers_abo_dvd_remain")


                ' nbrOfDvdThatCouldBeAtHome - nbrOfDvdCurrentlyAtHome
                CalcMaxDvd(customerCurrent, custRow)
                processCustom = CalcHowManyToAssign(customerstatcurrent, custRow, type_dvd)

                If processCustom Then

                    DS.Tables("wishlist").Clear()

                    If theme_event_id = Nothing Then
                        sql = _AboProcessSql.getUpdateWishlistThemeNull(customers_id)
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)
                    Else
                        sql = _AboProcessSql.getUpdateWishlistTheme(theme_event_id, customers_id)
                        DvdPostData.clsConnection.ExecuteNonQuery(sql)

                    End If

                    SQLWishList = _AboProcessSql.getSqlWishlist(customers_id, type_dvd)
                    DvdPostData.clsConnection.FillDataSet(DS.Tables("wishlist"), SQLWishList)

                    dt_DVDWishlistFound = Nothing
                    dt_DVDWishlistFound = searchDvdInWishlist(custRow, customerstatcurrent, type_dvd)

                    ' ovde mozda treba proveriti i dvdmax?
                    CalcDvdToSend(customerCurrent, type_dvd)
                    statCurrent.CptDVDask += customerstatcurrent.nb_request_max_credit

                    If customerstatcurrent.nb_request_max_credit_findDvdWishlist > 0 Then
                        customerstatcurrent.dt_wishlist = dt_DVDWishlistFound
                        customerstatcurrent.statSend.dvd_send = customerstatcurrent.nb_request_max_credit

                        customerstatcurrent.nb_send = 0
                        customerstatcurrent.nb_compensation = customerstatcurrent.statSend.dvd_compensation
                    Else
                        customerstatcurrent.stop_process = True
                    End If


                    If Not customerstatcurrent.stop_process Then
                        statCurrent.CptCustomerMustServed += 1
                    Else
                        ' COMMENT : NOT SERVED
                        ' NODVDFOUND
                        If (customerstatcurrent.statSend.dvd_Find = 0 And customerstatcurrent.statSend.dvd_wishlist > 0) Then
                            customerstatcurrent.statSend.reason = DvdPostData.Customer_stat.TypeReason.NOTFOUNDDVD
                            ' statCurrent.CptCustomerNoServedNotFindDVD += 1
                            customerstatcurrent.statSend.dvd_send = 0
                            statCurrent.CptCustomerMustServed += 1
                            manageRank(customers_id, False)

                        Else
                            ' WishlistEmpty 
                        End If

                    End If ' stop_process 
                Else
                    ' other reason : Credit not enough,Suspended,DVD@Home,NoManaged, Error
                    '  statCurrent.CptCustomerNoServed += 1
                    customerstatcurrent.stop_process = True

                End If ' processCustom

                StepProgressBar(_i)
            Catch ex As System.Exception

                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Abo_Process, ex, customers_id)
                customerstatcurrent.statSend.msgError = ex.Message
                customerstatcurrent.statSend.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
                statCurrent.CPTError += 1
            Finally


            End Try

        Next 'Each Customers
        ' _AboStat.CptCustomerMustServed = position_current
    End Sub
    Private Function statServedType(ByVal aboprocess_id As Integer, ByRef customer_stat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean
        Dim IsCustomerServed As Boolean
        IsCustomerServed = (customer_stat.statSend.dvd_send < customer_stat.nb_request_max_credit)

        'If customer_stat.nb_request_max_credit = 0 Then
        '    customer_stat.statSend.reason = DvdPostData.Customer_stat.TypeReason.NO_MANAGED
        'End If
        If customer_stat.statSend.reason = DVDPostBuziness.clsCustomer_Stat_TypeDvd_STAT.TypeReason.OTHER Then
            If IsCustomerServed Then
                '_AboStat.CptCustomerServed += 1
                If customer_stat.nb_request_max_credit > 0 Then
                    If customer_stat.statSend.dvd_send = 0 Then
                        customer_stat.statSend.reason = DvdPostData.Customer_stat.TypeReason.SERVED
                    Else
                        '_AboStat.CPTCustomerPartialServed += 1
                        customer_stat.statSend.reason = DvdPostData.Customer_stat.TypeReason.PARTIAL_SERVED
                    End If
                    customer_stat.statSend.dvd_send = customer_stat.nb_send
                End If

            Else
                If (customer_stat.statSend.dvd_Find = 0) Then
                    customer_stat.statSend.dvd_send = 0
                    customer_stat.statSend.reason = DvdPostData.Customer_stat.TypeReason.NOTFOUNDDVD
                End If
            End If
        Else
            Return False
        End If
        Return IsCustomerServed
    End Function
    Private Sub StatServed(ByVal index As Integer, ByRef customer As DVDPostBuziness.clsCustomer_stat, ByVal aboprocess_id As Integer, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)
        Dim IsCustomerServed As Boolean

        Dim Customerstat As DVDPostBuziness.clsCustomer_Stat_TypeDVD
        Dim stat As DVDPostBuziness.clsAboprocessStatTypeDVD


        Customerstat = customer.GetStat(type_dvd)
        stat = _AboStat.GetStat(type_dvd)

        IsCustomerServed = statServedType(aboprocess_id, Customerstat, type_dvd)

        Select Case Customerstat.statSend.reason
            'Case DvdPostData.Customer_stat.TypeReason.NO_MANAGED
            '  stat.CptCustomerMustServed -= 1
            Case DvdPostData.Customer_stat.TypeReason.PARTIAL_SERVED
                stat.CPTCustomerPartialServed += 1
            Case DvdPostData.Customer_stat.TypeReason.NOTFOUNDDVD
                stat.CptCustomerNoServedNotFindDVD += 1
            Case DvdPostData.Customer_stat.TypeReason.SERVED
                stat.CptCustomerServed += 1
                ' Case DVDPostBuziness.clsCustomer_Stat_TypeDvd_STAT.TypeReason.OTHER

        End Select

        If Not IsCustomerServed Then
            stat.CptCustomerNoServed += 1
        End If
        customer.SaveStat(aboprocess_id, type_dvd)
        Dim dr As DataRow = DS.Tables("customers").Select("customers_id = " & customer.customers_id)(0)
        dr("customers_abo_dvd_credit") = Customerstat.statSend.credit
        dr("customers_abo_dvd_remain") = Customerstat.statSend.remaindvd

        _AboStat.deleteCustomers(index, type_dvd)

    End Sub
    Private Function isStopProcess(ByVal customer As DVDPostBuziness.clsCustomer_stat, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean

        Dim stopProcess As Boolean
        Dim stat As DVDPostBuziness.clsCustomer_Stat_TypeDVD

        stat = customer.GetStat(type_dvd)
        stopProcess = (stat.statSend.dvd_send = 0) Or (stat.stop_process)


        Return stopProcess

    End Function
    Private Sub ProcessByStep(ByVal aboprocess_id As Integer, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD)

        Dim index As Integer = 0
        Dim customer As DVDPostBuziness.clsCustomer_stat
        Dim customerstat As DVDPostBuziness.clsCustomer_Stat_TypeDVD

        InitProgressBar(_AboStat.size(type_dvd))
        Dim cpt As Integer = 0
        While _AboStat.size(type_dvd) > 0

            customer = _AboStat.getcustomer(index, type_dvd)
            customerstat = customer.GetStat(type_dvd)
            If isStopProcess(customer, type_dvd) Then
                StatServed(index, customer, aboprocess_id, type_dvd)
            Else
                ' process 
                assignationStepByType(customerstat, type_dvd)
                ' apres une attribution revenir au 0 
                index += 1

            End If
            cpt += 1
            StepProgressBar(cpt)
            If index >= _AboStat.size(type_dvd) Then
                InitProgressBar(_AboStat.size(type_dvd))
                cpt = 0
                index = 0
            End If
        End While


    End Sub
    Private Sub manageRank(ByVal customers_id As Integer, ByVal iscustomerServed As Boolean)

        If iscustomerServed Then
            DvdPostData.clsConnection.ExecuteNonQuery("update customers set customers_abo_rank = 0 where customers_id = " & customers_id)
        Else
            DvdPostData.clsConnection.ExecuteNonQuery("update customers set customers_abo_rank = customers_abo_rank + 1 where customers_id = " & customers_id)
        End If
    End Sub

    ''' <summary>
    ''' delete the product of the view product
    ''' </summary>
    ''' <param name="product_id"></param>
    ''' <remarks></remarks>
    Private Sub LockDVDProduct(ByVal product_id As Integer)
        _ProductRow = GetProductAvailable(product_id)
        If Not _ProductRow Is Nothing Then
            _ProductRow.Delete()
        End If

    End Sub

    Private Function StatAddWishlist(ByVal cptDvd As Integer, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean

        If cptDvd = 0 Then
            _AboStat.GetStat(type_dvd).CptDVDWishlistEmpty += 1
            Return True
        ElseIf cptDvd < 20 Then
            _AboStat.GetStat(type_dvd).CptDVDWishlistLess20 += 1
            Return False
        End If

        Return False


    End Function

    Private Sub StatAddDvdSend(ByRef CustomerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD, ByVal priority As Integer, ByVal isCompensation As Boolean)
        Dim stat As DVDPostBuziness.clsAboprocessStatTypeDVD

        stat = _AboStat.GetStat(type_dvd)
        stat.CptDVDSend += 1
        stat.CptDVDSendNorm += 1
        If isCompensation Then
            stat.CptDVDSendComp += 1
        End If

        stat.addPriority(CustomerStat, priority)

    End Sub

    Private Sub AddDvdInTemporary(ByVal custRow As DataRowView, _
                                  ByVal customers_id As Integer, _
                                  ByVal products_id As Integer, _
                                  ByVal products_dvdid As Integer, _
                                  ByVal wl_id As Integer, _
                                  ByVal priority As Integer, _
                                  ByVal productType As String, _
                                  ByVal imdb_id As Long, _
                                  ByVal products_series_id As Integer, _
                                  ByVal products_series_number As Integer, _
                                  ByVal quantity As Integer, ByRef dt As DataTable)


        Dim __row As DataRow = dt.NewRow
        __row("customers_id") = customers_id
        __row("products_id") = products_id
        __row("products_dvdid") = products_dvdid
        __row("wl_id") = wl_id
        __row("priority") = priority
        __row("ProductType") = productType
        __row("imdb_id_serie") = imdb_id
        __row("products_series_id") = products_series_id
        __row("products_series_number") = products_series_number
        __row("quantity") = quantity

        dt.Rows.Add(__row)



    End Sub

    Private Function getBoxNegatifFirst(ByVal lst_drv As DataRowView()) As Integer
        Dim min As Integer = Integer.MaxValue
        Dim min_id As Integer = -1


        For index As Integer = 0 To lst_drv.Length - 1
            If lst_drv(index).Row.RowState <> DataRowState.Deleted Then
                If lst_drv(index)("box_id") < 0 Then
                    Return index
                Else
                    If min_id = -1 Then min_id = index
                End If
            End If
        Next

        Return min_id
    End Function

    Private Function getMinNbr_rotation(ByVal lst_drv As DataRowView()) As Integer
        Dim min As Integer = Integer.MaxValue
        Dim min_id As Integer = -1


        For index As Integer = 0 To lst_drv.Length - 1
            If lst_drv(index).Row.RowState <> DataRowState.Deleted Then
                If lst_drv(index)("nbr_rotation") < min Then
                    min = lst_drv(index)("nbr_rotation")
                    min_id = index
                End If
            End If
        Next

        Return min_id
    End Function
    Private Function GetProductAvailable(ByVal product_id As Integer) As DataRowView
        Dim min_id As Integer

        _ProductRows = _ProductView.FindRows(product_id)
        min_id = getBoxNegatifFirst(_ProductRows)
        If min_id = -1 Then
            Return Nothing
        Else
            Return _ProductRows(min_id)
        End If

    End Function
    Private Function GetFirstDVDSerie(ByVal WLRow As DataRowView, ByVal wl_viewSeries As DataView) As DataView
        Dim wl_viewFirst As DataView
        wl_viewFirst = New DataView(wl_viewSeries.Table, "imdb_id_serie = " & WLRow("imdb_id_serie"), "products_series_id,products_series_number", DataViewRowState.Unchanged)
        Return wl_viewFirst
    End Function

    Private Function IsSerieDVD(ByVal dr As DataRow) As Boolean

        Return (Not dr("imdb_id_serie") Is DBNull.Value) AndAlso dr("imdb_id_serie") > 0 AndAlso (Not dr("products_series_id") Is DBNull.Value) AndAlso (dr("products_series_id") <> 0)
    End Function

    Private Function IsSerieDVD(ByVal WLRow As DataRowView) As Boolean

        Return (Not WLRow("imdb_id_serie") Is DBNull.Value) AndAlso WLRow("imdb_id_serie") > 0 AndAlso (Not WLRow("products_series_id") Is DBNull.Value) AndAlso (WLRow("products_series_id") <> 0)
    End Function
    ''' <summary>
    ''' save the dvd list of customer in the temporary table 
    ''' </summary>
    ''' <param name="PRoductType"></param>
    ''' <remarks></remarks>
    Private Function ChooseDVDinWishlistInStock(ByVal custRow As DataRowView, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD, ByVal wl_ViewSeries As DataView, ByVal wl_quantityDVD As DataView) As DataTable  '(ByVal _WLRows() As DataRowView)

        Dim _IsPendingOrderExist As Boolean = False
        Dim customers_id As Integer = custRow("customers_id")
        Dim dt As DataTable = DS.Tables("customers_" & DVDPostTools.clsEnum.getNameStrEnum(type_dvd)).Clone()
        Dim prioritySerie As Integer
        Dim wl_viewFirstSerie As DataView
        Dim firstSerie_ProductsID As Integer
        Try
            For Each WL_RowQuantityDVD As DataRowView In wl_quantityDVD
                _ProductRow = GetProductAvailable(WL_RowQuantityDVD("product_id"))
                If WL_RowQuantityDVD.Row.RowState = DataRowState.Deleted Then
                    Continue For
                End If
                If IsSerieDVD(WL_RowQuantityDVD) Then
                    wl_viewFirstSerie = GetFirstDVDSerie(WL_RowQuantityDVD, wl_ViewSeries)
                    firstSerie_ProductsID = wl_viewFirstSerie(0)("product_id")

                    _ProductRow = GetProductAvailable(firstSerie_ProductsID)
                    If _ProductRow IsNot Nothing Then 'A Product Row is found.  

                        Dim lstdr As DataRow() = DS.Tables("customers_" & DVDPostTools.clsEnum.getNameStrEnum(type_dvd)).Select("imdb_id_serie = " & _ProductRow("imdb_id_serie"))
                        If lstdr.Length > 0 Then
                            prioritySerie = lstdr(0)("priority")
                        Else
                            prioritySerie = WL_RowQuantityDVD("priority")
                        End If
                        AddDvdInTemporary(custRow, _
                                          customers_id, _
                                          _ProductRow("products_id"), _
                                          _ProductRow("products_dvdid"), _
                                          wl_viewFirstSerie(0)("wl_id"), _
                                          prioritySerie, _
                                          DVDPostTools.clsEnum.getNameStrEnum(type_dvd), _
                                          _ProductRow("imdb_id_serie"), _
                                          _ProductRow("products_series_id"), _
                                          _ProductRow("products_series_number"), 0, dt)

                        wl_viewFirstSerie(0).Delete()
                    Else
                        Dim imdb_old As Long
                        imdb_old = WL_RowQuantityDVD("imdb_id_serie")

                        While wl_viewFirstSerie.Count > 0
                            wl_viewFirstSerie(0).Delete()
                        End While
                    End If

                Else ' not serie
                    If _ProductRow IsNot Nothing Then 'A Product Row is found.

                        AddDvdInTemporary(custRow, _
                                          customers_id, _
                                         _ProductRow("products_id"), _
                                         _ProductRow("products_dvdid"), _
                                         WL_RowQuantityDVD("wl_id"), _
                                         WL_RowQuantityDVD("priority"), _
                                          DVDPostTools.clsEnum.getNameStrEnum(type_dvd), _
                                         _ProductRow("imdb_id_serie"), _
                                         _ProductRow("products_series_id"), _
                                         _ProductRow("products_series_number"), WL_RowQuantityDVD("qty_in_stock"), dt)

                        WL_RowQuantityDVD.Delete()

                    End If
                End If ' serial 
            Next

            Return dt
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Abo_Process, ex.Message & " products_id : " & _ProductRow("products_id").ToString(), customers_id)
            Throw ex
        End Try

    End Function

    Private Function GetCptDVDNorm(ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal vCustRow As DataRowView) As Integer
        Return GetCptDVD(customerStat, vCustRow, "customers_abo_dvd_norm", "customers_abo_dvd_home_norm")
    End Function

    Private Function GetCptDVDadult(ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal vCustRow As DataRowView) As Integer
        Return GetCptDVD(customerStat, vCustRow, "customers_abo_dvd_adult", "customers_abo_dvd_home_adult")
    End Function

    Private Function GetCptDVD(ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal vCustRow As DataRowView, ByVal DVD As String, ByVal DVD_HOME As String) As Integer

        Dim cptdvd As Integer
        customerStat.statSend.dvd_abo = vCustRow(DVD)
        customerStat.statSend.dvd_home = vCustRow(DVD_HOME)

        cptdvd = customerStat.statSend.dvd_abo - customerStat.statSend.dvd_home

        Return cptdvd
    End Function

    Private Function IsSuspend(ByRef vCustRow As DataRowView, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean

        Dim suspend As Boolean = vCustRow("customers_abo_suspended") > 0
        If suspend Then
            ' txtXSuspended.EditValue += 1
            'txtCustomersNotServed.EditValue += 1
            _AboStat.GetStat(type_dvd).CptCustomerNoServedSuspended += 1
            '_AboStat.CptCustomerNoServed += 1

        End If
        Return suspend
    End Function

    Private Function IsMonoShippment(ByRef CustRow As DataRowView) As Boolean
        Return DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(CustRow("customers_id")) Or (CustRow("customers_abo_dvd_norm") + CustRow("customers_abo_dvd_adult")) Mod 2 <> 0
    End Function

    'ovde bi mogao da se proveri i customers_abo_dvd_remain
    Private Function IsCreditEnough(ByRef vCustRow As DataRowView, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD, ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD) As Boolean
        Dim strcredit As String = "customers_abo_dvd_credit"
        Dim credit As Boolean = (vCustRow("Use_credit") = 1 And vCustRow(strcredit) > 0) Or (vCustRow("Use_credit") = 0)

        If Not credit Then
            vCustRow(strcredit) = 0
            '  txtXCredit.EditValue += 1
            _AboStat.GetStat(type_dvd).CptCustomerNoServedNoCredit += 1
            ' _AboStat.CptCustomerNoServed += 1
            'txtCustomersNotServed.EditValue += 1
        End If
        customerStat.statSend.IllimitedCredit = vCustRow("Use_credit") = 0
        Return credit
    End Function

    Private Function UpdateCreditCustomer(ByRef vCustRow As DataRowView, ByVal vToSend As Integer) As Integer
        Dim cptSend As Integer
        Dim strcredit As String = "customers_abo_dvd_credit"
        Dim strdvdremain As String = "customers_abo_dvd_remain"
        Dim strnpp_logic As String = "npp_logic"

        If (vCustRow("Use_credit") = 0) Then
            cptSend = vToSend
        Else
            If (vCustRow(strnpp_logic) = 1) Then
                cptSend = Math.Min(vToSend, Math.Min(vCustRow(strdvdremain), vCustRow(strcredit)))
            Else
                cptSend = Math.Min(vToSend, vCustRow(strcredit))
            End If

        End If

        Return cptSend

    End Function

    Private Function GetCompensation(ByVal customers_id As Integer, ByVal typeDvd As DvdPostData.clsProductDvd.Type_DVD) As Integer
        Dim _CompensationRow As DataRow
        Dim compensation As Integer = 0

        _CompensationRow = DS.Tables("compensation_summary").Rows.Find(New Object() {customers_id, DVDPostTools.clsEnum.getNameStrEnum(typeDvd)})
        If Not IsNothing(_CompensationRow) Then
            compensation = _CompensationRow("compensation_qty")
        End If
        Return compensation
    End Function
    Private Sub CalcMaxDvd(ByRef cust As DVDPostBuziness.clsCustomer_stat, ByVal vCustRow As DataRowView)

        Dim vNormToSend As Integer
        Dim vAdultToSend As Integer


        vNormToSend = GetCptDVDNorm(cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM), vCustRow)
        vAdultToSend = GetCptDVDadult(cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT), vCustRow)

        ' COMMENT :
        ' dvdnorm : 2 -> dvdnormHome : 0
        ' dvdadult : 0 -> dvdadulthome : 2
        ' how many dvdnorm and dvdadult ? 
        ' in this case 0 dvd sended but (2 norm and -2 adult) 
        ' quid si vNormToSend + vAdultToSend > 0 

        Dim tmp As Integer = vNormToSend + vAdultToSend

        If tmp <= 0 Then
            vNormToSend = 0
            vAdultToSend = 0
        ElseIf vNormToSend < 0 Then
            vAdultToSend = vNormToSend + vAdultToSend
            vNormToSend = 0
        ElseIf vAdultToSend < 0 Then
            vNormToSend = vNormToSend + vAdultToSend
            vAdultToSend = 0
        End If

        cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM).maxDvdSend = vNormToSend
        cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT).maxDvdSend = vAdultToSend

        If cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM).statSend.dvd_abo _
            + cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT).statSend.dvd_abo = 0 Then

            _AboStat.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM).CPTError += 1
            cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM).statSend.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
            cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM).statSend.msgError = " 0 dvd At home and 0 dvd in rotation"

            _AboStat.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT).CPTError += 1
            cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT).statSend.reason = DvdPostData.Customer_stat.TypeReason.MSGERROR
            cust.GetStat(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT).statSend.msgError = " 0 dvd At home and 0 dvd in rotation"
        End If
    End Sub

    Private Function CalcHowManyToAssign(ByRef customerStat As DVDPostBuziness.clsCustomer_Stat_TypeDVD, ByVal vCustRow As DataRowView, ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD) As Boolean

        Dim DVDCompensation As Integer = 0
        Dim DVDToSend As Integer = 0
      
        If IsSuspend(vCustRow, type_dvd) Then
            customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.SUSPENDED
        ElseIf (DVDCompensation = 0) And Not IsCreditEnough(vCustRow, type_dvd, customerStat) Then
            customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.NOCREDIT
        ElseIf (customerStat.statSend.dvd_home >= customerStat.statSend.dvd_abo And customerStat.statSend.dvd_abo <> 0) Then
            customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.ATHOME
            _AboStat.GetStat(type_dvd).CptCustomerNoServedAtHome += 1
        ElseIf customerStat.statSend.dvd_abo = 0 Or _
            (customerStat.maxDvdSend = 0 And _
                customerStat.statSend.reason = DVDPostBuziness.clsCustomer_Stat_TypeDvd_STAT.TypeReason.OTHER _
            ) Then
            customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.NO_MANAGED
            _AboStat.GetStat(type_dvd).CptCustomerNoManaged += 1
        ElseIf (customerStat.statSend.remaindvd = 0 And vCustRow("npp_logic") = 1) Then
            customerStat.statSend.reason = DvdPostData.Customer_stat.TypeReason.DVD_MAX
            _AboStat.GetStat(type_dvd).CptCustomerDVDMax += 1
        Else
            'calculate how many dvd to send by taking minimum of (dvd could be at home - dvd at home, credit and maxdvd)
            DVDToSend = UpdateCreditCustomer(vCustRow, customerStat.maxDvdSend)
            DVDCompensation = GetCompensation(vCustRow("customers_id"), customerStat.typeDvd)
            customerStat.statSend.dvd_compensation = DVDCompensation
            customerStat.nb_request = Math.Min(DVDToSend, customerStat.maxDvdSend)
            customerStat.nb_compensation = DVDCompensation
            customerStat.nb_request += DVDCompensation

        End If ' customerStat.dvd_norm.dvd_home > 0

        Return (DVDToSend + DVDCompensation) > 0
    End Function
    'Private Sub ResetCounters()
    '    txtCustomersToProcess.EditValue = txtTotalCustomers.EditValue
    '    txtTotalCustomers.EditValue = 0
    '    TxtDvdAvailable.EditValue = 0
    '    txtEndTime.DateTime = DateTime.MinValue

    '    txtNormToSend.EditValue = 0
    '    txtAdultToSend.EditValue = 0

    '    txtNormCompensation.EditValue = 0
    '    txtAdultCompensation.EditValue = 0


    '    txtCustomersNotServed.EditValue = 0
    '    txtCustomersServed.EditValue = 0

    '    txtXCredit.EditValue = 0
    '    txtXDvdNotFound.EditValue = 0
    '    txtXSuspended.EditValue = 0
    '    txtXTooManyHome.EditValue = 0
    '    TxtRankTooLow.EditValue = 0
    '    TxtError.EditValue = 0

    '    TxtDvdHighSent.EditValue = 0
    '    TxtDvdMediumSent.EditValue = 0
    '    TxtDvdLowSent.EditValue = 0

    '    TxtWishListNormEmpty.EditValue = 0
    '    TxtWishListNormLess20.EditValue = 0

    '    TxtWishListAdultEmpty.EditValue = 0
    '    TxtWishListAdultLess20.EditValue = 0

    '    TxtDvdSentRating.EditValue = 0 & " %"
    '    TxtCustomServedRating.EditValue = 0 & " %"
    '    TxtPriorityRating.EditValue = 0 & " %"

    'End Sub
    Private Function AssignDVD(ByVal isIllimitedAbo As Boolean, ByRef isCompensation As Boolean, ByRef wl_id As Integer, ByRef vProducts_id As Integer, ByRef customers_id As Integer, ByVal productDvD_id As Integer, ByVal orders_type As DvdPostData.ClsCustomersData.OrdersType) As Integer
        Try
            Dim orders_id As Integer = 0
            Dim _DS As New dsProducts
            Dim _ObjProductsDvd As New clsProduct_DVD(SessionInfo, _DS, vProducts_id, productDvD_id)
            orders_id = _ObjProductsDvd.AssignDVD(isIllimitedAbo, isCompensation, wl_id, customers_id, DvdPostData.clsCreditHistory.ActionId.ABOPROCESS, orders_type)
            Return orders_id
        Catch ex As Exception
            Dim x As Integer = 1
            Return Nothing
        End Try
    End Function

    Private Sub btnStartABO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartABO2.Click
        aboprocess_main(sender, e)
    End Sub

    Private Sub chkActiveTheme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActiveTheme.CheckedChanged
        cmbTheme_event.Enabled = chkActiveTheme.Checked
        If chkActiveTheme.Checked Then
            chkActiveTheme.Text = "LOCK"
        Else
            chkActiveTheme.Text = "UNLOCK"
        End If
    End Sub
End Class

