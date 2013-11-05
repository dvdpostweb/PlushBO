Public Class frmStockUtility
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
    Friend WithEvents btnReCalcQtyNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.btnReCalcQtyNow = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Filter_Bar
        '
        Me.Filter_Bar.DockCol = 7
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.DockCol = 8
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.DockCol = 6
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.DockCol = 3
        '
        'Main_Bar
        '
        Me.Main_Bar.DockCol = 4
        '
        'Misc_Bar
        '
        Me.Misc_Bar.DockCol = 5
        '
        'View_Bar
        '
        Me.View_Bar.DockCol = 2
        '
        'btnReCalcQtyNow
        '
        Me.btnReCalcQtyNow.Location = New System.Drawing.Point(32, 40)
        Me.btnReCalcQtyNow.Name = "btnReCalcQtyNow"
        Me.btnReCalcQtyNow.Size = New System.Drawing.Size(200, 23)
        SuperToolTip1.FixedTooltipWidth = False
        ToolTipTitleItem1.Text = "Re-Calc Products Qty Now"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "For Each Product" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Count How Many DVD (products_dvd) with " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             Statu" & _
        "s = 1 (OK) " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             and " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "             InOut = 1 (In stock)." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "    Place th" & _
        "e Result in products.products_quantity"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnReCalcQtyNow.SuperTip = SuperToolTip1
        Me.btnReCalcQtyNow.TabIndex = 4
        Me.btnReCalcQtyNow.Text = "Re-Calc Products Qty NOW"
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
        'frmStockUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 266)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.btnReCalcQtyNow)
        Me.Name = "frmStockUtility"
        Me.Controls.SetChildIndex(Me.btnReCalcQtyNow, 0)
        Me.Controls.SetChildIndex(Me.ProgressBarControl1, 0)
        Me.Controls.SetChildIndex(Me.SpinEdit1, 0)
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCalcQtyNow.Click
        Dim _DS As New DataSet
        _DS.Tables.Add("products")
        Dim _PSQLTxt As String = "SELECT products_id, products_quantity, products_dvd_quantity FROM products WHERE products_type <> 'ABO' "
        BKGlobal.Cls1.FillDataSet(_DS.Tables("products"), _PSQLTxt)
        ProgressBarControl1.Visible = True
        ProgressBarControl1.Properties.Minimum = 1
        ProgressBarControl1.Properties.Maximum = _DS.Tables("products").Rows.Count
        ProgressBarControl1.EditValue = 1
        SpinEdit1.Value = 0
        SpinEdit1.Visible = True
        Dim _i As Integer = 1
        Dim _row As DataRow
        Dim _SQLTxt As String = ""
        Dim _NewQtyNow As Integer
        Dim _CorrInt As Integer = 0
        For Each _row In _DS.Tables("products").Rows
            _i += 1
            ProgressBarControl1.EditValue += 1
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & _row.Item("products_id") & _
             " AND products_dvd_status = 1 and inout = 1 "
            _NewQtyNow = BKGlobal.ExecuteCount(_SQLTxt)
            If _row.Item("products_quantity") <> _NewQtyNow Then
                _CorrInt += 1
                SpinEdit1.Value += 1
            End If
            _row.BeginEdit()
            _row.Item("products_quantity") = _NewQtyNow
            _row.EndEdit()
            If _i Mod 100 Then
                BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
                ProgressBarControl1.Refresh()
                SpinEdit1.Refresh()
            End If
        Next
        BKGlobal.Cls1.UpdateDataSource(_DS.Tables("products"), _PSQLTxt)
        MsgBox("Done, Corrected : " & _CorrInt.ToString & " Products.", MsgBoxStyle.Information)
        ProgressBarControl1.Visible = False
        SpinEdit1.Visible = False
    End Sub
End Class
