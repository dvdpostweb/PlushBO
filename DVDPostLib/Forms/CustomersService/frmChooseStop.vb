Public Class frmChooseStop
    Inherits BizzLib.frmBKForm

    Private standard As Boolean
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo, Optional ByVal varStandard As Boolean = True)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
        standard = varStandard
    End Sub

    Dim _ds As New DataSet
    Public customers_id As Integer
    Public drCustomer As DataRow
    Public typeAbo As Integer
    Dim commentAboStop As String

    Private Sub frmChooseStop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridControl1.ContextMenuStrip = menuStrip

        _ds.Tables.Add("reason_to_stop")
        loadDataset()

    End Sub


    'stop the abo 
    Private Sub ButOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOK.Click
        If TextBox1.Text.Length < 250 Then
            Dim commentAboStop As String = Me.TextBox1.Text
            Dim cls As New DVDPostBuziness.ClsCustomers
            Dim reason_Id As Integer = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)("id")
            cls.AboStopManual(drCustomer, reason_id, commentAboStop)

            ' Dim aboStop As New DVDPostBuziness.aboReconduction()

            'Dim _return As Integer

            'If standard The
            ' aboStop.stopAbo(customers_id, typeAbo, "Manual Stop", reasonId, commentAboStop)
            MsgBox("Customer has been stopped", MsgBoxStyle.Exclamation)
            'Else
            '    Dim _SQLTxt As String = "update customers set customers_abo_auto_stop_next_reconduction = 1 where customers_id = " & customers_id
            '    _Return = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
            '    If _Return = 1 Then
            '        MsgBox("Customer will be Auto-Stopped at next reconduction", MsgBoxStyle.Exclamation)
            '    Else
            '        MsgBox("An Error occure." & vbCrLf & _SQLTxt)
            '    End If

            'End If
            Me.Close()
        Else
            MsgBox("the commentary should not exceed 250 characters")
        End If


    End Sub

    ' load the dataset with the table "customers_abo_stop_reason"
    Public Sub loadDataset()
        _ds.Tables("reason_to_stop").Clear()
        DvdPostData.clsConnection.FillDataSet(_ds.Tables("reason_to_stop"), "select * from customers_abo_stop_reason")
        Me.GridControl1.DataSource = _ds.Tables("reason_to_stop")
    End Sub


End Class