Public Class ClsProducts_dvd_state
    Public Enum state
        [IN] = 1
        MID = 2
        OUT = 3
        PURCHASE = 4
        STOCK = 5
        ABO_PROCESS = 6
        SALE = 7
        SITE_WEB = 8
        DVD_STATUS_MAINTENANCE = 9
    End Enum

    Public Shared Function GetLastState(ByVal products_id As Integer, _
                                        ByVal products_dvd_id As Integer) As String

        Dim sql As String

        sql = " select * from products_dvd_state_history where products_id = " & products_id & _
              " and products_dvd_id = " & products_dvd_id & " orders by 1 desc limit 1"
        Return sql
    End Function
    Public Shared Function getInsertHistory(ByVal products_id As Integer, _
                                            ByVal products_dvd_id As Integer, _
                                            ByVal type_process As state, _
                                            ByVal status As clsProductDvd.DVDStatus, _
                                            ByVal box_id As Integer, _
                                            ByVal pibox_id As Integer, ByVal DVDinout As PlushData.clsProductDvd.INOUT, Optional ByVal pick_group As Integer = -1) As String
        Dim sql As String
        Dim strPick_group

        If pick_group = -1 Then
            strPick_group = "null"
        Else
            strPick_group = pick_group
        End If

        sql = "insert products_dvd_state_history values(null," & _
                                                        products_id & "," & _
                                                        products_dvd_id & "," & _
                                                        status & "," & _
                                                        type_process & "," & _
                                                        box_id & "," & _
                                                        pibox_id & "," & _
                                                        "now() ," & _
                                                        clsSession.user_id & "," & _
                                                        "now()," & DVDinout & "," & strPick_group & ")"
        Return sql
    End Function
End Class
