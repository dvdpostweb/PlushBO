Public Class clsPicture

    Public Shared Function getPathServer() As String
        Dim sql As String

        sql = " SELECT ParamValue FROM generalglobalparameter " & _
              " WHERE SetUpCategory = 'Global' and Name = 'ImagesServer'"
        Return sql

    End Function
End Class
