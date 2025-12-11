Public Class menu1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        Me.Close()
        consulta_produtos.Show()
    End Sub

    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        cadastro_produtos.Show()
        Me.Close()

    End Sub

    Private Sub menu1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        cadastro_usuarios.Show()
        Me.Close()

    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        cadastro_clientes.Show()
        Me.Close()

    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        cadastro_pedidos.Show()
        Me.Close()

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resposta As MsgBoxResult
        resposta = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmação")

        ' Verifica a resposta
        If resposta = MsgBoxResult.Yes Then
            Application.Exit() ' Sai do programa
        Else
            ' Não faz nada se a resposta for Não
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class