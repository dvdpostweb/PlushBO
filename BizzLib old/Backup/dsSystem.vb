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
    <Serializable, ToolboxItem(True), HelpKeyword("vs.data.DataSet"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlRoot("dsSystem"), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code")> _
    Public Class dsSystem
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsSystem.__ENCList
            SyncLock list
                dsSystem.__ENCList.Add(New WeakReference(Me))
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
            Dim list As ArrayList = dsSystem.__ENCList
            SyncLock list
                dsSystem.__ENCList.Add(New WeakReference(Me))
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
                    If (Not dataSet.Tables.Item("SystemKeyBoard") Is Nothing) Then
                        MyBase.Tables.Add(New SystemKeyBoardDataTable(dataSet.Tables.Item("SystemKeyBoard")))
                    End If
                    If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                        MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenutree") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenutreeDataTable(dataSet.Tables.Item("systemmenutree")))
                    End If
                    If (Not dataSet.Tables.Item("systemmessage") Is Nothing) Then
                        MyBase.Tables.Add(New systemmessageDataTable(dataSet.Tables.Item("systemmessage")))
                    End If
                    If (Not dataSet.Tables.Item("systemsequence") Is Nothing) Then
                        MyBase.Tables.Add(New systemsequenceDataTable(dataSet.Tables.Item("systemsequence")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenusub") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenusubDataTable(dataSet.Tables.Item("systemmenusub")))
                    End If
                    If (Not dataSet.Tables.Item("systemcurrency") Is Nothing) Then
                        MyBase.Tables.Add(New systemcurrencyDataTable(dataSet.Tables.Item("systemcurrency")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenutranslation") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenutranslationDataTable(dataSet.Tables.Item("systemmenutranslation")))
                    End If
                    If (Not dataSet.Tables.Item("securitymenu_role") Is Nothing) Then
                        MyBase.Tables.Add(New securitymenu_roleDataTable(dataSet.Tables.Item("securitymenu_role")))
                    End If
                    If (Not dataSet.Tables.Item("securityrole") Is Nothing) Then
                        MyBase.Tables.Add(New securityroleDataTable(dataSet.Tables.Item("securityrole")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalparameter") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalparameterDataTable(dataSet.Tables.Item("generalglobalparameter")))
                    End If
                    If (Not dataSet.Tables.Item("generalglobalcode") Is Nothing) Then
                        MyBase.Tables.Add(New generalglobalcodeDataTable(dataSet.Tables.Item("generalglobalcode")))
                    End If
                    If (Not dataSet.Tables.Item("systemcurrencyexrate") Is Nothing) Then
                        MyBase.Tables.Add(New systemcurrencyexrateDataTable(dataSet.Tables.Item("systemcurrencyexrate")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenu") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenuDataTable(dataSet.Tables.Item("systemmenu")))
                    End If
                    If (Not dataSet.Tables.Item("systemdatabase") Is Nothing) Then
                        MyBase.Tables.Add(New systemdatabaseDataTable(dataSet.Tables.Item("systemdatabase")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenutreeView1") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenutreeView1DataTable(dataSet.Tables.Item("systemmenutreeView1")))
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
            Dim system As dsSystem = DirectCast(MyBase.Clone, dsSystem)
            system.InitVars
            system.SchemaSerializationMode = Me.SchemaSerializationMode
            Return system
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
            Dim system As New dsSystem
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(system.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = system.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsSystem"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsSystem.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tableSystemKeyBoard = New SystemKeyBoardDataTable
            MyBase.Tables.Add(Me.tableSystemKeyBoard)
            Me.tablesystemlanguagecode = New systemlanguagecodeDataTable
            MyBase.Tables.Add(Me.tablesystemlanguagecode)
            Me.tablesystemmenutree = New systemmenutreeDataTable
            MyBase.Tables.Add(Me.tablesystemmenutree)
            Me.tablesystemmessage = New systemmessageDataTable
            MyBase.Tables.Add(Me.tablesystemmessage)
            Me.tablesystemsequence = New systemsequenceDataTable
            MyBase.Tables.Add(Me.tablesystemsequence)
            Me.tablesystemmenusub = New systemmenusubDataTable
            MyBase.Tables.Add(Me.tablesystemmenusub)
            Me.tablesystemcurrency = New systemcurrencyDataTable
            MyBase.Tables.Add(Me.tablesystemcurrency)
            Me.tablesystemmenutranslation = New systemmenutranslationDataTable
            MyBase.Tables.Add(Me.tablesystemmenutranslation)
            Me.tablesecuritymenu_role = New securitymenu_roleDataTable
            MyBase.Tables.Add(Me.tablesecuritymenu_role)
            Me.tablesecurityrole = New securityroleDataTable
            MyBase.Tables.Add(Me.tablesecurityrole)
            Me.tablegeneralglobalparameter = New generalglobalparameterDataTable
            MyBase.Tables.Add(Me.tablegeneralglobalparameter)
            Me.tablegeneralglobalcode = New generalglobalcodeDataTable
            MyBase.Tables.Add(Me.tablegeneralglobalcode)
            Me.tablesystemcurrencyexrate = New systemcurrencyexrateDataTable
            MyBase.Tables.Add(Me.tablesystemcurrencyexrate)
            Me.tablesystemmenu = New systemmenuDataTable
            MyBase.Tables.Add(Me.tablesystemmenu)
            Me.tablesystemdatabase = New systemdatabaseDataTable
            MyBase.Tables.Add(Me.tablesystemdatabase)
            Me.tablesystemmenutreeView1 = New systemmenutreeView1DataTable
            MyBase.Tables.Add(Me.tablesystemmenutreeView1)
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
            Me.tableSystemKeyBoard = DirectCast(MyBase.Tables.Item("SystemKeyBoard"), SystemKeyBoardDataTable)
            If (initTable AndAlso (Not Me.tableSystemKeyBoard Is Nothing)) Then
                Me.tableSystemKeyBoard.InitVars
            End If
            Me.tablesystemlanguagecode = DirectCast(MyBase.Tables.Item("systemlanguagecode"), systemlanguagecodeDataTable)
            If (initTable AndAlso (Not Me.tablesystemlanguagecode Is Nothing)) Then
                Me.tablesystemlanguagecode.InitVars
            End If
            Me.tablesystemmenutree = DirectCast(MyBase.Tables.Item("systemmenutree"), systemmenutreeDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenutree Is Nothing)) Then
                Me.tablesystemmenutree.InitVars
            End If
            Me.tablesystemmessage = DirectCast(MyBase.Tables.Item("systemmessage"), systemmessageDataTable)
            If (initTable AndAlso (Not Me.tablesystemmessage Is Nothing)) Then
                Me.tablesystemmessage.InitVars
            End If
            Me.tablesystemsequence = DirectCast(MyBase.Tables.Item("systemsequence"), systemsequenceDataTable)
            If (initTable AndAlso (Not Me.tablesystemsequence Is Nothing)) Then
                Me.tablesystemsequence.InitVars
            End If
            Me.tablesystemmenusub = DirectCast(MyBase.Tables.Item("systemmenusub"), systemmenusubDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenusub Is Nothing)) Then
                Me.tablesystemmenusub.InitVars
            End If
            Me.tablesystemcurrency = DirectCast(MyBase.Tables.Item("systemcurrency"), systemcurrencyDataTable)
            If (initTable AndAlso (Not Me.tablesystemcurrency Is Nothing)) Then
                Me.tablesystemcurrency.InitVars
            End If
            Me.tablesystemmenutranslation = DirectCast(MyBase.Tables.Item("systemmenutranslation"), systemmenutranslationDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenutranslation Is Nothing)) Then
                Me.tablesystemmenutranslation.InitVars
            End If
            Me.tablesecuritymenu_role = DirectCast(MyBase.Tables.Item("securitymenu_role"), securitymenu_roleDataTable)
            If (initTable AndAlso (Not Me.tablesecuritymenu_role Is Nothing)) Then
                Me.tablesecuritymenu_role.InitVars
            End If
            Me.tablesecurityrole = DirectCast(MyBase.Tables.Item("securityrole"), securityroleDataTable)
            If (initTable AndAlso (Not Me.tablesecurityrole Is Nothing)) Then
                Me.tablesecurityrole.InitVars
            End If
            Me.tablegeneralglobalparameter = DirectCast(MyBase.Tables.Item("generalglobalparameter"), generalglobalparameterDataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalparameter Is Nothing)) Then
                Me.tablegeneralglobalparameter.InitVars
            End If
            Me.tablegeneralglobalcode = DirectCast(MyBase.Tables.Item("generalglobalcode"), generalglobalcodeDataTable)
            If (initTable AndAlso (Not Me.tablegeneralglobalcode Is Nothing)) Then
                Me.tablegeneralglobalcode.InitVars
            End If
            Me.tablesystemcurrencyexrate = DirectCast(MyBase.Tables.Item("systemcurrencyexrate"), systemcurrencyexrateDataTable)
            If (initTable AndAlso (Not Me.tablesystemcurrencyexrate Is Nothing)) Then
                Me.tablesystemcurrencyexrate.InitVars
            End If
            Me.tablesystemmenu = DirectCast(MyBase.Tables.Item("systemmenu"), systemmenuDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenu Is Nothing)) Then
                Me.tablesystemmenu.InitVars
            End If
            Me.tablesystemdatabase = DirectCast(MyBase.Tables.Item("systemdatabase"), systemdatabaseDataTable)
            If (initTable AndAlso (Not Me.tablesystemdatabase Is Nothing)) Then
                Me.tablesystemdatabase.InitVars
            End If
            Me.tablesystemmenutreeView1 = DirectCast(MyBase.Tables.Item("systemmenutreeView1"), systemmenutreeView1DataTable)
            If (initTable AndAlso (Not Me.tablesystemmenutreeView1 Is Nothing)) Then
                Me.tablesystemmenutreeView1.InitVars
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
            If (Me.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema) Then
                Me.Reset
                Dim dataSet As New DataSet
                dataSet.ReadXml(reader)
                If (Not dataSet.Tables.Item("SystemKeyBoard") Is Nothing) Then
                    MyBase.Tables.Add(New SystemKeyBoardDataTable(dataSet.Tables.Item("SystemKeyBoard")))
                End If
                If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                    MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                End If
                If (Not dataSet.Tables.Item("systemmenutree") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenutreeDataTable(dataSet.Tables.Item("systemmenutree")))
                End If
                If (Not dataSet.Tables.Item("systemmessage") Is Nothing) Then
                    MyBase.Tables.Add(New systemmessageDataTable(dataSet.Tables.Item("systemmessage")))
                End If
                If (Not dataSet.Tables.Item("systemsequence") Is Nothing) Then
                    MyBase.Tables.Add(New systemsequenceDataTable(dataSet.Tables.Item("systemsequence")))
                End If
                If (Not dataSet.Tables.Item("systemmenusub") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenusubDataTable(dataSet.Tables.Item("systemmenusub")))
                End If
                If (Not dataSet.Tables.Item("systemcurrency") Is Nothing) Then
                    MyBase.Tables.Add(New systemcurrencyDataTable(dataSet.Tables.Item("systemcurrency")))
                End If
                If (Not dataSet.Tables.Item("systemmenutranslation") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenutranslationDataTable(dataSet.Tables.Item("systemmenutranslation")))
                End If
                If (Not dataSet.Tables.Item("securitymenu_role") Is Nothing) Then
                    MyBase.Tables.Add(New securitymenu_roleDataTable(dataSet.Tables.Item("securitymenu_role")))
                End If
                If (Not dataSet.Tables.Item("securityrole") Is Nothing) Then
                    MyBase.Tables.Add(New securityroleDataTable(dataSet.Tables.Item("securityrole")))
                End If
                If (Not dataSet.Tables.Item("generalglobalparameter") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalparameterDataTable(dataSet.Tables.Item("generalglobalparameter")))
                End If
                If (Not dataSet.Tables.Item("generalglobalcode") Is Nothing) Then
                    MyBase.Tables.Add(New generalglobalcodeDataTable(dataSet.Tables.Item("generalglobalcode")))
                End If
                If (Not dataSet.Tables.Item("systemcurrencyexrate") Is Nothing) Then
                    MyBase.Tables.Add(New systemcurrencyexrateDataTable(dataSet.Tables.Item("systemcurrencyexrate")))
                End If
                If (Not dataSet.Tables.Item("systemmenu") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenuDataTable(dataSet.Tables.Item("systemmenu")))
                End If
                If (Not dataSet.Tables.Item("systemdatabase") Is Nothing) Then
                    MyBase.Tables.Add(New systemdatabaseDataTable(dataSet.Tables.Item("systemdatabase")))
                End If
                If (Not dataSet.Tables.Item("systemmenutreeView1") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenutreeView1DataTable(dataSet.Tables.Item("systemmenutreeView1")))
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
        Private Function ShouldSerializegeneralglobalcode() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializegeneralglobalparameter() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeRelations() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecuritymenu_role() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityrole() As Boolean
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
        Private Function ShouldSerializesystemdatabase() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializeSystemKeyBoard() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemlanguagecode() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenu() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenusub() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenutranslation() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenutree() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenutreeView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmessage() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemsequence() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalglobalcode As generalglobalcodeDataTable
            Get
                Return Me.tablegeneralglobalcode
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property generalglobalparameter As generalglobalparameterDataTable
            Get
                Return Me.tablegeneralglobalparameter
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode> _
        Public ReadOnly Property Relations As DataRelationCollection
            Get
                Return MyBase.Relations
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), DebuggerNonUserCode, Browsable(True)> _
        Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
            Get
                Return Me._schemaSerializationMode
            End Get
            Set(ByVal Value As SchemaSerializationMode)
                Me._schemaSerializationMode = Value
            End Set
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property securitymenu_role As securitymenu_roleDataTable
            Get
                Return Me.tablesecuritymenu_role
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property securityrole As securityroleDataTable
            Get
                Return Me.tablesecurityrole
            End Get
        End Property

        <DebuggerNonUserCode, Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemcurrency As systemcurrencyDataTable
            Get
                Return Me.tablesystemcurrency
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property systemcurrencyexrate As systemcurrencyexrateDataTable
            Get
                Return Me.tablesystemcurrencyexrate
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property systemdatabase As systemdatabaseDataTable
            Get
                Return Me.tablesystemdatabase
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property SystemKeyBoard As SystemKeyBoardDataTable
            Get
                Return Me.tableSystemKeyBoard
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemlanguagecode As systemlanguagecodeDataTable
            Get
                Return Me.tablesystemlanguagecode
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property systemmenu As systemmenuDataTable
            Get
                Return Me.tablesystemmenu
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemmenusub As systemmenusubDataTable
            Get
                Return Me.tablesystemmenusub
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemmenutranslation As systemmenutranslationDataTable
            Get
                Return Me.tablesystemmenutranslation
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property systemmenutree As systemmenutreeDataTable
            Get
                Return Me.tablesystemmenutree
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemmenutreeView1 As systemmenutreeView1DataTable
            Get
                Return Me.tablesystemmenutreeView1
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property systemmessage As systemmessageDataTable
            Get
                Return Me.tablesystemmessage
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemsequence As systemsequenceDataTable
            Get
                Return Me.tablesystemsequence
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property Tables As DataTableCollection
            Get
                Return MyBase.Tables
            End Get
        End Property


        ' Fields
        Private Shared __ENCList As ArrayList = New ArrayList
        Private _schemaSerializationMode As SchemaSerializationMode
        Private tablegeneralglobalcode As generalglobalcodeDataTable
        Private tablegeneralglobalparameter As generalglobalparameterDataTable
        Private tablesecuritymenu_role As securitymenu_roleDataTable
        Private tablesecurityrole As securityroleDataTable
        Private tablesystemcurrency As systemcurrencyDataTable
        Private tablesystemcurrencyexrate As systemcurrencyexrateDataTable
        Private tablesystemdatabase As systemdatabaseDataTable
        Private tableSystemKeyBoard As SystemKeyBoardDataTable
        Private tablesystemlanguagecode As systemlanguagecodeDataTable
        Private tablesystemmenu As systemmenuDataTable
        Private tablesystemmenusub As systemmenusubDataTable
        Private tablesystemmenutranslation As systemmenutranslationDataTable
        Private tablesystemmenutree As systemmenutreeDataTable
        Private tablesystemmenutreeView1 As systemmenutreeView1DataTable
        Private tablesystemmessage As systemmessageDataTable
        Private tablesystemsequence As systemsequenceDataTable

        ' Nested Types
        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
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
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey13", New DataColumn() { Me.columnCodeType, Me.columnCodeValue }, True))
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

            <DebuggerNonUserCode, Browsable(False)> _
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

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
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
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey12", New DataColumn() { Me.columnSetupCategory, Me.columnName }, True))
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

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securitymenu_roleDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securitymenu_roleRowChanged As securitymenu_roleRowChangeEventHandler
            Public Event securitymenu_roleRowChanging As securitymenu_roleRowChangeEventHandler
            Public Event securitymenu_roleRowDeleted As securitymenu_roleRowChangeEventHandler
            Public Event securitymenu_roleRowDeleting As securitymenu_roleRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securitymenu_roleDataTable.__ENCList
                SyncLock list
                    securitymenu_roleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securitymenu_role"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securitymenu_roleDataTable.__ENCList
                SyncLock list
                    securitymenu_roleDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securitymenu_roleDataTable.__ENCList
                SyncLock list
                    securitymenu_roleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Addsecuritymenu_roleRow(ByVal row As securitymenu_roleRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Addsecuritymenu_roleRow(ByVal RoleID As Integer, ByVal MenuID As Integer) As securitymenu_roleRow
                Dim row As securitymenu_roleRow = DirectCast(Me.NewRow, securitymenu_roleRow)
                row.ItemArray = New Object() { RoleID, MenuID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securitymenu_roleDataTable = DirectCast(MyBase.Clone, securitymenu_roleDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securitymenu_roleDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByRoleIDMenuID(ByVal RoleID As Integer, ByVal MenuID As Integer) As securitymenu_roleRow
                Return DirectCast(Me.Rows.Find(New Object() { RoleID, MenuID }), securitymenu_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securitymenu_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securitymenu_roleDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnRoleID = New DataColumn("RoleID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRoleID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey10", New DataColumn() { Me.columnRoleID, Me.columnMenuID }, True))
                Me.columnRoleID.AllowDBNull = False
                Me.columnMenuID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnRoleID = MyBase.Columns.Item("RoleID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securitymenu_roleRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function Newsecuritymenu_roleRow() As securitymenu_roleRow
                Return DirectCast(Me.NewRow, securitymenu_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securitymenu_roleRowChangedEvent Is Nothing) Then
                    Dim handler As securitymenu_roleRowChangeEventHandler = Me.securitymenu_roleRowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securitymenu_roleRowChangeEvent(DirectCast(e.Row, securitymenu_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securitymenu_roleRowChangingEvent Is Nothing) Then
                    Dim handler As securitymenu_roleRowChangeEventHandler = Me.securitymenu_roleRowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securitymenu_roleRowChangeEvent(DirectCast(e.Row, securitymenu_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securitymenu_roleRowDeletedEvent Is Nothing) Then
                    Dim handler As securitymenu_roleRowChangeEventHandler = Me.securitymenu_roleRowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securitymenu_roleRowChangeEvent(DirectCast(e.Row, securitymenu_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securitymenu_roleRowDeletingEvent Is Nothing) Then
                    Dim handler As securitymenu_roleRowChangeEventHandler = Me.securitymenu_roleRowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securitymenu_roleRowChangeEvent(DirectCast(e.Row, securitymenu_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Removesecuritymenu_roleRow(ByVal row As securitymenu_roleRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As securitymenu_roleRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securitymenu_roleRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RoleIDColumn As DataColumn
                Get
                    Return Me.columnRoleID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnMenuID As DataColumn
            Private columnRoleID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securitymenu_roleRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecuritymenu_role = DirectCast(Me.Table, securitymenu_roleDataTable)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecuritymenu_role.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecuritymenu_role.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RoleID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecuritymenu_role.RoleIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecuritymenu_role.RoleIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecuritymenu_role As securitymenu_roleDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securitymenu_roleRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securitymenu_roleRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securitymenu_roleRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securitymenu_roleRow
        End Class

        Public Delegate Sub securitymenu_roleRowChangeEventHandler(ByVal sender As Object, ByVal e As securitymenu_roleRowChangeEvent)

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class securityroleDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityroleRowChanged As securityroleRowChangeEventHandler
            Public Event securityroleRowChanging As securityroleRowChangeEventHandler
            Public Event securityroleRowDeleted As securityroleRowChangeEventHandler
            Public Event securityroleRowDeleting As securityroleRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityroleDataTable.__ENCList
                SyncLock list
                    securityroleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityrole"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityroleDataTable.__ENCList
                SyncLock list
                    securityroleDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityroleDataTable.__ENCList
                SyncLock list
                    securityroleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsecurityroleRow(ByVal row As securityroleRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsecurityroleRow(ByVal RoleID As Integer, ByVal EntityID As Integer, ByVal Name As String, ByVal Description As String, ByVal CanModifyGlobalViews As Integer) As securityroleRow
                Dim row As securityroleRow = DirectCast(Me.NewRow, securityroleRow)
                row.ItemArray = New Object() { RoleID, EntityID, Name, Description, CanModifyGlobalViews }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityroleDataTable = DirectCast(MyBase.Clone, securityroleDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityroleDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByRoleID(ByVal RoleID As Integer) As securityroleRow
                Return DirectCast(Me.Rows.Find(New Object() { RoleID }), securityroleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityroleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityroleDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnRoleID = New DataColumn("RoleID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRoleID)
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnCanModifyGlobalViews = New DataColumn("CanModifyGlobalViews", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnCanModifyGlobalViews)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey11", New DataColumn() { Me.columnRoleID }, True))
                Me.columnRoleID.AllowDBNull = False
                Me.columnRoleID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnRoleID = MyBase.Columns.Item("RoleID")
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnCanModifyGlobalViews = MyBase.Columns.Item("CanModifyGlobalViews")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityroleRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsecurityroleRow() As securityroleRow
                Return DirectCast(Me.NewRow, securityroleRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityroleRowChangedEvent Is Nothing) Then
                    Dim securityroleRowChangedEvent As securityroleRowChangeEventHandler = Me.securityroleRowChangedEvent
                    If (Not securityroleRowChangedEvent Is Nothing) Then
                        securityroleRowChangedEvent.Invoke(Me, New securityroleRowChangeEvent(DirectCast(e.Row, securityroleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityroleRowChangingEvent Is Nothing) Then
                    Dim securityroleRowChangingEvent As securityroleRowChangeEventHandler = Me.securityroleRowChangingEvent
                    If (Not securityroleRowChangingEvent Is Nothing) Then
                        securityroleRowChangingEvent.Invoke(Me, New securityroleRowChangeEvent(DirectCast(e.Row, securityroleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityroleRowDeletedEvent Is Nothing) Then
                    Dim securityroleRowDeletedEvent As securityroleRowChangeEventHandler = Me.securityroleRowDeletedEvent
                    If (Not securityroleRowDeletedEvent Is Nothing) Then
                        securityroleRowDeletedEvent.Invoke(Me, New securityroleRowChangeEvent(DirectCast(e.Row, securityroleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityroleRowDeletingEvent Is Nothing) Then
                    Dim securityroleRowDeletingEvent As securityroleRowChangeEventHandler = Me.securityroleRowDeletingEvent
                    If (Not securityroleRowDeletingEvent Is Nothing) Then
                        securityroleRowDeletingEvent.Invoke(Me, New securityroleRowChangeEvent(DirectCast(e.Row, securityroleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesecurityroleRow(ByVal row As securityroleRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property CanModifyGlobalViewsColumn As DataColumn
                Get
                    Return Me.columnCanModifyGlobalViews
                End Get
            End Property

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
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityroleRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityroleRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RoleIDColumn As DataColumn
                Get
                    Return Me.columnRoleID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnCanModifyGlobalViews As DataColumn
            Private columnDescription As DataColumn
            Private columnEntityID As DataColumn
            Private columnName As DataColumn
            Private columnRoleID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityroleRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityrole = DirectCast(Me.Table, securityroleDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsCanModifyGlobalViewsNull() As Boolean
                Return Me.IsNull(Me.tablesecurityrole.CanModifyGlobalViewsColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablesecurityrole.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEntityIDNull() As Boolean
                Return Me.IsNull(Me.tablesecurityrole.EntityIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablesecurityrole.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetCanModifyGlobalViewsNull()
                Me.Item(Me.tablesecurityrole.CanModifyGlobalViewsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablesecurityrole.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEntityIDNull()
                Me.Item(Me.tablesecurityrole.EntityIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablesecurityrole.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property CanModifyGlobalViews As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityrole.CanModifyGlobalViewsColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'CanModifyGlobalViews' in table 'securityrole' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityrole.CanModifyGlobalViewsColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityrole.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'securityrole' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityrole.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityrole.EntityIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EntityID' in table 'securityrole' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityrole.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityrole.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'securityrole' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityrole.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RoleID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityrole.RoleIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityrole.RoleIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityrole As securityroleDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityroleRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityroleRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityroleRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityroleRow
        End Class

        Public Delegate Sub securityroleRowChangeEventHandler(ByVal sender As Object, ByVal e As securityroleRowChangeEvent)

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
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey8", New DataColumn() { Me.columnCurrCode }, True))
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

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
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
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey14", New DataColumn() { Me.columnExChangeID }, True))
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

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class systemdatabaseDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemdatabaseRowChanged As systemdatabaseRowChangeEventHandler
            Public Event systemdatabaseRowChanging As systemdatabaseRowChangeEventHandler
            Public Event systemdatabaseRowDeleted As systemdatabaseRowChangeEventHandler
            Public Event systemdatabaseRowDeleting As systemdatabaseRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemdatabaseDataTable.__ENCList
                SyncLock list
                    systemdatabaseDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemdatabase"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemdatabaseDataTable.__ENCList
                SyncLock list
                    systemdatabaseDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemdatabaseDataTable.__ENCList
                SyncLock list
                    systemdatabaseDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemdatabaseRow(ByVal row As systemdatabaseRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemdatabaseRow(ByVal DBName As String, ByVal Description As String, ByVal ConnectionString As String) As systemdatabaseRow
                Dim row As systemdatabaseRow = DirectCast(Me.NewRow, systemdatabaseRow)
                row.ItemArray = New Object() { DBName, Description, ConnectionString }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemdatabaseDataTable = DirectCast(MyBase.Clone, systemdatabaseDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemdatabaseDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByDBName(ByVal DBName As String) As systemdatabaseRow
                Return DirectCast(Me.Rows.Find(New Object() { DBName }), systemdatabaseRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemdatabaseRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemdatabaseDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnDBName = New DataColumn("DBName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDBName)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnConnectionString = New DataColumn("ConnectionString", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnConnectionString)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey15", New DataColumn() { Me.columnDBName }, True))
                Me.columnDBName.AllowDBNull = False
                Me.columnDBName.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnDBName = MyBase.Columns.Item("DBName")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnConnectionString = MyBase.Columns.Item("ConnectionString")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemdatabaseRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemdatabaseRow() As systemdatabaseRow
                Return DirectCast(Me.NewRow, systemdatabaseRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemdatabaseRowChangedEvent Is Nothing) Then
                    Dim systemdatabaseRowChangedEvent As systemdatabaseRowChangeEventHandler = Me.systemdatabaseRowChangedEvent
                    If (Not systemdatabaseRowChangedEvent Is Nothing) Then
                        systemdatabaseRowChangedEvent.Invoke(Me, New systemdatabaseRowChangeEvent(DirectCast(e.Row, systemdatabaseRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemdatabaseRowChangingEvent Is Nothing) Then
                    Dim systemdatabaseRowChangingEvent As systemdatabaseRowChangeEventHandler = Me.systemdatabaseRowChangingEvent
                    If (Not systemdatabaseRowChangingEvent Is Nothing) Then
                        systemdatabaseRowChangingEvent.Invoke(Me, New systemdatabaseRowChangeEvent(DirectCast(e.Row, systemdatabaseRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemdatabaseRowDeletedEvent Is Nothing) Then
                    Dim systemdatabaseRowDeletedEvent As systemdatabaseRowChangeEventHandler = Me.systemdatabaseRowDeletedEvent
                    If (Not systemdatabaseRowDeletedEvent Is Nothing) Then
                        systemdatabaseRowDeletedEvent.Invoke(Me, New systemdatabaseRowChangeEvent(DirectCast(e.Row, systemdatabaseRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemdatabaseRowDeletingEvent Is Nothing) Then
                    Dim systemdatabaseRowDeletingEvent As systemdatabaseRowChangeEventHandler = Me.systemdatabaseRowDeletingEvent
                    If (Not systemdatabaseRowDeletingEvent Is Nothing) Then
                        systemdatabaseRowDeletingEvent.Invoke(Me, New systemdatabaseRowChangeEvent(DirectCast(e.Row, systemdatabaseRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemdatabaseRow(ByVal row As systemdatabaseRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property ConnectionStringColumn As DataColumn
                Get
                    Return Me.columnConnectionString
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DBNameColumn As DataColumn
                Get
                    Return Me.columnDBName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemdatabaseRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemdatabaseRow)
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnConnectionString As DataColumn
            Private columnDBName As DataColumn
            Private columnDescription As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemdatabaseRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemdatabase = DirectCast(Me.Table, systemdatabaseDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsConnectionStringNull() As Boolean
                Return Me.IsNull(Me.tablesystemdatabase.ConnectionStringColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablesystemdatabase.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetConnectionStringNull()
                Me.Item(Me.tablesystemdatabase.ConnectionStringColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablesystemdatabase.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property ConnectionString As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemdatabase.ConnectionStringColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ConnectionString' in table 'systemdatabase' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemdatabase.ConnectionStringColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DBName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemdatabase.DBNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemdatabase.DBNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemdatabase.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'systemdatabase' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemdatabase.DescriptionColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemdatabase As systemdatabaseDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemdatabaseRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemdatabaseRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemdatabaseRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemdatabaseRow
        End Class

        Public Delegate Sub systemdatabaseRowChangeEventHandler(ByVal sender As Object, ByVal e As systemdatabaseRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class SystemKeyBoardDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event SystemKeyBoardRowChanged As SystemKeyBoardRowChangeEventHandler
            Public Event SystemKeyBoardRowChanging As SystemKeyBoardRowChangeEventHandler
            Public Event SystemKeyBoardRowDeleted As SystemKeyBoardRowChangeEventHandler
            Public Event SystemKeyBoardRowDeleting As SystemKeyBoardRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = SystemKeyBoardDataTable.__ENCList
                SyncLock list
                    SystemKeyBoardDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "SystemKeyBoard"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = SystemKeyBoardDataTable.__ENCList
                SyncLock list
                    SystemKeyBoardDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = SystemKeyBoardDataTable.__ENCList
                SyncLock list
                    SystemKeyBoardDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddSystemKeyBoardRow(ByVal row As SystemKeyBoardRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddSystemKeyBoardRow(ByVal KeyId As Integer, ByVal KeyLabel As String) As SystemKeyBoardRow
                Dim row As SystemKeyBoardRow = DirectCast(Me.NewRow, SystemKeyBoardRow)
                row.ItemArray = New Object() { KeyId, KeyLabel }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As SystemKeyBoardDataTable = DirectCast(MyBase.Clone, SystemKeyBoardDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New SystemKeyBoardDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByKeyId(ByVal KeyId As Integer) As SystemKeyBoardRow
                Return DirectCast(Me.Rows.Find(New Object() { KeyId }), SystemKeyBoardRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(SystemKeyBoardRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "SystemKeyBoardDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnKeyId = New DataColumn("KeyId", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnKeyId)
                Me.columnKeyLabel = New DataColumn("KeyLabel", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnKeyLabel)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey1", New DataColumn() { Me.columnKeyId }, True))
                Me.columnKeyId.AllowDBNull = False
                Me.columnKeyId.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnKeyId = MyBase.Columns.Item("KeyId")
                Me.columnKeyLabel = MyBase.Columns.Item("KeyLabel")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New SystemKeyBoardRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewSystemKeyBoardRow() As SystemKeyBoardRow
                Return DirectCast(Me.NewRow, SystemKeyBoardRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.SystemKeyBoardRowChangedEvent Is Nothing) Then
                    Dim systemKeyBoardRowChangedEvent As SystemKeyBoardRowChangeEventHandler = Me.SystemKeyBoardRowChangedEvent
                    If (Not systemKeyBoardRowChangedEvent Is Nothing) Then
                        systemKeyBoardRowChangedEvent.Invoke(Me, New SystemKeyBoardRowChangeEvent(DirectCast(e.Row, SystemKeyBoardRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.SystemKeyBoardRowChangingEvent Is Nothing) Then
                    Dim systemKeyBoardRowChangingEvent As SystemKeyBoardRowChangeEventHandler = Me.SystemKeyBoardRowChangingEvent
                    If (Not systemKeyBoardRowChangingEvent Is Nothing) Then
                        systemKeyBoardRowChangingEvent.Invoke(Me, New SystemKeyBoardRowChangeEvent(DirectCast(e.Row, SystemKeyBoardRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.SystemKeyBoardRowDeletedEvent Is Nothing) Then
                    Dim systemKeyBoardRowDeletedEvent As SystemKeyBoardRowChangeEventHandler = Me.SystemKeyBoardRowDeletedEvent
                    If (Not systemKeyBoardRowDeletedEvent Is Nothing) Then
                        systemKeyBoardRowDeletedEvent.Invoke(Me, New SystemKeyBoardRowChangeEvent(DirectCast(e.Row, SystemKeyBoardRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.SystemKeyBoardRowDeletingEvent Is Nothing) Then
                    Dim systemKeyBoardRowDeletingEvent As SystemKeyBoardRowChangeEventHandler = Me.SystemKeyBoardRowDeletingEvent
                    If (Not systemKeyBoardRowDeletingEvent Is Nothing) Then
                        systemKeyBoardRowDeletingEvent.Invoke(Me, New SystemKeyBoardRowChangeEvent(DirectCast(e.Row, SystemKeyBoardRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemoveSystemKeyBoardRow(ByVal row As SystemKeyBoardRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As SystemKeyBoardRow
                Get
                    Return DirectCast(Me.Rows.Item(index), SystemKeyBoardRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property KeyIdColumn As DataColumn
                Get
                    Return Me.columnKeyId
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property KeyLabelColumn As DataColumn
                Get
                    Return Me.columnKeyLabel
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnKeyId As DataColumn
            Private columnKeyLabel As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class SystemKeyBoardRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableSystemKeyBoard = DirectCast(Me.Table, SystemKeyBoardDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsKeyLabelNull() As Boolean
                Return Me.IsNull(Me.tableSystemKeyBoard.KeyLabelColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetKeyLabelNull()
                Me.Item(Me.tableSystemKeyBoard.KeyLabelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property KeyId As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tableSystemKeyBoard.KeyIdColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tableSystemKeyBoard.KeyIdColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property KeyLabel As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tableSystemKeyBoard.KeyLabelColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'KeyLabel' in table 'SystemKeyBoard' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tableSystemKeyBoard.KeyLabelColumn) = Value
                End Set
            End Property


            ' Fields
            Private tableSystemKeyBoard As SystemKeyBoardDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class SystemKeyBoardRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As SystemKeyBoardRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As SystemKeyBoardRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As SystemKeyBoardRow
        End Class

        Public Delegate Sub SystemKeyBoardRowChangeEventHandler(ByVal sender As Object, ByVal e As SystemKeyBoardRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
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
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey2", New DataColumn() { Me.columnLang }, True))
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

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class systemmenuDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmenuRowChanged As systemmenuRowChangeEventHandler
            Public Event systemmenuRowChanging As systemmenuRowChangeEventHandler
            Public Event systemmenuRowDeleted As systemmenuRowChangeEventHandler
            Public Event systemmenuRowDeleting As systemmenuRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmenuDataTable.__ENCList
                SyncLock list
                    systemmenuDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmenu"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmenuDataTable.__ENCList
                SyncLock list
                    systemmenuDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmenuDataTable.__ENCList
                SyncLock list
                    systemmenuDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmenuRow(ByVal row As systemmenuRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmenuRow(ByVal MenuID As Integer, ByVal MenuLabel As String, ByVal MenuForm As String, ByVal MenuIcon As String, ByVal MenuIconExpanded As String, ByVal MenuStartID As Integer, ByVal MenuStartCode As String, ByVal BrowseTableName As String, ByVal BrowseIDField As String, ByVal BrowseNameField As String, ByVal BrowseToMaintMenuID As Integer, ByVal BrowseWhereClause As String, ByVal BrowseOrderByClause As String, ByVal MenuStartCode2 As String, ByVal MenuAssembly As String, ByVal MenuLandScape As Boolean) As systemmenuRow
                Dim row As systemmenuRow = DirectCast(Me.NewRow, systemmenuRow)
                row.ItemArray = New Object() { MenuID, MenuLabel, MenuForm, MenuIcon, MenuIconExpanded, MenuStartID, MenuStartCode, BrowseTableName, BrowseIDField, BrowseNameField, BrowseToMaintMenuID, BrowseWhereClause, BrowseOrderByClause, MenuStartCode2, MenuAssembly, MenuLandScape }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmenuDataTable = DirectCast(MyBase.Clone, systemmenuDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmenuDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByMenuID(ByVal MenuID As Integer) As systemmenuRow
                Return DirectCast(Me.Rows.Find(New Object() { MenuID }), systemmenuRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmenuRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmenuDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnMenuLabel = New DataColumn("MenuLabel", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuLabel)
                Me.columnMenuForm = New DataColumn("MenuForm", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuForm)
                Me.columnMenuIcon = New DataColumn("MenuIcon", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuIcon)
                Me.columnMenuIconExpanded = New DataColumn("MenuIconExpanded", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuIconExpanded)
                Me.columnMenuStartID = New DataColumn("MenuStartID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartID)
                Me.columnMenuStartCode = New DataColumn("MenuStartCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartCode)
                Me.columnBrowseTableName = New DataColumn("BrowseTableName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseTableName)
                Me.columnBrowseIDField = New DataColumn("BrowseIDField", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseIDField)
                Me.columnBrowseNameField = New DataColumn("BrowseNameField", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseNameField)
                Me.columnBrowseToMaintMenuID = New DataColumn("BrowseToMaintMenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseToMaintMenuID)
                Me.columnBrowseWhereClause = New DataColumn("BrowseWhereClause", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseWhereClause)
                Me.columnBrowseOrderByClause = New DataColumn("BrowseOrderByClause", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseOrderByClause)
                Me.columnMenuStartCode2 = New DataColumn("MenuStartCode2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartCode2)
                Me.columnMenuAssembly = New DataColumn("MenuAssembly", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuAssembly)
                Me.columnMenuLandScape = New DataColumn("MenuLandScape", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuLandScape)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey3", New DataColumn() { Me.columnMenuID }, True))
                Me.columnMenuID.AllowDBNull = False
                Me.columnMenuID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnMenuLabel = MyBase.Columns.Item("MenuLabel")
                Me.columnMenuForm = MyBase.Columns.Item("MenuForm")
                Me.columnMenuIcon = MyBase.Columns.Item("MenuIcon")
                Me.columnMenuIconExpanded = MyBase.Columns.Item("MenuIconExpanded")
                Me.columnMenuStartID = MyBase.Columns.Item("MenuStartID")
                Me.columnMenuStartCode = MyBase.Columns.Item("MenuStartCode")
                Me.columnBrowseTableName = MyBase.Columns.Item("BrowseTableName")
                Me.columnBrowseIDField = MyBase.Columns.Item("BrowseIDField")
                Me.columnBrowseNameField = MyBase.Columns.Item("BrowseNameField")
                Me.columnBrowseToMaintMenuID = MyBase.Columns.Item("BrowseToMaintMenuID")
                Me.columnBrowseWhereClause = MyBase.Columns.Item("BrowseWhereClause")
                Me.columnBrowseOrderByClause = MyBase.Columns.Item("BrowseOrderByClause")
                Me.columnMenuStartCode2 = MyBase.Columns.Item("MenuStartCode2")
                Me.columnMenuAssembly = MyBase.Columns.Item("MenuAssembly")
                Me.columnMenuLandScape = MyBase.Columns.Item("MenuLandScape")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmenuRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmenuRow() As systemmenuRow
                Return DirectCast(Me.NewRow, systemmenuRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmenuRowChangedEvent Is Nothing) Then
                    Dim systemmenuRowChangedEvent As systemmenuRowChangeEventHandler = Me.systemmenuRowChangedEvent
                    If (Not systemmenuRowChangedEvent Is Nothing) Then
                        systemmenuRowChangedEvent.Invoke(Me, New systemmenuRowChangeEvent(DirectCast(e.Row, systemmenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmenuRowChangingEvent Is Nothing) Then
                    Dim systemmenuRowChangingEvent As systemmenuRowChangeEventHandler = Me.systemmenuRowChangingEvent
                    If (Not systemmenuRowChangingEvent Is Nothing) Then
                        systemmenuRowChangingEvent.Invoke(Me, New systemmenuRowChangeEvent(DirectCast(e.Row, systemmenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmenuRowDeletedEvent Is Nothing) Then
                    Dim systemmenuRowDeletedEvent As systemmenuRowChangeEventHandler = Me.systemmenuRowDeletedEvent
                    If (Not systemmenuRowDeletedEvent Is Nothing) Then
                        systemmenuRowDeletedEvent.Invoke(Me, New systemmenuRowChangeEvent(DirectCast(e.Row, systemmenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmenuRowDeletingEvent Is Nothing) Then
                    Dim systemmenuRowDeletingEvent As systemmenuRowChangeEventHandler = Me.systemmenuRowDeletingEvent
                    If (Not systemmenuRowDeletingEvent Is Nothing) Then
                        systemmenuRowDeletingEvent.Invoke(Me, New systemmenuRowChangeEvent(DirectCast(e.Row, systemmenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmenuRow(ByVal row As systemmenuRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseIDFieldColumn As DataColumn
                Get
                    Return Me.columnBrowseIDField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseNameFieldColumn As DataColumn
                Get
                    Return Me.columnBrowseNameField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseOrderByClauseColumn As DataColumn
                Get
                    Return Me.columnBrowseOrderByClause
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseTableNameColumn As DataColumn
                Get
                    Return Me.columnBrowseTableName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseToMaintMenuIDColumn As DataColumn
                Get
                    Return Me.columnBrowseToMaintMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseWhereClauseColumn As DataColumn
                Get
                    Return Me.columnBrowseWhereClause
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmenuRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmenuRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuAssemblyColumn As DataColumn
                Get
                    Return Me.columnMenuAssembly
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuFormColumn As DataColumn
                Get
                    Return Me.columnMenuForm
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIconColumn As DataColumn
                Get
                    Return Me.columnMenuIcon
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIconExpandedColumn As DataColumn
                Get
                    Return Me.columnMenuIconExpanded
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuLabelColumn As DataColumn
                Get
                    Return Me.columnMenuLabel
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuLandScapeColumn As DataColumn
                Get
                    Return Me.columnMenuLandScape
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartCode2Column As DataColumn
                Get
                    Return Me.columnMenuStartCode2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartCodeColumn As DataColumn
                Get
                    Return Me.columnMenuStartCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartIDColumn As DataColumn
                Get
                    Return Me.columnMenuStartID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnBrowseIDField As DataColumn
            Private columnBrowseNameField As DataColumn
            Private columnBrowseOrderByClause As DataColumn
            Private columnBrowseTableName As DataColumn
            Private columnBrowseToMaintMenuID As DataColumn
            Private columnBrowseWhereClause As DataColumn
            Private columnMenuAssembly As DataColumn
            Private columnMenuForm As DataColumn
            Private columnMenuIcon As DataColumn
            Private columnMenuIconExpanded As DataColumn
            Private columnMenuID As DataColumn
            Private columnMenuLabel As DataColumn
            Private columnMenuLandScape As DataColumn
            Private columnMenuStartCode As DataColumn
            Private columnMenuStartCode2 As DataColumn
            Private columnMenuStartID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenuRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmenu = DirectCast(Me.Table, systemmenuDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsBrowseIDFieldNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseIDFieldColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseNameFieldNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseNameFieldColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseOrderByClauseNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseOrderByClauseColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseTableNameNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseTableNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseToMaintMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseToMaintMenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseWhereClauseNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.BrowseWhereClauseColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuAssemblyNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuAssemblyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuFormNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuFormColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIconExpandedNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuIconExpandedColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIconNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuIconColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuLabelNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuLabelColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuLandScapeNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuLandScapeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartCode2Null() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuStartCode2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartCodeNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuStartCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuStartIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetBrowseIDFieldNull()
                Me.Item(Me.tablesystemmenu.BrowseIDFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseNameFieldNull()
                Me.Item(Me.tablesystemmenu.BrowseNameFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseOrderByClauseNull()
                Me.Item(Me.tablesystemmenu.BrowseOrderByClauseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseTableNameNull()
                Me.Item(Me.tablesystemmenu.BrowseTableNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseToMaintMenuIDNull()
                Me.Item(Me.tablesystemmenu.BrowseToMaintMenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseWhereClauseNull()
                Me.Item(Me.tablesystemmenu.BrowseWhereClauseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuAssemblyNull()
                Me.Item(Me.tablesystemmenu.MenuAssemblyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuFormNull()
                Me.Item(Me.tablesystemmenu.MenuFormColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIconExpandedNull()
                Me.Item(Me.tablesystemmenu.MenuIconExpandedColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIconNull()
                Me.Item(Me.tablesystemmenu.MenuIconColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuLabelNull()
                Me.Item(Me.tablesystemmenu.MenuLabelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuLandScapeNull()
                Me.Item(Me.tablesystemmenu.MenuLandScapeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartCode2Null()
                Me.Item(Me.tablesystemmenu.MenuStartCode2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartCodeNull()
                Me.Item(Me.tablesystemmenu.MenuStartCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartIDNull()
                Me.Item(Me.tablesystemmenu.MenuStartIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property BrowseIDField As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.BrowseIDFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseIDField' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.BrowseIDFieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseNameField As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.BrowseNameFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseNameField' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.BrowseNameFieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseOrderByClause As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.BrowseOrderByClauseColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseOrderByClause' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.BrowseOrderByClauseColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseTableName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.BrowseTableNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseTableName' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.BrowseTableNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseToMaintMenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenu.BrowseToMaintMenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseToMaintMenuID' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenu.BrowseToMaintMenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseWhereClause As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.BrowseWhereClauseColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseWhereClause' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.BrowseWhereClauseColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuAssembly As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuAssemblyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuAssembly' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuAssemblyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuForm As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuFormColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuForm' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuFormColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuIcon As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuIconColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuIcon' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuIconColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuIconExpanded As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuIconExpandedColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuIconExpanded' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuIconExpandedColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenu.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenu.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuLabel As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuLabelColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuLabel' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuLabelColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuLandScape As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablesystemmenu.MenuLandScapeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuLandScape' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablesystemmenu.MenuLandScapeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuStartCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartCode' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuStartCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartCode2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenu.MenuStartCode2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartCode2' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenu.MenuStartCode2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenu.MenuStartIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartID' in table 'systemmenu' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenu.MenuStartIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmenu As systemmenuDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenuRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmenuRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmenuRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmenuRow
        End Class

        Public Delegate Sub systemmenuRowChangeEventHandler(ByVal sender As Object, ByVal e As systemmenuRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class systemmenusubDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmenusubRowChanged As systemmenusubRowChangeEventHandler
            Public Event systemmenusubRowChanging As systemmenusubRowChangeEventHandler
            Public Event systemmenusubRowDeleted As systemmenusubRowChangeEventHandler
            Public Event systemmenusubRowDeleting As systemmenusubRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmenusubDataTable.__ENCList
                SyncLock list
                    systemmenusubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmenusub"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmenusubDataTable.__ENCList
                SyncLock list
                    systemmenusubDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmenusubDataTable.__ENCList
                SyncLock list
                    systemmenusubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmenusubRow(ByVal row As systemmenusubRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmenusubRow(ByVal MenuID As Integer, ByVal SubMenuID As Integer) As systemmenusubRow
                Dim row As systemmenusubRow = DirectCast(Me.NewRow, systemmenusubRow)
                row.ItemArray = New Object() { MenuID, SubMenuID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmenusubDataTable = DirectCast(MyBase.Clone, systemmenusubDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmenusubDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByMenuIDSubMenuID(ByVal MenuID As Integer, ByVal SubMenuID As Integer) As systemmenusubRow
                Return DirectCast(Me.Rows.Find(New Object() { MenuID, SubMenuID }), systemmenusubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmenusubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmenusubDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnSubMenuID = New DataColumn("SubMenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSubMenuID)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey7", New DataColumn() { Me.columnMenuID, Me.columnSubMenuID }, True))
                Me.columnMenuID.AllowDBNull = False
                Me.columnSubMenuID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnSubMenuID = MyBase.Columns.Item("SubMenuID")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmenusubRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmenusubRow() As systemmenusubRow
                Return DirectCast(Me.NewRow, systemmenusubRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmenusubRowChangedEvent Is Nothing) Then
                    Dim systemmenusubRowChangedEvent As systemmenusubRowChangeEventHandler = Me.systemmenusubRowChangedEvent
                    If (Not systemmenusubRowChangedEvent Is Nothing) Then
                        systemmenusubRowChangedEvent.Invoke(Me, New systemmenusubRowChangeEvent(DirectCast(e.Row, systemmenusubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmenusubRowChangingEvent Is Nothing) Then
                    Dim systemmenusubRowChangingEvent As systemmenusubRowChangeEventHandler = Me.systemmenusubRowChangingEvent
                    If (Not systemmenusubRowChangingEvent Is Nothing) Then
                        systemmenusubRowChangingEvent.Invoke(Me, New systemmenusubRowChangeEvent(DirectCast(e.Row, systemmenusubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmenusubRowDeletedEvent Is Nothing) Then
                    Dim systemmenusubRowDeletedEvent As systemmenusubRowChangeEventHandler = Me.systemmenusubRowDeletedEvent
                    If (Not systemmenusubRowDeletedEvent Is Nothing) Then
                        systemmenusubRowDeletedEvent.Invoke(Me, New systemmenusubRowChangeEvent(DirectCast(e.Row, systemmenusubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmenusubRowDeletingEvent Is Nothing) Then
                    Dim systemmenusubRowDeletingEvent As systemmenusubRowChangeEventHandler = Me.systemmenusubRowDeletingEvent
                    If (Not systemmenusubRowDeletingEvent Is Nothing) Then
                        systemmenusubRowDeletingEvent.Invoke(Me, New systemmenusubRowChangeEvent(DirectCast(e.Row, systemmenusubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmenusubRow(ByVal row As systemmenusubRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmenusubRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmenusubRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SubMenuIDColumn As DataColumn
                Get
                    Return Me.columnSubMenuID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnMenuID As DataColumn
            Private columnSubMenuID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenusubRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmenusub = DirectCast(Me.Table, systemmenusubDataTable)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenusub.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenusub.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SubMenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenusub.SubMenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenusub.SubMenuIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmenusub As systemmenusubDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenusubRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmenusubRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmenusubRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmenusubRow
        End Class

        Public Delegate Sub systemmenusubRowChangeEventHandler(ByVal sender As Object, ByVal e As systemmenusubRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutranslationDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmenutranslationRowChanged As systemmenutranslationRowChangeEventHandler
            Public Event systemmenutranslationRowChanging As systemmenutranslationRowChangeEventHandler
            Public Event systemmenutranslationRowDeleted As systemmenutranslationRowChangeEventHandler
            Public Event systemmenutranslationRowDeleting As systemmenutranslationRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmenutranslationDataTable.__ENCList
                SyncLock list
                    systemmenutranslationDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmenutranslation"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmenutranslationDataTable.__ENCList
                SyncLock list
                    systemmenutranslationDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmenutranslationDataTable.__ENCList
                SyncLock list
                    systemmenutranslationDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmenutranslationRow(ByVal row As systemmenutranslationRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmenutranslationRow(ByVal MenuID As Integer, ByVal Lang As String, ByVal MenuLabel As String) As systemmenutranslationRow
                Dim row As systemmenutranslationRow = DirectCast(Me.NewRow, systemmenutranslationRow)
                row.ItemArray = New Object() { MenuID, Lang, MenuLabel }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmenutranslationDataTable = DirectCast(MyBase.Clone, systemmenutranslationDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmenutranslationDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByMenuIDLang(ByVal MenuID As Integer, ByVal Lang As String) As systemmenutranslationRow
                Return DirectCast(Me.Rows.Find(New Object() { MenuID, Lang }), systemmenutranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmenutranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmenutranslationDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnMenuLabel = New DataColumn("MenuLabel", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuLabel)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey9", New DataColumn() { Me.columnMenuID, Me.columnLang }, True))
                Me.columnMenuID.AllowDBNull = False
                Me.columnLang.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnMenuLabel = MyBase.Columns.Item("MenuLabel")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmenutranslationRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmenutranslationRow() As systemmenutranslationRow
                Return DirectCast(Me.NewRow, systemmenutranslationRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmenutranslationRowChangedEvent Is Nothing) Then
                    Dim systemmenutranslationRowChangedEvent As systemmenutranslationRowChangeEventHandler = Me.systemmenutranslationRowChangedEvent
                    If (Not systemmenutranslationRowChangedEvent Is Nothing) Then
                        systemmenutranslationRowChangedEvent.Invoke(Me, New systemmenutranslationRowChangeEvent(DirectCast(e.Row, systemmenutranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmenutranslationRowChangingEvent Is Nothing) Then
                    Dim systemmenutranslationRowChangingEvent As systemmenutranslationRowChangeEventHandler = Me.systemmenutranslationRowChangingEvent
                    If (Not systemmenutranslationRowChangingEvent Is Nothing) Then
                        systemmenutranslationRowChangingEvent.Invoke(Me, New systemmenutranslationRowChangeEvent(DirectCast(e.Row, systemmenutranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmenutranslationRowDeletedEvent Is Nothing) Then
                    Dim systemmenutranslationRowDeletedEvent As systemmenutranslationRowChangeEventHandler = Me.systemmenutranslationRowDeletedEvent
                    If (Not systemmenutranslationRowDeletedEvent Is Nothing) Then
                        systemmenutranslationRowDeletedEvent.Invoke(Me, New systemmenutranslationRowChangeEvent(DirectCast(e.Row, systemmenutranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmenutranslationRowDeletingEvent Is Nothing) Then
                    Dim systemmenutranslationRowDeletingEvent As systemmenutranslationRowChangeEventHandler = Me.systemmenutranslationRowDeletingEvent
                    If (Not systemmenutranslationRowDeletingEvent Is Nothing) Then
                        systemmenutranslationRowDeletingEvent.Invoke(Me, New systemmenutranslationRowChangeEvent(DirectCast(e.Row, systemmenutranslationRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmenutranslationRow(ByVal row As systemmenutranslationRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmenutranslationRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmenutranslationRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuLabelColumn As DataColumn
                Get
                    Return Me.columnMenuLabel
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnLang As DataColumn
            Private columnMenuID As DataColumn
            Private columnMenuLabel As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutranslationRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmenutranslation = DirectCast(Me.Table, systemmenutranslationDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsMenuLabelNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutranslation.MenuLabelColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetMenuLabelNull()
                Me.Item(Me.tablesystemmenutranslation.MenuLabelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemmenutranslation.LangColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutranslation.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenutranslation.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutranslation.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuLabel As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutranslation.MenuLabelColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuLabel' in table 'systemmenutranslation' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutranslation.MenuLabelColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmenutranslation As systemmenutranslationDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutranslationRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmenutranslationRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmenutranslationRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmenutranslationRow
        End Class

        Public Delegate Sub systemmenutranslationRowChangeEventHandler(ByVal sender As Object, ByVal e As systemmenutranslationRowChangeEvent)

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutreeDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmenutreeRowChanged As systemmenutreeRowChangeEventHandler
            Public Event systemmenutreeRowChanging As systemmenutreeRowChangeEventHandler
            Public Event systemmenutreeRowDeleted As systemmenutreeRowChangeEventHandler
            Public Event systemmenutreeRowDeleting As systemmenutreeRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmenutreeDataTable.__ENCList
                SyncLock list
                    systemmenutreeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmenutree"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmenutreeDataTable.__ENCList
                SyncLock list
                    systemmenutreeDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmenutreeDataTable.__ENCList
                SyncLock list
                    systemmenutreeDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmenutreeRow(ByVal row As systemmenutreeRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmenutreeRow(ByVal ParentID As Integer, ByVal MenuID As Integer, ByVal Sequence As Integer) As systemmenutreeRow
                Dim row As systemmenutreeRow = DirectCast(Me.NewRow, systemmenutreeRow)
                row.ItemArray = New Object() { ParentID, MenuID, Sequence }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmenutreeDataTable = DirectCast(MyBase.Clone, systemmenutreeDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmenutreeDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByParentIDMenuID(ByVal ParentID As Integer, ByVal MenuID As Integer) As systemmenutreeRow
                Return DirectCast(Me.Rows.Find(New Object() { ParentID, MenuID }), systemmenutreeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmenutreeRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmenutreeDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnParentID = New DataColumn("ParentID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnParentID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnSequence = New DataColumn("Sequence", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSequence)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey4", New DataColumn() { Me.columnParentID, Me.columnMenuID }, True))
                Me.columnParentID.AllowDBNull = False
                Me.columnMenuID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnParentID = MyBase.Columns.Item("ParentID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnSequence = MyBase.Columns.Item("Sequence")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmenutreeRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmenutreeRow() As systemmenutreeRow
                Return DirectCast(Me.NewRow, systemmenutreeRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmenutreeRowChangedEvent Is Nothing) Then
                    Dim systemmenutreeRowChangedEvent As systemmenutreeRowChangeEventHandler = Me.systemmenutreeRowChangedEvent
                    If (Not systemmenutreeRowChangedEvent Is Nothing) Then
                        systemmenutreeRowChangedEvent.Invoke(Me, New systemmenutreeRowChangeEvent(DirectCast(e.Row, systemmenutreeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmenutreeRowChangingEvent Is Nothing) Then
                    Dim systemmenutreeRowChangingEvent As systemmenutreeRowChangeEventHandler = Me.systemmenutreeRowChangingEvent
                    If (Not systemmenutreeRowChangingEvent Is Nothing) Then
                        systemmenutreeRowChangingEvent.Invoke(Me, New systemmenutreeRowChangeEvent(DirectCast(e.Row, systemmenutreeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmenutreeRowDeletedEvent Is Nothing) Then
                    Dim systemmenutreeRowDeletedEvent As systemmenutreeRowChangeEventHandler = Me.systemmenutreeRowDeletedEvent
                    If (Not systemmenutreeRowDeletedEvent Is Nothing) Then
                        systemmenutreeRowDeletedEvent.Invoke(Me, New systemmenutreeRowChangeEvent(DirectCast(e.Row, systemmenutreeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmenutreeRowDeletingEvent Is Nothing) Then
                    Dim systemmenutreeRowDeletingEvent As systemmenutreeRowChangeEventHandler = Me.systemmenutreeRowDeletingEvent
                    If (Not systemmenutreeRowDeletingEvent Is Nothing) Then
                        systemmenutreeRowDeletingEvent.Invoke(Me, New systemmenutreeRowChangeEvent(DirectCast(e.Row, systemmenutreeRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmenutreeRow(ByVal row As systemmenutreeRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmenutreeRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmenutreeRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ParentIDColumn As DataColumn
                Get
                    Return Me.columnParentID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SequenceColumn As DataColumn
                Get
                    Return Me.columnSequence
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnMenuID As DataColumn
            Private columnParentID As DataColumn
            Private columnSequence As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutreeRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmenutree = DirectCast(Me.Table, systemmenutreeDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsSequenceNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutree.SequenceColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetSequenceNull()
                Me.Item(Me.tablesystemmenutree.SequenceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenutree.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutree.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ParentID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenutree.ParentIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutree.ParentIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Sequence As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenutree.SequenceColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Sequence' in table 'systemmenutree' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutree.SequenceColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmenutree As systemmenutreeDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutreeRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmenutreeRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmenutreeRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmenutreeRow
        End Class

        Public Delegate Sub systemmenutreeRowChangeEventHandler(ByVal sender As Object, ByVal e As systemmenutreeRowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item")> _
        Public Class systemmenutreeView1DataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmenutreeView1RowChanged As systemmenutreeView1RowChangeEventHandler
            Public Event systemmenutreeView1RowChanging As systemmenutreeView1RowChangeEventHandler
            Public Event systemmenutreeView1RowDeleted As systemmenutreeView1RowChangeEventHandler
            Public Event systemmenutreeView1RowDeleting As systemmenutreeView1RowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmenutreeView1DataTable.__ENCList
                SyncLock list
                    systemmenutreeView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmenutreeView1"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmenutreeView1DataTable.__ENCList
                SyncLock list
                    systemmenutreeView1DataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmenutreeView1DataTable.__ENCList
                SyncLock list
                    systemmenutreeView1DataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmenutreeView1Row(ByVal row As systemmenutreeView1Row)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmenutreeView1Row(ByVal ParentID As Integer, ByVal MenuID As Integer, ByVal MenuLabel As String, ByVal MenuForm As String, ByVal MenuIcon As String, ByVal MenuIconExpanded As String, ByVal Sequence As Integer, ByVal MenuStartID As Integer, ByVal MenuStartCode As String, ByVal MenuStartCode2 As String, ByVal BrowseTableName As String, ByVal BrowseIDField As String, ByVal BrowseNameField As String, ByVal BrowseToMaintMenuID As Integer, ByVal BrowseWhereClause As String, ByVal BrowseOrderByClause As String, ByVal AccessAllowed As Boolean) As systemmenutreeView1Row
                Dim row As systemmenutreeView1Row = DirectCast(Me.NewRow, systemmenutreeView1Row)
                row.ItemArray = New Object() { ParentID, MenuID, MenuLabel, MenuForm, MenuIcon, MenuIconExpanded, Sequence, MenuStartID, MenuStartCode, MenuStartCode2, BrowseTableName, BrowseIDField, BrowseNameField, BrowseToMaintMenuID, BrowseWhereClause, BrowseOrderByClause, AccessAllowed }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmenutreeView1DataTable = DirectCast(MyBase.Clone, systemmenutreeView1DataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmenutreeView1DataTable
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmenutreeView1Row)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmenutreeView1DataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnParentID = New DataColumn("ParentID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnParentID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.columnMenuLabel = New DataColumn("MenuLabel", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuLabel)
                Me.columnMenuForm = New DataColumn("MenuForm", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuForm)
                Me.columnMenuIcon = New DataColumn("MenuIcon", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuIcon)
                Me.columnMenuIconExpanded = New DataColumn("MenuIconExpanded", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuIconExpanded)
                Me.columnSequence = New DataColumn("Sequence", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSequence)
                Me.columnMenuStartID = New DataColumn("MenuStartID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartID)
                Me.columnMenuStartCode = New DataColumn("MenuStartCode", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartCode)
                Me.columnMenuStartCode2 = New DataColumn("MenuStartCode2", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuStartCode2)
                Me.columnBrowseTableName = New DataColumn("BrowseTableName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseTableName)
                Me.columnBrowseIDField = New DataColumn("BrowseIDField", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseIDField)
                Me.columnBrowseNameField = New DataColumn("BrowseNameField", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseNameField)
                Me.columnBrowseToMaintMenuID = New DataColumn("BrowseToMaintMenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseToMaintMenuID)
                Me.columnBrowseWhereClause = New DataColumn("BrowseWhereClause", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseWhereClause)
                Me.columnBrowseOrderByClause = New DataColumn("BrowseOrderByClause", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBrowseOrderByClause)
                Me.columnAccessAllowed = New DataColumn("AccessAllowed", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAccessAllowed)
                Me.columnParentID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnParentID = MyBase.Columns.Item("ParentID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
                Me.columnMenuLabel = MyBase.Columns.Item("MenuLabel")
                Me.columnMenuForm = MyBase.Columns.Item("MenuForm")
                Me.columnMenuIcon = MyBase.Columns.Item("MenuIcon")
                Me.columnMenuIconExpanded = MyBase.Columns.Item("MenuIconExpanded")
                Me.columnSequence = MyBase.Columns.Item("Sequence")
                Me.columnMenuStartID = MyBase.Columns.Item("MenuStartID")
                Me.columnMenuStartCode = MyBase.Columns.Item("MenuStartCode")
                Me.columnMenuStartCode2 = MyBase.Columns.Item("MenuStartCode2")
                Me.columnBrowseTableName = MyBase.Columns.Item("BrowseTableName")
                Me.columnBrowseIDField = MyBase.Columns.Item("BrowseIDField")
                Me.columnBrowseNameField = MyBase.Columns.Item("BrowseNameField")
                Me.columnBrowseToMaintMenuID = MyBase.Columns.Item("BrowseToMaintMenuID")
                Me.columnBrowseWhereClause = MyBase.Columns.Item("BrowseWhereClause")
                Me.columnBrowseOrderByClause = MyBase.Columns.Item("BrowseOrderByClause")
                Me.columnAccessAllowed = MyBase.Columns.Item("AccessAllowed")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmenutreeView1Row(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmenutreeView1Row() As systemmenutreeView1Row
                Return DirectCast(Me.NewRow, systemmenutreeView1Row)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmenutreeView1RowChangedEvent Is Nothing) Then
                    Dim handler As systemmenutreeView1RowChangeEventHandler = Me.systemmenutreeView1RowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New systemmenutreeView1RowChangeEvent(DirectCast(e.Row, systemmenutreeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmenutreeView1RowChangingEvent Is Nothing) Then
                    Dim handler As systemmenutreeView1RowChangeEventHandler = Me.systemmenutreeView1RowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New systemmenutreeView1RowChangeEvent(DirectCast(e.Row, systemmenutreeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmenutreeView1RowDeletedEvent Is Nothing) Then
                    Dim handler As systemmenutreeView1RowChangeEventHandler = Me.systemmenutreeView1RowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New systemmenutreeView1RowChangeEvent(DirectCast(e.Row, systemmenutreeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmenutreeView1RowDeletingEvent Is Nothing) Then
                    Dim handler As systemmenutreeView1RowChangeEventHandler = Me.systemmenutreeView1RowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New systemmenutreeView1RowChangeEvent(DirectCast(e.Row, systemmenutreeView1Row), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmenutreeView1Row(ByVal row As systemmenutreeView1Row)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AccessAllowedColumn As DataColumn
                Get
                    Return Me.columnAccessAllowed
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseIDFieldColumn As DataColumn
                Get
                    Return Me.columnBrowseIDField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseNameFieldColumn As DataColumn
                Get
                    Return Me.columnBrowseNameField
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseOrderByClauseColumn As DataColumn
                Get
                    Return Me.columnBrowseOrderByClause
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseTableNameColumn As DataColumn
                Get
                    Return Me.columnBrowseTableName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseToMaintMenuIDColumn As DataColumn
                Get
                    Return Me.columnBrowseToMaintMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BrowseWhereClauseColumn As DataColumn
                Get
                    Return Me.columnBrowseWhereClause
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmenutreeView1Row
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmenutreeView1Row)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuFormColumn As DataColumn
                Get
                    Return Me.columnMenuForm
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIconColumn As DataColumn
                Get
                    Return Me.columnMenuIcon
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIconExpandedColumn As DataColumn
                Get
                    Return Me.columnMenuIconExpanded
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuLabelColumn As DataColumn
                Get
                    Return Me.columnMenuLabel
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartCode2Column As DataColumn
                Get
                    Return Me.columnMenuStartCode2
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartCodeColumn As DataColumn
                Get
                    Return Me.columnMenuStartCode
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuStartIDColumn As DataColumn
                Get
                    Return Me.columnMenuStartID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ParentIDColumn As DataColumn
                Get
                    Return Me.columnParentID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SequenceColumn As DataColumn
                Get
                    Return Me.columnSequence
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAccessAllowed As DataColumn
            Private columnBrowseIDField As DataColumn
            Private columnBrowseNameField As DataColumn
            Private columnBrowseOrderByClause As DataColumn
            Private columnBrowseTableName As DataColumn
            Private columnBrowseToMaintMenuID As DataColumn
            Private columnBrowseWhereClause As DataColumn
            Private columnMenuForm As DataColumn
            Private columnMenuIcon As DataColumn
            Private columnMenuIconExpanded As DataColumn
            Private columnMenuID As DataColumn
            Private columnMenuLabel As DataColumn
            Private columnMenuStartCode As DataColumn
            Private columnMenuStartCode2 As DataColumn
            Private columnMenuStartID As DataColumn
            Private columnParentID As DataColumn
            Private columnSequence As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutreeView1Row
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmenutreeView1 = DirectCast(Me.Table, systemmenutreeView1DataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAccessAllowedNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.AccessAllowedColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseIDFieldNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseIDFieldColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseNameFieldNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseNameFieldColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseOrderByClauseNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseOrderByClauseColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseTableNameNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseTableNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseToMaintMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseToMaintMenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBrowseWhereClauseNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.BrowseWhereClauseColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuFormNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuFormColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIconExpandedNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuIconExpandedColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIconNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuIconColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuLabelNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuLabelColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartCode2Null() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuStartCode2Column)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartCodeNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuStartCodeColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsMenuStartIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.MenuStartIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSequenceNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenutreeView1.SequenceColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAccessAllowedNull()
                Me.Item(Me.tablesystemmenutreeView1.AccessAllowedColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseIDFieldNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseIDFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseNameFieldNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseNameFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseOrderByClauseNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseOrderByClauseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseTableNameNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseTableNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseToMaintMenuIDNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseToMaintMenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBrowseWhereClauseNull()
                Me.Item(Me.tablesystemmenutreeView1.BrowseWhereClauseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuFormNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuFormColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIconExpandedNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuIconExpandedColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIconNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuIconColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuIDNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuLabelNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuLabelColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartCode2Null()
                Me.Item(Me.tablesystemmenutreeView1.MenuStartCode2Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartCodeNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuStartCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetMenuStartIDNull()
                Me.Item(Me.tablesystemmenutreeView1.MenuStartIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSequenceNull()
                Me.Item(Me.tablesystemmenutreeView1.SequenceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AccessAllowed As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablesystemmenutreeView1.AccessAllowedColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AccessAllowed' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablesystemmenutreeView1.AccessAllowedColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseIDField As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.BrowseIDFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseIDField' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseIDFieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseNameField As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.BrowseNameFieldColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseNameField' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseNameFieldColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseOrderByClause As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.BrowseOrderByClauseColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseOrderByClause' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseOrderByClauseColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseTableName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.BrowseTableNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseTableName' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseTableNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseToMaintMenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenutreeView1.BrowseToMaintMenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseToMaintMenuID' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseToMaintMenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BrowseWhereClause As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.BrowseWhereClauseColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BrowseWhereClause' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.BrowseWhereClauseColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuForm As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuFormColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuForm' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuFormColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuIcon As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuIconColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuIcon' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuIconColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuIconExpanded As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuIconExpandedColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuIconExpanded' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuIconExpandedColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenutreeView1.MenuIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuID' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutreeView1.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuLabel As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuLabelColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuLabel' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuLabelColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartCode As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuStartCodeColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartCode' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuStartCodeColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartCode2 As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmenutreeView1.MenuStartCode2Column))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartCode2' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmenutreeView1.MenuStartCode2Column) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MenuStartID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenutreeView1.MenuStartIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MenuStartID' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutreeView1.MenuStartIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ParentID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmenutreeView1.ParentIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutreeView1.ParentIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Sequence As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemmenutreeView1.SequenceColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Sequence' in table 'systemmenutreeView1' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmenutreeView1.SequenceColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmenutreeView1 As systemmenutreeView1DataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmenutreeView1RowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmenutreeView1Row, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmenutreeView1Row
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmenutreeView1Row
        End Class

        Public Delegate Sub systemmenutreeView1RowChangeEventHandler(ByVal sender As Object, ByVal e As systemmenutreeView1RowChangeEvent)

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmessageDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemmessageRowChanged As systemmessageRowChangeEventHandler
            Public Event systemmessageRowChanging As systemmessageRowChangeEventHandler
            Public Event systemmessageRowDeleted As systemmessageRowChangeEventHandler
            Public Event systemmessageRowDeleting As systemmessageRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemmessageDataTable.__ENCList
                SyncLock list
                    systemmessageDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemmessage"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemmessageDataTable.__ENCList
                SyncLock list
                    systemmessageDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemmessageDataTable.__ENCList
                SyncLock list
                    systemmessageDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemmessageRow(ByVal row As systemmessageRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemmessageRow(ByVal MessageID As Integer, ByVal Lang As String, ByVal MessageBody As String) As systemmessageRow
                Dim row As systemmessageRow = DirectCast(Me.NewRow, systemmessageRow)
                row.ItemArray = New Object() { MessageID, Lang, MessageBody }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemmessageDataTable = DirectCast(MyBase.Clone, systemmessageDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemmessageDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByMessageIDLang(ByVal MessageID As Integer, ByVal Lang As String) As systemmessageRow
                Return DirectCast(Me.Rows.Find(New Object() { MessageID, Lang }), systemmessageRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemmessageRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemmessageDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnMessageID = New DataColumn("MessageID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMessageID)
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnMessageBody = New DataColumn("MessageBody", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMessageBody)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey5", New DataColumn() { Me.columnMessageID, Me.columnLang }, True))
                Me.columnMessageID.AllowDBNull = False
                Me.columnLang.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnMessageID = MyBase.Columns.Item("MessageID")
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnMessageBody = MyBase.Columns.Item("MessageBody")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemmessageRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemmessageRow() As systemmessageRow
                Return DirectCast(Me.NewRow, systemmessageRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemmessageRowChangedEvent Is Nothing) Then
                    Dim systemmessageRowChangedEvent As systemmessageRowChangeEventHandler = Me.systemmessageRowChangedEvent
                    If (Not systemmessageRowChangedEvent Is Nothing) Then
                        systemmessageRowChangedEvent.Invoke(Me, New systemmessageRowChangeEvent(DirectCast(e.Row, systemmessageRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemmessageRowChangingEvent Is Nothing) Then
                    Dim systemmessageRowChangingEvent As systemmessageRowChangeEventHandler = Me.systemmessageRowChangingEvent
                    If (Not systemmessageRowChangingEvent Is Nothing) Then
                        systemmessageRowChangingEvent.Invoke(Me, New systemmessageRowChangeEvent(DirectCast(e.Row, systemmessageRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemmessageRowDeletedEvent Is Nothing) Then
                    Dim systemmessageRowDeletedEvent As systemmessageRowChangeEventHandler = Me.systemmessageRowDeletedEvent
                    If (Not systemmessageRowDeletedEvent Is Nothing) Then
                        systemmessageRowDeletedEvent.Invoke(Me, New systemmessageRowChangeEvent(DirectCast(e.Row, systemmessageRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemmessageRowDeletingEvent Is Nothing) Then
                    Dim systemmessageRowDeletingEvent As systemmessageRowChangeEventHandler = Me.systemmessageRowDeletingEvent
                    If (Not systemmessageRowDeletingEvent Is Nothing) Then
                        systemmessageRowDeletingEvent.Invoke(Me, New systemmessageRowChangeEvent(DirectCast(e.Row, systemmessageRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemmessageRow(ByVal row As systemmessageRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemmessageRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemmessageRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MessageBodyColumn As DataColumn
                Get
                    Return Me.columnMessageBody
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MessageIDColumn As DataColumn
                Get
                    Return Me.columnMessageID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnLang As DataColumn
            Private columnMessageBody As DataColumn
            Private columnMessageID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmessageRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemmessage = DirectCast(Me.Table, systemmessageDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsMessageBodyNull() As Boolean
                Return Me.IsNull(Me.tablesystemmessage.MessageBodyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetMessageBodyNull()
                Me.Item(Me.tablesystemmessage.MessageBodyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemmessage.LangColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmessage.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MessageBody As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesystemmessage.MessageBodyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'MessageBody' in table 'systemmessage' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemmessage.MessageBodyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property MessageID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesystemmessage.MessageIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemmessage.MessageIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemmessage As systemmessageDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemmessageRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemmessageRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemmessageRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemmessageRow
        End Class

        Public Delegate Sub systemmessageRowChangeEventHandler(ByVal sender As Object, ByVal e As systemmessageRowChangeEvent)

        <Serializable, DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class systemsequenceDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event systemsequenceRowChanged As systemsequenceRowChangeEventHandler
            Public Event systemsequenceRowChanging As systemsequenceRowChangeEventHandler
            Public Event systemsequenceRowDeleted As systemsequenceRowChangeEventHandler
            Public Event systemsequenceRowDeleting As systemsequenceRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = systemsequenceDataTable.__ENCList
                SyncLock list
                    systemsequenceDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "systemsequence"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = systemsequenceDataTable.__ENCList
                SyncLock list
                    systemsequenceDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = systemsequenceDataTable.__ENCList
                SyncLock list
                    systemsequenceDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsystemsequenceRow(ByVal row As systemsequenceRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsystemsequenceRow(ByVal KeyName As String, ByVal Nextvalue As Integer, ByVal Increment As Integer) As systemsequenceRow
                Dim row As systemsequenceRow = DirectCast(Me.NewRow, systemsequenceRow)
                row.ItemArray = New Object() { KeyName, Nextvalue, Increment }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As systemsequenceDataTable = DirectCast(MyBase.Clone, systemsequenceDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New systemsequenceDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByKeyName(ByVal KeyName As String) As systemsequenceRow
                Return DirectCast(Me.Rows.Find(New Object() { KeyName }), systemsequenceRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(systemsequenceRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim system As New dsSystem
                xs.Add(system.GetSchemaSerializable)
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
                attribute.FixedValue = system.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "systemsequenceDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnKeyName = New DataColumn("KeyName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnKeyName)
                Me.columnNextvalue = New DataColumn("Nextvalue", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnNextvalue)
                Me.columnIncrement = New DataColumn("Increment", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnIncrement)
                Me.Constraints.Add(New UniqueConstraint("dsSystemKey6", New DataColumn() { Me.columnKeyName }, True))
                Me.columnKeyName.AllowDBNull = False
                Me.columnKeyName.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnKeyName = MyBase.Columns.Item("KeyName")
                Me.columnNextvalue = MyBase.Columns.Item("Nextvalue")
                Me.columnIncrement = MyBase.Columns.Item("Increment")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New systemsequenceRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsystemsequenceRow() As systemsequenceRow
                Return DirectCast(Me.NewRow, systemsequenceRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.systemsequenceRowChangedEvent Is Nothing) Then
                    Dim systemsequenceRowChangedEvent As systemsequenceRowChangeEventHandler = Me.systemsequenceRowChangedEvent
                    If (Not systemsequenceRowChangedEvent Is Nothing) Then
                        systemsequenceRowChangedEvent.Invoke(Me, New systemsequenceRowChangeEvent(DirectCast(e.Row, systemsequenceRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.systemsequenceRowChangingEvent Is Nothing) Then
                    Dim systemsequenceRowChangingEvent As systemsequenceRowChangeEventHandler = Me.systemsequenceRowChangingEvent
                    If (Not systemsequenceRowChangingEvent Is Nothing) Then
                        systemsequenceRowChangingEvent.Invoke(Me, New systemsequenceRowChangeEvent(DirectCast(e.Row, systemsequenceRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.systemsequenceRowDeletedEvent Is Nothing) Then
                    Dim systemsequenceRowDeletedEvent As systemsequenceRowChangeEventHandler = Me.systemsequenceRowDeletedEvent
                    If (Not systemsequenceRowDeletedEvent Is Nothing) Then
                        systemsequenceRowDeletedEvent.Invoke(Me, New systemsequenceRowChangeEvent(DirectCast(e.Row, systemsequenceRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.systemsequenceRowDeletingEvent Is Nothing) Then
                    Dim systemsequenceRowDeletingEvent As systemsequenceRowChangeEventHandler = Me.systemsequenceRowDeletingEvent
                    If (Not systemsequenceRowDeletingEvent Is Nothing) Then
                        systemsequenceRowDeletingEvent.Invoke(Me, New systemsequenceRowChangeEvent(DirectCast(e.Row, systemsequenceRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesystemsequenceRow(ByVal row As systemsequenceRow)
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
            Public ReadOnly Property IncrementColumn As DataColumn
                Get
                    Return Me.columnIncrement
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As systemsequenceRow
                Get
                    Return DirectCast(Me.Rows.Item(index), systemsequenceRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property KeyNameColumn As DataColumn
                Get
                    Return Me.columnKeyName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NextvalueColumn As DataColumn
                Get
                    Return Me.columnNextvalue
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnIncrement As DataColumn
            Private columnKeyName As DataColumn
            Private columnNextvalue As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemsequenceRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesystemsequence = DirectCast(Me.Table, systemsequenceDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsIncrementNull() As Boolean
                Return Me.IsNull(Me.tablesystemsequence.IncrementColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNextvalueNull() As Boolean
                Return Me.IsNull(Me.tablesystemsequence.NextvalueColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetIncrementNull()
                Me.Item(Me.tablesystemsequence.IncrementColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNextvalueNull()
                Me.Item(Me.tablesystemsequence.NextvalueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property Increment As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemsequence.IncrementColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Increment' in table 'systemsequence' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemsequence.IncrementColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property KeyName As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesystemsequence.KeyNameColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesystemsequence.KeyNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Nextvalue As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesystemsequence.NextvalueColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Nextvalue' in table 'systemsequence' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesystemsequence.NextvalueColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesystemsequence As systemsequenceDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class systemsequenceRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As systemsequenceRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As systemsequenceRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As systemsequenceRow
        End Class

        Public Delegate Sub systemsequenceRowChangeEventHandler(ByVal sender As Object, ByVal e As systemsequenceRowChangeEvent)
    End Class
End Namespace

