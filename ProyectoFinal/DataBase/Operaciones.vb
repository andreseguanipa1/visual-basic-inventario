Imports DataBase.Acceso
Imports MySql.Data.MySqlClient

'Clase para realizar todas las operaciones que requieran conexion a la base de datos.
Public Class Operaciones

    'Comprobamos que el usuario que se ha logueado exista en la base de datos para darle acceso
    'Recibe como parametros el usuario y la contrasena, para comprobar que sean correctos.
    Public Shared Function login(user As String, password As String)
        Acceso.AbrirConexion()
        Acceso.adaptador = New MySqlDataAdapter("SELECT * FROM empleado WHERE user='" & user & "' and password='" & password & "'", Acceso.conexion)
        Acceso.ds = New DataSet
        Acceso.adaptador.Fill(Acceso.ds, "empleado")

        If (Acceso.ds.Tables("empleado").Rows.Count() <> 0) Then
            Acceso.conexion.Close()
            Return True
        Else
            Acceso.conexion.Close()
            Return False
        End If
    End Function


    'Funcion para obtener la informacion del usuario que se ha logueado.
    'Recibe como parametros el usuario y la contrasena, para obtener la informacion completa del usuari..
    Public Shared Function information(user As String, password As String)
        Acceso.AbrirConexion()
        Acceso.adaptador = New MySqlDataAdapter("SELECT * FROM empleado WHERE user='" & user & "' and password='" & password & "'", Acceso.conexion)
        Acceso.ds = New DataSet
        Acceso.adaptador.Fill(Acceso.ds, "empleado")

        Dim a = Acceso.ds.Tables("empleado").Rows(0).Item("nombre").ToString
        Dim b = Acceso.ds.Tables("empleado").Rows(0).Item("apellido").ToString
        Dim c = Acceso.ds.Tables("empleado").Rows(0).Item("cargoFK").ToString
        Dim d = Acceso.ds.Tables("empleado").Rows(0).Item("user").ToString
        Dim e = Acceso.ds.Tables("empleado").Rows(0).Item("id").ToString
        Acceso.conexion.Close()
        Dim elementos() = {a, b, c, d, e}

        Return elementos

    End Function

    'Funcion que recibe dos parametros, el primero una sentencia SQL y el segundo un objeto de tipo GridView
    'Esta funcion la implementamos para cargar el contenido de la bases de datos a un objeto Gridview.
    Public Shared Sub ConsultaGrid(sql As String, Grid As Object)
        Acceso.AbrirConexion()
        Acceso.adaptador = New MySqlDataAdapter(sql, Acceso.conexion)
        Acceso.table = New DataTable
        Acceso.adaptador.Fill(Acceso.table)
        Grid.DataSource = Acceso.table
        Acceso.conexion.Close()
    End Sub


    'Funcion que recibe dos parametros, una sentencia sql y un string.
    'Esta funcion es para el registro de usuario.
    'Utilizamos la funcion para comprar si un nombre de usuario ya esta registrado.
    Public Shared Function ConsultaSelect(sql As String, tabla As String)
        Acceso.AbrirConexion()
        Acceso.adaptador = New MySqlDataAdapter(sql, Acceso.conexion)
        Acceso.ds = New DataSet
        Acceso.adaptador.Fill(Acceso.ds, tabla)

        If (Acceso.ds.Tables(tabla).Rows.Count() <> 0) Then
            Acceso.conexion.Close()
            Return True
        Else
            Acceso.conexion.Close()
            Return False
        End If
    End Function

    'Funcion que recibe una sentencia sql, la utilizamos para agregar, editar, y/o eliminar un elemento
    'en la base de datos.
    Public Shared Sub ingresar(sql As String)
        Acceso.AbrirConexion()
        Acceso.adaptador = New MySqlDataAdapter(sql, Acceso.conexion)
        Acceso.ds = New DataSet
        Acceso.adaptador.Fill(Acceso.ds)
        Acceso.conexion.Close()
    End Sub

    'Funcion que recibe tres parametros una sentencia sql, un objecto tipo box, y un elemento string.
    'Los elementos son los valores que se visualizan en el comboBox.
    Public Shared Sub cargaBox(sql As String, box As Object, elemento As String)
        Try
            Acceso.AbrirConexion()
            Acceso.adaptador = New MySqlDataAdapter(sql, Acceso.conexion)
            Acceso.table = New DataTable
            Acceso.adaptador.Fill(Acceso.table)
            box.DataSource = Acceso.table
            box.DisplayMember = elemento
            box.ValueMember = "id"
            Acceso.conexion.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un Error: " & Err.Description.ToString(), MsgBoxStyle.Critical, "Alerta")
        End Try
    End Sub
End Class
