Imports System.io
Public Class errorList

    Private Sub errorList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click

        Dim fB As New Windows.Forms.FolderBrowserDialog

        fB.RootFolder = Environment.SpecialFolder.Desktop

        fB.Description = "Sélectionnez un répertoire"

        fB.ShowDialog()

        If fB.SelectedPath = String.Empty Then

            MsgBox("Pas de sélection")

        Else
            Dim SW As StreamWriter = File.AppendText(fB.SelectedPath + "\errorList.log")
            SW.WriteLine(" ")
            SW.WriteLine(getIP())
            SW.WriteLine(DateTime.Now.ToString())
            For Each elem As Object In ListError.Items
                SW.WriteLine(elem.ToString)
            Next
            SW.Close()
        End If

        fB.Dispose()
    End Sub
    Public Function getIP() As String
        Dim IP, Name As String
        IP = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName).AddressList(0).ToString
        Name = System.Net.Dns.GetHostName()
        Return "IP : " + IP + " & le Nom de la machine est : " + Name
    End Function

End Class