<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.verMarcas = New System.Windows.Forms.DataGridView()
        Me.visualizarMarca = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Marca = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Ad = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BoxAddMarca = New System.Windows.Forms.TextBox()
        Me.AddbuttonMarca = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sMarca = New System.Windows.Forms.TextBox()
        Me.searchMarca = New System.Windows.Forms.Label()
        Me.eliminarMarca = New System.Windows.Forms.GroupBox()
        Me.deleteMarca = New System.Windows.Forms.Button()
        Me.labelMarca = New System.Windows.Forms.Label()
        Me.editarMarca = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.editMarca = New System.Windows.Forms.Button()
        Me.boxEditMarca = New System.Windows.Forms.TextBox()
        Me.Almacen = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BoxAddAlmacen1 = New System.Windows.Forms.TextBox()
        Me.BoxAddAlmacen2 = New System.Windows.Forms.TextBox()
        Me.AddbuttonAlmacen = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sAlmacen = New System.Windows.Forms.TextBox()
        Me.searchAlmacen = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteAlmacen = New System.Windows.Forms.Button()
        Me.labelAlmacen = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.editAlmacen = New System.Windows.Forms.Button()
        Me.boxEditAlmacen = New System.Windows.Forms.TextBox()
        Me.verAlmacenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.verMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.visualizarMarca.SuspendLayout()
        Me.Marca.SuspendLayout()
        Me.Ad.SuspendLayout()
        Me.eliminarMarca.SuspendLayout()
        Me.editarMarca.SuspendLayout()
        Me.Almacen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.verAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'verMarcas
        '
        Me.verMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.verMarcas.Location = New System.Drawing.Point(6, 62)
        Me.verMarcas.Name = "verMarcas"
        Me.verMarcas.Size = New System.Drawing.Size(242, 150)
        Me.verMarcas.TabIndex = 0
        '
        'visualizarMarca
        '
        Me.visualizarMarca.Controls.Add(Me.TextBox2)
        Me.visualizarMarca.Controls.Add(Me.TextBox1)
        Me.visualizarMarca.Controls.Add(Me.Label2)
        Me.visualizarMarca.Controls.Add(Me.Label1)
        Me.visualizarMarca.Location = New System.Drawing.Point(254, 62)
        Me.visualizarMarca.Name = "visualizarMarca"
        Me.visualizarMarca.Size = New System.Drawing.Size(192, 150)
        Me.visualizarMarca.TabIndex = 2
        Me.visualizarMarca.TabStop = False
        Me.visualizarMarca.Text = "Visualizar"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(116, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Id:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre: "
        '
        'Marca
        '
        Me.Marca.Controls.Add(Me.ComboBox2)
        Me.Marca.Controls.Add(Me.Ad)
        Me.Marca.Controls.Add(Me.sMarca)
        Me.Marca.Controls.Add(Me.searchMarca)
        Me.Marca.Controls.Add(Me.eliminarMarca)
        Me.Marca.Controls.Add(Me.editarMarca)
        Me.Marca.Controls.Add(Me.verMarcas)
        Me.Marca.Controls.Add(Me.visualizarMarca)
        Me.Marca.Location = New System.Drawing.Point(12, 12)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(1088, 232)
        Me.Marca.TabIndex = 4
        Me.Marca.TabStop = False
        Me.Marca.Text = "Marca"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(104, 27)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'Ad
        '
        Me.Ad.Controls.Add(Me.Label8)
        Me.Ad.Controls.Add(Me.BoxAddMarca)
        Me.Ad.Controls.Add(Me.AddbuttonMarca)
        Me.Ad.Controls.Add(Me.Label3)
        Me.Ad.Location = New System.Drawing.Point(871, 62)
        Me.Ad.Name = "Ad"
        Me.Ad.Size = New System.Drawing.Size(208, 150)
        Me.Ad.TabIndex = 8
        Me.Ad.TabStop = False
        Me.Ad.Text = "Agregar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nombre:"
        '
        'BoxAddMarca
        '
        Me.BoxAddMarca.Location = New System.Drawing.Point(79, 55)
        Me.BoxAddMarca.Name = "BoxAddMarca"
        Me.BoxAddMarca.Size = New System.Drawing.Size(115, 20)
        Me.BoxAddMarca.TabIndex = 6
        '
        'AddbuttonMarca
        '
        Me.AddbuttonMarca.Location = New System.Drawing.Point(119, 97)
        Me.AddbuttonMarca.Name = "AddbuttonMarca"
        Me.AddbuttonMarca.Size = New System.Drawing.Size(75, 23)
        Me.AddbuttonMarca.TabIndex = 5
        Me.AddbuttonMarca.Text = "Agregar"
        Me.AddbuttonMarca.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 1
        '
        'sMarca
        '
        Me.sMarca.Location = New System.Drawing.Point(231, 27)
        Me.sMarca.Name = "sMarca"
        Me.sMarca.Size = New System.Drawing.Size(333, 20)
        Me.sMarca.TabIndex = 7
        '
        'searchMarca
        '
        Me.searchMarca.AutoSize = True
        Me.searchMarca.Location = New System.Drawing.Point(48, 30)
        Me.searchMarca.Name = "searchMarca"
        Me.searchMarca.Size = New System.Drawing.Size(40, 13)
        Me.searchMarca.TabIndex = 6
        Me.searchMarca.Text = "Buscar"
        '
        'eliminarMarca
        '
        Me.eliminarMarca.Controls.Add(Me.deleteMarca)
        Me.eliminarMarca.Controls.Add(Me.labelMarca)
        Me.eliminarMarca.Location = New System.Drawing.Point(657, 62)
        Me.eliminarMarca.Name = "eliminarMarca"
        Me.eliminarMarca.Size = New System.Drawing.Size(208, 150)
        Me.eliminarMarca.TabIndex = 4
        Me.eliminarMarca.TabStop = False
        Me.eliminarMarca.Text = "Eliminar"
        '
        'deleteMarca
        '
        Me.deleteMarca.Location = New System.Drawing.Point(69, 97)
        Me.deleteMarca.Name = "deleteMarca"
        Me.deleteMarca.Size = New System.Drawing.Size(75, 23)
        Me.deleteMarca.TabIndex = 5
        Me.deleteMarca.Text = "Eliminar"
        Me.deleteMarca.UseVisualStyleBackColor = True
        '
        'labelMarca
        '
        Me.labelMarca.AutoSize = True
        Me.labelMarca.Location = New System.Drawing.Point(41, 46)
        Me.labelMarca.Name = "labelMarca"
        Me.labelMarca.Size = New System.Drawing.Size(0, 13)
        Me.labelMarca.TabIndex = 1
        '
        'editarMarca
        '
        Me.editarMarca.Controls.Add(Me.Label11)
        Me.editarMarca.Controls.Add(Me.editMarca)
        Me.editarMarca.Controls.Add(Me.boxEditMarca)
        Me.editarMarca.Location = New System.Drawing.Point(452, 62)
        Me.editarMarca.Name = "editarMarca"
        Me.editarMarca.Size = New System.Drawing.Size(199, 150)
        Me.editarMarca.TabIndex = 3
        Me.editarMarca.TabStop = False
        Me.editarMarca.Text = "Editar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nombre:"
        '
        'editMarca
        '
        Me.editMarca.Location = New System.Drawing.Point(92, 97)
        Me.editMarca.Name = "editMarca"
        Me.editMarca.Size = New System.Drawing.Size(75, 23)
        Me.editMarca.TabIndex = 1
        Me.editMarca.Text = "Editar"
        Me.editMarca.UseVisualStyleBackColor = True
        '
        'boxEditMarca
        '
        Me.boxEditMarca.Location = New System.Drawing.Point(67, 55)
        Me.boxEditMarca.Name = "boxEditMarca"
        Me.boxEditMarca.Size = New System.Drawing.Size(100, 20)
        Me.boxEditMarca.TabIndex = 1
        '
        'Almacen
        '
        Me.Almacen.Controls.Add(Me.ComboBox1)
        Me.Almacen.Controls.Add(Me.GroupBox1)
        Me.Almacen.Controls.Add(Me.sAlmacen)
        Me.Almacen.Controls.Add(Me.searchAlmacen)
        Me.Almacen.Controls.Add(Me.GroupBox2)
        Me.Almacen.Controls.Add(Me.GroupBox3)
        Me.Almacen.Controls.Add(Me.verAlmacenes)
        Me.Almacen.Controls.Add(Me.GroupBox4)
        Me.Almacen.Location = New System.Drawing.Point(12, 250)
        Me.Almacen.Name = "Almacen"
        Me.Almacen.Size = New System.Drawing.Size(1088, 233)
        Me.Almacen.TabIndex = 5
        Me.Almacen.TabStop = False
        Me.Almacen.Text = "Almacen"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BoxAddAlmacen1)
        Me.GroupBox1.Controls.Add(Me.BoxAddAlmacen2)
        Me.GroupBox1.Controls.Add(Me.AddbuttonAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(874, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "N° de Planta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nombre:"
        '
        'BoxAddAlmacen1
        '
        Me.BoxAddAlmacen1.Location = New System.Drawing.Point(68, 37)
        Me.BoxAddAlmacen1.Name = "BoxAddAlmacen1"
        Me.BoxAddAlmacen1.Size = New System.Drawing.Size(123, 20)
        Me.BoxAddAlmacen1.TabIndex = 7
        '
        'BoxAddAlmacen2
        '
        Me.BoxAddAlmacen2.Location = New System.Drawing.Point(91, 68)
        Me.BoxAddAlmacen2.Name = "BoxAddAlmacen2"
        Me.BoxAddAlmacen2.Size = New System.Drawing.Size(100, 20)
        Me.BoxAddAlmacen2.TabIndex = 6
        '
        'AddbuttonAlmacen
        '
        Me.AddbuttonAlmacen.Location = New System.Drawing.Point(116, 100)
        Me.AddbuttonAlmacen.Name = "AddbuttonAlmacen"
        Me.AddbuttonAlmacen.Size = New System.Drawing.Size(75, 23)
        Me.AddbuttonAlmacen.TabIndex = 5
        Me.AddbuttonAlmacen.Text = "Agregar"
        Me.AddbuttonAlmacen.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 1
        '
        'sAlmacen
        '
        Me.sAlmacen.Location = New System.Drawing.Point(231, 26)
        Me.sAlmacen.Name = "sAlmacen"
        Me.sAlmacen.Size = New System.Drawing.Size(333, 20)
        Me.sAlmacen.TabIndex = 9
        '
        'searchAlmacen
        '
        Me.searchAlmacen.AutoSize = True
        Me.searchAlmacen.Location = New System.Drawing.Point(48, 29)
        Me.searchAlmacen.Name = "searchAlmacen"
        Me.searchAlmacen.Size = New System.Drawing.Size(40, 13)
        Me.searchAlmacen.TabIndex = 8
        Me.searchAlmacen.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteAlmacen)
        Me.GroupBox2.Controls.Add(Me.labelAlmacen)
        Me.GroupBox2.Location = New System.Drawing.Point(657, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 150)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar"
        '
        'deleteAlmacen
        '
        Me.deleteAlmacen.Location = New System.Drawing.Point(64, 97)
        Me.deleteAlmacen.Name = "deleteAlmacen"
        Me.deleteAlmacen.Size = New System.Drawing.Size(75, 23)
        Me.deleteAlmacen.TabIndex = 5
        Me.deleteAlmacen.Text = "Eliminar"
        Me.deleteAlmacen.UseVisualStyleBackColor = True
        '
        'labelAlmacen
        '
        Me.labelAlmacen.AutoSize = True
        Me.labelAlmacen.Location = New System.Drawing.Point(33, 54)
        Me.labelAlmacen.Name = "labelAlmacen"
        Me.labelAlmacen.Size = New System.Drawing.Size(0, 13)
        Me.labelAlmacen.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.editAlmacen)
        Me.GroupBox3.Controls.Add(Me.boxEditAlmacen)
        Me.GroupBox3.Location = New System.Drawing.Point(452, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 150)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Editar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "N° de Planta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Nombre:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(92, 68)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 7
        '
        'editAlmacen
        '
        Me.editAlmacen.Location = New System.Drawing.Point(92, 97)
        Me.editAlmacen.Name = "editAlmacen"
        Me.editAlmacen.Size = New System.Drawing.Size(75, 23)
        Me.editAlmacen.TabIndex = 1
        Me.editAlmacen.Text = "Editar"
        Me.editAlmacen.UseVisualStyleBackColor = True
        '
        'boxEditAlmacen
        '
        Me.boxEditAlmacen.Location = New System.Drawing.Point(67, 37)
        Me.boxEditAlmacen.Name = "boxEditAlmacen"
        Me.boxEditAlmacen.Size = New System.Drawing.Size(100, 20)
        Me.boxEditAlmacen.TabIndex = 1
        '
        'verAlmacenes
        '
        Me.verAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.verAlmacenes.Location = New System.Drawing.Point(6, 63)
        Me.verAlmacenes.Name = "verAlmacenes"
        Me.verAlmacenes.Size = New System.Drawing.Size(242, 150)
        Me.verAlmacenes.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(254, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(192, 150)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Visualizar"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(77, 97)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(98, 20)
        Me.TextBox6.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Id:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(77, 68)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(97, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(77, 37)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(97, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ubicacion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre: "
        '
        'mas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 493)
        Me.Controls.Add(Me.Almacen)
        Me.Controls.Add(Me.Marca)
        Me.Name = "mas"
        Me.Text = "mas"
        CType(Me.verMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.visualizarMarca.ResumeLayout(False)
        Me.visualizarMarca.PerformLayout()
        Me.Marca.ResumeLayout(False)
        Me.Marca.PerformLayout()
        Me.Ad.ResumeLayout(False)
        Me.Ad.PerformLayout()
        Me.eliminarMarca.ResumeLayout(False)
        Me.eliminarMarca.PerformLayout()
        Me.editarMarca.ResumeLayout(False)
        Me.editarMarca.PerformLayout()
        Me.Almacen.ResumeLayout(False)
        Me.Almacen.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.verAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents verMarcas As DataGridView
    Friend WithEvents visualizarMarca As GroupBox
    Friend WithEvents Marca As GroupBox
    Friend WithEvents eliminarMarca As GroupBox
    Friend WithEvents editarMarca As GroupBox
    Friend WithEvents deleteMarca As Button
    Friend WithEvents labelMarca As Label
    Friend WithEvents editMarca As Button
    Friend WithEvents boxEditMarca As TextBox
    Friend WithEvents Almacen As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents deleteAlmacen As Button
    Friend WithEvents labelAlmacen As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents editAlmacen As Button
    Friend WithEvents boxEditAlmacen As TextBox
    Friend WithEvents verAlmacenes As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents sMarca As TextBox
    Friend WithEvents searchMarca As Label
    Friend WithEvents sAlmacen As TextBox
    Friend WithEvents searchAlmacen As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ad As GroupBox
    Friend WithEvents BoxAddMarca As TextBox
    Friend WithEvents AddbuttonMarca As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BoxAddAlmacen2 As TextBox
    Friend WithEvents AddbuttonAlmacen As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BoxAddAlmacen1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
