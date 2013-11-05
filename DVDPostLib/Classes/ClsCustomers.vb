Public Class ClsCustomers

    Public Shared Function openFrmCustMaint(ByVal customers_id As Integer, ByVal parentForm As Windows.Forms.Form, ByVal SessionInfo As BizzLib.clsSessionInfo) As Windows.Forms.Form
        Dim result As frmCustomers_Maint
        Dim _frm As New frmCustomers_Maint()
        _frm.SessionInfo = SessionInfo
        result = _frm.openFrmCustMaint(customers_id, parentForm)
        Return result
    End Function

End Class
