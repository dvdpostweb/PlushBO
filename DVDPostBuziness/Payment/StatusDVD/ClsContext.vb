

Public Class Context
    Private _state As State
    Private _products_id As Integer
    Private _products_dvd_id As Integer
    Private _box_id As Integer
    Private _pos_box_id As Integer


    Public ReadOnly Property products_id() As Integer
        Get
            Return _products_id
        End Get
    End Property

    Public ReadOnly Property products_dvd_id() As Integer
        Get
            Return _products_dvd_id
        End Get
    End Property


    Public ReadOnly Property box_id() As Integer
        Get
            Return _box_id
        End Get
    End Property

    Public ReadOnly Property pos_box_id() As Integer
        Get
            Return _pos_box_id
        End Get
    End Property

    Public Property State() As State
        Get
            Return _state
        End Get
        Set(ByVal value As State)
            _state = value
        End Set
    End Property

    Public Sub New(ByVal st_products_id As Integer, _
                   ByVal st_products_dvd_id As Integer, _
                   ByVal st_box_id As Integer, _
                   ByVal st_pos_box_id As Integer)

        _products_id = st_products_id
        _products_dvd_id = st_products_dvd_id
        _box_id = st_box_id
        _pos_box_id = st_pos_box_id
        ' get lastContext 

    End Sub
    Public Sub New(ByVal st_products_id As Integer, ByVal st_products_dvd_id As Integer)
        _products_id = st_products_id
        _products_dvd_id = st_products_dvd_id

        ' get lastContext 

    End Sub

    Public Sub New(ByVal st_state As State)
        Me.State = st_state
    End Sub

    Public Sub getIN()
        _state.getIN(Me)
    End Sub

    Public Sub getStock()
        _state.getStock(Me)
    End Sub

    Public Sub getOut()
        _state.getOut(Me)
    End Sub

    Public Sub getMid()
        _state.getMID(Me)
    End Sub

    Public Sub getSale()
        _state.getSALE(Me)
    End Sub

    Public Sub getPurchase()
        _state.getPURCHASE(Me)
    End Sub

    Public Sub getCustServ()
        _state.getCUSTSERV(Me)
    End Sub

    Public Sub getBrokenCustomer()
        _state.getBROKENCustomer(Me)
    End Sub

    Public Sub getDamaged()
        _state.getDAMAGED(Me)
    End Sub

    Public Sub getBadLabel()
        _state.getBADLABEL(Me)
    End Sub

    Public Sub getBIZARREMENTPERDU()
        _state.getBIZARREMENTPERDU(Me)
    End Sub

    Public Sub getPrepForSale()
        _state.getPrepForSale(Me)
    End Sub
End Class

Public MustInherit Class State

    Private Sub DisplayErrorState(ByVal st_in As State, ByVal st_out As State)
        MsgBox("Erro state DVD " & st_in.ToString() & " -> " & st_out.ToString())
    End Sub
    Public Overridable Sub getIN(ByVal context As Context)
        DisplayErrorState(context.State, New [IN])
    End Sub
    Public Overridable Sub getStock(ByVal context As Context)
        DisplayErrorState(context.State, New STOCK)
    End Sub
    Public Overridable Sub getOut(ByVal context As Context)
        DisplayErrorState(context.State, New ClsOut)
    End Sub

    Public Overridable Sub getMID(ByVal context As Context)
        DisplayErrorState(context.State, New ClsMID)
    End Sub

    Public Overridable Sub getSALE(ByVal context As Context)
        DisplayErrorState(context.State, New ClsSale)
    End Sub

    Public Overridable Sub getPURCHASE(ByVal context As Context)
        DisplayErrorState(context.State, New ClsPurchase)
    End Sub

    Public Overridable Sub getCUSTSERV(ByVal context As Context)
        DisplayErrorState(context.State, New CustServ)
    End Sub

    Public Overridable Sub getEntretienLogistic(ByVal context As Context)
        DisplayErrorState(context.State, New ClsEntretienLogistic)
    End Sub

    Public Overridable Sub getBROKENCustomer(ByVal context As Context)
        DisplayErrorState(context.State, New ClsBrokenCustomer)
    End Sub

    Public Overridable Sub getDAMAGED(ByVal context As Context)
        DisplayErrorState(context.State, New ClsDamaged)
    End Sub

    Public Overridable Sub getBADLABEL(ByVal context As Context)
        DisplayErrorState(context.State, New ClsBadLabel)
    End Sub

    Public Overridable Sub getBIZARREMENTPERDU(ByVal context As Context)
        DisplayErrorState(context.State, New clsBizarrementPerdu)
    End Sub

    Public Overridable Sub getPrepForSale(ByVal context As Context)
        DisplayErrorState(context.State, New ClsPrepForSale)
    End Sub
End Class


