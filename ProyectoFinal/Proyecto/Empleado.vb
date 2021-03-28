Imports DataBase
Imports MySql.Data.MySqlClient

Public Class Empleado

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declaramos los elementos para los objetos de tipo select.
        Dim elementos() As String = {"nombre", "cargo", "id"}
        Dim cargos() As String = {"Administrador", "Gerente"}
        Dim sexos() As String = {"male", "female", "others"}

        'Cargammos la tabla empleados en el objecto DataGriwView.
        Operaciones.ConsultaGrid("SELECT id,nombre,apellido,email,sexo,cargo FROM empleado JOIN cargo ON empleado.cargoFK= cargo.id_cargo ORDER BY nombre", DataGridView1)

        'Cargamos los estilos generales de la forma.
        With Me
            .CenterToScreen()
            .FormBorderStyle = BorderStyle.FixedSingle
            .MinimizeBox = False
            .MaximizeBox = False
            .BackColor = ColorTranslator.FromHtml("#F2F2F2")
        End With
        With ComboBox1
            .Items.AddRange(elementos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With ComboBox2
            .Items.AddRange(cargos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With sexo
            .Items.AddRange(sexos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With

        'Limpiamos lo inputs.
        CleanInputs()

        'Desactivamos lo botones de editar y eliminar, por defecto.
        EnableButtons()
    End Sub


    'Evento de tipo TextChanged para la busqueda de elementos.
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        'Cargamos los resultados de cada busqueda en el DataGridView
        Operaciones.ConsultaGrid("select id,nombre,apellido,email,sexo,cargo FROM empleado JOIN cargo ON empleado.cargoFK= cargo.id_cargo WHERE " & ComboBox1.Text & " like '%" & buscar.Text & "%' ORDER BY nombre", DataGridView1)
    End Sub

    'Evento de click en las celdas del DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'Obtenemos el indice del click
        Dim i As Integer = DataGridView1.CurrentRow.Index

        'Activamos los botones de editar y eliminar el elemento
        btnEdit.Enabled = True
        btnDelet.Enabled = True

        'Cargamos los elementos clickeados en el los inputs.
        Label9.Text = DataGridView1.Item(0, i).Value()
        TextBox2.Text = DataGridView1.Item(1, i).Value()
        TextBox3.Text = DataGridView1.Item(2, i).Value()
        TextBox5.Text = DataGridView1.Item(3, i).Value()
        sexo.Text = DataGridView1.Item(4, i).Value()
        ComboBox2.Text = DataGridView1.Item(5, i).Value()

        Label7.Text = "¿Desea eliminar a " & DataGridView1.Item(1, i).Value() & " del sistema?"
    End Sub

    'Funcion para editar los usuarios.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Intanciamos un nuevo elemento de validacion().
        Dim validar = New Validaciones()

        'Validamos los campos.
        Dim a = validar.validarCargo(ComboBox2.Text)
        Dim b = validar.validateName(TextBox2.Text)
        Dim c = validar.validateName(TextBox3.Text)
        Dim d = validar.validateEmail(TextBox5.Text)

        If (TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox3.Text = "") Then
            MsgBox("Ninguno de los campos pueden quedar vacios", MsgBoxStyle.Critical, "Aviso!")

        Else
            If b = False Then
                MsgBox("El nombre no puede contener caracteres especiales ni numeros", MsgBoxStyle.Critical, "Aviso!")
            End If
            If c = False Then
                MsgBox("El apellido no puede contener caracteres especiales ni numeros", MsgBoxStyle.Critical, "Aviso!")
            End If
            If d = False Then
                MsgBox("El email debe contener un '@' seguido de un dominio valido", MsgBoxStyle.Critical, "Aviso!")
            End If

            'Si se cumplen todas las validaciones...
            If (b = True And c = True And d = True) Then
                'Instanciamos la sentencia.
                Dim updateDato As String = "UPDATE empleado SET nombre= '" & TextBox2.Text & "' , apellido= '" & TextBox3.Text & "' , sexo= '" & sexo.Text & "' , email= '" & TextBox5.Text & "' , cargoFK= " & a & " WHERE id=" & Label9.Text

                'Actualizamos los datos.
                Operaciones.ingresar(updateDato)

                'Actualizamos la lsita de usuarios.
                Operaciones.ConsultaGrid("SELECT id,nombre,apellido,email,sexo,cargo FROM empleado JOIN cargo ON empleado.cargoFK= cargo.id_cargo ORDER BY nombre", DataGridView1)

                'Mostramos un mensaje exitoso.
                MsgBox("Usuario editado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")

                'Limpiamos lo inputs.
                CleanInputs()
                'Deshabilitamos los botones de editar y eliminar.
                EnableButtons()
            End If

        End If
    End Sub

    'Funcion para eliminar un usuario.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelet.Click

        'Si es se elimina el usuario que tiene la sesion activa, se rechaza la peticion.
        If (main.id_session = CInt(Label9.Text)) Then

            MsgBox("Tiene una sesion activa, no puede eliminar su propio usuario", MsgBoxStyle.MsgBoxRight, "Aviso!")

        Else
            'Sino, eleiminamos el usuario.
            'Instanciamos la sentencia.
            Dim dropDato = "DELETE FROM empleado WHERE empleado.id = " & Label9.Text
            'Eliminamos al usuario.
            Operaciones.ingresar(dropDato)

            'Actualizamos la lista de usuario.
            Operaciones.ConsultaGrid("SELECT id,nombre,apellido,email,sexo,cargo FROM empleado JOIN cargo ON empleado.cargoFK= cargo.id_cargo ORDER BY nombre", DataGridView1)

            MsgBox("Usuario eliminado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")

            CleanInputs()
            EnableButtons()

        End If

    End Sub

    'Funcion para limpiar los inputs.
    Private Sub CleanInputs()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox3.Text = ""
        sexo.SelectedIndex = 0
        TextBox5.Text = ""
        Label9.Text = ""
    End Sub

    'Funcion para deshabilitar botones.
    Private Sub EnableButtons()
        btnEdit.Enabled = False
        btnDelet.Enabled = False
    End Sub

End Class