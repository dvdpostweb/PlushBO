Public Class clsCustomer_Stat_TypeDvd_STAT

    Public Enum TypeReason
        OTHER = -1
        SERVED = 0
        SUSPENDED = 1
        NOCREDIT = 2
        ATHOME = 3
        WISHEMPTY = 4
        NOTFOUNDDVD = 5
        RANKTOOLOW = 6
        MSGERROR = 7
        PARTIAL_SERVED = 8
        NO_MANAGED = 9
    End Enum

    Private _customers_id As Integer

    Public dvd_highsent As Integer
    Public dvd_mediumsent As Integer
    Public dvd_lowsent As Integer

    Public dvd_send As Integer
    Public dvd_compensation As Integer
    Public dvd_home As Integer
    Public dvd_wishlist As Integer
    Public dvd_abo As Integer
    Public dvd_Find As Integer

    Public position As Integer
    Public credit As Integer
    Public remaindvd As Integer
    Public rank As Integer
    Public IllimitedCredit As Boolean
    Public reason As TypeReason
    Public msgError As String
    Private _sleep As Boolean

    Public Sub New(ByVal customers_id As Integer, ByVal sleep As Boolean)

        _customers_id = customers_id
        _sleep = sleep
        dvd_highsent = 0
        dvd_mediumsent = 0
        dvd_lowsent = 0
        credit = 0
        position = 0
        rank = 0
        reason = TypeReason.OTHER
        msgError = ""

        dvd_send = 0
        dvd_compensation = 0
        dvd_home = 0
        dvd_wishlist = 0
        dvd_abo = 0
        dvd_Find = 0
        IllimitedCredit = False
    End Sub
    Public Function SaveStat(ByVal aboprocess_id As Integer) As Boolean
        Dim sql As String

        sql = strInsertStatCustomer(aboprocess_id)
        PlushData.clsConnection.ExecuteNonQuery(sql)
        Return True
    End Function

    Private Function strInsertStatCustomer(ByVal aboprocess_id As Integer) As String

        Dim SQLTxt As String

        SQLTxt = "insert into customers_aboprocess_stats_new (customers_id , dvd_to_send, dvd_highsent, " & _
          "dvd_mediumsent, dvd_lowsent,dvd_abo,dvd_compensation ,dvd_home," & _
          " credit , customer_abo_rank, aboProcess_id, reason,msgerror,nbdvdfind,nbwishlist,position_served,sleep " & _
          ") values ( " & _customers_id & "," & dvd_send & ", " & _
                        dvd_highsent & "," & dvd_mediumsent & "," & dvd_lowsent & "," & _
                        dvd_abo & "," & dvd_compensation & "," & dvd_home & "," & _
                        credit & ", " & rank & "," & aboprocess_id & "," & _
                        Integer.Parse(reason) & ",'" & msgError.Replace("'", "") & "'," & _
                        dvd_Find & "," & dvd_wishlist & "," & position & "," & _sleep & ")"

        Return SQLTxt

    End Function

    Private Shared Function StrUpdateAboprocessId(ByVal aboprocess_id As Integer) As String
        Dim SQLTxt As String
        SQLTxt = " update customers_aboprocess_stats set aboProcess_id = " & aboprocess_id & " where aboprocess_id = 0"

        Return SQLTxt
    End Function

End Class
