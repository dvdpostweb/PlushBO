Imports System.Windows.Forms.Application
Public Class frmStockInventorySlsPur
    Inherits BizzLib.frmBKForm
    Private NbrDVDByBox As Int16 = 20

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
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents StyleRed As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleGreen As DevExpress.XtraEditors.StyleController
    Friend WithEvents StyleBlue As DevExpress.XtraEditors.StyleController
    Friend WithEvents SCbox1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DGReadyToRent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpibox_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbar_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TBBoxReadyToRent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCStockPassif As DevExpress.XtraGrid.GridControl
    Friend WithEvents TBBoxStockPassif As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCBadSticker As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TBBoxBadSticker As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnFindBarCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCExept As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TBBoxExept As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEBadSticker As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents btnOK1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictActif As System.Windows.Forms.PictureBox
    Friend WithEvents PictPassif As System.Windows.Forms.PictureBox
    Friend WithEvents PictBadLabel As System.Windows.Forms.PictureBox
    Friend WithEvents PictExcept As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearchActif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearchPassif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearchBadLabel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearchExcept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GVReadyToRent As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVStockPassif As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVBadSticker As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GVExept As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BTPartDeleteReadyToRent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTPartDeleteStockPassif As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTPartDeleteBadSticker As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTPartDeleteExept As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.objDS = New DVDPostLib.dsProducts
        Me.StyleRed = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleGreen = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.StyleBlue = New DevExpress.XtraEditors.StyleController(Me.components)
        Me.SCbox1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.DGReadyToRent = New DevExpress.XtraGrid.GridControl
        Me.GVReadyToRent = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colpibox_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbar_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_model = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BTPartDeleteReadyToRent = New DevExpress.XtraEditors.SimpleButton
        Me.PictActif = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearchActif = New DevExpress.XtraEditors.SimpleButton
        Me.TBBoxReadyToRent = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GCStockPassif = New DevExpress.XtraGrid.GridControl
        Me.GVStockPassif = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.PictPassif = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearchPassif = New DevExpress.XtraEditors.SimpleButton
        Me.TBBoxStockPassif = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GCBadSticker = New DevExpress.XtraGrid.GridControl
        Me.GVBadSticker = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.PictBadLabel = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearchBadLabel = New DevExpress.XtraEditors.SimpleButton
        Me.TBBoxBadSticker = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GCExept = New DevExpress.XtraGrid.GridControl
        Me.GVExept = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.PictExcept = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearchExcept = New DevExpress.XtraEditors.SimpleButton
        Me.TBBoxExept = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btnFindBarCode = New DevExpress.XtraEditors.SimpleButton
        Me.txtDVD_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnOK1 = New DevExpress.XtraEditors.SimpleButton
        Me.txtBarCode = New System.Windows.Forms.TextBox
        Me.CEBadSticker = New DevExpress.XtraEditors.CheckEdit
        Me.BTPartDeleteStockPassif = New DevExpress.XtraEditors.SimpleButton
        Me.BTPartDeleteBadSticker = New DevExpress.XtraEditors.SimpleButton
        Me.BTPartDeleteExept = New DevExpress.XtraEditors.SimpleButton
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCbox1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.DGReadyToRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVReadyToRent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TBBoxReadyToRent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCStockPassif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVStockPassif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.TBBoxStockPassif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GCBadSticker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVBadSticker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.TBBoxBadSticker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCExept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVExept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.TBBoxExept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CEBadSticker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'StyleRed
        '
        Me.StyleRed.Appearance.BackColor = System.Drawing.Color.Red
        Me.StyleRed.Appearance.Options.UseBackColor = True
        '
        'StyleGreen
        '
        Me.StyleGreen.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.StyleGreen.Appearance.Options.UseBackColor = True
        '
        'StyleBlue
        '
        Me.StyleBlue.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.StyleBlue.Appearance.Options.UseBackColor = True
        '
        'SCbox1
        '
        Me.SCbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCbox1.Location = New System.Drawing.Point(0, 104)
        Me.SCbox1.Name = "SCbox1"
        Me.SCbox1.Panel1.Controls.Add(Me.SplitContainerControl1)
        Me.SCbox1.Panel1.Text = "SplitContainerControl1_Panel1"
        Me.SCbox1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SCbox1.Panel2.Text = "SplitContainerControl1_Panel2"
        Me.SCbox1.Size = New System.Drawing.Size(1040, 286)
        Me.SCbox1.SplitterPosition = 519
        Me.SCbox1.TabIndex = 31
        Me.SCbox1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DGReadyToRent)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel1.Text = "SplitContainerControl1_Panel1"
        Me.SplitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GCStockPassif)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PanelControl3)
        Me.SplitContainerControl1.Panel2.Text = "SplitContainerControl1_Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(515, 282)
        Me.SplitContainerControl1.SplitterPosition = 257
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'DGReadyToRent
        '
        Me.DGReadyToRent.DataSource = Me.objDS.products_dvd_stock_1
        Me.DGReadyToRent.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'DGReadyToRent.EmbeddedNavigator
        '
        Me.DGReadyToRent.EmbeddedNavigator.Name = ""
        Me.DGReadyToRent.Location = New System.Drawing.Point(0, 88)
        Me.DGReadyToRent.MainView = Me.GVReadyToRent
        Me.DGReadyToRent.Name = "DGReadyToRent"
        Me.DGReadyToRent.Size = New System.Drawing.Size(257, 194)
        Me.DGReadyToRent.TabIndex = 1
        Me.DGReadyToRent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVReadyToRent, Me.GridView1})
        '
        'GVReadyToRent
        '
        Me.GVReadyToRent.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colbox_id, Me.colpibox_id, Me.colbar_code, Me.colproducts_model})
        Me.GVReadyToRent.GridControl = Me.DGReadyToRent
        Me.GVReadyToRent.Name = "GVReadyToRent"
        Me.GVReadyToRent.OptionsBehavior.Editable = False
        Me.GVReadyToRent.OptionsCustomization.AllowFilter = False
        Me.GVReadyToRent.OptionsSelection.MultiSelect = True
        Me.GVReadyToRent.OptionsView.ShowGroupPanel = False
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.Visible = True
        Me.colproducts_id.VisibleIndex = 0
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.VisibleIndex = 1
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.VisibleIndex = 2
        '
        'colbox_id
        '
        Me.colbox_id.Caption = "box_id"
        Me.colbox_id.FieldName = "box_id"
        Me.colbox_id.Name = "colbox_id"
        Me.colbox_id.Visible = True
        Me.colbox_id.VisibleIndex = 3
        '
        'colpibox_id
        '
        Me.colpibox_id.Caption = "pibox_id"
        Me.colpibox_id.FieldName = "pibox_id"
        Me.colpibox_id.Name = "colpibox_id"
        Me.colpibox_id.Visible = True
        Me.colpibox_id.VisibleIndex = 4
        '
        'colbar_code
        '
        Me.colbar_code.Caption = "bar_code"
        Me.colbar_code.FieldName = "bar_code"
        Me.colbar_code.Name = "colbar_code"
        Me.colbar_code.Visible = True
        Me.colbar_code.VisibleIndex = 5
        '
        'colproducts_model
        '
        Me.colproducts_model.Caption = "products_model"
        Me.colproducts_model.FieldName = "products_model"
        Me.colproducts_model.Name = "colproducts_model"
        Me.colproducts_model.Visible = True
        Me.colproducts_model.VisibleIndex = 6
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DGReadyToRent
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BTPartDeleteReadyToRent)
        Me.PanelControl2.Controls.Add(Me.PictActif)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.btnSearchActif)
        Me.PanelControl2.Controls.Add(Me.TBBoxReadyToRent)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(257, 88)
        Me.PanelControl2.TabIndex = 0
        Me.PanelControl2.Text = "PanelControl2"
        '
        'BTPartDeleteReadyToRent
        '
        Me.BTPartDeleteReadyToRent.Location = New System.Drawing.Point(128, 56)
        Me.BTPartDeleteReadyToRent.Name = "BTPartDeleteReadyToRent"
        Me.BTPartDeleteReadyToRent.Size = New System.Drawing.Size(120, 23)
        Me.BTPartDeleteReadyToRent.TabIndex = 32
        Me.BTPartDeleteReadyToRent.Text = "Delete selected DVD"
        '
        'PictActif
        '
        Me.PictActif.BackColor = System.Drawing.Color.Lime
        Me.PictActif.Location = New System.Drawing.Point(136, 32)
        Me.PictActif.Name = "PictActif"
        Me.PictActif.Size = New System.Drawing.Size(88, 16)
        Me.PictActif.TabIndex = 31
        Me.PictActif.TabStop = False
        Me.PictActif.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Boite Active"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(184, 8)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton5.TabIndex = 29
        Me.SimpleButton5.Text = "Clear"
        '
        'btnSearchActif
        '
        Me.btnSearchActif.Location = New System.Drawing.Point(128, 8)
        Me.btnSearchActif.Name = "btnSearchActif"
        Me.btnSearchActif.Size = New System.Drawing.Size(56, 23)
        Me.btnSearchActif.TabIndex = 27
        Me.btnSearchActif.Text = "Search"
        '
        'TBBoxReadyToRent
        '
        Me.TBBoxReadyToRent.Location = New System.Drawing.Point(48, 9)
        Me.TBBoxReadyToRent.Name = "TBBoxReadyToRent"
        Me.TBBoxReadyToRent.Size = New System.Drawing.Size(74, 20)
        Me.TBBoxReadyToRent.TabIndex = 26
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "BoxID"
        '
        'GCStockPassif
        '
        Me.GCStockPassif.DataSource = Me.objDS.products_dvd_stock_2
        Me.GCStockPassif.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GCStockPassif.EmbeddedNavigator
        '
        Me.GCStockPassif.EmbeddedNavigator.Name = ""
        Me.GCStockPassif.Location = New System.Drawing.Point(0, 88)
        Me.GCStockPassif.MainView = Me.GVStockPassif
        Me.GCStockPassif.Name = "GCStockPassif"
        Me.GCStockPassif.Size = New System.Drawing.Size(252, 194)
        Me.GCStockPassif.TabIndex = 2
        Me.GCStockPassif.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVStockPassif, Me.GridView4})
        '
        'GVStockPassif
        '
        Me.GVStockPassif.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GVStockPassif.GridControl = Me.GCStockPassif
        Me.GVStockPassif.Name = "GVStockPassif"
        Me.GVStockPassif.OptionsBehavior.Editable = False
        Me.GVStockPassif.OptionsCustomization.AllowFilter = False
        Me.GVStockPassif.OptionsCustomization.AllowGroup = False
        Me.GVStockPassif.OptionsSelection.MultiSelect = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "products_id"
        Me.GridColumn1.FieldName = "products_id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "products_dvdid"
        Me.GridColumn2.FieldName = "products_dvdid"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "products_dvd_status"
        Me.GridColumn3.FieldName = "products_dvd_status"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "box_id"
        Me.GridColumn4.FieldName = "box_id"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "pibox_id"
        Me.GridColumn5.FieldName = "pibox_id"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "bar_code"
        Me.GridColumn6.FieldName = "bar_code"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "products_model"
        Me.GridColumn7.FieldName = "products_model"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GCStockPassif
        Me.GridView4.Name = "GridView4"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BTPartDeleteStockPassif)
        Me.PanelControl3.Controls.Add(Me.PictPassif)
        Me.PanelControl3.Controls.Add(Me.Label2)
        Me.PanelControl3.Controls.Add(Me.SimpleButton6)
        Me.PanelControl3.Controls.Add(Me.btnSearchPassif)
        Me.PanelControl3.Controls.Add(Me.TBBoxStockPassif)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(252, 88)
        Me.PanelControl3.TabIndex = 1
        Me.PanelControl3.Text = "PanelControl3"
        '
        'PictPassif
        '
        Me.PictPassif.BackColor = System.Drawing.Color.Lime
        Me.PictPassif.Location = New System.Drawing.Point(144, 32)
        Me.PictPassif.Name = "PictPassif"
        Me.PictPassif.Size = New System.Drawing.Size(88, 16)
        Me.PictPassif.TabIndex = 32
        Me.PictPassif.TabStop = False
        Me.PictPassif.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Boite passive"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(184, 8)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton6.TabIndex = 30
        Me.SimpleButton6.Text = "Clear"
        '
        'btnSearchPassif
        '
        Me.btnSearchPassif.Location = New System.Drawing.Point(128, 8)
        Me.btnSearchPassif.Name = "btnSearchPassif"
        Me.btnSearchPassif.Size = New System.Drawing.Size(56, 23)
        Me.btnSearchPassif.TabIndex = 27
        Me.btnSearchPassif.Text = "Search"
        '
        'TBBoxStockPassif
        '
        Me.TBBoxStockPassif.Location = New System.Drawing.Point(48, 9)
        Me.TBBoxStockPassif.Name = "TBBoxStockPassif"
        Me.TBBoxStockPassif.Size = New System.Drawing.Size(74, 20)
        Me.TBBoxStockPassif.TabIndex = 26
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl6.TabIndex = 28
        Me.LabelControl6.Text = "BoxID"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GCBadSticker)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.PanelControl4)
        Me.SplitContainerControl2.Panel1.Text = "SplitContainerControl2_Panel1"
        Me.SplitContainerControl2.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.GCExept)
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.PanelControl5)
        Me.SplitContainerControl2.Panel2.Text = "SplitContainerControl2_Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(511, 282)
        Me.SplitContainerControl2.SplitterPosition = 252
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GCBadSticker
        '
        Me.GCBadSticker.DataSource = Me.objDS.products_dvd_stock_3
        Me.GCBadSticker.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GCBadSticker.EmbeddedNavigator
        '
        Me.GCBadSticker.EmbeddedNavigator.Name = ""
        Me.GCBadSticker.Location = New System.Drawing.Point(0, 88)
        Me.GCBadSticker.MainView = Me.GVBadSticker
        Me.GCBadSticker.Name = "GCBadSticker"
        Me.GCBadSticker.Size = New System.Drawing.Size(252, 194)
        Me.GCBadSticker.TabIndex = 4
        Me.GCBadSticker.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVBadSticker, Me.GridView6})
        '
        'GVBadSticker
        '
        Me.GVBadSticker.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14})
        Me.GVBadSticker.GridControl = Me.GCBadSticker
        Me.GVBadSticker.Name = "GVBadSticker"
        Me.GVBadSticker.OptionsBehavior.Editable = False
        Me.GVBadSticker.OptionsCustomization.AllowFilter = False
        Me.GVBadSticker.OptionsCustomization.AllowGroup = False
        Me.GVBadSticker.OptionsSelection.MultiSelect = True
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "products_id"
        Me.GridColumn8.FieldName = "products_id"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "products_dvdid"
        Me.GridColumn9.FieldName = "products_dvdid"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "products_dvd_status"
        Me.GridColumn10.FieldName = "products_dvd_status"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "box_id"
        Me.GridColumn11.FieldName = "box_id"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "pibox_id"
        Me.GridColumn12.FieldName = "pibox_id"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "bar_code"
        Me.GridColumn13.FieldName = "bar_code"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "products_model"
        Me.GridColumn14.FieldName = "products_model"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 6
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.GCBadSticker
        Me.GridView6.Name = "GridView6"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.BTPartDeleteBadSticker)
        Me.PanelControl4.Controls.Add(Me.PictBadLabel)
        Me.PanelControl4.Controls.Add(Me.Label3)
        Me.PanelControl4.Controls.Add(Me.SimpleButton7)
        Me.PanelControl4.Controls.Add(Me.btnSearchBadLabel)
        Me.PanelControl4.Controls.Add(Me.TBBoxBadSticker)
        Me.PanelControl4.Controls.Add(Me.LabelControl7)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(252, 88)
        Me.PanelControl4.TabIndex = 3
        Me.PanelControl4.Text = "PanelControl4"
        '
        'PictBadLabel
        '
        Me.PictBadLabel.BackColor = System.Drawing.Color.Lime
        Me.PictBadLabel.Location = New System.Drawing.Point(136, 32)
        Me.PictBadLabel.Name = "PictBadLabel"
        Me.PictBadLabel.Size = New System.Drawing.Size(88, 16)
        Me.PictBadLabel.TabIndex = 33
        Me.PictBadLabel.TabStop = False
        Me.PictBadLabel.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Boite Badad label "
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(184, 8)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(48, 23)
        Me.SimpleButton7.TabIndex = 31
        Me.SimpleButton7.Text = "Clear"
        '
        'btnSearchBadLabel
        '
        Me.btnSearchBadLabel.Location = New System.Drawing.Point(128, 8)
        Me.btnSearchBadLabel.Name = "btnSearchBadLabel"
        Me.btnSearchBadLabel.Size = New System.Drawing.Size(56, 23)
        Me.btnSearchBadLabel.TabIndex = 27
        Me.btnSearchBadLabel.Text = "Search"
        '
        'TBBoxBadSticker
        '
        Me.TBBoxBadSticker.Location = New System.Drawing.Point(48, 9)
        Me.TBBoxBadSticker.Name = "TBBoxBadSticker"
        Me.TBBoxBadSticker.Size = New System.Drawing.Size(74, 20)
        Me.TBBoxBadSticker.TabIndex = 26
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl7.TabIndex = 28
        Me.LabelControl7.Text = "BoxID"
        '
        'GCExept
        '
        Me.GCExept.DataSource = Me.objDS.products_dvd_stock_4
        Me.GCExept.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'GCExept.EmbeddedNavigator
        '
        Me.GCExept.EmbeddedNavigator.Name = ""
        Me.GCExept.Location = New System.Drawing.Point(0, 88)
        Me.GCExept.MainView = Me.GVExept
        Me.GCExept.Name = "GCExept"
        Me.GCExept.Size = New System.Drawing.Size(253, 194)
        Me.GCExept.TabIndex = 6
        Me.GCExept.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVExept, Me.GridView8})
        '
        'GVExept
        '
        Me.GVExept.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21})
        Me.GVExept.GridControl = Me.GCExept
        Me.GVExept.Name = "GVExept"
        Me.GVExept.OptionsBehavior.Editable = False
        Me.GVExept.OptionsCustomization.AllowFilter = False
        Me.GVExept.OptionsCustomization.AllowGroup = False
        Me.GVExept.OptionsSelection.MultiSelect = True
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "products_id"
        Me.GridColumn15.FieldName = "products_id"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "products_dvdid"
        Me.GridColumn16.FieldName = "products_dvdid"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 1
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "products_dvd_status"
        Me.GridColumn17.FieldName = "products_dvd_status"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 2
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "box_id"
        Me.GridColumn18.FieldName = "box_id"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 3
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "pibox_id"
        Me.GridColumn19.FieldName = "pibox_id"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 4
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "bar_code"
        Me.GridColumn20.FieldName = "bar_code"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 5
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "products_model"
        Me.GridColumn21.FieldName = "products_model"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 6
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.GCExept
        Me.GridView8.Name = "GridView8"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.BTPartDeleteExept)
        Me.PanelControl5.Controls.Add(Me.PictExcept)
        Me.PanelControl5.Controls.Add(Me.Label4)
        Me.PanelControl5.Controls.Add(Me.SimpleButton8)
        Me.PanelControl5.Controls.Add(Me.btnSearchExcept)
        Me.PanelControl5.Controls.Add(Me.TBBoxExept)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(253, 88)
        Me.PanelControl5.TabIndex = 5
        Me.PanelControl5.Text = "PanelControl5"
        '
        'PictExcept
        '
        Me.PictExcept.BackColor = System.Drawing.Color.Lime
        Me.PictExcept.Location = New System.Drawing.Point(144, 32)
        Me.PictExcept.Name = "PictExcept"
        Me.PictExcept.Size = New System.Drawing.Size(88, 16)
        Me.PictExcept.TabIndex = 33
        Me.PictExcept.TabStop = False
        Me.PictExcept.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Boite Exept"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Location = New System.Drawing.Point(184, 8)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(56, 23)
        Me.SimpleButton8.TabIndex = 31
        Me.SimpleButton8.Text = "Clear"
        '
        'btnSearchExcept
        '
        Me.btnSearchExcept.Location = New System.Drawing.Point(128, 8)
        Me.btnSearchExcept.Name = "btnSearchExcept"
        Me.btnSearchExcept.Size = New System.Drawing.Size(56, 23)
        Me.btnSearchExcept.TabIndex = 27
        Me.btnSearchExcept.Text = "Search"
        '
        'TBBoxExept
        '
        Me.TBBoxExept.Location = New System.Drawing.Point(48, 9)
        Me.TBBoxExept.Name = "TBBoxExept"
        Me.TBBoxExept.Size = New System.Drawing.Size(74, 20)
        Me.TBBoxExept.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 14)
        Me.LabelControl4.TabIndex = 28
        Me.LabelControl4.Text = "BoxID"
        '
        'btnFindBarCode
        '
        Me.btnFindBarCode.Location = New System.Drawing.Point(704, 16)
        Me.btnFindBarCode.Name = "btnFindBarCode"
        Me.btnFindBarCode.Size = New System.Drawing.Size(88, 23)
        Me.btnFindBarCode.TabIndex = 3
        Me.btnFindBarCode.Text = "Find Bar Code"
        '
        'txtDVD_ID
        '
        Me.txtDVD_ID.Enabled = False
        Me.txtDVD_ID.Location = New System.Drawing.Point(592, 40)
        Me.txtDVD_ID.Name = "txtDVD_ID"
        '
        'txtDVD_ID.Properties
        '
        Me.txtDVD_ID.Properties.ReadOnly = True
        Me.txtDVD_ID.Size = New System.Drawing.Size(96, 20)
        Me.txtDVD_ID.TabIndex = 29
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(512, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "DVD ID"
        '
        'txtProducts_id
        '
        Me.txtProducts_id.Enabled = False
        Me.txtProducts_id.Location = New System.Drawing.Point(384, 40)
        Me.txtProducts_id.Name = "txtProducts_id"
        '
        'txtProducts_id.Properties
        '
        Me.txtProducts_id.Properties.ReadOnly = True
        Me.txtProducts_id.Size = New System.Drawing.Size(96, 20)
        Me.txtProducts_id.TabIndex = 24
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(304, 16)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "BareCode"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(304, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnOK1)
        Me.PanelControl1.Controls.Add(Me.txtBarCode)
        Me.PanelControl1.Controls.Add(Me.CEBadSticker)
        Me.PanelControl1.Controls.Add(Me.btnFindBarCode)
        Me.PanelControl1.Controls.Add(Me.txtDVD_ID)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtProducts_id)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 26)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1040, 78)
        Me.PanelControl1.TabIndex = 30
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnOK1
        '
        Me.btnOK1.Location = New System.Drawing.Point(800, 16)
        Me.btnOK1.Name = "btnOK1"
        Me.btnOK1.Size = New System.Drawing.Size(88, 23)
        Me.btnOK1.TabIndex = 33
        Me.btnOK1.Text = "ok"
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(384, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarCode.TabIndex = 32
        Me.txtBarCode.Text = ""
        '
        'CEBadSticker
        '
        Me.CEBadSticker.Location = New System.Drawing.Point(704, 48)
        Me.CEBadSticker.Name = "CEBadSticker"
        '
        'CEBadSticker.Properties
        '
        Me.CEBadSticker.Properties.Caption = "BadLabel"
        Me.CEBadSticker.Size = New System.Drawing.Size(75, 19)
        Me.CEBadSticker.TabIndex = 30
        '
        'BTPartDeleteStockPassif
        '
        Me.BTPartDeleteStockPassif.Location = New System.Drawing.Point(128, 56)
        Me.BTPartDeleteStockPassif.Name = "BTPartDeleteStockPassif"
        Me.BTPartDeleteStockPassif.Size = New System.Drawing.Size(120, 23)
        Me.BTPartDeleteStockPassif.TabIndex = 33
        Me.BTPartDeleteStockPassif.Text = "Delete selected DVD"
        '
        'BTPartDeleteBadSticker
        '
        Me.BTPartDeleteBadSticker.Location = New System.Drawing.Point(128, 56)
        Me.BTPartDeleteBadSticker.Name = "BTPartDeleteBadSticker"
        Me.BTPartDeleteBadSticker.Size = New System.Drawing.Size(120, 23)
        Me.BTPartDeleteBadSticker.TabIndex = 34
        Me.BTPartDeleteBadSticker.Text = "Delete selected DVD"
        '
        'BTPartDeleteExept
        '
        Me.BTPartDeleteExept.Location = New System.Drawing.Point(128, 56)
        Me.BTPartDeleteExept.Name = "BTPartDeleteExept"
        Me.BTPartDeleteExept.Size = New System.Drawing.Size(120, 23)
        Me.BTPartDeleteExept.TabIndex = 34
        Me.BTPartDeleteExept.Text = "Delete selected DVD"
        '
        'frmStockInventorySlsPur
        '
        Me.AcceptButton = Me.btnOK1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 390)
        Me.Controls.Add(Me.SCbox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmStockInventorySlsPur"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SCbox1, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCbox1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.DGReadyToRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVReadyToRent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.TBBoxReadyToRent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCStockPassif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVStockPassif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.TBBoxStockPassif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GCBadSticker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVBadSticker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.TBBoxBadSticker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCExept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVExept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.TBBoxExept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVD_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.CEBadSticker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Pos_ID As Integer = 1
    Dim Pos_ID_IBox_ReadyToRent As Int16 = 1
    Dim Pos_ID_IBox_StockPassif As Int16 = 1
    Dim Pos_ID_IBox_Exept As Int16 = 1
    Dim Pos_ID_IBox_BadSticker As Int16 = 1

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub


    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load DVD Status ListBOX
        BKGlobal.Cls1.ExecuteNonQuery("UPDATE products SET feesharing_end = NULL WHERE feesharing_end = '0000-00-00'")
        BKGlobal.Cls1.ExecuteNonQuery("UPDATE products SET products_sale_date = NULL WHERE products_sale_date = '0000-00-00 00:00:00'")
        Dim _SQLTxt As String = "SELECT * FROM products_dvd_status"
        BKGlobal.Cls1.FillDataSet(objDS.Tables("products_dvd_status"), _SQLTxt)
    End Sub
    Public Sub BarCode_OK()
        'Dim Product_ID As String
        'Dim DVD_ID As Integer
        Dim _OLDRow As DataRow
        Dim _NewRow As DataRow
        Dim _DS As New dsProducts
        Dim _view As DataView
        Dim _objProductDVD As clsProduct_DVD
        Dim _Row As DataRow
        Dim _i As MsgBoxResult
        Dim _z As String
        'Dim _frm As New frmMessage

        If txtBarCode.Text.Length = 13 Then
            If txtBarCode.Enabled = False Then Exit Sub
            txtBarCode.Enabled = False
            txtBarCode.Refresh()
            _objProductDVD = New clsProduct_DVD(SessionInfo, objDS, txtBarCode.Text)
            If Not _objProductDVD.BarCode.IsBarCodeValid Then
                Beep()
                MsgBox("BAR CODE IS NOT VALIDE", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "BAR CODE IS NOT VALIDE"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If
            txtProducts_id.EditValue = _objProductDVD.ProductsId
            txtDVD_ID.EditValue = _objProductDVD.DvdId
            _objProductDVD.LoadExpeditedOrders()
            If _objProductDVD.OrdersDataTable.Rows.Count > 0 Then
                MsgBox("OPEN Orders exist. Please use Process IN", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "OPEN Orders exist. Please use Process IN"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            Else
            End If
            _Row = objDS.Tables("products_dvd_stock_1").Rows.Find(New Object() {_objProductDVD.ProductsId, _objProductDVD.DvdId})
            If Not IsNothing(_Row) Then
                'DoEvents()
                MsgBox("Dvd déjà scanné ... boite1", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "Dvd déjà scanné ... boite1"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If
            _Row = objDS.Tables("products_dvd_stock_2").Rows.Find(New Object() {_objProductDVD.ProductsId, _objProductDVD.DvdId})
            If Not IsNothing(_Row) Then
                MsgBox("Dvd déjà scanné ... boite2", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "Dvd déjà scanné ... boite2"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If
            _Row = objDS.Tables("products_dvd_stock_3").Rows.Find(New Object() {_objProductDVD.ProductsId, _objProductDVD.DvdId})
            If Not IsNothing(_Row) Then
                MsgBox("Dvd déjà scanné ... boite3", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "Dvd déjà scanné ... boite3"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If
            _Row = objDS.Tables("products_dvd_stock_4").Rows.Find(New Object() {_objProductDVD.ProductsId, _objProductDVD.DvdId})
            If Not IsNothing(_Row) Then
                MsgBox("Dvd déjà scanné ... boite4", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "Dvd déjà scanné ... boite4"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If

            Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                        " P.products_model as products_model, PD.stock_type as stock_type, PD.inout as products_io FROM products_dvd PD " & _
                        " Left join products P on P.products_id = PD.products_id " & _
                        " where PD.products_id = " & _objProductDVD.ProductsId & " AND PD.products_dvdid = " & _objProductDVD.DvdId

            BKGlobal.Cls1.FillDataSet(_DS.Tables("products_dvd_stock_5"), _SQLTxt)
            If _DS.Tables("products_dvd_stock_5").Rows.Count = 0 Then
                MsgBox("Invalid DVD, Gve it to Fred or Manu", MsgBoxStyle.Critical)
                '_frm.Label1.Text = "Invalid DVD, Gve it to Fred or Manu"
                '_frm.ShowDialog(Me)
                EnableBarCode()
                Exit Sub
            End If
            _OLDRow = _DS.Tables("products_dvd_stock_5").Rows(0)
            Dim TableDestIndice As Int16 = 0
            If (_OLDRow.Item("stock_type") = "P") Or (_OLDRow.Item("stock_type") = "M") Then
                TableDestIndice = 2
            Else
                If CEBadSticker.Checked = True Then
                    TableDestIndice = 3
                Else
                    If _OLDRow.Item("products_io") = 0 Then
                        TableDestIndice = 4
                    End If
                    TableDestIndice = 1
                End If
            End If
            _NewRow = objDS.Tables("products_dvd_stock_" & TableDestIndice).NewRow


            '_NewRow.ItemArray = _OLDRow.ItemArray
            _NewRow.Item("products_id") = _OLDRow.Item("products_id")
            _NewRow.Item("products_dvdid") = _OLDRow.Item("products_dvdid")
            _NewRow.Item("products_dvd_status") = _OLDRow.Item("products_dvd_status")


            _NewRow.Item("bar_code") = txtBarCode.Text

            Dim _objProduct As clsProduct_DVD
            _objProduct = New clsProduct_DVD(SessionInfo, _DS, _NewRow.Item("products_id"), _NewRow.Item("products_dvdid"))
            Select Case TableDestIndice
                Case 1
                    _NewRow.Item("box_id") = TBBoxReadyToRent.EditValue
                    _NewRow.Item("pibox_id") = Pos_ID_IBox_ReadyToRent
                    Pos_ID_IBox_ReadyToRent += 1
                    _objProduct.SetProductsStatusBox(1, _NewRow.Item("box_id"), _NewRow.Item("pibox_id"))

                Case 2
                    _NewRow.Item("box_id") = TBBoxStockPassif.EditValue
                    _NewRow.Item("pibox_id") = Pos_ID_IBox_StockPassif
                    Pos_ID_IBox_StockPassif += 1
                    _objProduct.SetProductsStatusBox(1, _NewRow.Item("box_id"), _NewRow.Item("pibox_id"))

                Case 3
                    _NewRow.Item("box_id") = TBBoxBadSticker.EditValue
                    _NewRow.Item("pibox_id") = Pos_ID_IBox_BadSticker
                    Pos_ID_IBox_BadSticker += 1
                    _objProduct.SetProductsStatusBox(1, _NewRow.Item("box_id"), _NewRow.Item("pibox_id"))
                Case 4
                    _NewRow.Item("box_id") = TBBoxExept.EditValue
                    _NewRow.Item("pibox_id") = Pos_ID_IBox_Exept
                    Pos_ID_IBox_Exept += 1
                    _objProduct.SetProductsStatusBox(1, _NewRow.Item("box_id"), _NewRow.Item("pibox_id"))

            End Select
            SetPictVisible(TableDestIndice)
            objDS.Tables("products_dvd_stock_" & TableDestIndice).Rows.Add(_NewRow)
            If objDS.Tables("products_dvd_stock_" & TableDestIndice).Rows.Count >= NbrDVDByBox Then
                MsgBox("Changer la boite " & TableDestIndice)
                '_frm.Label1.Text = "Changer la boite " & TableDestIndice
                '_frm.ShowDialog(Me)
            End If
            EnableBarCode()
            'txtBarCode.Enabled = True
            'txtBarCode.EditValue = ""
            'txtBarCode.Refresh()
            'txtBarCode.Focus()
            'DoEvents()
        Else
            DoEvents()
        End If
    End Sub
    Private Sub SetPictVisible(ByVal vPos As Int16)
        PictActif.Visible = False
        PictBadLabel.Visible = False
        PictExcept.Visible = False
        PictPassif.Visible = False
        Select Case vPos
            Case 1
                PictActif.Visible = True
            Case 2
                PictPassif.Visible = True
            Case 3
                PictBadLabel.Visible = True
            Case 4
                PictExcept.Visible = True
        End Select
    End Sub
    Private Sub EnableBarCode()
        txtBarCode.Text = ""
        txtBarCode.Enabled = True
        txtBarCode.Focus()
        txtBarCode.Refresh()
        'DoEvents()

    End Sub

    Private Sub btnPrintLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProducts As New clsProducts(SessionInfo)
        For Each _row In objDS.Tables("products_dvd_stock_1").Rows
            '_row.Item("bar_code") = barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow = _DS.Tables("products_labels").NewRow
            _labelRow.Item("products_id") = _row.Item("products_id")
            _labelRow.Item("dvd_id") = _row.Item("products_dvdid")
            _labelRow.Item("IDStr") = _row.Item("products_id") & "-" & _row.Item("products_dvdid")
            _labelRow.Item("bar_code") = _objProducts.barcode(_row.Item("products_id"), _row.Item("products_dvdid"))
            _labelRow.Item("Lang") = _objProducts.GetProductLangLabel(_row.Item("products_id"))
            _DS.Tables("products_labels").Rows.Add(_labelRow)
        Next
        Dim _rpt As New rptDVDLabel
        _rpt.objDS = _DS
        _rpt.DataMember = ""
        _rpt.DataSource = _DS.Tables("products_labels")
        _rpt.ShowPreview()
    End Sub

    Private Sub txtBoxID_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        Dim _answ As MsgBoxResult
        If objDS.Tables("products_dvd_stock_1").Rows.Count > 0 And objDS.Tables("products_dvd_stock_2").Rows.Count > 0 Then
            _answ = MsgBox("Do you want to save before changing the BOX ID ?", MsgBoxStyle.YesNoCancel, "Confirme")
            If _answ = MsgBoxResult.Cancel Then
                e.Cancel = True
                Exit Sub
            End If
            If _answ = MsgBoxResult.No Then
                objDS.Tables("products_dvd_stock_1").Clear()
            End If
            If _answ = MsgBoxResult.Yes Then
                '                SaveTheBox()
            End If
        End If
    End Sub
    Private Function ValidAllBoxId() As Int16
        If TBBoxReadyToRent.EditValue = "" Then
            System.Windows.Forms.MessageBox.Show("BoxId must be set")
            TBBoxReadyToRent.Focus()
            Return 1
        End If
        If TBBoxStockPassif.EditValue = "" Then
            System.Windows.Forms.MessageBox.Show("BoxId must be set")
            TBBoxStockPassif.Focus()
            Return 1
        End If
        If TBBoxBadSticker.EditValue = "" Then
            System.Windows.Forms.MessageBox.Show("BoxId must be set")
            TBBoxBadSticker.Focus()
            Return 1
        End If
        If TBBoxExept.EditValue = "" Then
            System.Windows.Forms.MessageBox.Show("BoxId must be set")
            TBBoxExept.Focus()
            Return 1
        End If
        Return 0
    End Function

    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindBarCode.Click
        Dim _productsId As Integer
        Dim _dvdId As Integer
        Dim _objProdDVD As clsProduct_DVD
        txtBarCode.Text.Trim()
        If txtBarCode.Text.IndexOf("-") <> -1 Then
            _productsId = txtBarCode.Text.Substring(0, txtBarCode.Text.IndexOf("-"))
            _dvdId = txtBarCode.Text.Substring(txtBarCode.Text.IndexOf("-") + 1)
            _objProdDVD = New clsProduct_DVD(SessionInfo, objDS, _productsId, _dvdId)
            If _objProdDVD.BarCode.IsBarCodeValid Then
                txtBarCode.Text = _objProdDVD.BarCode.BarcodeWithCheckDigit
                txtBarCode.Refresh()
            Else

            End If
        End If
        txtBarCode.Enabled = True
    End Sub

    Private Sub RefreshDG(ByVal TableIndex As Int16)
        Dim TableName As String = "products_dvd_stock_" & TableIndex
        Dim searchkey As String = ""
        Select Case TableIndex
            Case 1
                searchkey = TBBoxReadyToRent.Text
            Case 2
                searchkey = TBBoxStockPassif.Text
            Case 3
                searchkey = TBBoxBadSticker.Text
            Case 4
                searchkey = TBBoxExept.Text
        End Select


        Dim _SQLTxt As String = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, P.products_model as products_model FROM products_dvd PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where PD.box_id = '" & searchkey & "' Order by pibox_id "
        objDS.Tables(TableName).Clear()

        'Pos_ID_IBox_ReadyToRent = 1
        BKGlobal.Cls1.FillDataSet(objDS.Tables(TableName), _SQLTxt)
        If objDS.Tables(TableName).Rows.Count <> 0 Then
            MsgBox("Box non vide", MsgBoxStyle.Critical)
        End If
        Select Case TableIndex
            Case 1
                Pos_ID_IBox_ReadyToRent = objDS.Tables(TableName).Rows.Count + 1
            Case 2
                Pos_ID_IBox_StockPassif = objDS.Tables(TableName).Rows.Count + 1
            Case 3
                Pos_ID_IBox_BadSticker = objDS.Tables(TableName).Rows.Count + 1
            Case 4
                Pos_ID_IBox_Exept = objDS.Tables(TableName).Rows.Count + 1
        End Select
        txtBarCode.Enabled = True
        txtBarCode.Focus()
    End Sub

    Private Sub ClearDG(ByVal TableIndex As Int16)
        Dim TableName As String = "products_dvd_stock_" & TableIndex

        Dim _row, _labelRow As DataRow
        Dim _DS As New dsProducts
        Dim _objProduct As clsProduct_DVD
        For Each _row In objDS.Tables(TableName).Rows
            _objProduct = New clsProduct_DVD(SessionInfo, _DS, _row.Item("products_id"), _row.Item("products_dvdid"))
            _objProduct.SetProductsStatusBox(15, 999999, 999999)
        Next
    End Sub

    Private Sub btnSearchActif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchActif.Click
        RefreshDG(1)
    End Sub

    Private Sub CEBadSticker_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEBadSticker.CheckedChanged
        txtBarCode.Focus()
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        ClearDG(1)
    End Sub

    Private Sub btnSearchPassif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPassif.Click
        RefreshDG(2)
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        ClearDG(2)
    End Sub

    Private Sub btnSearchBadLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBadLabel.Click
        RefreshDG(3)
    End Sub

    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        ClearDG(3)
    End Sub

    Private Sub btnSearchExcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchExcept.Click
        RefreshDG(4)
    End Sub

    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        ClearDG(4)
    End Sub

    Private Sub txtBarCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtBarCode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
    End Sub

    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK1.Click
        DoEvents()
        'MsgBox("eeee")
        If ValidAllBoxId() = 0 And txtBarCode.Text.Length = 13 Then
            BarCode_OK()
        Else
            DoEvents()
        End If
    End Sub

    Private Sub PartDelete(ByVal z As Int16)
        Dim TableName As String = "products_dvd_stock_" & z

        Dim GVTmp As DevExpress.XtraGrid.Views.Grid.GridView
        Select Case z
            Case 1
                GVTmp = GVReadyToRent
            Case 2
                GVTmp = GVStockPassif
            Case 3
                GVTmp = GVBadSticker
            Case 4
                GVTmp = GVExept
        End Select

        If GVTmp.SelectedRowsCount = 0 Then
            Exit Sub
        End If

        Dim _DS As New dsProducts
        Dim _Row As DataRow
        Dim _Rows() As DataRow
        Dim I As Integer
        Dim _objProduct As clsProduct_DVD

        ReDim _Rows(GVTmp.SelectedRowsCount - 1)
        For I = 0 To GVTmp.SelectedRowsCount - 1
            _Rows(I) = GVTmp.GetDataRow(GVTmp.GetSelectedRows(I))
            _objProduct = New clsProduct_DVD(SessionInfo, _DS, _Rows(I).Item("products_id"), _Rows(I).Item("products_dvdid"))
            _objProduct.SetProductsStatusBox(15, 999999, 999999)
        Next

        GVTmp.BeginSort()
        Try
            For Each _Row In _Rows
                _Row.Delete()
            Next
        Finally
            GVTmp.EndSort()
        End Try
        I = 1
        For Each _Row In objDS.Tables(TableName).Rows
            If Not _Row.RowState = DataRowState.Deleted Then
                _objProduct = New clsProduct_DVD(SessionInfo, _DS, _Row.Item("products_id"), _Row.Item("products_dvdid"))
                _objProduct.SetProductsStatusBox(_Row.Item("products_dvd_status"), _Row.Item("box_id"), I)
                _Row.BeginEdit()
                _Row.Item("pibox_id") = I
                _Row.EndEdit()
                I += 1
            End If
        Next
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPartDeleteReadyToRent.Click
        PartDelete(1)
        txtBarCode.Focus()
    End Sub

    Private Sub BTPartDeleteStockPassif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPartDeleteStockPassif.Click
        PartDelete(2)
        txtBarCode.Focus()
    End Sub

    Private Sub BTPartDeleteBadSticker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPartDeleteBadSticker.Click
        PartDelete(3)
        txtBarCode.Focus()
    End Sub

    Private Sub BTPartDeleteExept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPartDeleteExept.Click
        PartDelete(4)
        txtBarCode.Focus()
    End Sub
End Class
