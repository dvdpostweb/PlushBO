

Public Class clsMemberGetMember

    Public Shared Function AddPointFather(ByVal son_id) As Boolean
        'Dim sql As String
        'Dim dt As DataTable
        'Dim father_id As Integer
        'Dim point As Integer
        'Dim dtFatherInfo As DataTable
        'Dim sqlFatherInfo As String

        'sql = PlushData.clsMemberGetMember.GetRowFather(son_id)
        'dt = PlushData.clsConnection.FillDataSet(sql)
        'If dt.Rows.Count > 0 Then
        '    father_id = dt.Rows(0)("father_id")
        '    point = dt.Rows(0)("expected_points")


        '    sql = PlushData.clsMemberGetMember.updateAddPointCustomers(father_id, point)
        '    PlushData.clsConnection.ExecuteNonQuery(sql)
        '    sql = PlushData.clsMemberGetMember.insertCustomersPointHist(father_id, PlushData.clsMemberGetMember.PointsHistoryAction.ADD, PlushData.clsMemberGetMember.PointsHistorySubAction.POINT_GIVEN_TO_SON, point)
        '    PlushData.clsConnection.ExecuteNonQuery(sql)

        '    sql = PlushData.clsMemberGetMember.updatePointSon(son_id, point)
        '    PlushData.clsConnection.ExecuteNonQuery(sql)

        '    sqlFatherInfo = PlushData.clsMemberGetMember.getGodsonAndSponsorInfo(son_id, point)
        '    dtFatherInfo = PlushData.clsConnection.FillDataSet(sqlFatherInfo)
        '    PlushBuziness.clsMail.SendMail(dtFatherInfo.Rows(0), clsMail.Mail.MAIL_SON_ACTIVATION, True, dtFatherInfo.Rows(0)("customers_email_address"), PlushData.clsMemberGetMember.MAIL_FROM_SPONSOR, PlushData.clsMemberGetMember.MAIL_FROM_SPONSOR_NAME)

        'Else
        '    Return False
        'End If

    End Function


End Class
