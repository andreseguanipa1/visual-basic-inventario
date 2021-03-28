Imports DataBase
Imports MySql.Data.MySqlClient

Public Class login
    'Intanciamos variables que utilizaremos para almacenar la informacion del login de usuario.
    Public Shared user1 As String = ""
    Public Shared pass1 As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.Text = ""
        password.Text = ""

        'Agregramos los estilos del formulario
        With Me
            CenterToScreen()
            FormBorderStyle = BorderStyle.FixedSingle
            MinimizeBox = False
            MaximizeBox = False
            BackColor = ColorTranslator.FromHtml("#57A773")
        End With

        With Titulo
            .Font = New Font("Arial", 20, FontStyle.Bold)
            .Text = "Login"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text1
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "User:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With text2
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Password:"
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With password
            .PasswordChar = "*"
        End With
        With btnLogin
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Login"
            .BackColor = ColorTranslator.FromHtml("#08B2E3")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnSign
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Text = "Sign in"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With horas
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With horas
            .Font = New Font("Arial", 14, FontStyle.Bold)
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
    End Sub

    'Evento click para aperturar el formulario de registro.
    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Me.Hide()
        Singin.Show()
        user.Text = ""
        password.Text = ""
    End Sub

    'Evento click para ingresar al sistema.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        'Comprobamos que tanto el usuario como contrasena sean correctos para permitir el acceso.
        If (Operaciones.login(user.Text, password.Text)) Then
            user1 = user.Text
            pass1 = password.Text

            Me.Hide()
            main.ShowDialog()

            user.Text = ""
            password.Text = ""
        Else
            'Mostramos un mensaje de error encaso de que el usuario o la contrasena sean incorrectos.
            MsgBox("Usuario o Contrasena incorrectos.", MsgBoxStyle.Critical, "Aviso")
        End If

        'Cerramos la conexion a la base de datos.
        Acceso.conexion.Close()
    End Sub

    'Evento Timer para actualizar la hora del login.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Asingamos el valor al label "horas"
        horas.Text = Format(DateAndTime.TimeOfDay)
    End Sub
End Class
