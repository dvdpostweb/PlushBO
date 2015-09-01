Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Data
Imports System.Runtime.InteropServices

Namespace BizzLib
    Public Class clsCombo
        ' Methods
        Public Sub New(ByVal CurrentSessionInfo As clsSessionInfo)
            Me.mvarSessionInfo = CurrentSessionInfo
        End Sub

        Public Sub GetCombo(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal SortField As String, ByVal SQLTxt As String, ByVal Optional MergeWithCurrentData As Boolean = False)
            Dim set2 As New DataSet
            Dim set As New clsDataSet(Me.SessionInfo)
            set2.Tables.Add(TableName)
            Try 
                ClsDs.FillDataSet(set2.Tables.Item(TableName), SQLTxt, True, False)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Throw exception
                ProjectData.ClearProjectError
            End Try
            Try 
                If Not MergeWithCurrentData Then
                    ObjDS.Tables.Item(TableName).Clear
                End If
                ObjDS.Merge(set2.Tables.Item(TableName))
                If ((SortField & "") <> "") Then
                    ObjDS.Tables.Item(TableName).DefaultView.Sort = SortField
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub GetCombo_AllowedEntities(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "generalentity", ByVal Optional SortField As String = "", ByVal Optional TxtFilter As String = "")
            Dim sQLTxt As String = ("SELECT EntityID, Name, Description FROM generalentity WHERE EntityID IN " & Me.SessionInfo.AllowedEntityList & " ")
            If ((TxtFilter & "") <> "") Then
                sQLTxt = (sQLTxt & " AND " & TxtFilter)
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Bank(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal OnlyAllowedEntities As Boolean, ByVal SortField As String)
            Dim sQLTxt As String = "SELECT * FROM CashBank "
            If OnlyAllowedEntities Then
                sQLTxt = (sQLTxt & " WHERE EntityID in " & Me.SessionInfo.AllowedEntityList)
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_BankView1(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal OnlyAllowedEntities As Boolean, ByVal SortField As String)
            Dim sQLTxt As String = "SELECT * FROM CashBankView1 "
            If OnlyAllowedEntities Then
                sQLTxt = (sQLTxt & " WHERE Entity_EntityID in " & Me.SessionInfo.AllowedEntityList)
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CashBuySell(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CashBuySell"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CashDocType(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CashDocType"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CashFrequency(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "", ByVal Optional FromFreqCode As Integer = 0, ByVal Optional ToFreqCode As Integer = 10)
            Dim sQLTxt As String = ("SELECT * FROM CashFrequency WHERE CodeValue >= " & Conversions.ToString(FromFreqCode) & " AND CodeValue <= " & Conversions.ToString(ToFreqCode))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CashLongTermLoanCalc(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CashLongTermLoanCalc"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CashLongTermLoanType(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CashLongTermLoanType"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMAddrContactFormat(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMAddrContactFormat", ByVal Optional SortField As String = "CodeDesc")
            Dim sQLTxt As String = "SELECT * FROM CRMAddrContactFormat"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMAddrFormat(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMAddrFormat", ByVal Optional SortField As String = "CodeDesc")
            Dim sQLTxt As String = "SELECT * FROM CRMAddrFormat"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMCompany(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMCompanyView1"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMContact(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMContactView1", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMcontactView1"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMContactGender(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMContactGender", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMContactGender"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMContactTittle(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMContactTitle", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMContactTitle"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMcountry(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMcountry", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = "SELECT * FROM CRMcountry"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMDepartement(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMDepartement", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMDepartement"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_CRMPerson(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "CRMPersonView1", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM CRMPersonView1"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Currency(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "systemcurrency", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT CurrCode, Description, RndFact FROM systemcurrency"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_DataType(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GeneralDataTypeView1", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM GeneralDataTypeView1"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_EntityAll(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "generalentity", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT EntityID, Name, Description FROM generalentity WHERE (EntityID <> 0)"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_generalglobalcode(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal CodeType As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = ("SELECT CodeType, CodeValue, CodeDesc FROM generalglobalcode WHERE CodeType = '" & CodeType & "' ORDER BY " & SortField)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_generalglobalcodeint(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal CodeType As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = ("SELECT CodeType, CodeValue, CodeDesc FROM generalglobalcodeint WHERE CodeType = '" & CodeType & "' ORDER BY " & SortField)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_generalglobalcodeTypes(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT CodeType, CodeValue, CodeDesc FROM generalglobalcode WHERE CodeType = 'CodeListType' AND CodeValue <> 'CodeListType' "
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLAcct_Link_View1(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal MasterID As Integer, ByVal SortField As String)
            Dim sQLTxt As String = ("SELECT * FROM GLAcct_Link_View1  WHERE MasterID = " & Conversions.ToString(MasterID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLAcctCenterView1(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLAcctView1", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional SortField As String = "Name", ByVal Optional MinOrderNbr As Integer = 1)
            Dim sQLTxt As String = ("SELECT * FROM GLAcctView1 WHERE OrderNbr >=  " & Conversions.ToString(MinOrderNbr))
            If OnlyCurrentEntity Then
                sQLTxt = (sQLTxt & " AND EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLAcctMaster(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLAcctMasterView1", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional SortField As String = "Name", ByVal Optional OnlyActive As Boolean = True)
            Dim sQLTxt As String = "SELECT * FROM GLAcctMasterView1 "
            Dim str2 As String = ""
            If OnlyCurrentEntity Then
                str2 = (" ( EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ) ")
            End If
            If OnlyActive Then
                If (str2 <> "") Then
                    str2 = (str2 & " AND ")
                End If
                str2 = (str2 & " ( Inactif = 0 ) ")
            End If
            sQLTxt = (sQLTxt & " WHERE " & str2)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLAcctRange(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLAcctRange", ByVal Optional FromAcctName As String = "", ByVal Optional ToAcctName As String = "")
            Dim str2 As String = ""
            If ((ToAcctName & "") <> "") Then
                str2 = (str2 & " FromGLAcctName <= '" & ToAcctName & "' ")
            End If
            If (((str2 & "") <> "") And ((FromAcctName & "") <> "")) Then
                str2 = (str2 & " AND ")
            End If
            If ((FromAcctName & "") <> "") Then
                str2 = (str2 & "  ToGLAcctName >= '" & FromAcctName & "' ")
            End If
            If ((str2 & "") <> "") Then
                str2 = (" WHERE " & str2)
            End If
            Me.GetCombo(ObjDS, TableName, "", ("SELECT * FROM GLAcctRange  " & " " & str2), False)
        End Sub

        Public Sub GetCombo_GLAcctView1(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLAcctView1", ByVal Optional ChartTypeID As Integer = -1, ByVal Optional SortField As String = "Name")
            Dim str As String
            If (ChartTypeID = -1) Then
                str = "SELECT * FROM GLAcctView1  "
            Else
                str = ("SELECT * FROM GLAcctView1  WHERE GLChartTypeID = " & Conversions.ToString(ChartTypeID))
            End If
            Me.GetCombo(ObjDS, TableName, SortField, str, False)
        End Sub

        Public Sub GetCombo_GLBook(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLBookView1", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = ("SELECT * FROM GLBookView1  WHERE EntityID in " & Me.SessionInfo.AllowedEntityList)
            If OnlyCurrentEntity Then
                sQLTxt = (sQLTxt & " AND EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLCalYears(ByVal ObjDS As DataSet, ByVal TableName As String)
            Dim sQLTxt As String = ("SELECT Distinct CalYear FROM GLCalendar  WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ORDER BY CalYear DESC ")
            Me.GetCombo(ObjDS, TableName, " CalYear Desc ", sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLCenter(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLCenter", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = "SELECT * FROM GLCenter "
            If OnlyCurrentEntity Then
                sQLTxt = (sQLTxt & " WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLCenterView1(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLCenterView1", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = "SELECT * FROM GLCenterView1 "
            If OnlyCurrentEntity Then
                sQLTxt = (sQLTxt & " WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            End If
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_GLChartType(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "GLChartType", ByVal Optional OnlyCurrentEntity As Boolean = True, ByVal Optional IncludeMaster As Boolean = True, ByVal Optional IncludeGL As Boolean = True, ByVal Optional IncludeOther As Boolean = True, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM GLChartType "
            Dim str2 As String = ""
            If IncludeMaster Then
                If ((str2 & "") <> "") Then
                    str2 = (str2 & " OR ")
                End If
                str2 = (str2 & " Master = 1 ")
            End If
            If IncludeGL Then
                If ((str2 & "") <> "") Then
                    str2 = (str2 & " OR ")
                End If
                str2 = (str2 & " GL = 1 ")
            End If
            If IncludeOther Then
                If ((str2 & "") <> "") Then
                    str2 = (str2 & " OR ")
                End If
                str2 = (str2 & " ( Master = 0 and GL = 0 ) ")
            End If
            If OnlyCurrentEntity Then
                If ((str2 & "") <> "") Then
                    str2 = ("( " & str2 & " ) AND ")
                End If
                str2 = (str2 & " ( EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & ") ")
            End If
            If ((str2 & "") <> "") Then
                str2 = (" WHERE " & str2)
            End If
            sQLTxt = (sQLTxt & str2)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_HoldingAll(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "generalholding", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT HoldingID, Name FROM generalholding WHERE (HoldingID <> 0)"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_IncoTerm(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "IncoTerm", ByVal Optional SortField As String = "Code")
            Dim sQLTxt As String = "SELECT * FROM IncoTerm"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Intervall(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT * FROM Intervall"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Lang(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "systemlanguagecode", ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT Lang, Description FROM systemlanguagecode"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Menu(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT MenuID, MenuLabel FROM systemmenu"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Month(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "MonthView1", ByVal Optional SortField As String = "CodeValue")
            Dim sQLTxt As String = "SELECT * FROM MonthView1 "
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_PayTerm(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "PayTerm", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = "SELECT * FROM PayTerm "
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_PayTermStart(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "PayTermStartView1", ByVal Optional SortField As String = "CodeDesc")
            Dim sQLTxt As String = "SELECT * FROM PayTermStartView1 "
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Role(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT RoleID, Name, Description, EntityID FROM securityrole WHERE (RoleID <> 0)"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_ShortCut(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT Name, ShortCutID, Description FROM securityshortcut"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_SOPPeriodByPlan(ByVal ObjDS As DataSet, ByVal PlanID As Integer, ByVal Optional TableName As String = "SOPPlanPeriod", ByVal Optional SortField As String = "PeriodName")
            Dim sQLTxt As String = ("SELECT * FROM SOPPlanPeriod WHERE SOPPlanID = " & Conversions.ToString(PlanID) & "  ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_SOPPeriodBySerie(ByVal ObjDS As DataSet, ByVal SerieID As Integer, ByVal Optional TableName As String = "SOPPlanPeriod", ByVal Optional SortField As String = "PeriodName")
            Dim sQLTxt As String = ("SELECT * FROM SOPPlanPeriod WHERE SOPPlanID in ( SELECT SOPPlanID FROM SOPPlan WHERE SOPSerieID = " & Conversions.ToString(SerieID) & " ) ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_SOPPlan(ByVal ObjDS As DataSet, ByVal SerieID As Integer, ByVal Optional TableName As String = "SOPPlan", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM SOPPlan WHERE SOPSerieID = " & Conversions.ToString(SerieID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_SOPSerie(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "SOPSerie", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = "SELECT * FROM SOPSerie"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STCostElement(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STCostElement", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STCostElement where EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STCostType(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STCostTypeView1", ByVal Optional SortField As String = "CodeDesc")
            Dim sQLTxt As String = "SELECT * FROM STCostTypeView1"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STGLGroupPO(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STGLGroupPOView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STGLGroupPOView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STGLGroupSO(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STGLGroupSOView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STGLGroupSOView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STGLGroupST(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STGLGroupSTView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STGLGroupSTView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STGLGroupWOL(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STGLGroupWOLView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STGLGroupWOLView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STGLGroupWOM(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STGLGroupWOMView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STGLGroupWOMView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & " ")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STItem(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STItemView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STItemView1 WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
            sQLTxt = ("SELECT * FROM STItemView1 WHERE EntityID = 0 AND ItemID not in ( Select ItemID From STItem WHERE EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID) & ")")
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, True)
        End Sub

        Public Sub GetCombo_STLoc(ByVal ObjDS As DataSet, ByVal LocLevel As Integer, ByVal Optional TableName As String = "STLocView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STLocView1 where LocLevel = " & Conversions.ToString(LocLevel) & " AND EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STLocAtLevel(ByVal ObjDS As DataSet, ByVal LocLevel As Integer, ByVal Optional TableName As String = "STLocView1", ByVal Optional SortField As String = "Name")
            Dim sQLTxt As String = ("SELECT * FROM STLoc where LocLevel = " & Conversions.ToString(LocLevel) & " AND EntityID = " & Conversions.ToString(Me.SessionInfo.EntityID))
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STLocLevel(ByVal ObjDS As DataSet, ByVal GlobalState As GlobalState, ByVal Optional TableName As String = "STLocLevel", ByVal Optional SortField As String = "LocLevel")
            Dim str As String = Me.SessionInfo.GlobalOrLocalEntityList(GlobalState)
            Dim sQLTxt As String = ("SELECT * FROM STLocLevel where EntityID IN " & str)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STLocLevelOverLevelX(ByVal ObjDS As DataSet, ByVal GlobalState As GlobalState, ByVal LevelX As Integer, ByVal Optional TableName As String = "STLocLevel", ByVal Optional SortField As String = "LocLevel")
            Dim str As String = Me.SessionInfo.GlobalOrLocalEntityList(GlobalState)
            Dim sQLTxt As String = ("SELECT * FROM STLocLevel where LocLevel > " & Conversions.ToString(LevelX) & " AND EntityID IN " & str)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STLotSerNeeded(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "STLotSerNeeded", ByVal Optional SortField As String = "CodeDesc")
            Dim sQLTxt As String = "SELECT * FROM STLotSerNeeded"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STQtyBalanceLotSer(ByVal ObjDS As DataSet, ByVal LocID As Integer, ByVal ItemID As Integer, ByVal AsOfDate As DateTime, ByVal Optional TableName As String = "STBalanceQtyLotSer", ByVal Optional SortField As String = "LotSer", ByVal Optional IncludeZeroBalance As Boolean = False)
            Dim str3 As String
            Dim str As String = String.Concat(New String() { "CONVERT(DATETIME, '", Conversions.ToString(DateAndTime.Year(AsOfDate)), "-", Conversions.ToString(DateAndTime.Month(AsOfDate)), "-", Conversions.ToString(DateAndTime.Day(AsOfDate)), " 00:00:00',102)" })
            Dim str4 As String = String.Concat(New String() { "CONVERT(DATETIME, '", Conversions.ToString(DateAndTime.Year(AsOfDate)), "-", Conversions.ToString(DateAndTime.Month(AsOfDate)), "-", Conversions.ToString(DateAndTime.Day(AsOfDate)), " 00:00:00',102)" })
            Dim str2 As String = ("( DateDiff ( Day , EffDate, ( SELECT TOP 1 EffDate FROM STBalanceQtyLotSer as Tble1 WHERE  DateDiff(Day, EffDate , " & str & ") >= 0 AND Tble1.LocID = STBalanceQtyLotSer.LocID and TBle1.ItemID = STBalanceQtyLotSer.ItemID AND Tble1.LotSer = STBalanceQtyLotSer.LotSer  ORDER BY EffDate DESC )) = 0 ) ")
            If IncludeZeroBalance Then
                str3 = String.Concat(New String() { "SELECT * FROM STBalanceQtyLotSer where LocID = ", Conversions.ToString(LocID), " AND ItemID = ", Conversions.ToString(ItemID), " AND ", str2 })
            Else
                str3 = String.Concat(New String() { "SELECT * FROM STBalanceQtyLotSer where Balance <> 0 and LocID = ", Conversions.ToString(LocID), " AND ItemID = ", Conversions.ToString(ItemID), " AND ", str2 })
            End If
            Me.GetCombo(ObjDS, TableName, SortField, str3, False)
        End Sub

        Public Sub GetCombo_STTechAttrib(ByVal ObjDS As DataSet, ByVal GlobalState As GlobalState, ByVal Optional TableName As String = "STTechAttrib", ByVal Optional SortField As String = "Name")
            Dim str As String = Me.SessionInfo.GlobalOrLocalEntityList(GlobalState)
            Dim sQLTxt As String = ("SELECT * FROM STTechAttrib where EntityID IN " & str)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_STTechType(ByVal ObjDS As DataSet, ByVal GlobalState As GlobalState, ByVal Optional TableName As String = "STTechType", ByVal Optional SortField As String = "Name")
            Dim str As String = Me.SessionInfo.GlobalOrLocalEntityList(GlobalState)
            Dim sQLTxt As String = ("SELECT * FROM STTechType where EntityID IN " & str)
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_UM(ByVal ObjDS As DataSet, ByVal Optional TableName As String = "UM", ByVal Optional SortField As String = "UM")
            Dim sQLTxt As String = "SELECT * FROM UM"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub

        Public Sub GetCombo_Users(ByVal ObjDS As DataSet, ByVal TableName As String, ByVal Optional SortField As String = "")
            Dim sQLTxt As String = "SELECT UserID, FullName, Lang FROM securityuser WHERE (UserID <> 0)"
            Me.GetCombo(ObjDS, TableName, SortField, sQLTxt, False)
        End Sub


        ' Properties
        Public Property SessionInfo As clsSessionInfo
            Get
                Return Me.mvarSessionInfo
            End Get
            Set(ByVal Value As clsSessionInfo)
                Me.mvarSessionInfo = Value
            End Set
        End Property


        ' Fields
        Private mvarSessionInfo As clsSessionInfo
    End Class
End Namespace

