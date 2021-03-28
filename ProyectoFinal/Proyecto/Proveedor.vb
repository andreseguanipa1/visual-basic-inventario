Imports DataBase
Imports MySql.Data.MySqlClient
Public Class Proveedor
    'Intanciamos la sentencia SQL
    Dim sql As String = "Select * from proveedor"
    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Instanaciamos los elementos del Select
        Dim elementos() As String = {"id", "proveedor", "pais", "ciudad", "calle"}

        'Cargamos los elementos de la base de datos en el objecto DataGridView.
        Operaciones.ConsultaGrid(sql, proveedores)

        'Limpiamos los inputs
        cleanInputs()

        'Datmos estilos a la forma.
        With Me
            .CenterToScreen()
            .FormBorderStyle = BorderStyle.FixedSingle
            .MinimizeBox = False
            .MaximizeBox = False
            .BackColor = ColorTranslator.FromHtml("#F2F2F2")
        End With
        With text1
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "ID:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text2
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Proveedor:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text3
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Ciudad:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text4
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Calle:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text5
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Pais:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With text6
            .Font = New Font("Arial", 16, FontStyle.Bold)
            .Text = "Buscar:"
            .ForeColor = ColorTranslator.FromHtml("#484D6D")
        End With
        With opciones
            .Items.AddRange(elementos)
            .SelectedIndex = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With btnAdd
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Agregar"
            .BackColor = ColorTranslator.FromHtml("#57A773")
            .ForeColor = ColorTranslator.FromHtml("#EFE9F4")
        End With
        With btnEdit
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Actualizar"
            .BackColor = ColorTranslator.FromHtml("#08B2E3")
            .ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            .Enabled = False
        End With
        With btnDelet
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Eliminar"
            .BackColor = ColorTranslator.FromHtml("#EE6352")
            .ForeColor = ColorTranslator.FromHtml("#FFFFFF")
            .Enabled = False
        End With
        With btnCls
            .FlatStyle = FlatStyle.Popup
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Text = "Limpiar"
        End With
        'Deshabilidatamos el input del id.
        id.Enabled = False
    End Sub

    'Evento click para agregar un nuevo proveedor.
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Instanciamos la variables a utilizar
        Dim validarCampos = New Validaciones()
        Dim a = validarCampos.validateName(nombre.Text)
        validarCampos.user = calle.Text
        Dim b = validarCampos.validateUser()
        Dim c = validarCampos.validateName(pais.Text)
        Dim d = validarCampos.validateName(ciudad.Text)

        'Realizamos la validaciones pertienentes.
        If (nombre.Text = "" Or calle.Text = "" Or pais.Text = "" Or ciudad.Text = "") Then
            MsgBox("Ninguno de los campos pueden estar vacios!", MsgBoxStyle.Critical, "Aviso!")

        Else

            If a = False Then
                MsgBox("Nombre: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If b = False Then
                MsgBox("Calle: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If c = False Then
                MsgBox("Pais: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If d = False Then
                MsgBox("Ciudad: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If

            'Si todo es correcot.
            'Creamos el nuevo elemento en la bases de datos.
            If a = True And b = True And c = True And d = True Then

                'Insertamos el nuevo elemento en la Base de Datos.
                Operaciones.ingresar("insert into proveedor values(null, '" & nombre.Text & "', '" & pais.Text & "', '" & ciudad.Text & "', '" & calle.Text & "')")

                'Actualizamos la lista de proveedores.
                Operaciones.ConsultaGrid(sql, proveedores)

                'Limpiamos los inputs.
                cleanInputs()
                MsgBox("Proveedor agregado exitosamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")
            End If

        End If

    End Sub

    'Metodo para limpiar los inputs.
    Private Sub cleanInputs()
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btnDelet.Enabled = False
        id.Text = ""
        nombre.Text = ""
        pais.Text = ""
        ciudad.Text = ""
        calle.Text = ""
    End Sub

    'Evento click para editar un proveedor.
    'Solo activo si se selecciona un proveedor con anterioridad.
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Instanciamos los variables a utilizar.
        Dim validarCampos = New Validaciones()
        Dim a = validarCampos.validateName(nombre.Text)
        validarCampos.user = calle.Text
        Dim b = validarCampos.validateUser()
        Dim c = validarCampos.validateName(pais.Text)
        Dim d = validarCampos.validateName(ciudad.Text)

        'Realizamos las validaciones correspondientes.
        If (nombre.Text = "" Or calle.Text = "" Or pais.Text = "" Or ciudad.Text = "") Then
            MsgBox("Ninguno de los campos pueden estar vacios!", MsgBoxStyle.Critical, "Aviso!")

        Else

            If a = False Then
                MsgBox("Nombre: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If b = False Then
                MsgBox("Calle: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If c = False Then
                MsgBox("Pais: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If
            If d = False Then
                MsgBox("Ciudad: La combinacion de caracteres ingresada es incorrecta", MsgBoxStyle.Critical, "Aviso!")
            End If

            'Si todo es correcto.
            'Acualizamos el elemento en la Base de Datos.
            If a = True And b = True And c = True And d = True Then

                'Actualizamos la informacion del proveedor.
                Operaciones.ingresar("update proveedor set proveedor='" & nombre.Text & "', pais='" & pais.Text & "', ciudad='" & ciudad.Text & "', calle='" & calle.Text & "' where id=" & id.Text)

                'Actualizamos la lsita de proveedores.
                Operaciones.ConsultaGrid(sql, proveedores)

                'Limpiamos los inputs.
                cleanInputs()
                MsgBox("Proveedor editado exitosamente!", MsgBoxStyle.MsgBoxRight, "Aviso!")
            End If

        End If

    End Sub

    'Evento de click en las celdas del DataGridView
    Private Sub proveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles proveedores.CellContentClick
        'Obtenemos el indice del Grid
        Dim psc As Integer = proveedores.CurrentRow.Index

        'Ajustamos los botones
        btnAdd.Enabled = False
        btnEdit.Enabled = True
        btnDelet.Enabled = True

        'Agregamos la informacion
        id.Text = proveedores.Item(0, psc).Value()
        nombre.Text = proveedores.Item(1, psc).Value()
        pais.Text = proveedores.Item(2, psc).Value()
        ciudad.Text = proveedores.Item(3, psc).Value()
        calle.Text = proveedores.Item(4, psc).Value()
    End Sub

    'Evento click en el boton "btnCls" para limpiar los inputs.
    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        cleanInputs()
    End Sub

    'Evento click para eliminar un proveedor.
    'Solo activo si se selecciona un proveedor con anterioridad.
    Private Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click
        Operaciones.ingresar("delete from proveedor where id=" & id.Text)
        Operaciones.ConsultaGrid(sql, proveedores)
        cleanInputs()
    End Sub

    'Evento TextChanged para actualizar la busqueda de un proveedor.
    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        'Actualizamos la informacion del DataGridView proveniente de la Base de Datos.
        Operaciones.ConsultaGrid("select * from proveedor where " & opciones.Text & " like '%" & buscar.Text & "%'", proveedores)
    End Sub
End Class