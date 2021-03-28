<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrega
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.entregas = New System.Windows.Forms.DataGridView()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.opciones = New System.Windows.Forms.ComboBox()
        Me.text1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCls = New System.Windows.Forms.Button()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.text7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.text6 = New System.Windows.Forms.Label()
        Me.text5 = New System.Windows.Forms.Label()
        Me.text4 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.Label()
        Me.producto = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.proveedor = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.text2 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.text9 = New System.Windows.Forms.Label()
        Me.text8 = New System.Windows.Forms.Label()
        Me.proveedores = New System.Windows.Forms.DataGridView()
        Me.productos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.entregas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.proveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'entregas
        '
        Me.entregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.entregas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.entregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.entregas.Location = New System.Drawing.Point(12, 52)
        Me.entregas.Name = "entregas"
        Me.entregas.Size = New System.Drawing.Size(592, 185)
        Me.entregas.TabIndex = 0
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(234, 26)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(298, 20)
        Me.buscar.TabIndex = 1
        '
        'opciones
        '
        Me.opciones.FormattingEnabled = True
        Me.opciones.Location = New System.Drawing.Point(107, 25)
        Me.opciones.Name = "opciones"
        Me.opciones.Size = New System.Drawing.Size(121, 21)
        Me.opciones.TabIndex = 2
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(12, 20)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(39, 13)
        Me.text1.TabIndex = 3
        Me.text1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCls)
        Me.GroupBox1.Controls.Add(Me.cantidad)
        Me.GroupBox1.Controls.Add(Me.text7)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.text6)
        Me.GroupBox1.Controls.Add(Me.text5)
        Me.GroupBox1.Controls.Add(Me.text4)
        Me.GroupBox1.Controls.Add(Me.text3)
        Me.GroupBox1.Controls.Add(Me.producto)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.proveedor)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Location = New System.Drawing.Point(619, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 334)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrega"
        '
        'btnCls
        '
        Me.btnCls.Location = New System.Drawing.Point(114, 294)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(85, 34)
        Me.btnCls.TabIndex = 13
        Me.btnCls.Text = "Button2"
        Me.btnCls.UseVisualStyleBackColor = True
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(10, 257)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(183, 20)
        Me.cantidad.TabIndex = 11
        '
        'text7
        '
        Me.text7.AutoSize = True
        Me.text7.Location = New System.Drawing.Point(7, 241)
        Me.text7.Name = "text7"
        Me.text7.Size = New System.Drawing.Size(39, 13)
        Me.text7.TabIndex = 10
        Me.text7.Text = "Label5"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 294)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 34)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Button1"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'text6
        '
        Me.text6.AutoSize = True
        Me.text6.Location = New System.Drawing.Point(6, 187)
        Me.text6.Name = "text6"
        Me.text6.Size = New System.Drawing.Size(39, 13)
        Me.text6.TabIndex = 9
        Me.text6.Text = "Label5"
        '
        'text5
        '
        Me.text5.AutoSize = True
        Me.text5.Location = New System.Drawing.Point(7, 130)
        Me.text5.Name = "text5"
        Me.text5.Size = New System.Drawing.Size(39, 13)
        Me.text5.TabIndex = 8
        Me.text5.Text = "Label4"
        '
        'text4
        '
        Me.text4.AutoSize = True
        Me.text4.Location = New System.Drawing.Point(6, 76)
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(39, 13)
        Me.text4.TabIndex = 7
        Me.text4.Text = "Label3"
        '
        'text3
        '
        Me.text3.AutoSize = True
        Me.text3.Location = New System.Drawing.Point(7, 28)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(39, 13)
        Me.text3.TabIndex = 6
        Me.text3.Text = "Label2"
        '
        'producto
        '
        Me.producto.Location = New System.Drawing.Point(9, 203)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(183, 20)
        Me.producto.TabIndex = 5
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(9, 146)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(183, 20)
        Me.codigo.TabIndex = 4
        '
        'proveedor
        '
        Me.proveedor.Location = New System.Drawing.Point(9, 92)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(183, 20)
        Me.proveedor.TabIndex = 3
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(10, 44)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(183, 20)
        Me.id.TabIndex = 2
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(7, 24)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(39, 13)
        Me.text2.TabIndex = 1
        Me.text2.Text = "Label1"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(10, 40)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(183, 20)
        Me.fecha.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.text9)
        Me.GroupBox2.Controls.Add(Me.text8)
        Me.GroupBox2.Controls.Add(Me.proveedores)
        Me.GroupBox2.Controls.Add(Me.productos)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 204)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Infomacion Entrega"
        '
        'text9
        '
        Me.text9.AutoSize = True
        Me.text9.Location = New System.Drawing.Point(329, 37)
        Me.text9.Name = "text9"
        Me.text9.Size = New System.Drawing.Size(39, 13)
        Me.text9.TabIndex = 3
        Me.text9.Text = "Label2"
        '
        'text8
        '
        Me.text8.AutoSize = True
        Me.text8.Location = New System.Drawing.Point(6, 37)
        Me.text8.Name = "text8"
        Me.text8.Size = New System.Drawing.Size(39, 13)
        Me.text8.TabIndex = 2
        Me.text8.Text = "Label1"
        '
        'proveedores
        '
        Me.proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.proveedores.Location = New System.Drawing.Point(332, 53)
        Me.proveedores.Name = "proveedores"
        Me.proveedores.Size = New System.Drawing.Size(254, 142)
        Me.proveedores.TabIndex = 1
        '
        'productos
        '
        Me.productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productos.Location = New System.Drawing.Point(6, 53)
        Me.productos.Name = "productos"
        Me.productos.Size = New System.Drawing.Size(306, 142)
        Me.productos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.text2)
        Me.GroupBox3.Controls.Add(Me.fecha)
        Me.GroupBox3.Location = New System.Drawing.Point(619, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(199, 96)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busqueda"
        '
        'entrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 451)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.opciones)
        Me.Controls.Add(Me.entregas)
        Me.Controls.Add(Me.buscar)
        Me.Name = "entrega"
        Me.Text = "Entrega"
        CType(Me.entregas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.proveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents entregas As DataGridView
    Friend WithEvents buscar As TextBox
    Friend WithEvents opciones As ComboBox
    Friend WithEvents text1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents text6 As Label
    Friend WithEvents text5 As Label
    Friend WithEvents text4 As Label
    Friend WithEvents text3 As Label
    Friend WithEvents producto As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents proveedor As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents text2 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents text7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCls As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents text9 As Label
    Friend WithEvents text8 As Label
    Friend WithEvents proveedores As DataGridView
    Friend WithEvents productos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
End Class
