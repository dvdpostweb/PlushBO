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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
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
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(32, 224)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Size = New System.Drawing.Size(976, 18)
        Me.ProgressBarControl1.TabIndex = 5
        Me.ProgressBarControl1.Visible = False
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(32, 200)
        Me.SpinEdit1.Name = "SpinEdit1"
        '
        'SpinEdit1.Properties
        '
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.TabIndex = 6
        Me.SpinEdit1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(32, 40)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(200, 23)
        SuperToolTip1.FixedTooltipWidth = False
        ToolTipTitleItem1.Text = "Re-Calc Products Qty Now"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "For Each Product" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
        "s = 1 (OK) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             and " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
        "e Result in products.products_quantity"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.SimpleButton1.SuperTip = SuperToolTip1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Recalc DVD @ Home"
        '
        'frmCustUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 266)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Name = "frmCustUtility"
        Me.Controls.SetChildIndex(Me.ProgressBarControl1, 0)
        Me.Controls.SetChildIndex(Me.SpinEdit1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        BKGlobal.Cls1.FillDataSet(_ds.Tables("cust"), _SQLTxt)
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
                      " WHERE o.customers_id = " & _custRow.Item("customers_id") & " and o.orders_status <= 2 "
            _ds.Tables("orders").Clear()
            BKGlobal.Cls1.FillDataSet(_ds.Tables("orders"), _SQLTxt)
            _ViewNorm = New DataView(_ds.Tables("orders"), "orders_products_type = 'DVD_NORM'", "", DataViewRowState.CurrentRows)
            _ViewAdult = New DataView(_ds.Tables("orders"), "orders_products_type = 'DVD_ADULT'", "", DataViewRowState.CurrentRows)
            'MsgBox(_custRow.Item("customers_abo_dvd_home_norm") & " " & _custRow.Item("customers_abo_dvd_home_adult") & _
            '      _ViewNorm.Count & " " & _ViewAdult.Count)
            If _custRow.Item("customers_abo_dvd_home_norm") <> _ViewNorm.Count Then
                _SQLTxt = " UPDATE customers SET customers_abo_dvd_home_norm = " & _ViewNorm.Count & " WHERE customers_id = " & _custRow.Item("customers_id")
                BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)
                _intCorrNorm += 1
            End If
            If _custRow.Item("customers_abo_dvd_home_adult") <> _ViewAdult.Count Then
                _SQLTxt = " UPDATE customers SET customers_abo_dvd_home_adult = " & _ViewAdult.Count & " WHERE customers_id = " & _custRow.Item("customers_id")
                BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)
                _intCorrAdult += 1
            End If
            SpinEdit1.Refresh()
            ProgressBarControl1.Refresh()
        Next
        MsgBox("Done - Corr Norm = " & _intCorrNorm & " - Corr Adult = " & _intCorrAdult, MsgBoxStyle.Information)
        ProgressBarControl1.Visible = False
        SpinEdit1.Visible = False
    End Sub
End Class
