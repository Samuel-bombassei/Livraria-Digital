<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadastro_clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_clientes))
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_clientes
        '
        Me.btn_clientes.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.Location = New System.Drawing.Point(1118, 729)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(112, 42)
        Me.btn_clientes.TabIndex = 0
        Me.btn_clientes.Text = "Cadastrar"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(767, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome "
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_nome.Location = New System.Drawing.Point(770, 244)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(800, 35)
        Me.txt_nome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(981, 395)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CPF "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1192, 395)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefone"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_email.Location = New System.Drawing.Point(770, 332)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(800, 35)
        Me.txt_email.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(767, 306)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Email, Me.CPF, Me.Telefone, Me.Editar, Me.Excluir})
        Me.dgv_clientes.Location = New System.Drawing.Point(770, 536)
        Me.dgv_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.RowHeadersWidth = 51
        Me.dgv_clientes.RowTemplate.Height = 24
        Me.dgv_clientes.Size = New System.Drawing.Size(800, 149)
        Me.dgv_clientes.TabIndex = 11
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 125
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.Width = 125
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 6
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 125
        '
        'Telefone
        '
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.MinimumWidth = 6
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Width = 125
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.MinimumWidth = 6
        Me.Editar.Name = "Editar"
        Me.Editar.Width = 125
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Excluir.Width = 125
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(984, 427)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(176, 35)
        Me.txt_cpf.TabIndex = 12
        '
        'txt_telefone
        '
        Me.txt_telefone.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.Location = New System.Drawing.Point(1195, 427)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone.Mask = "(99) 99999-9999"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(160, 35)
        Me.txt_telefone.TabIndex = 13
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(4, 768)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 31
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(4, 634)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 88)
        Me.btn_consulta.TabIndex = 30
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(4, 363)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(200, 88)
        Me.btn_pedidos.TabIndex = 29
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(4, 245)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(452, 88)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cadastro de Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(4, 497)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(200, 91)
        Me.btn_usuarios.TabIndex = 27
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(4, 116)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(200, 85)
        Me.btn_produtos.TabIndex = 26
        Me.btn_produtos.Text = "Cadastro de Produtos"
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-5, -7)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(473, 1036)
        Me.GunaPictureBox1.TabIndex = 32
        Me.GunaPictureBox1.TabStop = False
        '
        'cadastro_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.dgv_clientes)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "cadastro_clientes"
        Me.Text = "Cadastro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_clientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Telefone As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
