Public Class consulta_produtos

    '==========================
    ' EVENTOS DE CARREGAMENTO DO FORMULÁRIO
    '==========================
    Private Sub consulta_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        img_produto.SizeMode = PictureBoxSizeMode.Zoom

        ' GARANTE QUE O EVENTO ESTEJA LIGADO (Embora o Handles já faça isso, mantido por segurança)
        AddHandler dgv_produtos.CellClick, AddressOf dgv_produtos_CellClick

        ' CARREGA PRODUTOS
        ' ATENÇÃO: A função CarregarProdutosFiltro deve ser definida em um MÓDULO ou aqui.
        CarregarProdutosFiltro("", "")

        MsgBox("Formulário carregado e evento ligado com sucesso!")

    End Sub

    '==========================
    ' FILTROS (LostFocus)
    '==========================
    Private Sub txt_cod_LostFocus(sender As Object, e As EventArgs) Handles txt_cod.LostFocus
        If txt_cod.Text <> "" Then CarregarProdutosFiltro(txt_cod.Text, "codigo")
    End Sub

    Private Sub txt_nome_prod_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_prod.LostFocus
        If txt_nome_prod.Text <> "" Then CarregarProdutosFiltro(txt_nome_prod.Text, "nome_prod")
    End Sub

    Private Sub txt_editora_LostFocus(sender As Object, e As EventArgs) Handles txt_editora.LostFocus
        If txt_editora.Text <> "" Then CarregarProdutosFiltro(txt_editora.Text, "editora")
    End Sub

    Private Sub txt_categoria_LostFocus(sender As Object, e As EventArgs) Handles txt_categoria.LostFocus
        If txt_categoria.Text <> "" Then CarregarProdutosFiltro(txt_categoria.Text, "categoria")
    End Sub

    Private Sub txt_preco_LostFocus(sender As Object, e As EventArgs) Handles txt_preco.LostFocus
        If txt_preco.Text <> "" Then CarregarProdutosFiltro(txt_preco.Text, "preco")
    End Sub


    '==========================
    ' CLIQUE NO GRID (COM MITIGAÇÃO DE ERRO DE IMAGEM)
    '==========================
    Private Sub dgv_produtos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_produtos.CellClick

        ' Evita clique no cabeçalho
        If e.RowIndex < 0 Then Exit Sub

        Dim linha As DataGridViewRow = dgv_produtos.Rows(e.RowIndex)

        ' Preenche os TextBox
        txt_cod.Text = linha.Cells(0).Value.ToString()
        txt_nome_prod.Text = linha.Cells(1).Value.ToString()
        txt_editora.Text = linha.Cells(2).Value.ToString()
        txt_categoria.Text = linha.Cells(3).Value.ToString()
        txt_preco.Text = linha.Cells(4).Value.ToString()

        ' 1. Limpa a imagem anterior, se houver, antes de tentar carregar a nova
        If img_produto.Image IsNot Nothing Then
            img_produto.Image.Dispose()
            img_produto.Image = Nothing
        End If

        Try
            Dim caminhoImagem As String = ""

            ' Pega o caminho salvo na TAG
            If linha.Tag IsNot Nothing Then
                caminhoImagem = linha.Tag.ToString()
            End If

            ' Se não houver caminho de imagem ou se estiver vazio
            If String.IsNullOrWhiteSpace(caminhoImagem) Then
                Exit Sub ' img_produto já está Nothing
            End If

            ' Se o arquivo não existir fisicamente
            If Not IO.File.Exists(caminhoImagem) Then
                MessageBox.Show("Caminho de imagem salvo, mas arquivo não encontrado:" & vbCrLf & caminhoImagem, "Aviso")
                Exit Sub
            End If

            ' 2. Forma segura de carregar imagem (dentro do bloco Try)
            Using bmpTemp As New Bitmap(caminhoImagem)
                img_produto.Image = New Bitmap(bmpTemp)
            End Using

        Catch ex As Exception
            ' 3. MITIGAÇÃO: Em caso de erro de carregamento (ex: arquivo corrompido),
            ' apenas limpa o PictureBox e NÃO exibe nenhuma mensagem de erro para o usuário.
            img_produto.Image = Nothing
            ' Opcional: Para debug, você pode usar: Debug.WriteLine("Erro ao carregar imagem: " & ex.Message)
        End Try

    End Sub

    '==========================
    ' BOTÕES DE NAVEGAÇÃO
    '==========================
    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        cadastro_produtos.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cadastro_clientes.Show()
        Me.Close()
    End Sub

    Private Sub btn_usuarios_Click(sender As Object, e As EventArgs) Handles btn_usuarios.Click
        cadastro_usuarios.Show()
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

End Class