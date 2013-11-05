Imports System.IO
Imports System.Collections.Generic
Public Class frmThemeEvent
    Inherits BizzLib.frmBKForm
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        AddEventCtrl(TabPictures, GetType(DevExpress.XtraEditors.PictureEdit))

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
    Friend WithEvents XtraTabControlTheme As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabDetail As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl

    Friend WithEvents lblEventThemeId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnNewTheme As DevExpress.XtraEditors.SimpleButton

    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As PlushBuziness.contextMenu
    Friend WithEvents DsSite1 As PlushLib.DsSite
    Friend WithEvents GridThemeEvent As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewThemeEvent As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GpBanner As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPage_border_color As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPage_border_color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBannerMenu_text_color As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblBanner_menu_text_color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GpBackground As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblBackground_attachment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblBackground_color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBackground_color As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditTheme As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewTheme_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtEventThemeId_edit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTitleEdit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkLogoPicture As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents image_Logo_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabControl_Logo_Image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabLogoFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLogoNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLogoEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_Logo_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents image_Logo_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents OFDPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabPictures As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabBackground As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabLogo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabBanner_page As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabBanner_menu As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gpPicture As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkBackground As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabControl_Background_Image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabBackgroundFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_Background_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBackgroundNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_Background_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBackgroundEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_Background_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabControl_BannerMenu_Image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabBanner_menuFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_BannerMenu_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBanner_menuNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_BannerMenu_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBanner_menuEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_BannerMenu_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents chkBannerMenu As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbBackgroundAttachment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tabTitle_page As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabControl_Bannerpage_image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents image_banner_page_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBannerPageNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_banner_page_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabBannerPageEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_banner_page_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents chkBannerPage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabControl_TitlePage_image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTitlePageFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_title_page_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents image_title_page_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabTitlePageEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_title_page_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents chkTitlePage As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabTitlePageNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabThumbs As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabControl_thumbs_image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_thumbs_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_thumbs_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_thumbs_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents chkthumbs As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbSelectedType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tabHomePage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabControl_home_page_image As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabhome_pageFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_home_page_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabhome_pageNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_home_page_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents tabhome_pageEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents image_home_page_EN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents chkhome_page As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GpHome_Page As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_home_page_color As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_HP_Color As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLastModified As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCreatedAt As DevExpress.XtraEditors.TextEdit




    Friend WithEvents TxtEventThemeId As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim tabBannerPageFR As DevExpress.XtraTab.XtraTabPage
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemeEvent))
        Me.image_banner_page_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.TxtEventThemeId = New DevExpress.XtraEditors.TextEdit
        Me.btnNewTheme = New DevExpress.XtraEditors.SimpleButton
        Me.lblEventThemeId = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.tabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridThemeEvent = New DevExpress.XtraGrid.GridControl
        Me.GridViewThemeEvent = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.DsSite1 = New PlushLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New PlushBuziness.contextMenu
        Me.XtraTabControlTheme = New DevExpress.XtraTab.XtraTabControl
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage
        Me.txtLastModified = New DevExpress.XtraEditors.TextEdit
        Me.txtCreatedAt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GpHome_Page = New DevExpress.XtraEditors.GroupControl
        Me.txt_home_page_color = New DevExpress.XtraEditors.TextEdit
        Me.lbl_HP_Color = New DevExpress.XtraEditors.LabelControl
        Me.cmbSelectedType = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblType = New DevExpress.XtraEditors.LabelControl
        Me.gpPicture = New DevExpress.XtraEditors.GroupControl
        Me.TabPictures = New DevExpress.XtraTab.XtraTabControl
        Me.tabBackground = New DevExpress.XtraTab.XtraTabPage
        Me.chkBackground = New DevExpress.XtraEditors.CheckEdit
        Me.tabControl_Background_Image = New DevExpress.XtraTab.XtraTabControl
        Me.tabBackgroundFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_Background_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabBackgroundNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_Background_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabBackgroundEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_Background_EN = New DevExpress.XtraEditors.PictureEdit
        Me.tabLogo = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_Logo_Image = New DevExpress.XtraTab.XtraTabControl
        Me.tabLogoFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_Logo_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabLogoNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_Logo_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabLogoEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_Logo_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkLogoPicture = New DevExpress.XtraEditors.CheckEdit
        Me.tabBanner_page = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_Bannerpage_image = New DevExpress.XtraTab.XtraTabControl
        Me.tabBannerPageNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_banner_page_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabBannerPageEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_banner_page_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkBannerPage = New DevExpress.XtraEditors.CheckEdit
        Me.tabBanner_menu = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_BannerMenu_Image = New DevExpress.XtraTab.XtraTabControl
        Me.tabBanner_menuFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_BannerMenu_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabBanner_menuNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_BannerMenu_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabBanner_menuEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_BannerMenu_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkBannerMenu = New DevExpress.XtraEditors.CheckEdit
        Me.tabTitle_page = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_TitlePage_image = New DevExpress.XtraTab.XtraTabControl
        Me.tabTitlePageFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabTitlePageNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabTitlePageEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_title_page_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkTitlePage = New DevExpress.XtraEditors.CheckEdit
        Me.tabThumbs = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_thumbs_image = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.image_thumbs_FR = New DevExpress.XtraEditors.PictureEdit
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.image_thumbs_NL = New DevExpress.XtraEditors.PictureEdit
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.image_thumbs_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkthumbs = New DevExpress.XtraEditors.CheckEdit
        Me.tabHomePage = New DevExpress.XtraTab.XtraTabPage
        Me.tabControl_home_page_image = New DevExpress.XtraTab.XtraTabControl
        Me.tabhome_pageFR = New DevExpress.XtraTab.XtraTabPage
        Me.image_home_page_FR = New DevExpress.XtraEditors.PictureEdit
        Me.tabhome_pageNL = New DevExpress.XtraTab.XtraTabPage
        Me.image_home_page_NL = New DevExpress.XtraEditors.PictureEdit
        Me.tabhome_pageEN = New DevExpress.XtraTab.XtraTabPage
        Me.image_home_page_EN = New DevExpress.XtraEditors.PictureEdit
        Me.chkhome_page = New DevExpress.XtraEditors.CheckEdit
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.GpBanner = New DevExpress.XtraEditors.GroupControl
        Me.txtPage_border_color = New DevExpress.XtraEditors.TextEdit
        Me.lblPage_border_color = New DevExpress.XtraEditors.LabelControl
        Me.txtBannerMenu_text_color = New DevExpress.XtraEditors.TextEdit
        Me.lblBanner_menu_text_color = New DevExpress.XtraEditors.LabelControl
        Me.GpBackground = New DevExpress.XtraEditors.GroupControl
        Me.cmbBackgroundAttachment = New DevExpress.XtraEditors.LookUpEdit
        Me.lblBackground_attachment = New DevExpress.XtraEditors.LabelControl
        Me.lblBackground_color = New DevExpress.XtraEditors.LabelControl
        Me.txtBackground_color = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditTheme = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewTheme_edit = New DevExpress.XtraEditors.SimpleButton
        Me.TxtEventThemeId_edit = New DevExpress.XtraEditors.TextEdit
        Me.txtTitleEdit = New DevExpress.XtraEditors.TextEdit
        Me.lblTitleEdit = New DevExpress.XtraEditors.LabelControl
        Me.OFDPicture = New System.Windows.Forms.OpenFileDialog
        tabBannerPageFR = New DevExpress.XtraTab.XtraTabPage
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        tabBannerPageFR.SuspendLayout()
        CType(Me.image_banner_page_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult.SuspendLayout()
        CType(Me.GridThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewThemeEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlTheme.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        CType(Me.txtLastModified.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreatedAt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GpHome_Page, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpHome_Page.SuspendLayout()
        CType(Me.txt_home_page_color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSelectedType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpPicture.SuspendLayout()
        CType(Me.TabPictures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPictures.SuspendLayout()
        Me.tabBackground.SuspendLayout()
        CType(Me.chkBackground.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControl_Background_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_Background_Image.SuspendLayout()
        Me.tabBackgroundFR.SuspendLayout()
        CType(Me.image_Background_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBackgroundNL.SuspendLayout()
        CType(Me.image_Background_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBackgroundEN.SuspendLayout()
        CType(Me.image_Background_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogo.SuspendLayout()
        CType(Me.tabControl_Logo_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_Logo_Image.SuspendLayout()
        Me.tabLogoFR.SuspendLayout()
        CType(Me.image_Logo_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogoNL.SuspendLayout()
        CType(Me.image_Logo_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogoEN.SuspendLayout()
        CType(Me.image_Logo_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLogoPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBanner_page.SuspendLayout()
        CType(Me.tabControl_Bannerpage_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_Bannerpage_image.SuspendLayout()
        Me.tabBannerPageNL.SuspendLayout()
        CType(Me.image_banner_page_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBannerPageEN.SuspendLayout()
        CType(Me.image_banner_page_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBannerPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBanner_menu.SuspendLayout()
        CType(Me.tabControl_BannerMenu_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_BannerMenu_Image.SuspendLayout()
        Me.tabBanner_menuFR.SuspendLayout()
        CType(Me.image_BannerMenu_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBanner_menuNL.SuspendLayout()
        CType(Me.image_BannerMenu_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBanner_menuEN.SuspendLayout()
        CType(Me.image_BannerMenu_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkBannerMenu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitle_page.SuspendLayout()
        CType(Me.tabControl_TitlePage_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_TitlePage_image.SuspendLayout()
        Me.tabTitlePageFR.SuspendLayout()
        CType(Me.image_title_page_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitlePageNL.SuspendLayout()
        CType(Me.image_title_page_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTitlePageEN.SuspendLayout()
        CType(Me.image_title_page_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTitlePage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabThumbs.SuspendLayout()
        CType(Me.tabControl_thumbs_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_thumbs_image.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.image_thumbs_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.image_thumbs_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.image_thumbs_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkthumbs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHomePage.SuspendLayout()
        CType(Me.tabControl_home_page_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl_home_page_image.SuspendLayout()
        Me.tabhome_pageFR.SuspendLayout()
        CType(Me.image_home_page_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabhome_pageNL.SuspendLayout()
        CType(Me.image_home_page_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabhome_pageEN.SuspendLayout()
        CType(Me.image_home_page_EN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkhome_page.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GpBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBanner.SuspendLayout()
        CType(Me.txtPage_border_color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBannerMenu_text_color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GpBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBackground.SuspendLayout()
        CType(Me.cmbBackgroundAttachment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBackground_color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBannerPageFR
        '
        tabBannerPageFR.Controls.Add(Me.image_banner_page_FR)
        tabBannerPageFR.Name = "tabBannerPageFR"
        resources.ApplyResources(tabBannerPageFR, "tabBannerPageFR")
        tabBannerPageFR.Tag = "FR"
        '
        'image_banner_page_FR
        '
        resources.ApplyResources(Me.image_banner_page_FR, "image_banner_page_FR")
        Me.image_banner_page_FR.Name = "image_banner_page_FR"
        Me.image_banner_page_FR.Properties.ReadOnly = True
        Me.image_banner_page_FR.Properties.ShowMenu = False
        Me.image_banner_page_FR.Tag = "FR"
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GroupSearch)
        Me.tabSearch.Name = "tabSearch"
        resources.ApplyResources(Me.tabSearch, "tabSearch")
        '
        'GroupSearch
        '
        resources.ApplyResources(Me.GroupSearch, "GroupSearch")
        Me.GroupSearch.Controls.Add(Me.TxtEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnNewTheme)
        Me.GroupSearch.Controls.Add(Me.lblEventThemeId)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.lblTitle)
        Me.GroupSearch.Controls.Add(Me.txtTitle)
        Me.GroupSearch.Name = "GroupSearch"
        '
        'TxtEventThemeId
        '
        resources.ApplyResources(Me.TxtEventThemeId, "TxtEventThemeId")
        Me.TxtEventThemeId.Name = "TxtEventThemeId"
        Me.TxtEventThemeId.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtEventThemeId.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'btnNewTheme
        '
        resources.ApplyResources(Me.btnNewTheme, "btnNewTheme")
        Me.btnNewTheme.Name = "btnNewTheme"
        '
        'lblEventThemeId
        '
        resources.ApplyResources(Me.lblEventThemeId, "lblEventThemeId")
        Me.lblEventThemeId.Name = "lblEventThemeId"
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'txtTitle
        '
        resources.ApplyResources(Me.txtTitle, "txtTitle")
        Me.txtTitle.Name = "txtTitle"
        '
        'tabResult
        '
        Me.tabResult.Controls.Add(Me.GridThemeEvent)
        Me.tabResult.Name = "tabResult"
        resources.ApplyResources(Me.tabResult, "tabResult")
        '
        'GridThemeEvent
        '
        resources.ApplyResources(Me.GridThemeEvent, "GridThemeEvent")
        Me.GridThemeEvent.EmbeddedNavigator.Name = ""
        Me.GridThemeEvent.FormsUseDefaultLookAndFeel = False
        Me.GridThemeEvent.MainView = Me.GridViewThemeEvent
        Me.GridThemeEvent.Name = "GridThemeEvent"
        Me.GridThemeEvent.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewThemeEvent})
        '
        'GridViewThemeEvent
        '
        Me.GridViewThemeEvent.GridControl = Me.GridThemeEvent
        Me.GridViewThemeEvent.Name = "GridViewThemeEvent"
        Me.GridViewThemeEvent.OptionsView.ShowFooter = True
        '
        'DsSite1
        '
        Me.DsSite1.DataSetName = "DsSite"
        Me.DsSite1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkSelected
        '
        Me.chkSelected.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.selected", True))
        resources.ApplyResources(Me.chkSelected, "chkSelected")
        Me.chkSelected.Name = "chkSelected"
        Me.chkSelected.Properties.Caption = resources.GetString("chkSelected.Properties.Caption")
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        resources.ApplyResources(Me.ContextMenu1, "ContextMenu1")
        '
        'XtraTabControlTheme
        '
        resources.ApplyResources(Me.XtraTabControlTheme, "XtraTabControlTheme")
        Me.XtraTabControlTheme.Name = "XtraTabControlTheme"
        Me.XtraTabControlTheme.SelectedTabPage = Me.tabResult
        Me.XtraTabControlTheme.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult, Me.tabDetail})
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.txtLastModified)
        Me.tabDetail.Controls.Add(Me.txtCreatedAt)
        Me.tabDetail.Controls.Add(Me.LabelControl3)
        Me.tabDetail.Controls.Add(Me.LabelControl2)
        Me.tabDetail.Controls.Add(Me.GpHome_Page)
        Me.tabDetail.Controls.Add(Me.cmbSelectedType)
        Me.tabDetail.Controls.Add(Me.cmbType)
        Me.tabDetail.Controls.Add(Me.lblType)
        Me.tabDetail.Controls.Add(Me.gpPicture)
        Me.tabDetail.Controls.Add(Me.lblId)
        Me.tabDetail.Controls.Add(Me.GpBanner)
        Me.tabDetail.Controls.Add(Me.GpBackground)
        Me.tabDetail.Controls.Add(Me.LabelControl1)
        Me.tabDetail.Controls.Add(Me.btnCancel)
        Me.tabDetail.Controls.Add(Me.btnSaveTheme)
        Me.tabDetail.Controls.Add(Me.btnEditTheme)
        Me.tabDetail.Controls.Add(Me.btnNewTheme_edit)
        Me.tabDetail.Controls.Add(Me.TxtEventThemeId_edit)
        Me.tabDetail.Controls.Add(Me.txtTitleEdit)
        Me.tabDetail.Controls.Add(Me.lblTitleEdit)
        Me.tabDetail.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DsSite1, "themes_events.kind", True))
        Me.tabDetail.Name = "tabDetail"
        resources.ApplyResources(Me.tabDetail, "tabDetail")
        '
        'txtLastModified
        '
        Me.txtLastModified.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.last_modified", True))
        Me.txtLastModified.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSite1, "themes_events.last_modified", True))
        resources.ApplyResources(Me.txtLastModified, "txtLastModified")
        Me.txtLastModified.Name = "txtLastModified"
        Me.txtLastModified.Properties.ReadOnly = True
        '
        'txtCreatedAt
        '
        Me.txtCreatedAt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.created_at", True))
        Me.txtCreatedAt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSite1, "themes_events.created_at", True))
        resources.ApplyResources(Me.txtCreatedAt, "txtCreatedAt")
        Me.txtCreatedAt.Name = "txtCreatedAt"
        Me.txtCreatedAt.Properties.ReadOnly = True
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'GpHome_Page
        '
        resources.ApplyResources(Me.GpHome_Page, "GpHome_Page")
        Me.GpHome_Page.Controls.Add(Me.txt_home_page_color)
        Me.GpHome_Page.Controls.Add(Me.lbl_HP_Color)
        Me.GpHome_Page.Name = "GpHome_Page"
        '
        'txt_home_page_color
        '
        Me.txt_home_page_color.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.color_hp", True))
        resources.ApplyResources(Me.txt_home_page_color, "txt_home_page_color")
        Me.txt_home_page_color.Name = "txt_home_page_color"
        '
        'lbl_HP_Color
        '
        resources.ApplyResources(Me.lbl_HP_Color, "lbl_HP_Color")
        Me.lbl_HP_Color.Name = "lbl_HP_Color"
        '
        'cmbSelectedType
        '
        Me.cmbSelectedType.AllowDrop = True
        Me.cmbSelectedType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.themes_events_selection_id", True))
        resources.ApplyResources(Me.cmbSelectedType, "cmbSelectedType")
        Me.cmbSelectedType.Name = "cmbSelectedType"
        Me.cmbSelectedType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbSelectedType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbSelectedType.Properties.NullText = resources.GetString("cmbSelectedType.Properties.NullText")
        '
        'cmbType
        '
        Me.cmbType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.kind", True))
        resources.ApplyResources(Me.cmbType, "cmbType")
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbType.Properties.NullText = resources.GetString("cmbType.Properties.NullText")
        '
        'lblType
        '
        resources.ApplyResources(Me.lblType, "lblType")
        Me.lblType.Name = "lblType"
        '
        'gpPicture
        '
        resources.ApplyResources(Me.gpPicture, "gpPicture")
        Me.gpPicture.Controls.Add(Me.TabPictures)
        Me.gpPicture.Name = "gpPicture"
        '
        'TabPictures
        '
        resources.ApplyResources(Me.TabPictures, "TabPictures")
        Me.TabPictures.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DsSite1, "themes_events.banner_menu", True))
        Me.TabPictures.Name = "TabPictures"
        Me.TabPictures.SelectedTabPage = Me.tabBackground
        Me.TabPictures.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabBackground, Me.tabLogo, Me.tabBanner_page, Me.tabBanner_menu, Me.tabTitle_page, Me.tabThumbs, Me.tabHomePage})
        '
        'tabBackground
        '
        Me.tabBackground.Controls.Add(Me.chkBackground)
        Me.tabBackground.Controls.Add(Me.tabControl_Background_Image)
        Me.tabBackground.Name = "tabBackground"
        resources.ApplyResources(Me.tabBackground, "tabBackground")
        Me.tabBackground.Tag = "wallpaper"
        '
        'chkBackground
        '
        Me.chkBackground.AllowDrop = True
        Me.chkBackground.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.background_image", True))
        resources.ApplyResources(Me.chkBackground, "chkBackground")
        Me.chkBackground.Name = "chkBackground"
        Me.chkBackground.Properties.Caption = resources.GetString("chkBackground.Properties.Caption")
        '
        'tabControl_Background_Image
        '
        resources.ApplyResources(Me.tabControl_Background_Image, "tabControl_Background_Image")
        Me.tabControl_Background_Image.Name = "tabControl_Background_Image"
        Me.tabControl_Background_Image.SelectedTabPage = Me.tabBackgroundFR
        Me.tabControl_Background_Image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabBackgroundFR, Me.tabBackgroundNL, Me.tabBackgroundEN})
        '
        'tabBackgroundFR
        '
        Me.tabBackgroundFR.Controls.Add(Me.image_Background_FR)
        Me.tabBackgroundFR.Name = "tabBackgroundFR"
        resources.ApplyResources(Me.tabBackgroundFR, "tabBackgroundFR")
        Me.tabBackgroundFR.Tag = "FR"
        '
        'image_Background_FR
        '
        resources.ApplyResources(Me.image_Background_FR, "image_Background_FR")
        Me.image_Background_FR.Name = "image_Background_FR"
        Me.image_Background_FR.Properties.ReadOnly = True
        Me.image_Background_FR.Properties.ShowMenu = False
        Me.image_Background_FR.Tag = "FR"
        '
        'tabBackgroundNL
        '
        Me.tabBackgroundNL.Controls.Add(Me.image_Background_NL)
        Me.tabBackgroundNL.Name = "tabBackgroundNL"
        resources.ApplyResources(Me.tabBackgroundNL, "tabBackgroundNL")
        Me.tabBackgroundNL.Tag = "NL"
        '
        'image_Background_NL
        '
        resources.ApplyResources(Me.image_Background_NL, "image_Background_NL")
        Me.image_Background_NL.Name = "image_Background_NL"
        Me.image_Background_NL.Properties.ReadOnly = True
        Me.image_Background_NL.Properties.ShowMenu = False
        Me.image_Background_NL.Tag = "NL"
        '
        'tabBackgroundEN
        '
        Me.tabBackgroundEN.Controls.Add(Me.image_Background_EN)
        Me.tabBackgroundEN.Name = "tabBackgroundEN"
        resources.ApplyResources(Me.tabBackgroundEN, "tabBackgroundEN")
        Me.tabBackgroundEN.Tag = "EN"
        '
        'image_Background_EN
        '
        resources.ApplyResources(Me.image_Background_EN, "image_Background_EN")
        Me.image_Background_EN.Name = "image_Background_EN"
        Me.image_Background_EN.Properties.ReadOnly = True
        Me.image_Background_EN.Properties.ShowMenu = False
        Me.image_Background_EN.Tag = "EN"
        '
        'tabLogo
        '
        Me.tabLogo.Controls.Add(Me.tabControl_Logo_Image)
        Me.tabLogo.Controls.Add(Me.chkLogoPicture)
        Me.tabLogo.Name = "tabLogo"
        resources.ApplyResources(Me.tabLogo, "tabLogo")
        Me.tabLogo.Tag = "logo"
        '
        'tabControl_Logo_Image
        '
        resources.ApplyResources(Me.tabControl_Logo_Image, "tabControl_Logo_Image")
        Me.tabControl_Logo_Image.Name = "tabControl_Logo_Image"
        Me.tabControl_Logo_Image.SelectedTabPage = Me.tabLogoFR
        Me.tabControl_Logo_Image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabLogoFR, Me.tabLogoNL, Me.tabLogoEN})
        '
        'tabLogoFR
        '
        Me.tabLogoFR.Controls.Add(Me.image_Logo_FR)
        Me.tabLogoFR.Name = "tabLogoFR"
        resources.ApplyResources(Me.tabLogoFR, "tabLogoFR")
        Me.tabLogoFR.Tag = "FR"
        '
        'image_Logo_FR
        '
        resources.ApplyResources(Me.image_Logo_FR, "image_Logo_FR")
        Me.image_Logo_FR.Name = "image_Logo_FR"
        Me.image_Logo_FR.Properties.ReadOnly = True
        Me.image_Logo_FR.Properties.ShowMenu = False
        Me.image_Logo_FR.Tag = "FR"
        '
        'tabLogoNL
        '
        Me.tabLogoNL.Controls.Add(Me.image_Logo_NL)
        Me.tabLogoNL.Name = "tabLogoNL"
        resources.ApplyResources(Me.tabLogoNL, "tabLogoNL")
        Me.tabLogoNL.Tag = "NL"
        '
        'image_Logo_NL
        '
        resources.ApplyResources(Me.image_Logo_NL, "image_Logo_NL")
        Me.image_Logo_NL.Name = "image_Logo_NL"
        Me.image_Logo_NL.Properties.ReadOnly = True
        Me.image_Logo_NL.Properties.ShowMenu = False
        Me.image_Logo_NL.Tag = "NL"
        '
        'tabLogoEN
        '
        Me.tabLogoEN.Controls.Add(Me.image_Logo_EN)
        Me.tabLogoEN.Name = "tabLogoEN"
        resources.ApplyResources(Me.tabLogoEN, "tabLogoEN")
        Me.tabLogoEN.Tag = "EN"
        '
        'image_Logo_EN
        '
        resources.ApplyResources(Me.image_Logo_EN, "image_Logo_EN")
        Me.image_Logo_EN.Name = "image_Logo_EN"
        Me.image_Logo_EN.Properties.ReadOnly = True
        Me.image_Logo_EN.Properties.ShowMenu = False
        Me.image_Logo_EN.Tag = "EN"
        '
        'chkLogoPicture
        '
        Me.chkLogoPicture.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.logo_image", True))
        resources.ApplyResources(Me.chkLogoPicture, "chkLogoPicture")
        Me.chkLogoPicture.Name = "chkLogoPicture"
        Me.chkLogoPicture.Properties.Caption = resources.GetString("chkLogoPicture.Properties.Caption")
        '
        'tabBanner_page
        '
        Me.tabBanner_page.Controls.Add(Me.tabControl_Bannerpage_image)
        Me.tabBanner_page.Controls.Add(Me.chkBannerPage)
        Me.tabBanner_page.Name = "tabBanner_page"
        resources.ApplyResources(Me.tabBanner_page, "tabBanner_page")
        Me.tabBanner_page.Tag = "banner_page"
        '
        'tabControl_Bannerpage_image
        '
        resources.ApplyResources(Me.tabControl_Bannerpage_image, "tabControl_Bannerpage_image")
        Me.tabControl_Bannerpage_image.Name = "tabControl_Bannerpage_image"
        Me.tabControl_Bannerpage_image.SelectedTabPage = tabBannerPageFR
        Me.tabControl_Bannerpage_image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {tabBannerPageFR, Me.tabBannerPageNL, Me.tabBannerPageEN})
        '
        'tabBannerPageNL
        '
        Me.tabBannerPageNL.Controls.Add(Me.image_banner_page_NL)
        Me.tabBannerPageNL.Name = "tabBannerPageNL"
        resources.ApplyResources(Me.tabBannerPageNL, "tabBannerPageNL")
        Me.tabBannerPageNL.Tag = "NL"
        '
        'image_banner_page_NL
        '
        resources.ApplyResources(Me.image_banner_page_NL, "image_banner_page_NL")
        Me.image_banner_page_NL.Name = "image_banner_page_NL"
        Me.image_banner_page_NL.Properties.ReadOnly = True
        Me.image_banner_page_NL.Properties.ShowMenu = False
        Me.image_banner_page_NL.Tag = "NL"
        '
        'tabBannerPageEN
        '
        Me.tabBannerPageEN.Controls.Add(Me.image_banner_page_EN)
        Me.tabBannerPageEN.Name = "tabBannerPageEN"
        resources.ApplyResources(Me.tabBannerPageEN, "tabBannerPageEN")
        Me.tabBannerPageEN.Tag = "EN"
        '
        'image_banner_page_EN
        '
        Me.image_banner_page_EN.AllowDrop = True
        resources.ApplyResources(Me.image_banner_page_EN, "image_banner_page_EN")
        Me.image_banner_page_EN.Name = "image_banner_page_EN"
        Me.image_banner_page_EN.Properties.ReadOnly = True
        Me.image_banner_page_EN.Properties.ShowMenu = False
        Me.image_banner_page_EN.Tag = "EN"
        '
        'chkBannerPage
        '
        Me.chkBannerPage.AllowDrop = True
        Me.chkBannerPage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.banner_menu", True))
        resources.ApplyResources(Me.chkBannerPage, "chkBannerPage")
        Me.chkBannerPage.Name = "chkBannerPage"
        Me.chkBannerPage.Properties.Caption = resources.GetString("chkBannerPage.Properties.Caption")
        '
        'tabBanner_menu
        '
        Me.tabBanner_menu.Controls.Add(Me.tabControl_BannerMenu_Image)
        Me.tabBanner_menu.Controls.Add(Me.chkBannerMenu)
        Me.tabBanner_menu.Name = "tabBanner_menu"
        resources.ApplyResources(Me.tabBanner_menu, "tabBanner_menu")
        Me.tabBanner_menu.Tag = "banner_menu"
        '
        'tabControl_BannerMenu_Image
        '
        resources.ApplyResources(Me.tabControl_BannerMenu_Image, "tabControl_BannerMenu_Image")
        Me.tabControl_BannerMenu_Image.Name = "tabControl_BannerMenu_Image"
        Me.tabControl_BannerMenu_Image.SelectedTabPage = Me.tabBanner_menuFR
        Me.tabControl_BannerMenu_Image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabBanner_menuFR, Me.tabBanner_menuNL, Me.tabBanner_menuEN})
        '
        'tabBanner_menuFR
        '
        Me.tabBanner_menuFR.Controls.Add(Me.image_BannerMenu_FR)
        Me.tabBanner_menuFR.Name = "tabBanner_menuFR"
        resources.ApplyResources(Me.tabBanner_menuFR, "tabBanner_menuFR")
        Me.tabBanner_menuFR.Tag = "FR"
        '
        'image_BannerMenu_FR
        '
        resources.ApplyResources(Me.image_BannerMenu_FR, "image_BannerMenu_FR")
        Me.image_BannerMenu_FR.Name = "image_BannerMenu_FR"
        Me.image_BannerMenu_FR.Properties.ReadOnly = True
        Me.image_BannerMenu_FR.Properties.ShowMenu = False
        Me.image_BannerMenu_FR.Tag = "FR"
        '
        'tabBanner_menuNL
        '
        Me.tabBanner_menuNL.Controls.Add(Me.image_BannerMenu_NL)
        Me.tabBanner_menuNL.Name = "tabBanner_menuNL"
        resources.ApplyResources(Me.tabBanner_menuNL, "tabBanner_menuNL")
        Me.tabBanner_menuNL.Tag = "NL"
        '
        'image_BannerMenu_NL
        '
        resources.ApplyResources(Me.image_BannerMenu_NL, "image_BannerMenu_NL")
        Me.image_BannerMenu_NL.Name = "image_BannerMenu_NL"
        Me.image_BannerMenu_NL.Properties.ReadOnly = True
        Me.image_BannerMenu_NL.Properties.ShowMenu = False
        Me.image_BannerMenu_NL.Tag = "NL"
        '
        'tabBanner_menuEN
        '
        Me.tabBanner_menuEN.Controls.Add(Me.image_BannerMenu_EN)
        Me.tabBanner_menuEN.Name = "tabBanner_menuEN"
        resources.ApplyResources(Me.tabBanner_menuEN, "tabBanner_menuEN")
        Me.tabBanner_menuEN.Tag = "EN"
        '
        'image_BannerMenu_EN
        '
        resources.ApplyResources(Me.image_BannerMenu_EN, "image_BannerMenu_EN")
        Me.image_BannerMenu_EN.Name = "image_BannerMenu_EN"
        Me.image_BannerMenu_EN.Properties.ReadOnly = True
        Me.image_BannerMenu_EN.Properties.ShowMenu = False
        Me.image_BannerMenu_EN.Tag = "EN"
        '
        'chkBannerMenu
        '
        Me.chkBannerMenu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.banner_menu", True))
        resources.ApplyResources(Me.chkBannerMenu, "chkBannerMenu")
        Me.chkBannerMenu.Name = "chkBannerMenu"
        Me.chkBannerMenu.Properties.Caption = resources.GetString("chkBannerMenu.Properties.Caption")
        '
        'tabTitle_page
        '
        Me.tabTitle_page.Controls.Add(Me.tabControl_TitlePage_image)
        Me.tabTitle_page.Controls.Add(Me.chkTitlePage)
        Me.tabTitle_page.Name = "tabTitle_page"
        resources.ApplyResources(Me.tabTitle_page, "tabTitle_page")
        Me.tabTitle_page.Tag = "title_page"
        '
        'tabControl_TitlePage_image
        '
        resources.ApplyResources(Me.tabControl_TitlePage_image, "tabControl_TitlePage_image")
        Me.tabControl_TitlePage_image.Name = "tabControl_TitlePage_image"
        Me.tabControl_TitlePage_image.SelectedTabPage = Me.tabTitlePageFR
        Me.tabControl_TitlePage_image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabTitlePageFR, Me.tabTitlePageNL, Me.tabTitlePageEN})
        '
        'tabTitlePageFR
        '
        Me.tabTitlePageFR.Controls.Add(Me.image_title_page_FR)
        Me.tabTitlePageFR.Name = "tabTitlePageFR"
        resources.ApplyResources(Me.tabTitlePageFR, "tabTitlePageFR")
        Me.tabTitlePageFR.Tag = "FR"
        '
        'image_title_page_FR
        '
        Me.image_title_page_FR.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_FR, "image_title_page_FR")
        Me.image_title_page_FR.Name = "image_title_page_FR"
        Me.image_title_page_FR.Properties.ReadOnly = True
        Me.image_title_page_FR.Properties.ShowMenu = False
        Me.image_title_page_FR.Tag = "FR"
        '
        'tabTitlePageNL
        '
        Me.tabTitlePageNL.Controls.Add(Me.image_title_page_NL)
        Me.tabTitlePageNL.Name = "tabTitlePageNL"
        resources.ApplyResources(Me.tabTitlePageNL, "tabTitlePageNL")
        Me.tabTitlePageNL.Tag = "NL"
        '
        'image_title_page_NL
        '
        Me.image_title_page_NL.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_NL, "image_title_page_NL")
        Me.image_title_page_NL.Name = "image_title_page_NL"
        Me.image_title_page_NL.Properties.ReadOnly = True
        Me.image_title_page_NL.Properties.ShowMenu = False
        Me.image_title_page_NL.Tag = "NL"
        '
        'tabTitlePageEN
        '
        Me.tabTitlePageEN.Controls.Add(Me.image_title_page_EN)
        Me.tabTitlePageEN.Name = "tabTitlePageEN"
        resources.ApplyResources(Me.tabTitlePageEN, "tabTitlePageEN")
        Me.tabTitlePageEN.Tag = "EN"
        '
        'image_title_page_EN
        '
        Me.image_title_page_EN.AllowDrop = True
        resources.ApplyResources(Me.image_title_page_EN, "image_title_page_EN")
        Me.image_title_page_EN.Name = "image_title_page_EN"
        Me.image_title_page_EN.Properties.ReadOnly = True
        Me.image_title_page_EN.Properties.ShowMenu = False
        Me.image_title_page_EN.Tag = "EN"
        '
        'chkTitlePage
        '
        Me.chkTitlePage.AllowDrop = True
        Me.chkTitlePage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.title_page", True))
        resources.ApplyResources(Me.chkTitlePage, "chkTitlePage")
        Me.chkTitlePage.Name = "chkTitlePage"
        Me.chkTitlePage.Properties.Caption = resources.GetString("chkTitlePage.Properties.Caption")
        '
        'tabThumbs
        '
        Me.tabThumbs.Controls.Add(Me.tabControl_thumbs_image)
        Me.tabThumbs.Controls.Add(Me.chkthumbs)
        Me.tabThumbs.Name = "tabThumbs"
        resources.ApplyResources(Me.tabThumbs, "tabThumbs")
        Me.tabThumbs.Tag = "thumbs"
        '
        'tabControl_thumbs_image
        '
        resources.ApplyResources(Me.tabControl_thumbs_image, "tabControl_thumbs_image")
        Me.tabControl_thumbs_image.Name = "tabControl_thumbs_image"
        Me.tabControl_thumbs_image.SelectedTabPage = Me.XtraTabPage1
        Me.tabControl_thumbs_image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.image_thumbs_FR)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        Me.XtraTabPage1.Tag = "FR"
        '
        'image_thumbs_FR
        '
        Me.image_thumbs_FR.AllowDrop = True
        resources.ApplyResources(Me.image_thumbs_FR, "image_thumbs_FR")
        Me.image_thumbs_FR.Name = "image_thumbs_FR"
        Me.image_thumbs_FR.Properties.ReadOnly = True
        Me.image_thumbs_FR.Properties.ShowMenu = False
        Me.image_thumbs_FR.Tag = "FR"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.image_thumbs_NL)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        resources.ApplyResources(Me.XtraTabPage2, "XtraTabPage2")
        Me.XtraTabPage2.Tag = "NL"
        '
        'image_thumbs_NL
        '
        Me.image_thumbs_NL.AllowDrop = True
        resources.ApplyResources(Me.image_thumbs_NL, "image_thumbs_NL")
        Me.image_thumbs_NL.Name = "image_thumbs_NL"
        Me.image_thumbs_NL.Properties.ReadOnly = True
        Me.image_thumbs_NL.Properties.ShowMenu = False
        Me.image_thumbs_NL.Tag = "NL"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.image_thumbs_EN)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        resources.ApplyResources(Me.XtraTabPage3, "XtraTabPage3")
        Me.XtraTabPage3.Tag = "EN"
        '
        'image_thumbs_EN
        '
        Me.image_thumbs_EN.AllowDrop = True
        resources.ApplyResources(Me.image_thumbs_EN, "image_thumbs_EN")
        Me.image_thumbs_EN.Name = "image_thumbs_EN"
        Me.image_thumbs_EN.Properties.ReadOnly = True
        Me.image_thumbs_EN.Properties.ShowMenu = False
        Me.image_thumbs_EN.Tag = "EN"
        '
        'chkthumbs
        '
        Me.chkthumbs.AllowDrop = True
        Me.chkthumbs.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.title_page", True))
        resources.ApplyResources(Me.chkthumbs, "chkthumbs")
        Me.chkthumbs.Name = "chkthumbs"
        Me.chkthumbs.Properties.Caption = resources.GetString("chkthumbs.Properties.Caption")
        '
        'tabHomePage
        '
        Me.tabHomePage.Controls.Add(Me.tabControl_home_page_image)
        Me.tabHomePage.Controls.Add(Me.chkhome_page)
        Me.tabHomePage.Name = "tabHomePage"
        resources.ApplyResources(Me.tabHomePage, "tabHomePage")
        Me.tabHomePage.Tag = "home_page"
        '
        'tabControl_home_page_image
        '
        resources.ApplyResources(Me.tabControl_home_page_image, "tabControl_home_page_image")
        Me.tabControl_home_page_image.Name = "tabControl_home_page_image"
        Me.tabControl_home_page_image.SelectedTabPage = Me.tabhome_pageFR
        Me.tabControl_home_page_image.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabhome_pageFR, Me.tabhome_pageNL, Me.tabhome_pageEN})
        '
        'tabhome_pageFR
        '
        Me.tabhome_pageFR.Controls.Add(Me.image_home_page_FR)
        Me.tabhome_pageFR.Name = "tabhome_pageFR"
        resources.ApplyResources(Me.tabhome_pageFR, "tabhome_pageFR")
        Me.tabhome_pageFR.Tag = "FR"
        '
        'image_home_page_FR
        '
        resources.ApplyResources(Me.image_home_page_FR, "image_home_page_FR")
        Me.image_home_page_FR.Name = "image_home_page_FR"
        Me.image_home_page_FR.Properties.ReadOnly = True
        Me.image_home_page_FR.Properties.ShowMenu = False
        Me.image_home_page_FR.Tag = "FR"
        '
        'tabhome_pageNL
        '
        Me.tabhome_pageNL.Controls.Add(Me.image_home_page_NL)
        Me.tabhome_pageNL.Name = "tabhome_pageNL"
        resources.ApplyResources(Me.tabhome_pageNL, "tabhome_pageNL")
        Me.tabhome_pageNL.Tag = "NL"
        '
        'image_home_page_NL
        '
        resources.ApplyResources(Me.image_home_page_NL, "image_home_page_NL")
        Me.image_home_page_NL.Name = "image_home_page_NL"
        Me.image_home_page_NL.Properties.ReadOnly = True
        Me.image_home_page_NL.Properties.ShowMenu = False
        Me.image_home_page_NL.Tag = "NL"
        '
        'tabhome_pageEN
        '
        Me.tabhome_pageEN.Controls.Add(Me.image_home_page_EN)
        Me.tabhome_pageEN.Name = "tabhome_pageEN"
        resources.ApplyResources(Me.tabhome_pageEN, "tabhome_pageEN")
        Me.tabhome_pageEN.Tag = "EN"
        '
        'image_home_page_EN
        '
        resources.ApplyResources(Me.image_home_page_EN, "image_home_page_EN")
        Me.image_home_page_EN.Name = "image_home_page_EN"
        Me.image_home_page_EN.Properties.ReadOnly = True
        Me.image_home_page_EN.Properties.ShowMenu = False
        Me.image_home_page_EN.Tag = "EN"
        '
        'chkhome_page
        '
        Me.chkhome_page.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.banner_hp", True))
        resources.ApplyResources(Me.chkhome_page, "chkhome_page")
        Me.chkhome_page.Name = "chkhome_page"
        Me.chkhome_page.Properties.Caption = resources.GetString("chkhome_page.Properties.Caption")
        '
        'lblId
        '
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.Name = "lblId"
        '
        'GpBanner
        '
        resources.ApplyResources(Me.GpBanner, "GpBanner")
        Me.GpBanner.Controls.Add(Me.txtPage_border_color)
        Me.GpBanner.Controls.Add(Me.lblPage_border_color)
        Me.GpBanner.Controls.Add(Me.txtBannerMenu_text_color)
        Me.GpBanner.Controls.Add(Me.lblBanner_menu_text_color)
        Me.GpBanner.Name = "GpBanner"
        '
        'txtPage_border_color
        '
        Me.txtPage_border_color.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.page_border_color", True))
        resources.ApplyResources(Me.txtPage_border_color, "txtPage_border_color")
        Me.txtPage_border_color.Name = "txtPage_border_color"
        '
        'lblPage_border_color
        '
        resources.ApplyResources(Me.lblPage_border_color, "lblPage_border_color")
        Me.lblPage_border_color.Name = "lblPage_border_color"
        '
        'txtBannerMenu_text_color
        '
        Me.txtBannerMenu_text_color.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.banner_menu_text_color", True))
        resources.ApplyResources(Me.txtBannerMenu_text_color, "txtBannerMenu_text_color")
        Me.txtBannerMenu_text_color.Name = "txtBannerMenu_text_color"
        '
        'lblBanner_menu_text_color
        '
        resources.ApplyResources(Me.lblBanner_menu_text_color, "lblBanner_menu_text_color")
        Me.lblBanner_menu_text_color.Name = "lblBanner_menu_text_color"
        '
        'GpBackground
        '
        resources.ApplyResources(Me.GpBackground, "GpBackground")
        Me.GpBackground.Controls.Add(Me.cmbBackgroundAttachment)
        Me.GpBackground.Controls.Add(Me.lblBackground_attachment)
        Me.GpBackground.Controls.Add(Me.lblBackground_color)
        Me.GpBackground.Controls.Add(Me.txtBackground_color)
        Me.GpBackground.Name = "GpBackground"
        '
        'cmbBackgroundAttachment
        '
        Me.cmbBackgroundAttachment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.background_attachment", True))
        resources.ApplyResources(Me.cmbBackgroundAttachment, "cmbBackgroundAttachment")
        Me.cmbBackgroundAttachment.Name = "cmbBackgroundAttachment"
        Me.cmbBackgroundAttachment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbBackgroundAttachment.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbBackgroundAttachment.Properties.NullText = resources.GetString("cmbBackgroundAttachment.Properties.NullText")
        '
        'lblBackground_attachment
        '
        resources.ApplyResources(Me.lblBackground_attachment, "lblBackground_attachment")
        Me.lblBackground_attachment.Name = "lblBackground_attachment"
        '
        'lblBackground_color
        '
        resources.ApplyResources(Me.lblBackground_color, "lblBackground_color")
        Me.lblBackground_color.Name = "lblBackground_color"
        '
        'txtBackground_color
        '
        Me.txtBackground_color.AllowDrop = True
        Me.txtBackground_color.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.background_color", True))
        resources.ApplyResources(Me.txtBackground_color, "txtBackground_color")
        Me.txtBackground_color.Name = "txtBackground_color"
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        '
        'btnSaveTheme
        '
        resources.ApplyResources(Me.btnSaveTheme, "btnSaveTheme")
        Me.btnSaveTheme.Name = "btnSaveTheme"
        '
        'btnEditTheme
        '
        resources.ApplyResources(Me.btnEditTheme, "btnEditTheme")
        Me.btnEditTheme.Name = "btnEditTheme"
        '
        'btnNewTheme_edit
        '
        resources.ApplyResources(Me.btnNewTheme_edit, "btnNewTheme_edit")
        Me.btnNewTheme_edit.Name = "btnNewTheme_edit"
        '
        'TxtEventThemeId_edit
        '
        Me.TxtEventThemeId_edit.AllowDrop = True
        Me.TxtEventThemeId_edit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.id", True))
        resources.ApplyResources(Me.TxtEventThemeId_edit, "TxtEventThemeId_edit")
        Me.TxtEventThemeId_edit.Name = "TxtEventThemeId_edit"
        '
        'txtTitleEdit
        '
        Me.txtTitleEdit.AllowDrop = True
        Me.txtTitleEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.name", True))
        resources.ApplyResources(Me.txtTitleEdit, "txtTitleEdit")
        Me.txtTitleEdit.Name = "txtTitleEdit"
        '
        'lblTitleEdit
        '
        resources.ApplyResources(Me.lblTitleEdit, "lblTitleEdit")
        Me.lblTitleEdit.Name = "lblTitleEdit"
        '
        'OFDPicture
        '
        resources.ApplyResources(Me.OFDPicture, "OFDPicture")
        '
        'frmThemeEvent
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabControlTheme)
        Me.Name = "frmThemeEvent"
        Me.Controls.SetChildIndex(Me.XtraTabControlTheme, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        tabBannerPageFR.ResumeLayout(False)
        CType(Me.image_banner_page_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.TxtEventThemeId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult.ResumeLayout(False)
        CType(Me.GridThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewThemeEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlTheme.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.tabDetail.PerformLayout()
        CType(Me.txtLastModified.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreatedAt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GpHome_Page, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpHome_Page.ResumeLayout(False)
        Me.GpHome_Page.PerformLayout()
        CType(Me.txt_home_page_color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSelectedType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpPicture.ResumeLayout(False)
        CType(Me.TabPictures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPictures.ResumeLayout(False)
        Me.tabBackground.ResumeLayout(False)
        CType(Me.chkBackground.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControl_Background_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_Background_Image.ResumeLayout(False)
        Me.tabBackgroundFR.ResumeLayout(False)
        CType(Me.image_Background_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBackgroundNL.ResumeLayout(False)
        CType(Me.image_Background_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBackgroundEN.ResumeLayout(False)
        CType(Me.image_Background_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogo.ResumeLayout(False)
        CType(Me.tabControl_Logo_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_Logo_Image.ResumeLayout(False)
        Me.tabLogoFR.ResumeLayout(False)
        CType(Me.image_Logo_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogoNL.ResumeLayout(False)
        CType(Me.image_Logo_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogoEN.ResumeLayout(False)
        CType(Me.image_Logo_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLogoPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBanner_page.ResumeLayout(False)
        CType(Me.tabControl_Bannerpage_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_Bannerpage_image.ResumeLayout(False)
        Me.tabBannerPageNL.ResumeLayout(False)
        CType(Me.image_banner_page_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBannerPageEN.ResumeLayout(False)
        CType(Me.image_banner_page_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBannerPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBanner_menu.ResumeLayout(False)
        CType(Me.tabControl_BannerMenu_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_BannerMenu_Image.ResumeLayout(False)
        Me.tabBanner_menuFR.ResumeLayout(False)
        CType(Me.image_BannerMenu_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBanner_menuNL.ResumeLayout(False)
        CType(Me.image_BannerMenu_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBanner_menuEN.ResumeLayout(False)
        CType(Me.image_BannerMenu_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkBannerMenu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitle_page.ResumeLayout(False)
        CType(Me.tabControl_TitlePage_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_TitlePage_image.ResumeLayout(False)
        Me.tabTitlePageFR.ResumeLayout(False)
        CType(Me.image_title_page_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitlePageNL.ResumeLayout(False)
        CType(Me.image_title_page_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTitlePageEN.ResumeLayout(False)
        CType(Me.image_title_page_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTitlePage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabThumbs.ResumeLayout(False)
        CType(Me.tabControl_thumbs_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_thumbs_image.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.image_thumbs_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.image_thumbs_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.image_thumbs_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkthumbs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHomePage.ResumeLayout(False)
        CType(Me.tabControl_home_page_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl_home_page_image.ResumeLayout(False)
        Me.tabhome_pageFR.ResumeLayout(False)
        CType(Me.image_home_page_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabhome_pageNL.ResumeLayout(False)
        CType(Me.image_home_page_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabhome_pageEN.ResumeLayout(False)
        CType(Me.image_home_page_EN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkhome_page.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GpBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBanner.ResumeLayout(False)
        Me.GpBanner.PerformLayout()
        CType(Me.txtPage_border_color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBannerMenu_text_color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GpBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBackground.ResumeLayout(False)
        Me.GpBackground.PerformLayout()
        CType(Me.cmbBackgroundAttachment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBackground_color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEventThemeId_edit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String
    Dim _PathPictureWrite As String
    Dim _PathPictureRead As String
    Const SERVERKEY As String = "SERVERPATH"
    Const LANGKEY As String = "LANG"
    Const THEMEEVENTIDKEY As String = "ID"

    Const PATHLOGO As String = SERVERKEY & "themes\" & LANGKEY & "\"



    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum


    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub

    Private Sub save()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.themes_events, _sql)
    End Sub

    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)

                tabSearch.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = True
                btnNewTheme_edit.Enabled = False
                btnCancel.Enabled = True

                EnableField(True)

                tabDetail.PageVisible = True
                tabResult.PageVisible = False

            Case StepForm.INIT
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabResult.PageVisible = False
                tabSearch.PageVisible = True
                tabDetail.PageVisible = False
                XtraTabControlTheme.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditTheme.Enabled = False
                btnSaveTheme.Enabled = True
                btnNewTheme_edit.Enabled = False
                btnCancel.Enabled = True
                EnableField(True)
                tabResult.PageVisible = False
                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail



            Case StepForm.SAVE
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)
                tabDetail.PageVisible = True
                tabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditTheme.Enabled = True
                btnSaveTheme.Enabled = False
                btnNewTheme_edit.Enabled = True
                btnCancel.Enabled = False
                EnableField(False)

                tabDetail.PageVisible = True
                XtraTabControlTheme.SelectedTabPage = tabDetail

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewThemeEvent.OptionsView.ColumnAutoWidth = False
        GridViewThemeEvent.OptionsBehavior.Editable = False

        XtraTabControlTheme.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True

        Dim menuStrip As New PlushBuziness.contextMenu()
        GridThemeEvent.ContextMenuStrip = menuStrip
        search()
        ChangeStep(StepForm.INIT)

        Dim serverPath As String
        serverPath = PlushBuziness.clsPicture.getPathServerMapping()
        _PathPictureWrite = PATHLOGO.Replace(SERVERKEY, serverPath)

        serverPath = PlushBuziness.clsPicture.getPathServer()
        _PathPictureRead = PATHLOGO.Replace(SERVERKEY, serverPath)

        loadBackGround_attachment()
        loadType()
        loadSelected()


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        tabDetail.PageVisible = False
        tabResult.PageVisible = True
        XtraTabControlTheme.SelectedTabPage = tabResult
    End Sub

    Public Sub search()

        Dim id As Object
        Dim title As Object


        id = TxtEventThemeId.EditValue
        title = txtTitle.EditValue

        DsSite1.themes_events.Clear()
        _sql = PlushData.clsThemeEvent.GetSearch(id, title)
        PlushData.clsConnection.FillDataSet(DsSite1.themes_events, _sql, )
        GridThemeEvent.DataSource = DsSite1.themes_events


    End Sub

    Private Sub initForm()
        Dim blank As String = String.Empty
        TxtEventThemeId_edit.EditValue = blank
        txtTitleEdit.EditValue = blank
        txtBackground_color.EditValue = blank

        chkBackground.EditValue = blank
        chkBannerPage.EditValue = blank
        chkBannerMenu.EditValue = blank
        chkLogoPicture.EditValue = blank
        chkhome_page.EditValue = blank
        chkTitlePage.Checked = True

        txtBannerMenu_text_color.EditValue = blank
        txtPage_border_color.EditValue = blank
        txt_home_page_color.EditValue = blank
    End Sub

    Private Sub loadSelected()
        Dim dt As DataTable
        Dim sql As String

        sql = PlushData.clsThemeEvent.GetThemeEventSelected()
        dt = PlushData.clsConnection.FillDataSet(sql)

        cmbSelectedType.Properties.ValueMember = "id"
        cmbSelectedType.Properties.DisplayMember = "name"
        cmbSelectedType.Properties.DataSource = dt

    End Sub

    Private Sub loadType()
        Dim lstType As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeEvent.GetEnumMysqlType()
        lstType = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbType.Properties.ValueMember = "Value"
        cmbType.Properties.DisplayMember = "DisplayMember"
        cmbType.Properties.DataSource = lstType

    End Sub
    Private Sub loadBackGround_attachment()
        Dim lstBackGroundAttachment As List(Of PlushBuziness.clsKeyComboEnum)
        Dim sql As String

        sql = PlushData.clsThemeEvent.GetEnumMysqlBackgroundAttachment()
        lstBackGroundAttachment = PlushBuziness.ClsCombo.GetListEnum(sql)

        cmbBackgroundAttachment.Properties.ValueMember = "Value"
        cmbBackgroundAttachment.Properties.DisplayMember = "DisplayMember"
        cmbBackgroundAttachment.Properties.DataSource = lstBackGroundAttachment

    End Sub
    Private Sub ManageAfterBinding(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        ' refreshAllPictures(TabPictures)
    End Sub

    Private Sub loadformEdit()
        loadInfo()
        ChangeStep(StepForm.LOAD)
        refreshAllPictures(TabPictures)
    End Sub
    Private Sub GridThemeEvent_doubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridThemeEvent.DoubleClick
        loadformEdit()

    End Sub

    Private Sub loadInfo()
        Dim currentRow As DataRow

        If GridViewThemeEvent.RowCount > 0 Then

            currentRow = GridViewThemeEvent.GetDataRow(GridViewThemeEvent.FocusedRowHandle())
            Dim index As Integer = DsSite1.themes_events.Rows.IndexOf(currentRow)
            Me.BindingContext(DsSite1, DsSite1.themes_events.TableName).Position = index
            XtraTabControlTheme.SelectedTabPage = tabDetail

        End If
    End Sub

    Private Sub insertData()

        Dim dr As DsSite.themes_eventsRow
        dr = DsSite1.themes_events.NewRow()
        dr.id = PlushBuziness.ClsThemeEvent.GetLastId()
        DsSite1.themes_events.Addthemes_eventsRow(dr)
        Me.BindingContext(DsSite1, DsSite1.themes_events.TableName).Position = DsSite1.themes_events.Rows.Count - 1

    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok

        GpBackground.Enabled = enable
        GpBanner.Enabled = enable
        GpHome_Page.Enabled = enable
        txtTitleEdit.Enabled = enable
        SearchAllCtrl(TabPictures, GetType(DevExpress.XtraEditors.PictureEdit), enable)
        SearchAllCtrl(TabPictures, GetType(DevExpress.XtraEditors.CheckEdit), enable)
        cmbSelectedType.Enabled = enable
        cmbType.Enabled = enable
        Return ok
    End Function

    Private Sub btnEditTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTheme.Click
        ChangeStep(StepForm.EDIT)

    End Sub

    Private Sub btnNewTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewTheme.Click, btnNewTheme_edit.Click

        insertData()
        txtCreatedAt.EditValue = DateTime.Now
        txtCreatedAt.Text = DateTime.Now
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnSaveTheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTheme.Click
        txtLastModified.EditValue = DateTime.Now
        txtLastModified.Text = DateTime.Now
        Me.BindingContext(DsSite1, DsSite1.themes_events.TableName).EndCurrentEdit()
        PlushData.clsConnection.UpdateDataTableInDB(DsSite1.themes_events, _sql)
        ChangeStep(StepForm.SAVE)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.BindingContext(DsSite1, DsSite1.themes_events.TableName).CancelCurrentEdit()
        DsSite1.themes_events.RejectChanges()
        ChangeStep(StepForm.CANCEL)

    End Sub

#Region "Picture Tab"

    ''' <summary>
    ''' sub recursive pour mettre a jour ts les controls d'un type
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <param name="typectrl"></param>
    ''' <remarks></remarks>
    Private Sub AddEventCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type)
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                AddHandler ctrl.Controls(index).DoubleClick, AddressOf Image_DoubleClick
            Else
                AddEventCtrl(ctrl.Controls(index), typectrl)
            End If

            index += 1
        End While


    End Sub

    ''' <summary>
    ''' sub recursive pour mettre a jour ts les controls d'un type
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <param name="typectrl"></param>
    ''' <param name="enabled"></param>
    ''' <remarks></remarks>
    Private Sub SearchAllCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type, ByVal enabled As Boolean)
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                ctrl.Controls(index).Enabled = enabled
            Else
                SearchAllCtrl(ctrl.Controls(index), typectrl, enabled)
            End If

            index += 1
        End While


    End Sub

    Private Function SearchCtrl(ByVal ctrl As Windows.Forms.Control, ByVal typectrl As Type) As Object
        Dim index As Integer = 0
        While index < ctrl.Controls.Count
            If ctrl.Controls(index).GetType() Is typectrl Then
                Return ctrl.Controls(index)
            End If

            index += 1
        End While

        Return Nothing
    End Function

    Private Function SearchTabControlCtrl(ByVal tab As DevExpress.XtraTab.XtraTabPage) As DevExpress.XtraTab.XtraTabControl
        Return SearchCtrl(tab, GetType(DevExpress.XtraTab.XtraTabControl))
    End Function

    Private Function SearchImageCtrl(ByVal tab As DevExpress.XtraTab.XtraTabPage) As DevExpress.XtraEditors.PictureEdit
        Return SearchCtrl(tab, GetType(DevExpress.XtraEditors.PictureEdit))
    End Function

    Private Sub RefreshPictureTab(ByVal tabControl As DevExpress.XtraTab.XtraTabControl)
        Dim type As PlushBuziness.clsPicture.TypePicture
        Dim lang As String
        Dim img As DevExpress.XtraEditors.PictureEdit

        type = PlushBuziness.clsPicture.ConvertStringToEnum(tabControl.Parent.Tag)
        For Each tab As DevExpress.XtraTab.XtraTabPage In tabControl.TabPages
            img = SearchImageCtrl(tab)
            If Not img Is Nothing Then
                lang = tab.Tag
                RefreshPicture(img, TxtEventThemeId_edit.EditValue, type)
            End If
        Next


    End Sub

    Private Sub RefreshTypePictures(ByVal tab As DevExpress.XtraTab.XtraTabPage)

        Dim chk As DevExpress.XtraEditors.CheckEdit
        Dim tabLang As DevExpress.XtraTab.XtraTabControl
        chk = SearchCtrl(tab, GetType(DevExpress.XtraEditors.CheckEdit))
        tabLang = SearchCtrl(tab, GetType(DevExpress.XtraTab.XtraTabControl))
        If Not tabLang Is Nothing Then
            '  If Not chk Is Nothing AndAlso chk.Checked Then
            RefreshPictureTab(tabLang)
            tabLang.Visible = True
            'Else
            '     tabLang.Visible = False
            '  End If
        End If

    End Sub
    Private Sub refreshAllPictures(ByVal tabControl As DevExpress.XtraTab.XtraTabControl)

        For Each tab As DevExpress.XtraTab.XtraTabPage In tabControl.TabPages
            RefreshTypePictures(tab)
        Next


    End Sub

    Private Function GetFullPathPicture(ByVal Lang As String, ByVal themeEventId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal FullpathPicture As String) As FileInfo

        Dim pathPicture As String
        Dim TmpnameFilePicture As String
        pathPicture = FullpathPicture

        pathPicture = pathPicture.Replace(LANGKEY, Lang)
        TmpnameFilePicture = themeEventId
        TmpnameFilePicture += PlushBuziness.clsPicture.GetExtension(tp_picture)
        Dim file As FileInfo = New FileInfo(pathPicture & PlushTools.clsEnum.getNameStrEnum(tp_picture) & "\" & TmpnameFilePicture)
        Return file

    End Function
    Private Function thumbnailCallback() As Boolean
        Return False
    End Function

    Private Sub RefreshPicture(ByVal img As DevExpress.XtraEditors.PictureEdit, ByVal ThemeEventId As Integer, ByVal tp_picture As PlushBuziness.clsPicture.TypePicture)

        Dim filePicture As FileInfo

        filePicture = GetFullPathPicture(img.Tag, ThemeEventId, tp_picture, _PathPictureRead)

        If System.IO.File.Exists(filePicture.FullName) Then

            Dim myCallback As New Drawing.Image.GetThumbnailImageAbort(AddressOf thumbnailCallback)

            Using temp As System.Drawing.Image = System.Drawing.Image.FromFile(filePicture.FullName)
                img.Image = New System.Drawing.Bitmap(temp)
            End Using
            'this method used for reduce picture if too large 
            img.Image = img.Image.GetThumbnailImage(img.Width, img.Height, myCallback, IntPtr.Zero)
        Else
            img.Image = Nothing
        End If
    End Sub

    Private Function AddPicture(ByVal tp_picture As PlushBuziness.clsPicture.TypePicture, ByVal lang As String) As Boolean


        Dim FilePictureDestination As FileInfo
        Dim pathPictureSource As String
        Dim extension As String
        extension = PlushBuziness.clsPicture.GetExtension(tp_picture)
        OFDPicture.Filter = extension & "|*" & extension
        FilePictureDestination = GetFullPathPicture(lang, TxtEventThemeId_edit.EditValue, tp_picture, _PathPictureWrite)
        If OFDPicture.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pathPictureSource = OFDPicture.FileName
            If Not Directory.Exists(FilePictureDestination.DirectoryName) Then
                Directory.CreateDirectory(FilePictureDestination.DirectoryName)
            End If
            File.Copy(pathPictureSource, FilePictureDestination.FullName, True)
            Return True
        End If

        Return False
    End Function



    Private Sub Image_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim img As DevExpress.XtraEditors.PictureEdit
        Dim tabType As DevExpress.XtraTab.XtraTabPage
        Dim tabLang As DevExpress.XtraTab.XtraTabPage
        Dim tp_picture As PlushBuziness.clsPicture.TypePicture
        img = sender
        tabLang = img.Parent
        tabType = tabLang.Parent.Parent
        tp_picture = PlushBuziness.clsPicture.ConvertStringToEnum(tabType.Tag)

        If AddPicture(tp_picture, tabLang.Tag) Then
            RefreshTypePictures(tabType)
        End If

    End Sub

    Private Sub chkBackground_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBackground.CheckedChanged
        tabControl_Background_Image.Visible = chkBackground.Checked
        'If chkBackground.Checked Then
        '    RefreshTypePictures(chkBackground.Parent)
        'End If
    End Sub
    Private Sub chkTitlePage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTitlePage.CheckedChanged
        tabControl_TitlePage_image.Visible = chkTitlePage.Checked
    End Sub

    Private Sub chkBannerPage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBannerPage.CheckedChanged
        tabControl_Bannerpage_image.Visible = chkBannerPage.Checked

    End Sub

    Private Sub chkBannerMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBannerMenu.CheckedChanged
        tabControl_BannerMenu_Image.Visible = chkBannerMenu.Checked
    End Sub

    Private Sub chkLogoPicture_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLogoPicture.CheckedChanged
        tabControl_Logo_Image.Visible = chkLogoPicture.Checked
        'If chkLogoPicture.Checked Then
        '    RefreshTypePictures(chkLogoPicture.Parent)
        'End If
    End Sub
    Private Sub chkthums_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkthumbs.CheckedChanged
        tabControl_thumbs_image.Visible = chkthumbs.Checked
        'If chkLogoPicture.Checked Then
        '    RefreshTypePictures(chkLogoPicture.Parent)
        'End If
    End Sub


    Private Sub chkhome_page_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhome_page.CheckedChanged
        tabControl_home_page_image.Visible = chkhome_page.Checked
    End Sub

#End Region




End Class



