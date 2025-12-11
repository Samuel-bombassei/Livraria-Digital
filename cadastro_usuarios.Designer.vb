<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_usuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_repita = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_usuarios = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Ativar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(805, 321)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Usuário"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(806, 347)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(566, 35)
        Me.txt_nome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(805, 389)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_senha.Location = New System.Drawing.Point(806, 415)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(566, 35)
        Me.txt_senha.TabIndex = 5
        '
        'txt_repita
        '
        Me.txt_repita.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_repita.Location = New System.Drawing.Point(806, 488)
        Me.txt_repita.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_repita.Name = "txt_repita"
        Me.txt_repita.Size = New System.Drawing.Size(566, 35)
        Me.txt_repita.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(805, 462)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repita a Senha"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.White
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(1387, 317)
        Me.img_foto.Margin = New System.Windows.Forms.Padding(2)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(176, 206)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 8
        Me.img_foto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(1384, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Foto"
        '
        'dgv_usuarios
        '
        Me.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome, Me.Senha, Me.Tipo, Me.Status, Me.Foto, Me.Editar, Me.Bloquear, Me.Ativar, Me.Excluir})
        Me.dgv_usuarios.Location = New System.Drawing.Point(593, 568)
        Me.dgv_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_usuarios.Name = "dgv_usuarios"
        Me.dgv_usuarios.RowHeadersWidth = 51
        Me.dgv_usuarios.RowTemplate.Height = 24
        Me.dgv_usuarios.Size = New System.Drawing.Size(1178, 115)
        Me.dgv_usuarios.TabIndex = 10
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 125
        '
        'Senha
        '
        Me.Senha.HeaderText = "Senha"
        Me.Senha.MinimumWidth = 6
        Me.Senha.Name = "Senha"
        Me.Senha.Width = 125
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 125
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.MinimumWidth = 6
        Me.Foto.Name = "Foto"
        Me.Foto.Width = 125
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.MinimumWidth = 6
        Me.Editar.Name = "Editar"
        Me.Editar.Width = 125
        '
        'Bloquear
        '
        Me.Bloquear.HeaderText = "Bloquear"
        Me.Bloquear.Image = CType(resources.GetObject("Bloquear.Image"), System.Drawing.Image)
        Me.Bloquear.MinimumWidth = 6
        Me.Bloquear.Name = "Bloquear"
        Me.Bloquear.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bloquear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Bloquear.Width = 125
        '
        'Ativar
        '
        Me.Ativar.HeaderText = "Ativar"
        Me.Ativar.Image = CType(resources.GetObject("Ativar.Image"), System.Drawing.Image)
        Me.Ativar.MinimumWidth = 6
        Me.Ativar.Name = "Ativar"
        Me.Ativar.Width = 125
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Width = 125
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.White
        Me.btn_cadastrar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.Location = New System.Drawing.Point(1092, 728)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(117, 41)
        Me.btn_cadastrar.TabIndex = 11
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(9, 769)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 45
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(9, 635)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 88)
        Me.btn_consulta.TabIndex = 44
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(9, 364)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(200, 88)
        Me.btn_pedidos.TabIndex = 43
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(9, 241)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 88)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cadastro de Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(9, 498)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(452, 91)
        Me.btn_usuarios.TabIndex = 41
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(9, 117)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(200, 85)
        Me.btn_produtos.TabIndex = 40
        Me.btn_produtos.Text = "Cadastro de Produtos"
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(473, 1036)
        Me.GunaPictureBox1.TabIndex = 46
        Me.GunaPictureBox1.TabStop = False
        '
        'cadastro_usuarios
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
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.dgv_usuarios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.img_foto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_repita)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "cadastro_usuarios"
        Me.Text = "Cadastro de Usuários "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_repita As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_usuarios As DataGridView
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Senha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Bloquear As DataGridViewImageColumn
    Friend WithEvents Ativar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
