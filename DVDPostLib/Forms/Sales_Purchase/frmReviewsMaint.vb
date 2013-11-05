Imports System.Windows.Forms.Application
Public Class frmReviewsMaint
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
    Friend WithEvents DsProducts1 As DVDPostLib.dsProducts
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReviewID As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAcceptAndSave As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtCustomerID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtProductTitle As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCustomerName As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnDeleteReview As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtReviewRating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Public WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtLast_modified As DevExpress.XtraEditors.DateEdit
    Public WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReviews_Read As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReview_Check As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReview_Corrected As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCust_Best_Rating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtCust_Bad_Rating As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtLanguage_id As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReview_Text As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnSaveOnly As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtReviewID = New DevExpress.XtraEditors.TextEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnAcceptAndSave = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomerID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomerName = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.btnDeleteReview = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveOnly = New DevExpress.XtraEditors.SimpleButton
        Me.DsProducts1 = New DVDPostLib.dsProducts
        Me.txtReviewRating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
        Me.txtLast_modified = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtReviews_Read = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Check = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Corrected = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtCust_Best_Rating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtCust_Bad_Rating = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtLanguage_id = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtReview_Text = New DevExpress.XtraEditors.MemoEdit
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviewID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviewRating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLast_modified.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLast_modified.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReviews_Read.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Corrected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust_Best_Rating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCust_Bad_Rating.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLanguage_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReview_Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Review ID"
        '
        'txtReviewID
        '
        Me.txtReviewID.Location = New System.Drawing.Point(144, 56)
        Me.txtReviewID.Name = "txtReviewID"
        Me.txtReviewID.Size = New System.Drawing.Size(100, 20)
        Me.txtReviewID.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(248, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.ToolTip = "Rechercher les info de cette commande"
        '
        'btnAcceptAndSave
        '
        Me.btnAcceptAndSave.Location = New System.Drawing.Point(446, 56)
        Me.btnAcceptAndSave.Name = "btnAcceptAndSave"
        Me.btnAcceptAndSave.Size = New System.Drawing.Size(104, 23)
        Me.btnAcceptAndSave.TabIndex = 7
        Me.btnAcceptAndSave.Text = "Save and Accept"
        Me.btnAcceptAndSave.ToolTip = "Supprimer cette commande"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(144, 92)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Customer ID"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(144, 142)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 11
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 145)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Product ID"
        '
        'txtProductTitle
        '
        Me.txtProductTitle.Enabled = False
        Me.txtProductTitle.Location = New System.Drawing.Point(144, 168)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(296, 20)
        Me.txtProductTitle.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(32, 171)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Title"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Enabled = False
        Me.txtCustomerName.Location = New System.Drawing.Point(144, 116)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(296, 20)
        Me.txtCustomerName.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(32, 116)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Customer Name"
        '
        'btnDeleteReview
        '
        Me.btnDeleteReview.Location = New System.Drawing.Point(336, 56)
        Me.btnDeleteReview.Name = "btnDeleteReview"
        Me.btnDeleteReview.Size = New System.Drawing.Size(104, 23)
        Me.btnDeleteReview.TabIndex = 28
        Me.btnDeleteReview.Text = "Delete Review"
        Me.btnDeleteReview.ToolTip = "Definir ce DVD comme Bizzarement Perdu"
        '
        'btnSaveOnly
        '
        Me.btnSaveOnly.Location = New System.Drawing.Point(556, 56)
        Me.btnSaveOnly.Name = "btnSaveOnly"
        Me.btnSaveOnly.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveOnly.TabIndex = 29
        Me.btnSaveOnly.Text = "Save Only"
        Me.btnSaveOnly.ToolTip = "Supprimer cette commande"
        '
        'DsProducts1
        '
        Me.DsProducts1.DataSetName = "dsProducts"
        Me.DsProducts1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtReviewRating
        '
        Me.txtReviewRating.Enabled = False
        Me.txtReviewRating.Location = New System.Drawing.Point(560, 116)
        Me.txtReviewRating.Name = "txtReviewRating"
        Me.txtReviewRating.Size = New System.Drawing.Size(100, 20)
        Me.txtReviewRating.TabIndex = 31
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(471, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Review Rating"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(471, 93)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Date Added"
        '
        'txtDateAdded
        '
        Me.txtDateAdded.EditValue = Nothing
        Me.txtDateAdded.Enabled = False
        Me.txtDateAdded.Location = New System.Drawing.Point(560, 90)
        Me.txtDateAdded.Name = "txtDateAdded"
        Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDateAdded.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDateAdded.Size = New System.Drawing.Size(100, 20)
        Me.txtDateAdded.TabIndex = 33
        '
        'txtLast_modified
        '
        Me.txtLast_modified.EditValue = Nothing
        Me.txtLast_modified.Enabled = False
        Me.txtLast_modified.Location = New System.Drawing.Point(771, 89)
        Me.txtLast_modified.Name = "txtLast_modified"
        Me.txtLast_modified.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtLast_modified.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtLast_modified.Size = New System.Drawing.Size(100, 20)
        Me.txtLast_modified.TabIndex = 35
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(671, 92)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Last Modified"
        '
        'txtReviews_Read
        '
        Me.txtReviews_Read.Enabled = False
        Me.txtReviews_Read.Location = New System.Drawing.Point(771, 116)
        Me.txtReviews_Read.Name = "txtReviews_Read"
        Me.txtReviews_Read.Size = New System.Drawing.Size(100, 20)
        Me.txtReviews_Read.TabIndex = 37
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(671, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl9.TabIndex = 36
        Me.LabelControl9.Text = "Review Read"
        '
        'txtReview_Check
        '
        Me.txtReview_Check.Enabled = False
        Me.txtReview_Check.Location = New System.Drawing.Point(771, 142)
        Me.txtReview_Check.Name = "txtReview_Check"
        Me.txtReview_Check.Size = New System.Drawing.Size(100, 20)
        Me.txtReview_Check.TabIndex = 39
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(671, 145)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "Review Check"
        '
        'txtReview_Corrected
        '
        Me.txtReview_Corrected.Enabled = False
        Me.txtReview_Corrected.Location = New System.Drawing.Point(771, 168)
        Me.txtReview_Corrected.Name = "txtReview_Corrected"
        Me.txtReview_Corrected.Size = New System.Drawing.Size(100, 20)
        Me.txtReview_Corrected.TabIndex = 41
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(671, 171)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl11.TabIndex = 40
        Me.LabelControl11.Text = "Review Corrected"
        '
        'txtCust_Best_Rating
        '
        Me.txtCust_Best_Rating.Enabled = False
        Me.txtCust_Best_Rating.Location = New System.Drawing.Point(560, 142)
        Me.txtCust_Best_Rating.Name = "txtCust_Best_Rating"
        Me.txtCust_Best_Rating.Size = New System.Drawing.Size(100, 20)
        Me.txtCust_Best_Rating.TabIndex = 43
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(471, 145)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl12.TabIndex = 42
        Me.LabelControl12.Text = "Cust Best Rating"
        '
        'txtCust_Bad_Rating
        '
        Me.txtCust_Bad_Rating.Enabled = False
        Me.txtCust_Bad_Rating.Location = New System.Drawing.Point(560, 168)
        Me.txtCust_Bad_Rating.Name = "txtCust_Bad_Rating"
        Me.txtCust_Bad_Rating.Size = New System.Drawing.Size(100, 20)
        Me.txtCust_Bad_Rating.TabIndex = 45
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(471, 171)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl13.TabIndex = 44
        Me.LabelControl13.Text = "Cust Best Rating"
        '
        'txtLanguage_id
        '
        Me.txtLanguage_id.Enabled = False
        Me.txtLanguage_id.Location = New System.Drawing.Point(340, 89)
        Me.txtLanguage_id.Name = "txtLanguage_id"
        Me.txtLanguage_id.Size = New System.Drawing.Size(100, 20)
        Me.txtLanguage_id.TabIndex = 47
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(251, 92)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl14.TabIndex = 46
        Me.LabelControl14.Text = "Language ID"
        '
        'txtReview_Text
        '
        Me.txtReview_Text.Location = New System.Drawing.Point(144, 206)
        Me.txtReview_Text.Name = "txtReview_Text"
        Me.txtReview_Text.Size = New System.Drawing.Size(727, 148)
        Me.txtReview_Text.TabIndex = 48
        '
        'frmReviewsMaint
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 366)
        Me.Controls.Add(Me.txtReview_Text)
        Me.Controls.Add(Me.txtLanguage_id)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtCust_Bad_Rating)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtCust_Best_Rating)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtReview_Corrected)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtReview_Check)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtReviews_Read)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtLast_modified)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txtDateAdded)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtReviewRating)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btnSaveOnly)
        Me.Controls.Add(Me.btnDeleteReview)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtProductTitle)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnAcceptAndSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtReviewID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmReviewsMaint"
        Me.Text = "frmReviewsMaint"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtReviewID, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnAcceptAndSave, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtProductID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.txtProductTitle, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.txtCustomerName, 0)
        Me.Controls.SetChildIndex(Me.btnDeleteReview, 0)
        Me.Controls.SetChildIndex(Me.btnSaveOnly, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.txtReviewRating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.txtDateAdded, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.txtLast_modified, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.txtReviews_Read, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Check, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Corrected, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.txtCust_Best_Rating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl13, 0)
        Me.Controls.SetChildIndex(Me.txtCust_Bad_Rating, 0)
        Me.Controls.SetChildIndex(Me.LabelControl14, 0)
        Me.Controls.SetChildIndex(Me.txtLanguage_id, 0)
        Me.Controls.SetChildIndex(Me.txtReview_Text, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviewID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProducts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviewRating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateAdded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLast_modified.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLast_modified.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReviews_Read.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Corrected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust_Best_Rating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCust_Bad_Rating.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLanguage_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReview_Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim ReviewsTable As New DataTable("Reviews")
    Dim CustomerTable As New DataTable("customers")
    Dim ReviewRow As DataRow
    Dim objProductsDVD As clsProduct_DVD
    Public Need_A_Reload As Boolean = False

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchReviewInfo()
    End Sub
    Public Sub SearchReviewInfo()
        If txtReviewID.EditValue & "" = "" Then Exit Sub
        If Not IsNumeric(txtReviewID.EditValue) Then Exit Sub
        Dim _SQLTxt As String
        _SQLTxt = "SELECT * FROM reviews " & _
                  " WHERE reviews_id = " & txtReviewID.EditValue
        ReviewsTable.Clear()
        DvdPostData.clsConnection.FillDataSet(ReviewsTable, _SQLTxt)
        If ReviewsTable.Rows.Count = 1 Then
            ReviewRow = ReviewsTable.Rows(0)
        Else
            ReviewRow = Nothing
        End If
        If Not IsNothing(ReviewRow) Then
            CustomerTable.Clear()
            DvdPostData.clsConnection.FillDataSet(CustomerTable, "SELECT * From customers where customers_id = " & ReviewRow("customers_id"))
            objProductsDVD = New clsProduct_DVD(SessionInfo, DsProducts1, ReviewRow("products_id"), 0)
            txtCustomerID.EditValue = ReviewRow("customers_id")
            txtCustomerName.EditValue = CustomerTable.Rows(0)("customers_lastname") & " " & CustomerTable.Rows(0)("customers_firstname")
            txtProductID.EditValue = ReviewRow("products_id")
            txtProductTitle.EditValue = objProductsDVD.Product_row("products_title")
            txtLanguage_id.EditValue = ReviewRow("customers_id")
            txtDateAdded.EditValue = ReviewRow("date_added")
            txtReviewRating.EditValue = ReviewRow("reviews_rating")
            txtCust_Best_Rating.EditValue = ReviewRow("customers_best_rating")
            txtCust_Bad_Rating.EditValue = ReviewRow("customers_bad_rating")
            txtLast_modified.EditValue = ReviewRow("last_modified")
            txtReviews_Read.EditValue = ReviewRow("reviews_read")
            txtReview_Check.EditValue = ReviewRow("reviews_check")
            txtReview_Corrected.EditValue = ReviewRow("reviews_corrected")
            txtReview_Text.Text = ReviewRow("reviews_text")
        Else
            txtCustomerID.EditValue = ""
            txtCustomerName.EditValue = "REVIEW NON TROUVEE"
            txtProductID.EditValue = ""
            txtProductTitle.EditValue = "REVIEW NON TROUVEE"
            txtLanguage_id.EditValue = ""
            txtDateAdded.EditValue = ""
            txtReviewRating.EditValue = ""
            txtCust_Best_Rating.EditValue = ""
            txtCust_Bad_Rating.EditValue = ""
            txtLast_modified.EditValue = ""
            txtReviews_Read.EditValue = ""
            txtReview_Check.EditValue = ""
            txtReview_Corrected.EditValue = ""
            txtReview_Text.Text = ""
        End If
    End Sub

    Private Sub btnDeleteReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteReview.Click
        Dim _answ As MsgBoxResult = MsgBox("Do you really want to delete this review?", MsgBoxStyle.YesNo)
        If _answ = MsgBoxResult.No Then Exit Sub
        Dim _SQLTXt As String = "DELETE FROM reviews where reviews_id = " & txtReviewID.EditValue
        Dim _del As Int32 = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTXt)
        If _del <> 1 Then
            MsgBox("Cannot delete this review.", MsgBoxStyle.Critical)
        Else
            Need_A_Reload = True
            Me.Hide()
        End If

    End Sub
    Private Sub btnSaveOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOnly.Click
        If String.Equals(ReviewRow("reviews_text"), txtReview_Text.Text, StringComparison.InvariantCultureIgnoreCase) = False Then
            ReviewRow("reviews_corrected") = 1
        End If
        ReviewRow("reviews_text") = txtReview_Text.Text
        ReviewRow("last_modified") = Now.ToString("yyyy-MM-dd HH:mm:ss")
        BKGlobal.Cls1.UpdateDataSource(ReviewsTable, "SELECT * FROM reviews")
        SearchReviewInfo()
    End Sub

    Private Sub btnAcceptAndSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptAndSave.Click
        ReviewRow("reviews_check") = 1
        If String.Equals(ReviewRow("reviews_text"), txtReview_Text.Text, StringComparison.InvariantCultureIgnoreCase) = False Then
            ReviewRow("reviews_corrected") = 1
        End If
        ReviewRow("reviews_text") = txtReview_Text.Text
        ReviewRow("last_modified") = Now.ToString("yyyy-MM-dd HH:mm:ss")
        BKGlobal.Cls1.UpdateDataSource(ReviewsTable, "SELECT * FROM reviews")
        Need_A_Reload = True
        Me.Hide()
    End Sub
End Class

