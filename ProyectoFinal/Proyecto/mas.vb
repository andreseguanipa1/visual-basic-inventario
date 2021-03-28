Imports DataBase
Imports MySql.Data.MySqlClient

Public Class mas

    Private Sub mas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos la informacion de la base de datos en el objeto DataGridView.
        Operaciones.ConsultaGrid("SELECT id,marca FROM marca ORDER BY id", verMarcas)
        Operaciones.ConsultaGrid("SELECT id,almacen,ubicacion FROM almacen ORDER BY ubicacion", verAlmacenes)

        'Instanciamos los elementos del select
        Dim elementos() = {"almacen", "ubicacion", "id"}
        Dim elementos2() = {"id", "marca"}

        'Deshabilitamos los elementos.
        disable_almacen()
        disable_marca()

        'Estilos de la forma general.
        With Me
            CenterToScreen()
            .ControlBox = False
            MinimizeBox = False
            MaximizeBox = False
            FormBorderStyle = BorderStyle.FixedSingle
            BackColor = ColorTranslator.FromHtml("#F2F2F2")
        End With
        With ComboBox1
            .Items.AddRange(elementos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With ComboBox2
            .Items.AddRange(elementos2)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With AddbuttonMarca
            .Enabled = True
        End With
        With AddbuttonAlmacen
            .Enabled = True
        End With

        'Habilitamos algunos componentes de la forma.
        BoxAddAlmacen1.Enabled = True
        BoxAddAlmacen2.Enabled = True
        BoxAddMarca.Enabled = True
    End Sub

    'Evento de click en las celdas del DataGridView
    Private Sub verMarcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles verMarcas.CellClick

        'Obtenemos el indice del click
        Dim i As Integer = verMarcas.CurrentRow.Index

        'Limpiamos los inputs.
        Clean_Inputs2()

        'Activamos los elementos de  las marca.
        activate_marca()

        'Desactivamos los elementos de los almacenes.
        disable_almacen()

        'Cargamos los elementos clickeados en el los inputs.
        TextBox1.Text = verMarcas.Item(1, i).Value()
        TextBox2.Text = verMarcas.Item(0, i).Value()
        labelMarca.Text = "¿Desea eliminar la marca?"
        boxEditMarca.Text = verMarcas.Item(1, i).Value()

    End Sub

    'Evento click para editar una marca.
    'Solo activo si se selecciona una marca con anterioridad.
    Private Sub editMarca_Click(sender As Object, e As EventArgs) Handles editMarca.Click
        Dim valida = New Validaciones()
        valida.user = boxEditMarca.Text

        'Validaciones correspondientes.
        If boxEditMarca.Text = "" Then

            MsgBox("El campo no puede quedar vacio", MsgBoxStyle.Critical, "Aviso!")

        Else

            'Si todo es correcto.
            'Editamos la marca en la base de datos.
            If valida.validateUser() Then
                Dim updateDato As String = "UPDATE marca SET marca= '" & boxEditMarca.Text & "' WHERE id=" & TextBox2.Text
                Operaciones.ingresar(updateDato)
                Operaciones.ConsultaGrid("SELECT id,marca FROM marca ORDER BY id", verMarcas)
                Clean_Inputs1()
                Clean_Inputs2()
                MsgBox("Marca editada satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")

            Else
                'Mensaje de Error.
                MsgBox("La combinacion de carcateres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")

            End If


        End If

    End Sub
    'Evento click para eliminar una marca.
    'Solo activo si se selecciona un marca con anterioridad.
    Private Sub deleteMarca_Click(sender As Object, e As EventArgs) Handles deleteMarca.Click

        Dim selectDato = "SELECT * FROM producto WHERE producto.marcaFK = " & TextBox2.Text
        Dim comprobar = Operaciones.ConsultaSelect(selectDato, "producto")

        If comprobar = True Then
            MsgBox("Aun almacena productos con esta marca, no puede eliminarse por el momento", MsgBoxStyle.Critical, "Aviso!")
        Else
            Dim dropDato = "DELETE FROM marca WHERE marca.id = " & TextBox2.Text
            Operaciones.ingresar(dropDato)
            Operaciones.ConsultaGrid("SELECT id,marca FROM marca ORDER BY id", verMarcas)
            Clean_Inputs1()
            Clean_Inputs2()
            MsgBox("Marca eliminada satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")
        End If

    End Sub

    'Metodo para limpiar los inputs de la marca.
    Public Sub Clean_Inputs1()
        TextBox1.Text = ""
        TextBox2.Text = ""
        boxEditMarca.Text = ""
        labelMarca.Text = ""
        BoxAddMarca.Text = ""
    End Sub

    'Metodo para limpiar los inputs del almacen.
    Public Sub Clean_Inputs2()
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        boxEditAlmacen.Text = ""
        labelAlmacen.Text = ""
        BoxAddAlmacen1.Text = ""
        BoxAddAlmacen2.Text = ""
        TextBox3.Text = ""
    End Sub

    'Evento click para editar una marca.
    'Solo activo si se selecciona un marca con anterioridad.
    Private Sub AddbuttonMarca_Click(sender As Object, e As EventArgs) Handles AddbuttonMarca.Click
        Dim valida = New Validaciones()
        valida.user = BoxAddMarca.Text


        'Validaciones correspondientes.
        If BoxAddMarca.Text = "" Then

            MsgBox("El campo no puede quedar vacio", MsgBoxStyle.Critical, "Aviso!")

        Else

            'Si la validacion es correcta.
            'Agregamos la marca en la bases de datos.
            If valida.validateUser() Then
                Dim updateDato As String = "INSERT INTO marca(marca) VALUES ('" & BoxAddMarca.Text & "')"
                Operaciones.ingresar(updateDato)
                Operaciones.ConsultaGrid("SELECT id,marca FROM marca ORDER BY id", verMarcas)
                Clean_Inputs1()
                Clean_Inputs2()
                MsgBox("Marca agregada satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")

            Else

                MsgBox("La combinacion de carcateres ingresada es incorrecta", MsgBoxStyle.MsgBoxRight, "Aviso!")

            End If

        End If

    End Sub


    'Evento click para editar un almacen.
    'Solo activo si se selecciona un almacen con anterioridad.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles editAlmacen.Click
        Dim valida = New Validaciones()
        valida.user = boxEditAlmacen.Text
        Dim nameAlmacen = valida.validateUser()
        Dim ubicacionAlmacen = valida.validateNumber(TextBox3.Text)

        'Validaciones correspondientes.
        If boxEditAlmacen.Text = "" Or TextBox3.Text = "" Then

            MsgBox("Ninguno de los campos puede estar vacio!", MsgBoxStyle.Critical, "Aviso!")

        Else

            If nameAlmacen = False Then
                MsgBox("La combinacion de carcateres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If

            If ubicacionAlmacen = False Then
                MsgBox("El numero ingresado es incorrecto", MsgBoxStyle.Critical, "Aviso!")
            End If

            If ubicacionAlmacen = True Then
                If TextBox3.Text < 1 Then

                    MsgBox("El numero ingresado es incorrecto", MsgBoxStyle.Critical, "Aviso!")

                Else

                    If nameAlmacen = True And ubicacionAlmacen = True Then
                        Dim updateDato As String = "UPDATE almacen SET almacen= '" & boxEditAlmacen.Text & "', ubicacion='Planta " & TextBox3.Text & "' WHERE id=" & TextBox6.Text
                        Operaciones.ingresar(updateDato)
                        Operaciones.ConsultaGrid("SELECT id,almacen,ubicacion FROM almacen ORDER BY id", verAlmacenes)
                        Clean_Inputs1()
                        Clean_Inputs2()
                        MsgBox("Almacen editado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")

                    End If

                End If

            End If

        End If

    End Sub

    'Evento de click en las celdas del DataGridView
    Private Sub verAlmacenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles verAlmacenes.CellClick
        'Obtenemos el indice del click
        Dim i As Integer = verAlmacenes.CurrentRow.Index

        'Limpiamos los inputs.
        Clean_Inputs1()

        'Activamos los elementos de  los almacenes.
        activate_almacen()

        'Desactivmaos los elementos de  las marca.
        disable_marca()

        'Cargamos los elementos clickeados en el los inputs.
        TextBox6.Text = verAlmacenes.Item(0, i).Value()
        TextBox4.Text = verAlmacenes.Item(2, i).Value()
        TextBox5.Text = verAlmacenes.Item(1, i).Value()
        TextBox3.Text = Mid(verAlmacenes.Item(2, i).Value(), 8)
        labelAlmacen.Text = "¿Desea eliminar el almacen?"
        boxEditAlmacen.Text = verAlmacenes.Item(1, i).Value()

    End Sub

    'Evento click para eliminar un almacen.
    'Solo activo si se selecciona un almacen con anterioridad.
    Private Sub deleteAlmacen_Click(sender As Object, e As EventArgs) Handles deleteAlmacen.Click

        Dim selectDato = "SELECT * FROM producto WHERE producto.almacenFK = " & TextBox6.Text
        Dim comprobar = Operaciones.ConsultaSelect(selectDato, "producto")

        If comprobar = True Then
            MsgBox("Aun almacena productos en este almacen, no puede eliminarse por el momento", MsgBoxStyle.Critical, "Aviso!")
        Else
            Dim dropDato = "DELETE FROM almacen WHERE almacen.id = " & TextBox6.Text
            Operaciones.ingresar(dropDato)
            Operaciones.ConsultaGrid("SELECT id,almacen,ubicacion FROM almacen ORDER BY id", verAlmacenes)
            Clean_Inputs1()
            Clean_Inputs2()
            MsgBox("Almacen eliminado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")
        End If
    End Sub


    'Evento click para agregar un almacen.
    Private Sub AddbuttonAlmacen_Click(sender As Object, e As EventArgs) Handles AddbuttonAlmacen.Click

        Dim validaAdd = New Validaciones()
        validaAdd.user = BoxAddAlmacen1.Text

        Dim number = validaAdd.validateNumber(BoxAddAlmacen2.Text)
        Dim name = validaAdd.validateUser()


        'Validaciones de los campos correspondientes.
        If BoxAddAlmacen2.Text = "" Or BoxAddAlmacen1.Text = "" Then
            MsgBox("Ninguno de los campos pueden estar vacios", MsgBoxStyle.Critical, "Aviso!")

        Else

            If (number <> True) Then
                MsgBox("El numero ingresado es incorrecto!", MsgBoxStyle.Critical, "Aviso!")
            End If

            If (name <> True) Then
                MsgBox("La combinacion de carcateres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If

            'Si todo es valdiado correctamente, agregamos el almacen.
            If (number = True And name = True) Then
                If BoxAddAlmacen2.Text < 1 Then
                    MsgBox("El numero ingresado es incorrecto!", MsgBoxStyle.Critical, "Aviso!")
                Else
                    Dim updateDato As String = "INSERT INTO almacen(almacen,ubicacion) VALUES ('" & BoxAddAlmacen1.Text & "' , 'Planta " & BoxAddAlmacen2.Text & "')"
                    Operaciones.ingresar(updateDato)
                    Operaciones.ConsultaGrid("SELECT id,almacen,ubicacion FROM almacen ORDER BY id", verAlmacenes)
                    Clean_Inputs1()
                    Clean_Inputs2()
                    MsgBox("Almacen agregado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")
                End If

            End If

        End If

    End Sub

    'Habilitamos los elementos de las marcas.
    Public Sub activate_marca()
        editMarca.Enabled = True
        deleteMarca.Enabled = True
        AddbuttonMarca.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        boxEditMarca.Enabled = True
        BoxAddMarca.Enabled = True
    End Sub

    'Habilitamos los elementos de los almacenes.
    Public Sub activate_almacen()
        TextBox5.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        boxEditAlmacen.Enabled = True
        TextBox3.Enabled = True
        BoxAddAlmacen1.Enabled = True
        BoxAddAlmacen2.Enabled = True
        editAlmacen.Enabled = True
        deleteAlmacen.Enabled = True
        AddbuttonAlmacen.Enabled = True
    End Sub

    'Deshabilitamos los elementos de los almacenes.
    Public Sub disable_almacen()
        TextBox5.Enabled = False
        TextBox4.Enabled = False
        TextBox6.Enabled = False
        boxEditAlmacen.Enabled = False
        TextBox3.Enabled = False
        editAlmacen.Enabled = False
        deleteAlmacen.Enabled = False
    End Sub

    'Deshabilitamos los elementos de las marcas.
    Public Sub disable_marca()
        editMarca.Enabled = False
        deleteMarca.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        boxEditMarca.Enabled = False
    End Sub

    'Evento TextChanged para actualizar la informacion de los DataGridView en cada busqueda del usuario.
    Private Sub sAlmacen_TextChanged(sender As Object, e As EventArgs) Handles sAlmacen.TextChanged
        Operaciones.ConsultaGrid("select id,almacen,ubicacion FROM almacen WHERE " & ComboBox1.Text & " like '%" & sAlmacen.Text & "%' ORDER BY ubicacion", verAlmacenes)
    End Sub

    'Evento TextChanged para actualizar la informacion de los DataGridView en cada busqueda del usuario.
    Private Sub sMarca_TextChanged(sender As Object, e As EventArgs) Handles sMarca.TextChanged
        Operaciones.ConsultaGrid("select id,marca FROM marca WHERE " & ComboBox2.Text & " like '%" & sMarca.Text & "%' ORDER BY marca", verMarcas)

    End Sub
End Class