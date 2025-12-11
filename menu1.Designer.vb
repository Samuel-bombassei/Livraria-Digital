<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu1))
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(11, 124)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(200, 85)
        Me.btn_produtos.TabIndex = 1
        Me.btn_produtos.Text = "Cadastro de Produtos"
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(11, 511)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(200, 91)
        Me.btn_usuarios.TabIndex = 2
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_clientes.Location = New System.Drawing.Point(11, 243)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(200, 88)
        Me.btn_clientes.TabIndex = 3
        Me.btn_clientes.Text = "Cadastro de Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(11, 377)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(200, 88)
        Me.btn_pedidos.TabIndex = 4
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(11, 648)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 88)
        Me.btn_consulta.TabIndex = 5
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(11, 782)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1013, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(889, 1047)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-6, -7)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(473, 1036)
        Me.GunaPictureBox1.TabIndex = 47
        Me.GunaPictureBox1.TabStop = False
        '
        'menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "menu1"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_produtos As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
