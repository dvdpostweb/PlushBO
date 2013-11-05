Imports system.Net
Public Class clsFTP

    Private _ftpserver As String = "ftp://upload.cdnlayer.com"
    Private _username As String = "s706550001"
    Private _pwd As String = "4fe08fe667"
    Private _pathFileFolder = "/media/secureflash/"

    Public Function GetListFilesTree(ByVal ftpserver As String) As List(Of String)
        Return GetListFilesTree(ftpserver, _username, _pwd)
    End Function
    Private Function GetListFilesTree(ByVal FtpUri As String, ByVal user As String, ByVal Pass As String) As List(Of String)

        Dim newFiles As List(Of String) = New List(Of String)()
        Dim files As List(Of String) = New List(Of String)()
        Dim folders As Queue(Of String) = New Queue(Of String)()
        folders.Enqueue(FtpUri)

        While (folders.Count > 0)
            Dim fld As String = folders.Dequeue()

            Dim ftp As FtpWebRequest = FtpWebRequest.Create(fld)
            ftp.Credentials = New NetworkCredential(user, Pass)
            ftp.UsePassive = False
            ftp.Method = WebRequestMethods.Ftp.ListDirectory

            Using resp As New IO.StreamReader(ftp.GetResponse().GetResponseStream())
                Dim line As String = resp.ReadLine()
                While (Not line Is Nothing)
                    If line.Trim() <> String.Empty Then
                        newFiles.Add(line.Trim())
                    End If
                    line = resp.ReadLine()
                End While
            End Using


            '    ftp = FtpWebRequest.Create(fld)
            '    ftp.Credentials = New NetworkCredential(user, Pass)
            '    ftp.UsePassive = False
            '    ftp.Method = WebRequestMethods.Ftp.ListDirectoryDetails
            '    Using resp As New IO.StreamReader(ftp.GetResponse().GetResponseStream())
            '        Dim line As String = resp.ReadLine()
            '        While (Not line Is Nothing)
            '            If (line.Trim().ToLower().StartsWith("d") Or line.Contains(" <DIR> ")) Then
            '                'Dim dir As String = newFiles.First(x >= line.EndsWith(x))
            '                newFiles.Remove(dir)
            '                folders.Enqueue(fld + dir + "/")
            '            End If
            '            line = resp.ReadLine()
            '        End While
            '    End Using
            '    '  files.AddRange(from f in newFiles select fld + f)
        End While
        'Return files.ToArray()
        Return newFiles
    End Function
End Class
