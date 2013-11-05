Public Class clsProcessIN
    Public Enum Status
        [IN] = 1
        [OUT] = 0
        [READY] = 2
    End Enum

    'Public Enum statusDvd
    '    OK = 1
    '    ABIME = 2
    '    LOST = 3
    '    BROKEN = 4
    '    DELAYED = 5
    '    LOST_AND_CHARGED = 6
    '    MOVED_TO_FRANCE = 7
    '    MOVED_TO_NL = 8
    '    CANCEL = 9
    '    TRANSIT_KIALA = 10
    '    DVD_SOLD = 11
    '    DVD_GIVEN_IN_KDO = 12
    '    INTERCHANGE = 13
    '    PREP_FOR_SOLD = 14
    '    BIZARREMENT_PERDU = 15
    '    GIVEN_BACK_TO_STUDIO = 16
    '    LONGTIME_CUSTOMER = 17
    '    TEMPORAIREMENT_INDISPONIBLE = 18
    '    CUSTOMERS_SERRVICE = 19
    '    IRREPARABLE = 20
    '    ENTRETIEN = 21

    'End Enum


    Public Shared Function getDVDInStock(ByVal boxId As Integer) As String

        Return getDVDWithStatus(boxId)
    End Function

    Public Shared Function getDVDInStockAndReady(ByVal boxId As Integer) As String

        Return getDVDWithStatus(boxId, Status.IN & "," & Status.READY)
    End Function
    Private Shared Function getDVDSTATUS(ByVal statDVD As clsProductDvd.DVDStatus, ByVal stralias As String) As String
        Dim sql As String

        sql = stralias & ".products_dvd_status = " & statDVD

        Return sql
    End Function

    Private Shared Function getDVDINOUT(ByVal liststatus As String, ByVal stralias As String) As String
        Dim sql As String

        sql = stralias & ".`inout` in (" & liststatus & ") "

        Return sql
    End Function

    Private Shared Function getDVDBOX(ByVal boxId As Integer, ByVal stralias As String) As String
        Dim sql As String

        sql = stralias & ".box_id = '" & boxId & "'"

        Return sql
    End Function

    Private Shared Function getDVDSQL() As String
        Dim sql As String

        sql = "SELECT PD.products_id, PD.products_dvdid, PD.products_dvd_status, PD.box_id, PD.pibox_id, " & _
                                   " P.products_model as products_model, PD.`inout` " & _
                                   " FROM products_dvd PD " & _
                                   " Left join products P on P.products_id = PD.products_id "

        Return sql

    End Function

    Public Shared Function getDVDBoxOnly(ByVal boxId As Integer) As String
        Dim sql As String

        sql = getDVDSQL() & _
        " where " & getDVDBOX(boxId, "PD") & " Order by pibox_id desc"

        Return sql
    End Function

    Private Shared Function getDVDWithStatus(ByVal boxId As Integer) As String
        Dim sql As String

        sql = getDVDSQL() & _
        " where " & getDVDBOX(boxId, "PD") & " Order by pibox_id desc"

        Return sql
    End Function
    Private Shared Function getDVDWithStatus(ByVal boxId As Integer, ByVal liststatus As String) As String
        Dim sql As String

        sql = getDVDSQL() & _
        " where " & getDVDSTATUS(clsProductDvd.DVDStatus.DVD_STATUS_OK, "PD") & " and " & getDVDINOUT(liststatus, "PD") & " and " & getDVDBOX(boxId, "PD") & " Order by pibox_id desc "

        Return sql
    End Function



End Class
