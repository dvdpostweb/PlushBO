Imports System.Web.Mail
Public Class frmEMail_IN_OUT
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
    Friend WithEvents btnSendIN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents grpIN As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpOUT As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSendOUT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIN_Count As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIN_Norm_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIN_Adult_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOUT_Count As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOUT_Norm_Multi_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOUT_Norm_Single_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOUT_Adult_Multi_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOUT_Adult_Single_ID As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSendIN = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.grpIN = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtIN_Adult_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtIN_Norm_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtIN_Count = New DevExpress.XtraEditors.TextEdit
        Me.grpOUT = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtOUT_Adult_Multi_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtOUT_Norm_Multi_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtOUT_Count = New DevExpress.XtraEditors.TextEdit
        Me.btnSendOUT = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtOUT_Norm_Single_ID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtOUT_Adult_Single_ID = New DevExpress.XtraEditors.TextEdit
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpIN.SuspendLayout()
        CType(Me.txtIN_Adult_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIN_Norm_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIN_Count.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOUT.SuspendLayout()
        CType(Me.txtOUT_Adult_Multi_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOUT_Norm_Multi_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOUT_Count.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOUT_Norm_Single_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOUT_Adult_Single_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'btnSendIN
        '
        Me.btnSendIN.Location = New System.Drawing.Point(8, 160)
        Me.btnSendIN.Name = "btnSendIN"
        Me.btnSendIN.TabIndex = 4
        Me.btnSendIN.Text = "SEND"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(24, 248)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(472, 18)
        Me.ProgressBarControl1.TabIndex = 6
        '
        'grpIN
        '
        Me.grpIN.Controls.Add(Me.LabelControl3)
        Me.grpIN.Controls.Add(Me.txtIN_Adult_ID)
        Me.grpIN.Controls.Add(Me.LabelControl2)
        Me.grpIN.Controls.Add(Me.txtIN_Norm_ID)
        Me.grpIN.Controls.Add(Me.LabelControl1)
        Me.grpIN.Controls.Add(Me.txtIN_Count)
        Me.grpIN.Controls.Add(Me.btnSendIN)
        Me.grpIN.Location = New System.Drawing.Point(24, 40)
        Me.grpIN.Name = "grpIN"
        Me.grpIN.Size = New System.Drawing.Size(232, 192)
        Me.grpIN.TabIndex = 7
        Me.grpIN.Text = "E-Mails Process IN"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "EMail Adult ID"
        '
        'txtIN_Adult_ID
        '
        Me.txtIN_Adult_ID.EditValue = "2"
        Me.txtIN_Adult_ID.Location = New System.Drawing.Point(104, 72)
        Me.txtIN_Adult_ID.Name = "txtIN_Adult_ID"
        Me.txtIN_Adult_ID.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "EMail NORM ID"
        '
        'txtIN_Norm_ID
        '
        Me.txtIN_Norm_ID.EditValue = "99"
        Me.txtIN_Norm_ID.Location = New System.Drawing.Point(104, 48)
        Me.txtIN_Norm_ID.Name = "txtIN_Norm_ID"
        Me.txtIN_Norm_ID.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "To Send"
        '
        'txtIN_Count
        '
        Me.txtIN_Count.Location = New System.Drawing.Point(104, 24)
        Me.txtIN_Count.Name = "txtIN_Count"
        Me.txtIN_Count.TabIndex = 5
        '
        'grpOUT
        '
        Me.grpOUT.Controls.Add(Me.LabelControl8)
        Me.grpOUT.Controls.Add(Me.txtOUT_Adult_Single_ID)
        Me.grpOUT.Controls.Add(Me.LabelControl7)
        Me.grpOUT.Controls.Add(Me.txtOUT_Norm_Single_ID)
        Me.grpOUT.Controls.Add(Me.LabelControl4)
        Me.grpOUT.Controls.Add(Me.txtOUT_Adult_Multi_ID)
        Me.grpOUT.Controls.Add(Me.LabelControl5)
        Me.grpOUT.Controls.Add(Me.txtOUT_Norm_Multi_ID)
        Me.grpOUT.Controls.Add(Me.LabelControl6)
        Me.grpOUT.Controls.Add(Me.txtOUT_Count)
        Me.grpOUT.Controls.Add(Me.btnSendOUT)
        Me.grpOUT.Location = New System.Drawing.Point(264, 40)
        Me.grpOUT.Name = "grpOUT"
        Me.grpOUT.Size = New System.Drawing.Size(256, 192)
        Me.grpOUT.TabIndex = 8
        Me.grpOUT.Text = "E-Mails Process OUT"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 104)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "EMail Adult Multi ID"
        '
        'txtOUT_Adult_Multi_ID
        '
        Me.txtOUT_Adult_Multi_ID.EditValue = "3"
        Me.txtOUT_Adult_Multi_ID.Location = New System.Drawing.Point(144, 96)
        Me.txtOUT_Adult_Multi_ID.Name = "txtOUT_Adult_Multi_ID"
        Me.txtOUT_Adult_Multi_ID.TabIndex = 15
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 56)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(120, 14)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "EMail NORM Multi ID"
        '
        'txtOUT_Norm_Multi_ID
        '
        Me.txtOUT_Norm_Multi_ID.EditValue = "100"
        Me.txtOUT_Norm_Multi_ID.Location = New System.Drawing.Point(144, 48)
        Me.txtOUT_Norm_Multi_ID.Name = "txtOUT_Norm_Multi_ID"
        Me.txtOUT_Norm_Multi_ID.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "To Send"
        '
        'txtOUT_Count
        '
        Me.txtOUT_Count.Location = New System.Drawing.Point(144, 24)
        Me.txtOUT_Count.Name = "txtOUT_Count"
        Me.txtOUT_Count.TabIndex = 11
        '
        'btnSendOUT
        '
        Me.btnSendOUT.Location = New System.Drawing.Point(8, 160)
        Me.btnSendOUT.Name = "btnSendOUT"
        Me.btnSendOUT.TabIndex = 4
        Me.btnSendOUT.Text = "SEND"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 80)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(120, 14)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "EMail NORM Single ID"
        '
        'txtOUT_Norm_Single_ID
        '
        Me.txtOUT_Norm_Single_ID.EditValue = "101"
        Me.txtOUT_Norm_Single_ID.Location = New System.Drawing.Point(144, 72)
        Me.txtOUT_Norm_Single_ID.Name = "txtOUT_Norm_Single_ID"
        Me.txtOUT_Norm_Single_ID.TabIndex = 17
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 128)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(104, 14)
        Me.LabelControl8.TabIndex = 20
        Me.LabelControl8.Text = "EMail Adult Single ID"
        '
        'txtOUT_Adult_Single_ID
        '
        Me.txtOUT_Adult_Single_ID.EditValue = "3"
        Me.txtOUT_Adult_Single_ID.Location = New System.Drawing.Point(144, 120)
        Me.txtOUT_Adult_Single_ID.Name = "txtOUT_Adult_Single_ID"
        Me.txtOUT_Adult_Single_ID.TabIndex = 19
        '
        'frmEMail_IN_OUT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 382)
        Me.Controls.Add(Me.grpOUT)
        Me.Controls.Add(Me.grpIN)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Name = "frmEMail_IN_OUT"
        Me.Controls.SetChildIndex(Me.ProgressBarControl1, 0)
        Me.Controls.SetChildIndex(Me.grpIN, 0)
        Me.Controls.SetChildIndex(Me.grpOUT, 0)
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpIN.ResumeLayout(False)
        CType(Me.txtIN_Adult_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIN_Norm_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIN_Count.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpOUT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOUT.ResumeLayout(False)
        CType(Me.txtOUT_Adult_Multi_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOUT_Norm_Multi_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOUT_Count.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOUT_Norm_Single_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOUT_Adult_Single_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim objDS As New dsCustomers
    Dim mvarsmtpserver As String = "" '"192.168.0.203"
    Dim mvarsite As String = "" '"www.dvdpost.be"
    Dim _view As DataView
    Dim lowerbound As Integer
    Dim upperbound As Integer

    Private Sub frmEMail_IN_OUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Count_How_Many_To_Send()
        mvarsmtpserver = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'SMTPServer'")
        mvarsite = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM GeneralGlobalParameter WHERE SetUpCategory = 'Global' and Name = 'BESite'")
        Dim sSQL3 As String = " select p.products_id , count(pd.products_id) as cnt_dvd , pdesc_fr.products_image_big as image_fr, pdesc_nl.products_image_big as image_nl, " & _
                " pdesc_en.products_image_big as image_en from products p " & _
                " left join products_dvd pd on pd.products_id = p.products_id " & _
                " left join products_description pdesc_fr on pdesc_fr.products_id = p.products_id and pdesc_fr.language_id = 1 " & _
                " left join products_description pdesc_nl on pdesc_nl.products_id = p.products_id and pdesc_nl.language_id = 2 " & _
                " left join products_description pdesc_en on pdesc_en.products_id = p.products_id and pdesc_en.language_id = 3 " & _
                " WHERE pd.products_dvd_status = 1 group by pd.products_id "
        BKGlobal.Cls1.FillDataSet(objDS.Tables("prod_instock_image_view1"), sSQL3)
        _view = New DataView(objDS.Tables("prod_instock_image_view1"), "cnt_dvd >= 5", "", DataViewRowState.CurrentRows)
        lowerbound = 0
        upperbound = _view.Count - 1

    End Sub
    Private Sub Count_How_Many_To_Send()
        Dim _SQLTXt As String = "select count(*) as Count1 from orders_status_history  where new_value = 3 and customer_notified= 0"
        txtIN_Count.EditValue = BKGlobal.ExecuteCount(_SQLTXt)

        _SQLTXt = " select count(*) as Count1 from orders_status_history  where new_value = 2 and customer_notified= 0"
        txtOUT_Count.EditValue = BKGlobal.ExecuteCount(_SQLTXt)

    End Sub
    Private Sub btnSendIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendIN.Click
        SendMail("In")
    End Sub
    Private Sub btnSendOUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOUT.Click
        SendMail("Out")
    End Sub

    Private Sub SendMail(ByVal vInOut As String)
        'vInOut  can be In or Out
        Dim sSQL, sSQL1, sSQL2, sSQL3, sSQL4 As String
        Dim _order_status_row, _MailRow As DataRow
        Dim intorders_id, intcustomers_id, intproducts_id As Integer
        Dim strcustomers_name, strcustomers_email_address, strproducts_name, intcustomers_language As String
        Dim intmessages_id As Integer
        Dim strFrom As String = "dvdpost@dvdpost.be"
        Dim strTo As String
        Dim strSubject As String = ""
        Dim strMessage As String = ""
        Dim _IsAdult As Boolean = False
        Dim _IsMulti As Boolean = False
        Dim _i, _j As Integer

        objDS.Tables("orders_status_history").Clear()
        If vInOut = "In" Then
            sSQL = "select * from orders_status_history  where new_value = 3 and customer_notified= 0"
        Else
            sSQL = "select * from orders_status_history  where new_value = 2 and customer_notified= 0"
        End If

        BKGlobal.Cls1.FillDataSet(objDS.Tables("orders_status_history"), sSQL)
        ProgressBarControl1.Properties.Maximum = objDS.Tables("orders_status_history").Rows.Count
        ProgressBarControl1.Properties.Minimum = 0
        ProgressBarControl1.EditValue = 0


        For Each _order_status_row In objDS.Tables("orders_status_history").Rows
            ProgressBarControl1.EditValue += 1
            ProgressBarControl1.Refresh()
            intorders_id = _order_status_row.Item("orders_id")
            'orders
            objDS.Tables("orders").Clear()
            sSQL1 = "select * from orders where orders_id = '" & intorders_id & "'"
            BKGlobal.Cls1.FillDataSet(objDS.Tables("orders"), sSQL1)
            If objDS.Tables("orders").Rows.Count = 1 Then
                intcustomers_id = objDS.Tables("orders").Rows(0).Item("customers_id")
                strcustomers_name = objDS.Tables("orders").Rows(0).Item("customers_name")
                strcustomers_email_address = objDS.Tables("orders").Rows(0).Item("customers_email_address")
                If objDS.Tables("orders").Rows(0).Item("multishipment_sm") = "m" Then
                    _IsMulti = True
                Else
                    _IsMulti = False
                End If
                objDS.Tables("orders_products").Clear()
                'Orders_Products
                sSQL2 = "select * from orders_products where orders_id= '" & intorders_id & "' "
                BKGlobal.Cls1.FillDataSet(objDS.Tables("orders_products"), sSQL2)
                strproducts_name = ""
                If objDS.Tables("orders_products").Rows.Count = 1 Then
                    strproducts_name = objDS.Tables("orders_products").Rows(0).Item("products_name")
                    intproducts_id = objDS.Tables("orders_products").Rows(0).Item("products_id")
                    'Customers_Info - To get Language
                    objDS.Tables("customers_info").Clear()
                    sSQL3 = "select * from customers_info where customers_info_id = '" & intcustomers_id & "'"
                    BKGlobal.Cls1.FillDataSet(objDS.Tables("customers_info"), sSQL3)
                    If objDS.Tables("customers_info").Rows.Count = 1 Then
                        intcustomers_language = objDS.Tables("customers_info").Rows(0).Item("customers_language")
                        If G_ADULT_IS_SPLIT = True Then
                            If intproducts_id < 9999 Then
                                _IsAdult = False
                            Else
                                _IsAdult = True
                            End If
                        Else
                            If objDS.Tables("products").Rows.Count = 1 Then
                                If objDS.Tables("products").Rows(0).Item("products_type") <> "DVD-ADULT" Then
                                    _IsAdult = False
                                Else
                                    _IsAdult = True
                                End If
                            End If
                        End If
                        If _IsAdult Then
                            If vInOut = "In" Then
                                intmessages_id = CInt(txtIN_Adult_ID.EditValue)
                            Else
                                If _IsMulti Then
                                    intmessages_id = CInt(txtOUT_Adult_Multi_ID.EditValue)
                                Else
                                    intmessages_id = CInt(txtOUT_Adult_Single_ID.EditValue)
                                End If

                            End If
                        Else
                            If vInOut = "In" Then
                                intmessages_id = CInt(txtIN_Norm_ID.EditValue)
                            Else
                                If _IsMulti Then
                                    intmessages_id = CInt(txtOUT_Norm_Multi_ID.EditValue)
                                Else
                                    intmessages_id = CInt(txtOUT_Norm_Single_ID.EditValue)
                                End If
                            End If

                        End If
                        objDS.Tables("mail_messages").Clear()
                        sSQL2 = "SELECT * FROM mail_messages WHERE mail_messages_id = '" & intmessages_id & "' and language_id = '" & intcustomers_language & "'"
                        BKGlobal.Cls1.FillDataSet(objDS.Tables("mail_messages"), sSQL2)
                        For Each _MailRow In objDS.Tables("mail_messages").Rows
                            strTo = strcustomers_email_address
                            strSubject = _MailRow.Item("messages_subject")
                            strMessage = _MailRow.Item("messages_html")
                            'titre
                            strMessage = Replace(strMessage, "$$$title$$$", _MailRow.Item("messages_title"))
                            'customers_name
                            strMessage = Replace(strMessage, "$$$customers_name$$$", strcustomers_name)
                            'products_name
                            strMessage = Replace(strMessage, "$$$products_name$$$", strproducts_name)
                            'site
                            strMessage = Replace(strMessage, "$$$site$$$", "<a href='" & mvarsite & " '>" & mvarsite & "</a>")
                            'today
                            strMessage = Replace(strMessage, "$$$today$$$", Today())
                            If Not _IsAdult Then
                                sSQL3 = "select * from products_description where products_id = '" & intproducts_id & "' AND language_id = '" & _
                                       intcustomers_language & "' "
                                BKGlobal.Cls1.FillDataSet(objDS.Tables("products_description"), sSQL3)
                                If objDS.Tables("products_description").Rows.Count = 1 Then
                                    strMessage = Replace(strMessage, "$$$products_image$$$", objDS.Tables("products_description").Rows(0).Item("products_image_big"))
                                End If
                                sSQL3 = "select * from products where products_id = '" & intproducts_id & "'"
                                BKGlobal.Cls1.FillDataSet(objDS.Tables("products"), sSQL3)
                                If objDS.Tables("products").Rows.Count = 1 Then
                                    strMessage = Replace(strMessage, "$$$products_id$$$", intproducts_id)
                                    strMessage = Replace(strMessage, "$$$products_rating$$$", objDS.Tables("products").Rows(0).Item("products_rating"))
                                    strMessage = Replace(strMessage, "$$$directors_id$$$", objDS.Tables("products").Rows(0).Item("products_directors_id"))
                                    'Search Director Name
                                    sSQL3 = "select * from directors where directors_id = '" & objDS.Tables("products").Rows(0).Item("products_directors_id") & "'"
                                    BKGlobal.Cls1.FillDataSet(objDS.Tables("directors"), sSQL3)
                                    If objDS.Tables("directors").Rows.Count = 1 Then
                                        strMessage = Replace(strMessage, "$$$directors$$$", objDS.Tables("directors").Rows(0).Item("directors_name"))
                                    Else
                                        strMessage = Replace(strMessage, "$$$directors$$$", "")
                                    End If
                                    'Search Actors
                                    sSQL3 = "select p2a.products_id, p2a.actors_id, a.actors_name from products_to_actors p2a  left join actors a on a.actors_id = p2a.actors_id WHERE p2a.products_id = '" & intproducts_id & "'"
                                    BKGlobal.Cls1.FillDataSet(objDS.Tables("products_actors_view1"), sSQL3)
                                    Dim _actor_row As DataRow
                                    _i = 1
                                    For Each _actor_row In objDS.Tables("products_actors_view1").Rows
                                        strMessage = Replace(strMessage, "$$$actor" & _i & "_id$$$", _actor_row.Item("actors_id"))
                                        strMessage = Replace(strMessage, "$$$actor" & _i & "$$$", _actor_row.Item("actors_name"))
                                        _i += 1
                                        If _i = 4 Then Exit For
                                    Next
                                    Randomize()
                                    For _i = 1 To 7
                                        _j = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
                                        strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_id$$$", _view(_j).Item("products_id"))
                                        Select Case intcustomers_language
                                            Case 1 'FR
                                                strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", _view(_j).Item("image_fr"))
                                            Case 2 'NL
                                                strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", _view(_j).Item("image_nl"))
                                            Case 3 'EN
                                                strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", _view(_j).Item("image_en"))
                                        End Select

                                    Next

                                Else 'Products Not Fount
                                    strMessage = Replace(strMessage, "$$$products_rating$$$", "0")
                                    strMessage = Replace(strMessage, "$$$directors_id$$$", "0")
                                    strMessage = Replace(strMessage, "$$$actor1_id$$$", "")
                                    strMessage = Replace(strMessage, "$$$actor1$$$", "")
                                    strMessage = Replace(strMessage, "$$$actor2_id$$$", "")
                                    strMessage = Replace(strMessage, "$$$actor2$$$", "")
                                    strMessage = Replace(strMessage, "$$$actor2_id$$$", "")
                                    strMessage = Replace(strMessage, "$$$actor2$$$", "")
                                    For _i = 1 To 7
                                        strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_id$$$", "")
                                        strMessage = Replace(strMessage, "$$$dvd" & _i & "_products_image$$$", "")
                                    Next

                                End If
                            End If
                            'Sending the Mail
                            Dim mymail As New MailMessage
                            mymail.From = strFrom
                            mymail.To = strTo
                            mymail.Subject = strSubject
                            mymail.Body = strMessage
                            mymail.BodyFormat = MailFormat.Html
                            mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
                            mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "Administrator")
                            mymail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "DVD7(post")
                            SmtpMail.SmtpServer = mvarsmtpserver
                            Try
                                SmtpMail.Send(mymail)
                            Catch ex As Exception
                                ex.Message.ToString()
                            End Try
                            'update status mail sended
                            If vInOut = "In" Then
                                'sSQL4 = "update orders_status_history set customer_notified  = 1 where orders_id = '" & intorders_id & "'  "
                                sSQL4 = "update orders_status_history set customer_notified  = 1 where orders_id = '" & intorders_id & "' and new_value = 3 "
                            Else
                                sSQL4 = "update orders_status_history set customer_notified  = 1 where orders_id = '" & intorders_id & "' and new_value = 2 "
                            End If
                            BKGlobal.Cls1.ExecuteNonQuery(sSQL4)

                        Next
                    End If 'Language Exist
                End If 'orders_products exist
            End If 'orders exist
        Next
        Count_How_Many_To_Send()
        ProgressBarControl1.EditValue = 0
        MsgBox("Process Complete", MsgBoxStyle.Information)
    End Sub

    Private Sub ProgressBarControl1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarControl1.EditValueChanged

    End Sub
End Class
