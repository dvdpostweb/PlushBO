Public Class ClsVod

    Public Shared Sub InsertStatVod()
        Dim sql As String

        sql = PlushData.ClsVod.InsertStatVod()
        PlushData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Public Shared Sub UpdateVodPrice()

        Dim sql As String

        sql = PlushData.ClsVod.UpdateVodPrice()
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Shared Sub UpdateSoonVod()

        Dim sql As String

        sql = PlushData.ClsVod.UpdateSoonVod()
        PlushData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Shared Sub UpdateGeoIP()
        Dim sql As String

    End Sub


End Class
