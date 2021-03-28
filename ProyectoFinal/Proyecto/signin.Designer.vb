<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Singin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Singin))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.titulo = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.Label()
        Me.text4 = New System.Windows.Forms.Label()
        Me.text5 = New System.Windows.Forms.Label()
        Me.text6 = New System.Windows.Forms.Label()
        Me.text7 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.passwordR = New System.Windows.Forms.TextBox()
        Me.cargos = New System.Windows.Forms.ComboBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.others = New System.Windows.Forms.RadioButton()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.text8 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'titulo
        '
        Me.titulo.AutoSize = True
        Me.titulo.Location = New System.Drawing.Point(63, 23)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(39, 13)
        Me.titulo.TabIndex = 1
        Me.titulo.Text = "Label1"
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(28, 208)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(39, 13)
        Me.text1.TabIndex = 2
        Me.text1.Text = "Label1"
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(28, 260)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(39, 13)
        Me.text2.TabIndex = 3
        Me.text2.Text = "Label1"
        '
        'text3
        '
        Me.text3.AutoSize = True
        Me.text3.Location = New System.Drawing.Point(28, 362)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(39, 13)
        Me.text3.TabIndex = 4
        Me.text3.Text = "Label1"
        '
        'text4
        '
        Me.text4.AutoSize = True
        Me.text4.Location = New System.Drawing.Point(28, 411)
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(39, 13)
        Me.text4.TabIndex = 5
        Me.text4.Text = "Label1"
        '
        'text5
        '
        Me.text5.AutoSize = True
        Me.text5.Location = New System.Drawing.Point(28, 461)
        Me.text5.Name = "text5"
        Me.text5.Size = New System.Drawing.Size(39, 13)
        Me.text5.TabIndex = 6
        Me.text5.Text = "Label1"
        '
        'text6
        '
        Me.text6.AutoSize = True
        Me.text6.Location = New System.Drawing.Point(28, 512)
        Me.text6.Name = "text6"
        Me.text6.Size = New System.Drawing.Size(39, 13)
        Me.text6.TabIndex = 7
        Me.text6.Text = "Label1"
        '
        'text7
        '
        Me.text7.AutoSize = True
        Me.text7.Location = New System.Drawing.Point(28, 567)
        Me.text7.Name = "text7"
        Me.text7.Size = New System.Drawing.Size(39, 13)
        Me.text7.TabIndex = 8
        Me.text7.Text = "Label1"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(31, 224)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(201, 20)
        Me.nombre.TabIndex = 9
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(31, 276)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(201, 20)
        Me.lastname.TabIndex = 10
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(31, 378)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(201, 20)
        Me.user.TabIndex = 11
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(31, 427)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(201, 20)
        Me.password.TabIndex = 12
        '
        'passwordR
        '
        Me.passwordR.Location = New System.Drawing.Point(31, 477)
        Me.passwordR.Name = "passwordR"
        Me.passwordR.Size = New System.Drawing.Size(201, 20)
        Me.passwordR.TabIndex = 13
        '
        'cargos
        '
        Me.cargos.FormattingEnabled = True
        Me.cargos.Location = New System.Drawing.Point(31, 528)
        Me.cargos.Name = "cargos"
        Me.cargos.Size = New System.Drawing.Size(201, 21)
        Me.cargos.TabIndex = 14
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(31, 594)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 15
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(98, 594)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 16
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'others
        '
        Me.others.AutoSize = True
        Me.others.Location = New System.Drawing.Point(176, 594)
        Me.others.Name = "others"
        Me.others.Size = New System.Drawing.Size(56, 17)
        Me.others.TabIndex = 17
        Me.others.TabStop = True
        Me.others.Text = "Others"
        Me.others.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(31, 630)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(80, 26)
        Me.btnSign.TabIndex = 18
        Me.btnSign.Text = "Button1"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(152, 630)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 26)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Button2"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'text8
        '
        Me.text8.AutoSize = True
        Me.text8.Location = New System.Drawing.Point(28, 312)
        Me.text8.Name = "text8"
        Me.text8.Size = New System.Drawing.Size(39, 13)
        Me.text8.TabIndex = 20
        Me.text8.Text = "Label1"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(31, 328)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(201, 20)
        Me.email.TabIndex = 21
        '
        'Singin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 677)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.text8)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.others)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.male)
        Me.Controls.Add(Me.cargos)
        Me.Controls.Add(Me.passwordR)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.text7)
        Me.Controls.Add(Me.text6)
        Me.Controls.Add(Me.text5)
        Me.Controls.Add(Me.text4)
        Me.Controls.Add(Me.text3)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Singin"
        Me.Text = "signin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents titulo As Label
    Friend WithEvents text1 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents text3 As Label
    Friend WithEvents text4 As Label
    Friend WithEvents text5 As Label
    Friend WithEvents text6 As Label
    Friend WithEvents text7 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents lastname As TextBox
    Friend WithEvents user As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents passwordR As TextBox
    Friend WithEvents cargos As ComboBox
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents others As RadioButton
    Friend WithEvents btnSign As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents text8 As Label
    Friend WithEvents email As TextBox
End Class
