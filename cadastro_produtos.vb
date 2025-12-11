Public Class cadastro_produtos

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            ' Agora o campo código NÃO é mais obrigatório
            If txt_nome_prod.Text = "" Or txt_categoria.Text = "" Or txt_editora.Text = "" Or txt_preco.Text = "" Or txt_quantidade.Text = "" Then
                MsgBox("Preencha todos os campos (exceto o código)!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            ' Sanitizar textos para evitar erros por aspas simples
            Dim nome As String = txt_nome_prod.Text.Replace("'", "''")
            Dim editora As String = txt_editora.Text.Replace("'", "''")
            Dim categoria As String = txt_categoria.Text.Replace("'", "''")
            Dim preco As String = txt_preco.Text.Replace("'", "''")
            Dim qnt As String = txt_quantidade.Text.Replace("'", "''")
            Dim imgPath As String = diretorio.Replace("'", "''")

            ' Verificar se produto já existe pelo nome
            sql = $"SELECT * FROM tb_produtos WHERE nome_prod = '{nome}'"
            rs = db.Execute(sql)

            '=========================================================
            ' 1) PRODUTO NOVO → INSERT sem o campo codigo
            '=========================================================
            If rs.EOF Then

                sql = "INSERT INTO tb_produtos (nome_prod, editora, categoria, preco, quantidade, imagem) " &
                  $"VALUES ('{nome}', '{editora}', '{categoria}', '{preco}', '{qnt}', '{imgPath}')"

                db.Execute(sql)

                MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information, "ATENÇÃO")

            Else


                Dim codigoExistente As String = rs.Fields("codigo").Value

                sql = "UPDATE tb_produtos SET " &
                  $"nome_prod='{nome}', " &
                  $"editora='{editora}', " &
                  $"categoria='{categoria}', " &
                  $"preco='{preco}', " &
                  $"quantidade='{qnt}', " &
                  $"imagem='{imgPath}' " &
                  $"WHERE codigo={codigoExistente}"

                db.Execute(sql)

                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation, "ATENÇÃO")
            End If

            '=========================================================
            ' RESETAR CAMPOS
            '=========================================================

            txt_nome_prod.Clear()
            txt_categoria.Clear()
            txt_editora.Clear()
            txt_preco.Clear()
            txt_quantidade.Clear()
            img_produto.Load(Application.StartupPath & "\Produtos\10608872.png")

            carregar_dados_produto()

        Catch ex As Exception
            MsgBox("Não foi possível cadastrar o produto!" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ATENÇÃO")
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellContentClick
        Try
            With dgv_produtos
                If .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(8).Selected Then
                    Dim aux_nome_prod As String = .CurrentRow.Cells(0).Value.ToString()

                    ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM tb_produtos WHERE nome_prod = '{aux_nome_prod}'"
                    Dim rs As Object = db.Execute(sql)

                    If rs.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir o produto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"DELETE FROM tb_produtos WHERE nome_prod = '{aux_nome_prod}'"
                            db.Execute(sql)
                            txt_nome_prod.Clear()
                            txt_categoria.Clear()
                            txt_editora.Clear()
                            txt_preco.Clear()
                            txt_quantidade.Clear()
                            img_produto.Load(Application.StartupPath & "\Produtos\10608872.png")
                            carregar_dados_produto()
                        End If
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(7).Selected Then
                    Dim aux_nome_prod As String = .CurrentRow.Cells(0).Value.ToString()

                    ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM tb_produtos WHERE nome_prod = '{aux_nome_prod}'"
                    Dim rs As Object = db.Execute(sql)

                    diretorio = rs.Fields(6).Value
                    diretorio = diretorio.Replace("\", "/")
                    txt_nome_prod.Text = rs.Fields(0).Value
                    txt_editora.Text = rs.Fields(1).Value
                    txt_categoria.Text = rs.Fields(2).Value
                    txt_preco.Text = rs.Fields(4).Value
                    txt_quantidade.Text = rs.Fields(5).Value
                    img_produto.Load(rs.Fields(6).Value)
                Else
                    Exit Sub
                End If
            End With
            carregar_dados_produto()
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub cadastro_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_produto()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles img_produto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a imagem do produto"
                .InitialDirectory = Application.StartupPath & "\Produtos"
                .ShowDialog()
                diretorio = .FileName
                diretorio = diretorio.Replace("\", "/")
                img_produto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
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

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        cadastro_clientes.Show()
        Me.Close()

    End Sub
End Class