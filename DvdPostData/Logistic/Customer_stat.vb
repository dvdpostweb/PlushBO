Public Class Customer_stat

    Public Enum TypeReason
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
        DVD_MAX = 10
    End Enum

    Private _customers_id As Integer
    Private _sleep As Boolean
    Public dvd_norm As Customer_TypeDvd
    Public dvd_adult As Customer_TypeDvd

    Public dvd_highsent As Integer
    Public dvd_mediumsent As Integer
    Public dvd_lowsent As Integer

    Public position As Integer
    Public credit As Integer
    Public rank As Integer
    Public reasonNorm As TypeReason
    Public reasonADULT As TypeReason
    Public aboProcess_id As Integer
    Public msgError As String

    Public Sub New(ByVal customers_id As Integer, ByVal sleep As Boolean)

        _customers_id = customers_id
        _sleep = sleep
        dvd_norm = New Customer_TypeDvd
        dvd_adult = New Customer_TypeDvd

        dvd_highsent = 0
        dvd_mediumsent = 0
        dvd_lowsent = 0
        credit = 0
        position = 0
        rank = 0
        reasonNorm = 0
        aboProcess_id = 0
        msgError = ""

    End Sub


    Public Function strUpdateStatCustomer(ByVal aboprocess_id) As String

        Dim SQLTxt As String

        SQLTxt = "insert into customers_aboprocess_stats (customers_id , dvd_norm_to_send, dvd_adult_to_send, dvd_highsent, " & _
          "dvd_mediumsent, dvd_lowsent,dvd_norm_abo,dvd_adult_abo,dvd_norm_compensation , dvd_adult_compensation, dvd_norm_home, dvd_adult_home," & _
          " credit , customer_abo_rank, aboProcess_id, reason,msgerror,nbdvdfindnorm,nbdvdfindadult,nbwishlistnorm,nbwishlistadult,position_served,sleep " & _
          ") values ( " & _customers_id & "," & dvd_norm.dvd_send & ", " & dvd_adult.dvd_send & "," & _
          dvd_highsent & "," & dvd_mediumsent & "," & dvd_lowsent & "," & dvd_norm.dvd_abo & "," & dvd_adult.dvd_abo & "," & _
          dvd_norm.dvd_compensation & "," & dvd_adult.dvd_compensation & "," & dvd_norm.dvd_home & "," & _
          dvd_adult.dvd_home & "," & credit & ", " & rank & "," & aboprocess_id & "," & Integer.Parse(reasonNorm) & ",'" & msgError.Replace("'", "") & "'," & dvd_norm.dvd_Find & "," & dvd_adult.dvd_Find & "," & dvd_norm.dvd_wishlist & "," & dvd_adult.dvd_wishlist & "," & position & "," & _sleep & ")"

        Return SQLTxt

    End Function

    Public Shared Function StrUpdateAboprocessId(ByVal aboprocess_id As Integer) As String
        Dim SQLTxt As String
        SQLTxt = " update customers_aboprocess_stats set aboProcess_id = " & aboprocess_id & " where aboprocess_id = 0"

        Return SQLTxt
    End Function

End Class
