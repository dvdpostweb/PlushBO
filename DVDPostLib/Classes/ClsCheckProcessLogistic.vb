Public Class ClsCheckProcessLogistic

    Public txtInfo As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnUnlock As DevExpress.XtraEditors.SimpleButton
    Public btnSearch As DevExpress.XtraEditors.SimpleButton
    Public txtbarcode As DevExpress.XtraEditors.TextEdit
    Public WithEvents Ctrlbox_id As DevExpress.XtraEditors.SpinEdit
    Public sessionInfo As BizzLib.clsSessionInfo
    Public objDS As dsProducts
    Private Const NbrDVDByBox As Integer = 20
    Private Const maxValueBox As Integer = 100000
    Private Const minValueBox As Integer = -1000


    Public Function GetCodeBar(ByVal codebar As String) As clsProduct_DVD
        Dim objProductDVD As clsProduct_DVD

        objProductDVD = New clsProduct_DVD(sessionInfo, objDS, codebar)
        If Not objProductDVD.BarCode.IsBarCodeValid Then
            txtInfo.Text = "BAR CODE NON VALIDE  Retry Scan"
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            txtInfo.Focus()
            objProductDVD = Nothing
            DisableBarCode()
        End If
        Return objProductDVD
    End Function

    Public Sub DisableBarCode()
        txtbarcode.Enabled = False
        btnUnlock.Visible = True
        If Not btnSearch Is Nothing Then btnSearch.Enabled = False
        If Not Ctrlbox_id Is Nothing Then Ctrlbox_id.Enabled = False

        For index As Integer = 1 To 10
            Beep()
        Next

  
    End Sub

    Public Sub EnableBarCode()
        If Not Ctrlbox_id Is Nothing Then
            Dim value As Integer
            Ctrlbox_id.Enabled = True
            value = Ctrlbox_id.EditValue
            Ctrlbox_id.Properties.MaxValue = maxValueBox
            Ctrlbox_id.Properties.MinValue = minValueBox

            Ctrlbox_id.EditValue = value
        End If
        If Not btnSearch Is Nothing Then btnSearch.Enabled = True
        txtbarcode.Text = ""
        txtbarcode.Enabled = True
        txtbarcode.Focus()
        txtbarcode.Refresh()


        btnUnlock.Visible = False
        'DoEvents()

    End Sub

    Public Function ExistAlreadyBox(ByVal dt As DataTable, ByVal objProductDVD As clsProduct_DVD) As Boolean
        Dim DVD_Row As DataRow
        DVD_Row = dt.Rows.Find(New Object() {objProductDVD.ProductsID, objProductDVD.DvdId})
        ' Deja Scanne 
        If DVD_Row IsNot Nothing Then
            txtInfo.Text = "DVD already in this box !!"
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            DisableBarCode()
            Return True
        End If
        Return False
    End Function

    Public Function CheckValidBox(ByVal txtBoxID As DevExpress.XtraEditors.SpinEdit) As Boolean

        If txtBoxID.EditValue Is Nothing OrElse txtBoxID.EditValue = 0 Then
            txtInfo.Text = "Choose one box before "
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            DisableBarCode()
            Return False
        End If

        Return True
    End Function

    Public Function CheckdvdAlreadyInStock(ByVal box_id As Integer) As Boolean

        If box_id > 0 And box_id < 10000 Then
            txtInfo.Text = " Verify the old box " & box_id
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            DisableBarCode()
            Return True
        End If

        Return False
    End Function

    Public Function CheckFullBox(ByRef dt As DataTable, ByVal box_id As Integer) As Boolean
        Dim viewInout1 As New DataView(dt)
        ' viewInout1.RowFilter = " inout = 1 "
        If viewInout1.Count >= NbrDVDByBox And box_id > 0 Then
            txtInfo.Text = "Full Box ! Change Box please "
            MsgBox(txtInfo.Text, MsgBoxStyle.Exclamation)
            ' removed dvd status inventaire 
            resetNumberBox(dt, box_id)

            DisableBarCode()
            Return True
        End If

        Return False
    End Function

    Public Sub resetNumberBox(ByRef dt As DataTable, ByVal box_id As Integer)
        If btnUnlock.Visible = True Then Return
        DVDPostBuziness.ClsproductsDvd.resetposinbox(dt)
        RefreshData(dt, box_id)
    End Sub

    Public Function cleanBox(ByRef dt As DataTable, ByVal box_id As Integer) As Boolean

        Dim _row As DataRow
        Dim _DS As New dsProducts
        Dim objProductDVD As clsProduct_DVD

        If box_id < 0 Then
            txtInfo.Text = " don't clean manually a box negative!!!"
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            DisableBarCode()
            Return False

        End If
        ' Dim _SQLTxt As String

        ' _SQLTxt = DvdPostData.clsProductDvd.GetProductDvdInBoxClean(box_id)

        objDS.EnforceConstraints = False

        ' dt = DvdPostData.clsConnection.FillDataSet(_SQLTxt)

        For Each _row In dt.Rows
            If _row("inout") <> DvdPostData.clsProductDvd.INOUT.IN Then Continue For
            objProductDVD = New clsProduct_DVD(sessionInfo, _DS, _row("products_id"), _row("products_dvdid"))
            objProductDVD.ChangeStateProductsDVD(DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE, _
                                                      "Inventaire - Clearing a Box", _
                                                      DvdPostData.ClsProducts_dvd_state.state.STOCK, objProductDVD.INOUT)

        Next
        dt.Rows.Clear()
        'RefreshData(dt, box_id)
        Return True
    End Function
    Public Sub RefreshData(ByRef dt As DataTable, ByVal box_id As Integer, Optional ByVal inStock As Boolean = False)

        Dim _SQLTxt As String

        _SQLTxt = DvdPostData.clsStock.GetSelectStock(box_id, inStock)
        dt.Clear()
        DvdPostData.clsConnection.FillDataSet(dt, _SQLTxt)

        EnableBarCode()

    End Sub

    Public Function CheckStatus(ByVal currentdvd_status As DvdPostData.clsProductDvd.DVDStatus, ByVal objProductDVD As clsProduct_DVD, ByVal check As Boolean, ByRef cptRefound As Integer) As Boolean
        Dim warning As String
        Dim Answ As MsgBoxResult

        If currentdvd_status = DvdPostData.clsProductDvd.DVDStatus.ENTRETIEN Then
            resetCounter(objProductDVD, check)
        ElseIf currentdvd_status = DvdPostData.clsProductDvd.DVDStatus.VOD Then
            btnSearch.Focus()
            cptRefound += 1
        ElseIf currentdvd_status <> DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK _
            And currentdvd_status <> DvdPostData.clsProductDvd.DVDStatus.INVENTAIRE _
            And currentdvd_status <> DvdPostData.clsProductDvd.DVDStatus.PURCHASE Then

            warning = "PREVIOUS STATUS ( " & DVDPostTools.clsEnum.getNameStrEnum(currentdvd_status) & " ) !!"
            txtInfo.Text = warning & " is it normaly ?"

            Answ = MsgBox(txtInfo.Text, MsgBoxStyle.YesNo)
            If Answ = MsgBoxResult.No Then
                txtInfo.Text = "NO UPDATE "
                DisableBarCode()
                Return False

            End If
            btnSearch.Focus()
            cptRefound += 1
        End If
        Return True

    End Function

    Private Sub resetCounter(ByVal objProductDVD As clsProduct_DVD, ByVal chkReset As Boolean)
        Dim sql As String
        If chkReset = False Then Return
        If objProductDVD.products_dvd_status = DvdPostData.clsProductDvd.DVDStatus.ENTRETIEN Then
            sql = "update products_dvd set nbr_rotation_since_last_check = 0 , nbr_repair = if ( nbr_repair is null , 0 , nbr_repair) + 1 " & _
                   " where products_id = '" & objProductDVD.ProductsID & "' and products_dvdid  = '" & objProductDVD.DvdId & "'"
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
        Else
            txtINFO.Text = "No resetCounter but status dvd is " & DVDPostTools.clsEnum.getNameStrEnum(objProductDVD.products_dvd_status)
            MsgBox(txtINFO.Text, MsgBoxStyle.Critical)
        End If
    End Sub

    Public Function CheckOrder(ByVal objProductDVD As clsProduct_DVD) As Boolean

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsOdersStatusHistory.GetLastOrdersOpened(objProductDVD.ProductsID, objProductDVD.DvdId)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count > 0 Then
            txtInfo.Text = "Check Order Dvd please in DVD maintenance (orders open : " & dt.Rows.Count & ")  Order_id : " & _
            dt.Rows(0)("date_purchased") & " customers_id : " & dt.Rows(0)("customers_id") & " INOUT : " & objProductDVD.INOUT
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            DisableBarCode()
            Return False
        End If

        Return True
    End Function

    Public Sub GenereBarCode()

        If btnUnlock.Visible = True Then Return
        Dim _productsId As Integer
        Dim _dvdId As Integer
        Dim _objProdDVD As clsProduct_DVD = Nothing
        txtbarcode.Text.Trim()
        If txtbarcode.Text.IndexOf("-") <> -1 Then
            _productsId = txtbarcode.Text.Substring(0, txtbarcode.Text.IndexOf("-"))
            _dvdId = txtbarcode.Text.Substring(txtbarcode.Text.IndexOf("-") + 1)
            _objProdDVD = New clsProduct_DVD(sessionInfo, objDS, _productsId, _dvdId)
            If _objProdDVD.BarCode.IsBarCodeValid Then
                txtbarcode.Text = _objProdDVD.BarCode.Barcode
                txtbarcode.Refresh()
            Else
                DisableBarCode()
            End If
        End If

    End Sub

    Public Sub GetBoxEmpty(ByVal win As Windows.Forms.Form)
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsStock.getBoxEmpty()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If btnUnlock.Visible = True Then Return
        Dim _frm As New frmBoxList

        _frm.GridControl1.DataSource = dt
        _frm.ShowDialog(win)
    End Sub


    Public Sub GetLastInventory(ByVal win As Windows.Forms.Form)

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsStock.GetLastInventory()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If btnUnlock.Visible = True Then Return
        Dim _frm As New frmBoxList

        _frm.GridControl1.DataSource = dt
        _frm.ShowDialog(win)

    End Sub

    Public Sub GetMoreEmptyBox(ByVal win As Windows.Forms.Form)

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsStock.GetMoreEmptyBox()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If btnUnlock.Visible = True Then Return
        Dim _frm As New frmBoxList

        _frm.GridControl1.DataSource = dt
        _frm.ShowDialog(win)

    End Sub

    Private Sub CtrlBoxID_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles Ctrlbox_id.EditValueChanging
        Dim newvalue As Integer = Integer.Parse(e.NewValue)
        If newvalue > maxValueBox Or newvalue < minValueBox Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnlock.Click
        txtInfo.Text = ""
        EnableBarCode()
    End Sub

    Public Sub ChkAlert(ByVal objProductDVD As clsProduct_DVD)
        ' objProductDVD.LoadFirstAlarm()

        Dim sql As String
        Dim isAlert As Boolean

        Dim dt As DataTable
        sql = DvdPostData.clsProductsAlert.getProductsAlert(objProductDVD.ProductsID, 0)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        isAlert = dt.Rows.Count > 0
        If dt.Rows.Count = 0 Then
            sql = DvdPostData.clsProductsAlert.getProductsAlert(objProductDVD.ProductsID, objProductDVD.DvdId)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            isAlert = dt.Rows.Count > 0
        End If

        If isAlert Then
            DisableBarCode()
            txtInfo.Text = dt.Rows(0)("alert_comment") & " - Ne PAS mettre ce DVD dans la boite"
            MsgBox(txtInfo.Text, MsgBoxStyle.Critical)
            sql = DvdPostData.clsProductsAlert.UpdateCheckStatus(dt.Rows(0)("alert_id"), DvdPostData.clsProductsAlert.checkStatus.CHECKED)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            'DisableBarCode()
            ' Order_Status = DvdPostData.clsOdersStatusHistory.OrderStatus.ORDERS_STATUS_CUSTSERV

        End If

    End Sub

End Class
