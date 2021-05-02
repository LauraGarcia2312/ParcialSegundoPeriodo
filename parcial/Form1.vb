Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim producto1 As C_Productos = New C_Productos
        producto1.Producto = "Carro"
        Dim producto2 As C_Productos = New C_Productos
        producto2.Producto = "Moto"
        Dim producto3 As C_Productos = New C_Productos
        producto3.Producto = "Televisor"
        Dim producto4 As C_Productos = New C_Productos
        producto4.Producto = "Teclado"
        Dim producto5 As C_Productos = New C_Productos
        producto5.Producto = "Mouse"
        Dim productos() As String = {producto1.Producto, producto2.Producto, producto3.Producto, producto4.Producto, producto5.Producto}
        cboProductos.Items.AddRange(productos)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim productos As C_Productos = New C_Productos
        productos.Producto = txtproducto.Text
        productos.PrecioCompra = txtValor.Text
        productos.PrecioVenta = txtPrecio.Text
        productos.Inventario = txtinventario.Text
        cboProductos.Items.Add(productos.Producto)
        txtproducto.Text = ""
        txtPrecio.Text = ""
        txtValor.Text = ""
        txtinventario.Text = ""
    End Sub

    Private Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        Dim productos As C_Productos = New C_Productos
        productos.PrecioVenta = txtPrecio.Text
        productos.Cantidad = txtcantidad.Text
        productos.CalcularIVA(txtcantidad.Text, txtPrecio.Text)
        txtVenta.Text = productos.CalculoIVA
        txtIva.Text = productos.Calculo
    End Sub

    Private Sub cboProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductos.SelectedIndexChanged
        Dim producto1 As C_Productos = New C_Productos
        producto1.Producto = "Carro"
        producto1.PrecioCompra = 10
        producto1.PrecioVenta = 15
        producto1.Inventario = 10
        Dim producto2 As C_Productos = New C_Productos
        producto2.Producto = "Moto"
        producto2.PrecioCompra = 5
        producto2.PrecioVenta = 10
        producto2.Inventario = 20
        Dim producto3 As C_Productos = New C_Productos
        producto3.Producto = "Televisor"
        producto3.PrecioCompra = 50
        producto3.PrecioVenta = 75
        producto3.Inventario = 25
        Dim producto4 As C_Productos = New C_Productos
        producto4.Producto = "Teclado"
        producto4.PrecioCompra = 20
        producto4.PrecioVenta = 25
        producto4.Inventario = 40
        Dim producto5 As C_Productos = New C_Productos
        producto5.Producto = "Mouse"
        producto5.PrecioCompra = 30
        producto5.PrecioVenta = 45
        producto5.Inventario = 60

        If cboProductos.Text = "Carro" Then
            txtproducto.Text = producto1.Producto
            txtValor.Text = producto1.PrecioCompra
            txtPrecio.Text = producto1.PrecioVenta
            txtinventario.Text = producto1.Inventario
        End If
        If cboProductos.Text = "Moto" Then
            txtproducto.Text = producto2.Producto
            txtValor.Text = producto2.PrecioCompra
            txtPrecio.Text = producto2.PrecioVenta
            txtinventario.Text = producto2.Inventario
        End If
        If cboProductos.Text = "Televisor" Then
            txtproducto.Text = producto3.Producto
            txtValor.Text = producto3.PrecioCompra
            txtPrecio.Text = producto3.PrecioVenta
            txtinventario.Text = producto3.Inventario
        End If
        If cboProductos.Text = "Teclado" Then
            txtproducto.Text = producto4.Producto
            txtValor.Text = producto4.PrecioCompra
            txtPrecio.Text = producto4.PrecioVenta
            txtinventario.Text = producto4.Inventario
        End If
        If cboProductos.Text = "Mouse" Then
            txtproducto.Text = producto5.Producto
            txtValor.Text = producto5.PrecioCompra
            txtPrecio.Text = producto5.PrecioVenta
            txtinventario.Text = producto5.Inventario
        End If
    End Sub
End Class
