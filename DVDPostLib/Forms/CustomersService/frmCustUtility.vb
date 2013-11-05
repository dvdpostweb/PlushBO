Imports System.Windows.Forms.Application
Public Class frmCustUtility
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
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCust_20_To_31 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnStep20_2_31 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.btnStep20_2_31 = New DevExpress.XtraEditors.SimpleButton
        Me.txtCust_20_To_31 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txtCust_20_To_31.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(16, 67)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.ProgressBarControl1.Size = New System.Drawing.Size(976, 18)
        Me.ProgressBarControl1.TabIndex = 5
        Me.ProgressBarControl1.Visible = False
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(16, 43)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Size = New System.Drawing.Size(100, 20)
        Me.SpinEdit1.TabIndex = 6
        Me.SpinEdit1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(16, 14)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(200, 23)
        ToolTipTitleItem1.Text = "Re-Calc Products Qty Now"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "For Each Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
            "s = 1 (OK) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
            "e Result in products.products_quantity"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.SimpleButton1.SuperTip = SuperToolTip1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Recalc DVD @ Home"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 30)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1040, 236)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        Me.XtraTabControl1.Text = "XtraTabControl1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage1.Controls.Add(Me.SpinEdit1)
        Me.XtraTabPage1.Controls.Add(Me.ProgressBarControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1031, 205)
        Me.XtraTabPage1.Text = "Re-Calc DVD@Home"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage2.Controls.Add(Me.txtCust_20_To_31)
        Me.XtraTabPage2.Controls.Add(Me.btnStep20_2_31)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1031, 205)
        Me.XtraTabPage2.Text = "Move Step 20 to Step 31"
        '
        'btnStep20_2_31
        '
        Me.btnStep20_2_31.Location = New System.Drawing.Point(30, 15)
        Me.btnStep20_2_31.Name = "btnStep20_2_31"
        Me.btnStep20_2_31.Size = New System.Drawing.Size(75, 23)
        Me.btnStep20_2_31.TabIndex = 0
        Me.btnStep20_2_31.Text = "GO"
        '
        'txtCust_20_To_31
        '
        Me.txtCust_20_To_31.Location = New System.Drawing.Point(137, 45)
        Me.txtCust_20_To_31.Name = "txtCust_20_To_31"
        Me.txtCust_20_To_31.Size = New System.Drawing.Size(100, 20)
        Me.txtCust_20_To_31.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Nbr of Customers"
        '
        'frmCustUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 266)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frmCustUtility"
        Me.Controls.SetChildIndex(Me.XtraTabControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txtCust_20_To_31.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim _ds As New DataSet
        _ds.Tables.Add("cust")
        _ds.Tables.Add("orders")
        Dim _SQLTxt As String
        Dim _custRow As DataRow
        Dim _ViewNorm As DataView
        Dim _ViewAdult As DataView
        Dim _intCorrNorm, _intCorrAdult As Integer
        _intCorrNorm = 0
        _intCorrAdult = 0
        _SQLTxt = "SELECT customers_id, customers_abo_dvd_home_norm, customers_abo_dvd_home_adult from customers " & _
                  " where customers_abo = 1 "
        DvdPostData.clsConnection.FillDataSet(_ds.Tables("cust"), _SQLTxt)
        ProgressBarControl1.Visible = True
        ProgressBarControl1.Properties.Minimum = 1
        ProgressBarControl1.Properties.Maximum = _ds.Tables("cust").Rows.Count
        ProgressBarControl1.EditValue = 1
        SpinEdit1.Value = _ds.Tables("cust").Rows.Count
        SpinEdit1.Visible = True
        For Each _custRow In _ds.Tables("cust").Rows
            ProgressBarControl1.EditValue += 1
            SpinEdit1.EditValue -= 1
            _SQLTxt = " SELECT o.orders_id, o.customers_id, op.products_id, op.orders_products_type " & _
                      " FROM orders o left join orders_products op on op.orders_id = o.orders_id " & _
                      " WHERE o.customers_id = " & _custRow("customers_id") & " and o.orders_status <= 2 "
            _ds.Tables("orders").Clear()
            DvdPostData.clsConnection.FillDataSet(_ds.Tables("orders"), _SQLTxt)
            _ViewNorm = New DataView(_ds.Tables("orders"), "orders_products_type = 'DVD_NORM'", "", DataViewRowState.CurrentRows)
            _ViewAdult = New DataView(_ds.Tables("orders"), "orders_products_type = 'DVD_ADULT'", "", DataViewRowState.CurrentRows)
            'MsgBox(_custRow("customers_abo_dvd_home_norm") & " " & _custRow("customers_abo_dvd_home_adult") & _
            '      _ViewNorm.Count & " " & _ViewAdult.Count)
            If _custRow("customers_abo_dvd_home_norm") <> _ViewNorm.Count Then
                _SQLTxt = " UPDATE customers SET customers_abo_dvd_home_norm = " & _ViewNorm.Count & " WHERE customers_id = " & _custRow("customers_id")
                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
                _intCorrNorm += 1
            End If
            If _custRow("customers_abo_dvd_home_adult") <> _ViewAdult.Count Then
                _SQLTxt = " UPDATE customers SET customers_abo_dvd_home_adult = " & _ViewAdult.Count & " WHERE customers_id = " & _custRow("customers_id")
                DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
                _intCorrAdult += 1
            End If
            SpinEdit1.Refresh()
            ProgressBarControl1.Refresh()
        Next
        MsgBox("Done - Corr Norm = " & _intCorrNorm & " - Corr Adult = " & _intCorrAdult, MsgBoxStyle.Information)
        ProgressBarControl1.Visible = False
        SpinEdit1.Visible = False
    End Sub

    Private Sub btnStep20_2_31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep20_2_31.Click
        Dim _ds As New DataSet
        Dim _row As DataRow
        Dim _totCust As Integer
        _ds.Tables.Add("customers")
        _ds.Tables.Add("address_book")

        Dim _SQLTxt As String = "SELECT * FROM customers where customers_registration_step = 20"
        DvdPostData.clsConnection.FillDataSet(_ds.Tables("customers"), _SQLTxt)
        _totCust = _ds.Tables("customers").Rows.Count
        txtCust_20_To_31.EditValue = _totCust.ToString
        For Each _row In _ds.Tables("customers").Rows
            _totCust -= 1
            _SQLTxt = "UPDATE customers set activation_discount_code_type = 'D', " & _
                              "activation_discount_code_id = 495, " & _
                              "customers_registration_step = 31, " & _
                              "customers_default_address_id = 1, " & _
                              "customers_abo_type = 18, " & _
                              "customers_next_abo_type = 18 " & _
                              "WHERE customers_id = " & _row("customers_id")
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            _SQLTxt = "INSERT INTO address_book (customers_id, address_book_id) values (" & _row("customers_id") & ", 1)"
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            txtCust_20_To_31.EditValue = _totCust.ToString
            txtCust_20_To_31.Refresh()
            DoEvents()
        Next
    End Sub
End Class
