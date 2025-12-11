<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_pedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_prod = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeUsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ts_cad_clientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ts_cad_pedidos, Me.ConsultaDeProdutosToolStripMenuItem, Me.ts_cad_prod, Me.CadastroDeUsuáriosToolStripMenuItem, Me.ts_cad_clientes, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1204, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ts_cad_pedidos
        '
        Me.ts_cad_pedidos.Name = "ts_cad_pedidos"
        Me.ts_cad_pedidos.Size = New System.Drawing.Size(192, 29)
        Me.ts_cad_pedidos.Text = "Cadastro de Pedidos"
        '
        'ConsultaDeProdutosToolStripMenuItem
        '
        Me.ConsultaDeProdutosToolStripMenuItem.Name = "ConsultaDeProdutosToolStripMenuItem"
        Me.ConsultaDeProdutosToolStripMenuItem.Size = New System.Drawing.Size(200, 29)
        Me.ConsultaDeProdutosToolStripMenuItem.Text = "Consulta de Produtos"
        '
        'ts_cad_prod
        '
        Me.ts_cad_prod.Name = "ts_cad_prod"
        Me.ts_cad_prod.Size = New System.Drawing.Size(202, 29)
        Me.ts_cad_prod.Text = "Cadastro de Produtos"
        '
        'CadastroDeUsuáriosToolStripMenuItem
        '
        Me.CadastroDeUsuáriosToolStripMenuItem.Name = "CadastroDeUsuáriosToolStripMenuItem"
        Me.CadastroDeUsuáriosToolStripMenuItem.Size = New System.Drawing.Size(197, 29)
        Me.CadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários"
        '
        'ts_cad_clientes
        '
        Me.ts_cad_clientes.Name = "ts_cad_clientes"
        Me.ts_cad_clientes.Size = New System.Drawing.Size(190, 29)
        Me.ts_cad_clientes.Text = "Cadastro de Clientes"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(91, 29)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1204, 558)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ts_cad_clientes As ToolStripMenuItem
    Friend WithEvents ts_cad_pedidos As ToolStripMenuItem
    Friend WithEvents ConsultaDeProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ts_cad_prod As ToolStripMenuItem
    Friend WithEvents CadastroDeUsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
End Class
