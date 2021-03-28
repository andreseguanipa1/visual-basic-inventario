Public Class Validaciones

    'Instanciamos las variables a utilizar.
    Public name As String
    Public lastname As String
    Public user As String
    Public pass1 As String
    Public pass2 As String

    'Instanciamos las variables a utilizar como comprobador.
    Dim caracteres = ",/\*-+._¿'¡?!#$%&/()[]´¨~|¬°@=1234567890"
    Dim caracter = ""
    Dim caracteres1 = ",¿'¡?!#$%&/()[]´¨~/\|¬°@=*"
    Dim caracter1 = ""

    'Funcion para validar el nombre y apellido.
    Public Function validateName(name As String) As Boolean

        For k = 1 To Len(caracteres)
            caracter = Mid(caracteres, k, 1)
            For l = 1 To Len(name)
                If Mid(name, l, 1) = caracter Then
                    Return False
                End If
            Next l
        Next k

        Return True
    End Function

    'Funcion para validar el nombre usuario.
    Public Function validateUser() As Boolean

        For k = 1 To Len(caracteres1)
            caracter1 = Mid(caracteres1, k, 1)
            For l = 1 To Len(Me.user)
                If Mid(Me.user, l, 1) = caracter1 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    'Funcion para validar el email.
    Public Function validateEmail(email As String) As Boolean
        For i = 1 To Len(email)
            If Mid(email, i, 1) = "@" Then
                If (Mid(email, i + 1) = "hotmail.com") Or (Mid((email), i + 1) = "gmail.com") Or (Mid((email), i + 1) = "yahoo.com") Or (Mid((email), i + 1) = "urbe.edu") Then
                    Return True
                    Exit For
                End If
            End If
        Next i
        Return False
    End Function

    'Funcion para comprobar que las contrasenas sean iguales.
    Public Function validatePassword() As Boolean
        If Me.pass1 = Me.pass2 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Funcion para validar que un input sea solo numeros.
    Public Function validateNumber(number As String) As Boolean
        If IsNumeric(number) = True Then
            Dim numero = CInt(number)
            If numero < 0 Then
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    'Funcion para validar el cargo.
    'Actualmente en desuso.
    Public Function validarCargo(cargo As String) As Integer
        If cargo = "Administrador" Then
            Return 1

        Else
            Return 2

        End If
    End Function

    'Funcion para Validar la llave foranea de un cargo.
    'Actualmetne en desuso.
    Public Function validarCargoFK(cargo As String) As String
        If cargo = "1" Then
            Return "Administrador"

        Else
            Return "Gerente"

        End If
    End Function

End Class

