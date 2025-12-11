Public Class cadastro_usuarios

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            If txt_senha.Text <> txt_repita.Text Then
                MsgBox("As senhas não conferem!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            ElseIf txt_nome.Text = "" Or txt_senha.Text = "" Or txt_repita.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = $"Select * FROM usuarios WHERE usuario = '{txt_nome.Text}'"
                rs = db.Execute(sql)
                If rs.EOF = True Then
                    sql = $"INSERT INTO usuarios (usuario, senha, tipo, status, imagem) VALUES ('{txt_nome.Text}', '{txt_senha.Text}', 'usuario', 'ativo', '{diretorio}')"
                    rs = db.Execute(sql)
                    MsgBox("Usuário cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_nome.Clear()
                    txt_repita.Clear()
                    txt_senha.Clear()
                    img_foto.Load(Application.StartupPath & "\Usuarios\wondicon-ui-free-add-user_111248.png")
                    carregar_dados_usuario()
                Else
                    sql = $"update usuarios set usuario ='{txt_nome.Text}', senha = '{txt_senha.Text}', imagem = '{diretorio}' where usuario = '{txt_nome.Text}'"
                    rs = db.Execute(sql)
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_nome.Clear()
                    txt_repita.Clear()
                    txt_senha.Clear()
                    img_foto.Load(Application.StartupPath & "\Usuarios\wondicon-ui-free-add-user_111248.png")
                    carregar_dados_usuario()
                End If
            End If
        Catch ex As Exception
            MsgBox("Não foi possível cadastrar o usuário!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cadastro_usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_usuario()
    End Sub

    Private Sub dgv_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_usuarios.CellContentClick
        Try
            With dgv_usuarios
                If .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(8).Selected Then
                    Dim aux_usuario As String = .CurrentRow.Cells(0).Value.ToString() ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM usuarios WHERE usuario = '{aux_usuario}'"
                    Dim rs As Object = db.Execute(sql)
                    If rs.EOF = False Then
                        Dim resp As MsgBoxResult = MsgBox("Deseja realmente excluir o usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"DELETE FROM usuarios WHERE usuario = '{aux_usuario}'"
                            db.Execute(sql)
                        End If
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(7).Selected Then
                    Dim aux_usuario As String = .CurrentRow.Cells(0).Value.ToString() ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM usuarios WHERE usuario = '{aux_usuario}'"
                    Dim rs As Object = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = $"UPDATE usuarios SET status = 'ativo' WHERE usuario = '{aux_usuario}'"
                        db.Execute(sql)
                        MsgBox("Usuário desbloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(6).Selected Then
                    Dim aux_usuario As String = .CurrentRow.Cells(0).Value.ToString() ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM usuarios WHERE usuario = '{aux_usuario}'"
                    Dim rs As Object = db.Execute(sql)
                    If rs.EOF = False Then
                        sql = $"UPDATE usuarios SET status = 'bloqueado' WHERE usuario = '{aux_usuario}'"
                        db.Execute(sql)
                        MsgBox("Usuário bloqueado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    End If

                ElseIf .CurrentRow IsNot Nothing AndAlso .CurrentRow.Cells(5).Selected Then
                    Dim aux_nome_prod As String = .CurrentRow.Cells(0).Value.ToString() ' Corrigido: faltava o campo a ser selecionado
                    Dim sql As String = $"SELECT * FROM usuarios WHERE usuario = '{aux_nome_prod}'"
                    Dim rs As Object = db.Execute(sql)
                    diretorio = rs.Fields(5).Value
                    diretorio = diretorio.Replace("\", "/")
                    txt_nome.Text = rs.Fields(1).Value
                    txt_repita.Text = rs.Fields(2).Value
                    txt_senha.Text = rs.Fields(2).Value
                    img_foto.Load(rs.Fields(5).Value)

                Else
                    Exit Sub
                End If
            End With

            carregar_dados_usuario()
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

        carregar_dados_usuario()
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione a foto do usuário"
                .InitialDirectory = Application.StartupPath & "\Usuarios"
                .ShowDialog()
                diretorio = .FileName
                diretorio = diretorio.Replace("\", "/")
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_produtos_Click(sender As Object, e As EventArgs) Handles btn_produtos.Click
        cadastro_produtos.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cadastro_clientes.Show()
        Me.Close()
    End Sub

    Private Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        consulta_produtos.Show()
        Me.Close()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        cadastro_pedidos.Show()
        Me.Close()
    End Sub

End Class
