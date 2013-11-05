Public Class frmCriteo

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    Private Sub btnBrowse_Rating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse_Rating.Click
        SaveFileDialog1.ShowDialog(Me)
        txtFileName.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub btnGo_ExportRating_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo_ExportRating.Click
        Dim _DateFromTxt As String = Year(txtFromDate.EditValue) & "-" & Month(txtFromDate.EditValue) & "-" & DateAndTime.Day(txtFromDate.EditValue) & " 00:00:00"
        Dim _DateToTxt As String = Year(txtToDate.EditValue) & "-" & Month(txtToDate.EditValue) & "-" & DateAndTime.Day(txtToDate.EditValue) & " 23:59:59"
        Dim _SQLTxt As String = "SELECT pr.customers_id, p.imdb_id, p.products_id, pr.products_rating, pr.products_rating_date " & _
                                " FROM products_rating pr LEFT JOIN products p on p.products_id=pr.products_id " & _
                                " WHERE products_rating_date >= '" & _DateFromTxt & "' AND products_rating_date <= '" & _DateToTxt & _
                                "' AND p.imdb_id>0 and p.products_type='DVD_NORM' and p.products_status>-1 " & _
                                " order by p.imdb_id ASC"
        Dim _DS As New DataSet
        _DS.Tables.Add("TmpTable")
        DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), _SQLTxt)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(txtFileName.Text, False)
        Dim _row As DataRow
        file.WriteLine("<?xml version=""1.0"" encoding=""ISO-8859-1"" ?>")
        file.WriteLine("<import>")
        For Each _row In _DS.Tables("TmpTable").Rows
            file.WriteLine("<Rating UserId=" & _row("customers_id") & _
                     " ItemId=""" & _row("imdb_id") & """" & _
                     " Value=""" & _row("products_rating") & """" & _
                     " Date=""" & _row("products_rating_date") & """ />")
        Next
        file.WriteLine("</import>")
        file.Close()
        MsgBox("Export complete to : " & txtFileName.Text, MsgBoxStyle.Information)
    End Sub
End Class
