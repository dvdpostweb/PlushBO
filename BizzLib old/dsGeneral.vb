Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Namespace BizzLib
    <Serializable, XmlSchemaProvider("GetTypedDataSetSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), HelpKeyword("vs.data.DataSet"), XmlRoot("dsGeneral"), DesignerCategory("code"), ToolboxItem(True)> _
    Public Class dsGeneral
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsGeneral.__ENCList
            SyncLock list
                dsGeneral.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.BeginInit
            Me.InitClass
            Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler MyBase.Tables.CollectionChanged, handler
            AddHandler MyBase.Relations.CollectionChanged, handler
            Me.EndInit
        End Sub

        <DebuggerNonUserCode> _
        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context, False)
            Dim list As ArrayList = dsGeneral.__ENCList
            SyncLock list
                dsGeneral.__ENCList.Add(New WeakReference(Me))
            End SyncLock
            Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
            If Me.IsBinarySerialized(info, context) Then
                Me.InitVars(False)
                Dim handler2 As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
                AddHandler Me.Tables.CollectionChanged, handler2
                AddHandler Me.Relations.CollectionChanged, handler2
            Else
                Dim s As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
                If (Me.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema) Then
                    Dim dataSet As New DataSet
                    dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
                    If (Not dataSet.Tables.Item("generalcomment") Is Nothing) Then
                        MyBase.Tables.Add(New generalcommentDataTable(dataSet.Tables.Item("generalcomment")))
                    End If
                    If (Not dataSet.Tables.Item("generaldesctranslation") Is Nothing) Then
                        MyBase.Tables.Add(New generaldesctranslationDataTable(dataSet.Tables.Item("generaldesctranslation")))
                    End If
                    If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                        MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                    End If
                    If (Not dataSet.Tables.Item("generalholding") Is Nothing) Then
                        MyBase.Tables.Add(New generalholdingDataTable(dataSet.Tables.Item("generalholding")))
                    End If
                    If (Not dataSet.Tables.Item("systemcurrency") Is Nothing) Then
                        MyBase.Tables.Add(New systemcurrencyDataTable(dataSet.Tables.Item("systemcurrency")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalcode") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalcodeDataTable(dataSet.Tables.Item("generalglobalcode")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalcodeType") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalcodeTypeDataTable(dataSet.Tables.Item("generalglobalcodeType")))
                    End If
                    If (Not dataSet.Tables.Item("CashBank") Is Nothing) Then
                        MyBase.Tables.Add(New CashBankDataTable(dataSet.Tables.Item("CashBank")))
                    End If
                    If (Not dataSet.Tables.Item("CashBankCreditLine") Is Nothing) Then
                        MyBase.Tables.Add(New CashBankCreditLineDataTable(dataSet.Tables.Item("CashBankCreditLine")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalcode1") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalcode1DataTable(dataSet.Tables.Item("generalglobalcode1")))
                    End If
                    If (Not dataSet.Tables.Item("systemcurrencyexrate") Is Nothing) Then
                        MyBase.Tables.Add(New systemcurrencyexrateDataTable(dataSet.Tables.Item("systemcurrencyexrate")))
                    End If
                    If (Not dataSet.Tables.Item("GeneralCurrencyView1") Is Nothing) Then
                        MyBase.Tables.Add(New GeneralCurrencyView1DataTable(dataSet.Tables.Item("GeneralCurrencyView1")))
                    End If
                    If (Not dataSet.Tables.Item("CashBankAccount") Is Nothing) Then
                        MyBase.Tables.Add(New CashBankAccountDataTable(dataSet.Tables.Item("CashBankAccount")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalparameter") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalparameterDataTable(dataSet.Tables.Item("generalglobalparameter")))
                    End If
                    If (Not dataSet.Tables.Item("CRMcountry") Is Nothing) Then
                        MyBase.Tables.Add(New CRMcountryDataTable(dataSet.Tables.Item("CRMcountry")))
                    End If
                    If (Not dataSet.Tables.Item("generalholdingView1") Is Nothing) Then
                        MyBase.Tables.Add(New generalholdingView1DataTable(dataSet.Tables.Item("generalholdingView1")))
                    End If
                    If (Not dataSet.Tables.Item("generalentity") Is Nothing) Then
                        MyBase.Tables.Add(New generalentityDataTable(dataSet.Tables.Item("generalentity")))
                    End If
                    If (Not dataSet.Tables.Item("STCostTypeView1") Is Nothing) Then
                        MyBase.Tables.Add(New STCostTypeView1DataTable(dataSet.Tables.Item("STCostTypeView1")))
                    End If
                    If (Not dataSet.Tables.Item("GeneralAddress") Is Nothing) Then
                        MyBase.Tables.Add(New GeneralAddressDataTable(dataSet.Tables.Item("GeneralAddress")))
                    End If
                    If (Not dataSet.Tables.Item("generalentityView1") Is Nothing) Then
                        MyBase.Tables.Add(New generalentityView1DataTable(dataSet.Tables.Item("generalentityView1")))
                    End If
                    If (Not dataSet.Tables.Item("PayMethod") Is Nothing) Then
                        MyBase.Tables.Add(New PayMethodDataTable(dataSet.Tables.Item("PayMethod")))
                    End If
                    Me.DataSetName = dataSet.DataSetName
                    Me.Prefix = dataSet.Prefix
                    Me.Namespace = dataSet.Namespace
                    Me.Locale = dataSet.Locale
                    Me.CaseSensitive = dataSet.CaseSensitive
                    Me.EnforceConstraints = dataSet.EnforceConstraints
                    Me.Merge(dataSet, False, MissingSchemaAction.Add)
                    Me.InitVars
                Else
                    Me.ReadXmlSchema(New XmlTextReader(New StringReader(s)))
                End If
                Me.GetSerializationData(info, context)
                Dim handler As CollectionChangeEventHandler = New CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
                AddHandler MyBase.Tables.CollectionChanged, handler
                AddHandler Me.Relations.CollectionChanged, handler
            End If
        End Sub

        <DebuggerNonUserCode> _
        Public Overrides Function Clone() As DataSet
            Dim general As dsGeneral = DirectCast(MyBase.Clone, dsGeneral)
            general.InitVars
            general.SchemaSerializationMode = Me.SchemaSerializationMode
            Return general
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function GetSchemaSerializable() As XmlSchema
            Dim w As New MemoryStream
            Me.WriteXmlSchema(New XmlTextWriter(w, Nothing))
            w.Position = 0
            Return XmlSchema.Read(New XmlTextReader(w), Nothing)
        End Function

        <DebuggerNonUserCode> _
        Public Shared Function GetTypedDataSetSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
            Dim general As New dsGeneral
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(general.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = general.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsGeneral"
            Me.Prefix = ""
            Me.Namespace = "http://www.tempuri.org/dsGeneral.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablegeneralcomment = New generalcommentDataTable
            MyBase.Tables.Add(Me.tablegeneralcomment)
            Me.tablegeneraldesctranslation = New generaldesctranslationDataTable
            MyBase.Tables.Add(Me.tablegeneraldesctranslation)
            Me.tablesystemlanguagecode = New systemlanguagecodeDataTable
            MyBase.Tables.Add(Me.tablesystemlanguagecode)
            Me.tablegeneralholding = New generalholdingDataTable
            MyBase.Tables.Add(Me.tablegeneralholding)
            Me.tablesystemcurrency = New systemcurrencyDataTable
            MyBase.Tables.Add(Me.tablesystemcurrency)
            Me.tablegeneralglobalcode = New generalglobalcodeDataTable
            MyBase.Tables.Add(Me.tablegeneralglobalcode)
            Me.tablegeneralglobalcodeType = New generalglobalcodeTypeDataTable
            MyBase.Tables.Add(Me.tablegeneralglobalcodeType)
            Me.tableCashBank = New CashBankDataTable
            MyBase.Tables.Add(Me.tableCashBank)
            Me.tableCashBankCreditLine = New CashBankCreditLineDataTable
            MyBase.Tables.Add(Me.tableCashBankCreditLine)
            Me.tablegeneralglobalcode1 = New generalglobalcode1DataTable
            MyBase.Tables.Add(Me.tablegeneralglobalcode1)
            Me.tablesystemcurrencyexrate = New systemcurrencyexrateDataTable
            MyBase.Tables.Add(Me.tablesystemcurrencyexrate)
            Me.tableGeneralCurrencyView1 = New GeneralCurrencyView1DataTable
            MyBase.Tables.Add(Me.tableGeneralCurrencyView1)
            Me.tableCashBankAccount = New CashBankAccountDataTable
            MyBase.Tables.Add(Me.tableCashBankAccount)
            Me.tablegeneralglobalparameter = New generalglobalparameterDataTable
            MyBase.Tables.Add(Me.tablegeneralglobalparameter)
            Me.tableCRMcountry = New CRMcountryDataTable
            MyBase.Tables.Add(Me.tableCRMcountry)
            Me.tablegeneralholdingView1 = New generalholdingView1DataTable
            MyBase.Tables.Add(Me.tablegeneralholdingView1)
            Me.tablegeneralentity = New generalentityDataTable
            MyBase.Tables.Add(Me.tablegeneralentity)
            Me.tableSTCostTypeView1 = New STCostTypeView1DataTable
            MyBase.Tables.Add(Me.tableSTCostTypeView1)
            Me.tableGeneralAddress = New GeneralAddressDataTable
            MyBase.Tables.Add(Me.tableGeneralAddress)
            Me.tablegeneralentityView1 = New generalentityView1DataTable
            MyBase.Tables.Add(Me.tablegeneralentityView1)
            Me.tablePayMethod = New PayMethodDataTable
            MyBase.Tables.Add(Me.tablePayMethod)
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub InitializeDerivedDataSet()
            Me.BeginInit
            Me.InitClass
            Me.EndInit
        End Sub

        <DebuggerNonUserCode> _
        Friend Sub InitVars()
            Me.InitVars(True)
        End Sub

        <DebuggerNonUserCode> _
        Friend Sub InitVars(ByVal initTable As Boolean)
            Me.tablegeneralcomment = DirectCast(MyBase.Tables.Item("generalcomment"), generalcommentDataTable)
            If (initTable AndAlso (Not Me.tablegeneralcomment Is Nothing)) Then
                Me.tablegeneralcomment.InitVars
            End If
            Me.tablegeneraldesctranslation = DirectCast(MyBase.Tables.Item("generaldesctranslation"), generaldesctranslationDataTable)
            If (initTable AndAlso (Not Me.tablegeneraldesctranslation Is Nothing)) Then
                Me.tablegeneraldesctranslation.InitVars
            End If
            Me.tablesystemlanguagecode = DirectCast(MyBase.Tables.Item("systemlanguagecode"), systemlanguagecodeDataTable)
            If (initTable AndAlso (Not Me.tablesystemlanguagecode Is Nothing)) Then
                Me.tablesystemlanguagecode.InitVars
            End If
            Me.tablegeneralholding = DirectCast(MyBase.Tables.Item("generalholding"), generalholdingDataTable)
            If (initTable AndAlso (Not Me.tablegeneralholding Is Nothing)) Then
                Me.tablegeneralholding.InitVars
            End If
            Me.tablesystemcurrency = DirectCast(MyBase.Tables.Item("systemcurrency"), systemcurrencyDataTable)
            If (initTable AndAlso (Not Me.tablesystemcurrency Is Nothing)) Then
                Me.tablesystemcurrency.InitVars
            End If
            Me.tablegeneralglobalcode = DirectCast(MyBase.Tables.Item("generalglobalcode"), generalglobalcodeDataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalcode Is Nothing)) Then
                Me.tablegeneralglobalcode.InitVars
            End If
            Me.tablegeneralglobalcodeType = DirectCast(MyBase.Tables.Item("generalglobalcodeType"), generalglobalcodeTypeDataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalcodeType Is Nothing)) Then
                Me.tablegeneralglobalcodeType.InitVars
            End If
            Me.tableCashBank = DirectCast(MyBase.Tables.Item("CashBank"), CashBankDataTable)
            If (initTable AndAlso (Not Me.tableCashBank Is Nothing)) Then
                Me.tableCashBank.InitVars
            End If
            Me.tableCashBankCreditLine = DirectCast(MyBase.Tables.Item("CashBankCreditLine"), CashBankCreditLineDataTable)
            If (initTable AndAlso (Not Me.tableCashBankCreditLine Is Nothing)) Then
                Me.tableCashBankCreditLine.InitVars
            End If
            Me.tablegeneralglobalcode1 = DirectCast(MyBase.Tables.Item("generalglobalcode1"), generalglobalcode1DataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalcode1 Is Nothing)) Then
                Me.tablegeneralglobalcode1.InitVars
            End If
            Me.tablesystemcurrencyexrate = DirectCast(MyBase.Tables.Item("systemcurrencyexrate"), systemcurrencyexrateDataTable)
            If (initTable AndAlso (Not Me.tablesystemcurrencyexrate Is Nothing)) Then
                Me.tablesystemcurrencyexrate.InitVars
            End If
            Me.tableGeneralCurrencyView1 = DirectCast(MyBase.Tables.Item("GeneralCurrencyView1"), GeneralCurrencyView1DataTable)
            If (initTable AndAlso (Not Me.tableGeneralCurrencyView1 Is Nothing)) Then
                Me.tableGeneralCurrencyView1.InitVars
            End If
            Me.tableCashBankAccount = DirectCast(MyBase.Tables.Item("CashBankAccount"), CashBankAccountDataTable)
            If (initTable AndAlso (Not Me.tableCashBankAccount Is Nothing)) Then
                Me.tableCashBankAccount.InitVars
            End If
            Me.tablegeneralglobalparameter = DirectCast(MyBase.Tables.Item("generalglobalparameter"), generalglobalparameterDataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalparameter Is Nothing)) Then
                Me.tablegeneralglobalparameter.InitVars
            End If
            Me.tableCRMcountry = DirectCast(MyBase.Tables.Item("CRMcountry"), CRMcountryDataTable)
            If (initTable AndAlso (Not Me.tableCRMcountry Is Nothing)) Then
                Me.tableCRMcountry.InitVars
            End If
            Me.tablegeneralholdingView1 = DirectCast(MyBase.Tables.Item("generalholdingView1"), generalholdingView1DataTable)
            If (initTable AndAlso (Not Me.tablegeneralholdingView1 Is Nothing)) Then
                Me.tablegeneralholdingView1.InitVars
            End If
            Me.tablegeneralentity = DirectCast(MyBase.Tables.Item("generalentity"), generalentityDataTable)
            If (initTable AndAlso (Not Me.tablegeneralentity Is Nothing)) Then
                Me.tablegeneralentity.InitVars
            End If
            Me.tableSTCostTypeView1 = DirectCast(MyBase.Tables.Item("STCostTypeView1"), STCostTypeView1DataTable)
            If (initTable AndAlso (Not Me.tableSTCostTypeView1 Is Nothing)) Then
                Me.tableSTCostTypeView1.InitVars
            End If
            Me.tableGeneralAddress = DirectCast(MyBase.Tables.Item("GeneralAddress"), GeneralAddressDataTable)
            If (initTable AndAlso (Not Me.tableGeneralAddress Is Nothing)) Then
                Me.tableGeneralAddress.InitVars
            End If
            Me.tablegeneralentityView1 = DirectCast(MyBase.Tables.Item("generalentityView1"), generalentityView1DataTable)
            If (initTable AndAlso (Not Me.tablegeneralentityView1 Is Nothing)) Then
                Me.tablegeneralentityView1.InitVars
            End If
            Me.tablePayMethod = DirectCast(MyBase.Tables.Item("PayMethod"), PayMethodDataTable)
            If (initTable AndAlso (Not Me.tablePayMethod Is Nothing)) Then
                Me.tablePayMethod.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("generalcomment") Is Nothing) Then
                    MyBase.Tables.Add(New generalcommentDataTable(dataSet.Tables.Item("generalcomment")))
                End If
                If (Not dataSet.Tables.Item("generaldesctranslation") Is Nothing) Then
                    MyBase.Tables.Add(New generaldesctranslationDataTable(dataSet.Tables.Item("generaldesctranslation")))
                End If
                If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                    MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                End If
                If (Not dataSet.Tables.Item("generalholding") Is Nothing) Then
                    MyBase.Tables.Add(New generalholdingDataTable(dataSet.Tables.Item("generalholding")))
                End If
                If (Not dataSet.Tables.Item("systemcurrency") Is Nothing) Then
                    MyBase.Tables.Add(New systemcurrencyDataTable(dataSet.Tables.Item("systemcurrency")))
                End If
                If (Not dataSet.Tables.Item("generalglobalcode") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalcodeDataTable(dataSet.Tables.Item("generalglobalcode")))
                End If
                If (Not dataSet.Tables.Item("generalglobalcodeType") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalcodeTypeDataTable(dataSet.Tables.Item("generalglobalcodeType")))
                End If
                If (Not dataSet.Tables.Item("CashBank") Is Nothing) Then
                    MyBase.Tables.Add(New CashBankDataTable(dataSet.Tables.Item("CashBank")))
                End If
                If (Not dataSet.Tables.Item("CashBankCreditLine") Is Nothing) Then
                    MyBase.Tables.Add(New CashBankCreditLineDataTable(dataSet.Tables.Item("CashBankCreditLine")))
                End If
                If (Not dataSet.Tables.Item("generalglobalcode1") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalcode1DataTable(dataSet.Tables.Item("generalglobalcode1")))
                End If
                If (Not dataSet.Tables.Item("systemcurrencyexrate") Is Nothing) Then
                    MyBase.Tables.Add(New systemcurrencyexrateDataTable(dataSet.Tables.Item("systemcurrencyexrate")))
                End If
                If (Not dataSet.Tables.Item("GeneralCurrencyView1") Is Nothing) Then
                    MyBase.Tables.Add(New GeneralCurrencyView1DataTable(dataSet.Tables.Item("GeneralCurrencyView1")))
                End If
                If (Not dataSet.Tables.Item("CashBankAccount") Is Nothing) Then
                    MyBase.Tables.Add(New CashBankAccountDataTable(dataSet.Tables.Item("CashBankAccount")))
                End If
                If (Not dataSet.Tables.Item("generalglobalparameter") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalparameterDataTable(dataSet.Tables.Item("generalglobalparameter")))
                End If
                If (Not dataSet.Tables.Item("CRMcountry") Is Nothing) Then
                    MyBase.Tables.Add(New CRMcountryDataTable(dataSet.Tables.Item("CRMcountry")))
                End If
                If (Not dataSet.Tables.Item("generalholdingView1") Is Nothing) Then
                    MyBase.Tables.Add(New generalholdingView1DataTable(dataSet.Tables.Item("generalholdingView1")))
                End If
                If (Not dataSet.Tables.Item("generalentity") Is Nothing) Then
                    MyBase.Tables.Add(New generalentityDataTable(dataSet.Tables.Item("generalentity")))
                End If
                If (Not dataSet.Tables.Item("STCostTypeView1") Is Nothing) Then
                    MyBase.Tables.Add(New STCostTypeView1DataTable(dataSet.Tables.Item("STCostTypeView1")))
                End If
                If (Not dataSet.Tables.Item("GeneralAddress") Is Nothing) Then
                    MyBase.Tables.Add(New GeneralAddressDataTable(dataSet.Tables.Item("GeneralAddress")))
                End If
                If (Not dataSet.Tables.Item("generalentityView1") Is Nothing) Then
                    MyBase.Tables.Add(New generalentityView1DataTable(dataSet.Tables.Item("generalentityView1")))
                End If
                If (Not dataSet.Tables.Item("PayMethod") Is Nothing) Then
                    MyBase.Tables.Add(New PayMethodDataTable(dataSet.Tables.Item("PayMethod")))
                End If
                Me.DataSetName = dataSet.DataSetName
                Me.Prefix = dataSet.Prefix
                Me.Namespace = dataSet.Namespace
                Me.Locale = dataSet.Locale
                Me.CaseSensitive = dataSet.CaseSensitive
                Me.EnforceConstraints = dataSet.EnforceConstraints
                Me.Merge(dataSet, False, MissingSchemaAction.Add)
                Me.InitVars
            Else
                Me.ReadXml(reader)
                Me.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Private Sub SchemaChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
            If (e.Action = CollectionChangeAction.Remove) Then
                Me.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeCashBank() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeCashBankAccount() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeCashBankCreditLine() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeCRMcountry() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeGeneralAddress() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralcomment() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeGeneralCurrencyView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneraldesctranslation() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralentity() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralentityView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralglobalcode() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralglobalcode1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralglobalcodeType() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralglobalparameter() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralholding() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralholdingView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializePayMethod() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeSTCostTypeView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemcurrency() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemcurrencyexrate() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemlanguagecode() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property CashBank As CashBankDataTable
            Get
                Return Me.tableCashBank
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property CashBankAccount As CashBankAccountDataTable
            Get
                Return Me.tableCashBankAccount
            End Get
        End Property

        <DebuggerNonUserCode, Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property CashBankCreditLine As CashBankCreditLineDataTable
            Get
                Return Me.tableCashBankCreditLine
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property CRMcountry As CRMcountryDataTable
            Get
                Return Me.tableCRMcountry
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property GeneralAddress As GeneralAddressDataTable
            Get
                Return Me.tableGeneralAddress
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property generalcomment As generalcommentDataTable
            Get
                Return Me.tablegeneralcomment
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property GeneralCurrencyView1 As GeneralCurrencyView1DataTable
            Get
                Return Me.tableGeneralCurrencyView1
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generaldesctranslation As generaldesctranslationDataTable
            Get
                Return Me.tablegeneraldesctranslation
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property generalentity As generalentityDataTable
            Get
                Return Me.tablegeneralentity
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property generalentityView1 As generalentityView1DataTable
            Get
                Return Me.tablegeneralentityView1
            End Get
        End Property

        <DebuggerNonUserCode, Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalglobalcode As generalglobalcodeDataTable
            Get
                Return Me.tablegeneralglobalcode
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property generalglobalcode1 As generalglobalcode1DataTable
            Get
                Return Me.tablegeneralglobalcode1
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property generalglobalcodeType As generalglobalcodeTypeDataTable
            Get
                Return Me.tablegeneralglobalcodeType
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property generalglobalparameter As generalglobalparameterDataTable
            Get
                Return Me.tablegeneralglobalparameter
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalholding As generalholdingDataTable
            Get
                Return Me.tablegeneralholding
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalholdingView1 As generalholdingView1DataTable
            Get
                Return Me.tablegeneralholdingView1
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property PayMethod As PayMethodDataTable
            Get
                Return Me.tablePayMethod
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property Relations As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True), DebuggerNonUserCode> _
        Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(ByVal Value As SchemaSerializationMode)
                Me._schemaSerializationMode = Value
            End Set
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property STCostTypeView1 As STCostTypeView1DataTable
            Get
                Return Me.tableSTCostTypeView1
            End Get
        End Property

        <DebuggerNonUserCode, Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemcurrency As systemcurrencyDataTable
            Get
                Return Me.tablesystemcurrency
            End Get
        End Property

        <DebuggerNonUserCode, Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemcurrencyexrate As systemcurrencyexrateDataTable
            Get
                Return Me.tablesystemcurrencyexrate
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemlanguagecode As systemlanguagecodeDataTable
            Get
                Return Me.tablesystemlanguagecode
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode> _
        Public ReadOnly Property Tables As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private _schemaSerializationMode As SchemaSerializationMode
        Private tableCashBank As CashBankDataTable
        Private tableCashBankAccount As CashBankAccountDataTable
        Private tableCashBankCreditLine As CashBankCreditLineDataTable
        Private tableCRMcountry As CRMcountryDataTable
        Private tableGeneralAddress As GeneralAddressDataTable
        Private tablegeneralcomment As generalcommentDataTable
        Private tableGeneralCurrencyView1 As GeneralCurrencyView1DataTable
        Private tablegeneraldesctranslation As generaldesctranslationDataTable
        Private tablegeneralentity As generalentityDataTable
        Private tablegeneralentityView1 As generalentityView1DataTable
        Private tablegeneralglobalcode As generalglobalcodeDataTable
        Private tablegeneralglobalcode1 As generalglobalcode1DataTable
        Private tablegeneralglobalcodeType As generalglobalcodeTypeDataTable
        Private tablegeneralglobalparameter As generalglobalparameterDataTable
        Private tablegeneralholding As generalholdingDataTable
        Private tablegeneralholdingView1 As generalholdingView1DataTable
        Private tablePayMethod As PayMethodDataTable
        Private tableSTCostTypeView1 As STCostTypeView1DataTable
        Private tablesystemcurrency As systemcurrencyDataTable
        Private tablesystemcurrencyexrate As systemcurrencyexrateDataTable
        Private tablesystemlanguagecode As systemlanguagecodeDataTable

        ' Nested Types
        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class CashBankAccountDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event CashBankAccountRowChanged As CashBankAccountRowChangeEventHandler
            Public Event CashBankAccountRowChanging As CashBankAccountRowChangeEventHandler
            Public Event CashBankAccountRowDeleted As CashBankAccountRowChangeEventHandler
            Public Event CashBankAccountRowDeleting As CashBankAccountRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = CashBankAccountDataTable.__ENCList
                SyncLock list
                    CashBankAccountDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "CashBankAccount"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = CashBankAccountDataTable.__ENCList
                SyncLock list
                    CashBankAccountDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = CashBankAccountDataTable.__ENCList
                SyncLock list
                    CashBankAccountDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddCashBankAccountRow(ByVal row As CashBankAccountRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddCashBankAccountRow(ByVal BankAccountID As Integer, ByVal BankID As Integer, ByVal SystemType As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String, ByVal Category As String, ByVal SubCategory As String, ByVal IBAN As String, ByVal UserType As String, ByVal LimitAmount As Decimal, ByVal AcctNumber As String, ByVal InterCo As Integer) As CashBankAccountRow
                Dim row As CashBankAccountRow = DirectCast(Me.NewRow, CashBankAccountRow)
                row.ItemArray = New Object() { BankAccountID, BankID, SystemType, Name, Description, CurrCode, Category, SubCategory, IBAN, UserType, LimitAmount, AcctNumber, InterCo }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As CashBankAccountDataTable = DirectCast(MyBase.Clone, CashBankAccountDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New CashBankAccountDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByBankAccountID(ByVal BankAccountID As Integer) As CashBankAccountRow
                Return DirectCast(Me.Rows.Find(New Object() { BankAccountID }), CashBankAccountRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(CashBankAccountRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "CashBankAccountDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnBankAccountID = New DataColumn("BankAccountID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankAccountID)
                Me.columnBankID = New DataColumn("BankID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankID)
                Me.columnSystemType = New DataColumn("SystemType", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSystemType)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnCategory = New DataColumn("Category", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCategory)
                Me.columnSubCategory = New DataColumn("SubCategory", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSubCategory)
                Me.columnIBAN = New DataColumn("IBAN", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnIBAN)
                Me.columnUserType = New DataColumn("UserType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserType)
                Me.columnLimitAmount = New DataColumn("LimitAmount", GetType(Decimal), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLimitAmount)
                Me.columnAcctNumber = New DataColumn("AcctNumber", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAcctNumber)
                Me.columnInterCo = New DataColumn("InterCo", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnInterCo)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey12", New DataColumn() { Me.columnBankAccountID }, True))
                Me.columnBankAccountID.AllowDBNull = False
                Me.columnBankAccountID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnBankAccountID = MyBase.Columns.Item("BankAccountID")
                Me.columnBankID = MyBase.Columns.Item("BankID")
                Me.columnSystemType = MyBase.Columns.Item("SystemType")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnCategory = MyBase.Columns.Item("Category")
                Me.columnSubCategory = MyBase.Columns.Item("SubCategory")
                Me.columnIBAN = MyBase.Columns.Item("IBAN")
                Me.columnUserType = MyBase.Columns.Item("UserType")
                Me.columnLimitAmount = MyBase.Columns.Item("LimitAmount")
                Me.columnAcctNumber = MyBase.Columns.Item("AcctNumber")
                Me.columnInterCo = MyBase.Columns.Item("InterCo")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewCashBankAccountRow() As CashBankAccountRow
                Return DirectCast(Me.NewRow, CashBankAccountRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New CashBankAccountRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.CashBankAccountRowChangedEvent Is Nothing) Then
                    Dim cashBankAccountRowChangedEvent As CashBankAccountRowChangeEventHandler = Me.CashBankAccountRowChangedEvent
                    If (Not cashBankAccountRowChangedEvent Is Nothing) Then
                        cashBankAccountRowChangedEvent.Invoke(Me, New CashBankAccountRowChangeEvent(DirectCast(e.Row, CashBankAccountRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.CashBankAccountRowChangingEvent Is Nothing) Then
                    Dim cashBankAccountRowChangingEvent As CashBankAccountRowChangeEventHandler = Me.CashBankAccountRowChangingEvent
                    If (Not cashBankAccountRowChangingEvent Is Nothing) Then
                        cashBankAccountRowChangingEvent.Invoke(Me, New CashBankAccountRowChangeEvent(DirectCast(e.Row, CashBankAccountRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.CashBankAccountRowDeletedEvent Is Nothing) Then
                    Dim cashBankAccountRowDeletedEvent As CashBankAccountRowChangeEventHandler = Me.CashBankAccountRowDeletedEvent
                    If (Not cashBankAccountRowDeletedEvent Is Nothing) Then
                        cashBankAccountRowDeletedEvent.Invoke(Me, New CashBankAccountRowChangeEvent(DirectCast(e.Row, CashBankAccountRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.CashBankAccountRowDeletingEvent Is Nothing) Then
                    Dim cashBankAccountRowDeletingEvent As CashBankAccountRowChangeEventHandler = Me.CashBankAccountRowDeletingEvent
                    If (Not cashBankAccountRowDeletingEvent Is Nothing) Then
                        cashBankAccountRowDeletingEvent.Invoke(Me, New CashBankAccountRowChangeEvent(DirectCast(e.Row, CashBankAccountRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveCashBankAccountRow(ByVal row As CashBankAccountRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AcctNumberColumn As DataColumn
                Get
                    Return Me.columnAcctNumber
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankAccountIDColumn As DataColumn
                Get
                    Return Me.columnBankAccountID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankIDColumn As DataColumn
                Get
                    Return Me.columnBankID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CategoryColumn As DataColumn
                Get
                    Return Me.columnCategory
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property IBANColumn As DataColumn
                Get
                    Return Me.columnIBAN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property InterCoColumn As DataColumn
                Get
                    Return Me.columnInterCo
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As CashBankAccountRow
                Get
                    Return DirectCast(Me.Rows.Item(index), CashBankAccountRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LimitAmountColumn As DataColumn
                Get
                    Return Me.columnLimitAmount
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SubCategoryColumn As DataColumn
                Get
                    Return Me.columnSubCategory
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SystemTypeColumn As DataColumn
                Get
                    Return Me.columnSystemType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserTypeColumn As DataColumn
                Get
                    Return Me.columnUserType
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAcctNumber As DataColumn
            Private columnBankAccountID As DataColumn
            Private columnBankID As DataColumn
            Private columnCategory As DataColumn
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnIBAN As DataColumn
            Private columnInterCo As DataColumn
            Private columnLimitAmount As DataColumn
            Private columnName As DataColumn
            Private columnSubCategory As DataColumn
            Private columnSystemType As DataColumn
            Private columnUserType As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankAccountRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableCashBankAccount = DirectCast(Me.Table, CashBankAccountDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAcctNumberNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.AcctNumberColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBankIDNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.BankIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCategoryNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.CategoryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsIBANNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.IBANColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsInterCoNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.InterCoColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLimitAmountNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.LimitAmountColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSubCategoryNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.SubCategoryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSystemTypeNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.SystemTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserTypeNull() As Boolean
                Return Me.IsNull(Me.tableCashBankAccount.UserTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAcctNumberNull()
                Me.Item(Me.tableCashBankAccount.AcctNumberColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBankIDNull()
                Me.Item(Me.tableCashBankAccount.BankIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCategoryNull()
                Me.Item(Me.tableCashBankAccount.CategoryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tableCashBankAccount.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tableCashBankAccount.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetIBANNull()
                Me.Item(Me.tableCashBankAccount.IBANColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetInterCoNull()
                Me.Item(Me.tableCashBankAccount.InterCoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLimitAmountNull()
                Me.Item(Me.tableCashBankAccount.LimitAmountColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tableCashBankAccount.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSubCategoryNull()
                Me.Item(Me.tableCashBankAccount.SubCategoryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSystemTypeNull()
                Me.Item(Me.tableCashBankAccount.SystemTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserTypeNull()
                Me.Item(Me.tableCashBankAccount.UserTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AcctNumber As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.AcctNumberColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AcctNumber' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.AcctNumberColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankAccountID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableCashBankAccount.BankAccountIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankAccount.BankAccountIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBankAccount.BankIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BankID' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankAccount.BankIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Category As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.CategoryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Category' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.CategoryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property IBAN As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.IBANColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'IBAN' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.IBANColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property InterCo As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBankAccount.InterCoColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'InterCo' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankAccount.InterCoColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property LimitAmount As Decimal
                Get
                    Dim num As Decimal
                    Try 
                        num = Conversions.ToDecimal(Me.Item(Me.tableCashBankAccount.LimitAmountColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'LimitAmount' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Decimal)
                    Me.Item(Me.tableCashBankAccount.LimitAmountColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SubCategory As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.SubCategoryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SubCategory' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.SubCategoryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SystemType As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBankAccount.SystemTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SystemType' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankAccount.SystemTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankAccount.UserTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserType' in table 'CashBankAccount' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankAccount.UserTypeColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableCashBankAccount As CashBankAccountDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankAccountRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As CashBankAccountRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As CashBankAccountRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As CashBankAccountRow
        End Class

        Public Delegate Sub CashBankAccountRowChangeEventHandler(ByVal sender As Object, ByVal e As CashBankAccountRowChangeEvent)

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class CashBankCreditLineDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event CashBankCreditLineRowChanged As CashBankCreditLineRowChangeEventHandler
            Public Event CashBankCreditLineRowChanging As CashBankCreditLineRowChangeEventHandler
            Public Event CashBankCreditLineRowDeleted As CashBankCreditLineRowChangeEventHandler
            Public Event CashBankCreditLineRowDeleting As CashBankCreditLineRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = CashBankCreditLineDataTable.__ENCList
                SyncLock list
                    CashBankCreditLineDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "CashBankCreditLine"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = CashBankCreditLineDataTable.__ENCList
                SyncLock list
                    CashBankCreditLineDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = CashBankCreditLineDataTable.__ENCList
                SyncLock list
                    CashBankCreditLineDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddCashBankCreditLineRow(ByVal row As CashBankCreditLineRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddCashBankCreditLineRow(ByVal CreditLineID As Integer, ByVal BankID As Integer, ByVal Name As String, ByVal CreditLineType As String, ByVal Amount As Decimal) As CashBankCreditLineRow
                Dim row As CashBankCreditLineRow = DirectCast(Me.NewRow, CashBankCreditLineRow)
                row.ItemArray = New Object() { CreditLineID, BankID, Name, CreditLineType, Amount }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As CashBankCreditLineDataTable = DirectCast(MyBase.Clone, CashBankCreditLineDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New CashBankCreditLineDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCreditLineID(ByVal CreditLineID As Integer) As CashBankCreditLineRow
                Return DirectCast(Me.Rows.Find(New Object() { CreditLineID }), CashBankCreditLineRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(CashBankCreditLineRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "CashBankCreditLineDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCreditLineID = New DataColumn("CreditLineID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCreditLineID)
                Me.columnBankID = New DataColumn("BankID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnCreditLineType = New DataColumn("CreditLineType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCreditLineType)
                Me.columnAmount = New DataColumn("Amount", GetType(Decimal), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAmount)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey13", New DataColumn() { Me.columnCreditLineID }, True))
                Me.columnCreditLineID.AllowDBNull = False
                Me.columnCreditLineID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCreditLineID = MyBase.Columns.Item("CreditLineID")
                Me.columnBankID = MyBase.Columns.Item("BankID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnCreditLineType = MyBase.Columns.Item("CreditLineType")
                Me.columnAmount = MyBase.Columns.Item("Amount")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewCashBankCreditLineRow() As CashBankCreditLineRow
                Return DirectCast(Me.NewRow, CashBankCreditLineRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New CashBankCreditLineRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.CashBankCreditLineRowChangedEvent Is Nothing) Then
                    Dim cashBankCreditLineRowChangedEvent As CashBankCreditLineRowChangeEventHandler = Me.CashBankCreditLineRowChangedEvent
                    If (Not cashBankCreditLineRowChangedEvent Is Nothing) Then
                        cashBankCreditLineRowChangedEvent.Invoke(Me, New CashBankCreditLineRowChangeEvent(DirectCast(e.Row, CashBankCreditLineRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.CashBankCreditLineRowChangingEvent Is Nothing) Then
                    Dim cashBankCreditLineRowChangingEvent As CashBankCreditLineRowChangeEventHandler = Me.CashBankCreditLineRowChangingEvent
                    If (Not cashBankCreditLineRowChangingEvent Is Nothing) Then
                        cashBankCreditLineRowChangingEvent.Invoke(Me, New CashBankCreditLineRowChangeEvent(DirectCast(e.Row, CashBankCreditLineRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.CashBankCreditLineRowDeletedEvent Is Nothing) Then
                    Dim cashBankCreditLineRowDeletedEvent As CashBankCreditLineRowChangeEventHandler = Me.CashBankCreditLineRowDeletedEvent
                    If (Not cashBankCreditLineRowDeletedEvent Is Nothing) Then
                        cashBankCreditLineRowDeletedEvent.Invoke(Me, New CashBankCreditLineRowChangeEvent(DirectCast(e.Row, CashBankCreditLineRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.CashBankCreditLineRowDeletingEvent Is Nothing) Then
                    Dim cashBankCreditLineRowDeletingEvent As CashBankCreditLineRowChangeEventHandler = Me.CashBankCreditLineRowDeletingEvent
                    If (Not cashBankCreditLineRowDeletingEvent Is Nothing) Then
                        cashBankCreditLineRowDeletingEvent.Invoke(Me, New CashBankCreditLineRowChangeEvent(DirectCast(e.Row, CashBankCreditLineRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveCashBankCreditLineRow(ByVal row As CashBankCreditLineRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AmountColumn As DataColumn
                Get
                    Return Me.columnAmount
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankIDColumn As DataColumn
                Get
                    Return Me.columnBankID
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CreditLineIDColumn As DataColumn
                Get
                    Return Me.columnCreditLineID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CreditLineTypeColumn As DataColumn
                Get
                    Return Me.columnCreditLineType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As CashBankCreditLineRow
                Get
                    Return DirectCast(Me.Rows.Item(index), CashBankCreditLineRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAmount As DataColumn
            Private columnBankID As DataColumn
            Private columnCreditLineID As DataColumn
            Private columnCreditLineType As DataColumn
            Private columnName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankCreditLineRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableCashBankCreditLine = DirectCast(Me.Table, CashBankCreditLineDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAmountNull() As Boolean
                Return Me.IsNull(Me.tableCashBankCreditLine.AmountColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBankIDNull() As Boolean
                Return Me.IsNull(Me.tableCashBankCreditLine.BankIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCreditLineTypeNull() As Boolean
                Return Me.IsNull(Me.tableCashBankCreditLine.CreditLineTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableCashBankCreditLine.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAmountNull()
                Me.Item(Me.tableCashBankCreditLine.AmountColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBankIDNull()
                Me.Item(Me.tableCashBankCreditLine.BankIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCreditLineTypeNull()
                Me.Item(Me.tableCashBankCreditLine.CreditLineTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tableCashBankCreditLine.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Amount As Decimal
                Get
                    Dim num As Decimal
                    Try 
                        num = Conversions.ToDecimal(Me.Item(Me.tableCashBankCreditLine.AmountColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Amount' in table 'CashBankCreditLine' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Decimal)
                    Me.Item(Me.tableCashBankCreditLine.AmountColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBankCreditLine.BankIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BankID' in table 'CashBankCreditLine' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankCreditLine.BankIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CreditLineID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableCashBankCreditLine.CreditLineIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBankCreditLine.CreditLineIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CreditLineType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankCreditLine.CreditLineTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CreditLineType' in table 'CashBankCreditLine' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankCreditLine.CreditLineTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBankCreditLine.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'CashBankCreditLine' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBankCreditLine.NameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableCashBankCreditLine As CashBankCreditLineDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankCreditLineRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As CashBankCreditLineRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As CashBankCreditLineRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As CashBankCreditLineRow
        End Class

        Public Delegate Sub CashBankCreditLineRowChangeEventHandler(ByVal sender As Object, ByVal e As CashBankCreditLineRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event CashBankRowChanged As CashBankRowChangeEventHandler
            Public Event CashBankRowChanging As CashBankRowChangeEventHandler
            Public Event CashBankRowDeleted As CashBankRowChangeEventHandler
            Public Event CashBankRowDeleting As CashBankRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = CashBankDataTable.__ENCList
                SyncLock list
                    CashBankDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "CashBank"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = CashBankDataTable.__ENCList
                SyncLock list
                    CashBankDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = CashBankDataTable.__ENCList
                SyncLock list
                    CashBankDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddCashBankRow(ByVal row As CashBankRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddCashBankRow(ByVal BankID As Integer, ByVal Name As String, ByVal EntityID As Integer, ByVal Description As String, ByVal Swift As String, ByVal CreditType As String, ByVal CreditAmount As Decimal, ByVal AddrID As Integer) As CashBankRow
                Dim row As CashBankRow = DirectCast(Me.NewRow, CashBankRow)
                row.ItemArray = New Object() { BankID, Name, EntityID, Description, Swift, CreditType, CreditAmount, AddrID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As CashBankDataTable = DirectCast(MyBase.Clone, CashBankDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New CashBankDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByBankID(ByVal BankID As Integer) As CashBankRow
                Return DirectCast(Me.Rows.Find(New Object() { BankID }), CashBankRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(CashBankRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "CashBankDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnBankID = New DataColumn("BankID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnSwift = New DataColumn("Swift", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSwift)
                Me.columnCreditType = New DataColumn("CreditType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCreditType)
                Me.columnCreditAmount = New DataColumn("CreditAmount", GetType(Decimal), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCreditAmount)
                Me.columnAddrID = New DataColumn("AddrID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddrID)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey11", New DataColumn() { Me.columnBankID }, True))
                Me.columnBankID.AllowDBNull = False
                Me.columnBankID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnBankID = MyBase.Columns.Item("BankID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnSwift = MyBase.Columns.Item("Swift")
                Me.columnCreditType = MyBase.Columns.Item("CreditType")
                Me.columnCreditAmount = MyBase.Columns.Item("CreditAmount")
                Me.columnAddrID = MyBase.Columns.Item("AddrID")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewCashBankRow() As CashBankRow
                Return DirectCast(Me.NewRow, CashBankRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New CashBankRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.CashBankRowChangedEvent Is Nothing) Then
                    Dim cashBankRowChangedEvent As CashBankRowChangeEventHandler = Me.CashBankRowChangedEvent
                    If (Not cashBankRowChangedEvent Is Nothing) Then
                        cashBankRowChangedEvent.Invoke(Me, New CashBankRowChangeEvent(DirectCast(e.Row, CashBankRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.CashBankRowChangingEvent Is Nothing) Then
                    Dim cashBankRowChangingEvent As CashBankRowChangeEventHandler = Me.CashBankRowChangingEvent
                    If (Not cashBankRowChangingEvent Is Nothing) Then
                        cashBankRowChangingEvent.Invoke(Me, New CashBankRowChangeEvent(DirectCast(e.Row, CashBankRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.CashBankRowDeletedEvent Is Nothing) Then
                    Dim cashBankRowDeletedEvent As CashBankRowChangeEventHandler = Me.CashBankRowDeletedEvent
                    If (Not cashBankRowDeletedEvent Is Nothing) Then
                        cashBankRowDeletedEvent.Invoke(Me, New CashBankRowChangeEvent(DirectCast(e.Row, CashBankRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.CashBankRowDeletingEvent Is Nothing) Then
                    Dim cashBankRowDeletingEvent As CashBankRowChangeEventHandler = Me.CashBankRowDeletingEvent
                    If (Not cashBankRowDeletingEvent Is Nothing) Then
                        cashBankRowDeletingEvent.Invoke(Me, New CashBankRowChangeEvent(DirectCast(e.Row, CashBankRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveCashBankRow(ByVal row As CashBankRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AddrIDColumn As DataColumn
                Get
                    Return Me.columnAddrID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankIDColumn As DataColumn
                Get
                    Return Me.columnBankID
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CreditAmountColumn As DataColumn
                Get
                    Return Me.columnCreditAmount
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CreditTypeColumn As DataColumn
                Get
                    Return Me.columnCreditType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As CashBankRow
                Get
                    Return DirectCast(Me.Rows.Item(index), CashBankRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SwiftColumn As DataColumn
                Get
                    Return Me.columnSwift
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAddrID As DataColumn
            Private columnBankID As DataColumn
            Private columnCreditAmount As DataColumn
            Private columnCreditType As DataColumn
            Private columnDescription As DataColumn
            Private columnEntityID As DataColumn
            Private columnName As DataColumn
            Private columnSwift As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableCashBank = DirectCast(Me.Table, CashBankDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAddrIDNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.AddrIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCreditAmountNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.CreditAmountColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCreditTypeNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.CreditTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEntityIDNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.EntityIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSwiftNull() As Boolean
                Return Me.IsNull(Me.tableCashBank.SwiftColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAddrIDNull()
                Me.Item(Me.tableCashBank.AddrIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCreditAmountNull()
                Me.Item(Me.tableCashBank.CreditAmountColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCreditTypeNull()
                Me.Item(Me.tableCashBank.CreditTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tableCashBank.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEntityIDNull()
                Me.Item(Me.tableCashBank.EntityIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tableCashBank.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSwiftNull()
                Me.Item(Me.tableCashBank.SwiftColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AddrID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBank.AddrIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddrID' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBank.AddrIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableCashBank.BankIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBank.BankIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CreditAmount As Decimal
                Get
                    Dim num As Decimal
                    Try 
                        num = Conversions.ToDecimal(Me.Item(Me.tableCashBank.CreditAmountColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CreditAmount' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Decimal)
                    Me.Item(Me.tableCashBank.CreditAmountColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CreditType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBank.CreditTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CreditType' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBank.CreditTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBank.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBank.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCashBank.EntityIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EntityID' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCashBank.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBank.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBank.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Swift As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCashBank.SwiftColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Swift' in table 'CashBank' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCashBank.SwiftColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableCashBank As CashBankDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CashBankRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As CashBankRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As CashBankRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As CashBankRow
        End Class

        Public Delegate Sub CashBankRowChangeEventHandler(ByVal sender As Object, ByVal e As CashBankRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class CRMcountryDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event CRMcountryRowChanged As CRMcountryRowChangeEventHandler
            Public Event CRMcountryRowChanging As CRMcountryRowChangeEventHandler
            Public Event CRMcountryRowDeleted As CRMcountryRowChangeEventHandler
            Public Event CRMcountryRowDeleting As CRMcountryRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = CRMcountryDataTable.__ENCList
                SyncLock list
                    CRMcountryDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "CRMcountry"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = CRMcountryDataTable.__ENCList
                SyncLock list
                    CRMcountryDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = CRMcountryDataTable.__ENCList
                SyncLock list
                    CRMcountryDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddCRMcountryRow(ByVal row As CRMcountryRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddCRMcountryRow(ByVal Code As String, ByVal Name As String, ByVal EUCode As String, ByVal IntrastatCode As String, ByVal AddrFormat As Integer, ByVal AddrContactFormat As Integer, ByVal ISOCode As String) As CRMcountryRow
                Dim row As CRMcountryRow = DirectCast(Me.NewRow, CRMcountryRow)
                row.ItemArray = New Object() { Code, Name, EUCode, IntrastatCode, AddrFormat, AddrContactFormat, ISOCode }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As CRMcountryDataTable = DirectCast(MyBase.Clone, CRMcountryDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New CRMcountryDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCode(ByVal Code As String) As CRMcountryRow
                Return DirectCast(Me.Rows.Find(New Object() { Code }), CRMcountryRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(CRMcountryRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "CRMcountryDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCode = New DataColumn("Code", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCode)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnEUCode = New DataColumn("EUCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEUCode)
                Me.columnIntrastatCode = New DataColumn("IntrastatCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnIntrastatCode)
                Me.columnAddrFormat = New DataColumn("AddrFormat", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddrFormat)
                Me.columnAddrContactFormat = New DataColumn("AddrContactFormat", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddrContactFormat)
                Me.columnISOCode = New DataColumn("ISOCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnISOCode)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey16", New DataColumn() { Me.columnCode }, True))
                Me.columnCode.AllowDBNull = False
                Me.columnCode.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCode = MyBase.Columns.Item("Code")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnEUCode = MyBase.Columns.Item("EUCode")
                Me.columnIntrastatCode = MyBase.Columns.Item("IntrastatCode")
                Me.columnAddrFormat = MyBase.Columns.Item("AddrFormat")
                Me.columnAddrContactFormat = MyBase.Columns.Item("AddrContactFormat")
                Me.columnISOCode = MyBase.Columns.Item("ISOCode")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewCRMcountryRow() As CRMcountryRow
                Return DirectCast(Me.NewRow, CRMcountryRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New CRMcountryRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.CRMcountryRowChangedEvent Is Nothing) Then
                    Dim cRMcountryRowChangedEvent As CRMcountryRowChangeEventHandler = Me.CRMcountryRowChangedEvent
                    If (Not cRMcountryRowChangedEvent Is Nothing) Then
                        cRMcountryRowChangedEvent.Invoke(Me, New CRMcountryRowChangeEvent(DirectCast(e.Row, CRMcountryRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.CRMcountryRowChangingEvent Is Nothing) Then
                    Dim cRMcountryRowChangingEvent As CRMcountryRowChangeEventHandler = Me.CRMcountryRowChangingEvent
                    If (Not cRMcountryRowChangingEvent Is Nothing) Then
                        cRMcountryRowChangingEvent.Invoke(Me, New CRMcountryRowChangeEvent(DirectCast(e.Row, CRMcountryRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.CRMcountryRowDeletedEvent Is Nothing) Then
                    Dim cRMcountryRowDeletedEvent As CRMcountryRowChangeEventHandler = Me.CRMcountryRowDeletedEvent
                    If (Not cRMcountryRowDeletedEvent Is Nothing) Then
                        cRMcountryRowDeletedEvent.Invoke(Me, New CRMcountryRowChangeEvent(DirectCast(e.Row, CRMcountryRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.CRMcountryRowDeletingEvent Is Nothing) Then
                    Dim cRMcountryRowDeletingEvent As CRMcountryRowChangeEventHandler = Me.CRMcountryRowDeletingEvent
                    If (Not cRMcountryRowDeletingEvent Is Nothing) Then
                        cRMcountryRowDeletingEvent.Invoke(Me, New CRMcountryRowChangeEvent(DirectCast(e.Row, CRMcountryRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveCRMcountryRow(ByVal row As CRMcountryRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AddrContactFormatColumn As DataColumn
                Get
                    Return Me.columnAddrContactFormat
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AddrFormatColumn As DataColumn
                Get
                    Return Me.columnAddrFormat
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeColumn As DataColumn
                Get
                    Return Me.columnCode
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EUCodeColumn As DataColumn
                Get
                    Return Me.columnEUCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property IntrastatCodeColumn As DataColumn
                Get
                    Return Me.columnIntrastatCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ISOCodeColumn As DataColumn
                Get
                    Return Me.columnISOCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As CRMcountryRow
                Get
                    Return DirectCast(Me.Rows.Item(index), CRMcountryRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAddrContactFormat As DataColumn
            Private columnAddrFormat As DataColumn
            Private columnCode As DataColumn
            Private columnEUCode As DataColumn
            Private columnIntrastatCode As DataColumn
            Private columnISOCode As DataColumn
            Private columnName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CRMcountryRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableCRMcountry = DirectCast(Me.Table, CRMcountryDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAddrContactFormatNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.AddrContactFormatColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAddrFormatNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.AddrFormatColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEUCodeNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.EUCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsIntrastatCodeNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.IntrastatCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsISOCodeNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.ISOCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableCRMcountry.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAddrContactFormatNull()
                Me.Item(Me.tableCRMcountry.AddrContactFormatColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAddrFormatNull()
                Me.Item(Me.tableCRMcountry.AddrFormatColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEUCodeNull()
                Me.Item(Me.tableCRMcountry.EUCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetIntrastatCodeNull()
                Me.Item(Me.tableCRMcountry.IntrastatCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetISOCodeNull()
                Me.Item(Me.tableCRMcountry.ISOCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tableCRMcountry.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AddrContactFormat As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCRMcountry.AddrContactFormatColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddrContactFormat' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCRMcountry.AddrContactFormatColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property AddrFormat As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableCRMcountry.AddrFormatColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddrFormat' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableCRMcountry.AddrFormatColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Code As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableCRMcountry.CodeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCRMcountry.CodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EUCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCRMcountry.EUCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EUCode' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCRMcountry.EUCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property IntrastatCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCRMcountry.IntrastatCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'IntrastatCode' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCRMcountry.IntrastatCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ISOCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCRMcountry.ISOCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ISOCode' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCRMcountry.ISOCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableCRMcountry.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'CRMcountry' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableCRMcountry.NameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableCRMcountry As CRMcountryDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class CRMcountryRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As CRMcountryRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As CRMcountryRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As CRMcountryRow
        End Class

        Public Delegate Sub CRMcountryRowChangeEventHandler(ByVal sender As Object, ByVal e As CRMcountryRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class GeneralAddressDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralAddressRowChanged As GeneralAddressRowChangeEventHandler
            Public Event GeneralAddressRowChanging As GeneralAddressRowChangeEventHandler
            Public Event GeneralAddressRowDeleted As GeneralAddressRowChangeEventHandler
            Public Event GeneralAddressRowDeleting As GeneralAddressRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = GeneralAddressDataTable.__ENCList
                SyncLock list
                    GeneralAddressDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "GeneralAddress"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = GeneralAddressDataTable.__ENCList
                SyncLock list
                    GeneralAddressDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = GeneralAddressDataTable.__ENCList
                SyncLock list
                    GeneralAddressDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddGeneralAddressRow(ByVal row As GeneralAddressRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddGeneralAddressRow(ByVal AddrID As Integer, ByVal Name As String, ByVal FirstName As String, ByVal Description As String, ByVal Address1 As String, ByVal Address2 As String, ByVal ZIP As String, ByVal City As String, ByVal country As String, ByVal PersonYN As Integer, ByVal EntityYN As Boolean, ByVal BankYN As Boolean, ByVal EmployeeYN As Boolean, ByVal CustomerYN As Boolean, ByVal SupplierYN As Boolean, ByVal LocYN As Boolean, ByVal Lang As String, ByVal Phone1 As String, ByVal Phone2 As String, ByVal Phone3 As String, ByVal Fax1 As String, ByVal Fax2 As String, ByVal Fax3 As String, ByVal EMail1 As String, ByVal EMail2 As String, ByVal EMail3 As String, ByVal WebSite As String, ByVal EntityID As Integer, ByVal BankID As Integer, ByVal EmployeeID As Integer, ByVal CustomerID As Integer, ByVal SupplierID As Integer, ByVal Title As Integer, ByVal Gender As Integer, ByVal JobTitle As String, ByVal ManagerID As Integer, ByVal AssistantID As Integer, ByVal CompanyID As Integer, ByVal LocID As Integer, ByVal TaxNbr1 As String, ByVal TaxNbr2 As String, ByVal TaxNbr3 As String, ByVal countryCode As String, ByVal _Region As String) As GeneralAddressRow
                Dim row As GeneralAddressRow = DirectCast(Me.NewRow, GeneralAddressRow)
                row.ItemArray = New Object() { AddrID, Name, FirstName, Description, Address1, Address2, ZIP, City, country, PersonYN, EntityYN, BankYN, EmployeeYN, CustomerYN, SupplierYN, LocYN, Lang, Phone1, Phone2, Phone3, Fax1, Fax2, Fax3, EMail1, EMail2, EMail3, WebSite, EntityID, BankID, EmployeeID, CustomerID, SupplierID, Title, Gender, JobTitle, ManagerID, AssistantID, CompanyID, LocID, TaxNbr1, TaxNbr2, TaxNbr3, countryCode, _Region }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As GeneralAddressDataTable = DirectCast(MyBase.Clone, GeneralAddressDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralAddressDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByAddrID(ByVal AddrID As Integer) As GeneralAddressRow
                Return DirectCast(Me.Rows.Find(New Object() { AddrID }), GeneralAddressRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralAddressRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "GeneralAddressDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnAddrID = New DataColumn("AddrID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddrID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnFirstName = New DataColumn("FirstName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFirstName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnAddress1 = New DataColumn("Address1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddress1)
                Me.columnAddress2 = New DataColumn("Address2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddress2)
                Me.columnZIP = New DataColumn("ZIP", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnZIP)
                Me.columnCity = New DataColumn("City", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCity)
                Me.columncountry = New DataColumn("country", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columncountry)
                Me.columnPersonYN = New DataColumn("PersonYN", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPersonYN)
                Me.columnEntityYN = New DataColumn("EntityYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityYN)
                Me.columnBankYN = New DataColumn("BankYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankYN)
                Me.columnEmployeeYN = New DataColumn("EmployeeYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEmployeeYN)
                Me.columnCustomerYN = New DataColumn("CustomerYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCustomerYN)
                Me.columnSupplierYN = New DataColumn("SupplierYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSupplierYN)
                Me.columnLocYN = New DataColumn("LocYN", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLocYN)
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnPhone1 = New DataColumn("Phone1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPhone1)
                Me.columnPhone2 = New DataColumn("Phone2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPhone2)
                Me.columnPhone3 = New DataColumn("Phone3", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPhone3)
                Me.columnFax1 = New DataColumn("Fax1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFax1)
                Me.columnFax2 = New DataColumn("Fax2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFax2)
                Me.columnFax3 = New DataColumn("Fax3", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFax3)
                Me.columnEMail1 = New DataColumn("EMail1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEMail1)
                Me.columnEMail2 = New DataColumn("EMail2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEMail2)
                Me.columnEMail3 = New DataColumn("EMail3", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEMail3)
                Me.columnWebSite = New DataColumn("WebSite", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnWebSite)
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnBankID = New DataColumn("BankID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBankID)
                Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEmployeeID)
                Me.columnCustomerID = New DataColumn("CustomerID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCustomerID)
                Me.columnSupplierID = New DataColumn("SupplierID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSupplierID)
                Me.columnTitle = New DataColumn("Title", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTitle)
                Me.columnGender = New DataColumn("Gender", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnGender)
                Me.columnJobTitle = New DataColumn("JobTitle", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnJobTitle)
                Me.columnManagerID = New DataColumn("ManagerID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnManagerID)
                Me.columnAssistantID = New DataColumn("AssistantID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAssistantID)
                Me.columnCompanyID = New DataColumn("CompanyID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCompanyID)
                Me.columnLocID = New DataColumn("LocID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLocID)
                Me.columnTaxNbr1 = New DataColumn("TaxNbr1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTaxNbr1)
                Me.columnTaxNbr2 = New DataColumn("TaxNbr2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTaxNbr2)
                Me.columnTaxNbr3 = New DataColumn("TaxNbr3", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTaxNbr3)
                Me.columncountryCode = New DataColumn("countryCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columncountryCode)
                Me.column_Region = New DataColumn("Region", GetType(String), Nothing, MappingType.Element)
                Me.column_Region.ExtendedProperties.Add("Generator_ColumnPropNameInRow", "_Region")
                Me.column_Region.ExtendedProperties.Add("Generator_ColumnPropNameInTable", "_RegionColumn")
                Me.column_Region.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "column_Region")
                Me.column_Region.ExtendedProperties.Add("Generator_UserColumnName", "Region")
                MyBase.Columns.Add(Me.column_Region)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey7", New DataColumn() { Me.columnAddrID }, True))
                Me.columnAddrID.AllowDBNull = False
                Me.columnAddrID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnAddrID = MyBase.Columns.Item("AddrID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnFirstName = MyBase.Columns.Item("FirstName")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnAddress1 = MyBase.Columns.Item("Address1")
                Me.columnAddress2 = MyBase.Columns.Item("Address2")
                Me.columnZIP = MyBase.Columns.Item("ZIP")
                Me.columnCity = MyBase.Columns.Item("City")
                Me.columncountry = MyBase.Columns.Item("country")
                Me.columnPersonYN = MyBase.Columns.Item("PersonYN")
                Me.columnEntityYN = MyBase.Columns.Item("EntityYN")
                Me.columnBankYN = MyBase.Columns.Item("BankYN")
                Me.columnEmployeeYN = MyBase.Columns.Item("EmployeeYN")
                Me.columnCustomerYN = MyBase.Columns.Item("CustomerYN")
                Me.columnSupplierYN = MyBase.Columns.Item("SupplierYN")
                Me.columnLocYN = MyBase.Columns.Item("LocYN")
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnPhone1 = MyBase.Columns.Item("Phone1")
                Me.columnPhone2 = MyBase.Columns.Item("Phone2")
                Me.columnPhone3 = MyBase.Columns.Item("Phone3")
                Me.columnFax1 = MyBase.Columns.Item("Fax1")
                Me.columnFax2 = MyBase.Columns.Item("Fax2")
                Me.columnFax3 = MyBase.Columns.Item("Fax3")
                Me.columnEMail1 = MyBase.Columns.Item("EMail1")
                Me.columnEMail2 = MyBase.Columns.Item("EMail2")
                Me.columnEMail3 = MyBase.Columns.Item("EMail3")
                Me.columnWebSite = MyBase.Columns.Item("WebSite")
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnBankID = MyBase.Columns.Item("BankID")
                Me.columnEmployeeID = MyBase.Columns.Item("EmployeeID")
                Me.columnCustomerID = MyBase.Columns.Item("CustomerID")
                Me.columnSupplierID = MyBase.Columns.Item("SupplierID")
                Me.columnTitle = MyBase.Columns.Item("Title")
                Me.columnGender = MyBase.Columns.Item("Gender")
                Me.columnJobTitle = MyBase.Columns.Item("JobTitle")
                Me.columnManagerID = MyBase.Columns.Item("ManagerID")
                Me.columnAssistantID = MyBase.Columns.Item("AssistantID")
                Me.columnCompanyID = MyBase.Columns.Item("CompanyID")
                Me.columnLocID = MyBase.Columns.Item("LocID")
                Me.columnTaxNbr1 = MyBase.Columns.Item("TaxNbr1")
                Me.columnTaxNbr2 = MyBase.Columns.Item("TaxNbr2")
                Me.columnTaxNbr3 = MyBase.Columns.Item("TaxNbr3")
                Me.columncountryCode = MyBase.Columns.Item("countryCode")
                Me.column_Region = MyBase.Columns.Item("Region")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewGeneralAddressRow() As GeneralAddressRow
                Return DirectCast(Me.NewRow, GeneralAddressRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralAddressRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralAddressRowChangedEvent Is Nothing) Then
                    Dim generalAddressRowChangedEvent As GeneralAddressRowChangeEventHandler = Me.GeneralAddressRowChangedEvent
                    If (Not generalAddressRowChangedEvent Is Nothing) Then
                        generalAddressRowChangedEvent.Invoke(Me, New GeneralAddressRowChangeEvent(DirectCast(e.Row, GeneralAddressRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralAddressRowChangingEvent Is Nothing) Then
                    Dim generalAddressRowChangingEvent As GeneralAddressRowChangeEventHandler = Me.GeneralAddressRowChangingEvent
                    If (Not generalAddressRowChangingEvent Is Nothing) Then
                        generalAddressRowChangingEvent.Invoke(Me, New GeneralAddressRowChangeEvent(DirectCast(e.Row, GeneralAddressRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralAddressRowDeletedEvent Is Nothing) Then
                    Dim generalAddressRowDeletedEvent As GeneralAddressRowChangeEventHandler = Me.GeneralAddressRowDeletedEvent
                    If (Not generalAddressRowDeletedEvent Is Nothing) Then
                        generalAddressRowDeletedEvent.Invoke(Me, New GeneralAddressRowChangeEvent(DirectCast(e.Row, GeneralAddressRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralAddressRowDeletingEvent Is Nothing) Then
                    Dim generalAddressRowDeletingEvent As GeneralAddressRowChangeEventHandler = Me.GeneralAddressRowDeletingEvent
                    If (Not generalAddressRowDeletingEvent Is Nothing) Then
                        generalAddressRowDeletingEvent.Invoke(Me, New GeneralAddressRowChangeEvent(DirectCast(e.Row, GeneralAddressRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveGeneralAddressRow(ByVal row As GeneralAddressRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property _RegionColumn As DataColumn
                Get
                    Return Me.column_Region
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Address1Column As DataColumn
                Get
                    Return Me.columnAddress1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Address2Column As DataColumn
                Get
                    Return Me.columnAddress2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AddrIDColumn As DataColumn
                Get
                    Return Me.columnAddrID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AssistantIDColumn As DataColumn
                Get
                    Return Me.columnAssistantID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankIDColumn As DataColumn
                Get
                    Return Me.columnBankID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BankYNColumn As DataColumn
                Get
                    Return Me.columnBankYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CityColumn As DataColumn
                Get
                    Return Me.columnCity
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CompanyIDColumn As DataColumn
                Get
                    Return Me.columnCompanyID
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property countryCodeColumn As DataColumn
                Get
                    Return Me.columncountryCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property countryColumn As DataColumn
                Get
                    Return Me.columncountry
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CustomerIDColumn As DataColumn
                Get
                    Return Me.columnCustomerID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CustomerYNColumn As DataColumn
                Get
                    Return Me.columnCustomerYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EMail1Column As DataColumn
                Get
                    Return Me.columnEMail1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EMail2Column As DataColumn
                Get
                    Return Me.columnEMail2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EMail3Column As DataColumn
                Get
                    Return Me.columnEMail3
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EmployeeIDColumn As DataColumn
                Get
                    Return Me.columnEmployeeID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EmployeeYNColumn As DataColumn
                Get
                    Return Me.columnEmployeeYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityYNColumn As DataColumn
                Get
                    Return Me.columnEntityYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Fax1Column As DataColumn
                Get
                    Return Me.columnFax1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Fax2Column As DataColumn
                Get
                    Return Me.columnFax2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Fax3Column As DataColumn
                Get
                    Return Me.columnFax3
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FirstNameColumn As DataColumn
                Get
                    Return Me.columnFirstName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property GenderColumn As DataColumn
                Get
                    Return Me.columnGender
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralAddressRow
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralAddressRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property JobTitleColumn As DataColumn
                Get
                    Return Me.columnJobTitle
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LocIDColumn As DataColumn
                Get
                    Return Me.columnLocID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LocYNColumn As DataColumn
                Get
                    Return Me.columnLocYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ManagerIDColumn As DataColumn
                Get
                    Return Me.columnManagerID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property PersonYNColumn As DataColumn
                Get
                    Return Me.columnPersonYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Phone1Column As DataColumn
                Get
                    Return Me.columnPhone1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Phone2Column As DataColumn
                Get
                    Return Me.columnPhone2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Phone3Column As DataColumn
                Get
                    Return Me.columnPhone3
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SupplierIDColumn As DataColumn
                Get
                    Return Me.columnSupplierID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SupplierYNColumn As DataColumn
                Get
                    Return Me.columnSupplierYN
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TaxNbr1Column As DataColumn
                Get
                    Return Me.columnTaxNbr1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TaxNbr2Column As DataColumn
                Get
                    Return Me.columnTaxNbr2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TaxNbr3Column As DataColumn
                Get
                    Return Me.columnTaxNbr3
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TitleColumn As DataColumn
                Get
                    Return Me.columnTitle
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property WebSiteColumn As DataColumn
                Get
                    Return Me.columnWebSite
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ZIPColumn As DataColumn
                Get
                    Return Me.columnZIP
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private column_Region As DataColumn
            Private columnAddress1 As DataColumn
            Private columnAddress2 As DataColumn
            Private columnAddrID As DataColumn
            Private columnAssistantID As DataColumn
            Private columnBankID As DataColumn
            Private columnBankYN As DataColumn
            Private columnCity As DataColumn
            Private columnCompanyID As DataColumn
            Private columncountry As DataColumn
            Private columncountryCode As DataColumn
            Private columnCustomerID As DataColumn
            Private columnCustomerYN As DataColumn
            Private columnDescription As DataColumn
            Private columnEMail1 As DataColumn
            Private columnEMail2 As DataColumn
            Private columnEMail3 As DataColumn
            Private columnEmployeeID As DataColumn
            Private columnEmployeeYN As DataColumn
            Private columnEntityID As DataColumn
            Private columnEntityYN As DataColumn
            Private columnFax1 As DataColumn
            Private columnFax2 As DataColumn
            Private columnFax3 As DataColumn
            Private columnFirstName As DataColumn
            Private columnGender As DataColumn
            Private columnJobTitle As DataColumn
            Private columnLang As DataColumn
            Private columnLocID As DataColumn
            Private columnLocYN As DataColumn
            Private columnManagerID As DataColumn
            Private columnName As DataColumn
            Private columnPersonYN As DataColumn
            Private columnPhone1 As DataColumn
            Private columnPhone2 As DataColumn
            Private columnPhone3 As DataColumn
            Private columnSupplierID As DataColumn
            Private columnSupplierYN As DataColumn
            Private columnTaxNbr1 As DataColumn
            Private columnTaxNbr2 As DataColumn
            Private columnTaxNbr3 As DataColumn
            Private columnTitle As DataColumn
            Private columnWebSite As DataColumn
            Private columnZIP As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GeneralAddressRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralAddress = DirectCast(Me.Table, GeneralAddressDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Is_RegionNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress._RegionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAddress1Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Address1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAddress2Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Address2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAssistantIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.AssistantIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBankIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.BankIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBankYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.BankYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCityNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.CityColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCompanyIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.CompanyIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IscountryCodeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.countryCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IscountryNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.countryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCustomerIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.CustomerIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCustomerYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.CustomerYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEMail1Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EMail1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEMail2Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EMail2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEMail3Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EMail3Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEmployeeIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EmployeeIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEmployeeYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EmployeeYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEntityIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EntityIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEntityYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.EntityYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFax1Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Fax1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFax2Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Fax2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFax3Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Fax3Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFirstNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.FirstNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsGenderNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.GenderColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsJobTitleNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.JobTitleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLangNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.LangColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLocIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.LocIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLocYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.LocYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsManagerIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.ManagerIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPersonYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.PersonYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPhone1Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Phone1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPhone2Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Phone2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPhone3Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.Phone3Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSupplierIDNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.SupplierIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSupplierYNNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.SupplierYNColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTaxNbr1Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.TaxNbr1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTaxNbr2Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.TaxNbr2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTaxNbr3Null() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.TaxNbr3Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTitleNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.TitleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsWebSiteNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.WebSiteColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsZIPNull() As Boolean
                Return Me.IsNull(Me.tableGeneralAddress.ZIPColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub Set_RegionNull()
                Me.Item(Me.tableGeneralAddress._RegionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAddress1Null()
                Me.Item(Me.tableGeneralAddress.Address1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAddress2Null()
                Me.Item(Me.tableGeneralAddress.Address2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAssistantIDNull()
                Me.Item(Me.tableGeneralAddress.AssistantIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBankIDNull()
                Me.Item(Me.tableGeneralAddress.BankIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBankYNNull()
                Me.Item(Me.tableGeneralAddress.BankYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCityNull()
                Me.Item(Me.tableGeneralAddress.CityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCompanyIDNull()
                Me.Item(Me.tableGeneralAddress.CompanyIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetcountryCodeNull()
                Me.Item(Me.tableGeneralAddress.countryCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetcountryNull()
                Me.Item(Me.tableGeneralAddress.countryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCustomerIDNull()
                Me.Item(Me.tableGeneralAddress.CustomerIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCustomerYNNull()
                Me.Item(Me.tableGeneralAddress.CustomerYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tableGeneralAddress.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEMail1Null()
                Me.Item(Me.tableGeneralAddress.EMail1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEMail2Null()
                Me.Item(Me.tableGeneralAddress.EMail2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEMail3Null()
                Me.Item(Me.tableGeneralAddress.EMail3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEmployeeIDNull()
                Me.Item(Me.tableGeneralAddress.EmployeeIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEmployeeYNNull()
                Me.Item(Me.tableGeneralAddress.EmployeeYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEntityIDNull()
                Me.Item(Me.tableGeneralAddress.EntityIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEntityYNNull()
                Me.Item(Me.tableGeneralAddress.EntityYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFax1Null()
                Me.Item(Me.tableGeneralAddress.Fax1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFax2Null()
                Me.Item(Me.tableGeneralAddress.Fax2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFax3Null()
                Me.Item(Me.tableGeneralAddress.Fax3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFirstNameNull()
                Me.Item(Me.tableGeneralAddress.FirstNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetGenderNull()
                Me.Item(Me.tableGeneralAddress.GenderColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetJobTitleNull()
                Me.Item(Me.tableGeneralAddress.JobTitleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLangNull()
                Me.Item(Me.tableGeneralAddress.LangColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLocIDNull()
                Me.Item(Me.tableGeneralAddress.LocIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLocYNNull()
                Me.Item(Me.tableGeneralAddress.LocYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetManagerIDNull()
                Me.Item(Me.tableGeneralAddress.ManagerIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tableGeneralAddress.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPersonYNNull()
                Me.Item(Me.tableGeneralAddress.PersonYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPhone1Null()
                Me.Item(Me.tableGeneralAddress.Phone1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPhone2Null()
                Me.Item(Me.tableGeneralAddress.Phone2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPhone3Null()
                Me.Item(Me.tableGeneralAddress.Phone3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSupplierIDNull()
                Me.Item(Me.tableGeneralAddress.SupplierIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSupplierYNNull()
                Me.Item(Me.tableGeneralAddress.SupplierYNColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTaxNbr1Null()
                Me.Item(Me.tableGeneralAddress.TaxNbr1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTaxNbr2Null()
                Me.Item(Me.tableGeneralAddress.TaxNbr2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTaxNbr3Null()
                Me.Item(Me.tableGeneralAddress.TaxNbr3Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTitleNull()
                Me.Item(Me.tableGeneralAddress.TitleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetWebSiteNull()
                Me.Item(Me.tableGeneralAddress.WebSiteColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetZIPNull()
                Me.Item(Me.tableGeneralAddress.ZIPColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property _Region As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress._RegionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Region' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress._RegionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Address1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Address1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Address1' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Address1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Address2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Address2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Address2' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Address2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property AddrID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.AddrIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.AddrIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property AssistantID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.AssistantIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AssistantID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.AssistantIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.BankIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BankID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.BankIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BankYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.BankYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BankYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.BankYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property City As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.CityColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'City' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.CityColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CompanyID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.CompanyIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CompanyID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.CompanyIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property country As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.countryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'country' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.countryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property countryCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.countryCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'countryCode' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.countryCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CustomerID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.CustomerIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CustomerID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.CustomerIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CustomerYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.CustomerYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CustomerYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.CustomerYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EMail1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.EMail1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EMail1' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.EMail1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EMail2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.EMail2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EMail2' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.EMail2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EMail3 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.EMail3Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EMail3' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.EMail3Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EmployeeID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.EmployeeIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EmployeeID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.EmployeeIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EmployeeYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.EmployeeYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EmployeeYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.EmployeeYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.EntityIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EntityID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.EntityYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EntityYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.EntityYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Fax1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Fax1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Fax1' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Fax1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Fax2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Fax2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Fax2' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Fax2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Fax3 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Fax3Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Fax3' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Fax3Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FirstName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.FirstNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FirstName' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.FirstNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Gender As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.GenderColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Gender' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.GenderColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property JobTitle As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.JobTitleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'JobTitle' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.JobTitleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.LangColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Lang' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property LocID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.LocIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'LocID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.LocIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property LocYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.LocYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'LocYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.LocYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ManagerID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.ManagerIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ManagerID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.ManagerIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property PersonYN As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.PersonYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'PersonYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.PersonYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Phone1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Phone1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Phone1' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Phone1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Phone2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Phone2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Phone2' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Phone2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Phone3 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.Phone3Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Phone3' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.Phone3Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SupplierID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.SupplierIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SupplierID' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.SupplierIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SupplierYN As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tableGeneralAddress.SupplierYNColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SupplierYN' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tableGeneralAddress.SupplierYNColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TaxNbr1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.TaxNbr1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TaxNbr1' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.TaxNbr1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TaxNbr2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.TaxNbr2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TaxNbr2' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.TaxNbr2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TaxNbr3 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.TaxNbr3Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TaxNbr3' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.TaxNbr3Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Title As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralAddress.TitleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Title' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralAddress.TitleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property WebSite As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.WebSiteColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'WebSite' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.WebSiteColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ZIP As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralAddress.ZIPColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ZIP' in table 'GeneralAddress' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralAddress.ZIPColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralAddress As GeneralAddressDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GeneralAddressRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As GeneralAddressRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As GeneralAddressRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralAddressRow
        End Class

        Public Delegate Sub GeneralAddressRowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralAddressRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class generalcommentDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalcommentRowChanged As generalcommentRowChangeEventHandler
            Public Event generalcommentRowChanging As generalcommentRowChangeEventHandler
            Public Event generalcommentRowDeleted As generalcommentRowChangeEventHandler
            Public Event generalcommentRowDeleting As generalcommentRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalcommentDataTable.__ENCList
                SyncLock list
                    generalcommentDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalcomment"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalcommentDataTable.__ENCList
                SyncLock list
                    generalcommentDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalcommentDataTable.__ENCList
                SyncLock list
                    generalcommentDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralcommentRow(ByVal row As generalcommentRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralcommentRow(ByVal EntityID As Integer, ByVal CommentRef As String, ByVal Lang As String, ByVal Page As Integer, ByVal UserID As String, ByVal Description As String, ByVal Comment As String, ByVal InDate As DateTime, ByVal TableName As String, ByVal FieldName As String, ByVal FieldID As Integer) As generalcommentRow
                Dim row As generalcommentRow = DirectCast(Me.NewRow, generalcommentRow)
                row.ItemArray = New Object() { EntityID, CommentRef, Lang, Page, UserID, Description, Comment, InDate, TableName, FieldName, FieldID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalcommentDataTable = DirectCast(MyBase.Clone, generalcommentDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalcommentDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByEntityIDCommentRefLangPage(ByVal EntityID As Integer, ByVal CommentRef As String, ByVal Lang As String, ByVal Page As Integer) As generalcommentRow
                Return DirectCast(Me.Rows.Find(New Object() { EntityID, CommentRef, Lang, Page }), generalcommentRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalcommentRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalcommentDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnCommentRef = New DataColumn("CommentRef", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCommentRef)
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnPage = New DataColumn("Page", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPage)
                Me.columnUserID = New DataColumn("UserID", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnComment = New DataColumn("Comment", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnComment)
                Me.columnInDate = New DataColumn("InDate", GetType(DateTime), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnInDate)
                Me.columnTableName = New DataColumn("TableName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTableName)
                Me.columnFieldName = New DataColumn("FieldName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldName)
                Me.columnFieldID = New DataColumn("FieldID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldID)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey1", New DataColumn() { Me.columnEntityID, Me.columnCommentRef, Me.columnLang, Me.columnPage }, True))
                Me.columnEntityID.AllowDBNull = False
                Me.columnCommentRef.AllowDBNull = False
                Me.columnLang.AllowDBNull = False
                Me.columnPage.AllowDBNull = False
                Me.columnUserID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnCommentRef = MyBase.Columns.Item("CommentRef")
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnPage = MyBase.Columns.Item("Page")
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnComment = MyBase.Columns.Item("Comment")
                Me.columnInDate = MyBase.Columns.Item("InDate")
                Me.columnTableName = MyBase.Columns.Item("TableName")
                Me.columnFieldName = MyBase.Columns.Item("FieldName")
                Me.columnFieldID = MyBase.Columns.Item("FieldID")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralcommentRow() As generalcommentRow
                Return DirectCast(Me.NewRow, generalcommentRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalcommentRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalcommentRowChangedEvent Is Nothing) Then
                    Dim generalcommentRowChangedEvent As generalcommentRowChangeEventHandler = Me.generalcommentRowChangedEvent
                    If (Not generalcommentRowChangedEvent Is Nothing) Then
                        generalcommentRowChangedEvent.Invoke(Me, New generalcommentRowChangeEvent(DirectCast(e.Row, generalcommentRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalcommentRowChangingEvent Is Nothing) Then
                    Dim generalcommentRowChangingEvent As generalcommentRowChangeEventHandler = Me.generalcommentRowChangingEvent
                    If (Not generalcommentRowChangingEvent Is Nothing) Then
                        generalcommentRowChangingEvent.Invoke(Me, New generalcommentRowChangeEvent(DirectCast(e.Row, generalcommentRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalcommentRowDeletedEvent Is Nothing) Then
                    Dim generalcommentRowDeletedEvent As generalcommentRowChangeEventHandler = Me.generalcommentRowDeletedEvent
                    If (Not generalcommentRowDeletedEvent Is Nothing) Then
                        generalcommentRowDeletedEvent.Invoke(Me, New generalcommentRowChangeEvent(DirectCast(e.Row, generalcommentRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalcommentRowDeletingEvent Is Nothing) Then
                    Dim generalcommentRowDeletingEvent As generalcommentRowChangeEventHandler = Me.generalcommentRowDeletingEvent
                    If (Not generalcommentRowDeletingEvent Is Nothing) Then
                        generalcommentRowDeletingEvent.Invoke(Me, New generalcommentRowChangeEvent(DirectCast(e.Row, generalcommentRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralcommentRow(ByVal row As generalcommentRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CommentColumn As DataColumn
                Get
                    Return Me.columnComment
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CommentRefColumn As DataColumn
                Get
                    Return Me.columnCommentRef
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldIDColumn As DataColumn
                Get
                    Return Me.columnFieldID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldNameColumn As DataColumn
                Get
                    Return Me.columnFieldName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property InDateColumn As DataColumn
                Get
                    Return Me.columnInDate
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalcommentRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalcommentRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property PageColumn As DataColumn
                Get
                    Return Me.columnPage
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TableNameColumn As DataColumn
                Get
                    Return Me.columnTableName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserIDColumn As DataColumn
                Get
                    Return Me.columnUserID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnComment As DataColumn
            Private columnCommentRef As DataColumn
            Private columnDescription As DataColumn
            Private columnEntityID As DataColumn
            Private columnFieldID As DataColumn
            Private columnFieldName As DataColumn
            Private columnInDate As DataColumn
            Private columnLang As DataColumn
            Private columnPage As DataColumn
            Private columnTableName As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalcommentRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralcomment = DirectCast(Me.Table, generalcommentDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCommentNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.CommentColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFieldIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.FieldIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFieldNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.FieldNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsInDateNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.InDateColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsTableNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralcomment.TableNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCommentNull()
                Me.Item(Me.tablegeneralcomment.CommentColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralcomment.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFieldIDNull()
                Me.Item(Me.tablegeneralcomment.FieldIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFieldNameNull()
                Me.Item(Me.tablegeneralcomment.FieldNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetInDateNull()
                Me.Item(Me.tablegeneralcomment.InDateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetTableNameNull()
                Me.Item(Me.tablegeneralcomment.TableNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Comment As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralcomment.CommentColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Comment' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.CommentColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CommentRef As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralcomment.CommentRefColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.CommentRefColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralcomment.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralcomment.EntityIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralcomment.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralcomment.FieldIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FieldID' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralcomment.FieldIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralcomment.FieldNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FieldName' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.FieldNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property InDate As DateTime
                Get
                    Dim time As DateTime
                    Try 
                        time = Conversions.ToDate(Me.Item(Me.tablegeneralcomment.InDateColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'InDate' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return time
                End Get
                Set(ByVal Value As DateTime)
                    Me.Item(Me.tablegeneralcomment.InDateColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralcomment.LangColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Page As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralcomment.PageColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralcomment.PageColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property TableName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralcomment.TableNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'TableName' in table 'generalcomment' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.TableNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralcomment.UserIDColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralcomment.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralcomment As generalcommentDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalcommentRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalcommentRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalcommentRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalcommentRow
        End Class

        Public Delegate Sub generalcommentRowChangeEventHandler(ByVal sender As Object, ByVal e As generalcommentRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class GeneralCurrencyView1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event GeneralCurrencyView1RowChanged As GeneralCurrencyView1RowChangeEventHandler
            Public Event GeneralCurrencyView1RowChanging As GeneralCurrencyView1RowChangeEventHandler
            Public Event GeneralCurrencyView1RowDeleted As GeneralCurrencyView1RowChangeEventHandler
            Public Event GeneralCurrencyView1RowDeleting As GeneralCurrencyView1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = GeneralCurrencyView1DataTable.__ENCList
                SyncLock list
                    GeneralCurrencyView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "GeneralCurrencyView1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = GeneralCurrencyView1DataTable.__ENCList
                SyncLock list
                    GeneralCurrencyView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = GeneralCurrencyView1DataTable.__ENCList
                SyncLock list
                    GeneralCurrencyView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddGeneralCurrencyView1Row(ByVal row As GeneralCurrencyView1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddGeneralCurrencyView1Row(ByVal CurrCode As String, ByVal Description As String, ByVal RndFact As Integer, ByVal ExChangeType As String, ByVal FromDate As DateTime, ByVal ExRate As Double, ByVal BaseCurr As String, ByVal BaseCurrLabel As String) As GeneralCurrencyView1Row
                Dim row As GeneralCurrencyView1Row = DirectCast(Me.NewRow, GeneralCurrencyView1Row)
                row.ItemArray = New Object() { CurrCode, Description, RndFact, ExChangeType, FromDate, ExRate, BaseCurr, BaseCurrLabel }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As GeneralCurrencyView1DataTable = DirectCast(MyBase.Clone, GeneralCurrencyView1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New GeneralCurrencyView1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(GeneralCurrencyView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "GeneralCurrencyView1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnRndFact = New DataColumn("RndFact", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRndFact)
                Me.columnExChangeType = New DataColumn("ExChangeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnExChangeType)
                Me.columnFromDate = New DataColumn("FromDate", GetType(DateTime), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFromDate)
                Me.columnExRate = New DataColumn("ExRate", GetType(Double), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnExRate)
                Me.columnBaseCurr = New DataColumn("BaseCurr", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBaseCurr)
                Me.columnBaseCurrLabel = New DataColumn("BaseCurrLabel", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBaseCurrLabel)
                Me.columnCurrCode.AllowDBNull = False
                Me.columnBaseCurrLabel.ReadOnly = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnRndFact = MyBase.Columns.Item("RndFact")
                Me.columnExChangeType = MyBase.Columns.Item("ExChangeType")
                Me.columnFromDate = MyBase.Columns.Item("FromDate")
                Me.columnExRate = MyBase.Columns.Item("ExRate")
                Me.columnBaseCurr = MyBase.Columns.Item("BaseCurr")
                Me.columnBaseCurrLabel = MyBase.Columns.Item("BaseCurrLabel")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewGeneralCurrencyView1Row() As GeneralCurrencyView1Row
                Return DirectCast(Me.NewRow, GeneralCurrencyView1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New GeneralCurrencyView1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.GeneralCurrencyView1RowChangedEvent Is Nothing) Then
                    Dim handler As GeneralCurrencyView1RowChangeEventHandler = Me.GeneralCurrencyView1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralCurrencyView1RowChangeEvent(DirectCast(e.Row, GeneralCurrencyView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.GeneralCurrencyView1RowChangingEvent Is Nothing) Then
                    Dim handler As GeneralCurrencyView1RowChangeEventHandler = Me.GeneralCurrencyView1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralCurrencyView1RowChangeEvent(DirectCast(e.Row, GeneralCurrencyView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.GeneralCurrencyView1RowDeletedEvent Is Nothing) Then
                    Dim handler As GeneralCurrencyView1RowChangeEventHandler = Me.GeneralCurrencyView1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralCurrencyView1RowChangeEvent(DirectCast(e.Row, GeneralCurrencyView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.GeneralCurrencyView1RowDeletingEvent Is Nothing) Then
                    Dim handler As GeneralCurrencyView1RowChangeEventHandler = Me.GeneralCurrencyView1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New GeneralCurrencyView1RowChangeEvent(DirectCast(e.Row, GeneralCurrencyView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveGeneralCurrencyView1Row(ByVal row As GeneralCurrencyView1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property BaseCurrColumn As DataColumn
                Get
                    Return Me.columnBaseCurr
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BaseCurrLabelColumn As DataColumn
                Get
                    Return Me.columnBaseCurrLabel
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ExChangeTypeColumn As DataColumn
                Get
                    Return Me.columnExChangeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ExRateColumn As DataColumn
                Get
                    Return Me.columnExRate
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FromDateColumn As DataColumn
                Get
                    Return Me.columnFromDate
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As GeneralCurrencyView1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), GeneralCurrencyView1Row)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RndFactColumn As DataColumn
                Get
                    Return Me.columnRndFact
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBaseCurr As DataColumn
            Private columnBaseCurrLabel As DataColumn
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnExChangeType As DataColumn
            Private columnExRate As DataColumn
            Private columnFromDate As DataColumn
            Private columnRndFact As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GeneralCurrencyView1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableGeneralCurrencyView1 = DirectCast(Me.Table, GeneralCurrencyView1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsBaseCurrLabelNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.BaseCurrLabelColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBaseCurrNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.BaseCurrColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsExChangeTypeNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.ExChangeTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsExRateNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.ExRateColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFromDateNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.FromDateColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRndFactNull() As Boolean
                Return Me.IsNull(Me.tableGeneralCurrencyView1.RndFactColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetBaseCurrLabelNull()
                Me.Item(Me.tableGeneralCurrencyView1.BaseCurrLabelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBaseCurrNull()
                Me.Item(Me.tableGeneralCurrencyView1.BaseCurrColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tableGeneralCurrencyView1.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetExChangeTypeNull()
                Me.Item(Me.tableGeneralCurrencyView1.ExChangeTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetExRateNull()
                Me.Item(Me.tableGeneralCurrencyView1.ExRateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFromDateNull()
                Me.Item(Me.tableGeneralCurrencyView1.FromDateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRndFactNull()
                Me.Item(Me.tableGeneralCurrencyView1.RndFactColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property BaseCurr As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralCurrencyView1.BaseCurrColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BaseCurr' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralCurrencyView1.BaseCurrColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BaseCurrLabel As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralCurrencyView1.BaseCurrLabelColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BaseCurrLabel' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralCurrencyView1.BaseCurrLabelColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableGeneralCurrencyView1.CurrCodeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralCurrencyView1.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralCurrencyView1.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralCurrencyView1.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ExChangeType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableGeneralCurrencyView1.ExChangeTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ExChangeType' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableGeneralCurrencyView1.ExChangeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ExRate As Double
                Get
                    Dim num As Double
                    Try 
                        num = Conversions.ToDouble(Me.Item(Me.tableGeneralCurrencyView1.ExRateColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ExRate' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Double)
                    Me.Item(Me.tableGeneralCurrencyView1.ExRateColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FromDate As DateTime
                Get
                    Dim time As DateTime
                    Try 
                        time = Conversions.ToDate(Me.Item(Me.tableGeneralCurrencyView1.FromDateColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FromDate' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return time
                End Get
                Set(ByVal Value As DateTime)
                    Me.Item(Me.tableGeneralCurrencyView1.FromDateColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RndFact As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tableGeneralCurrencyView1.RndFactColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RndFact' in table 'GeneralCurrencyView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableGeneralCurrencyView1.RndFactColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableGeneralCurrencyView1 As GeneralCurrencyView1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class GeneralCurrencyView1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As GeneralCurrencyView1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As GeneralCurrencyView1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As GeneralCurrencyView1Row
        End Class

        Public Delegate Sub GeneralCurrencyView1RowChangeEventHandler(ByVal sender As Object, ByVal e As GeneralCurrencyView1RowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldesctranslationDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generaldesctranslationRowChanged As generaldesctranslationRowChangeEventHandler
            Public Event generaldesctranslationRowChanging As generaldesctranslationRowChangeEventHandler
            Public Event generaldesctranslationRowDeleted As generaldesctranslationRowChangeEventHandler
            Public Event generaldesctranslationRowDeleting As generaldesctranslationRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generaldesctranslationDataTable.__ENCList
                SyncLock list
                    generaldesctranslationDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generaldesctranslation"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generaldesctranslationDataTable.__ENCList
                SyncLock list
                    generaldesctranslationDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generaldesctranslationDataTable.__ENCList
                SyncLock list
                    generaldesctranslationDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneraldesctranslationRow(ByVal row As generaldesctranslationRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneraldesctranslationRow(ByVal Lang As String, ByVal Field As String, ByVal FieldID As Integer, ByVal Translate1 As String) As generaldesctranslationRow
                Dim row As generaldesctranslationRow = DirectCast(Me.NewRow, generaldesctranslationRow)
                row.ItemArray = New Object() { Lang, Field, FieldID, Translate1 }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generaldesctranslationDataTable = DirectCast(MyBase.Clone, generaldesctranslationDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generaldesctranslationDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByLangFieldFieldID(ByVal Lang As String, ByVal Field As String, ByVal FieldID As Integer) As generaldesctranslationRow
                Return DirectCast(Me.Rows.Find(New Object() { Lang, Field, FieldID }), generaldesctranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generaldesctranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generaldesctranslationDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnField = New DataColumn("Field", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnField)
                Me.columnFieldID = New DataColumn("FieldID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFieldID)
                Me.columnTranslate1 = New DataColumn("Translate1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnTranslate1)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey3", New DataColumn() { Me.columnLang, Me.columnField, Me.columnFieldID }, True))
                Me.columnLang.AllowDBNull = False
                Me.columnField.AllowDBNull = False
                Me.columnFieldID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnField = MyBase.Columns.Item("Field")
                Me.columnFieldID = MyBase.Columns.Item("FieldID")
                Me.columnTranslate1 = MyBase.Columns.Item("Translate1")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneraldesctranslationRow() As generaldesctranslationRow
                Return DirectCast(Me.NewRow, generaldesctranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generaldesctranslationRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generaldesctranslationRowChangedEvent Is Nothing) Then
                    Dim generaldesctranslationRowChangedEvent As generaldesctranslationRowChangeEventHandler = Me.generaldesctranslationRowChangedEvent
                    If (Not generaldesctranslationRowChangedEvent Is Nothing) Then
                        generaldesctranslationRowChangedEvent.Invoke(Me, New generaldesctranslationRowChangeEvent(DirectCast(e.Row, generaldesctranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generaldesctranslationRowChangingEvent Is Nothing) Then
                    Dim generaldesctranslationRowChangingEvent As generaldesctranslationRowChangeEventHandler = Me.generaldesctranslationRowChangingEvent
                    If (Not generaldesctranslationRowChangingEvent Is Nothing) Then
                        generaldesctranslationRowChangingEvent.Invoke(Me, New generaldesctranslationRowChangeEvent(DirectCast(e.Row, generaldesctranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generaldesctranslationRowDeletedEvent Is Nothing) Then
                    Dim generaldesctranslationRowDeletedEvent As generaldesctranslationRowChangeEventHandler = Me.generaldesctranslationRowDeletedEvent
                    If (Not generaldesctranslationRowDeletedEvent Is Nothing) Then
                        generaldesctranslationRowDeletedEvent.Invoke(Me, New generaldesctranslationRowChangeEvent(DirectCast(e.Row, generaldesctranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generaldesctranslationRowDeletingEvent Is Nothing) Then
                    Dim generaldesctranslationRowDeletingEvent As generaldesctranslationRowChangeEventHandler = Me.generaldesctranslationRowDeletingEvent
                    If (Not generaldesctranslationRowDeletingEvent Is Nothing) Then
                        generaldesctranslationRowDeletingEvent.Invoke(Me, New generaldesctranslationRowChangeEvent(DirectCast(e.Row, generaldesctranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneraldesctranslationRow(ByVal row As generaldesctranslationRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldColumn As DataColumn
                Get
                    Return Me.columnField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FieldIDColumn As DataColumn
                Get
                    Return Me.columnFieldID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generaldesctranslationRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generaldesctranslationRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Translate1Column As DataColumn
                Get
                    Return Me.columnTranslate1
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnField As DataColumn
            Private columnFieldID As DataColumn
            Private columnLang As DataColumn
            Private columnTranslate1 As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldesctranslationRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneraldesctranslation = DirectCast(Me.Table, generaldesctranslationDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsTranslate1Null() As Boolean
                Return Me.IsNull(Me.tablegeneraldesctranslation.Translate1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetTranslate1Null()
                Me.Item(Me.tablegeneraldesctranslation.Translate1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Field As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneraldesctranslation.FieldColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldesctranslation.FieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FieldID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneraldesctranslation.FieldIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneraldesctranslation.FieldIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneraldesctranslation.LangColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldesctranslation.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Translate1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneraldesctranslation.Translate1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Translate1' in table 'generaldesctranslation' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneraldesctranslation.Translate1Column) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneraldesctranslation As generaldesctranslationDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generaldesctranslationRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generaldesctranslationRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generaldesctranslationRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generaldesctranslationRow
        End Class

        Public Delegate Sub generaldesctranslationRowChangeEventHandler(ByVal sender As Object, ByVal e As generaldesctranslationRowChangeEvent)

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalentityDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalentityRowChanged As generalentityRowChangeEventHandler
            Public Event generalentityRowChanging As generalentityRowChangeEventHandler
            Public Event generalentityRowDeleted As generalentityRowChangeEventHandler
            Public Event generalentityRowDeleting As generalentityRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalentityDataTable.__ENCList
                SyncLock list
                    generalentityDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalentity"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalentityDataTable.__ENCList
                SyncLock list
                    generalentityDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalentityDataTable.__ENCList
                SyncLock list
                    generalentityDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralentityRow(ByVal row As generalentityRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralentityRow(ByVal EntityID As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String, ByVal FormIcon As String, ByVal HoldingID As Integer, ByVal AddrID As Integer, ByVal ConsoEntityID As Integer, ByVal CostTypeForGL As String) As generalentityRow
                Dim row As generalentityRow = DirectCast(Me.NewRow, generalentityRow)
                row.ItemArray = New Object() { EntityID, Name, Description, CurrCode, FormIcon, HoldingID, AddrID, ConsoEntityID, CostTypeForGL }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalentityDataTable = DirectCast(MyBase.Clone, generalentityDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalentityDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByEntityID(ByVal EntityID As Integer) As generalentityRow
                Return DirectCast(Me.Rows.Find(New Object() { EntityID }), generalentityRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalentityRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalentityDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnFormIcon = New DataColumn("FormIcon", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFormIcon)
                Me.columnHoldingID = New DataColumn("HoldingID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHoldingID)
                Me.columnAddrID = New DataColumn("AddrID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddrID)
                Me.columnConsoEntityID = New DataColumn("ConsoEntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnConsoEntityID)
                Me.columnCostTypeForGL = New DataColumn("CostTypeForGL", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCostTypeForGL)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey2", New DataColumn() { Me.columnEntityID }, True))
                Me.columnEntityID.AllowDBNull = False
                Me.columnEntityID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnFormIcon = MyBase.Columns.Item("FormIcon")
                Me.columnHoldingID = MyBase.Columns.Item("HoldingID")
                Me.columnAddrID = MyBase.Columns.Item("AddrID")
                Me.columnConsoEntityID = MyBase.Columns.Item("ConsoEntityID")
                Me.columnCostTypeForGL = MyBase.Columns.Item("CostTypeForGL")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralentityRow() As generalentityRow
                Return DirectCast(Me.NewRow, generalentityRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalentityRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalentityRowChangedEvent Is Nothing) Then
                    Dim generalentityRowChangedEvent As generalentityRowChangeEventHandler = Me.generalentityRowChangedEvent
                    If (Not generalentityRowChangedEvent Is Nothing) Then
                        generalentityRowChangedEvent.Invoke(Me, New generalentityRowChangeEvent(DirectCast(e.Row, generalentityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalentityRowChangingEvent Is Nothing) Then
                    Dim generalentityRowChangingEvent As generalentityRowChangeEventHandler = Me.generalentityRowChangingEvent
                    If (Not generalentityRowChangingEvent Is Nothing) Then
                        generalentityRowChangingEvent.Invoke(Me, New generalentityRowChangeEvent(DirectCast(e.Row, generalentityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalentityRowDeletedEvent Is Nothing) Then
                    Dim generalentityRowDeletedEvent As generalentityRowChangeEventHandler = Me.generalentityRowDeletedEvent
                    If (Not generalentityRowDeletedEvent Is Nothing) Then
                        generalentityRowDeletedEvent.Invoke(Me, New generalentityRowChangeEvent(DirectCast(e.Row, generalentityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalentityRowDeletingEvent Is Nothing) Then
                    Dim generalentityRowDeletingEvent As generalentityRowChangeEventHandler = Me.generalentityRowDeletingEvent
                    If (Not generalentityRowDeletingEvent Is Nothing) Then
                        generalentityRowDeletingEvent.Invoke(Me, New generalentityRowChangeEvent(DirectCast(e.Row, generalentityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralentityRow(ByVal row As generalentityRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AddrIDColumn As DataColumn
                Get
                    Return Me.columnAddrID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ConsoEntityIDColumn As DataColumn
                Get
                    Return Me.columnConsoEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CostTypeForGLColumn As DataColumn
                Get
                    Return Me.columnCostTypeForGL
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FormIconColumn As DataColumn
                Get
                    Return Me.columnFormIcon
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property HoldingIDColumn As DataColumn
                Get
                    Return Me.columnHoldingID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalentityRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalentityRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAddrID As DataColumn
            Private columnConsoEntityID As DataColumn
            Private columnCostTypeForGL As DataColumn
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnEntityID As DataColumn
            Private columnFormIcon As DataColumn
            Private columnHoldingID As DataColumn
            Private columnName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalentityRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralentity = DirectCast(Me.Table, generalentityDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAddrIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.AddrIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsConsoEntityIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.ConsoEntityIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCostTypeForGLNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.CostTypeForGLColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFormIconNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.FormIconColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHoldingIDNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.HoldingIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAddrIDNull()
                Me.Item(Me.tablegeneralentity.AddrIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetConsoEntityIDNull()
                Me.Item(Me.tablegeneralentity.ConsoEntityIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCostTypeForGLNull()
                Me.Item(Me.tablegeneralentity.CostTypeForGLColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tablegeneralentity.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralentity.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFormIconNull()
                Me.Item(Me.tablegeneralentity.FormIconColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHoldingIDNull()
                Me.Item(Me.tablegeneralentity.HoldingIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralentity.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AddrID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralentity.AddrIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddrID' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralentity.AddrIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ConsoEntityID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralentity.ConsoEntityIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ConsoEntityID' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralentity.ConsoEntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CostTypeForGL As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentity.CostTypeForGLColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CostTypeForGL' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentity.CostTypeForGLColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentity.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentity.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentity.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentity.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralentity.EntityIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralentity.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FormIcon As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentity.FormIconColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FormIcon' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentity.FormIconColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property HoldingID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablegeneralentity.HoldingIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'HoldingID' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralentity.HoldingIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentity.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalentity' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentity.NameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralentity As generalentityDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalentityRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalentityRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalentityRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalentityRow
        End Class

        Public Delegate Sub generalentityRowChangeEventHandler(ByVal sender As Object, ByVal e As generalentityRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalentityView1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalentityView1RowChanged As generalentityView1RowChangeEventHandler
            Public Event generalentityView1RowChanging As generalentityView1RowChangeEventHandler
            Public Event generalentityView1RowDeleted As generalentityView1RowChangeEventHandler
            Public Event generalentityView1RowDeleting As generalentityView1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalentityView1DataTable.__ENCList
                SyncLock list
                    generalentityView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalentityView1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalentityView1DataTable.__ENCList
                SyncLock list
                    generalentityView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalentityView1DataTable.__ENCList
                SyncLock list
                    generalentityView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralentityView1Row(ByVal row As generalentityView1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralentityView1Row(ByVal EntityID As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String, ByVal Address1 As String, ByVal Address2 As String, ByVal ZIP As String, ByVal City As String, ByVal country As String, ByVal Holding_Name As String, ByVal Holding_Desc As String, ByVal Holding_CurrCode As String, ByVal Phone1 As String, ByVal Fax1 As String, ByVal EMail1 As String, ByVal WebSite As String) As generalentityView1Row
                Dim row As generalentityView1Row = DirectCast(Me.NewRow, generalentityView1Row)
                row.ItemArray = New Object() { EntityID, Name, Description, CurrCode, Address1, Address2, ZIP, City, country, Holding_Name, Holding_Desc, Holding_CurrCode, Phone1, Fax1, EMail1, WebSite }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalentityView1DataTable = DirectCast(MyBase.Clone, generalentityView1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalentityView1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalentityView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalentityView1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnAddress1 = New DataColumn("Address1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddress1)
                Me.columnAddress2 = New DataColumn("Address2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddress2)
                Me.columnZIP = New DataColumn("ZIP", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnZIP)
                Me.columnCity = New DataColumn("City", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCity)
                Me.columncountry = New DataColumn("country", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columncountry)
                Me.columnHolding_Name = New DataColumn("Holding_Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHolding_Name)
                Me.columnHolding_Desc = New DataColumn("Holding_Desc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHolding_Desc)
                Me.columnHolding_CurrCode = New DataColumn("Holding_CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHolding_CurrCode)
                Me.columnPhone1 = New DataColumn("Phone1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPhone1)
                Me.columnFax1 = New DataColumn("Fax1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFax1)
                Me.columnEMail1 = New DataColumn("EMail1", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEMail1)
                Me.columnWebSite = New DataColumn("WebSite", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnWebSite)
                Me.columnEntityID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnAddress1 = MyBase.Columns.Item("Address1")
                Me.columnAddress2 = MyBase.Columns.Item("Address2")
                Me.columnZIP = MyBase.Columns.Item("ZIP")
                Me.columnCity = MyBase.Columns.Item("City")
                Me.columncountry = MyBase.Columns.Item("country")
                Me.columnHolding_Name = MyBase.Columns.Item("Holding_Name")
                Me.columnHolding_Desc = MyBase.Columns.Item("Holding_Desc")
                Me.columnHolding_CurrCode = MyBase.Columns.Item("Holding_CurrCode")
                Me.columnPhone1 = MyBase.Columns.Item("Phone1")
                Me.columnFax1 = MyBase.Columns.Item("Fax1")
                Me.columnEMail1 = MyBase.Columns.Item("EMail1")
                Me.columnWebSite = MyBase.Columns.Item("WebSite")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralentityView1Row() As generalentityView1Row
                Return DirectCast(Me.NewRow, generalentityView1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalentityView1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalentityView1RowChangedEvent Is Nothing) Then
                    Dim handler As generalentityView1RowChangeEventHandler = Me.generalentityView1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalentityView1RowChangeEvent(DirectCast(e.Row, generalentityView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalentityView1RowChangingEvent Is Nothing) Then
                    Dim handler As generalentityView1RowChangeEventHandler = Me.generalentityView1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalentityView1RowChangeEvent(DirectCast(e.Row, generalentityView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalentityView1RowDeletedEvent Is Nothing) Then
                    Dim handler As generalentityView1RowChangeEventHandler = Me.generalentityView1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalentityView1RowChangeEvent(DirectCast(e.Row, generalentityView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalentityView1RowDeletingEvent Is Nothing) Then
                    Dim handler As generalentityView1RowChangeEventHandler = Me.generalentityView1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalentityView1RowChangeEvent(DirectCast(e.Row, generalentityView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralentityView1Row(ByVal row As generalentityView1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Address1Column As DataColumn
                Get
                    Return Me.columnAddress1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Address2Column As DataColumn
                Get
                    Return Me.columnAddress2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CityColumn As DataColumn
                Get
                    Return Me.columnCity
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property countryColumn As DataColumn
                Get
                    Return Me.columncountry
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EMail1Column As DataColumn
                Get
                    Return Me.columnEMail1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Fax1Column As DataColumn
                Get
                    Return Me.columnFax1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Holding_CurrCodeColumn As DataColumn
                Get
                    Return Me.columnHolding_CurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Holding_DescColumn As DataColumn
                Get
                    Return Me.columnHolding_Desc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Holding_NameColumn As DataColumn
                Get
                    Return Me.columnHolding_Name
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalentityView1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), generalentityView1Row)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Phone1Column As DataColumn
                Get
                    Return Me.columnPhone1
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property WebSiteColumn As DataColumn
                Get
                    Return Me.columnWebSite
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ZIPColumn As DataColumn
                Get
                    Return Me.columnZIP
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAddress1 As DataColumn
            Private columnAddress2 As DataColumn
            Private columnCity As DataColumn
            Private columncountry As DataColumn
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnEMail1 As DataColumn
            Private columnEntityID As DataColumn
            Private columnFax1 As DataColumn
            Private columnHolding_CurrCode As DataColumn
            Private columnHolding_Desc As DataColumn
            Private columnHolding_Name As DataColumn
            Private columnName As DataColumn
            Private columnPhone1 As DataColumn
            Private columnWebSite As DataColumn
            Private columnZIP As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalentityView1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralentityView1 = DirectCast(Me.Table, generalentityView1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAddress1Null() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Address1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAddress2Null() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Address2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCityNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.CityColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IscountryNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.countryColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEMail1Null() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.EMail1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFax1Null() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Fax1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHolding_CurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Holding_CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHolding_DescNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Holding_DescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHolding_NameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Holding_NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPhone1Null() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.Phone1Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsWebSiteNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.WebSiteColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsZIPNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentityView1.ZIPColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAddress1Null()
                Me.Item(Me.tablegeneralentityView1.Address1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAddress2Null()
                Me.Item(Me.tablegeneralentityView1.Address2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCityNull()
                Me.Item(Me.tablegeneralentityView1.CityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetcountryNull()
                Me.Item(Me.tablegeneralentityView1.countryColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tablegeneralentityView1.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralentityView1.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEMail1Null()
                Me.Item(Me.tablegeneralentityView1.EMail1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFax1Null()
                Me.Item(Me.tablegeneralentityView1.Fax1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHolding_CurrCodeNull()
                Me.Item(Me.tablegeneralentityView1.Holding_CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHolding_DescNull()
                Me.Item(Me.tablegeneralentityView1.Holding_DescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHolding_NameNull()
                Me.Item(Me.tablegeneralentityView1.Holding_NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralentityView1.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPhone1Null()
                Me.Item(Me.tablegeneralentityView1.Phone1Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetWebSiteNull()
                Me.Item(Me.tablegeneralentityView1.WebSiteColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetZIPNull()
                Me.Item(Me.tablegeneralentityView1.ZIPColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Address1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Address1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Address1' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Address1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Address2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Address2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Address2' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Address2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property City As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.CityColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'City' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.CityColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property country As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.countryColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'country' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.countryColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EMail1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.EMail1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EMail1' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.EMail1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralentityView1.EntityIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralentityView1.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Fax1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Fax1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Fax1' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Fax1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Holding_CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Holding_CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Holding_CurrCode' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Holding_CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Holding_Desc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Holding_DescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Holding_Desc' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Holding_DescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Holding_Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Holding_NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Holding_Name' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Holding_NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Phone1 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.Phone1Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Phone1' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.Phone1Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property WebSite As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.WebSiteColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'WebSite' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.WebSiteColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ZIP As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralentityView1.ZIPColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ZIP' in table 'generalentityView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralentityView1.ZIPColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralentityView1 As generalentityView1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalentityView1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalentityView1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalentityView1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalentityView1Row
        End Class

        Public Delegate Sub generalentityView1RowChangeEventHandler(ByVal sender As Object, ByVal e As generalentityView1RowChangeEvent)

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalglobalcode1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalglobalcode1RowChanged As generalglobalcode1RowChangeEventHandler
            Public Event generalglobalcode1RowChanging As generalglobalcode1RowChangeEventHandler
            Public Event generalglobalcode1RowDeleted As generalglobalcode1RowChangeEventHandler
            Public Event generalglobalcode1RowDeleting As generalglobalcode1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalglobalcode1DataTable.__ENCList
                SyncLock list
                    generalglobalcode1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalglobalcode1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalglobalcode1DataTable.__ENCList
                SyncLock list
                    generalglobalcode1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalglobalcode1DataTable.__ENCList
                SyncLock list
                    generalglobalcode1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Addgeneralglobalcode1Row(ByVal row As generalglobalcode1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Addgeneralglobalcode1Row(ByVal CodeType As String, ByVal CodeValue As String, ByVal CodeDesc As String) As generalglobalcode1Row
                Dim row As generalglobalcode1Row = DirectCast(Me.NewRow, generalglobalcode1Row)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalglobalcode1DataTable = DirectCast(MyBase.Clone, generalglobalcode1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalglobalcode1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As String) As generalglobalcode1Row
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), generalglobalcode1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalglobalcode1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalglobalcode1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey14", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Public Function Newgeneralglobalcode1Row() As generalglobalcode1Row
                Return DirectCast(Me.NewRow, generalglobalcode1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalglobalcode1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalglobalcode1RowChangedEvent Is Nothing) Then
                    Dim handler As generalglobalcode1RowChangeEventHandler = Me.generalglobalcode1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalglobalcode1RowChangeEvent(DirectCast(e.Row, generalglobalcode1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalglobalcode1RowChangingEvent Is Nothing) Then
                    Dim handler As generalglobalcode1RowChangeEventHandler = Me.generalglobalcode1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalglobalcode1RowChangeEvent(DirectCast(e.Row, generalglobalcode1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalglobalcode1RowDeletedEvent Is Nothing) Then
                    Dim handler As generalglobalcode1RowChangeEventHandler = Me.generalglobalcode1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalglobalcode1RowChangeEvent(DirectCast(e.Row, generalglobalcode1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalglobalcode1RowDeletingEvent Is Nothing) Then
                    Dim handler As generalglobalcode1RowChangeEventHandler = Me.generalglobalcode1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalglobalcode1RowChangeEvent(DirectCast(e.Row, generalglobalcode1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Removegeneralglobalcode1Row(ByVal row As generalglobalcode1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalglobalcode1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), generalglobalcode1Row)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcode1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralglobalcode1 = DirectCast(Me.Table, generalglobalcode1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tablegeneralglobalcode1.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tablegeneralglobalcode1.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralglobalcode1.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'generalglobalcode1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode1.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcode1.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode1.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcode1.CodeValueColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode1.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralglobalcode1 As generalglobalcode1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcode1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalglobalcode1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalglobalcode1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalglobalcode1Row
        End Class

        Public Delegate Sub generalglobalcode1RowChangeEventHandler(ByVal sender As Object, ByVal e As generalglobalcode1RowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcodeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalglobalcodeRowChanged As generalglobalcodeRowChangeEventHandler
            Public Event generalglobalcodeRowChanging As generalglobalcodeRowChangeEventHandler
            Public Event generalglobalcodeRowDeleted As generalglobalcodeRowChangeEventHandler
            Public Event generalglobalcodeRowDeleting As generalglobalcodeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalglobalcodeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalglobalcode"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalglobalcodeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalglobalcodeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralglobalcodeRow(ByVal row As generalglobalcodeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralglobalcodeRow(ByVal CodeType As String, ByVal CodeValue As String, ByVal CodeDesc As String) As generalglobalcodeRow
                Dim row As generalglobalcodeRow = DirectCast(Me.NewRow, generalglobalcodeRow)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalglobalcodeDataTable = DirectCast(MyBase.Clone, generalglobalcodeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalglobalcodeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As String) As generalglobalcodeRow
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), generalglobalcodeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalglobalcodeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalglobalcodeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey8", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralglobalcodeRow() As generalglobalcodeRow
                Return DirectCast(Me.NewRow, generalglobalcodeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalglobalcodeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalglobalcodeRowChangedEvent Is Nothing) Then
                    Dim generalglobalcodeRowChangedEvent As generalglobalcodeRowChangeEventHandler = Me.generalglobalcodeRowChangedEvent
                    If (Not generalglobalcodeRowChangedEvent Is Nothing) Then
                        generalglobalcodeRowChangedEvent.Invoke(Me, New generalglobalcodeRowChangeEvent(DirectCast(e.Row, generalglobalcodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalglobalcodeRowChangingEvent Is Nothing) Then
                    Dim generalglobalcodeRowChangingEvent As generalglobalcodeRowChangeEventHandler = Me.generalglobalcodeRowChangingEvent
                    If (Not generalglobalcodeRowChangingEvent Is Nothing) Then
                        generalglobalcodeRowChangingEvent.Invoke(Me, New generalglobalcodeRowChangeEvent(DirectCast(e.Row, generalglobalcodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalglobalcodeRowDeletedEvent Is Nothing) Then
                    Dim generalglobalcodeRowDeletedEvent As generalglobalcodeRowChangeEventHandler = Me.generalglobalcodeRowDeletedEvent
                    If (Not generalglobalcodeRowDeletedEvent Is Nothing) Then
                        generalglobalcodeRowDeletedEvent.Invoke(Me, New generalglobalcodeRowChangeEvent(DirectCast(e.Row, generalglobalcodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalglobalcodeRowDeletingEvent Is Nothing) Then
                    Dim generalglobalcodeRowDeletingEvent As generalglobalcodeRowChangeEventHandler = Me.generalglobalcodeRowDeletingEvent
                    If (Not generalglobalcodeRowDeletingEvent Is Nothing) Then
                        generalglobalcodeRowDeletingEvent.Invoke(Me, New generalglobalcodeRowChangeEvent(DirectCast(e.Row, generalglobalcodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralglobalcodeRow(ByVal row As generalglobalcodeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalglobalcodeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalglobalcodeRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcodeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralglobalcode = DirectCast(Me.Table, generalglobalcodeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tablegeneralglobalcode.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tablegeneralglobalcode.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralglobalcode.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'generalglobalcode' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcode.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcode.CodeValueColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcode.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralglobalcode As generalglobalcodeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcodeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalglobalcodeRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalglobalcodeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalglobalcodeRow
        End Class

        Public Delegate Sub generalglobalcodeRowChangeEventHandler(ByVal sender As Object, ByVal e As generalglobalcodeRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalglobalcodeTypeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalglobalcodeTypeRowChanged As generalglobalcodeTypeRowChangeEventHandler
            Public Event generalglobalcodeTypeRowChanging As generalglobalcodeTypeRowChangeEventHandler
            Public Event generalglobalcodeTypeRowDeleted As generalglobalcodeTypeRowChangeEventHandler
            Public Event generalglobalcodeTypeRowDeleting As generalglobalcodeTypeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalglobalcodeTypeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalglobalcodeType"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalglobalcodeTypeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalglobalcodeTypeDataTable.__ENCList
                SyncLock list
                    generalglobalcodeTypeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralglobalcodeTypeRow(ByVal row As generalglobalcodeTypeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralglobalcodeTypeRow(ByVal CodeType As String, ByVal CodeValue As String, ByVal CodeDesc As String) As generalglobalcodeTypeRow
                Dim row As generalglobalcodeTypeRow = DirectCast(Me.NewRow, generalglobalcodeTypeRow)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalglobalcodeTypeDataTable = DirectCast(MyBase.Clone, generalglobalcodeTypeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalglobalcodeTypeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As String) As generalglobalcodeTypeRow
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), generalglobalcodeTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalglobalcodeTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalglobalcodeTypeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey10", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralglobalcodeTypeRow() As generalglobalcodeTypeRow
                Return DirectCast(Me.NewRow, generalglobalcodeTypeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalglobalcodeTypeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalglobalcodeTypeRowChangedEvent Is Nothing) Then
                    Dim generalglobalcodeTypeRowChangedEvent As generalglobalcodeTypeRowChangeEventHandler = Me.generalglobalcodeTypeRowChangedEvent
                    If (Not generalglobalcodeTypeRowChangedEvent Is Nothing) Then
                        generalglobalcodeTypeRowChangedEvent.Invoke(Me, New generalglobalcodeTypeRowChangeEvent(DirectCast(e.Row, generalglobalcodeTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalglobalcodeTypeRowChangingEvent Is Nothing) Then
                    Dim generalglobalcodeTypeRowChangingEvent As generalglobalcodeTypeRowChangeEventHandler = Me.generalglobalcodeTypeRowChangingEvent
                    If (Not generalglobalcodeTypeRowChangingEvent Is Nothing) Then
                        generalglobalcodeTypeRowChangingEvent.Invoke(Me, New generalglobalcodeTypeRowChangeEvent(DirectCast(e.Row, generalglobalcodeTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalglobalcodeTypeRowDeletedEvent Is Nothing) Then
                    Dim generalglobalcodeTypeRowDeletedEvent As generalglobalcodeTypeRowChangeEventHandler = Me.generalglobalcodeTypeRowDeletedEvent
                    If (Not generalglobalcodeTypeRowDeletedEvent Is Nothing) Then
                        generalglobalcodeTypeRowDeletedEvent.Invoke(Me, New generalglobalcodeTypeRowChangeEvent(DirectCast(e.Row, generalglobalcodeTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalglobalcodeTypeRowDeletingEvent Is Nothing) Then
                    Dim generalglobalcodeTypeRowDeletingEvent As generalglobalcodeTypeRowChangeEventHandler = Me.generalglobalcodeTypeRowDeletingEvent
                    If (Not generalglobalcodeTypeRowDeletingEvent Is Nothing) Then
                        generalglobalcodeTypeRowDeletingEvent.Invoke(Me, New generalglobalcodeTypeRowChangeEvent(DirectCast(e.Row, generalglobalcodeTypeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralglobalcodeTypeRow(ByVal row As generalglobalcodeTypeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalglobalcodeTypeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalglobalcodeTypeRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcodeTypeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralglobalcodeType = DirectCast(Me.Table, generalglobalcodeTypeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tablegeneralglobalcodeType.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tablegeneralglobalcodeType.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralglobalcodeType.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'generalglobalcodeType' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcodeType.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcodeType.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcodeType.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalcodeType.CodeValueColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalcodeType.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralglobalcodeType As generalglobalcodeTypeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalcodeTypeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalglobalcodeTypeRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalglobalcodeTypeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalglobalcodeTypeRow
        End Class

        Public Delegate Sub generalglobalcodeTypeRowChangeEventHandler(ByVal sender As Object, ByVal e As generalglobalcodeTypeRowChangeEvent)

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalparameterDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalglobalparameterRowChanged As generalglobalparameterRowChangeEventHandler
            Public Event generalglobalparameterRowChanging As generalglobalparameterRowChangeEventHandler
            Public Event generalglobalparameterRowDeleted As generalglobalparameterRowChangeEventHandler
            Public Event generalglobalparameterRowDeleting As generalglobalparameterRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalglobalparameterDataTable.__ENCList
                SyncLock list
                    generalglobalparameterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalglobalparameter"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalglobalparameterDataTable.__ENCList
                SyncLock list
                    generalglobalparameterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalglobalparameterDataTable.__ENCList
                SyncLock list
                    generalglobalparameterDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralglobalparameterRow(ByVal row As generalglobalparameterRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralglobalparameterRow(ByVal SetupCategory As String, ByVal Name As String, ByVal ParamValue As String) As generalglobalparameterRow
                Dim row As generalglobalparameterRow = DirectCast(Me.NewRow, generalglobalparameterRow)
                row.ItemArray = New Object() { SetupCategory, Name, ParamValue }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalglobalparameterDataTable = DirectCast(MyBase.Clone, generalglobalparameterDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalglobalparameterDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindBySetupCategoryName(ByVal SetupCategory As String, ByVal Name As String) As generalglobalparameterRow
                Return DirectCast(Me.Rows.Find(New Object() { SetupCategory, Name }), generalglobalparameterRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalglobalparameterRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalglobalparameterDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnSetupCategory = New DataColumn("SetupCategory", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSetupCategory)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnParamValue = New DataColumn("ParamValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnParamValue)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey9", New DataColumn() { Me.columnSetupCategory, Me.columnName }, True))
                Me.columnSetupCategory.AllowDBNull = False
                Me.columnName.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnSetupCategory = MyBase.Columns.Item("SetupCategory")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnParamValue = MyBase.Columns.Item("ParamValue")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralglobalparameterRow() As generalglobalparameterRow
                Return DirectCast(Me.NewRow, generalglobalparameterRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalglobalparameterRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalglobalparameterRowChangedEvent Is Nothing) Then
                    Dim generalglobalparameterRowChangedEvent As generalglobalparameterRowChangeEventHandler = Me.generalglobalparameterRowChangedEvent
                    If (Not generalglobalparameterRowChangedEvent Is Nothing) Then
                        generalglobalparameterRowChangedEvent.Invoke(Me, New generalglobalparameterRowChangeEvent(DirectCast(e.Row, generalglobalparameterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalglobalparameterRowChangingEvent Is Nothing) Then
                    Dim generalglobalparameterRowChangingEvent As generalglobalparameterRowChangeEventHandler = Me.generalglobalparameterRowChangingEvent
                    If (Not generalglobalparameterRowChangingEvent Is Nothing) Then
                        generalglobalparameterRowChangingEvent.Invoke(Me, New generalglobalparameterRowChangeEvent(DirectCast(e.Row, generalglobalparameterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalglobalparameterRowDeletedEvent Is Nothing) Then
                    Dim generalglobalparameterRowDeletedEvent As generalglobalparameterRowChangeEventHandler = Me.generalglobalparameterRowDeletedEvent
                    If (Not generalglobalparameterRowDeletedEvent Is Nothing) Then
                        generalglobalparameterRowDeletedEvent.Invoke(Me, New generalglobalparameterRowChangeEvent(DirectCast(e.Row, generalglobalparameterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalglobalparameterRowDeletingEvent Is Nothing) Then
                    Dim generalglobalparameterRowDeletingEvent As generalglobalparameterRowChangeEventHandler = Me.generalglobalparameterRowDeletingEvent
                    If (Not generalglobalparameterRowDeletingEvent Is Nothing) Then
                        generalglobalparameterRowDeletingEvent.Invoke(Me, New generalglobalparameterRowChangeEvent(DirectCast(e.Row, generalglobalparameterRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralglobalparameterRow(ByVal row As generalglobalparameterRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalglobalparameterRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalglobalparameterRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ParamValueColumn As DataColumn
                Get
                    Return Me.columnParamValue
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SetupCategoryColumn As DataColumn
                Get
                    Return Me.columnSetupCategory
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnName As DataColumn
            Private columnParamValue As DataColumn
            Private columnSetupCategory As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalparameterRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralglobalparameter = DirectCast(Me.Table, generalglobalparameterDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsParamValueNull() As Boolean
                Return Me.IsNull(Me.tablegeneralglobalparameter.ParamValueColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetParamValueNull()
                Me.Item(Me.tablegeneralglobalparameter.ParamValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalparameter.NameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalparameter.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ParamValue As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralglobalparameter.ParamValueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ParamValue' in table 'generalglobalparameter' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalparameter.ParamValueColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SetupCategory As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablegeneralglobalparameter.SetupCategoryColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralglobalparameter.SetupCategoryColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralglobalparameter As generalglobalparameterDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalglobalparameterRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalglobalparameterRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalglobalparameterRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalglobalparameterRow
        End Class

        Public Delegate Sub generalglobalparameterRowChangeEventHandler(ByVal sender As Object, ByVal e As generalglobalparameterRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class generalholdingDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalholdingRowChanged As generalholdingRowChangeEventHandler
            Public Event generalholdingRowChanging As generalholdingRowChangeEventHandler
            Public Event generalholdingRowDeleted As generalholdingRowChangeEventHandler
            Public Event generalholdingRowDeleting As generalholdingRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalholdingDataTable.__ENCList
                SyncLock list
                    generalholdingDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalholding"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalholdingDataTable.__ENCList
                SyncLock list
                    generalholdingDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalholdingDataTable.__ENCList
                SyncLock list
                    generalholdingDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralholdingRow(ByVal row As generalholdingRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralholdingRow(ByVal HoldingID As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String) As generalholdingRow
                Dim row As generalholdingRow = DirectCast(Me.NewRow, generalholdingRow)
                row.ItemArray = New Object() { HoldingID, Name, Description, CurrCode }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalholdingDataTable = DirectCast(MyBase.Clone, generalholdingDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalholdingDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByHoldingID(ByVal HoldingID As Integer) As generalholdingRow
                Return DirectCast(Me.Rows.Find(New Object() { HoldingID }), generalholdingRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalholdingRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalholdingDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnHoldingID = New DataColumn("HoldingID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHoldingID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey5", New DataColumn() { Me.columnHoldingID }, True))
                Me.columnHoldingID.AllowDBNull = False
                Me.columnHoldingID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnHoldingID = MyBase.Columns.Item("HoldingID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralholdingRow() As generalholdingRow
                Return DirectCast(Me.NewRow, generalholdingRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalholdingRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalholdingRowChangedEvent Is Nothing) Then
                    Dim generalholdingRowChangedEvent As generalholdingRowChangeEventHandler = Me.generalholdingRowChangedEvent
                    If (Not generalholdingRowChangedEvent Is Nothing) Then
                        generalholdingRowChangedEvent.Invoke(Me, New generalholdingRowChangeEvent(DirectCast(e.Row, generalholdingRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalholdingRowChangingEvent Is Nothing) Then
                    Dim generalholdingRowChangingEvent As generalholdingRowChangeEventHandler = Me.generalholdingRowChangingEvent
                    If (Not generalholdingRowChangingEvent Is Nothing) Then
                        generalholdingRowChangingEvent.Invoke(Me, New generalholdingRowChangeEvent(DirectCast(e.Row, generalholdingRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalholdingRowDeletedEvent Is Nothing) Then
                    Dim generalholdingRowDeletedEvent As generalholdingRowChangeEventHandler = Me.generalholdingRowDeletedEvent
                    If (Not generalholdingRowDeletedEvent Is Nothing) Then
                        generalholdingRowDeletedEvent.Invoke(Me, New generalholdingRowChangeEvent(DirectCast(e.Row, generalholdingRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalholdingRowDeletingEvent Is Nothing) Then
                    Dim generalholdingRowDeletingEvent As generalholdingRowChangeEventHandler = Me.generalholdingRowDeletingEvent
                    If (Not generalholdingRowDeletingEvent Is Nothing) Then
                        generalholdingRowDeletingEvent.Invoke(Me, New generalholdingRowChangeEvent(DirectCast(e.Row, generalholdingRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralholdingRow(ByVal row As generalholdingRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property HoldingIDColumn As DataColumn
                Get
                    Return Me.columnHoldingID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalholdingRow
                Get
                    Return DirectCast(Me.Rows.Item(index), generalholdingRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnHoldingID As DataColumn
            Private columnName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalholdingRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralholding = DirectCast(Me.Table, generalholdingDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholding.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholding.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholding.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tablegeneralholding.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralholding.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralholding.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholding.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'generalholding' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholding.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholding.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalholding' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholding.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property HoldingID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralholding.HoldingIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralholding.HoldingIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholding.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalholding' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholding.NameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralholding As generalholdingDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalholdingRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalholdingRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalholdingRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalholdingRow
        End Class

        Public Delegate Sub generalholdingRowChangeEventHandler(ByVal sender As Object, ByVal e As generalholdingRowChangeEvent)

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalholdingView1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event generalholdingView1RowChanged As generalholdingView1RowChangeEventHandler
            Public Event generalholdingView1RowChanging As generalholdingView1RowChangeEventHandler
            Public Event generalholdingView1RowDeleted As generalholdingView1RowChangeEventHandler
            Public Event generalholdingView1RowDeleting As generalholdingView1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = generalholdingView1DataTable.__ENCList
                SyncLock list
                    generalholdingView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "generalholdingView1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = generalholdingView1DataTable.__ENCList
                SyncLock list
                    generalholdingView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = generalholdingView1DataTable.__ENCList
                SyncLock list
                    generalholdingView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddgeneralholdingView1Row(ByVal row As generalholdingView1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddgeneralholdingView1Row(ByVal HoldingID As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String) As generalholdingView1Row
                Dim row As generalholdingView1Row = DirectCast(Me.NewRow, generalholdingView1Row)
                row.ItemArray = New Object() { HoldingID, Name, Description, CurrCode }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As generalholdingView1DataTable = DirectCast(MyBase.Clone, generalholdingView1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New generalholdingView1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByHoldingID(ByVal HoldingID As Integer) As generalholdingView1Row
                Return DirectCast(Me.Rows.Find(New Object() { HoldingID }), generalholdingView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(generalholdingView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "generalholdingView1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnHoldingID = New DataColumn("HoldingID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHoldingID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey17", New DataColumn() { Me.columnHoldingID }, True))
                Me.columnHoldingID.AllowDBNull = False
                Me.columnHoldingID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnHoldingID = MyBase.Columns.Item("HoldingID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewgeneralholdingView1Row() As generalholdingView1Row
                Return DirectCast(Me.NewRow, generalholdingView1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New generalholdingView1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.generalholdingView1RowChangedEvent Is Nothing) Then
                    Dim handler As generalholdingView1RowChangeEventHandler = Me.generalholdingView1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalholdingView1RowChangeEvent(DirectCast(e.Row, generalholdingView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.generalholdingView1RowChangingEvent Is Nothing) Then
                    Dim handler As generalholdingView1RowChangeEventHandler = Me.generalholdingView1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalholdingView1RowChangeEvent(DirectCast(e.Row, generalholdingView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.generalholdingView1RowDeletedEvent Is Nothing) Then
                    Dim handler As generalholdingView1RowChangeEventHandler = Me.generalholdingView1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalholdingView1RowChangeEvent(DirectCast(e.Row, generalholdingView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.generalholdingView1RowDeletingEvent Is Nothing) Then
                    Dim handler As generalholdingView1RowChangeEventHandler = Me.generalholdingView1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New generalholdingView1RowChangeEvent(DirectCast(e.Row, generalholdingView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovegeneralholdingView1Row(ByVal row As generalholdingView1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property HoldingIDColumn As DataColumn
                Get
                    Return Me.columnHoldingID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As generalholdingView1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), generalholdingView1Row)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnHoldingID As DataColumn
            Private columnName As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalholdingView1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablegeneralholdingView1 = DirectCast(Me.Table, generalholdingView1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholdingView1.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholdingView1.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralholdingView1.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tablegeneralholdingView1.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablegeneralholdingView1.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralholdingView1.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholdingView1.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'generalholdingView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholdingView1.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholdingView1.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'generalholdingView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholdingView1.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property HoldingID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablegeneralholdingView1.HoldingIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablegeneralholdingView1.HoldingIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablegeneralholdingView1.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'generalholdingView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablegeneralholdingView1.NameColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablegeneralholdingView1 As generalholdingView1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class generalholdingView1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As generalholdingView1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As generalholdingView1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As generalholdingView1Row
        End Class

        Public Delegate Sub generalholdingView1RowChangeEventHandler(ByVal sender As Object, ByVal e As generalholdingView1RowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class PayMethodDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event PayMethodRowChanged As PayMethodRowChangeEventHandler
            Public Event PayMethodRowChanging As PayMethodRowChangeEventHandler
            Public Event PayMethodRowDeleted As PayMethodRowChangeEventHandler
            Public Event PayMethodRowDeleting As PayMethodRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = PayMethodDataTable.__ENCList
                SyncLock list
                    PayMethodDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "PayMethod"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = PayMethodDataTable.__ENCList
                SyncLock list
                    PayMethodDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = PayMethodDataTable.__ENCList
                SyncLock list
                    PayMethodDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddPayMethodRow(ByVal row As PayMethodRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddPayMethodRow(ByVal CodeType As String, ByVal CodeValue As Integer, ByVal CodeDesc As String) As PayMethodRow
                Dim row As PayMethodRow = DirectCast(Me.NewRow, PayMethodRow)
                row.ItemArray = New Object() { CodeType, CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As PayMethodDataTable = DirectCast(MyBase.Clone, PayMethodDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New PayMethodDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCodeTypeCodeValue(ByVal CodeType As String, ByVal CodeValue As Integer) As PayMethodRow
                Return DirectCast(Me.Rows.Find(New Object() { CodeType, CodeValue }), PayMethodRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(PayMethodRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "PayMethodDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeType = New DataColumn("CodeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeType)
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey18", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
                Me.columnCodeType.AllowDBNull = False
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeType = MyBase.Columns.Item("CodeType")
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Public Function NewPayMethodRow() As PayMethodRow
                Return DirectCast(Me.NewRow, PayMethodRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New PayMethodRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.PayMethodRowChangedEvent Is Nothing) Then
                    Dim payMethodRowChangedEvent As PayMethodRowChangeEventHandler = Me.PayMethodRowChangedEvent
                    If (Not payMethodRowChangedEvent Is Nothing) Then
                        payMethodRowChangedEvent.Invoke(Me, New PayMethodRowChangeEvent(DirectCast(e.Row, PayMethodRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.PayMethodRowChangingEvent Is Nothing) Then
                    Dim payMethodRowChangingEvent As PayMethodRowChangeEventHandler = Me.PayMethodRowChangingEvent
                    If (Not payMethodRowChangingEvent Is Nothing) Then
                        payMethodRowChangingEvent.Invoke(Me, New PayMethodRowChangeEvent(DirectCast(e.Row, PayMethodRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.PayMethodRowDeletedEvent Is Nothing) Then
                    Dim payMethodRowDeletedEvent As PayMethodRowChangeEventHandler = Me.PayMethodRowDeletedEvent
                    If (Not payMethodRowDeletedEvent Is Nothing) Then
                        payMethodRowDeletedEvent.Invoke(Me, New PayMethodRowChangeEvent(DirectCast(e.Row, PayMethodRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.PayMethodRowDeletingEvent Is Nothing) Then
                    Dim payMethodRowDeletingEvent As PayMethodRowChangeEventHandler = Me.PayMethodRowDeletingEvent
                    If (Not payMethodRowDeletingEvent Is Nothing) Then
                        payMethodRowDeletingEvent.Invoke(Me, New PayMethodRowChangeEvent(DirectCast(e.Row, PayMethodRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovePayMethodRow(ByVal row As PayMethodRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeTypeColumn As DataColumn
                Get
                    Return Me.columnCodeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As PayMethodRow
                Get
                    Return DirectCast(Me.Rows.Item(index), PayMethodRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeType As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class PayMethodRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablePayMethod = DirectCast(Me.Table, PayMethodDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tablePayMethod.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tablePayMethod.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablePayMethod.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'PayMethod' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablePayMethod.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeType As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablePayMethod.CodeTypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablePayMethod.CodeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablePayMethod.CodeValueColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablePayMethod.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablePayMethod As PayMethodDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class PayMethodRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As PayMethodRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As PayMethodRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As PayMethodRow
        End Class

        Public Delegate Sub PayMethodRowChangeEventHandler(ByVal sender As Object, ByVal e As PayMethodRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class STCostTypeView1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event STCostTypeView1RowChanged As STCostTypeView1RowChangeEventHandler
            Public Event STCostTypeView1RowChanging As STCostTypeView1RowChangeEventHandler
            Public Event STCostTypeView1RowDeleted As STCostTypeView1RowChangeEventHandler
            Public Event STCostTypeView1RowDeleting As STCostTypeView1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = STCostTypeView1DataTable.__ENCList
                SyncLock list
                    STCostTypeView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "STCostTypeView1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = STCostTypeView1DataTable.__ENCList
                SyncLock list
                    STCostTypeView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = STCostTypeView1DataTable.__ENCList
                SyncLock list
                    STCostTypeView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddSTCostTypeView1Row(ByVal row As STCostTypeView1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddSTCostTypeView1Row(ByVal CodeValue As String, ByVal CodeDesc As String) As STCostTypeView1Row
                Dim row As STCostTypeView1Row = DirectCast(Me.NewRow, STCostTypeView1Row)
                row.ItemArray = New Object() { CodeValue, CodeDesc }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As STCostTypeView1DataTable = DirectCast(MyBase.Clone, STCostTypeView1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New STCostTypeView1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(STCostTypeView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "STCostTypeView1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCodeValue = New DataColumn("CodeValue", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeValue)
                Me.columnCodeDesc = New DataColumn("CodeDesc", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCodeDesc)
                Me.columnCodeValue.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCodeValue = MyBase.Columns.Item("CodeValue")
                Me.columnCodeDesc = MyBase.Columns.Item("CodeDesc")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New STCostTypeView1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewSTCostTypeView1Row() As STCostTypeView1Row
                Return DirectCast(Me.NewRow, STCostTypeView1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.STCostTypeView1RowChangedEvent Is Nothing) Then
                    Dim handler As STCostTypeView1RowChangeEventHandler = Me.STCostTypeView1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New STCostTypeView1RowChangeEvent(DirectCast(e.Row, STCostTypeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.STCostTypeView1RowChangingEvent Is Nothing) Then
                    Dim handler As STCostTypeView1RowChangeEventHandler = Me.STCostTypeView1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New STCostTypeView1RowChangeEvent(DirectCast(e.Row, STCostTypeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.STCostTypeView1RowDeletedEvent Is Nothing) Then
                    Dim handler As STCostTypeView1RowChangeEventHandler = Me.STCostTypeView1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New STCostTypeView1RowChangeEvent(DirectCast(e.Row, STCostTypeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.STCostTypeView1RowDeletingEvent Is Nothing) Then
                    Dim handler As STCostTypeView1RowChangeEventHandler = Me.STCostTypeView1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New STCostTypeView1RowChangeEvent(DirectCast(e.Row, STCostTypeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveSTCostTypeView1Row(ByVal row As STCostTypeView1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeDescColumn As DataColumn
                Get
                    Return Me.columnCodeDesc
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CodeValueColumn As DataColumn
                Get
                    Return Me.columnCodeValue
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As STCostTypeView1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), STCostTypeView1Row)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCodeDesc As DataColumn
            Private columnCodeValue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class STCostTypeView1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableSTCostTypeView1 = DirectCast(Me.Table, STCostTypeView1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCodeDescNull() As Boolean
                Return Me.IsNull(Me.tableSTCostTypeView1.CodeDescColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCodeDescNull()
                Me.Item(Me.tableSTCostTypeView1.CodeDescColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CodeDesc As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableSTCostTypeView1.CodeDescColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CodeDesc' in table 'STCostTypeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableSTCostTypeView1.CodeDescColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property CodeValue As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tableSTCostTypeView1.CodeValueColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableSTCostTypeView1.CodeValueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableSTCostTypeView1 As STCostTypeView1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class STCostTypeView1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As STCostTypeView1Row, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As STCostTypeView1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As STCostTypeView1Row
        End Class

        Public Delegate Sub STCostTypeView1RowChangeEventHandler(ByVal sender As Object, ByVal e As STCostTypeView1RowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class systemcurrencyDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemcurrencyRowChanged As systemcurrencyRowChangeEventHandler
            Public Event systemcurrencyRowChanging As systemcurrencyRowChangeEventHandler
            Public Event systemcurrencyRowDeleted As systemcurrencyRowChangeEventHandler
            Public Event systemcurrencyRowDeleting As systemcurrencyRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemcurrencyDataTable.__ENCList
                SyncLock list
                    systemcurrencyDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemcurrency"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemcurrencyDataTable.__ENCList
                SyncLock list
                    systemcurrencyDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = systemcurrencyDataTable.__ENCList
                SyncLock list
                    systemcurrencyDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemcurrencyRow(ByVal row As systemcurrencyRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemcurrencyRow(ByVal CurrCode As String, ByVal Description As String, ByVal RndFact As Integer) As systemcurrencyRow
                Dim row As systemcurrencyRow = DirectCast(Me.NewRow, systemcurrencyRow)
                row.ItemArray = New Object() { CurrCode, Description, RndFact }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemcurrencyDataTable = DirectCast(MyBase.Clone, systemcurrencyDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemcurrencyDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByCurrCode(ByVal CurrCode As String) As systemcurrencyRow
                Return DirectCast(Me.Rows.Find(New Object() { CurrCode }), systemcurrencyRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemcurrencyRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemcurrencyDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnRndFact = New DataColumn("RndFact", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRndFact)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey6", New DataColumn() { Me.columnCurrCode }, True))
                Me.columnCurrCode.AllowDBNull = False
                Me.columnCurrCode.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnRndFact = MyBase.Columns.Item("RndFact")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemcurrencyRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemcurrencyRow() As systemcurrencyRow
                Return DirectCast(Me.NewRow, systemcurrencyRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemcurrencyRowChangedEvent Is Nothing) Then
                    Dim systemcurrencyRowChangedEvent As systemcurrencyRowChangeEventHandler = Me.systemcurrencyRowChangedEvent
                    If (Not systemcurrencyRowChangedEvent Is Nothing) Then
                        systemcurrencyRowChangedEvent.Invoke(Me, New systemcurrencyRowChangeEvent(DirectCast(e.Row, systemcurrencyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemcurrencyRowChangingEvent Is Nothing) Then
                    Dim systemcurrencyRowChangingEvent As systemcurrencyRowChangeEventHandler = Me.systemcurrencyRowChangingEvent
                    If (Not systemcurrencyRowChangingEvent Is Nothing) Then
                        systemcurrencyRowChangingEvent.Invoke(Me, New systemcurrencyRowChangeEvent(DirectCast(e.Row, systemcurrencyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemcurrencyRowDeletedEvent Is Nothing) Then
                    Dim systemcurrencyRowDeletedEvent As systemcurrencyRowChangeEventHandler = Me.systemcurrencyRowDeletedEvent
                    If (Not systemcurrencyRowDeletedEvent Is Nothing) Then
                        systemcurrencyRowDeletedEvent.Invoke(Me, New systemcurrencyRowChangeEvent(DirectCast(e.Row, systemcurrencyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemcurrencyRowDeletingEvent Is Nothing) Then
                    Dim systemcurrencyRowDeletingEvent As systemcurrencyRowChangeEventHandler = Me.systemcurrencyRowDeletingEvent
                    If (Not systemcurrencyRowDeletingEvent Is Nothing) Then
                        systemcurrencyRowDeletingEvent.Invoke(Me, New systemcurrencyRowChangeEvent(DirectCast(e.Row, systemcurrencyRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemcurrencyRow(ByVal row As systemcurrencyRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemcurrencyRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemcurrencyRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RndFactColumn As DataColumn
                Get
                    Return Me.columnRndFact
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnRndFact As DataColumn
        End Class

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemcurrencyexrateDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemcurrencyexrateRowChanged As systemcurrencyexrateRowChangeEventHandler
            Public Event systemcurrencyexrateRowChanging As systemcurrencyexrateRowChangeEventHandler
            Public Event systemcurrencyexrateRowDeleted As systemcurrencyexrateRowChangeEventHandler
            Public Event systemcurrencyexrateRowDeleting As systemcurrencyexrateRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemcurrencyexrateDataTable.__ENCList
                SyncLock list
                    systemcurrencyexrateDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemcurrencyexrate"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemcurrencyexrateDataTable.__ENCList
                SyncLock list
                    systemcurrencyexrateDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = systemcurrencyexrateDataTable.__ENCList
                SyncLock list
                    systemcurrencyexrateDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemcurrencyexrateRow(ByVal row As systemcurrencyexrateRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemcurrencyexrateRow(ByVal ExChangeID As Integer, ByVal ExChangeType As String, ByVal CurrCode As String, ByVal FromDate As DateTime, ByVal ExRate As Double) As systemcurrencyexrateRow
                Dim row As systemcurrencyexrateRow = DirectCast(Me.NewRow, systemcurrencyexrateRow)
                row.ItemArray = New Object() { ExChangeID, ExChangeType, CurrCode, FromDate, ExRate }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemcurrencyexrateDataTable = DirectCast(MyBase.Clone, systemcurrencyexrateDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemcurrencyexrateDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByExChangeID(ByVal ExChangeID As Integer) As systemcurrencyexrateRow
                Return DirectCast(Me.Rows.Find(New Object() { ExChangeID }), systemcurrencyexrateRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemcurrencyexrateRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemcurrencyexrateDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnExChangeID = New DataColumn("ExChangeID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnExChangeID)
                Me.columnExChangeType = New DataColumn("ExChangeType", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnExChangeType)
                Me.columnCurrCode = New DataColumn("CurrCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCurrCode)
                Me.columnFromDate = New DataColumn("FromDate", GetType(DateTime), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFromDate)
                Me.columnExRate = New DataColumn("ExRate", GetType(Double), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnExRate)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey15", New DataColumn() { Me.columnExChangeID }, True))
                Me.columnExChangeID.AllowDBNull = False
                Me.columnExChangeID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnExChangeID = MyBase.Columns.Item("ExChangeID")
                Me.columnExChangeType = MyBase.Columns.Item("ExChangeType")
                Me.columnCurrCode = MyBase.Columns.Item("CurrCode")
                Me.columnFromDate = MyBase.Columns.Item("FromDate")
                Me.columnExRate = MyBase.Columns.Item("ExRate")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemcurrencyexrateRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemcurrencyexrateRow() As systemcurrencyexrateRow
                Return DirectCast(Me.NewRow, systemcurrencyexrateRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemcurrencyexrateRowChangedEvent Is Nothing) Then
                    Dim systemcurrencyexrateRowChangedEvent As systemcurrencyexrateRowChangeEventHandler = Me.systemcurrencyexrateRowChangedEvent
                    If (Not systemcurrencyexrateRowChangedEvent Is Nothing) Then
                        systemcurrencyexrateRowChangedEvent.Invoke(Me, New systemcurrencyexrateRowChangeEvent(DirectCast(e.Row, systemcurrencyexrateRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemcurrencyexrateRowChangingEvent Is Nothing) Then
                    Dim systemcurrencyexrateRowChangingEvent As systemcurrencyexrateRowChangeEventHandler = Me.systemcurrencyexrateRowChangingEvent
                    If (Not systemcurrencyexrateRowChangingEvent Is Nothing) Then
                        systemcurrencyexrateRowChangingEvent.Invoke(Me, New systemcurrencyexrateRowChangeEvent(DirectCast(e.Row, systemcurrencyexrateRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemcurrencyexrateRowDeletedEvent Is Nothing) Then
                    Dim systemcurrencyexrateRowDeletedEvent As systemcurrencyexrateRowChangeEventHandler = Me.systemcurrencyexrateRowDeletedEvent
                    If (Not systemcurrencyexrateRowDeletedEvent Is Nothing) Then
                        systemcurrencyexrateRowDeletedEvent.Invoke(Me, New systemcurrencyexrateRowChangeEvent(DirectCast(e.Row, systemcurrencyexrateRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemcurrencyexrateRowDeletingEvent Is Nothing) Then
                    Dim systemcurrencyexrateRowDeletingEvent As systemcurrencyexrateRowChangeEventHandler = Me.systemcurrencyexrateRowDeletingEvent
                    If (Not systemcurrencyexrateRowDeletingEvent Is Nothing) Then
                        systemcurrencyexrateRowDeletingEvent.Invoke(Me, New systemcurrencyexrateRowChangeEvent(DirectCast(e.Row, systemcurrencyexrateRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemcurrencyexrateRow(ByVal row As systemcurrencyexrateRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property CurrCodeColumn As DataColumn
                Get
                    Return Me.columnCurrCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ExChangeIDColumn As DataColumn
                Get
                    Return Me.columnExChangeID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ExChangeTypeColumn As DataColumn
                Get
                    Return Me.columnExChangeType
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ExRateColumn As DataColumn
                Get
                    Return Me.columnExRate
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FromDateColumn As DataColumn
                Get
                    Return Me.columnFromDate
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemcurrencyexrateRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemcurrencyexrateRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCurrCode As DataColumn
            Private columnExChangeID As DataColumn
            Private columnExChangeType As DataColumn
            Private columnExRate As DataColumn
            Private columnFromDate As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemcurrencyexrateRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemcurrencyexrate = DirectCast(Me.Table, systemcurrencyexrateDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCurrCodeNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrencyexrate.CurrCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsExChangeTypeNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrencyexrate.ExChangeTypeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsExRateNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrencyexrate.ExRateColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFromDateNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrencyexrate.FromDateColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCurrCodeNull()
                Me.Item(Me.tablesystemcurrencyexrate.CurrCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetExChangeTypeNull()
                Me.Item(Me.tablesystemcurrencyexrate.ExChangeTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetExRateNull()
                Me.Item(Me.tablesystemcurrencyexrate.ExRateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFromDateNull()
                Me.Item(Me.tablesystemcurrencyexrate.FromDateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemcurrencyexrate.CurrCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CurrCode' in table 'systemcurrencyexrate' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemcurrencyexrate.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ExChangeID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemcurrencyexrate.ExChangeIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemcurrencyexrate.ExChangeIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ExChangeType As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemcurrencyexrate.ExChangeTypeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ExChangeType' in table 'systemcurrencyexrate' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemcurrencyexrate.ExChangeTypeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ExRate As Double
                Get
                    Dim num As Double
                    Try 
                        num = Conversions.ToDouble(Me.Item(Me.tablesystemcurrencyexrate.ExRateColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ExRate' in table 'systemcurrencyexrate' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Double)
                    Me.Item(Me.tablesystemcurrencyexrate.ExRateColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FromDate As DateTime
                Get
                    Dim time As DateTime
                    Try 
                        time = Conversions.ToDate(Me.Item(Me.tablesystemcurrencyexrate.FromDateColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FromDate' in table 'systemcurrencyexrate' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return time
                End Get
                Set(ByVal Value As DateTime)
                    Me.Item(Me.tablesystemcurrencyexrate.FromDateColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemcurrencyexrate As systemcurrencyexrateDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemcurrencyexrateRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemcurrencyexrateRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As systemcurrencyexrateRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemcurrencyexrateRow
        End Class

        Public Delegate Sub systemcurrencyexrateRowChangeEventHandler(ByVal sender As Object, ByVal e As systemcurrencyexrateRowChangeEvent)

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemcurrencyRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemcurrency = DirectCast(Me.Table, systemcurrencyDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrency.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsRndFactNull() As Boolean
                Return Me.IsNull(Me.tablesystemcurrency.RndFactColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablesystemcurrency.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetRndFactNull()
                Me.Item(Me.tablesystemcurrency.RndFactColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CurrCode As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemcurrency.CurrCodeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemcurrency.CurrCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemcurrency.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'systemcurrency' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemcurrency.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RndFact As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemcurrency.RndFactColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'RndFact' in table 'systemcurrency' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemcurrency.RndFactColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemcurrency As systemcurrencyDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemcurrencyRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemcurrencyRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As systemcurrencyRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemcurrencyRow
        End Class

        Public Delegate Sub systemcurrencyRowChangeEventHandler(ByVal sender As Object, ByVal e As systemcurrencyRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class systemlanguagecodeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemlanguagecodeRowChanged As systemlanguagecodeRowChangeEventHandler
            Public Event systemlanguagecodeRowChanging As systemlanguagecodeRowChangeEventHandler
            Public Event systemlanguagecodeRowDeleted As systemlanguagecodeRowChangeEventHandler
            Public Event systemlanguagecodeRowDeleting As systemlanguagecodeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemlanguagecodeDataTable.__ENCList
                SyncLock list
                    systemlanguagecodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemlanguagecode"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemlanguagecodeDataTable.__ENCList
                SyncLock list
                    systemlanguagecodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = table.TableName
                If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                    Me.CaseSensitive = table.CaseSensitive
                End If
                If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                    Me.Locale = table.Locale
                End If
                If (table.Namespace <> table.DataSet.Namespace) Then
                    Me.Namespace = table.Namespace
                End If
                Me.Prefix = table.Prefix
                Me.MinimumCapacity = table.MinimumCapacity
            End Sub

            <DebuggerNonUserCode> _
            Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
                MyBase.New(info, context)
                Dim list As ArrayList = systemlanguagecodeDataTable.__ENCList
                SyncLock list
                    systemlanguagecodeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemlanguagecodeRow(ByVal row As systemlanguagecodeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemlanguagecodeRow(ByVal Lang As String, ByVal Description As String) As systemlanguagecodeRow
                Dim row As systemlanguagecodeRow = DirectCast(Me.NewRow, systemlanguagecodeRow)
                row.ItemArray = New Object() { Lang, Description }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemlanguagecodeDataTable = DirectCast(MyBase.Clone, systemlanguagecodeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemlanguagecodeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByLang(ByVal Lang As String) As systemlanguagecodeRow
                Return DirectCast(Me.Rows.Find(New Object() { Lang }), systemlanguagecodeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemlanguagecodeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim general As New dsGeneral
                xs.Add(general.GetSchemaSerializable)
                Dim item As New XmlSchemaAny
                item.Namespace = "http://www.w3.org/2001/XMLSchema"
                Dim num As Decimal = 0
                item.MinOccurs = num
                item.MaxOccurs = 79228162514264337593543950335
                item.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(item)
                Dim any2 As New XmlSchemaAny
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
                num = 1
                any2.MinOccurs = num
                any2.ProcessContents = XmlSchemaContentProcessing.Lax
                sequence.Items.Add(any2)
                Dim attribute As New XmlSchemaAttribute
                attribute.Name = "namespace"
                attribute.FixedValue = general.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemlanguagecodeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.Constraints.Add(New UniqueConstraint("dsGeneralKey4", New DataColumn() { Me.columnLang }, True))
                Me.columnLang.AllowDBNull = False
                Me.columnLang.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnDescription = MyBase.Columns.Item("Description")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemlanguagecodeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemlanguagecodeRow() As systemlanguagecodeRow
                Return DirectCast(Me.NewRow, systemlanguagecodeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemlanguagecodeRowChangedEvent Is Nothing) Then
                    Dim systemlanguagecodeRowChangedEvent As systemlanguagecodeRowChangeEventHandler = Me.systemlanguagecodeRowChangedEvent
                    If (Not systemlanguagecodeRowChangedEvent Is Nothing) Then
                        systemlanguagecodeRowChangedEvent.Invoke(Me, New systemlanguagecodeRowChangeEvent(DirectCast(e.Row, systemlanguagecodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemlanguagecodeRowChangingEvent Is Nothing) Then
                    Dim systemlanguagecodeRowChangingEvent As systemlanguagecodeRowChangeEventHandler = Me.systemlanguagecodeRowChangingEvent
                    If (Not systemlanguagecodeRowChangingEvent Is Nothing) Then
                        systemlanguagecodeRowChangingEvent.Invoke(Me, New systemlanguagecodeRowChangeEvent(DirectCast(e.Row, systemlanguagecodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemlanguagecodeRowDeletedEvent Is Nothing) Then
                    Dim systemlanguagecodeRowDeletedEvent As systemlanguagecodeRowChangeEventHandler = Me.systemlanguagecodeRowDeletedEvent
                    If (Not systemlanguagecodeRowDeletedEvent Is Nothing) Then
                        systemlanguagecodeRowDeletedEvent.Invoke(Me, New systemlanguagecodeRowChangeEvent(DirectCast(e.Row, systemlanguagecodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemlanguagecodeRowDeletingEvent Is Nothing) Then
                    Dim systemlanguagecodeRowDeletingEvent As systemlanguagecodeRowChangeEventHandler = Me.systemlanguagecodeRowDeletingEvent
                    If (Not systemlanguagecodeRowDeletingEvent Is Nothing) Then
                        systemlanguagecodeRowDeletingEvent.Invoke(Me, New systemlanguagecodeRowChangeEvent(DirectCast(e.Row, systemlanguagecodeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemlanguagecodeRow(ByVal row As systemlanguagecodeRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemlanguagecodeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemlanguagecodeRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnDescription As DataColumn
            Private columnLang As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemlanguagecodeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemlanguagecode = DirectCast(Me.Table, systemlanguagecodeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablesystemlanguagecode.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablesystemlanguagecode.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemlanguagecode.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'systemlanguagecode' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemlanguagecode.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemlanguagecode.LangColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemlanguagecode.LangColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemlanguagecode As systemlanguagecodeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemlanguagecodeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemlanguagecodeRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property Action As DataRowAction
                Get
                    Return Me.eventAction
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property Row As systemlanguagecodeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemlanguagecodeRow
        End Class

        Public Delegate Sub systemlanguagecodeRowChangeEventHandler(ByVal sender As Object, ByVal e As systemlanguagecodeRowChangeEvent)
    End Class
End Namespace

