Public Class frmMSNUtility
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabMSN1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grpMSN1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCreateNLContest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateFRContest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImageTxtNL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImageTxtFR1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleNL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleFR1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImage1FR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBodyTextNL1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtBodyTextFR1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabMSN2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTitleUrlNL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleUrlFR1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLoadFRContest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadNLContest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnLoadNLQuizz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadFRQuizz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitleUrlNL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleUrlFR2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBodyTextNL2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtBodyTextFR2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImageTxtNL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImageTxtFR2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleNL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitleFR2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImage2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCreateNLQuizz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateFRQuizz As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabMSN3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_FR_TextB1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextAURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnLoadRent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLoadSls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSls_FR_TextBURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageText1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_Image1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCreateSlsNL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateSlsFR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_NL_TextB1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextAURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextBURL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageText1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextA1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_Image1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_NL_TextB2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextAURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextBURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageText2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextA2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_Image2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_FR_TextB2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextAURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextBURL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageText2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextA2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_Image2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_NL_TextB3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextAURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextBURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageText3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextA3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_Image3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_FR_TextB3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextAURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextBURL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageText3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextA3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_Image3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_NL_TextB4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextAURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextBURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_ImageText4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_TextA4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_NL_Image4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtSls_FR_TextB4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextAURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextBURL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_ImageText4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_TextA4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSls_FR_Image4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCreateRentNL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateRentFR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictContestFR_Image As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictQuizz_Image As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls1_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls1_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls2_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls2_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls3_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls3_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls4_NL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictSls4_FR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImage1NL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictContestNL_Image As DevExpress.XtraEditors.PictureEdit

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.tabMSN1 = New DevExpress.XtraTab.XtraTabPage
        Me.grpMSN1 = New DevExpress.XtraEditors.GroupControl
        Me.PictContestFR_Image = New DevExpress.XtraEditors.PictureEdit
        Me.btnLoadNLContest = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadFRContest = New DevExpress.XtraEditors.SimpleButton
        Me.txtTitleUrlNL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleUrlFR1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtBodyTextNL1 = New DevExpress.XtraEditors.MemoEdit
        Me.txtBodyTextFR1 = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtImageTxtNL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtImageTxtFR1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleNL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleFR1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtImage1FR = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnCreateNLContest = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateFRContest = New DevExpress.XtraEditors.SimpleButton
        Me.tabMSN2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PictQuizz_Image = New DevExpress.XtraEditors.PictureEdit
        Me.btnLoadNLQuizz = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadFRQuizz = New DevExpress.XtraEditors.SimpleButton
        Me.txtTitleUrlNL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleUrlFR2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtBodyTextNL2 = New DevExpress.XtraEditors.MemoEdit
        Me.txtBodyTextFR2 = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtImageTxtNL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtImageTxtFR2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleNL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleFR2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.txtImage2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.btnCreateNLQuizz = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateFRQuizz = New DevExpress.XtraEditors.SimpleButton
        Me.tabMSN3 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls1_NL = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_NL_TextB1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextAURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextBURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageText1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextA1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_Image1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls1_FR = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_FR_TextB1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextAURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextBURL1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageText1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextA1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_Image1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls2_NL = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_NL_TextB2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextAURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextBURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageText2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextA2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_Image2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls2_FR = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_FR_TextB2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextAURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextBURL2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageText2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextA2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_Image2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls3_NL = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_NL_TextB3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextAURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextBURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageText3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextA3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_Image3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls3_FR = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_FR_TextB3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextAURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextBURL3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageText3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextA3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_Image3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls4_NL = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_NL_TextB4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextAURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextBURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_ImageText4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_TextA4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_NL_Image4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl
        Me.PictSls4_FR = New DevExpress.XtraEditors.PictureEdit
        Me.txtSls_FR_TextB4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextAURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextBURL4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_ImageText4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_TextA4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl
        Me.txtSls_FR_Image4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl
        Me.btnCreateRentNL = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateRentFR = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateSlsFR = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadSls = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateSlsNL = New DevExpress.XtraEditors.SimpleButton
        Me.btnLoadRent = New DevExpress.XtraEditors.SimpleButton
        Me.PictContestNL_Image = New DevExpress.XtraEditors.PictureEdit
        Me.txtImage1NL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tabMSN1.SuspendLayout()
        CType(Me.grpMSN1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMSN1.SuspendLayout()
        CType(Me.PictContestFR_Image.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleUrlNL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleUrlFR1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodyTextNL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodyTextFR1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageTxtNL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageTxtFR1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleNL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleFR1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImage1FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMSN2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictQuizz_Image.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleUrlNL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleUrlFR2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodyTextNL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBodyTextFR2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageTxtNL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageTxtFR2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleNL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleFR2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImage2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMSN3.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PictSls1_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextB1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextAURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextBURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageText1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_Image1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictSls1_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextB1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextAURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextBURL1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageText1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_Image1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.PictSls2_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextB2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextAURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextBURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageText2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextA2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_Image2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.PictSls2_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextB2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextAURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextBURL2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageText2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextA2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_Image2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.PictSls3_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextB3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextAURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextBURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageText3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextA3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_Image3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.PictSls3_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextB3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextAURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextBURL3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageText3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextA3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_Image3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.PictSls4_NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextB4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextAURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextBURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_ImageText4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_TextA4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_NL_Image4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.PictSls4_FR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextB4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextAURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextBURL4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_ImageText4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_TextA4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSls_FR_Image4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictContestNL_Image.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImage1NL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabMSN1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1109, 469)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMSN1, Me.tabMSN2, Me.tabMSN3})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'tabMSN1
        '
        Me.tabMSN1.Controls.Add(Me.grpMSN1)
        Me.tabMSN1.Name = "tabMSN1"
        Me.tabMSN1.Size = New System.Drawing.Size(1100, 438)
        Me.tabMSN1.Text = "Contest"
        '
        'grpMSN1
        '
        Me.grpMSN1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.grpMSN1.Controls.Add(Me.txtImage1NL)
        Me.grpMSN1.Controls.Add(Me.LabelControl76)
        Me.grpMSN1.Controls.Add(Me.PictContestNL_Image)
        Me.grpMSN1.Controls.Add(Me.PictContestFR_Image)
        Me.grpMSN1.Controls.Add(Me.btnLoadNLContest)
        Me.grpMSN1.Controls.Add(Me.btnLoadFRContest)
        Me.grpMSN1.Controls.Add(Me.txtTitleUrlNL1)
        Me.grpMSN1.Controls.Add(Me.LabelControl16)
        Me.grpMSN1.Controls.Add(Me.txtTitleUrlFR1)
        Me.grpMSN1.Controls.Add(Me.LabelControl15)
        Me.grpMSN1.Controls.Add(Me.txtBodyTextNL1)
        Me.grpMSN1.Controls.Add(Me.txtBodyTextFR1)
        Me.grpMSN1.Controls.Add(Me.LabelControl6)
        Me.grpMSN1.Controls.Add(Me.LabelControl7)
        Me.grpMSN1.Controls.Add(Me.txtImageTxtNL1)
        Me.grpMSN1.Controls.Add(Me.LabelControl4)
        Me.grpMSN1.Controls.Add(Me.txtImageTxtFR1)
        Me.grpMSN1.Controls.Add(Me.LabelControl5)
        Me.grpMSN1.Controls.Add(Me.txtTitleNL1)
        Me.grpMSN1.Controls.Add(Me.LabelControl3)
        Me.grpMSN1.Controls.Add(Me.txtTitleFR1)
        Me.grpMSN1.Controls.Add(Me.LabelControl2)
        Me.grpMSN1.Controls.Add(Me.txtImage1FR)
        Me.grpMSN1.Controls.Add(Me.LabelControl1)
        Me.grpMSN1.Controls.Add(Me.btnCreateNLContest)
        Me.grpMSN1.Controls.Add(Me.btnCreateFRContest)
        Me.grpMSN1.Location = New System.Drawing.Point(9, 3)
        Me.grpMSN1.Name = "grpMSN1"
        Me.grpMSN1.Size = New System.Drawing.Size(996, 402)
        Me.grpMSN1.TabIndex = 0
        Me.grpMSN1.Text = "1 Image and Text"
        '
        'PictContestFR_Image
        '
        Me.PictContestFR_Image.Location = New System.Drawing.Point(376, 229)
        Me.PictContestFR_Image.Name = "PictContestFR_Image"
        Me.PictContestFR_Image.Properties.ReadOnly = True
        Me.PictContestFR_Image.Size = New System.Drawing.Size(100, 136)
        Me.PictContestFR_Image.TabIndex = 21
        '
        'btnLoadNLContest
        '
        Me.btnLoadNLContest.Location = New System.Drawing.Point(599, 229)
        Me.btnLoadNLContest.Name = "btnLoadNLContest"
        Me.btnLoadNLContest.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadNLContest.TabIndex = 20
        Me.btnLoadNLContest.Text = "Load NL XML"
        '
        'btnLoadFRContest
        '
        Me.btnLoadFRContest.Location = New System.Drawing.Point(125, 229)
        Me.btnLoadFRContest.Name = "btnLoadFRContest"
        Me.btnLoadFRContest.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadFRContest.TabIndex = 19
        Me.btnLoadFRContest.Text = "Load FR XML"
        '
        'txtTitleUrlNL1
        '
        Me.txtTitleUrlNL1.EditValue = "http://dvd.msn.be/contest.php"
        Me.txtTitleUrlNL1.Location = New System.Drawing.Point(601, 110)
        Me.txtTitleUrlNL1.Name = "txtTitleUrlNL1"
        Me.txtTitleUrlNL1.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleUrlNL1.TabIndex = 8
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(490, 113)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl16.TabIndex = 18
        Me.LabelControl16.Text = "Title URL NL"
        '
        'txtTitleUrlFR1
        '
        Me.txtTitleUrlFR1.EditValue = "http://dvd.fr.msn.be/contest.php"
        Me.txtTitleUrlFR1.Location = New System.Drawing.Point(127, 110)
        Me.txtTitleUrlFR1.Name = "txtTitleUrlFR1"
        Me.txtTitleUrlFR1.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleUrlFR1.TabIndex = 3
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl15.TabIndex = 16
        Me.LabelControl15.Text = "Title URL FR"
        '
        'txtBodyTextNL1
        '
        Me.txtBodyTextNL1.Location = New System.Drawing.Point(601, 136)
        Me.txtBodyTextNL1.Name = "txtBodyTextNL1"
        Me.txtBodyTextNL1.Size = New System.Drawing.Size(349, 87)
        Me.txtBodyTextNL1.TabIndex = 9
        '
        'txtBodyTextFR1
        '
        Me.txtBodyTextFR1.Location = New System.Drawing.Point(127, 136)
        Me.txtBodyTextFR1.Name = "txtBodyTextFR1"
        Me.txtBodyTextFR1.Size = New System.Drawing.Size(349, 87)
        Me.txtBodyTextFR1.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(490, 131)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Text NL"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Text FR"
        '
        'txtImageTxtNL1
        '
        Me.txtImageTxtNL1.Location = New System.Drawing.Point(601, 60)
        Me.txtImageTxtNL1.Name = "txtImageTxtNL1"
        Me.txtImageTxtNL1.Size = New System.Drawing.Size(349, 20)
        Me.txtImageTxtNL1.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(490, 63)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Image Text NL"
        '
        'txtImageTxtFR1
        '
        Me.txtImageTxtFR1.Location = New System.Drawing.Point(127, 60)
        Me.txtImageTxtFR1.Name = "txtImageTxtFR1"
        Me.txtImageTxtFR1.Size = New System.Drawing.Size(349, 20)
        Me.txtImageTxtFR1.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Image Text FR"
        '
        'txtTitleNL1
        '
        Me.txtTitleNL1.Location = New System.Drawing.Point(601, 86)
        Me.txtTitleNL1.Name = "txtTitleNL1"
        Me.txtTitleNL1.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleNL1.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(490, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Title NL"
        '
        'txtTitleFR1
        '
        Me.txtTitleFR1.Location = New System.Drawing.Point(127, 86)
        Me.txtTitleFR1.Name = "txtTitleFR1"
        Me.txtTitleFR1.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleFR1.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Title FR"
        '
        'txtImage1FR
        '
        Me.txtImage1FR.Location = New System.Drawing.Point(127, 34)
        Me.txtImage1FR.Name = "txtImage1FR"
        Me.txtImage1FR.Size = New System.Drawing.Size(349, 20)
        Me.txtImage1FR.TabIndex = 0
        Me.txtImage1FR.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Image FR"
        '
        'btnCreateNLContest
        '
        Me.btnCreateNLContest.Location = New System.Drawing.Point(693, 229)
        Me.btnCreateNLContest.Name = "btnCreateNLContest"
        Me.btnCreateNLContest.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateNLContest.TabIndex = 10
        Me.btnCreateNLContest.Text = "Create NL XML"
        '
        'btnCreateFRContest
        '
        Me.btnCreateFRContest.Location = New System.Drawing.Point(219, 229)
        Me.btnCreateFRContest.Name = "btnCreateFRContest"
        Me.btnCreateFRContest.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateFRContest.TabIndex = 5
        Me.btnCreateFRContest.Text = "Create FR XML"
        '
        'tabMSN2
        '
        Me.tabMSN2.Controls.Add(Me.GroupControl1)
        Me.tabMSN2.Name = "tabMSN2"
        Me.tabMSN2.Size = New System.Drawing.Size(1100, 438)
        Me.tabMSN2.Text = "Quizz"
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.PictQuizz_Image)
        Me.GroupControl1.Controls.Add(Me.btnLoadNLQuizz)
        Me.GroupControl1.Controls.Add(Me.btnLoadFRQuizz)
        Me.GroupControl1.Controls.Add(Me.txtTitleUrlNL2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtTitleUrlFR2)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtBodyTextNL2)
        Me.GroupControl1.Controls.Add(Me.txtBodyTextFR2)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtImageTxtNL2)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txtImageTxtFR2)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txtTitleNL2)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.txtTitleFR2)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.txtImage2)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.btnCreateNLQuizz)
        Me.GroupControl1.Controls.Add(Me.btnCreateFRQuizz)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(996, 402)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "1 Image and Text"
        '
        'PictQuizz_Image
        '
        Me.PictQuizz_Image.Location = New System.Drawing.Point(490, 229)
        Me.PictQuizz_Image.Name = "PictQuizz_Image"
        Me.PictQuizz_Image.Properties.ReadOnly = True
        Me.PictQuizz_Image.Size = New System.Drawing.Size(100, 136)
        Me.PictQuizz_Image.TabIndex = 22
        '
        'btnLoadNLQuizz
        '
        Me.btnLoadNLQuizz.Location = New System.Drawing.Point(599, 229)
        Me.btnLoadNLQuizz.Name = "btnLoadNLQuizz"
        Me.btnLoadNLQuizz.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadNLQuizz.TabIndex = 20
        Me.btnLoadNLQuizz.Text = "Load NL XML"
        '
        'btnLoadFRQuizz
        '
        Me.btnLoadFRQuizz.Location = New System.Drawing.Point(125, 229)
        Me.btnLoadFRQuizz.Name = "btnLoadFRQuizz"
        Me.btnLoadFRQuizz.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadFRQuizz.TabIndex = 19
        Me.btnLoadFRQuizz.Text = "Load FR XML"
        '
        'txtTitleUrlNL2
        '
        Me.txtTitleUrlNL2.EditValue = "http://dvd.msn.be/quizz.php"
        Me.txtTitleUrlNL2.Location = New System.Drawing.Point(601, 110)
        Me.txtTitleUrlNL2.Name = "txtTitleUrlNL2"
        Me.txtTitleUrlNL2.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleUrlNL2.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(490, 113)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Title URL NL"
        '
        'txtTitleUrlFR2
        '
        Me.txtTitleUrlFR2.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtTitleUrlFR2.Location = New System.Drawing.Point(127, 110)
        Me.txtTitleUrlFR2.Name = "txtTitleUrlFR2"
        Me.txtTitleUrlFR2.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleUrlFR2.TabIndex = 3
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Title URL FR"
        '
        'txtBodyTextNL2
        '
        Me.txtBodyTextNL2.Location = New System.Drawing.Point(601, 136)
        Me.txtBodyTextNL2.Name = "txtBodyTextNL2"
        Me.txtBodyTextNL2.Size = New System.Drawing.Size(349, 87)
        Me.txtBodyTextNL2.TabIndex = 9
        '
        'txtBodyTextFR2
        '
        Me.txtBodyTextFR2.Location = New System.Drawing.Point(127, 136)
        Me.txtBodyTextFR2.Name = "txtBodyTextFR2"
        Me.txtBodyTextFR2.Size = New System.Drawing.Size(349, 87)
        Me.txtBodyTextFR2.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(490, 131)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl10.TabIndex = 14
        Me.LabelControl10.Text = "Text NL"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl11.TabIndex = 12
        Me.LabelControl11.Text = "Text FR"
        '
        'txtImageTxtNL2
        '
        Me.txtImageTxtNL2.Location = New System.Drawing.Point(601, 60)
        Me.txtImageTxtNL2.Name = "txtImageTxtNL2"
        Me.txtImageTxtNL2.Size = New System.Drawing.Size(349, 20)
        Me.txtImageTxtNL2.TabIndex = 6
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(490, 63)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl12.TabIndex = 10
        Me.LabelControl12.Text = "Image Text NL"
        '
        'txtImageTxtFR2
        '
        Me.txtImageTxtFR2.Location = New System.Drawing.Point(127, 60)
        Me.txtImageTxtFR2.Name = "txtImageTxtFR2"
        Me.txtImageTxtFR2.Size = New System.Drawing.Size(349, 20)
        Me.txtImageTxtFR2.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl13.TabIndex = 8
        Me.LabelControl13.Text = "Image Text FR"
        '
        'txtTitleNL2
        '
        Me.txtTitleNL2.Location = New System.Drawing.Point(601, 86)
        Me.txtTitleNL2.Name = "txtTitleNL2"
        Me.txtTitleNL2.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleNL2.TabIndex = 7
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(490, 89)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl14.TabIndex = 6
        Me.LabelControl14.Text = "Title NL"
        '
        'txtTitleFR2
        '
        Me.txtTitleFR2.Location = New System.Drawing.Point(127, 86)
        Me.txtTitleFR2.Name = "txtTitleFR2"
        Me.txtTitleFR2.Size = New System.Drawing.Size(349, 20)
        Me.txtTitleFR2.TabIndex = 2
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl17.TabIndex = 4
        Me.LabelControl17.Text = "Title FR"
        '
        'txtImage2
        '
        Me.txtImage2.Location = New System.Drawing.Point(127, 34)
        Me.txtImage2.Name = "txtImage2"
        Me.txtImage2.Size = New System.Drawing.Size(823, 20)
        Me.txtImage2.TabIndex = 0
        Me.txtImage2.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl18.TabIndex = 2
        Me.LabelControl18.Text = "Image"
        '
        'btnCreateNLQuizz
        '
        Me.btnCreateNLQuizz.Location = New System.Drawing.Point(693, 229)
        Me.btnCreateNLQuizz.Name = "btnCreateNLQuizz"
        Me.btnCreateNLQuizz.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateNLQuizz.TabIndex = 10
        Me.btnCreateNLQuizz.Text = "Create NL XML"
        '
        'btnCreateFRQuizz
        '
        Me.btnCreateFRQuizz.Location = New System.Drawing.Point(219, 229)
        Me.btnCreateFRQuizz.Name = "btnCreateFRQuizz"
        Me.btnCreateFRQuizz.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateFRQuizz.TabIndex = 5
        Me.btnCreateFRQuizz.Text = "Create FR XML"
        '
        'tabMSN3
        '
        Me.tabMSN3.Controls.Add(Me.XtraTabControl2)
        Me.tabMSN3.Controls.Add(Me.PanelControl1)
        Me.tabMSN3.Name = "tabMSN3"
        Me.tabMSN3.Size = New System.Drawing.Size(1100, 438)
        Me.tabMSN3.Text = "Sales / Rentchase"
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XtraTabControl2.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 34)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl2.Size = New System.Drawing.Size(1100, 404)
        Me.XtraTabControl2.TabIndex = 4
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        Me.XtraTabControl2.Text = "XtraTabControl2"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1043, 395)
        Me.XtraTabPage1.Text = "Image 1"
        '
        'GroupControl3
        '
        Me.GroupControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl3.Controls.Add(Me.PictSls1_NL)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_TextB1)
        Me.GroupControl3.Controls.Add(Me.LabelControl19)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_TextAURL1)
        Me.GroupControl3.Controls.Add(Me.LabelControl21)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_ImageURL1)
        Me.GroupControl3.Controls.Add(Me.LabelControl22)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_TextBURL1)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_ImageText1)
        Me.GroupControl3.Controls.Add(Me.LabelControl25)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_TextA1)
        Me.GroupControl3.Controls.Add(Me.LabelControl31)
        Me.GroupControl3.Controls.Add(Me.txtSls_NL_Image1)
        Me.GroupControl3.Controls.Add(Me.LabelControl32)
        Me.GroupControl3.Location = New System.Drawing.Point(500, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(486, 365)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "NL"
        '
        'PictSls1_NL
        '
        Me.PictSls1_NL.Location = New System.Drawing.Point(127, 213)
        Me.PictSls1_NL.Name = "PictSls1_NL"
        Me.PictSls1_NL.Properties.ReadOnly = True
        Me.PictSls1_NL.Size = New System.Drawing.Size(100, 136)
        Me.PictSls1_NL.TabIndex = 27
        '
        'txtSls_NL_TextB1
        '
        Me.txtSls_NL_TextB1.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_NL_TextB1.Name = "txtSls_NL_TextB1"
        Me.txtSls_NL_TextB1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextB1.TabIndex = 25
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl19.TabIndex = 26
        Me.LabelControl19.Text = "Text B"
        '
        'txtSls_NL_TextAURL1
        '
        Me.txtSls_NL_TextAURL1.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_NL_TextAURL1.Name = "txtSls_NL_TextAURL1"
        Me.txtSls_NL_TextAURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextAURL1.TabIndex = 23
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl21.TabIndex = 24
        Me.LabelControl21.Text = "Text A URL"
        '
        'txtSls_NL_ImageURL1
        '
        Me.txtSls_NL_ImageURL1.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_NL_ImageURL1.Name = "txtSls_NL_ImageURL1"
        Me.txtSls_NL_ImageURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageURL1.TabIndex = 21
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl22.TabIndex = 22
        Me.LabelControl22.Text = "Image URL"
        '
        'txtSls_NL_TextBURL1
        '
        Me.txtSls_NL_TextBURL1.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_NL_TextBURL1.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_NL_TextBURL1.Name = "txtSls_NL_TextBURL1"
        Me.txtSls_NL_TextBURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextBURL1.TabIndex = 3
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl23.TabIndex = 16
        Me.LabelControl23.Text = "Text B URL"
        '
        'txtSls_NL_ImageText1
        '
        Me.txtSls_NL_ImageText1.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_NL_ImageText1.Name = "txtSls_NL_ImageText1"
        Me.txtSls_NL_ImageText1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageText1.TabIndex = 1
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl25.TabIndex = 8
        Me.LabelControl25.Text = "Image Text"
        '
        'txtSls_NL_TextA1
        '
        Me.txtSls_NL_TextA1.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_NL_TextA1.Name = "txtSls_NL_TextA1"
        Me.txtSls_NL_TextA1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextA1.TabIndex = 2
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl31.TabIndex = 4
        Me.LabelControl31.Text = "Text A"
        '
        'txtSls_NL_Image1
        '
        Me.txtSls_NL_Image1.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_NL_Image1.Name = "txtSls_NL_Image1"
        Me.txtSls_NL_Image1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_Image1.TabIndex = 0
        Me.txtSls_NL_Image1.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl32.TabIndex = 2
        Me.LabelControl32.Text = "Image"
        '
        'GroupControl2
        '
        Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl2.Controls.Add(Me.PictSls1_FR)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_TextB1)
        Me.GroupControl2.Controls.Add(Me.LabelControl30)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_TextAURL1)
        Me.GroupControl2.Controls.Add(Me.LabelControl29)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_ImageURL1)
        Me.GroupControl2.Controls.Add(Me.LabelControl28)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_TextBURL1)
        Me.GroupControl2.Controls.Add(Me.LabelControl20)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_ImageText1)
        Me.GroupControl2.Controls.Add(Me.LabelControl24)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_TextA1)
        Me.GroupControl2.Controls.Add(Me.LabelControl26)
        Me.GroupControl2.Controls.Add(Me.txtSls_FR_Image1)
        Me.GroupControl2.Controls.Add(Me.LabelControl27)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(486, 365)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "FR"
        '
        'PictSls1_FR
        '
        Me.PictSls1_FR.Location = New System.Drawing.Point(127, 213)
        Me.PictSls1_FR.Name = "PictSls1_FR"
        Me.PictSls1_FR.Properties.ReadOnly = True
        Me.PictSls1_FR.Size = New System.Drawing.Size(100, 136)
        Me.PictSls1_FR.TabIndex = 27
        '
        'txtSls_FR_TextB1
        '
        Me.txtSls_FR_TextB1.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_FR_TextB1.Name = "txtSls_FR_TextB1"
        Me.txtSls_FR_TextB1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextB1.TabIndex = 25
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl30.TabIndex = 26
        Me.LabelControl30.Text = "Text B"
        '
        'txtSls_FR_TextAURL1
        '
        Me.txtSls_FR_TextAURL1.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_FR_TextAURL1.Name = "txtSls_FR_TextAURL1"
        Me.txtSls_FR_TextAURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextAURL1.TabIndex = 23
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl29.TabIndex = 24
        Me.LabelControl29.Text = "Text A  URL"
        '
        'txtSls_FR_ImageURL1
        '
        Me.txtSls_FR_ImageURL1.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_FR_ImageURL1.Name = "txtSls_FR_ImageURL1"
        Me.txtSls_FR_ImageURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageURL1.TabIndex = 21
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl28.TabIndex = 22
        Me.LabelControl28.Text = "Image URL"
        '
        'txtSls_FR_TextBURL1
        '
        Me.txtSls_FR_TextBURL1.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_FR_TextBURL1.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_FR_TextBURL1.Name = "txtSls_FR_TextBURL1"
        Me.txtSls_FR_TextBURL1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextBURL1.TabIndex = 3
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl20.TabIndex = 16
        Me.LabelControl20.Text = "Text B URL"
        '
        'txtSls_FR_ImageText1
        '
        Me.txtSls_FR_ImageText1.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_FR_ImageText1.Name = "txtSls_FR_ImageText1"
        Me.txtSls_FR_ImageText1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageText1.TabIndex = 1
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl24.TabIndex = 8
        Me.LabelControl24.Text = "Image Text"
        '
        'txtSls_FR_TextA1
        '
        Me.txtSls_FR_TextA1.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_FR_TextA1.Name = "txtSls_FR_TextA1"
        Me.txtSls_FR_TextA1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextA1.TabIndex = 2
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl26.TabIndex = 4
        Me.LabelControl26.Text = "Text A"
        '
        'txtSls_FR_Image1
        '
        Me.txtSls_FR_Image1.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_FR_Image1.Name = "txtSls_FR_Image1"
        Me.txtSls_FR_Image1.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_Image1.TabIndex = 0
        Me.txtSls_FR_Image1.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl27.TabIndex = 2
        Me.LabelControl27.Text = "Image"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1043, 395)
        Me.XtraTabPage2.Text = "Image 2"
        '
        'GroupControl4
        '
        Me.GroupControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl4.Controls.Add(Me.PictSls2_NL)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_TextB2)
        Me.GroupControl4.Controls.Add(Me.LabelControl33)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_TextAURL2)
        Me.GroupControl4.Controls.Add(Me.LabelControl34)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_ImageURL2)
        Me.GroupControl4.Controls.Add(Me.LabelControl35)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_TextBURL2)
        Me.GroupControl4.Controls.Add(Me.LabelControl36)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_ImageText2)
        Me.GroupControl4.Controls.Add(Me.LabelControl37)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_TextA2)
        Me.GroupControl4.Controls.Add(Me.LabelControl38)
        Me.GroupControl4.Controls.Add(Me.txtSls_NL_Image2)
        Me.GroupControl4.Controls.Add(Me.LabelControl39)
        Me.GroupControl4.Location = New System.Drawing.Point(500, 3)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(486, 358)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "NL"
        '
        'PictSls2_NL
        '
        Me.PictSls2_NL.Location = New System.Drawing.Point(127, 213)
        Me.PictSls2_NL.Name = "PictSls2_NL"
        Me.PictSls2_NL.Properties.ReadOnly = True
        Me.PictSls2_NL.Size = New System.Drawing.Size(100, 136)
        Me.PictSls2_NL.TabIndex = 27
        '
        'txtSls_NL_TextB2
        '
        Me.txtSls_NL_TextB2.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_NL_TextB2.Name = "txtSls_NL_TextB2"
        Me.txtSls_NL_TextB2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextB2.TabIndex = 25
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl33.TabIndex = 26
        Me.LabelControl33.Text = "Text B"
        '
        'txtSls_NL_TextAURL2
        '
        Me.txtSls_NL_TextAURL2.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_NL_TextAURL2.Name = "txtSls_NL_TextAURL2"
        Me.txtSls_NL_TextAURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextAURL2.TabIndex = 23
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl34.TabIndex = 24
        Me.LabelControl34.Text = "Text A URL"
        '
        'txtSls_NL_ImageURL2
        '
        Me.txtSls_NL_ImageURL2.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_NL_ImageURL2.Name = "txtSls_NL_ImageURL2"
        Me.txtSls_NL_ImageURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageURL2.TabIndex = 21
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl35.TabIndex = 22
        Me.LabelControl35.Text = "Image URL"
        '
        'txtSls_NL_TextBURL2
        '
        Me.txtSls_NL_TextBURL2.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_NL_TextBURL2.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_NL_TextBURL2.Name = "txtSls_NL_TextBURL2"
        Me.txtSls_NL_TextBURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextBURL2.TabIndex = 3
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl36.TabIndex = 16
        Me.LabelControl36.Text = "Text B URL"
        '
        'txtSls_NL_ImageText2
        '
        Me.txtSls_NL_ImageText2.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_NL_ImageText2.Name = "txtSls_NL_ImageText2"
        Me.txtSls_NL_ImageText2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageText2.TabIndex = 1
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl37.TabIndex = 8
        Me.LabelControl37.Text = "Image Text"
        '
        'txtSls_NL_TextA2
        '
        Me.txtSls_NL_TextA2.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_NL_TextA2.Name = "txtSls_NL_TextA2"
        Me.txtSls_NL_TextA2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextA2.TabIndex = 2
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl38.TabIndex = 4
        Me.LabelControl38.Text = "Text A"
        '
        'txtSls_NL_Image2
        '
        Me.txtSls_NL_Image2.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_NL_Image2.Name = "txtSls_NL_Image2"
        Me.txtSls_NL_Image2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_Image2.TabIndex = 0
        Me.txtSls_NL_Image2.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl39.TabIndex = 2
        Me.LabelControl39.Text = "Image"
        '
        'GroupControl5
        '
        Me.GroupControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl5.Controls.Add(Me.PictSls2_FR)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_TextB2)
        Me.GroupControl5.Controls.Add(Me.LabelControl40)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_TextAURL2)
        Me.GroupControl5.Controls.Add(Me.LabelControl41)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_ImageURL2)
        Me.GroupControl5.Controls.Add(Me.LabelControl42)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_TextBURL2)
        Me.GroupControl5.Controls.Add(Me.LabelControl43)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_ImageText2)
        Me.GroupControl5.Controls.Add(Me.LabelControl44)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_TextA2)
        Me.GroupControl5.Controls.Add(Me.LabelControl45)
        Me.GroupControl5.Controls.Add(Me.txtSls_FR_Image2)
        Me.GroupControl5.Controls.Add(Me.LabelControl46)
        Me.GroupControl5.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(486, 358)
        Me.GroupControl5.TabIndex = 4
        Me.GroupControl5.Text = "FR"
        '
        'PictSls2_FR
        '
        Me.PictSls2_FR.Location = New System.Drawing.Point(127, 213)
        Me.PictSls2_FR.Name = "PictSls2_FR"
        Me.PictSls2_FR.Properties.ReadOnly = True
        Me.PictSls2_FR.Size = New System.Drawing.Size(100, 136)
        Me.PictSls2_FR.TabIndex = 27
        '
        'txtSls_FR_TextB2
        '
        Me.txtSls_FR_TextB2.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_FR_TextB2.Name = "txtSls_FR_TextB2"
        Me.txtSls_FR_TextB2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextB2.TabIndex = 25
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl40.TabIndex = 26
        Me.LabelControl40.Text = "Text B"
        '
        'txtSls_FR_TextAURL2
        '
        Me.txtSls_FR_TextAURL2.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_FR_TextAURL2.Name = "txtSls_FR_TextAURL2"
        Me.txtSls_FR_TextAURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextAURL2.TabIndex = 23
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl41.TabIndex = 24
        Me.LabelControl41.Text = "Text A  URL"
        '
        'txtSls_FR_ImageURL2
        '
        Me.txtSls_FR_ImageURL2.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_FR_ImageURL2.Name = "txtSls_FR_ImageURL2"
        Me.txtSls_FR_ImageURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageURL2.TabIndex = 21
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl42.TabIndex = 22
        Me.LabelControl42.Text = "Image URL"
        '
        'txtSls_FR_TextBURL2
        '
        Me.txtSls_FR_TextBURL2.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_FR_TextBURL2.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_FR_TextBURL2.Name = "txtSls_FR_TextBURL2"
        Me.txtSls_FR_TextBURL2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextBURL2.TabIndex = 3
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl43.TabIndex = 16
        Me.LabelControl43.Text = "Text B URL"
        '
        'txtSls_FR_ImageText2
        '
        Me.txtSls_FR_ImageText2.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_FR_ImageText2.Name = "txtSls_FR_ImageText2"
        Me.txtSls_FR_ImageText2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageText2.TabIndex = 1
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl44.TabIndex = 8
        Me.LabelControl44.Text = "Image Text"
        '
        'txtSls_FR_TextA2
        '
        Me.txtSls_FR_TextA2.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_FR_TextA2.Name = "txtSls_FR_TextA2"
        Me.txtSls_FR_TextA2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextA2.TabIndex = 2
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl45.TabIndex = 4
        Me.LabelControl45.Text = "Text A"
        '
        'txtSls_FR_Image2
        '
        Me.txtSls_FR_Image2.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_FR_Image2.Name = "txtSls_FR_Image2"
        Me.txtSls_FR_Image2.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_Image2.TabIndex = 0
        Me.txtSls_FR_Image2.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl46.TabIndex = 2
        Me.LabelControl46.Text = "Image"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage3.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1043, 395)
        Me.XtraTabPage3.Text = "Image 3"
        '
        'GroupControl6
        '
        Me.GroupControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl6.Controls.Add(Me.PictSls3_NL)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_TextB3)
        Me.GroupControl6.Controls.Add(Me.LabelControl47)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_TextAURL3)
        Me.GroupControl6.Controls.Add(Me.LabelControl48)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_ImageURL3)
        Me.GroupControl6.Controls.Add(Me.LabelControl49)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_TextBURL3)
        Me.GroupControl6.Controls.Add(Me.LabelControl50)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_ImageText3)
        Me.GroupControl6.Controls.Add(Me.LabelControl51)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_TextA3)
        Me.GroupControl6.Controls.Add(Me.LabelControl52)
        Me.GroupControl6.Controls.Add(Me.txtSls_NL_Image3)
        Me.GroupControl6.Controls.Add(Me.LabelControl53)
        Me.GroupControl6.Location = New System.Drawing.Point(500, 3)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(486, 361)
        Me.GroupControl6.TabIndex = 7
        Me.GroupControl6.Text = "NL"
        '
        'PictSls3_NL
        '
        Me.PictSls3_NL.Location = New System.Drawing.Point(127, 213)
        Me.PictSls3_NL.Name = "PictSls3_NL"
        Me.PictSls3_NL.Properties.ReadOnly = True
        Me.PictSls3_NL.Size = New System.Drawing.Size(100, 136)
        Me.PictSls3_NL.TabIndex = 27
        '
        'txtSls_NL_TextB3
        '
        Me.txtSls_NL_TextB3.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_NL_TextB3.Name = "txtSls_NL_TextB3"
        Me.txtSls_NL_TextB3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextB3.TabIndex = 25
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl47.TabIndex = 26
        Me.LabelControl47.Text = "Text B"
        '
        'txtSls_NL_TextAURL3
        '
        Me.txtSls_NL_TextAURL3.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_NL_TextAURL3.Name = "txtSls_NL_TextAURL3"
        Me.txtSls_NL_TextAURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextAURL3.TabIndex = 23
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl48.TabIndex = 24
        Me.LabelControl48.Text = "Text A URL"
        '
        'txtSls_NL_ImageURL3
        '
        Me.txtSls_NL_ImageURL3.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_NL_ImageURL3.Name = "txtSls_NL_ImageURL3"
        Me.txtSls_NL_ImageURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageURL3.TabIndex = 21
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl49.TabIndex = 22
        Me.LabelControl49.Text = "Image URL"
        '
        'txtSls_NL_TextBURL3
        '
        Me.txtSls_NL_TextBURL3.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_NL_TextBURL3.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_NL_TextBURL3.Name = "txtSls_NL_TextBURL3"
        Me.txtSls_NL_TextBURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextBURL3.TabIndex = 3
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl50.TabIndex = 16
        Me.LabelControl50.Text = "Text B URL"
        '
        'txtSls_NL_ImageText3
        '
        Me.txtSls_NL_ImageText3.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_NL_ImageText3.Name = "txtSls_NL_ImageText3"
        Me.txtSls_NL_ImageText3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageText3.TabIndex = 1
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl51.TabIndex = 8
        Me.LabelControl51.Text = "Image Text"
        '
        'txtSls_NL_TextA3
        '
        Me.txtSls_NL_TextA3.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_NL_TextA3.Name = "txtSls_NL_TextA3"
        Me.txtSls_NL_TextA3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextA3.TabIndex = 2
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl52.TabIndex = 4
        Me.LabelControl52.Text = "Text A"
        '
        'txtSls_NL_Image3
        '
        Me.txtSls_NL_Image3.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_NL_Image3.Name = "txtSls_NL_Image3"
        Me.txtSls_NL_Image3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_Image3.TabIndex = 0
        Me.txtSls_NL_Image3.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl53.TabIndex = 2
        Me.LabelControl53.Text = "Image"
        '
        'GroupControl7
        '
        Me.GroupControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl7.Controls.Add(Me.PictSls3_FR)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_TextB3)
        Me.GroupControl7.Controls.Add(Me.LabelControl54)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_TextAURL3)
        Me.GroupControl7.Controls.Add(Me.LabelControl55)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_ImageURL3)
        Me.GroupControl7.Controls.Add(Me.LabelControl56)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_TextBURL3)
        Me.GroupControl7.Controls.Add(Me.LabelControl57)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_ImageText3)
        Me.GroupControl7.Controls.Add(Me.LabelControl58)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_TextA3)
        Me.GroupControl7.Controls.Add(Me.LabelControl59)
        Me.GroupControl7.Controls.Add(Me.txtSls_FR_Image3)
        Me.GroupControl7.Controls.Add(Me.LabelControl60)
        Me.GroupControl7.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(486, 361)
        Me.GroupControl7.TabIndex = 6
        Me.GroupControl7.Text = "FR"
        '
        'PictSls3_FR
        '
        Me.PictSls3_FR.Location = New System.Drawing.Point(127, 213)
        Me.PictSls3_FR.Name = "PictSls3_FR"
        Me.PictSls3_FR.Properties.ReadOnly = True
        Me.PictSls3_FR.Size = New System.Drawing.Size(100, 136)
        Me.PictSls3_FR.TabIndex = 27
        '
        'txtSls_FR_TextB3
        '
        Me.txtSls_FR_TextB3.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_FR_TextB3.Name = "txtSls_FR_TextB3"
        Me.txtSls_FR_TextB3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextB3.TabIndex = 25
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl54.TabIndex = 26
        Me.LabelControl54.Text = "Text B"
        '
        'txtSls_FR_TextAURL3
        '
        Me.txtSls_FR_TextAURL3.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_FR_TextAURL3.Name = "txtSls_FR_TextAURL3"
        Me.txtSls_FR_TextAURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextAURL3.TabIndex = 23
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl55.TabIndex = 24
        Me.LabelControl55.Text = "Text A  URL"
        '
        'txtSls_FR_ImageURL3
        '
        Me.txtSls_FR_ImageURL3.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_FR_ImageURL3.Name = "txtSls_FR_ImageURL3"
        Me.txtSls_FR_ImageURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageURL3.TabIndex = 21
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl56.TabIndex = 22
        Me.LabelControl56.Text = "Image URL"
        '
        'txtSls_FR_TextBURL3
        '
        Me.txtSls_FR_TextBURL3.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_FR_TextBURL3.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_FR_TextBURL3.Name = "txtSls_FR_TextBURL3"
        Me.txtSls_FR_TextBURL3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextBURL3.TabIndex = 3
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl57.TabIndex = 16
        Me.LabelControl57.Text = "Text B URL"
        '
        'txtSls_FR_ImageText3
        '
        Me.txtSls_FR_ImageText3.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_FR_ImageText3.Name = "txtSls_FR_ImageText3"
        Me.txtSls_FR_ImageText3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageText3.TabIndex = 1
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl58.TabIndex = 8
        Me.LabelControl58.Text = "Image Text"
        '
        'txtSls_FR_TextA3
        '
        Me.txtSls_FR_TextA3.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_FR_TextA3.Name = "txtSls_FR_TextA3"
        Me.txtSls_FR_TextA3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextA3.TabIndex = 2
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl59.TabIndex = 4
        Me.LabelControl59.Text = "Text A"
        '
        'txtSls_FR_Image3
        '
        Me.txtSls_FR_Image3.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_FR_Image3.Name = "txtSls_FR_Image3"
        Me.txtSls_FR_Image3.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_Image3.TabIndex = 0
        Me.txtSls_FR_Image3.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl60.TabIndex = 2
        Me.LabelControl60.Text = "Image"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GroupControl8)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl9)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1043, 395)
        Me.XtraTabPage4.Text = "Image 4"
        '
        'GroupControl8
        '
        Me.GroupControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl8.Controls.Add(Me.PictSls4_NL)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_TextB4)
        Me.GroupControl8.Controls.Add(Me.LabelControl61)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_TextAURL4)
        Me.GroupControl8.Controls.Add(Me.LabelControl62)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_ImageURL4)
        Me.GroupControl8.Controls.Add(Me.LabelControl63)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_TextBURL4)
        Me.GroupControl8.Controls.Add(Me.LabelControl64)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_ImageText4)
        Me.GroupControl8.Controls.Add(Me.LabelControl65)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_TextA4)
        Me.GroupControl8.Controls.Add(Me.LabelControl66)
        Me.GroupControl8.Controls.Add(Me.txtSls_NL_Image4)
        Me.GroupControl8.Controls.Add(Me.LabelControl67)
        Me.GroupControl8.Location = New System.Drawing.Point(500, 3)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(486, 361)
        Me.GroupControl8.TabIndex = 7
        Me.GroupControl8.Text = "NL"
        '
        'PictSls4_NL
        '
        Me.PictSls4_NL.Location = New System.Drawing.Point(127, 213)
        Me.PictSls4_NL.Name = "PictSls4_NL"
        Me.PictSls4_NL.Properties.ReadOnly = True
        Me.PictSls4_NL.Size = New System.Drawing.Size(100, 136)
        Me.PictSls4_NL.TabIndex = 27
        '
        'txtSls_NL_TextB4
        '
        Me.txtSls_NL_TextB4.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_NL_TextB4.Name = "txtSls_NL_TextB4"
        Me.txtSls_NL_TextB4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextB4.TabIndex = 25
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl61.TabIndex = 26
        Me.LabelControl61.Text = "Text B"
        '
        'txtSls_NL_TextAURL4
        '
        Me.txtSls_NL_TextAURL4.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_NL_TextAURL4.Name = "txtSls_NL_TextAURL4"
        Me.txtSls_NL_TextAURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextAURL4.TabIndex = 23
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl62.TabIndex = 24
        Me.LabelControl62.Text = "Text A URL"
        '
        'txtSls_NL_ImageURL4
        '
        Me.txtSls_NL_ImageURL4.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_NL_ImageURL4.Name = "txtSls_NL_ImageURL4"
        Me.txtSls_NL_ImageURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageURL4.TabIndex = 21
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl63.TabIndex = 22
        Me.LabelControl63.Text = "Image URL"
        '
        'txtSls_NL_TextBURL4
        '
        Me.txtSls_NL_TextBURL4.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_NL_TextBURL4.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_NL_TextBURL4.Name = "txtSls_NL_TextBURL4"
        Me.txtSls_NL_TextBURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextBURL4.TabIndex = 3
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl64.TabIndex = 16
        Me.LabelControl64.Text = "Text B URL"
        '
        'txtSls_NL_ImageText4
        '
        Me.txtSls_NL_ImageText4.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_NL_ImageText4.Name = "txtSls_NL_ImageText4"
        Me.txtSls_NL_ImageText4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_ImageText4.TabIndex = 1
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl65.TabIndex = 8
        Me.LabelControl65.Text = "Image Text"
        '
        'txtSls_NL_TextA4
        '
        Me.txtSls_NL_TextA4.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_NL_TextA4.Name = "txtSls_NL_TextA4"
        Me.txtSls_NL_TextA4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_TextA4.TabIndex = 2
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl66.TabIndex = 4
        Me.LabelControl66.Text = "Text A"
        '
        'txtSls_NL_Image4
        '
        Me.txtSls_NL_Image4.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_NL_Image4.Name = "txtSls_NL_Image4"
        Me.txtSls_NL_Image4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_NL_Image4.TabIndex = 0
        Me.txtSls_NL_Image4.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl67
        '
        Me.LabelControl67.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl67.TabIndex = 2
        Me.LabelControl67.Text = "Image"
        '
        'GroupControl9
        '
        Me.GroupControl9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl9.Controls.Add(Me.PictSls4_FR)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_TextB4)
        Me.GroupControl9.Controls.Add(Me.LabelControl68)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_TextAURL4)
        Me.GroupControl9.Controls.Add(Me.LabelControl69)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_ImageURL4)
        Me.GroupControl9.Controls.Add(Me.LabelControl70)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_TextBURL4)
        Me.GroupControl9.Controls.Add(Me.LabelControl71)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_ImageText4)
        Me.GroupControl9.Controls.Add(Me.LabelControl72)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_TextA4)
        Me.GroupControl9.Controls.Add(Me.LabelControl73)
        Me.GroupControl9.Controls.Add(Me.txtSls_FR_Image4)
        Me.GroupControl9.Controls.Add(Me.LabelControl74)
        Me.GroupControl9.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(486, 361)
        Me.GroupControl9.TabIndex = 6
        Me.GroupControl9.Text = "FR"
        '
        'PictSls4_FR
        '
        Me.PictSls4_FR.Location = New System.Drawing.Point(127, 213)
        Me.PictSls4_FR.Name = "PictSls4_FR"
        Me.PictSls4_FR.Properties.ReadOnly = True
        Me.PictSls4_FR.Size = New System.Drawing.Size(100, 136)
        Me.PictSls4_FR.TabIndex = 27
        '
        'txtSls_FR_TextB4
        '
        Me.txtSls_FR_TextB4.Location = New System.Drawing.Point(127, 161)
        Me.txtSls_FR_TextB4.Name = "txtSls_FR_TextB4"
        Me.txtSls_FR_TextB4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextB4.TabIndex = 25
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl68.TabIndex = 26
        Me.LabelControl68.Text = "Text B"
        '
        'txtSls_FR_TextAURL4
        '
        Me.txtSls_FR_TextAURL4.Location = New System.Drawing.Point(127, 135)
        Me.txtSls_FR_TextAURL4.Name = "txtSls_FR_TextAURL4"
        Me.txtSls_FR_TextAURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextAURL4.TabIndex = 23
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(16, 138)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl69.TabIndex = 24
        Me.LabelControl69.Text = "Text A  URL"
        '
        'txtSls_FR_ImageURL4
        '
        Me.txtSls_FR_ImageURL4.Location = New System.Drawing.Point(127, 86)
        Me.txtSls_FR_ImageURL4.Name = "txtSls_FR_ImageURL4"
        Me.txtSls_FR_ImageURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageURL4.TabIndex = 21
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(16, 89)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl70.TabIndex = 22
        Me.LabelControl70.Text = "Image URL"
        '
        'txtSls_FR_TextBURL4
        '
        Me.txtSls_FR_TextBURL4.EditValue = "http://dvd.fr.msn.be/quizz.php"
        Me.txtSls_FR_TextBURL4.Location = New System.Drawing.Point(127, 187)
        Me.txtSls_FR_TextBURL4.Name = "txtSls_FR_TextBURL4"
        Me.txtSls_FR_TextBURL4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextBURL4.TabIndex = 3
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl71.TabIndex = 16
        Me.LabelControl71.Text = "Text B URL"
        '
        'txtSls_FR_ImageText4
        '
        Me.txtSls_FR_ImageText4.Location = New System.Drawing.Point(127, 60)
        Me.txtSls_FR_ImageText4.Name = "txtSls_FR_ImageText4"
        Me.txtSls_FR_ImageText4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_ImageText4.TabIndex = 1
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(16, 63)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl72.TabIndex = 8
        Me.LabelControl72.Text = "Image Text"
        '
        'txtSls_FR_TextA4
        '
        Me.txtSls_FR_TextA4.Location = New System.Drawing.Point(127, 110)
        Me.txtSls_FR_TextA4.Name = "txtSls_FR_TextA4"
        Me.txtSls_FR_TextA4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_TextA4.TabIndex = 2
        '
        'LabelControl73
        '
        Me.LabelControl73.Location = New System.Drawing.Point(16, 113)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl73.TabIndex = 4
        Me.LabelControl73.Text = "Text A"
        '
        'txtSls_FR_Image4
        '
        Me.txtSls_FR_Image4.Location = New System.Drawing.Point(127, 34)
        Me.txtSls_FR_Image4.Name = "txtSls_FR_Image4"
        Me.txtSls_FR_Image4.Size = New System.Drawing.Size(349, 20)
        Me.txtSls_FR_Image4.TabIndex = 0
        Me.txtSls_FR_Image4.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(16, 37)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl74.TabIndex = 2
        Me.LabelControl74.Text = "Image"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.LabelControl75)
        Me.PanelControl1.Controls.Add(Me.btnCreateRentNL)
        Me.PanelControl1.Controls.Add(Me.btnCreateRentFR)
        Me.PanelControl1.Controls.Add(Me.btnCreateSlsFR)
        Me.PanelControl1.Controls.Add(Me.btnLoadSls)
        Me.PanelControl1.Controls.Add(Me.btnCreateSlsNL)
        Me.PanelControl1.Controls.Add(Me.btnLoadRent)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1100, 34)
        Me.PanelControl1.TabIndex = 3
        '
        'LabelControl75
        '
        Me.LabelControl75.Location = New System.Drawing.Point(366, 15)
        Me.LabelControl75.Name = "LabelControl75"
        Me.LabelControl75.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl75.TabIndex = 23
        Me.LabelControl75.Text = "Image 45 X 47 with .jpg extension"
        '
        'btnCreateRentNL
        '
        Me.btnCreateRentNL.Location = New System.Drawing.Point(739, 5)
        Me.btnCreateRentNL.Name = "btnCreateRentNL"
        Me.btnCreateRentNL.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateRentNL.TabIndex = 22
        Me.btnCreateRentNL.Text = "Create Rent NL"
        '
        'btnCreateRentFR
        '
        Me.btnCreateRentFR.Location = New System.Drawing.Point(645, 5)
        Me.btnCreateRentFR.Name = "btnCreateRentFR"
        Me.btnCreateRentFR.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateRentFR.TabIndex = 21
        Me.btnCreateRentFR.Text = "Create Rent FR"
        '
        'btnCreateSlsFR
        '
        Me.btnCreateSlsFR.Location = New System.Drawing.Point(148, 5)
        Me.btnCreateSlsFR.Name = "btnCreateSlsFR"
        Me.btnCreateSlsFR.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateSlsFR.TabIndex = 5
        Me.btnCreateSlsFR.Text = "Create SLS FR"
        '
        'btnLoadSls
        '
        Me.btnLoadSls.Location = New System.Drawing.Point(54, 6)
        Me.btnLoadSls.Name = "btnLoadSls"
        Me.btnLoadSls.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadSls.TabIndex = 19
        Me.btnLoadSls.Text = "Load SLS"
        '
        'btnCreateSlsNL
        '
        Me.btnCreateSlsNL.Location = New System.Drawing.Point(242, 5)
        Me.btnCreateSlsNL.Name = "btnCreateSlsNL"
        Me.btnCreateSlsNL.Size = New System.Drawing.Size(88, 23)
        Me.btnCreateSlsNL.TabIndex = 10
        Me.btnCreateSlsNL.Text = "Create SLS NL"
        '
        'btnLoadRent
        '
        Me.btnLoadRent.Location = New System.Drawing.Point(551, 5)
        Me.btnLoadRent.Name = "btnLoadRent"
        Me.btnLoadRent.Size = New System.Drawing.Size(88, 23)
        Me.btnLoadRent.TabIndex = 20
        Me.btnLoadRent.Text = "Load Rent"
        '
        'PictContestNL_Image
        '
        Me.PictContestNL_Image.Location = New System.Drawing.Point(850, 229)
        Me.PictContestNL_Image.Name = "PictContestNL_Image"
        Me.PictContestNL_Image.Properties.ReadOnly = True
        Me.PictContestNL_Image.Size = New System.Drawing.Size(100, 136)
        Me.PictContestNL_Image.TabIndex = 22
        '
        'txtImage1NL
        '
        Me.txtImage1NL.Location = New System.Drawing.Point(601, 34)
        Me.txtImage1NL.Name = "txtImage1NL"
        Me.txtImage1NL.Size = New System.Drawing.Size(349, 20)
        Me.txtImage1NL.TabIndex = 23
        Me.txtImage1NL.ToolTip = "Image 75 X 75 with .jpg extension"
        '
        'LabelControl76
        '
        Me.LabelControl76.Location = New System.Drawing.Point(490, 37)
        Me.LabelControl76.Name = "LabelControl76"
        Me.LabelControl76.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl76.TabIndex = 24
        Me.LabelControl76.Text = "Image NL"
        '
        'frmMSNUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1109, 499)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmMSNUtility"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tabMSN1.ResumeLayout(False)
        CType(Me.grpMSN1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMSN1.ResumeLayout(False)
        Me.grpMSN1.PerformLayout()
        CType(Me.PictContestFR_Image.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleUrlNL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleUrlFR1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodyTextNL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodyTextFR1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageTxtNL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageTxtFR1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleNL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleFR1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImage1FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMSN2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictQuizz_Image.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleUrlNL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleUrlFR2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodyTextNL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBodyTextFR2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageTxtNL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageTxtFR2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleNL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleFR2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImage2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMSN3.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.PictSls1_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextB1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextAURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextBURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageText1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_Image1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PictSls1_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextB1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextAURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextBURL1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageText1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_Image1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.PictSls2_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextB2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextAURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextBURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageText2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextA2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_Image2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.PictSls2_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextB2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextAURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextBURL2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageText2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextA2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_Image2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.PictSls3_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextB3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextAURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextBURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageText3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextA3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_Image3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.PictSls3_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextB3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextAURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextBURL3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageText3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextA3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_Image3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        CType(Me.PictSls4_NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextB4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextAURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextBURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_ImageText4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_TextA4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_NL_Image4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        Me.GroupControl9.PerformLayout()
        CType(Me.PictSls4_FR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextB4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextAURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextBURL4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_ImageText4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_TextA4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSls_FR_Image4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictContestNL_Image.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImage1NL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim mvarImagesServer As String = ""

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub frmMSNUtility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        mvarImagesServer = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'ImagesServer'")
        'LoadMSNContest("FR")
        'LoadMSNContest("NL")
        'LoadMSNQuizz("FR")
        'LoadMSNQuizz("NL")
    End Sub


#Region "Contest"
    Private Sub btnCreateFRContest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFRContest.Click
        CreateMSNContest("FR")
    End Sub
    Private Sub btnCreateNLContest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNLContest.Click
        CreateMSNContest("NL")
    End Sub
    Private Sub btnLoadFRContest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFRContest.Click
        LoadMSNContest("FR")
    End Sub
    Private Sub btnLoadNLContest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadNLContest.Click
        LoadMSNContest("NL")
    End Sub
    Private Sub CreateMSNContest(ByVal vLang As String)
        Dim _XMLStr As String
        _XMLStr = GetXMLTextType1()
        If vLang = "FR" Then
            _XMLStr = _XMLStr.Replace("$$$image$$$", txtImage1FR.EditValue)
            _XMLStr = _XMLStr.Replace("$$$url$$$", txtTitleUrlFR1.Text)
            _XMLStr = _XMLStr.Replace("$$$titletext$$$", txtTitleFR1.EditValue)
            _XMLStr = _XMLStr.Replace("$$$alternate$$$", txtImageTxtFR1.EditValue)
            _XMLStr = _XMLStr.Replace("$$$text$$$", txtBodyTextFR1.EditValue)
        Else
            _XMLStr = _XMLStr.Replace("$$$image$$$", txtImage1NL.EditValue)
            _XMLStr = _XMLStr.Replace("$$$url$$$", txtTitleUrlNL1.Text)
            _XMLStr = _XMLStr.Replace("$$$titletext$$$", txtTitleNL1.EditValue)
            _XMLStr = _XMLStr.Replace("$$$alternate$$$", txtImageTxtNL1.EditValue)
            _XMLStr = _XMLStr.Replace("$$$text$$$", txtBodyTextNL1.EditValue)
        End If
        Dim _txtStream As New System.IO.StreamWriter("\\" & mvarImagesServer & "\xml\msn\box_contest_" & vLang & ".xml")
        _txtStream.Write(_XMLStr)
        _txtStream.Close()
    End Sub
    Private Sub LoadMSNContest(ByVal vLang As String)
        Dim _XML As New Xml.XmlDocument
        _XML.Load("\\" & mvarImagesServer & "\xml\msn\box_contest_" & vLang & ".xml")
        If vLang = "FR" Then
            txtImage1FR.EditValue = _XML.GetElementsByTagName("cp:src").Item(0).InnerText
            txtTitleFR1.EditValue = _XML.GetElementsByTagName("cp:text").Item(0).InnerText
            txtTitleUrlFR1.EditValue = _XML.GetElementsByTagName("cp:url").Item(0).InnerText
            txtBodyTextFR1.EditValue = _XML.GetElementsByTagName("cp:abstract").Item(0).InnerText
            txtImageTxtFR1.EditValue = _XML.GetElementsByTagName("cp:alternatetext").Item(0).InnerText
        End If
        If vLang = "NL" Then
            txtImage1NL.EditValue = _XML.GetElementsByTagName("cp:src").Item(0).InnerText
            txtTitleNL1.EditValue = _XML.GetElementsByTagName("cp:text").Item(0).InnerText
            txtTitleUrlNL1.EditValue = _XML.GetElementsByTagName("cp:url").Item(0).InnerText
            txtBodyTextNL1.EditValue = _XML.GetElementsByTagName("cp:abstract").Item(0).InnerText
            txtImageTxtNL1.EditValue = _XML.GetElementsByTagName("cp:alternatetext").Item(0).InnerText
        End If
    End Sub
    Private Sub txtImage1FR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImage1FR.EditValueChanged
        RefreshImage(txtImage1FR.EditValue, PictContestFR_Image)
    End Sub
    Private Sub txtImage1NL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImage1NL.EditValueChanged
        RefreshImage(txtImage1NL.EditValue, PictContestNL_Image)
    End Sub

#End Region

#Region "Quizz"
    Private Sub btnCreateFRQuizz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFRQuizz.Click
        CreateMSNQuizz("FR")
    End Sub
    Private Sub btnCreateNLQuizz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNLQuizz.Click
        CreateMSNQuizz("NL")
    End Sub
    Private Sub btnLoadFRQuizz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFRQuizz.Click
        LoadMSNQuizz("FR")
    End Sub
    Private Sub btnLoadNLQuizz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadNLQuizz.Click
        LoadMSNQuizz("NL")
    End Sub
    Private Sub CreateMSNQuizz(ByVal vLang As String)
        Dim _XMLStr As String
        _XMLStr = GetXMLTextType1()
        _XMLStr = _XMLStr.Replace("$$$image$$$", txtImage2.EditValue)
        If vLang = "FR" Then
            _XMLStr = _XMLStr.Replace("$$$url$$$", txtTitleUrlFR2.Text)
            _XMLStr = _XMLStr.Replace("$$$titletext$$$", txtTitleFR2.EditValue)
            _XMLStr = _XMLStr.Replace("$$$alternate$$$", txtImageTxtFR2.EditValue)
            _XMLStr = _XMLStr.Replace("$$$text$$$", txtBodyTextFR2.EditValue)
        Else
            _XMLStr = _XMLStr.Replace("$$$url$$$", txtTitleUrlNL2.Text)
            _XMLStr = _XMLStr.Replace("$$$titletext$$$", txtTitleNL2.EditValue)
            _XMLStr = _XMLStr.Replace("$$$alternate$$$", txtImageTxtNL2.EditValue)
            _XMLStr = _XMLStr.Replace("$$$text$$$", txtBodyTextNL2.EditValue)
        End If
        Dim _txtStream As New System.IO.StreamWriter("\\" & mvarImagesServer & "\xml\msn\box_quizz_" & vLang & ".xml")
        _txtStream.Write(_XMLStr)
        _txtStream.Close()
    End Sub
    Private Sub LoadMSNQuizz(ByVal vLang As String)
        Dim _XML As New Xml.XmlDocument
        _XML.Load("\\" & mvarImagesServer & "\xml\msn\box_quizz_" & vLang & ".xml")
        txtImage2.EditValue = _XML.GetElementsByTagName("cp:src").Item(0).InnerText
        If vLang = "FR" Then
            txtTitleFR2.EditValue = _XML.GetElementsByTagName("cp:text").Item(0).InnerText
            txtTitleUrlFR2.EditValue = _XML.GetElementsByTagName("cp:url").Item(0).InnerText
            txtBodyTextFR2.EditValue = _XML.GetElementsByTagName("cp:abstract").Item(0).InnerText
            txtImageTxtFR2.EditValue = _XML.GetElementsByTagName("cp:alternatetext").Item(0).InnerText
        End If
        If vLang = "NL" Then
            txtTitleNL2.EditValue = _XML.GetElementsByTagName("cp:text").Item(0).InnerText
            txtTitleUrlNL2.EditValue = _XML.GetElementsByTagName("cp:url").Item(0).InnerText
            txtBodyTextNL2.EditValue = _XML.GetElementsByTagName("cp:abstract").Item(0).InnerText
            txtImageTxtNL2.EditValue = _XML.GetElementsByTagName("cp:alternatetext").Item(0).InnerText
        End If
    End Sub
    Private Sub txtImage2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImage2.EditValueChanged
        RefreshImage(txtImage2.EditValue, PictQuizz_Image)
    End Sub

#End Region

    Private Sub RefreshImage(ByVal vImageFile As String, ByVal vImageCtrl As DevExpress.XtraEditors.PictureEdit)
        Dim _FileStr As String
        If vImageFile & "" <> "" Then
            _FileStr = vImageFile
            _FileStr = _FileStr.Replace("http://www.dvdpost.be/", "\\" & mvarImagesServer & "\")
            _FileStr = _FileStr.Replace("/", "\")
            If System.IO.File.Exists(_FileStr) Then
                vImageCtrl.Image = System.Drawing.Image.FromFile(_FileStr)
            Else
                vImageCtrl.Image = Nothing
            End If
        Else
            vImageCtrl.Image = Nothing
        End If
    End Sub

    Private Sub CreateMSNType2(ByVal vType As String, ByVal vLang As String)
        Dim _XMLStr1 As String
        Dim _XMLStr2 As String
        _XMLStr1 = GetXMLTextType2_A() 'Image Part
        _XMLStr2 = GetXMLTextType2_B() 'Text Part
        _XMLStr1 = ReplaceType2(_XMLStr1, vLang)
        _XMLStr2 = ReplaceType2(_XMLStr2, vLang)
        Dim _txtStream As System.IO.StreamWriter
        _txtStream = New System.IO.StreamWriter("\\" & mvarImagesServer & "\xml\msn\box" & vType & "1_" & vLang & ".xml")
        _txtStream.Write(_XMLStr1)
        _txtStream.Close()
        _txtStream = New System.IO.StreamWriter("\\" & mvarImagesServer & "\xml\msn\box" & vType & "2_" & vLang & ".xml")
        _txtStream.Write(_XMLStr2)
        _txtStream.Close()
    End Sub
    Private Sub btnLoadSlsFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSls.Click
        LoadMSNSls("Sls", "FR")
        LoadMSNSls("Sls", "NL")
    End Sub
    Public Sub LoadMSNSls(ByVal vType As String, ByVal vLang As String)
        Dim _XML As New Xml.XmlDocument
        Dim _XMLNode As System.Xml.XmlElement
        Dim i As Integer
        _XML.Load("\\" & mvarImagesServer & "\xml\msn\box" & vType & "1_" & vLang & ".xml")
        For i = 1 To 4
            _XMLNode = _XML.GetElementsByTagName("cp:linkedimageabstract").Item(i - 1)
            InvertReplaceType2(vLang, 1, i, "cp:src", _XMLNode.GetElementsByTagName("cp:src").Item(0).InnerText)
            InvertReplaceType2(vLang, 1, i, "cp:alternatetext", _XMLNode.GetElementsByTagName("cp:alternatetext").Item(0).InnerText)
            InvertReplaceType2(vLang, 1, i, "my:ImageUrl", _XMLNode.GetElementsByTagName("my:ImageUrl").Item(0).InnerText)
            InvertReplaceType2(vLang, 1, i, "cp:abstract", _XMLNode.GetElementsByTagName("cp:abstract").Item(0).InnerText)
            InvertReplaceType2(vLang, 1, i, "cp:url", _XMLNode.GetElementsByTagName("cp:url").Item(0).InnerText)
        Next
        _XML.Load("\\" & mvarImagesServer & "\xml\msn\box" & vType & "2_" & vLang & ".xml")
        For i = 1 To 4
            _XMLNode = _XML.GetElementsByTagName("cp:link").Item(i - 1)
            InvertReplaceType2(vLang, 2, i, "cp:text", _XMLNode.GetElementsByTagName("cp:text").Item(0).InnerText)
            InvertReplaceType2(vLang, 2, i, "cp:url", _XMLNode.GetElementsByTagName("cp:url").Item(0).InnerText)
        Next
    End Sub
    Private Sub btnLoadRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRent.Click
        LoadMSNSls("Rent", "FR")
        LoadMSNSls("Rent", "NL")
    End Sub

    Public Function ReplaceType2(ByVal vXMLStr As String, ByVal vLang As String, Optional ByVal vCtrl As System.Windows.Forms.Control = Nothing) As String
        Dim _Ctrl As System.Windows.Forms.Control
        Dim i As Integer
        If IsNothing(vCtrl) Then vCtrl = tabMSN3
        For i = 1 To 4
            For Each _Ctrl In vCtrl.Controls
                vXMLStr = ReplaceType2(vXMLStr, vLang, _Ctrl)
                If _Ctrl.Name = ("txtSls_" & vLang & "_Image" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$Image" & i.ToString & "$$$", _Ctrl.Text & " ")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_ImageText" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$ImageText" & i.ToString & "$$$", _Ctrl.Text & " ")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_ImageURL" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$ImageURL" & i.ToString & "$$$", _Ctrl.Text & " ")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_TextA" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$Text" & i.ToString & "$$$", _Ctrl.Text & "")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_TextAURL" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$URL" & i.ToString & "$$$", _Ctrl.Text & "")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_TextB" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$TextB" & i.ToString & "$$$", _Ctrl.Text & "")
                End If
                If _Ctrl.Name = ("txtSls_" & vLang & "_TextBURL" & i.ToString) Then
                    vXMLStr = vXMLStr.Replace("$$$TextBURL" & i.ToString & "$$$", _Ctrl.Text & "")
                End If
            Next
        Next
        Return vXMLStr
    End Function
    Public Sub InvertReplaceType2(ByVal vLang As String, ByVal vFileIndx As Integer, ByVal vIndx As Integer, ByVal vTagName As String, _
                                  ByVal vTagValue As String, Optional ByVal vCtrl As System.Windows.Forms.Control = Nothing)
        Dim _Ctrl As System.Windows.Forms.Control
        If IsNothing(vCtrl) Then vCtrl = tabMSN3
        For Each _Ctrl In vCtrl.Controls
            InvertReplaceType2(vLang, vFileIndx, vIndx, vTagName, vTagValue, _Ctrl)
            'First XML File - Image Info
            If vTagName = "cp:src" And _Ctrl.Name = ("txtSls_" & vLang & "_Image" & vIndx.ToString) Then
                _Ctrl.Text = vTagValue
            End If
            If vTagName = "cp:alternatetext" And _Ctrl.Name = ("txtSls_" & vLang & "_ImageText" & vIndx.ToString) Then
                _Ctrl.Text = vTagValue
            End If
            If vTagName = "my:ImageUrl" And _Ctrl.Name = ("txtSls_" & vLang & "_ImageURL" & vIndx.ToString) Then
                _Ctrl.Text = vTagValue
            End If
            If vTagName = "cp:abstract" And _Ctrl.Name = ("txtSls_" & vLang & "_TextA" & vIndx.ToString) Then
                _Ctrl.Text = vTagValue
            End If
            If vTagName = "cp:url" And _Ctrl.Name = ("txtSls_" & vLang & "_TextAURL" & vIndx.ToString) And vFileIndx = 1 Then
                _Ctrl.Text = vTagValue
            End If
            'Second XML File - Link Info
            If vTagName = "cp:text" And _Ctrl.Name = ("txtSls_" & vLang & "_TextB" & vIndx.ToString) Then
                _Ctrl.Text = vTagValue
            End If
            If vTagName = "cp:url" And _Ctrl.Name = ("txtSls_" & vLang & "_TextBURL" & vIndx.ToString) And vFileIndx = 2 Then
                _Ctrl.Text = vTagValue
            End If
        Next
    End Sub
    Private Function GetXMLTextType1() As String
        Dim _XMLStr As String
        _XMLStr = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf & _
                  "<?mso-infoPathSolution" & vbCrLf & _
                  "name=""urn:schemas-microsoft-com:office:infopath:GTL_LinkImageAbstract:-myXSD-2005-05-02T19-24-44""  " & vbCrLf & _
                  "href=""manifest.xsf"" solutionVersion=""1.0.1.5"" productVersion=""11.0.6357"" " & vbCrLf & _
                  "PIVersion=""1.0.0.0"" ?> " & vbCrLf & _
                  "<?mso-application progid=""InfoPath.Document""?> <cp:gtl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" " & vbCrLf & _
                  "xmlns:cp=""urn:schemas-microsoft-com/contentpublishing/content"" " & vbCrLf & _
                  "xmlns:ns1=""http://www.w3.org/1999/xhtml"" " & vbCrLf & _
                  "xmlns:my=""urn:schemas-microsoft-com/contentpublishing/imagepreview"" " & vbCrLf & _
                  "xmlns:xd=""http://schemas.microsoft.com/office/infopath/2003""> " & vbCrLf & _
                  "<cp:linkimageabstract>" & vbCrLf & _
                  "    <cp:link>" & vbCrLf & _
                  "      <cp:text>$$$titletext$$$</cp:text> " & vbCrLf & _
                  "      <cp:url>$$$url$$$</cp:url> " & vbCrLf & _
                  "      <cp:format>0</cp:format>  " & vbCrLf & _
                  "    </cp:link>" & vbCrLf & _
                  "    <cp:image>" & vbCrLf & _
                  "      <cp:src>$$$image$$$</cp:src> " & vbCrLf & _
                  "      <cp:width>75</cp:width>" & vbCrLf & _
                  "      <cp:height>75</cp:height> " & vbCrLf & _
                  "      <cp:alternatetext>$$$alternate$$$</cp:alternatetext> " & vbCrLf & _
                  "      <cp:ImageUrl>$$$url$$$</cp:ImageUrl> " & vbCrLf & _
                  "    </cp:image> " & vbCrLf & _
                  "    <cp:abstract>$$$text$$$</cp:abstract> " & vbCrLf & _
                  "  </cp:linkimageabstract> " & vbCrLf & _
                  "</cp:gtl> "
        Return _XMLStr
    End Function
    Private Function GetXMLTextType2_A() As String
        Dim _XMLStr As String
        _XMLStr = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf & _
                  "<?mso-infoPathSolution name=""urn:schemas-microsoft-com:office:infopath:GTL_LinkedImageAbstractList:-myXSD-2005-05-02T19-05-11"" href=""manifest.xsf"" solutionVersion=""1.0.1.5"" productVersion=""11.0.6357"" PIVersion=""1.0.0.0"" ?>" & vbCrLf & _
                  "<?mso-application progid=""InfoPath.Document""?>" & vbCrLf & _
                  "<cp:gtl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:cp=""urn:schemas-microsoft-com/contentpublishing/content"" xmlns:ns1=""http://www.w3.org/1999/xhtml"" xmlns:my=""urn:schemas-microsoft-com/contentpublishing/imagepreview"" xmlns:xd=""http://schemas.microsoft.com/office/infopath/2003"" xml:lang=""zh-cn"">" & vbCrLf & _
                  "  <cp:linkedimageabstractlist>" & vbCrLf & _
                  "    <cp:linkedimageabstract>" & vbCrLf & _
                  "      <cp:linkedimage>" & vbCrLf & _
                  "        <cp:image>" & vbCrLf & _
                  "          <cp:src>$$$Image1$$$</cp:src>" & vbCrLf & _
                  "          <cp:width>45</cp:width>" & vbCrLf & _
                  "          <cp:height>47</cp:height>" & vbCrLf & _
                  "          <cp:alternatetext>$$$ImageText1$$$</cp:alternatetext>" & vbCrLf & _
                  "          <my:ImageUrl>$$$ImageURL1$$$</my:ImageUrl>" & vbCrLf & _
                  "        </cp:image>" & vbCrLf & _
                  "        <cp:url>$$$URL1$$$</cp:url>" & vbCrLf & _
                  "      </cp:linkedimage>" & vbCrLf & _
                  "      <cp:abstract>$$$Text1$$$</cp:abstract>" & vbCrLf & _
                  "    </cp:linkedimageabstract>" & vbCrLf & _
                  "    <cp:linkedimageabstract>" & vbCrLf & _
                  "      <cp:linkedimage>" & vbCrLf & _
                  "        <cp:image>" & vbCrLf & _
                  "          <cp:src>$$$Image2$$$</cp:src>" & vbCrLf & _
                  "          <cp:width>45</cp:width>" & vbCrLf & _
                  "          <cp:height>47</cp:height>" & vbCrLf & _
                  "          <cp:alternatetext>$$$ImageText2$$$</cp:alternatetext>" & vbCrLf & _
                  "          <my:ImageUrl>$$$ImageURL2$$$</my:ImageUrl>" & vbCrLf & _
                  "        </cp:image>" & vbCrLf & _
                  "        <cp:url>$$$URL2$$$</cp:url>" & vbCrLf & _
                  "      </cp:linkedimage>" & vbCrLf & _
                  "      <cp:abstract>$$$Text2$$$</cp:abstract>" & vbCrLf & _
                  "    </cp:linkedimageabstract>" & vbCrLf & _
                  "    <cp:linkedimageabstract>" & vbCrLf & _
                  "      <cp:linkedimage>" & vbCrLf & _
                  "        <cp:image>" & vbCrLf & _
                  "          <cp:src>$$$Image3$$$</cp:src>" & vbCrLf & _
                  "          <cp:width>45</cp:width>" & vbCrLf & _
                  "          <cp:height>47</cp:height>" & vbCrLf & _
                  "          <cp:alternatetext>$$$ImageText3$$$</cp:alternatetext>" & vbCrLf & _
                  "          <my:ImageUrl>$$$ImageURL3$$$</my:ImageUrl>" & vbCrLf & _
                  "        </cp:image>" & vbCrLf & _
                  "        <cp:url>$$$URL3$$$</cp:url>" & vbCrLf & _
                  "      </cp:linkedimage>" & vbCrLf & _
                  "      <cp:abstract>$$$Text3$$$</cp:abstract>" & vbCrLf & _
                  "    </cp:linkedimageabstract>" & vbCrLf & _
                  "    <cp:linkedimageabstract>" & vbCrLf & _
                  "      <cp:linkedimage>" & vbCrLf & _
                  "        <cp:image>" & vbCrLf & _
                  "          <cp:src>$$$Image4$$$</cp:src>" & vbCrLf & _
                  "          <cp:width>45</cp:width>" & vbCrLf & _
                  "          <cp:height>47</cp:height>" & vbCrLf & _
                  "          <cp:alternatetext>$$$ImageText4$$$</cp:alternatetext>" & vbCrLf & _
                  "          <my:ImageUrl>$$$ImageURL4$$$</my:ImageUrl>" & vbCrLf & _
                  "        </cp:image>" & vbCrLf & _
                  "        <cp:url>$$$URL4$$$</cp:url>" & vbCrLf & _
                  "      </cp:linkedimage>" & vbCrLf & _
                  "      <cp:abstract>$$$Text4$$$</cp:abstract>" & vbCrLf & _
                  "    </cp:linkedimageabstract>" & vbCrLf & _
                  "  </cp:linkedimageabstractlist>" & vbCrLf & _
                  "</cp:gtl>"
        Return _XMLStr
    End Function
    Private Function GetXMLTextType2_B() As String
        Dim _XMLStr As String
        _XMLStr = "<?xml version=""1.0"" encoding=""UTF-8""?>" & vbCrLf & _
                  "<?mso-infoPathSolution name=""urn:schemas-microsoft-com:office:infopath:GTL_LinkList:-myXSD-2005-05-02T19-40-03"" href=""manifest.xsf"" solutionVersion=""1.0.1.9"" productVersion=""11.0.6357"" PIVersion=""1.0.0.0"" ?>" & vbCrLf & _
                  "<?mso-application progid=""InfoPath.Document""?>" & vbCrLf & _
                  "<cp:gtl xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:cp=""urn:schemas-microsoft-com/contentpublishing/content"" xmlns:ns1=""http://www.w3.org/1999/xhtml"" xmlns:my=""urn:schemas-microsoft-com/contentpublishing/imagepreview"" xmlns:xd=""http://schemas.microsoft.com/office/infopath/2003"" xml:lang=""zh-cn"">" & vbCrLf & _
                  "  <cp:linklist>" & vbCrLf & _
                  "    <cp:link>" & vbCrLf & _
                  "      <cp:text>$$$TextB1$$$</cp:text>" & vbCrLf & _
                  "      <cp:url>$$$TextBURL1$$$</cp:url>" & vbCrLf & _
                  "      <cp:format>0</cp:format>" & vbCrLf & _
                  "    </cp:link>" & vbCrLf & _
                  "    <cp:link>" & vbCrLf & _
                  "      <cp:text>$$$TextB2$$$</cp:text>" & vbCrLf & _
                  "      <cp:url>$$$TextBURL2$$$</cp:url>" & vbCrLf & _
                  "      <cp:format>0</cp:format>" & vbCrLf & _
                  "    </cp:link>" & vbCrLf & _
                  "    <cp:link>" & vbCrLf & _
                  "      <cp:text>$$$TextB3$$$</cp:text>" & vbCrLf & _
                  "      <cp:url>$$$TextBURL3$$$</cp:url>" & vbCrLf & _
                  "      <cp:format>0</cp:format>" & vbCrLf & _
                  "    </cp:link>" & vbCrLf & _
                  "    <cp:link>" & vbCrLf & _
                  "      <cp:text>$$$TextB4$$$</cp:text>" & vbCrLf & _
                  "      <cp:url>$$$TextBURL4$$$</cp:url>" & vbCrLf & _
                  "      <cp:format>0</cp:format>" & vbCrLf & _
                  "    </cp:link>" & vbCrLf & _
                  "  </cp:linklist>" & vbCrLf & _
                  "</cp:gtl>" & vbCrLf & _
                  ""
        Return _XMLStr
    End Function
    Private Sub btnCreateSlsFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSlsFR.Click
        CreateMSNType2("Sls", "FR")
    End Sub
    Private Sub btnCreateSlsNL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSlsNL.Click
        CreateMSNType2("Sls", "NL")
    End Sub
    Private Sub btnCreateRentFR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateRentFR.Click
        CreateMSNType2("Rent", "FR")
    End Sub
    Private Sub btnCreateRentNL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateRentNL.Click
        CreateMSNType2("Rent", "NL")
    End Sub


    Private Sub txtSls_FR_Image1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_FR_Image1.EditValueChanged
        RefreshImage(txtSls_FR_Image1.EditValue, PictSls1_FR)
    End Sub
    Private Sub txtSls_NL_Image1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_NL_Image1.EditValueChanged
        RefreshImage(txtSls_NL_Image1.EditValue, PictSls1_NL)
    End Sub
    Private Sub txtSls_FR_Image2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_FR_Image2.EditValueChanged
        RefreshImage(txtSls_FR_Image2.EditValue, PictSls2_FR)
    End Sub
    Private Sub txtSls_NL_Image2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_NL_Image2.EditValueChanged
        RefreshImage(txtSls_NL_Image2.EditValue, PictSls2_NL)
    End Sub
    Private Sub txtSls_FR_Image3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_FR_Image3.EditValueChanged
        RefreshImage(txtSls_FR_Image3.EditValue, PictSls3_FR)
    End Sub
    Private Sub txtSls_NL_Image3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_NL_Image3.EditValueChanged
        RefreshImage(txtSls_NL_Image3.EditValue, PictSls3_NL)
    End Sub
    Private Sub txtSls_FR_Image4_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_FR_Image4.EditValueChanged
        RefreshImage(txtSls_FR_Image4.EditValue, PictSls4_FR)
    End Sub
    Private Sub txtSls_NL_Image4_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSls_NL_Image4.EditValueChanged
        RefreshImage(txtSls_NL_Image4.EditValue, PictSls4_NL)
    End Sub
End Class
