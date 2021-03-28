'Importamos la Clase MySql.Date.MySqlClient para hacer conexion con la Base de Datos
Imports MySql.Data.MySqlClient
Public Class Acceso
    'Todas las variables osn declaradas como "Public Shared" debiado a que las utilizaremos en las demas clases
    'Conexion es la varibale que nos permite conectarnos con una base de datos.
    Public Shared conexion As MySql.Data.MySqlClient.MySqlConnection
    'Comanod es una variable que nos permite escribir sentencias sql.
    Public Shared comando As MySql.Data.MySqlClient.MySqlCommand
    'adaptador es la variable que nos permite ingresar una sentencia sql con la conexion de referencia.
    Public Shared adaptador As MySql.Data.MySqlClient.MySqlDataAdapter

    'Representa la Base de Datos Virtual
    Public Shared ds As DataSet
    'Representa un tabla en la Base da Datos
    Public Shared table As DataTable

    'Funcion para establecer la conexion ha la bases de datos.
    Public Shared Sub AbrirConexion()
        Try
            'Establecemos la conexion
            conexion = New MySqlConnection("Data Source=Localhost;Database=inventario;User Id=root; Password=")

        Catch ex As Exception
            'Obtenemos el error en caso de error
            Err.Description.ToString()
        End Try
    End Sub

End Class
