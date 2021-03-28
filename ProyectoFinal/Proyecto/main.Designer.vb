<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.btnEmp = New System.Windows.Forms.Button()
        Me.btngroup = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOtr = New System.Windows.Forms.Button()
        Me.btnEnt = New System.Windows.Forms.Button()
        Me.btnPro = New System.Windows.Forms.Button()
        Me.articulos = New System.Windows.Forms.DataGridView()
        Me.search = New System.Windows.Forms.TextBox()
        Me.opciones = New System.Windows.Forms.ComboBox()
        Me.text1 = New System.Windows.Forms.Label()
        Me.grupoProducto = New System.Windows.Forms.GroupBox()
        Me.btnDelet = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.text8 = New System.Windows.Forms.Label()
        Me.text7 = New System.Windows.Forms.Label()
        Me.text6 = New System.Windows.Forms.Label()
        Me.text5 = New System.Windows.Forms.Label()
        Me.text4 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.almacen = New System.Windows.Forms.ComboBox()
        Me.marca = New System.Windows.Forms.ComboBox()
        Me.clase = New System.Windows.Forms.ComboBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.userinfo = New System.Windows.Forms.GroupBox()
        Me.tusuario = New System.Windows.Forms.Label()
        Me.tcargo = New System.Windows.Forms.Label()
        Me.tapellido = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.Label()
        Me.btngroup.SuspendLayout()
        CType(Me.articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoProducto.SuspendLayout()
        Me.userinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEmp
        '
        Me.btnEmp.Image = CType(resources.GetObject("btnEmp.Image"), System.Drawing.Image)
        Me.btnEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmp.Location = New System.Drawing.Point(6, 19)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(151, 52)
        Me.btnEmp.TabIndex = 0
        Me.btnEmp.Text = "Button1"
        Me.btnEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmp.UseVisualStyleBackColor = True
        '
        'btngroup
        '
        Me.btngroup.Controls.Add(Me.btnExit)
        Me.btngroup.Controls.Add(Me.btnOtr)
        Me.btngroup.Controls.Add(Me.btnEnt)
        Me.btngroup.Controls.Add(Me.btnPro)
        Me.btngroup.Controls.Add(Me.btnEmp)
        Me.btngroup.Location = New System.Drawing.Point(0, 185)
        Me.btngroup.Name = "btngroup"
        Me.btngroup.Size = New System.Drawing.Size(168, 287)
        Me.btngroup.TabIndex = 1
        Me.btngroup.TabStop = False
        Me.btngroup.Text = "Opciones"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(6, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(30, 25)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Button1"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOtr
        '
        Me.btnOtr.Image = CType(resources.GetObject("btnOtr.Image"), System.Drawing.Image)
        Me.btnOtr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOtr.Location = New System.Drawing.Point(6, 193)
        Me.btnOtr.Name = "btnOtr"
        Me.btnOtr.Size = New System.Drawing.Size(151, 52)
        Me.btnOtr.TabIndex = 2
        Me.btnOtr.Text = "Button4"
        Me.btnOtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOtr.UseVisualStyleBackColor = True
        '
        'btnEnt
        '
        Me.btnEnt.Image = CType(resources.GetObject("btnEnt.Image"), System.Drawing.Image)
        Me.btnEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnt.Location = New System.Drawing.Point(6, 135)
        Me.btnEnt.Name = "btnEnt"
        Me.btnEnt.Size = New System.Drawing.Size(151, 52)
        Me.btnEnt.TabIndex = 2
        Me.btnEnt.Text = "Button3"
        Me.btnEnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnt.UseVisualStyleBackColor = True
        '
        'btnPro
        '
        Me.btnPro.Image = CType(resources.GetObject("btnPro.Image"), System.Drawing.Image)
        Me.btnPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPro.Location = New System.Drawing.Point(6, 77)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(151, 52)
        Me.btnPro.TabIndex = 2
        Me.btnPro.Text = "Button2"
        Me.btnPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'articulos
        '
        Me.articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.articulos.Location = New System.Drawing.Point(175, 256)
        Me.articulos.Name = "articulos"
        Me.articulos.Size = New System.Drawing.Size(772, 216)
        Me.articulos.TabIndex = 2
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(468, 229)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(479, 20)
        Me.search.TabIndex = 3
        '
        'opciones
        '
        Me.opciones.FormattingEnabled = True
        Me.opciones.Location = New System.Drawing.Point(323, 229)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(139, 21)
        Me.opciones.TabIndex = 4
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(187, 218)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(39, 13)
        Me.text1.TabIndex = 5
        Me.text1.Text = "Label1"
        '
        'grupoProducto
        '
        Me.grupoProducto.Controls.Add(Me.btnDelet)
        Me.grupoProducto.Controls.Add(Me.btnEdit)
        Me.grupoProducto.Controls.Add(Me.btnCls)
        Me.grupoProducto.Controls.Add(Me.text8)
        Me.grupoProducto.Controls.Add(Me.text7)
        Me.grupoProducto.Controls.Add(Me.text6)
        Me.grupoProducto.Controls.Add(Me.text5)
        Me.grupoProducto.Controls.Add(Me.text4)
        Me.grupoProducto.Controls.Add(Me.text3)
        Me.grupoProducto.Controls.Add(Me.text2)
        Me.grupoProducto.Controls.Add(Me.btnAdd)
        Me.grupoProducto.Controls.Add(Me.almacen)
        Me.grupoProducto.Controls.Add(Me.marca)
        Me.grupoProducto.Controls.Add(Me.clase)
        Me.grupoProducto.Controls.Add(Me.precio)
        Me.grupoProducto.Controls.Add(Me.cantidad)
        Me.grupoProducto.Controls.Add(Me.nombre)
        Me.grupoProducto.Controls.Add(Me.codigo)
        Me.grupoProducto.Location = New System.Drawing.Point(174, 0)
        Me.grupoProducto.Name = "grupoProducto"
        Me.grupoProducto.Size = New System.Drawing.Size(753, 192)
        Me.grupoProducto.TabIndex = 6
        Me.grupoProducto.TabStop = False
        Me.grupoProducto.Text = "Producto"
        '
        'btnDelet
        '
        Me.btnDelet.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelet.Location = New System.Drawing.Point(538, 84)
        Me.btnDelet.Name = "btnDelet"
        Me.btnDelet.Size = New System.Drawing.Size(98, 36)
        Me.btnDelet.TabIndex = 18
        Me.btnDelet.Text = "Button1"
        Me.btnDelet.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEdit.Location = New System.Drawing.Point(649, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 36)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Button1"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCls
        '
        Me.btnCls.Location = New System.Drawing.Point(649, 84)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(98, 36)
        Me.btnCls.TabIndex = 16
        Me.btnCls.Text = "Button1"
        Me.btnCls.UseVisualStyleBackColor = True
        '
        'text8
        '
        Me.text8.AutoSize = True
        Me.text8.Location = New System.Drawing.Point(6, 135)
        Me.text8.Name = "text8"
        Me.text8.Size = New System.Drawing.Size(39, 13)
        Me.text8.TabIndex = 15
        Me.text8.Text = "Label7"
        '
        'text7
        '
        Me.text7.AutoSize = True
        Me.text7.Location = New System.Drawing.Point(360, 77)
        Me.text7.Name = "text7"
        Me.text7.Size = New System.Drawing.Size(39, 13)
        Me.text7.TabIndex = 14
        Me.text7.Text = "Label6"
        '
        'text6
        '
        Me.text6.AutoSize = True
        Me.text6.Location = New System.Drawing.Point(177, 77)
        Me.text6.Name = "text6"
        Me.text6.Size = New System.Drawing.Size(39, 13)
        Me.text6.TabIndex = 13
        Me.text6.Text = "Label5"
        '
        'text5
        '
        Me.text5.AutoSize = True
        Me.text5.Location = New System.Drawing.Point(349, 19)
        Me.text5.Name = "text5"
        Me.text5.Size = New System.Drawing.Size(39, 13)
        Me.text5.TabIndex = 12
        Me.text5.Text = "Label4"
        '
        'text4
        '
        Me.text4.AutoSize = True
        Me.text4.Location = New System.Drawing.Point(6, 77)
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(39, 13)
        Me.text4.TabIndex = 11
        Me.text4.Text = "Label3"
        '
        'text3
        '
        Me.text3.AutoSize = True
        Me.text3.Location = New System.Drawing.Point(177, 19)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(39, 13)
        Me.text3.TabIndex = 10
        Me.text3.Text = "Label2"
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(6, 19)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(39, 13)
        Me.text2.TabIndex = 9
        Me.text2.Text = "Label1"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnAdd.Location = New System.Drawing.Point(538, 19)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 36)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Button1"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'almacen
        '
        Me.almacen.FormattingEnabled = True
        Me.almacen.Location = New System.Drawing.Point(6, 151)
        Me.almacen.Name = "almacen"
        Me.almacen.Size = New System.Drawing.Size(143, 21)
        Me.almacen.TabIndex = 6
        '
        'marca
        '
        Me.marca.FormattingEnabled = True
        Me.marca.Location = New System.Drawing.Point(352, 94)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(143, 21)
        Me.marca.TabIndex = 5
        '
        'clase
        '
        Me.clase.FormattingEnabled = True
        Me.clase.Location = New System.Drawing.Point(180, 92)
        Me.clase.Name = "clase"
        Me.clase.Size = New System.Drawing.Size(143, 21)
        Me.clase.TabIndex = 4
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(352, 35)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(143, 20)
        Me.precio.TabIndex = 3
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(6, 93)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(143, 20)
        Me.cantidad.TabIndex = 2
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(180, 35)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(143, 20)
        Me.nombre.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(6, 35)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(143, 20)
        Me.codigo.TabIndex = 0
        '
        'userinfo
        '
        Me.userinfo.Controls.Add(Me.tusuario)
        Me.userinfo.Controls.Add(Me.tcargo)
        Me.userinfo.Controls.Add(Me.tapellido)
        Me.userinfo.Controls.Add(Me.tnombre)
        Me.userinfo.Location = New System.Drawing.Point(5, 0)
        Me.userinfo.Name = "userinfo"
        Me.userinfo.Size = New System.Drawing.Size(162, 185)
        Me.userinfo.TabIndex = 7
        Me.userinfo.TabStop = False
        Me.userinfo.Text = "Informacion"
        '
        'tusuario
        '
        Me.tusuario.AutoSize = True
        Me.tusuario.Location = New System.Drawing.Point(7, 145)
        Me.tusuario.Name = "tusuario"
        Me.tusuario.Size = New System.Drawing.Size(39, 13)
        Me.tusuario.TabIndex = 3
        Me.tusuario.Text = "Label4"
        '
        'tcargo
        '
        Me.tcargo.AutoSize = True
        Me.tcargo.Location = New System.Drawing.Point(7, 101)
        Me.tcargo.Name = "tcargo"
        Me.tcargo.Size = New System.Drawing.Size(39, 13)
        Me.tcargo.TabIndex = 2
        Me.tcargo.Text = "Label3"
        '
        'tapellido
        '
        Me.tapellido.AutoSize = True
        Me.tapellido.Location = New System.Drawing.Point(7, 61)
        Me.tapellido.Name = "tapellido"
        Me.tapellido.Size = New System.Drawing.Size(39, 13)
        Me.tapellido.TabIndex = 1
        Me.tapellido.Text = "Label2"
        '
        'tnombre
        '
        Me.tnombre.AutoSize = True
        Me.tnombre.Location = New System.Drawing.Point(7, 25)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(39, 13)
        Me.tnombre.TabIndex = 0
        Me.tnombre.Text = "Label1"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 485)
        Me.Controls.Add(Me.userinfo)
        Me.Controls.Add(Me.grupoProducto)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.articulos)
        Me.Controls.Add(Me.btngroup)
        Me.Name = "main"
        Me.Text = "main"
        Me.btngroup.ResumeLayout(False)
        CType(Me.articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoProducto.ResumeLayout(False)
        Me.grupoProducto.PerformLayout()
        Me.userinfo.ResumeLayout(False)
        Me.userinfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmp As Button
    Friend WithEvents btngroup As GroupBox
    Friend WithEvents btnOtr As Button
    Friend WithEvents btnEnt As Button
    Friend WithEvents btnPro As Button
    Friend WithEvents articulos As DataGridView
    Friend WithEvents search As TextBox
    Friend WithEvents opciones As ComboBox
    Friend WithEvents text1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents grupoProducto As GroupBox
    Friend WithEvents almacen As ComboBox
    Friend WithEvents marca As ComboBox
    Friend WithEvents clase As ComboBox
    Friend WithEvents precio As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents text8 As Label
    Friend WithEvents text7 As Label
    Friend WithEvents text6 As Label
    Friend WithEvents text5 As Label
    Friend WithEvents text4 As Label
    Friend WithEvents text3 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents btnCls As Button
    Friend WithEvents btnDelet As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents userinfo As GroupBox
    Friend WithEvents tusuario As Label
    Friend WithEvents tcargo As Label
    Friend WithEvents tapellido As Label
    Friend WithEvents tnombre As Label
End Class
