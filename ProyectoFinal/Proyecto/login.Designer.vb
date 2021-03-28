<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.avatar = New System.Windows.Forms.PictureBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.text1 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.horas = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'avatar
        '
        Me.avatar.Cursor = System.Windows.Forms.Cursors.Default
        Me.avatar.Image = CType(resources.GetObject("avatar.Image"), System.Drawing.Image)
        Me.avatar.Location = New System.Drawing.Point(12, 47)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(166, 152)
        Me.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.avatar.TabIndex = 0
        Me.avatar.TabStop = False
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(215, 85)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(213, 20)
        Me.user.TabIndex = 1
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(215, 137)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(213, 20)
        Me.password.TabIndex = 2
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Location = New System.Drawing.Point(258, 28)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(39, 13)
        Me.Titulo.TabIndex = 3
        Me.Titulo.Text = "Label1"
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Location = New System.Drawing.Point(212, 69)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(39, 13)
        Me.text1.TabIndex = 4
        Me.text1.Text = "Label2"
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Location = New System.Drawing.Point(212, 121)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(39, 13)
        Me.text2.TabIndex = 5
        Me.text2.Text = "Label3"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(215, 192)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(97, 29)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Button1"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(339, 192)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(89, 29)
        Me.btnSign.TabIndex = 7
        Me.btnSign.Text = "Button2"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.Location = New System.Drawing.Point(12, 223)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(39, 13)
        Me.horas.TabIndex = 8
        Me.horas.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 254)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.avatar)
        Me.Name = "login"
        Me.Text = "Form1"
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents user As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Titulo As Label
    Friend WithEvents text1 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSign As Button
    Friend WithEvents horas As Label
    Friend WithEvents Timer1 As Timer
End Class
