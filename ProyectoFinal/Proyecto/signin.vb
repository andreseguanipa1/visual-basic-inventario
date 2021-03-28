Imports DataBase
Imports MySql.Data.MySqlClient

Public Class Singin
    Private Sub signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargamos la informacion de la base de datos en los select.
        cargoBox("select id_cargo,cargo from cargo")

        'Estilos Generales de la Forma.
        With Me
            CenterToScreen()
            FormBorderStyle = BorderStyle.FixedSingle
            MinimizeBox = False
            MaximizeBox = False
            BackColor = ColorTranslator.FromHtml("#57A773")
        End With
        With titulo
            .Font = New Font("Arial", 20, FontStyle.Bold)
            .Text = "Sign In"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text1
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Name:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text2
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Last Name:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text3
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "User:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text4
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Password:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text5
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Repeat Password:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text6
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Position:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text7
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Sex:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text8
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Email:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With password
            .PasswordChar = "*"
        End With
        With passwordR
            .PasswordChar = "*"
        End With
        With btnSign
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Sign in"
            .BackColor = ColorTranslator.FromHtml("#08B2E3")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnBack
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Back"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With cargos
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With male
            .Checked = True
        End With

    End Sub

    'Evento click para agregar un usuario en la Base de Datos.
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click

        'Instanciamos la variable para obtener el sexo.
        Dim sexo As String

        'Comprobamos cual checkBox esta seleccionado.
        If male.Checked Then
            sexo = "male"
        ElseIf female.Checked Then
            sexo = "female"
        Else
            sexo = "others"
        End If

        'Instanciamos las valdiaciones.
        Dim sign = New Validaciones()

        'Definimos los elementos a validar.
        sign.pass1 = password.Text
        sign.pass2 = passwordR.Text
        sign.user = user.Text

        Dim nombrePersona = sign.validateName(nombre.Text)
        Dim apellidoPersona = sign.validateName(lastname.Text)
        Dim passwordPersona = sign.validatePassword()
        Dim emailPersona = sign.validateEmail(email.Text)
        Dim userPersona = sign.validateUser()
        Dim validateCargo = sign.validarCargo(cargos.SelectedValue)

        'Comprobamos que ningun campo este vacio.
        If nombre.Text = "" Or lastname.Text = "" Or email.Text = "" Or password.Text = "" Or passwordR.Text = "" Or user.Text = "" Then
            MsgBox("Ninguno de los campos puede estar vacios!", MsgBoxStyle.Critical, "Aviso!")
        Else

            'Comprobamos las valdiaciones.
            If nombrePersona = False Then
                MsgBox("El nombre no puede contener caracteres especiales!", MsgBoxStyle.Critical, "Aviso!")
            End If

            If apellidoPersona = False Then
                MsgBox("El apellido no puede contener caracteres especiales!", MsgBoxStyle.Critical, "Aviso!")
            End If

            If passwordPersona = False Then
                MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Aviso!")
            End If

            If emailPersona = False Then
                MsgBox("El E-mail debe contener por lo menos un '@' y un dominio que sea válido", MsgBoxStyle.Critical, "Aviso!")
            End If

            If userPersona = False Then
                MsgBox("El nombre de usuario no tiene permitido ciertos caracteres especiales escritos en el campo", MsgBoxStyle.Critical, "Aviso!")
            End If

            'Comprobamos si el nombre de usuario se encuentra registrado.
            Dim sqlCodigo = "SELECT * FROM empleado WHERE user= '" & user.Text & "'"
            If (Operaciones.ConsultaSelect(sqlCodigo, "empleado")) Then
                MsgBox("El usuario ingresado ya se encuentra existente, elija otro", MsgBoxStyle.Critical, "Aviso!")
                userPersona = False
            End If

            'Si todas las validaciones son correctas.
            'Instanciamos el nuevo usuario en la Base de Datos.
            If nombrePersona = True And apellidoPersona = True And passwordPersona = True And emailPersona = True And userPersona = True Then

                Dim sql As String
                'Instanciamos las entencias.
                sql = "INSERT INTO empleado values('null','" & nombre.Text & "', '" & lastname.Text & "', '" & email.Text & "', '" & sexo & "', '" & user.Text & "', '" & password.Text & "', '" & cargos.SelectedValue & "')"
                'Insertamos el nuevo usuario.
                Operaciones.ingresar(sql)
                cleanInputs()
                MsgBox("Usuario agregado satisfactoriamente!", MsgBoxStyle.MsgBoxRight, "Buen trabajo")

            End If

        End If

    End Sub

    'Evento Click para llamar a la forma de login y salir de esta forma.
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        cleanInputs()
        login.Show()
    End Sub

    'Metodo para cargar los elementos en el Select.
    'Recibe como parametro una sentencia sql.
    Private Sub cargoBox(sql As String)
        'Abrimos la conexion con la Baso de Datos.
        Acceso.AbrirConexion()
        'Insertamos el codigo sql que tiene como parametro y la conexion.
        Acceso.adaptador = New MySqlDataAdapter(sql, Acceso.conexion)
        'Instanciamos una elemento DataTable.
        Acceso.table = New DataTable
        'Agreamos la informacion al Datable.
        Acceso.adaptador.Fill(Acceso.table)
        'Cargamos la informacion del DataTable.
        cargos.DataSource = Acceso.table
        'Asignamos la columna que mostrara como display.
        cargos.DisplayMember = "cargo"
        'Asignamos la columna que retornara como valor.
        cargos.ValueMember = "id_cargo"
        Acceso.conexion.Close()
    End Sub

    Private Sub cleanInputs()
        'Limpiamos los inputs.
        nombre.Text = ""
        lastname.Text = ""
        email.Text = ""
        password.Text = ""
        passwordR.Text = ""
        user.Text = ""
    End Sub

End Class