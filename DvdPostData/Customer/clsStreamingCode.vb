Public Class clsStreamingCode

    Public Shared Function GetStreamingCodeAllFields() As String
        Dim sql = "select id, name, email, mail_id, white_label, activation_group_id, used_at, created_at, expiration_at from streaming_codes where 1 "
        Return sql
    End Function

    Public Shared Function GetStreamingCodeSearch(Optional ByVal stremingcode_id As String = "", Optional ByVal streaming_code As String = "", Optional ByVal streamingcodeUse As Boolean = False, Optional ByVal dateFrom As String = "", Optional ByVal dateTo As String = "", Optional ByVal dateExpirationTo As String = "", Optional ByVal groupID As String = "") As String
        Dim sql As String
        'Dim orderBy As String = " order by activation_code_creation_date desc "
        sql = GetStreamingCodeAllFields()

        If stremingcode_id <> String.Empty Then
            sql = sql + " and id = " & stremingcode_id 'GetActivationById(activation_id)
        End If

        If streaming_code <> String.Empty Then
            sql = sql + " and name like '" & streaming_code & "%' " 'GetActivationWithPrefixe(activation_code)
        End If

        If dateFrom <> String.Empty Then
            sql = sql + " and created_at >= '" & PlushTools.ClsDate.formatDate(dateFrom) & "'"
        End If

        If dateTo <> String.Empty Then
            sql = sql + " and  created_at <= '" & PlushTools.ClsDate.formatDate(dateTo) & "' "
        End If

        If dateExpirationTo <> String.Empty Then
            sql = sql + " and  expiration_at <= '" & PlushTools.ClsDate.formatDate(dateExpirationTo) & "' "
        End If

        If streamingcodeUse = True Then
            sql = sql + " and used_at is not null"
        End If

        If groupID <> "" Then
            sql = sql + " and activation_group_id = " & groupID
        End If


        sql = sql + " order by id desc "
        Return sql
    End Function

    Public Shared Function insertStreamingCode(ByVal _StreamingCode As String, ByVal _ActivationGroupID As Integer, _
                                                ByVal _CreatedAt As String, ByVal _ExpiredAt As String, ByVal _UsedAt As String, _
                                                ByVal chkWhiteLabel As Integer) As String

        Dim ExpiredAt As String
        Dim CreatedAt As String
        Dim UsedAt As String

        If _ExpiredAt <> "" Then
            ExpiredAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_ExpiredAt) & "' "
        Else
            ExpiredAt = " NULL "
        End If
        'If _CreatedAt <> "" Then
        '    CreatedAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_CreatedAt) & "' "
        'Else
        '    CreatedAt = " NULL "
        'End If
        If _UsedAt <> "" Then
            UsedAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_UsedAt) & "' "
        Else
            UsedAt = " NULL "
        End If


        Dim sql As String
        sql = "INSERT INTO streaming_codes (name, white_label, activation_group_id , expiration_at, used_at, created_at, updated_at) values " & _
                                            "  ('" & _StreamingCode & "'" & _
                      " ,0 " & _
                      " , " & _ActivationGroupID & _
                      " , " & ExpiredAt & _
                      " , " & UsedAt & _
                      " , now() , now() )"


        Return sql
    End Function

    Public Shared Function updateSteamingCodeByVal(ByVal streamingID As Integer, ByVal _StreamingCode As String, ByVal _ActivationGroupID As Integer, ByVal _mail_id As Integer, ByVal _email As String, _
                                                ByVal _CreatedAt As String, ByVal _ExpiredAt As String, ByVal _UsedAt As String, _
                                                ByVal chkWhiteLabel As Integer) As String

        Dim ExpiredAt As String
        Dim CreatedAt As String
        Dim UsedAt As String
        Dim stremail As String
        Dim strmailid As String

        If _email = "" Then
            stremail = "null"
        Else
            stremail = "'" & _email & "'"
        End If
        If _mail_id = 0 Then
            strmailid = "null"
        Else
            strmailid = _mail_id
        End If
        If _ExpiredAt <> "" Then
            ExpiredAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_ExpiredAt) & "' "
        Else
            ExpiredAt = " NULL "
        End If
        If _CreatedAt <> "" Then
            CreatedAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_CreatedAt) & "' "
        Else
            CreatedAt = " NULL "
        End If
        If _UsedAt <> "" Then
            UsedAt = " '" & PlushTools.ClsDate.formatDateTimeDB(_UsedAt) & "' "
        Else
            UsedAt = " NULL "
        End If

        Dim sql As String
        sql = "update streaming_codes set  name = '" & _StreamingCode & "'" & _
              " ,white_label = " & Math.Abs(chkWhiteLabel) & _
              " ,activation_group_id = " & _ActivationGroupID & _
              " , email = " & stremail & _
              " , mail_id = " & strmailid & _
              " , expiration_at = " & ExpiredAt & _
              " , used_at = " & UsedAt & _
              " , created_at = " & CreatedAt & _
              " , updated_at = '" & PlushTools.ClsDate.formatDateTimeDB(Now()) & "' " & _
              "  where id = " & streamingID

        Return sql
    End Function

End Class
