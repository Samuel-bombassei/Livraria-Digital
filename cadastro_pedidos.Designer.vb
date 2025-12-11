<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastro_pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastro_pedidos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_salvar_pedidos = New System.Windows.Forms.Button()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_data = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_qtde = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_consulta = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_usuarios = New System.Windows.Forms.Button()
        Me.btn_produtos = New System.Windows.Forms.Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_adcionar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(871, 301)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CPF do Cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPF, Me.CODIGO, Me.NOME, Me.DATA, Me.QTDE, Me.VALOR})
        Me.DataGridView1.Location = New System.Drawing.Point(716, 478)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(937, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 8
        Me.CPF.Name = "CPF"
        Me.CPF.Width = 150
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CÓDIGO DO PRODUTO"
        Me.CODIGO.MinimumWidth = 8
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Width = 150
        '
        'NOME
        '
        Me.NOME.HeaderText = "PRODUTO"
        Me.NOME.MinimumWidth = 8
        Me.NOME.Name = "NOME"
        Me.NOME.Width = 150
        '
        'DATA
        '
        Me.DATA.HeaderText = "DATA"
        Me.DATA.MinimumWidth = 8
        Me.DATA.Name = "DATA"
        Me.DATA.Width = 150
        '
        'QTDE
        '
        Me.QTDE.HeaderText = "QUANTIDADE"
        Me.QTDE.MinimumWidth = 8
        Me.QTDE.Name = "QTDE"
        Me.QTDE.Width = 150
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "VALOR FINAL"
        Me.VALOR.MinimumWidth = 8
        Me.VALOR.Name = "VALOR"
        Me.VALOR.Width = 150
        '
        'txt_cod
        '
        Me.txt_cod.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_cod.Location = New System.Drawing.Point(1036, 326)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(168, 35)
        Me.txt_cod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1033, 293)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Código do Produto"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_nome.Location = New System.Drawing.Point(874, 407)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(624, 35)
        Me.txt_nome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(871, 379)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome do Produto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(713, 650)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total"
        '
        'btn_salvar_pedidos
        '
        Me.btn_salvar_pedidos.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar_pedidos.Location = New System.Drawing.Point(1221, 674)
        Me.btn_salvar_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salvar_pedidos.Name = "btn_salvar_pedidos"
        Me.btn_salvar_pedidos.Size = New System.Drawing.Size(115, 67)
        Me.btn_salvar_pedidos.TabIndex = 9
        Me.btn_salvar_pedidos.Text = "Concluir"
        Me.btn_salvar_pedidos.UseVisualStyleBackColor = True
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(874, 323)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(148, 35)
        Me.txt_cpf.TabIndex = 11
        '
        'txt_data
        '
        Me.txt_data.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_data.Location = New System.Drawing.Point(1221, 324)
        Me.txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_data.Mask = "99/99/9999"
        Me.txt_data.Name = "txt_data"
        Me.txt_data.Size = New System.Drawing.Size(110, 35)
        Me.txt_data.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1218, 293)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1345, 293)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Quantidade"
        '
        'txt_qtde
        '
        Me.txt_qtde.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_qtde.Location = New System.Drawing.Point(1348, 324)
        Me.txt_qtde.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtde.Name = "txt_qtde"
        Me.txt_qtde.Size = New System.Drawing.Size(150, 35)
        Me.txt_qtde.TabIndex = 14
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Arial Narrow", 18.0!)
        Me.txt_total.Location = New System.Drawing.Point(716, 674)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(96, 35)
        Me.txt_total.TabIndex = 16
        '
        'btn_sair
        '
        Me.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_sair.FlatAppearance.BorderSize = 15
        Me.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_sair.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_sair.Location = New System.Drawing.Point(12, 768)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(200, 88)
        Me.btn_sair.TabIndex = 38
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_consulta
        '
        Me.btn_consulta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_consulta.Location = New System.Drawing.Point(12, 634)
        Me.btn_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_consulta.Name = "btn_consulta"
        Me.btn_consulta.Size = New System.Drawing.Size(200, 88)
        Me.btn_consulta.TabIndex = 37
        Me.btn_consulta.Text = "Consulta de Produtos"
        Me.btn_consulta.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_pedidos.Location = New System.Drawing.Point(12, 363)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(452, 88)
        Me.btn_pedidos.TabIndex = 36
        Me.btn_pedidos.Text = "Cadastro de Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(12, 240)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 88)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Cadastro de Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_usuarios
        '
        Me.btn_usuarios.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.btn_usuarios.Location = New System.Drawing.Point(12, 497)
        Me.btn_usuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_usuarios.Name = "btn_usuarios"
        Me.btn_usuarios.Size = New System.Drawing.Size(200, 91)
        Me.btn_usuarios.TabIndex = 34
        Me.btn_usuarios.Text = "Cadastro de Usuários"
        Me.btn_usuarios.UseVisualStyleBackColor = True
        '
        'btn_produtos
        '
        Me.btn_produtos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btn_produtos.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.Location = New System.Drawing.Point(12, 116)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(200, 85)
        Me.btn_produtos.TabIndex = 33
        Me.btn_produtos.Text = "Cadastro de Produtos"
        Me.btn_produtos.UseVisualStyleBackColor = True
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(473, 1036)
        Me.GunaPictureBox1.TabIndex = 39
        Me.GunaPictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1794, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 1027)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Voltar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_adcionar
        '
        Me.btn_adcionar.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adcionar.Location = New System.Drawing.Point(1040, 674)
        Me.btn_adcionar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_adcionar.Name = "btn_adcionar"
        Me.btn_adcionar.Size = New System.Drawing.Size(115, 67)
        Me.btn_adcionar.TabIndex = 42
        Me.btn_adcionar.Text = "Adicionar"
        Me.btn_adcionar.UseVisualStyleBackColor = True
        '
        'cadastro_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.btn_adcionar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_consulta)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_usuarios)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_qtde)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_data)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.btn_salvar_pedidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "cadastro_pedidos"
        Me.Text = "Cadastro de Pedidos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_salvar_pedidos As Button
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_data As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_qtde As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOME As DataGridViewTextBoxColumn
    Friend WithEvents DATA As DataGridViewTextBoxColumn
    Friend WithEvents QTDE As DataGridViewTextBoxColumn
    Friend WithEvents VALOR As DataGridViewTextBoxColumn
    Friend WithEvents btn_sair As Button
    Friend WithEvents btn_consulta As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_produtos As Button
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_adcionar As Button
End Class
