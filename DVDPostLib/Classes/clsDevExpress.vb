Public Class clsDevExpress
    Public Const COLDATETIME As String = "dd/MM/yyyy HH:mm:ss"
    Public Const COLDATE As String = "dd/MM/yyyy"
    Private Shared _sessionInfo As BizzLib.clsSessionInfo
    Public Shared Property sessionInfo() As BizzLib.clsSessionInfo
        Get
            If _sessionInfo Is Nothing Then
                Try
                    _sessionInfo = New BizzLib.clsSessionInfo(0, 1)
                Catch ex As Exception
                    PlushBuziness.clsMsgError.MsgBox(ex.Message)
                End Try
            End If
            Return _sessionInfo
        End Get
        Set(ByVal value As BizzLib.clsSessionInfo)
            _sessionInfo = value
        End Set
    End Property

    Public Enum TypeForm
        PRODUCT = 1033
    End Enum
    Public Shared Sub changeDateColumnToDateTime(ByRef col As DevExpress.XtraGrid.Columns.GridColumn)

        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        col.DisplayFormat.FormatString = COLDATETIME

    End Sub

    Public Shared Sub OpenFormCustomer(ByVal grid As DevExpress.XtraGrid.GridControl, _
                                       ByVal nameColumn As String, _
                                        ByVal formCurrent As Windows.Forms.Form)

        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView

        gridview = grid.Views(0)
        Dim customers_id As Integer = gridview.GetDataRow(gridview.FocusedRowHandle)(nameColumn)
      
        ClsCustomers.openFrmCustMaint(customers_id, formCurrent.ParentForm, sessionInfo)
    End Sub


    Public Shared Sub OpenForm(ByVal grid As DevExpress.XtraGrid.GridControl, _
                               ByVal nameColumn As String, _
                               ByVal formCurrent As Windows.Forms.Form, _
                               ByVal BKGlobal As BizzLib.clsGlobal, _
                               ByVal formOpen As TypeForm)
        Dim singleton As PlushBuziness.clsSingleton = Nothing
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView

        gridview = grid.Views(0)
        singleton = PlushBuziness.clsSingleton.Instance()
        singleton.Products_dvd_id = gridview.GetDataRow(gridview.FocusedRowHandle)(nameColumn)
        BKGlobal.StartMenuForm(formOpen, formCurrent.MdiParent)
    End Sub
    Private Shared Sub hyperlinkOtherColumn_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim hyperlink As DevExpress.XtraEditors.HyperLinkEdit = sender
        Dim repository As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit = hyperlink.Tag
        If TypeOf (hyperlink.Parent) Is DevExpress.XtraGrid.GridControl Then
            Dim grid As DevExpress.XtraGrid.GridControl = hyperlink.Parent
            Dim bgkglobal As BizzLib.clsGlobal = New BizzLib.clsGlobal(sessionInfo)
            OpenForm(grid, repository.Tag, hyperlink.FindForm(), bgkglobal, TypeForm.PRODUCT)
        End If
    End Sub

    Private Shared Sub hyperlinkCustomers_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim hyperlink As DevExpress.XtraEditors.HyperLinkEdit = sender
        If TypeOf (hyperlink.Parent) Is DevExpress.XtraGrid.GridControl Then
            Dim grid As DevExpress.XtraGrid.GridControl = hyperlink.Parent
            OpenFormCustomer(grid, "customers_id", hyperlink.FindForm())
        End If
    End Sub
    Private Shared Function IsColumnHyperLink(ByVal namecol As String) As Boolean

        Select Case namecol
            Case "customers_id", "products_id"
                Return (True)
            Case Else
                Return (False)
        End Select
    End Function
    Public Shared Sub AddCountFooter(ByRef grid As DevExpress.XtraGrid.GridControl)
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView

        gridview = grid.Views(0)
        If gridView.Columns.Count > 0 Then
            gridView.Columns(0).SummaryItem.SetSummary(DevExpress.Data.SummaryItemType.Count, "{0:n0}")
        End If
    End Sub
    Public Shared Sub AddHyperlinkDynamic(ByRef grid As DevExpress.XtraGrid.GridControl)
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView

        gridview = grid.Views(0)
        Dim hyperlink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            If IsColumnHyperLink(col.Caption) Then
                gridview.OptionsBehavior.Editable = True
                col.OptionsColumn.AllowEdit = True
                hyperlink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
                col.ColumnEdit = hyperlink
                hyperlink.Tag = col.Caption

                If col.Caption = "customers_id" Then
                    AddHandler hyperlink.Click, AddressOf hyperlinkCustomers_click
                Else
                    AddHandler hyperlink.Click, AddressOf hyperlinkOtherColumn_click
                End If
            Else
                ' ne pas rendre readonly une column button 
                If col.ColumnEdit Is Nothing OrElse Not TypeOf col.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Then
                    col.OptionsColumn.AllowEdit = False
                Else
                    col.OptionsColumn.AllowEdit = True
                End If
                End If

        Next

    End Sub

    Public Shared Sub AddHyperlinkDynamicWithCheckBox(ByRef grid As DevExpress.XtraGrid.GridControl)
        Dim gridview As DevExpress.XtraGrid.Views.Grid.GridView

        gridview = grid.Views(0)
        Dim hyperlink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit

        For Each col As DevExpress.XtraGrid.Columns.GridColumn In gridview.Columns
            If IsColumnHyperLink(col.Caption) Then
                gridview.OptionsBehavior.Editable = True
                col.OptionsColumn.AllowEdit = True
                hyperlink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
                col.ColumnEdit = hyperlink
                hyperlink.Tag = col.Caption

                If col.Caption = "customers_id" Then
                    AddHandler hyperlink.Click, AddressOf hyperlinkCustomers_click
                Else
                    AddHandler hyperlink.Click, AddressOf hyperlinkOtherColumn_click
                End If
            Else
                ' ne pas rendre readonly une column button 
                If col.ColumnEdit Is Nothing OrElse (Not TypeOf col.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit And Not TypeOf col.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit) Then
                    col.OptionsColumn.AllowEdit = False
                Else
                    col.OptionsColumn.AllowEdit = True
                End If
            End If

        Next

    End Sub

End Class
