Public Class C_Productos
    Public _producto As String
    Public _precioCompra As Double
    Public _precioVenta As Double
    Public _cantidad As Integer
    Public _inventario As Integer
    Public _calculo As Double
    Public _calIva As Double
    Public _total As Double

    Public Property Producto As String
        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property
    Public Property PrecioCompra As Double
        Get
            Return _precioCompra
        End Get
        Set(value As Double)
            _precioCompra = value
        End Set
    End Property
    Public Property PrecioVenta As Double
        Get
            Return _precioVenta
        End Get
        Set(value As Double)
            _precioVenta = value
        End Set
    End Property
    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property Calculo As Double
        Get
            Return _calculo
        End Get
        Set(value As Double)
            _calculo = value
        End Set
    End Property
    Public Property CalculoIVA As Double
        Get
            Return _calIva
        End Get
        Set(value As Double)
            _calIva = value
        End Set
    End Property
    Public Property Inventario As Integer
        Get
            Return _inventario
        End Get
        Set(value As Integer)
            _inventario = value
        End Set
    End Property
    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
    Public Sub CalcularIVA(cantidad As Integer, precio As Double)
        Me.Total = cantidad * precio
        Me.Calculo = (Total * 0.13)
        Me.CalculoIVA = Calculo + Total
    End Sub
End Class
