Imports DataBase
Imports MySql.Data.MySqlClient

Public Class main
    'Instanciamos las variable utilizadas en esta clase
    Public Shared id_session As Integer
    'Creamos un objeto de tipo login.
    Dim logg = New login()
    'Instanciamos la sentencia sql que se repetira a lo largo del programa
    Dim ConsultaSql As String = "select codigo, nombre, marca, precio, cantidad, tipo, almacen from producto join marca on producto.marcaFK= marca.id join almacen on producto.almacenFK = almacen.id join claseproducto on producto.claseFK = claseproducto.id ORDER BY almacen, marca"

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanciamos los elementos del select
        Dim elementos() As String = {"codigo", "nombre", "marca", "precio", "cantidad", "tipo", "almacen"}

        'Cargamos la informacion de la base de datos en el objeto DataGridView.
        Operaciones.ConsultaGrid(ConsultaSql, articulos)

        'Cargamos la informacion de la base de datos en los select.
        Operaciones.cargaBox("select id,marca from marca", marca, "marca")
        Operaciones.cargaBox("select id,tipo from claseproducto", clase, "tipo")
        Operaciones.cargaBox("select id,almacen from almacen", almacen, "almacen")

        'Instanciamos un objeto de tipo Validaciones.
        Dim val = New Validaciones()

        'Instanciamos los datos personales.
        Dim datosPersonales = Operaciones.information(logg.user1, logg.pass1)

        'Intanciamos la validacion de los datos personales.
        Dim cargoString As String = val.validarCargoFK(datosPersonales(2).ToString)

        'Obtenenmso el id del usuario que mantiene la sesion.
        id_session = CInt(datosPersonales(4))

        'Creamos los estilos generales de la forma.
        With Me
            CenterToScreen()
            .ControlBox = False
            MinimizeBox = False
            MaximizeBox = False
            FormBorderStyle = BorderStyle.FixedSingle
            BackColor = ColorTranslator.FromHtml("#F2F2F2")
        End With
        With text1
            .Font = New Font("Arial", 20, FontStyle.Bold)
            .Text = "Buscar:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text2
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Codigo"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text3
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Nombre"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text4
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Cantidad"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text5
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Precio"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text6
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Tipo"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text7
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Marca"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text8
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Almacen"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With opciones
            .Items.AddRange(elementos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With btnEmp
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Empleados"
            .BackColor = ColorTranslator.FromHtml("#08B2E3")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnPro
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Proveedores"
            .BackColor = ColorTranslator.FromHtml("#57A773")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnEnt
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Entregas"
            .BackColor = ColorTranslator.FromHtml("#484D6D")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnOtr
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Mas"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnExit
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .Text = "X"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#FFFFFF")
        End With
        With btnAdd
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Agregar"
            .BackColor = ColorTranslator.FromHtml("#57A773")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnEdit
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Actualizar"
            .BackColor = ColorTranslator.FromHtml("#08B2E3")
            .ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            .Enabled = False
        End With
        With btnDelet
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Eliminar"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            .Enabled = False
        End With
        With btnCls
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Limpiar"
        End With
        With marca
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With clase
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With almacen
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With tnombre
            .Font = New Font("Arial", 7, FontStyle.Bold)
            .Text = "Nombre: " & datosPersonales(0)
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With tapellido
            .Font = New Font("Arial", 7, FontStyle.Bold)
            .Text = "Apellido: " & datosPersonales(1)
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With tcargo
            .Font = New Font("Arial", 7, FontStyle.Bold)
            .Text = "Cargo: " & cargoString
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With tusuario
            .Font = New Font("Arial", 7, FontStyle.Bold)
            .Text = "Usuario: " & datosPersonales(3)
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With

        'Informacion del Usuario Logueado
        Archivo.Login(logg.user1)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()
    End Sub

    'Evento TextChanged para actualizar la busqueda de producto.
    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        'Actualizamos la informacion del DataGridView proveniente de la Base de Datos.
        Operaciones.ConsultaGrid("select codigo, nombre, marca, precio, cantidad, tipo, almacen from producto join marca on producto.marcaFK= marca.id join almacen on producto.almacenFK = almacen.id join claseproducto on producto.claseFK = claseproducto.id  WHERE " & opciones.Text & " like '%" & search.Text & "%' ORDER BY marca", articulos)
    End Sub

    'Evento click para cerrar la sesion.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Informacion del Usuario Logueado
        Archivo.SalLogin(logg.user1)
        Me.Hide()
        login.Show()
    End Sub

    'Evento click para agregar un producto.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Instanciamos una variable de tipo validaciones.
        Dim productos = New Validaciones()
        'Instanciamos variables para obtener la informacion del nuevo producto.
        Dim codigoProducto = productos.validateNumber(codigo.Text)
        Dim cantidadProductos = productos.validateNumber(cantidad.Text)
        Dim nombreProducto = productos.validateName(nombre.Text)
        Dim precioProducto = productos.validateNumber(precio.Text)

        'Validamos que ningun campo este vacio.
        If (codigo.Text = "" Or cantidad.Text = "" Or nombre.Text = "" Or precio.Text = "") Then
            MsgBox("Ninguno de los campos puede estar vacios!", MsgBoxStyle.Critical, "Aviso!")

        Else
            'Comprobamos las validaciones de los productos.
            If codigoProducto = False Then
                MsgBox("El código introducido es incorrecto! Recuerde que solo se permite numeros enteros mayores a cero", MsgBoxStyle.Critical, "Aviso!")
            End If

            If cantidadProductos = False Then
                MsgBox("La cantidad introducida es incorrecta! Recuerde que solo se permite numeros enteros mayores a cero", MsgBoxStyle.Critical, "Aviso!")
            End If

            If nombreProducto = False Then
                MsgBox("No se permiten carcateres especiales en el nombre!", MsgBoxStyle.Critical, "Aviso!")
            End If

            If precioProducto = False Then
                MsgBox("El precio introducido es incorrecto! Recuerde que solo se permite numeros enteros mayores a cero", MsgBoxStyle.Critical, "Aviso!")
            End If

            If codigoProducto = True Then
                'Comprobamos si el codigo del producto existe.
                Dim sqlCodigo = "SELECT * FROM producto WHERE codigo= " & codigo.Text
                If (Operaciones.ConsultaSelect(sqlCodigo, "producto")) Then
                    'Si el codigo existe, mostramos un mensaje de error.
                    MsgBox("El ID del producto ingresado ya se encuentra existente", MsgBoxStyle.Critical, "Aviso!")
                    codigoProducto = False
                End If
            End If

            'Si todo se valido correctamente, creamos el nuevo producto.
            If codigoProducto = True And codigoProducto = True And codigoProducto = True And codigoProducto = True Then

                Dim sql As String
                sql = "insert into producto values(" & CInt(codigo.Text) & ",'" & nombre.Text & "', " & clase.SelectedValue & ", " & marca.SelectedValue & ", " & CDbl(precio.Text) & ", " & CInt(cantidad.Text) & ", " & almacen.SelectedValue & ")"
                Operaciones.ingresar(sql)
                'Actualizamos la lista de productos.
                Operaciones.ConsultaGrid(ConsultaSql, articulos)
                'Limpiamos los inputs.
                cleanInputs()
                'Mostramos un mensaje de exito en la operacion.
                MsgBox("Producto agregado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Buen trabajo")

            End If

        End If

    End Sub

    'Evento click para llamar la forma de los empleados.
    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        Empleado.ShowDialog()
    End Sub

    'Evento click para limpiar los inputs.
    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        'limpiamos los inputs.
        cleanInputs()
    End Sub

    'Evento de click en las celdas del DataGridView
    Private Sub articulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles articulos.CellContentClick

        'Creando Variable de Posicion del Grid
        Dim psc As Integer = articulos.CurrentRow.Index

        'Deshabilitando Botones
        codigo.Enabled = False
        btnAdd.Enabled = False
        btnDelet.Enabled = True
        btnEdit.Enabled = True

        'Adaptando los Valores
        codigo.Text = articulos.Item(0, psc).Value()
        nombre.Text = articulos.Item(1, psc).Value()
        marca.Text = articulos.Item(2, psc).Value()
        precio.Text = articulos.Item(3, psc).Value()
        cantidad.Text = articulos.Item(4, psc).Value()
        clase.Text = articulos.Item(5, psc).Value()
        almacen.Text = articulos.Item(6, psc).Value()

    End Sub

    'Evento click para editar un producto.
    'Solo activo si se selecciona un producto con anterioridad.
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Operaciones.ingresar("update producto set nombre = '" & nombre.Text & "', claseFK = " & clase.SelectedValue & ", marcaFK=" & marca.SelectedValue & ", precio=" & CDbl(precio.Text) & ", cantidad=" & CInt(cantidad.Text) & ", almacenFK=" & almacen.SelectedValue & " where codigo= " & codigo.Text)
        cleanInputs()
        Operaciones.ConsultaGrid(ConsultaSql, articulos)
    End Sub

    'Evento click para eliminar un producto.
    'Solo activo si se selecciona un producto con anterioridad.
    Private Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click
        Operaciones.ingresar("delete from producto where codigo=" & codigo.Text)
        cleanInputs()
        Operaciones.ConsultaGrid(ConsultaSql, articulos)
    End Sub

    'Metodo para limpiar los inputs.
    Private Sub cleanInputs()
        codigo.Enabled = True
        btnAdd.Enabled = True
        btnDelet.Enabled = False
        btnEdit.Enabled = False
        codigo.Text = ""
        nombre.Text = ""
        precio.Text = ""
        cantidad.Text = ""
    End Sub

    'Evento click para llamar la forma de los proveedores.
    Private Sub btnPro_Click(sender As Object, e As EventArgs) Handles btnPro.Click
        Proveedor.ShowDialog()
    End Sub

    'Evento click para llamar la forma de las entregas.
    Private Sub btnEnt_Click(sender As Object, e As EventArgs) Handles btnEnt.Click
        entrega.ShowDialog()
    End Sub

    'Evento click para llamar la forma de mas.
    Private Sub btnOtr_Click(sender As Object, e As EventArgs) Handles btnOtr.Click
        mas.ShowDialog()
    End Sub
End Class