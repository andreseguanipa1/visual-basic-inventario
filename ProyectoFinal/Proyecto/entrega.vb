Imports DataBase

Public Class entrega
    'Instanciamos las sentencias sql que repetiremos a lo largo de todo esta clase.
    Dim sql As String = "select entrega.id, fecha, proveedor, nombre, descripcion from entrega join producto on entrega.productoFk = producto.codigo join proveedor on entrega.proveedorFk = proveedor.id ORDER BY fecha"
    Dim sqlPD As String = "select codigo,nombre,cantidad from producto"
    Dim sqlPV As String = "select id,proveedor from proveedor"

    'Definimos un sumador, para anexar la cantidad que ha sido recibida de un producogt.
    Dim cantSuma As Integer
    Private Sub entregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciamos los elementos que se cargaran en un select.
        Dim elementos() As String = {"proveedor", "producto"}
        'Cargamos los elementos de la base de datos en los DataGridView.
        Operaciones.ConsultaGrid(sql, entregas)
        Operaciones.ConsultaGrid(sqlPD, productos)
        Operaciones.ConsultaGrid(sqlPV, proveedores)

        'Estilos generales del formulario.
        With Me
            .CenterToScreen()
            .FormBorderStyle = BorderStyle.FixedSingle
            .MinimizeBox = False
            .MaximizeBox = False
            .BackColor = ColorTranslator.FromHtml("#F2F2F2")
        End With
        With opciones
            .Items.AddRange(elementos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With text1
            .Font = New Font("Arial", 16, FontStyle.Bold)
            .Text = "Buscar:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text2
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Fecha:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text3
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "ID Proveedor:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text4
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Proveedor:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text5
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Codigo:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text6
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Producto:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text7
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Cantidad:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text8
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Productos:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text9
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Proveedores:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With btnAdd
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Agregar"
            .BackColor = ColorTranslator.FromHtml("#57A773")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnCls
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Limpiar"
        End With

        'Deshabilitamos dos inputs.
        id.Enabled = False
        proveedor.Enabled = False
        codigo.Enabled = False
        producto.Enabled = False
    End Sub

    'Metodo que permite la busqueda por medio de un calentario para consultar las entregas por fechas.
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles fecha.ValueChanged
        'Cargamos los elementos de las entregas basados en la fecha que se selecciona.
        Operaciones.ConsultaGrid("select entrega.id, fecha, proveedor, nombre, descripcion from entrega join producto on entrega.productoFk = producto.codigo join proveedor on entrega.proveedorFk = proveedor.id where fecha='" & fecha.Value.Date.Year & "-" & fecha.Value.Date.Month & "-" & fecha.Value.Date.Day & "'", entregas)
    End Sub

    'Metodo de evento click para cargar la informacion en los inputs del producto seleccionado.
    Private Sub productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles productos.CellContentClick
        Dim psc As Integer = productos.CurrentRow.Index
        codigo.Text = productos.Item(0, psc).Value
        producto.Text = productos.Item(1, psc).Value
        cantSuma = productos.Item(2, psc).Value

    End Sub

    'Metodo de evento click para cargar la informacion en los inputs del proveedor seleccionado.
    Private Sub proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles proveedores.CellContentClick
        Dim psc As Integer = proveedores.CurrentRow.Index
        id.Text = proveedores.Item(0, psc).Value
        proveedor.Text = proveedores.Item(1, psc).Value
    End Sub

    'Metodo para limpiar los inputs.
    Private Sub cleanInputs()
        id.Text = ""
        proveedor.Text = ""
        codigo.Text = ""
        producto.Text = ""
        cantidad.Text = ""
    End Sub

    'Evento click en el boton "Limpiar"
    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        'Limpiamos los inputs
        cleanInputs()
    End Sub

    'Evento TextChanged para actulizar los resultados de los DataGridView segun sea la busqueda.
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        Dim opcion As String
        If opciones.Text.Equals("producto") Then
            opcion = "nombre"
        Else
            opcion = opciones.Text
        End If
        Operaciones.ConsultaGrid("select entrega.id, fecha, proveedor, nombre, descripcion from entrega join producto on entrega.productoFk = producto.codigo join proveedor on entrega.proveedorFk = proveedor.id where " & opcion & " like '%" & buscar.Text & "%'", entregas)
    End Sub

    'Metodo para agregar una entrega.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim val = New Validaciones()
        Dim a = val.validateNumber(cantidad.Text)


        'Comprobamos que ningun input este vacio
        If (cantidad.Text = "" Or id.Text = "" Or proveedor.Text = "" Or producto.Text = "") Then
            MsgBox("Ninguno de los campos pueden estar vacios", MsgBoxStyle.Critical, "Aviso!")
        Else
            'Comprobamos que la cantidad que recibimos sea una cantidad mayo o igual a uno.
            If a = False Then
                MsgBox("El numero ingresado no es valido", MsgBoxStyle.Critical, "Aviso!")

            ElseIf cantidad.Text < 1 Then
                MsgBox("El numero ingresado no es valido", MsgBoxStyle.Critical, "Aviso!")

            Else
                'Registramos la entrega.
                'Variables a utilizar.
                Dim descripcion As String = "Cantidad de Producto entregado: " & cantSuma
                Dim suma As Integer = cantSuma + CInt(cantidad.Text)
                Dim fechaE = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day

                'Ingresar y Actualizar.
                Operaciones.ingresar("insert into entrega values(null, " & id.Text & ", " & codigo.Text & ",'" & fechaE & "' , '" & descripcion & "')")
                Operaciones.ingresar("update producto set cantidad=" & suma & " where codigo=" & codigo.Text)

                'Consultas.
                Operaciones.ConsultaGrid(sql, entregas)
                Operaciones.ConsultaGrid(sqlPD, productos)

                'Actualizamos la lista de productos con cada entrega.
                Operaciones.ConsultaGrid("select codigo, nombre, marca, precio, cantidad, tipo, almacen from producto join marca on producto.marcaFK= marca.id join almacen on producto.almacenFK = almacen.id join claseproducto on producto.claseFK = claseproducto.id ORDER BY almacen, marca", main.articulos)
                'Limpiamos los inputs
                cleanInputs()
            End If
        End If
    End Sub
End Class