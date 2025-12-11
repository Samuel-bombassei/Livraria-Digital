Imports System.Xml
Imports ADODB

Public Class login
    Private Sub login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_senha.PasswordChar = "•"
        txt_usuario.Clear()
        txt_senha.Clear()
        conectar_banco()
    End Sub
    Sub login_adm()
        Form1.Show()
    End Sub
    Sub login_usuario()
        Form1.Show()
        Form1.ts_cad_clientes.Visible = False
        Form1.ts_cad_prod.Visible = False
        Form1.CadastroDeUsuáriosToolStripMenuItem.Visible = False

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            usuario = txt_usuario.Text
            senha = txt_senha.Text

            ' Verifica campos vazios
            If usuario = "" Or senha = "" Then
                MsgBox("Preencha todos os campos.", MsgBoxStyle.Exclamation, "ATENÇÃO")
                Exit Sub
            End If

            ' Garante que o banco esteja aberto
            If db.State = 0 Then
                db.Open()
            End If

            sql = $"SELECT * FROM usuarios WHERE usuario = '{usuario}' AND senha = '{senha}'"
            rs = New ADODB.Recordset
            rs.Open(sql, db, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

            If Not rs.EOF Then
                tipo = rs.Fields("tipo").Value.ToString
                status = rs.Fields("status").Value.ToString

                ' Verifica se o usuário está ativo
                If status.ToLower() = "bloqueado" Then
                    MsgBox("Seu acesso está bloqueado. Contate o administrador.", MsgBoxStyle.Critical, "Acesso negado")
                    rs.Close()
                    Exit Sub
                End If

                ' Login permitido
                MsgBox("Login realizado com sucesso!", MsgBoxStyle.Information, "Bem-vindo")

                ' Exibe o menu principal conforme o tipo de usuário
                menu1.Show()

                If tipo.ToLower() = "usuario" Then
                    login_usuario()
                ElseIf tipo.ToLower() = "admin" Then
                    login_adm()
                End If

                Me.Hide()
            Else
                MsgBox("Usuário ou senha incorretos!", MsgBoxStyle.Exclamation, "Erro de login")
            End If

            rs.Close()
        Catch ex As Exception
            MsgBox("Erro ao tentar fazer login:" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub esconder_senhaChanged(sender As Object, e As EventArgs) Handles esconder_senha.CheckedChanged
        If esconder_senha.Checked Then
            ' Mostrar senha
            txt_senha.PasswordChar = ""
        Else
            ' Esconder senha
            txt_senha.PasswordChar = "•"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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