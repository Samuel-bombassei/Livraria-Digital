<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_produtos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.txt_editora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preço = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(895, 247)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Produto"
        '
        'txt_nome_prod
        '
        Me.txt_nome_prod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_prod.Location = New System.Drawing.Point(898, 282)
        Me.txt_nome_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_prod.Name = "txt_nome_prod"
        Me.txt_nome_prod.Size = New System.Drawing.Size(610, 24)
        Me.txt_nome_prod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1220, 323)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Categoria "
        '
        'txt_categoria
        '
        Me.txt_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_categoria.Location = New System.Drawing.Point(1223, 354)
        Me.txt_categoria.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(285, 24)
        Me.txt_categoria.TabIndex = 3
        '
        'txt_editora
        '
        Me.txt_editora.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_editora.Location = New System.Drawing.Point(898, 354)
        Me.txt_editora.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(309, 24)
        Me.txt_editora.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(895, 323)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Editora"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(1169, 689)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(106, 41)
        Me.btn_cadastrar.TabIndex = 6
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'img_produto
        '
        Me.img_produto.BackColor = System.Drawing.Color.White
        Me.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.InitialImage = CType(resources.GetObject("img_produto.InitialImage"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(1512, 282)
        Me.img_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(150, 210)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produto.TabIndex = 7
        Me.img_produto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1509, 247)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Imagem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1066, 416)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Preço"
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Editora, Me.Categoria, Me.Código, Me.Preço, Me.Quantidade, Me.Imagem, Me.Editar, Me.Excluir})
        Me.dgv_produtos.Location = New System.Drawing.Point(898, 505)
        Me.dgv_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.RowHeadersWidth = 51
        Me.dgv_produtos.RowTemplate.Height = 24
        Me.dgv_produtos.Size = New System.Drawing.Size(764, 154)
        Me.dgv_produtos.TabIndex = 13
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 125
        '
        'Editora
        '
        Me.Editora.HeaderText = "Editora"
        Me.Editora.MinimumWidth = 6
        Me.Editora.Name = "Editora"
        Me.Editora.Width = 125
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.MinimumWidth = 6
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Width = 125
        '
        'Código
        '
        Me.Código.HeaderText = "Código"
        Me.Código.MinimumWidth = 6
        Me.Código.Name = "Código"
        Me.Código.Width = 125
        '
        'Preço
        '
        Me.Preço.HeaderText = "Preço"
        Me.Preço.MinimumWidth = 6
        Me.Preço.Name = "Preço"
        Me.Preço.Width = 125
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.MinimumWidth = 6
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.Width = 125
        '
        'Imagem
        '
        Me.Imagem.HeaderText = "Imagem"
        Me.Imagem.MinimumWidth = 6
        Me.Imagem.Name = "Imagem"
        Me.Imagem.Width = 125
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
        Me.Excluir.Width = 125
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(1069, 446)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(138, 24)
        Me.txt_preco.TabIndex = 14
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantidade.Location = New System.Drawing.Point(1223, 446)
        Me.txt_quantidade.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(138, 24)
        Me.txt_quantidade.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1220, 416)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Quantidade"
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(11, 776)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 24
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(11, 642)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 88)
        Me.btn_consulta.TabIndex = 23
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(11, 371)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(200, 88)
        Me.btn_pedidos.TabIndex = 22
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_clientes.Location = New System.Drawing.Point(11, 237)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(200, 88)
        Me.btn_clientes.TabIndex = 21
        Me.btn_clientes.Text = "Cadastro de Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(11, 505)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(200, 91)
        Me.btn_usuarios.TabIndex = 20
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(11, 124)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(452, 85)
        Me.btn_produtos.TabIndex = 19
        Me.btn_produtos.Text = "Cadastro de Produtos"
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(473, 1036)
        Me.GunaPictureBox1.TabIndex = 25
        Me.GunaPictureBox1.TabStop = False
        '
        'cadastro_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.img_produto)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_editora)
        Me.Controls.Add(Me.txt_categoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_prod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "cadastro_produtos"
        Me.Text = "Cadastro de Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_prod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_categoria As TextBox
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Editora As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Preço As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Imagem As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
