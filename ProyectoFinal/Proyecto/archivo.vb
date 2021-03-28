Imports System.IO
'Clase para crear un archivo con el horario de ingreso y salida de sistema de un usaurio.
Public Class Archivo
    'Obtenemos el directorio del escritorio y le anexamos el nombre del archivo.

    Public Shared path As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\login.txt"

    'Constructor, no lo necesitaremos.
    Public Shared Sub Archivo(user As String)

    End Sub

    'Funcion que recibe como parametro el nombre del usuario para hacer el registro.
    Public Shared Sub Login(user As String)
        'Este simple metodo del sistema rebice tres paramatros, primero el directorio para crear el archivo (sino existe) o sobreescribirlo (en caso de que exista),
        'El segundo parametros el texto del archivo, y el tercer parametro es un valor booleano ("True" -> para anexar contenido, "False" -> para eliminar todo el contendio y escribir solo el nuevo.)
        'Date.Now -> proporciona la informacion de tiempo del sistema.

        My.Computer.FileSystem.WriteAllText(path, "Fecha de Ingreso: " & Date.Now & " Usuario: " & user & vbCrLf, True)
    End Sub

    'Funcion que recibe como parametro el nombre del usuario para hacer el registro.
    Public Shared Sub SalLogin(user As String)
        'Este simple metodo del sistema rebice tres paramatros, primero el directorio para crear el archivo (sino existe) o sobreescribirlo (en caso de que exista),
        'El segundo parametros el texto del archivo, y el tercer parametro es un valor booleano ("True" -> para anexar contenido, "False" -> para eliminar todo el contendio y escribir solo el nuevo.)
        'Date.Now -> proporciona la informacion de tiempo del sistema.

        My.Computer.FileSystem.WriteAllText(path, "Fecha de Salida: " & Date.Now & " Usuario: " & user & vbCrLf, True)
    End Sub
End Class
