Public Class Form1
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs)
        login.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cadastro_clientes.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cadastro_produtos.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ts_cad_clientes.Click
        cadastro_clientes.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDePedidosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ts_cad_pedidos.Click
        cadastro_pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub ConsultaDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeProdutosToolStripMenuItem.Click
        consulta_produtos.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ts_cad_prod.Click
        cadastro_produtos.Show()
        Me.Hide()
    End Sub

    Private Sub CadastroDeUsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeUsuáriosToolStripMenuItem.Click
        cadastro_usuarios.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        conectar_banco()

    End Sub

    Private Sub EncerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarToolStripMenuItem.Click
        Dim resposta As MsgBoxResult
        resposta = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmação")

        ' Verifica a resposta
        If resposta = MsgBoxResult.Yes Then
            Application.Exit() ' Sai do programa
        Else
            ' Não faz nada se a resposta for Não
        End If
    End Sub
End Class