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
    <Serializable, XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(True), DesignerCategory("code"), XmlRoot("dsSecurity"), HelpKeyword("vs.data.DataSet"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
    Public Class dsSecurity
        Inherits DataSet
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Dim list As ArrayList = dsSecurity.__ENCList
            SyncLock list
                dsSecurity.__ENCList.Add(New WeakReference(Me))
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
            Dim list As ArrayList = dsSecurity.__ENCList
            SyncLock list
                dsSecurity.__ENCList.Add(New WeakReference(Me))
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
                    If (Not dataSet.Tables.Item("securityuser_role") Is Nothing) Then
                        MyBase.Tables.Add(New securityuser_roleDataTable(dataSet.Tables.Item("securityuser_role")))
                    End If
                    If (Not dataSet.Tables.Item("securityusermenu") Is Nothing) Then
                        MyBase.Tables.Add(New securityusermenuDataTable(dataSet.Tables.Item("securityusermenu")))
                    End If
                    If (Not dataSet.Tables.Item("generalentity") Is Nothing) Then
                        MyBase.Tables.Add(New generalentityDataTable(dataSet.Tables.Item("generalentity")))
                    End If
                    If (Not dataSet.Tables.Item("securityshortcut") Is Nothing) Then
                        MyBase.Tables.Add(New securityshortcutDataTable(dataSet.Tables.Item("securityshortcut")))
                    End If
                    If (Not dataSet.Tables.Item("securityshortcutsub") Is Nothing) Then
                        MyBase.Tables.Add(New securityshortcutsubDataTable(dataSet.Tables.Item("securityshortcutsub")))
                    End If
                    If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                        MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                    End If
                    If (Not dataSet.Tables.Item("securityrole") Is Nothing) Then
                        MyBase.Tables.Add(New securityroleDataTable(dataSet.Tables.Item("securityrole")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenu") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenuDataTable(dataSet.Tables.Item("systemmenu")))
                    End If
                    If (Not dataSet.Tables.Item("securitymenu_role") Is Nothing) Then
                        MyBase.Tables.Add(New securitymenu_roleDataTable(dataSet.Tables.Item("securitymenu_role")))
                    End If
                    If (Not dataSet.Tables.Item("securityrole_entity") Is Nothing) Then
                        MyBase.Tables.Add(New securityrole_entityDataTable(dataSet.Tables.Item("securityrole_entity")))
                    End If
                    If (Not dataSet.Tables.Item("systemmenutree") Is Nothing) Then
                        MyBase.Tables.Add(New systemmenutreeDataTable(dataSet.Tables.Item("systemmenutree")))
                    End If
                    If (Not dataSet.Tables.Item("securityuser") Is Nothing) Then
                        MyBase.Tables.Add(New securityuserDataTable(dataSet.Tables.Item("securityuser")))
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
            Dim security As dsSecurity = DirectCast(MyBase.Clone, dsSecurity)
            security.InitVars
            security.SchemaSerializationMode = Me.SchemaSerializationMode
            Return security
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
            Dim security As New dsSecurity
            Dim type2 As New XmlSchemaComplexType
            Dim sequence As New XmlSchemaSequence
            xs.Add(security.GetSchemaSerializable)
            Dim item As New XmlSchemaAny
            item.Namespace = security.Namespace
            sequence.Items.Add(item)
            type2.Particle = sequence
            Return type2
        End Function

        <DebuggerNonUserCode> _
        Private Sub InitClass()
            Me.DataSetName = "dsSecurity"
            Me.Prefix = ""
            Me.Namespace = "http://tempuri.org/dsSecurity.xsd"
            Me.EnforceConstraints = True
            Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
            Me.tablesecurityuser_role = New securityuser_roleDataTable
            MyBase.Tables.Add(Me.tablesecurityuser_role)
            Me.tablesecurityusermenu = New securityusermenuDataTable
            MyBase.Tables.Add(Me.tablesecurityusermenu)
            Me.tablegeneralentity = New generalentityDataTable
            MyBase.Tables.Add(Me.tablegeneralentity)
            Me.tablesecurityshortcut = New securityshortcutDataTable
            MyBase.Tables.Add(Me.tablesecurityshortcut)
            Me.tablesecurityshortcutsub = New securityshortcutsubDataTable
            MyBase.Tables.Add(Me.tablesecurityshortcutsub)
            Me.tablesystemlanguagecode = New systemlanguagecodeDataTable
            MyBase.Tables.Add(Me.tablesystemlanguagecode)
            Me.tablesecurityrole = New securityroleDataTable
            MyBase.Tables.Add(Me.tablesecurityrole)
            Me.tablesystemmenu = New systemmenuDataTable
            MyBase.Tables.Add(Me.tablesystemmenu)
            Me.tablesecuritymenu_role = New securitymenu_roleDataTable
            MyBase.Tables.Add(Me.tablesecuritymenu_role)
            Me.tablesecurityrole_entity = New securityrole_entityDataTable
            MyBase.Tables.Add(Me.tablesecurityrole_entity)
            Me.tablesystemmenutree = New systemmenutreeDataTable
            MyBase.Tables.Add(Me.tablesystemmenutree)
            Me.tablesecurityuser = New securityuserDataTable
            MyBase.Tables.Add(Me.tablesecurityuser)
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
            Me.tablesecurityuser_role = DirectCast(MyBase.Tables.Item("securityuser_role"), securityuser_roleDataTable)
            If (initTable AndAlso (Not Me.tablesecurityuser_role Is Nothing)) Then
                Me.tablesecurityuser_role.InitVars
            End If
            Me.tablesecurityusermenu = DirectCast(MyBase.Tables.Item("securityusermenu"), securityusermenuDataTable)
            If (initTable AndAlso (Not Me.tablesecurityusermenu Is Nothing)) Then
                Me.tablesecurityusermenu.InitVars
            End If
            Me.tablegeneralentity = DirectCast(MyBase.Tables.Item("generalentity"), generalentityDataTable)
            If (initTable AndAlso (Not Me.tablegeneralentity Is Nothing)) Then
                Me.tablegeneralentity.InitVars
            End If
            Me.tablesecurityshortcut = DirectCast(MyBase.Tables.Item("securityshortcut"), securityshortcutDataTable)
            If (initTable AndAlso (Not Me.tablesecurityshortcut Is Nothing)) Then
                Me.tablesecurityshortcut.InitVars
            End If
            Me.tablesecurityshortcutsub = DirectCast(MyBase.Tables.Item("securityshortcutsub"), securityshortcutsubDataTable)
            If (initTable AndAlso (Not Me.tablesecurityshortcutsub Is Nothing)) Then
                Me.tablesecurityshortcutsub.InitVars
            End If
            Me.tablesystemlanguagecode = DirectCast(MyBase.Tables.Item("systemlanguagecode"), systemlanguagecodeDataTable)
            If (initTable AndAlso (Not Me.tablesystemlanguagecode Is Nothing)) Then
                Me.tablesystemlanguagecode.InitVars
            End If
            Me.tablesecurityrole = DirectCast(MyBase.Tables.Item("securityrole"), securityroleDataTable)
            If (initTable AndAlso (Not Me.tablesecurityrole Is Nothing)) Then
                Me.tablesecurityrole.InitVars
            End If
            Me.tablesystemmenu = DirectCast(MyBase.Tables.Item("systemmenu"), systemmenuDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenu Is Nothing)) Then
                Me.tablesystemmenu.InitVars
            End If
            Me.tablesecuritymenu_role = DirectCast(MyBase.Tables.Item("securitymenu_role"), securitymenu_roleDataTable)
            If (initTable AndAlso (Not Me.tablesecuritymenu_role Is Nothing)) Then
                Me.tablesecuritymenu_role.InitVars
            End If
            Me.tablesecurityrole_entity = DirectCast(MyBase.Tables.Item("securityrole_entity"), securityrole_entityDataTable)
            If (initTable AndAlso (Not Me.tablesecurityrole_entity Is Nothing)) Then
                Me.tablesecurityrole_entity.InitVars
            End If
            Me.tablesystemmenutree = DirectCast(MyBase.Tables.Item("systemmenutree"), systemmenutreeDataTable)
            If (initTable AndAlso (Not Me.tablesystemmenutree Is Nothing)) Then
                Me.tablesystemmenutree.InitVars
            End If
            Me.tablesecurityuser = DirectCast(MyBase.Tables.Item("securityuser"), securityuserDataTable)
            If (initTable AndAlso (Not Me.tablesecurityuser Is Nothing)) Then
                Me.tablesecurityuser.InitVars
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
                If (Not dataSet.Tables.Item("securityuser_role") Is Nothing) Then
                    MyBase.Tables.Add(New securityuser_roleDataTable(dataSet.Tables.Item("securityuser_role")))
                End If
                If (Not dataSet.Tables.Item("securityusermenu") Is Nothing) Then
                    MyBase.Tables.Add(New securityusermenuDataTable(dataSet.Tables.Item("securityusermenu")))
                End If
                If (Not dataSet.Tables.Item("generalentity") Is Nothing) Then
                    MyBase.Tables.Add(New generalentityDataTable(dataSet.Tables.Item("generalentity")))
                End If
                If (Not dataSet.Tables.Item("securityshortcut") Is Nothing) Then
                    MyBase.Tables.Add(New securityshortcutDataTable(dataSet.Tables.Item("securityshortcut")))
                End If
                If (Not dataSet.Tables.Item("securityshortcutsub") Is Nothing) Then
                    MyBase.Tables.Add(New securityshortcutsubDataTable(dataSet.Tables.Item("securityshortcutsub")))
                End If
                If (Not dataSet.Tables.Item("systemlanguagecode") Is Nothing) Then
                    MyBase.Tables.Add(New systemlanguagecodeDataTable(dataSet.Tables.Item("systemlanguagecode")))
                End If
                If (Not dataSet.Tables.Item("securityrole") Is Nothing) Then
                    MyBase.Tables.Add(New securityroleDataTable(dataSet.Tables.Item("securityrole")))
                End If
                If (Not dataSet.Tables.Item("systemmenu") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenuDataTable(dataSet.Tables.Item("systemmenu")))
                End If
                If (Not dataSet.Tables.Item("securitymenu_role") Is Nothing) Then
                    MyBase.Tables.Add(New securitymenu_roleDataTable(dataSet.Tables.Item("securitymenu_role")))
                End If
                If (Not dataSet.Tables.Item("securityrole_entity") Is Nothing) Then
                    MyBase.Tables.Add(New securityrole_entityDataTable(dataSet.Tables.Item("securityrole_entity")))
                End If
                If (Not dataSet.Tables.Item("systemmenutree") Is Nothing) Then
                    MyBase.Tables.Add(New systemmenutreeDataTable(dataSet.Tables.Item("systemmenutree")))
                End If
                If (Not dataSet.Tables.Item("securityuser") Is Nothing) Then
                    MyBase.Tables.Add(New securityuserDataTable(dataSet.Tables.Item("securityuser")))
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
        Private Function ShouldSerializegeneralentity() As Boolean
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
        Private Function ShouldSerializesecurityrole_entity() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityshortcut() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityshortcutsub() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityuser() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityuser_role() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesecurityusermenu() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemdatabase() As Boolean
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
        Private Function ShouldSerializesystemmenutree() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Private Function ShouldSerializesystemmenutreeView1() As Boolean
            Return False
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Function ShouldSerializeTables() As Boolean
            Return False
        End Function


        ' Properties
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property generalentity As generalentityDataTable
            Get
                Return Me.tablegeneralentity
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode> _
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

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
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

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property securityrole_entity As securityrole_entityDataTable
            Get
                Return Me.tablesecurityrole_entity
            End Get
        End Property

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode> _
        Public ReadOnly Property securityshortcut As securityshortcutDataTable
            Get
                Return Me.tablesecurityshortcut
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property securityshortcutsub As securityshortcutsubDataTable
            Get
                Return Me.tablesecurityshortcutsub
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property securityuser As securityuserDataTable
            Get
                Return Me.tablesecurityuser
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property securityuser_role As securityuser_roleDataTable
            Get
                Return Me.tablesecurityuser_role
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property securityusermenu As securityusermenuDataTable
            Get
                Return Me.tablesecurityusermenu
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemdatabase As systemdatabaseDataTable
            Get
                Return Me.tablesystemdatabase
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False), DebuggerNonUserCode> _
        Public ReadOnly Property systemlanguagecode As systemlanguagecodeDataTable
            Get
                Return Me.tablesystemlanguagecode
            End Get
        End Property

        <Browsable(False), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property systemmenu As systemmenuDataTable
            Get
                Return Me.tablesystemmenu
            End Get
        End Property

        <DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(False)> _
        Public ReadOnly Property systemmenutree As systemmenutreeDataTable
            Get
                Return Me.tablesystemmenutree
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(False)> _
        Public ReadOnly Property systemmenutreeView1 As systemmenutreeView1DataTable
            Get
                Return Me.tablesystemmenutreeView1
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
        Private tablegeneralentity As generalentityDataTable
        Private tablesecuritymenu_role As securitymenu_roleDataTable
        Private tablesecurityrole As securityroleDataTable
        Private tablesecurityrole_entity As securityrole_entityDataTable
        Private tablesecurityshortcut As securityshortcutDataTable
        Private tablesecurityshortcutsub As securityshortcutsubDataTable
        Private tablesecurityuser As securityuserDataTable
        Private tablesecurityuser_role As securityuser_roleDataTable
        Private tablesecurityusermenu As securityusermenuDataTable
        Private tablesystemdatabase As systemdatabaseDataTable
        Private tablesystemlanguagecode As systemlanguagecodeDataTable
        Private tablesystemmenu As systemmenuDataTable
        Private tablesystemmenutree As systemmenutreeDataTable
        Private tablesystemmenutreeView1 As systemmenutreeView1DataTable

        ' Nested Types
        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
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
            Public Function AddgeneralentityRow(ByVal EntityID As Integer, ByVal Name As String, ByVal Description As String, ByVal CurrCode As String, ByVal FormIcon As String) As generalentityRow
                Dim row As generalentityRow = DirectCast(Me.NewRow, generalentityRow)
                row.ItemArray = New Object() { EntityID, Name, Description, CurrCode, FormIcon }
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey7", New DataColumn() { Me.columnEntityID }, True))
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
            Private columnCurrCode As DataColumn
            Private columnDescription As DataColumn
            Private columnEntityID As DataColumn
            Private columnFormIcon As DataColumn
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
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablegeneralentity.NameColumn)
            End Function

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
            Public Sub SetNameNull()
                Me.Item(Me.tablegeneralentity.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey1", New DataColumn() { Me.columnRoleID, Me.columnMenuID }, True))
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
            <Browsable(False), DebuggerNonUserCode> _
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

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class securityrole_entityDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityrole_entityRowChanged As securityrole_entityRowChangeEventHandler
            Public Event securityrole_entityRowChanging As securityrole_entityRowChangeEventHandler
            Public Event securityrole_entityRowDeleted As securityrole_entityRowChangeEventHandler
            Public Event securityrole_entityRowDeleting As securityrole_entityRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityrole_entityDataTable.__ENCList
                SyncLock list
                    securityrole_entityDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityrole_entity"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityrole_entityDataTable.__ENCList
                SyncLock list
                    securityrole_entityDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityrole_entityDataTable.__ENCList
                SyncLock list
                    securityrole_entityDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Addsecurityrole_entityRow(ByVal row As securityrole_entityRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Addsecurityrole_entityRow(ByVal RoleID As Integer, ByVal EntityID As Integer) As securityrole_entityRow
                Dim row As securityrole_entityRow = DirectCast(Me.NewRow, securityrole_entityRow)
                row.ItemArray = New Object() { RoleID, EntityID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityrole_entityDataTable = DirectCast(MyBase.Clone, securityrole_entityDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityrole_entityDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByRoleIDEntityID(ByVal RoleID As Integer, ByVal EntityID As Integer) As securityrole_entityRow
                Return DirectCast(Me.Rows.Find(New Object() { RoleID, EntityID }), securityrole_entityRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityrole_entityRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityrole_entityDataTable"
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey11", New DataColumn() { Me.columnRoleID, Me.columnEntityID }, True))
                Me.columnRoleID.AllowDBNull = False
                Me.columnEntityID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnRoleID = MyBase.Columns.Item("RoleID")
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityrole_entityRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function Newsecurityrole_entityRow() As securityrole_entityRow
                Return DirectCast(Me.NewRow, securityrole_entityRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityrole_entityRowChangedEvent Is Nothing) Then
                    Dim handler As securityrole_entityRowChangeEventHandler = Me.securityrole_entityRowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityrole_entityRowChangeEvent(DirectCast(e.Row, securityrole_entityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityrole_entityRowChangingEvent Is Nothing) Then
                    Dim handler As securityrole_entityRowChangeEventHandler = Me.securityrole_entityRowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityrole_entityRowChangeEvent(DirectCast(e.Row, securityrole_entityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityrole_entityRowDeletedEvent Is Nothing) Then
                    Dim handler As securityrole_entityRowChangeEventHandler = Me.securityrole_entityRowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityrole_entityRowChangeEvent(DirectCast(e.Row, securityrole_entityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityrole_entityRowDeletingEvent Is Nothing) Then
                    Dim handler As securityrole_entityRowChangeEventHandler = Me.securityrole_entityRowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityrole_entityRowChangeEvent(DirectCast(e.Row, securityrole_entityRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Removesecurityrole_entityRow(ByVal row As securityrole_entityRow)
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
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityrole_entityRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityrole_entityRow)
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
            Private columnEntityID As DataColumn
            Private columnRoleID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityrole_entityRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityrole_entity = DirectCast(Me.Table, securityrole_entityDataTable)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityrole_entity.EntityIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityrole_entity.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property RoleID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityrole_entity.RoleIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityrole_entity.RoleIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityrole_entity As securityrole_entityDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityrole_entityRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityrole_entityRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityrole_entityRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityrole_entityRow
        End Class

        Public Delegate Sub securityrole_entityRowChangeEventHandler(ByVal sender As Object, ByVal e As securityrole_entityRowChangeEvent)

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey3", New DataColumn() { Me.columnRoleID }, True))
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

        <Serializable, DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityshortcutDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityshortcutRowChanged As securityshortcutRowChangeEventHandler
            Public Event securityshortcutRowChanging As securityshortcutRowChangeEventHandler
            Public Event securityshortcutRowDeleted As securityshortcutRowChangeEventHandler
            Public Event securityshortcutRowDeleting As securityshortcutRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityshortcutDataTable.__ENCList
                SyncLock list
                    securityshortcutDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityshortcut"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityshortcutDataTable.__ENCList
                SyncLock list
                    securityshortcutDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityshortcutDataTable.__ENCList
                SyncLock list
                    securityshortcutDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsecurityshortcutRow(ByVal row As securityshortcutRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsecurityshortcutRow(ByVal ShortCutID As Integer, ByVal Name As String, ByVal EntityID As Integer, ByVal Description As String, ByVal AddKey As Integer, ByVal AddKeyModifier As Integer, ByVal EditKey As Integer, ByVal EditKeyModifier As Integer, ByVal DeleteKey As Integer, ByVal DeleteKeyModifier As Integer, ByVal SaveKey As Integer, ByVal SaveKeyModifier As Integer, ByVal UndoKey As Integer, ByVal UndoKeyModifier As Integer, ByVal HelpKey As Integer, ByVal HelpKeyModifier As Integer) As securityshortcutRow
                Dim row As securityshortcutRow = DirectCast(Me.NewRow, securityshortcutRow)
                row.ItemArray = New Object() { ShortCutID, Name, EntityID, Description, AddKey, AddKeyModifier, EditKey, EditKeyModifier, DeleteKey, DeleteKeyModifier, SaveKey, SaveKeyModifier, UndoKey, UndoKeyModifier, HelpKey, HelpKeyModifier }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityshortcutDataTable = DirectCast(MyBase.Clone, securityshortcutDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityshortcutDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByShortCutID(ByVal ShortCutID As Integer) As securityshortcutRow
                Return DirectCast(Me.Rows.Find(New Object() { ShortCutID }), securityshortcutRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityshortcutRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityshortcutDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnShortCutID = New DataColumn("ShortCutID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnShortCutID)
                Me.columnName = New DataColumn("Name", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnName)
                Me.columnEntityID = New DataColumn("EntityID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEntityID)
                Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDescription)
                Me.columnAddKey = New DataColumn("AddKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddKey)
                Me.columnAddKeyModifier = New DataColumn("AddKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAddKeyModifier)
                Me.columnEditKey = New DataColumn("EditKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEditKey)
                Me.columnEditKeyModifier = New DataColumn("EditKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnEditKeyModifier)
                Me.columnDeleteKey = New DataColumn("DeleteKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDeleteKey)
                Me.columnDeleteKeyModifier = New DataColumn("DeleteKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDeleteKeyModifier)
                Me.columnSaveKey = New DataColumn("SaveKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSaveKey)
                Me.columnSaveKeyModifier = New DataColumn("SaveKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnSaveKeyModifier)
                Me.columnUndoKey = New DataColumn("UndoKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUndoKey)
                Me.columnUndoKeyModifier = New DataColumn("UndoKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUndoKeyModifier)
                Me.columnHelpKey = New DataColumn("HelpKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHelpKey)
                Me.columnHelpKeyModifier = New DataColumn("HelpKeyModifier", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnHelpKeyModifier)
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey4", New DataColumn() { Me.columnShortCutID }, True))
                Me.columnShortCutID.AllowDBNull = False
                Me.columnShortCutID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnShortCutID = MyBase.Columns.Item("ShortCutID")
                Me.columnName = MyBase.Columns.Item("Name")
                Me.columnEntityID = MyBase.Columns.Item("EntityID")
                Me.columnDescription = MyBase.Columns.Item("Description")
                Me.columnAddKey = MyBase.Columns.Item("AddKey")
                Me.columnAddKeyModifier = MyBase.Columns.Item("AddKeyModifier")
                Me.columnEditKey = MyBase.Columns.Item("EditKey")
                Me.columnEditKeyModifier = MyBase.Columns.Item("EditKeyModifier")
                Me.columnDeleteKey = MyBase.Columns.Item("DeleteKey")
                Me.columnDeleteKeyModifier = MyBase.Columns.Item("DeleteKeyModifier")
                Me.columnSaveKey = MyBase.Columns.Item("SaveKey")
                Me.columnSaveKeyModifier = MyBase.Columns.Item("SaveKeyModifier")
                Me.columnUndoKey = MyBase.Columns.Item("UndoKey")
                Me.columnUndoKeyModifier = MyBase.Columns.Item("UndoKeyModifier")
                Me.columnHelpKey = MyBase.Columns.Item("HelpKey")
                Me.columnHelpKeyModifier = MyBase.Columns.Item("HelpKeyModifier")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityshortcutRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsecurityshortcutRow() As securityshortcutRow
                Return DirectCast(Me.NewRow, securityshortcutRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityshortcutRowChangedEvent Is Nothing) Then
                    Dim securityshortcutRowChangedEvent As securityshortcutRowChangeEventHandler = Me.securityshortcutRowChangedEvent
                    If (Not securityshortcutRowChangedEvent Is Nothing) Then
                        securityshortcutRowChangedEvent.Invoke(Me, New securityshortcutRowChangeEvent(DirectCast(e.Row, securityshortcutRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityshortcutRowChangingEvent Is Nothing) Then
                    Dim securityshortcutRowChangingEvent As securityshortcutRowChangeEventHandler = Me.securityshortcutRowChangingEvent
                    If (Not securityshortcutRowChangingEvent Is Nothing) Then
                        securityshortcutRowChangingEvent.Invoke(Me, New securityshortcutRowChangeEvent(DirectCast(e.Row, securityshortcutRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityshortcutRowDeletedEvent Is Nothing) Then
                    Dim securityshortcutRowDeletedEvent As securityshortcutRowChangeEventHandler = Me.securityshortcutRowDeletedEvent
                    If (Not securityshortcutRowDeletedEvent Is Nothing) Then
                        securityshortcutRowDeletedEvent.Invoke(Me, New securityshortcutRowChangeEvent(DirectCast(e.Row, securityshortcutRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityshortcutRowDeletingEvent Is Nothing) Then
                    Dim securityshortcutRowDeletingEvent As securityshortcutRowChangeEventHandler = Me.securityshortcutRowDeletingEvent
                    If (Not securityshortcutRowDeletingEvent Is Nothing) Then
                        securityshortcutRowDeletingEvent.Invoke(Me, New securityshortcutRowChangeEvent(DirectCast(e.Row, securityshortcutRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesecurityshortcutRow(ByVal row As securityshortcutRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AddKeyColumn As DataColumn
                Get
                    Return Me.columnAddKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AddKeyModifierColumn As DataColumn
                Get
                    Return Me.columnAddKeyModifier
                End Get
            End Property

            <Browsable(False), DebuggerNonUserCode> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DeleteKeyColumn As DataColumn
                Get
                    Return Me.columnDeleteKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DeleteKeyModifierColumn As DataColumn
                Get
                    Return Me.columnDeleteKeyModifier
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DescriptionColumn As DataColumn
                Get
                    Return Me.columnDescription
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EditKeyColumn As DataColumn
                Get
                    Return Me.columnEditKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EditKeyModifierColumn As DataColumn
                Get
                    Return Me.columnEditKeyModifier
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property EntityIDColumn As DataColumn
                Get
                    Return Me.columnEntityID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property HelpKeyColumn As DataColumn
                Get
                    Return Me.columnHelpKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property HelpKeyModifierColumn As DataColumn
                Get
                    Return Me.columnHelpKeyModifier
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityshortcutRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityshortcutRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property NameColumn As DataColumn
                Get
                    Return Me.columnName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SaveKeyColumn As DataColumn
                Get
                    Return Me.columnSaveKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property SaveKeyModifierColumn As DataColumn
                Get
                    Return Me.columnSaveKeyModifier
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ShortCutIDColumn As DataColumn
                Get
                    Return Me.columnShortCutID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UndoKeyColumn As DataColumn
                Get
                    Return Me.columnUndoKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UndoKeyModifierColumn As DataColumn
                Get
                    Return Me.columnUndoKeyModifier
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnAddKey As DataColumn
            Private columnAddKeyModifier As DataColumn
            Private columnDeleteKey As DataColumn
            Private columnDeleteKeyModifier As DataColumn
            Private columnDescription As DataColumn
            Private columnEditKey As DataColumn
            Private columnEditKeyModifier As DataColumn
            Private columnEntityID As DataColumn
            Private columnHelpKey As DataColumn
            Private columnHelpKeyModifier As DataColumn
            Private columnName As DataColumn
            Private columnSaveKey As DataColumn
            Private columnSaveKeyModifier As DataColumn
            Private columnShortCutID As DataColumn
            Private columnUndoKey As DataColumn
            Private columnUndoKeyModifier As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityshortcutRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityshortcut = DirectCast(Me.Table, securityshortcutDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAddKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.AddKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAddKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.AddKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDeleteKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.DeleteKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDeleteKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.DeleteKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDescriptionNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.DescriptionColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEditKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.EditKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEditKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.EditKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsEntityIDNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.EntityIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHelpKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.HelpKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsHelpKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.HelpKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsNameNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.NameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSaveKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.SaveKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsSaveKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.SaveKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUndoKeyModifierNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.UndoKeyModifierColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUndoKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcut.UndoKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAddKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.AddKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAddKeyNull()
                Me.Item(Me.tablesecurityshortcut.AddKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDeleteKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.DeleteKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDeleteKeyNull()
                Me.Item(Me.tablesecurityshortcut.DeleteKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDescriptionNull()
                Me.Item(Me.tablesecurityshortcut.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEditKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.EditKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEditKeyNull()
                Me.Item(Me.tablesecurityshortcut.EditKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetEntityIDNull()
                Me.Item(Me.tablesecurityshortcut.EntityIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHelpKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.HelpKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetHelpKeyNull()
                Me.Item(Me.tablesecurityshortcut.HelpKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetNameNull()
                Me.Item(Me.tablesecurityshortcut.NameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSaveKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.SaveKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetSaveKeyNull()
                Me.Item(Me.tablesecurityshortcut.SaveKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUndoKeyModifierNull()
                Me.Item(Me.tablesecurityshortcut.UndoKeyModifierColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUndoKeyNull()
                Me.Item(Me.tablesecurityshortcut.UndoKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AddKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.AddKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.AddKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property AddKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.AddKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AddKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.AddKeyModifierColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DeleteKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.DeleteKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DeleteKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.DeleteKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DeleteKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.DeleteKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DeleteKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.DeleteKeyModifierColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Description As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityshortcut.DescriptionColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Description' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityshortcut.DescriptionColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EditKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.EditKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EditKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.EditKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EditKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.EditKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EditKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.EditKeyModifierColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property EntityID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.EntityIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'EntityID' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.EntityIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property HelpKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.HelpKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'HelpKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.HelpKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property HelpKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.HelpKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'HelpKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.HelpKeyModifierColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Name As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityshortcut.NameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Name' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityshortcut.NameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SaveKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.SaveKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SaveKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.SaveKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property SaveKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.SaveKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'SaveKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.SaveKeyModifierColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ShortCutID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.ShortCutIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.ShortCutIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UndoKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.UndoKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UndoKey' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.UndoKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UndoKeyModifier As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcut.UndoKeyModifierColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UndoKeyModifier' in table 'securityshortcut' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcut.UndoKeyModifierColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityshortcut As securityshortcutDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityshortcutRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityshortcutRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityshortcutRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityshortcutRow
        End Class

        Public Delegate Sub securityshortcutRowChangeEventHandler(ByVal sender As Object, ByVal e As securityshortcutRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class securityshortcutsubDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityshortcutsubRowChanged As securityshortcutsubRowChangeEventHandler
            Public Event securityshortcutsubRowChanging As securityshortcutsubRowChangeEventHandler
            Public Event securityshortcutsubRowDeleted As securityshortcutsubRowChangeEventHandler
            Public Event securityshortcutsubRowDeleting As securityshortcutsubRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityshortcutsubDataTable.__ENCList
                SyncLock list
                    securityshortcutsubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityshortcutsub"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityshortcutsubDataTable.__ENCList
                SyncLock list
                    securityshortcutsubDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityshortcutsubDataTable.__ENCList
                SyncLock list
                    securityshortcutsubDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsecurityshortcutsubRow(ByVal row As securityshortcutsubRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsecurityshortcutsubRow(ByVal ShortCutID As Integer, ByVal Type As String, ByVal ShortKey As Integer, ByVal ModifierKey As Integer) As securityshortcutsubRow
                Dim row As securityshortcutsubRow = DirectCast(Me.NewRow, securityshortcutsubRow)
                row.ItemArray = New Object() { ShortCutID, Type, ShortKey, ModifierKey }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityshortcutsubDataTable = DirectCast(MyBase.Clone, securityshortcutsubDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityshortcutsubDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByShortCutIDType(ByVal ShortCutID As Integer, ByVal Type As String) As securityshortcutsubRow
                Return DirectCast(Me.Rows.Find(New Object() { ShortCutID, Type }), securityshortcutsubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityshortcutsubRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityshortcutsubDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnShortCutID = New DataColumn("ShortCutID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnShortCutID)
                Me.columnType = New DataColumn("Type", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnType)
                Me.columnShortKey = New DataColumn("ShortKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnShortKey)
                Me.columnModifierKey = New DataColumn("ModifierKey", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnModifierKey)
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey8", New DataColumn() { Me.columnShortCutID, Me.columnType }, True))
                Me.columnShortCutID.AllowDBNull = False
                Me.columnType.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnShortCutID = MyBase.Columns.Item("ShortCutID")
                Me.columnType = MyBase.Columns.Item("Type")
                Me.columnShortKey = MyBase.Columns.Item("ShortKey")
                Me.columnModifierKey = MyBase.Columns.Item("ModifierKey")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityshortcutsubRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsecurityshortcutsubRow() As securityshortcutsubRow
                Return DirectCast(Me.NewRow, securityshortcutsubRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityshortcutsubRowChangedEvent Is Nothing) Then
                    Dim securityshortcutsubRowChangedEvent As securityshortcutsubRowChangeEventHandler = Me.securityshortcutsubRowChangedEvent
                    If (Not securityshortcutsubRowChangedEvent Is Nothing) Then
                        securityshortcutsubRowChangedEvent.Invoke(Me, New securityshortcutsubRowChangeEvent(DirectCast(e.Row, securityshortcutsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityshortcutsubRowChangingEvent Is Nothing) Then
                    Dim securityshortcutsubRowChangingEvent As securityshortcutsubRowChangeEventHandler = Me.securityshortcutsubRowChangingEvent
                    If (Not securityshortcutsubRowChangingEvent Is Nothing) Then
                        securityshortcutsubRowChangingEvent.Invoke(Me, New securityshortcutsubRowChangeEvent(DirectCast(e.Row, securityshortcutsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityshortcutsubRowDeletedEvent Is Nothing) Then
                    Dim securityshortcutsubRowDeletedEvent As securityshortcutsubRowChangeEventHandler = Me.securityshortcutsubRowDeletedEvent
                    If (Not securityshortcutsubRowDeletedEvent Is Nothing) Then
                        securityshortcutsubRowDeletedEvent.Invoke(Me, New securityshortcutsubRowChangeEvent(DirectCast(e.Row, securityshortcutsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityshortcutsubRowDeletingEvent Is Nothing) Then
                    Dim securityshortcutsubRowDeletingEvent As securityshortcutsubRowChangeEventHandler = Me.securityshortcutsubRowDeletingEvent
                    If (Not securityshortcutsubRowDeletingEvent Is Nothing) Then
                        securityshortcutsubRowDeletingEvent.Invoke(Me, New securityshortcutsubRowChangeEvent(DirectCast(e.Row, securityshortcutsubRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesecurityshortcutsubRow(ByVal row As securityshortcutsubRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityshortcutsubRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityshortcutsubRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ModifierKeyColumn As DataColumn
                Get
                    Return Me.columnModifierKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ShortCutIDColumn As DataColumn
                Get
                    Return Me.columnShortCutID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ShortKeyColumn As DataColumn
                Get
                    Return Me.columnShortKey
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property TypeColumn As DataColumn
                Get
                    Return Me.columnType
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnModifierKey As DataColumn
            Private columnShortCutID As DataColumn
            Private columnShortKey As DataColumn
            Private columnType As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityshortcutsubRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityshortcutsub = DirectCast(Me.Table, securityshortcutsubDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsModifierKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcutsub.ModifierKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsShortKeyNull() As Boolean
                Return Me.IsNull(Me.tablesecurityshortcutsub.ShortKeyColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetModifierKeyNull()
                Me.Item(Me.tablesecurityshortcutsub.ModifierKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetShortKeyNull()
                Me.Item(Me.tablesecurityshortcutsub.ShortKeyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property ModifierKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcutsub.ModifierKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ModifierKey' in table 'securityshortcutsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcutsub.ModifierKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ShortCutID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityshortcutsub.ShortCutIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcutsub.ShortCutIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ShortKey As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityshortcutsub.ShortKeyColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ShortKey' in table 'securityshortcutsub' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityshortcutsub.ShortKeyColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Type As String
                Get
                    Return Conversions.ToString(Me.Item(Me.tablesecurityshortcutsub.TypeColumn))
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityshortcutsub.TypeColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityshortcutsub As securityshortcutsubDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityshortcutsubRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityshortcutsubRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityshortcutsubRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityshortcutsubRow
        End Class

        Public Delegate Sub securityshortcutsubRowChangeEventHandler(ByVal sender As Object, ByVal e As securityshortcutsubRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class securityuser_roleDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityuser_roleRowChanged As securityuser_roleRowChangeEventHandler
            Public Event securityuser_roleRowChanging As securityuser_roleRowChangeEventHandler
            Public Event securityuser_roleRowDeleted As securityuser_roleRowChangeEventHandler
            Public Event securityuser_roleRowDeleting As securityuser_roleRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityuser_roleDataTable.__ENCList
                SyncLock list
                    securityuser_roleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityuser_role"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityuser_roleDataTable.__ENCList
                SyncLock list
                    securityuser_roleDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityuser_roleDataTable.__ENCList
                SyncLock list
                    securityuser_roleDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Addsecurityuser_roleRow(ByVal row As securityuser_roleRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function Addsecurityuser_roleRow(ByVal UserId As Integer, ByVal RoleID As Integer) As securityuser_roleRow
                Dim row As securityuser_roleRow = DirectCast(Me.NewRow, securityuser_roleRow)
                row.ItemArray = New Object() { UserId, RoleID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityuser_roleDataTable = DirectCast(MyBase.Clone, securityuser_roleDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityuser_roleDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByUserIdRoleID(ByVal UserId As Integer, ByVal RoleID As Integer) As securityuser_roleRow
                Return DirectCast(Me.Rows.Find(New Object() { UserId, RoleID }), securityuser_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityuser_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityuser_roleDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnUserId = New DataColumn("UserId", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserId)
                Me.columnRoleID = New DataColumn("RoleID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnRoleID)
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey2", New DataColumn() { Me.columnUserId, Me.columnRoleID }, True))
                Me.columnUserId.AllowDBNull = False
                Me.columnRoleID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnUserId = MyBase.Columns.Item("UserId")
                Me.columnRoleID = MyBase.Columns.Item("RoleID")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityuser_roleRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function Newsecurityuser_roleRow() As securityuser_roleRow
                Return DirectCast(Me.NewRow, securityuser_roleRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityuser_roleRowChangedEvent Is Nothing) Then
                    Dim handler As securityuser_roleRowChangeEventHandler = Me.securityuser_roleRowChangedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityuser_roleRowChangeEvent(DirectCast(e.Row, securityuser_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityuser_roleRowChangingEvent Is Nothing) Then
                    Dim handler As securityuser_roleRowChangeEventHandler = Me.securityuser_roleRowChangingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityuser_roleRowChangeEvent(DirectCast(e.Row, securityuser_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityuser_roleRowDeletedEvent Is Nothing) Then
                    Dim handler As securityuser_roleRowChangeEventHandler = Me.securityuser_roleRowDeletedEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityuser_roleRowChangeEvent(DirectCast(e.Row, securityuser_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityuser_roleRowDeletingEvent Is Nothing) Then
                    Dim handler As securityuser_roleRowChangeEventHandler = Me.securityuser_roleRowDeletingEvent
                    If (Not handler Is Nothing) Then
                        handler.Invoke(Me, New securityuser_roleRowChangeEvent(DirectCast(e.Row, securityuser_roleRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub Removesecurityuser_roleRow(ByVal row As securityuser_roleRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityuser_roleRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityuser_roleRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property RoleIDColumn As DataColumn
                Get
                    Return Me.columnRoleID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserIdColumn As DataColumn
                Get
                    Return Me.columnUserId
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnRoleID As DataColumn
            Private columnUserId As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityuser_roleRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityuser_role = DirectCast(Me.Table, securityuser_roleDataTable)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property RoleID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityuser_role.RoleIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser_role.RoleIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserId As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityuser_role.UserIdColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser_role.UserIdColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityuser_role As securityuser_roleDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityuser_roleRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityuser_roleRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityuser_roleRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityuser_roleRow
        End Class

        Public Delegate Sub securityuser_roleRowChangeEventHandler(ByVal sender As Object, ByVal e As securityuser_roleRowChangeEvent)

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
        Public Class securityuserDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityuserRowChanged As securityuserRowChangeEventHandler
            Public Event securityuserRowChanging As securityuserRowChangeEventHandler
            Public Event securityuserRowDeleted As securityuserRowChangeEventHandler
            Public Event securityuserRowDeleting As securityuserRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityuserDataTable.__ENCList
                SyncLock list
                    securityuserDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityuser"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityuserDataTable.__ENCList
                SyncLock list
                    securityuserDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityuserDataTable.__ENCList
                SyncLock list
                    securityuserDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsecurityuserRow(ByVal row As securityuserRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsecurityuserRow(ByVal UserID As Integer, ByVal FullName As String, ByVal Login As String, ByVal PassWord As String, ByVal ShortCutID As Integer, ByVal Lang As String, ByVal DefaultRoleID As Integer, ByVal BannerVisible As Boolean, ByVal AutoSaveViews As Integer, ByVal ShowInTaskBar As Boolean, ByVal AutoHideMenu As Boolean, ByVal UserDocPath As String) As securityuserRow
                Dim row As securityuserRow = DirectCast(Me.NewRow, securityuserRow)
                row.ItemArray = New Object() { UserID, FullName, Login, PassWord, ShortCutID, Lang, DefaultRoleID, BannerVisible, AutoSaveViews, ShowInTaskBar, AutoHideMenu, UserDocPath }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityuserDataTable = DirectCast(MyBase.Clone, securityuserDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityuserDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByUserID(ByVal UserID As Integer) As securityuserRow
                Return DirectCast(Me.Rows.Find(New Object() { UserID }), securityuserRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityuserRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityuserDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnFullName = New DataColumn("FullName", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnFullName)
                Me.columnLogin = New DataColumn("Login", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLogin)
                Me.columnPassWord = New DataColumn("PassWord", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnPassWord)
                Me.columnShortCutID = New DataColumn("ShortCutID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnShortCutID)
                Me.columnLang = New DataColumn("Lang", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnLang)
                Me.columnDefaultRoleID = New DataColumn("DefaultRoleID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnDefaultRoleID)
                Me.columnBannerVisible = New DataColumn("BannerVisible", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnBannerVisible)
                Me.columnAutoSaveViews = New DataColumn("AutoSaveViews", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAutoSaveViews)
                Me.columnShowInTaskBar = New DataColumn("ShowInTaskBar", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnShowInTaskBar)
                Me.columnAutoHideMenu = New DataColumn("AutoHideMenu", GetType(Boolean), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnAutoHideMenu)
                Me.columnUserDocPath = New DataColumn("UserDocPath", GetType(String), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserDocPath)
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey5", New DataColumn() { Me.columnUserID }, True))
                Me.columnUserID.AllowDBNull = False
                Me.columnUserID.Unique = True
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnFullName = MyBase.Columns.Item("FullName")
                Me.columnLogin = MyBase.Columns.Item("Login")
                Me.columnPassWord = MyBase.Columns.Item("PassWord")
                Me.columnShortCutID = MyBase.Columns.Item("ShortCutID")
                Me.columnLang = MyBase.Columns.Item("Lang")
                Me.columnDefaultRoleID = MyBase.Columns.Item("DefaultRoleID")
                Me.columnBannerVisible = MyBase.Columns.Item("BannerVisible")
                Me.columnAutoSaveViews = MyBase.Columns.Item("AutoSaveViews")
                Me.columnShowInTaskBar = MyBase.Columns.Item("ShowInTaskBar")
                Me.columnAutoHideMenu = MyBase.Columns.Item("AutoHideMenu")
                Me.columnUserDocPath = MyBase.Columns.Item("UserDocPath")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityuserRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsecurityuserRow() As securityuserRow
                Return DirectCast(Me.NewRow, securityuserRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityuserRowChangedEvent Is Nothing) Then
                    Dim securityuserRowChangedEvent As securityuserRowChangeEventHandler = Me.securityuserRowChangedEvent
                    If (Not securityuserRowChangedEvent Is Nothing) Then
                        securityuserRowChangedEvent.Invoke(Me, New securityuserRowChangeEvent(DirectCast(e.Row, securityuserRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityuserRowChangingEvent Is Nothing) Then
                    Dim securityuserRowChangingEvent As securityuserRowChangeEventHandler = Me.securityuserRowChangingEvent
                    If (Not securityuserRowChangingEvent Is Nothing) Then
                        securityuserRowChangingEvent.Invoke(Me, New securityuserRowChangeEvent(DirectCast(e.Row, securityuserRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityuserRowDeletedEvent Is Nothing) Then
                    Dim securityuserRowDeletedEvent As securityuserRowChangeEventHandler = Me.securityuserRowDeletedEvent
                    If (Not securityuserRowDeletedEvent Is Nothing) Then
                        securityuserRowDeletedEvent.Invoke(Me, New securityuserRowChangeEvent(DirectCast(e.Row, securityuserRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityuserRowDeletingEvent Is Nothing) Then
                    Dim securityuserRowDeletingEvent As securityuserRowChangeEventHandler = Me.securityuserRowDeletingEvent
                    If (Not securityuserRowDeletingEvent Is Nothing) Then
                        securityuserRowDeletingEvent.Invoke(Me, New securityuserRowChangeEvent(DirectCast(e.Row, securityuserRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesecurityuserRow(ByVal row As securityuserRow)
                Me.Rows.Remove(row)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public ReadOnly Property AutoHideMenuColumn As DataColumn
                Get
                    Return Me.columnAutoHideMenu
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property AutoSaveViewsColumn As DataColumn
                Get
                    Return Me.columnAutoSaveViews
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property BannerVisibleColumn As DataColumn
                Get
                    Return Me.columnBannerVisible
                End Get
            End Property

            <DebuggerNonUserCode, Browsable(False)> _
            Public ReadOnly Property Count As Integer
                Get
                    Return Me.Rows.Count
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property DefaultRoleIDColumn As DataColumn
                Get
                    Return Me.columnDefaultRoleID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property FullNameColumn As DataColumn
                Get
                    Return Me.columnFullName
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityuserRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityuserRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LangColumn As DataColumn
                Get
                    Return Me.columnLang
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property LoginColumn As DataColumn
                Get
                    Return Me.columnLogin
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property PassWordColumn As DataColumn
                Get
                    Return Me.columnPassWord
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ShortCutIDColumn As DataColumn
                Get
                    Return Me.columnShortCutID
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property ShowInTaskBarColumn As DataColumn
                Get
                    Return Me.columnShowInTaskBar
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property UserDocPathColumn As DataColumn
                Get
                    Return Me.columnUserDocPath
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
            Private columnAutoHideMenu As DataColumn
            Private columnAutoSaveViews As DataColumn
            Private columnBannerVisible As DataColumn
            Private columnDefaultRoleID As DataColumn
            Private columnFullName As DataColumn
            Private columnLang As DataColumn
            Private columnLogin As DataColumn
            Private columnPassWord As DataColumn
            Private columnShortCutID As DataColumn
            Private columnShowInTaskBar As DataColumn
            Private columnUserDocPath As DataColumn
            Private columnUserID As DataColumn
        End Class

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item")> _
        Public Class securityusermenuDataTable
            Inherits DataTable
            Implements IEnumerable
            ' Events
            Public Event securityusermenuRowChanged As securityusermenuRowChangeEventHandler
            Public Event securityusermenuRowChanging As securityusermenuRowChangeEventHandler
            Public Event securityusermenuRowDeleted As securityusermenuRowChangeEventHandler
            Public Event securityusermenuRowDeleting As securityusermenuRowChangeEventHandler

            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New()
                Dim list As ArrayList = securityusermenuDataTable.__ENCList
                SyncLock list
                    securityusermenuDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.TableName = "securityusermenu"
                Me.BeginInit
                Me.InitClass
                Me.EndInit
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub New(ByVal table As DataTable)
                Dim list As ArrayList = securityusermenuDataTable.__ENCList
                SyncLock list
                    securityusermenuDataTable.__ENCList.Add(New WeakReference(Me))
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
                Dim list As ArrayList = securityusermenuDataTable.__ENCList
                SyncLock list
                    securityusermenuDataTable.__ENCList.Add(New WeakReference(Me))
                End SyncLock
                Me.InitVars
            End Sub

            <DebuggerNonUserCode> _
            Public Sub AddsecurityusermenuRow(ByVal row As securityusermenuRow)
                Me.Rows.Add(row)
            End Sub

            <DebuggerNonUserCode> _
            Public Function AddsecurityusermenuRow(ByVal UserID As Integer, ByVal MenuID As Integer) As securityusermenuRow
                Dim row As securityusermenuRow = DirectCast(Me.NewRow, securityusermenuRow)
                row.ItemArray = New Object() { UserID, MenuID }
                Me.Rows.Add(row)
                Return row
            End Function

            <DebuggerNonUserCode> _
            Public Overrides Function Clone() As DataTable
                Dim table As securityusermenuDataTable = DirectCast(MyBase.Clone, securityusermenuDataTable)
                table.InitVars
                Return table
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function CreateInstance() As DataTable
                Return New securityusermenuDataTable
            End Function

            <DebuggerNonUserCode> _
            Public Function FindByUserIDMenuID(ByVal UserID As Integer, ByVal MenuID As Integer) As securityusermenuRow
                Return DirectCast(Me.Rows.Find(New Object() { UserID, MenuID }), securityusermenuRow)
            End Function

            <DebuggerNonUserCode> _
            Public Overridable Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Function GetRowType() As Type
                Return GetType(securityusermenuRow)
            End Function

            <DebuggerNonUserCode> _
            Public Shared Function GetTypedTableSchema(ByVal xs As XmlSchemaSet) As XmlSchemaComplexType
                Dim type2 As New XmlSchemaComplexType
                Dim sequence As New XmlSchemaSequence
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
                type2.Attributes.Add(attribute)
                Dim attribute2 As New XmlSchemaAttribute
                attribute2.Name = "tableTypeName"
                attribute2.FixedValue = "securityusermenuDataTable"
                type2.Attributes.Add(attribute2)
                type2.Particle = sequence
                Return type2
            End Function

            <DebuggerNonUserCode> _
            Private Sub InitClass()
                Me.columnUserID = New DataColumn("UserID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnUserID)
                Me.columnMenuID = New DataColumn("MenuID", GetType(Integer), Nothing, MappingType.Element)
                MyBase.Columns.Add(Me.columnMenuID)
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey6", New DataColumn() { Me.columnUserID, Me.columnMenuID }, True))
                Me.columnUserID.AllowDBNull = False
                Me.columnMenuID.AllowDBNull = False
            End Sub

            <DebuggerNonUserCode> _
            Friend Sub InitVars()
                Me.columnUserID = MyBase.Columns.Item("UserID")
                Me.columnMenuID = MyBase.Columns.Item("MenuID")
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New securityusermenuRow(builder)
            End Function

            <DebuggerNonUserCode> _
            Public Function NewsecurityusermenuRow() As securityusermenuRow
                Return DirectCast(Me.NewRow, securityusermenuRow)
            End Function

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Not Me.securityusermenuRowChangedEvent Is Nothing) Then
                    Dim securityusermenuRowChangedEvent As securityusermenuRowChangeEventHandler = Me.securityusermenuRowChangedEvent
                    If (Not securityusermenuRowChangedEvent Is Nothing) Then
                        securityusermenuRowChangedEvent.Invoke(Me, New securityusermenuRowChangeEvent(DirectCast(e.Row, securityusermenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Not Me.securityusermenuRowChangingEvent Is Nothing) Then
                    Dim securityusermenuRowChangingEvent As securityusermenuRowChangeEventHandler = Me.securityusermenuRowChangingEvent
                    If (Not securityusermenuRowChangingEvent Is Nothing) Then
                        securityusermenuRowChangingEvent.Invoke(Me, New securityusermenuRowChangeEvent(DirectCast(e.Row, securityusermenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Not Me.securityusermenuRowDeletedEvent Is Nothing) Then
                    Dim securityusermenuRowDeletedEvent As securityusermenuRowChangeEventHandler = Me.securityusermenuRowDeletedEvent
                    If (Not securityusermenuRowDeletedEvent Is Nothing) Then
                        securityusermenuRowDeletedEvent.Invoke(Me, New securityusermenuRowChangeEvent(DirectCast(e.Row, securityusermenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Not Me.securityusermenuRowDeletingEvent Is Nothing) Then
                    Dim securityusermenuRowDeletingEvent As securityusermenuRowChangeEventHandler = Me.securityusermenuRowDeletingEvent
                    If (Not securityusermenuRowDeletingEvent Is Nothing) Then
                        securityusermenuRowDeletingEvent.Invoke(Me, New securityusermenuRowChangeEvent(DirectCast(e.Row, securityusermenuRow), e.Action))
                    End If
                End If
            End Sub

            <DebuggerNonUserCode> _
            Public Sub RemovesecurityusermenuRow(ByVal row As securityusermenuRow)
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
            Public ReadOnly Default Property Item(ByVal index As Integer) As securityusermenuRow
                Get
                    Return DirectCast(Me.Rows.Item(index), securityusermenuRow)
                End Get
            End Property

            <DebuggerNonUserCode> _
            Public ReadOnly Property MenuIDColumn As DataColumn
                Get
                    Return Me.columnMenuID
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
            Private columnMenuID As DataColumn
            Private columnUserID As DataColumn
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityusermenuRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityusermenu = DirectCast(Me.Table, securityusermenuDataTable)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property MenuID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityusermenu.MenuIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityusermenu.MenuIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityusermenu.UserIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityusermenu.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityusermenu As securityusermenuDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityusermenuRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityusermenuRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityusermenuRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityusermenuRow
        End Class

        Public Delegate Sub securityusermenuRowChangeEventHandler(ByVal sender As Object, ByVal e As securityusermenuRowChangeEvent)

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityuserRow
            Inherits DataRow
            ' Methods
            <DebuggerNonUserCode> _
            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tablesecurityuser = DirectCast(Me.Table, securityuserDataTable)
            End Sub

            <DebuggerNonUserCode> _
            Public Function IsAutoHideMenuNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.AutoHideMenuColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsAutoSaveViewsNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.AutoSaveViewsColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsBannerVisibleNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.BannerVisibleColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsDefaultRoleIDNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.DefaultRoleIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsFullNameNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.FullNameColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLangNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.LangColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsLoginNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.LoginColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsPassWordNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.PassWordColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsShortCutIDNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.ShortCutIDColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsShowInTaskBarNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.ShowInTaskBarColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Function IsUserDocPathNull() As Boolean
                Return Me.IsNull(Me.tablesecurityuser.UserDocPathColumn)
            End Function

            <DebuggerNonUserCode> _
            Public Sub SetAutoHideMenuNull()
                Me.Item(Me.tablesecurityuser.AutoHideMenuColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetAutoSaveViewsNull()
                Me.Item(Me.tablesecurityuser.AutoSaveViewsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetBannerVisibleNull()
                Me.Item(Me.tablesecurityuser.BannerVisibleColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetDefaultRoleIDNull()
                Me.Item(Me.tablesecurityuser.DefaultRoleIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetFullNameNull()
                Me.Item(Me.tablesecurityuser.FullNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLangNull()
                Me.Item(Me.tablesecurityuser.LangColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetLoginNull()
                Me.Item(Me.tablesecurityuser.LoginColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetPassWordNull()
                Me.Item(Me.tablesecurityuser.PassWordColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetShortCutIDNull()
                Me.Item(Me.tablesecurityuser.ShortCutIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetShowInTaskBarNull()
                Me.Item(Me.tablesecurityuser.ShowInTaskBarColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub

            <DebuggerNonUserCode> _
            Public Sub SetUserDocPathNull()
                Me.Item(Me.tablesecurityuser.UserDocPathColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
            <DebuggerNonUserCode> _
            Public Property AutoHideMenu As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablesecurityuser.AutoHideMenuColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AutoHideMenu' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablesecurityuser.AutoHideMenuColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property AutoSaveViews As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityuser.AutoSaveViewsColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'AutoSaveViews' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser.AutoSaveViewsColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property BannerVisible As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablesecurityuser.BannerVisibleColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'BannerVisible' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablesecurityuser.BannerVisibleColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property DefaultRoleID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityuser.DefaultRoleIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'DefaultRoleID' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser.DefaultRoleIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property FullName As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityuser.FullNameColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'FullName' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityuser.FullNameColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Lang As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityuser.LangColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Lang' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityuser.LangColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property Login As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityuser.LoginColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'Login' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityuser.LoginColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property PassWord As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityuser.PassWordColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'PassWord' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityuser.PassWordColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ShortCutID As Integer
                Get
                    Dim num As Integer
                    Try 
                        num = Conversions.ToInteger(Me.Item(Me.tablesecurityuser.ShortCutIDColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ShortCutID' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return num
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser.ShortCutIDColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property ShowInTaskBar As Boolean
                Get
                    Dim flag As Boolean
                    Try 
                        flag = Conversions.ToBoolean(Me.Item(Me.tablesecurityuser.ShowInTaskBarColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'ShowInTaskBar' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return flag
                End Get
                Set(ByVal Value As Boolean)
                    Me.Item(Me.tablesecurityuser.ShowInTaskBarColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserDocPath As String
                Get
                    Dim str As String
                    Try 
                        str = Conversions.ToString(Me.Item(Me.tablesecurityuser.UserDocPathColumn))
                    Catch exception1 As InvalidCastException
                        ProjectData.SetProjectError(exception1)
                        Dim innerException As InvalidCastException = exception1
                        Throw New StrongTypingException("The value for column 'UserDocPath' in table 'securityuser' is DBNull.", innerException)
                        ProjectData.ClearProjectError
                    End Try
                    Return str
                End Get
                Set(ByVal Value As String)
                    Me.Item(Me.tablesecurityuser.UserDocPathColumn) = Value
                End Set
            End Property

            <DebuggerNonUserCode> _
            Public Property UserID As Integer
                Get
                    Return Conversions.ToInteger(Me.Item(Me.tablesecurityuser.UserIDColumn))
                End Get
                Set(ByVal Value As Integer)
                    Me.Item(Me.tablesecurityuser.UserIDColumn) = Value
                End Set
            End Property


            ' Fields
            Private tablesecurityuser As securityuserDataTable
        End Class

        <GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
        Public Class securityuserRowChangeEvent
            Inherits EventArgs
            ' Methods
            <DebuggerNonUserCode> _
            Public Sub New(ByVal row As securityuserRow, ByVal action As DataRowAction)
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
            Public ReadOnly Property Row As securityuserRow
                Get
                    Return Me.eventRow
                End Get
            End Property


            ' Fields
            Private eventAction As DataRowAction
            Private eventRow As securityuserRow
        End Class

        Public Delegate Sub securityuserRowChangeEventHandler(ByVal sender As Object, ByVal e As securityuserRowChangeEvent)

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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey12", New DataColumn() { Me.columnDBName }, True))
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey9", New DataColumn() { Me.columnLang }, True))
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

        <Serializable, XmlSchemaProvider("GetTypedTableSchema"), DefaultMember("Item"), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
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
            Public Function AddsystemmenuRow(ByVal MenuID As Integer, ByVal MenuLabel As String, ByVal MenuForm As String, ByVal MenuIcon As String, ByVal MenuIconExpanded As String, ByVal MenuStartID As Integer) As systemmenuRow
                Dim row As systemmenuRow = DirectCast(Me.NewRow, systemmenuRow)
                row.ItemArray = New Object() { MenuID, MenuLabel, MenuForm, MenuIcon, MenuIconExpanded, MenuStartID }
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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
                Me.Constraints.Add(New UniqueConstraint("dsSecurityKey10", New DataColumn() { Me.columnMenuID }, True))
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
            <Browsable(False), DebuggerNonUserCode> _
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
            Public ReadOnly Property MenuStartIDColumn As DataColumn
                Get
                    Return Me.columnMenuStartID
                End Get
            End Property


            ' Fields
            Private Shared __ENCList As ArrayList = New ArrayList
            Private columnMenuForm As DataColumn
            Private columnMenuIcon As DataColumn
            Private columnMenuIconExpanded As DataColumn
            Private columnMenuID As DataColumn
            Private columnMenuLabel As DataColumn
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
            Public Function IsMenuStartIDNull() As Boolean
                Return Me.IsNull(Me.tablesystemmenu.MenuStartIDColumn)
            End Function

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
            Public Sub SetMenuStartIDNull()
                Me.Item(Me.tablesystemmenu.MenuStartIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
            End Sub


            ' Properties
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

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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

        <Serializable, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), DefaultMember("Item"), XmlSchemaProvider("GetTypedTableSchema")> _
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
                Dim security As New dsSecurity
                xs.Add(security.GetSchemaSerializable)
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
                attribute.FixedValue = security.Namespace
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

            <Browsable(False), DebuggerNonUserCode> _
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
    End Class
End Namespace

