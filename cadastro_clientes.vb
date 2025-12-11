Public Class cadastro_clientes
    Private Sub cadastro_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_cliente()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Try
            If txt_nome.Text = "" Or txt_email.Text = "" Or String.IsNullOrWhiteSpace(txt_cpf.Text) Or String.IsNullOrWhiteSpace(txt_telefone.Text) Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Else

                sql = $"Select * FROM tb_clientes WHERE cpf = '{txt_cpf.Text}'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = $"INSERT INTO tb_clientes (nome, email, cpf, telefone) VALUES ('{txt_nome.Text}', '{txt_email.Text}', '{txt_cpf.Text}', '{txt_telefone.Text}')"
                    rs = db.Execute(sql)
                    MsgBox("Cliente cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                    txt_nome.Clear()
                    txt_email.Clear()
                    txt_cpf.Clear()
                    txt_telefone.Clear()
                    carregar_dados_cliente()

                Else
                    sql = $"update tb_clientes set nome='{txt_nome.Text}',
                                            email ='{txt_email.Text}',
                                           cpf='{txt_cpf.Text}',
                                           telefone ='{txt_telefone.Text}' where cpf='{txt_cpf.Text}'"
                    rs = db.Execute(sql)

                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

                    txt_nome.Clear()
                    txt_email.Clear()
                    txt_cpf.Clear()
                    txt_telefone.Clear()
                    carregar_dados_cliente()

                End If
            End If

        Catch ex As Exception
            MsgBox("Não foi possível cadastrar o cliente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nome.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpf.MaskInputRejected

    End Sub

    Private Sub dgv_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellContentClick
        Try
            With dgv_clientes
                If .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(5).Selected Then
                    Dim aux_nome As String = .CurrentRow.Cells(0).Value.ToString()

                    ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM tb_clientes WHERE nome = '{aux_nome}'"
                    Dim rs As Object = db.Execute(sql)

                    If rs.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir o cliente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"DELETE FROM tb_clientes WHERE nome = '{aux_nome}'"
                            db.Execute(sql)
                        End If
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(4).Selected Then
                    Dim aux_nome As String = .CurrentRow.Cells(0).Value.ToString()

                    ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM tb_clientes WHERE nome = '{aux_nome}'"
                    Dim rs As Object = db.Execute(sql)

                    txt_nome.Text = rs.Fields(0).Value
                    txt_email.Text = rs.Fields(1).Value
                    txt_cpf.Text = rs.Fields(2).Value
                    txt_telefone.Text = rs.Fields(3).Value

                Else
                    Exit Sub
                End If
            End With
            carregar_dados_cliente()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub



    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        cadastro_produtos.Show()
        Me.Close()
    End Sub


    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        cadastro_usuarios.Show()
        Me.Close()
    End Sub

    Private Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        consulta_produtos.Show()
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

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        cadastro_pedidos.Show()
        Me.Close()
    End Sub
End Class