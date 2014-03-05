Public Class ClsOut
    Inherits State
    Public Overrides Sub getIN(ByVal context As Context)

        context.State = New [IN]()
    End Sub

    Public Overrides Sub getCUSTSERV(ByVal context As Context)

        context.State = New CustServ()
    End Sub

    Public Overrides Sub getBROKENCustomer(ByVal context As Context)

        context.State = New ClsBrokenCustomer()
    End Sub

    Public Overrides Sub getDAMAGED(ByVal context As Context)

        context.State = New ClsDamaged()
    End Sub

    Public Overrides Sub getBADLABEL(ByVal context As Context)

        context.State = New ClsBadLabel()
    End Sub



End Class
