Public Class clsPicture
    Const MappingDiskPicture As String = "x:\"
    Const MappingDiskPictureTest As String = "d:\temp\"

    Enum TypePicture
        logo
        wallpaper
        banner_page
        banner_menu
        title_page
        landings_plush
        thumbs
        surveys
        survey_detail
        home_page
        landingsmobile_plush
        landingstablet_plush
        landingssmarttv_plush
    End Enum

    Public Shared Function GetExtension(ByVal tp As TypePicture) As String


        Select Case tp
            Case TypePicture.logo, TypePicture.banner_menu, TypePicture.thumbs, TypePicture.surveys
                Return ".gif"

            Case Else
                Return ".jpg"

        End Select

    End Function
    Public Shared Function getPathServerMapping() As String
        If PlushData.clsSession.isEnvTest Then
            Return MappingDiskPictureTest
        Else
            Return MappingDiskPicture
        End If


    End Function

    Public Shared Function getPathServer(Optional ByVal type_dvd As PlushData.clsProductDvd.Type_DVD = PlushData.clsProductDvd.Type_DVD.DVD_NORM) As String
        Dim sql As String
        Dim path As String

        sql = PlushData.clsPicture.getPathServer()
        path = PlushData.clsConnection.ExecuteScalar(sql)

        If PlushData.clsSession.isEnvTest Then
            Return MappingDiskPictureTest
        Else

            If type_dvd = PlushData.clsProductDvd.Type_DVD.DVD_NORM Then
                Return "\\" & path & "\images\"
            Else
                Return "\\" & path & "\imagesx\"
            End If

        End If

    End Function

    Public Shared Function ConvertStringToEnum(ByVal str As String) As TypePicture
        Dim tp_picture As TypePicture
        If [Enum].IsDefined(GetType(TypePicture), str) Then
            tp_picture = (CType([Enum].Parse(GetType(TypePicture), str, True), TypePicture))
            Return tp_picture
        End If
        Return Nothing
    End Function


End Class
