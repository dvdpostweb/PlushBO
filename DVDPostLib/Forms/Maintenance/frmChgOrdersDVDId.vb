Public Class frmChgOrdersDVDId
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrderID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDVDId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtOrderID = New DevExpress.XtraEditors.TextEdit
        Me.txtDVDId = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveOrder = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(104, 42)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.TabIndex = 0
        '
        'txtDVDId
        '
        Me.txtDVDId.Location = New System.Drawing.Point(104, 88)
        Me.txtDVDId.Name = "txtDVDId"
        Me.txtDVDId.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 96)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "DVD ID"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(104, 64)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Product ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(216, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(216, 88)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.TabIndex = 3
        Me.btnSaveOrder.Text = "Save"
        '
        'frmChgOrdersDVDId
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1040, 266)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtDVDId)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frmChgOrdersDVDId"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.txtOrderID, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.txtDVDId, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.txtProductID, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnSaveOrder, 0)
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Dim _PreviousDVDID As Integer
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If Not IsNumeric(txtOrderID.EditValue) Then
            MsgBox("Order ID must be a number, please re-enter", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim _sqlTxt As String = "select orders_id, products_id, products_dvd from orders_products where " & _
                            " orders_id = " & txtOrderID.EditValue
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        BKGlobal.Cls1.FillDataSet(_DS.Tables("TmpTable"), _sqlTxt)
        If _DS.Tables("TmpTable").Rows.Count = 1 Then
            txtDVDId.EditValue = _DS.Tables("TmpTable").Rows(0).Item("products_dvd")
            txtProductID.EditValue = _DS.Tables("TmpTable").Rows(0).Item("products_id")
            _PreviousDVDID = txtDVDId.EditValue
        Else
            txtDVDId.EditValue = ""
            txtProductID.EditValue = "Orders Not Found "
        End If

    End Sub

    Private Sub btnSaveOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOrder.Click
        If Not IsNumeric(txtDVDId.EditValue) Then
            MsgBox("DVD ID must be a number, please re-enter", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim _SQLTxt As String = "UPDATE orders_products set products_dvd = " & txtDVDId.EditValue & " WHERE orders_id = " & txtOrderID.EditValue
        Dim _Nbr As Integer
        _Nbr = BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)
        If _Nbr <> 1 Then
            MsgBox("Something went wrong during the save.", MsgBoxStyle.Critical)
        End If
        _SQLTxt = "update products_dvd pd set  inout = 1 WHERE pd.products__id = " & txtProductID.EditValue & " AND products_dvdid = " & txtDVDId.EditValue
        BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)
        _SQLTxt = "update products_dvd pd set  inout = 2 WHERE pd.products__id = " & txtProductID.EditValue & " AND products_dvdid = " & _PreviousDVDID
        BKGlobal.Cls1.ExecuteNonQuery(_SQLTxt)

        txtProductID.EditValue = ""
        txtDVDId.EditValue = ""
        txtOrderID.EditValue = ""
    End Sub
End Class
