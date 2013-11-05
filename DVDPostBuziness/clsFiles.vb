Imports System.IO
Public Class clsFiles

    Public Function GetListFilesTree(ByVal PathFolder As String) As List(Of String)
        Dim ArrayFiles As String()
        Dim lstFiles As New List(Of String)
        ArrayFiles = Directory.GetFiles(PathFolder, "*.mp4", SearchOption.AllDirectories)

        Dim fInfo As FileInfo
        For Each Item As String In ArrayFiles
            If Item.Trim <> String.Empty Then
                fInfo = New FileInfo(Item)
                lstFiles.Add(fInfo.Name)
            End If
        Next
        Return lstFiles

    End Function

End Class
