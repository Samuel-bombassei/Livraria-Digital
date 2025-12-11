<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class consulta_produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(consulta_produtos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome_prod = New System.Windows.Forms.TextBox()
        Me.txt_editora = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_produto = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_categoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(923, 372)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código do Produto"
        '
        'txt_cod
        '
        Me.txt_cod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cod.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_cod.Location = New System.Drawing.Point(927, 400)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(146, 35)
        Me.txt_cod.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(924, 442)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome do Produto"
        '
        'txt_nome_prod
        '
        Me.txt_nome_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome_prod.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_nome_prod.Location = New System.Drawing.Point(928, 471)
        Me.txt_nome_prod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_nome_prod.Name = "txt_nome_prod"
        Me.txt_nome_prod.Size = New System.Drawing.Size(322, 35)
        Me.txt_nome_prod.TabIndex = 4
        '
        'txt_editora
        '
        Me.txt_editora.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_editora.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_editora.Location = New System.Drawing.Point(1101, 400)
        Me.txt_editora.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_editora.Name = "txt_editora"
        Me.txt_editora.Size = New System.Drawing.Size(151, 35)
        Me.txt_editora.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(1098, 372)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Editora"
        '
        'img_produto
        '
        Me.img_produto.BackColor = System.Drawing.Color.White
        Me.img_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_produto.Image = CType(resources.GetObject("img_produto.Image"), System.Drawing.Image)
        Me.img_produto.InitialImage = CType(resources.GetObject("img_produto.InitialImage"), System.Drawing.Image)
        Me.img_produto.Location = New System.Drawing.Point(1276, 431)
        Me.img_produto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.img_produto.Name = "img_produto"
        Me.img_produto.Size = New System.Drawing.Size(141, 150)
        Me.img_produto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_produto.TabIndex = 7
        Me.img_produto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1273, 373)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Imagem"
        '
        'txt_categoria
        '
        Me.txt_categoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_categoria.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_categoria.Location = New System.Drawing.Point(929, 548)
        Me.txt_categoria.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_categoria.Name = "txt_categoria"
        Me.txt_categoria.Size = New System.Drawing.Size(189, 35)
        Me.txt_categoria.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(925, 523)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Categoria"
        '
        'txt_preco
        '
        Me.txt_preco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_preco.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_preco.Location = New System.Drawing.Point(1133, 548)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.Size = New System.Drawing.Size(117, 35)
        Me.txt_preco.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(1130, 523)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Preço"
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.editora, Me.categoria, Me.preco, Me.estoque})
        Me.dgv_produtos.Location = New System.Drawing.Point(854, 625)
        Me.dgv_produtos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.RowHeadersWidth = 51
        Me.dgv_produtos.RowTemplate.Height = 24
        Me.dgv_produtos.Size = New System.Drawing.Size(648, 141)
        Me.dgv_produtos.TabIndex = 14
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'editora
        '
        Me.editora.HeaderText = "Editora"
        Me.editora.Name = "editora"
        '
        'categoria
        '
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        '
        'preco
        '
        Me.preco.HeaderText = "Preço"
        Me.preco.Name = "preco"
        '
        'estoque
        '
        Me.estoque.HeaderText = "Estoque"
        Me.estoque.Name = "estoque"
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(5, 759)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 52
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(5, 625)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(447, 88)
        Me.btn_consulta.TabIndex = 51
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(5, 354)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(200, 88)
        Me.btn_pedidos.TabIndex = 50
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(5, 231)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 88)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Cadastro de Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(5, 488)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(200, 91)
        Me.btn_usuarios.TabIndex = 48
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(5, 107)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(200, 85)
        Me.btn_produtos.TabIndex = 47
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
        Me.GunaPictureBox1.TabIndex = 53
        Me.GunaPictureBox1.TabStop = False
        '
        'consulta_produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1039)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_preco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_categoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.img_produto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_editora)
        Me.Controls.Add(Me.txt_nome_prod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "consulta_produtos"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.Text = "Consulta de Produtos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.img_produto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome_prod As TextBox
    Friend WithEvents txt_editora As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents img_produto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_categoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents editora As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents preco As DataGridViewTextBoxColumn
    Friend WithEvents estoque As DataGridViewTextBoxColumn
End Class
