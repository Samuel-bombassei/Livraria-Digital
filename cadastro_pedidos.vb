Imports System.Globalization

Public Class cadastro_pedidos

    Private precoUnit As Double = 0
    Private desconto_aplicado As Double = 0
    Private totalGeral As Double = 0

    Private Sub cadastro_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conectar_banco()
            carregar_dados_pedidos()

            ' DATA AUTOMÁTICA
            txt_data.Text = Date.Now.ToString("dd/MM/yyyy")

        Catch ex As Exception
            MsgBox("Erro ao iniciar sistema: " & ex.Message, vbCritical)
        End Try
    End Sub

    ' ======================
    ' DESCONTO POR CPF
    ' ======================
    Private Sub txt_cpf_Leave(sender As Object, e As EventArgs) Handles txt_cpf.Leave
        VerificarDesconto()
        AtualizarTotal()
    End Sub

    Private Sub VerificarDesconto()

        desconto_aplicado = 0

        If txt_cpf.Text.Trim = "" Then Exit Sub

        Dim rs As Object = Nothing

        Try
            rs = CreateObject("ADODB.Recordset")

            sql = "SELECT cpf FROM tb_clientes WHERE cpf='" & txt_cpf.Text.Replace("'", "''") & "'"
            rs.Open(sql, db, 3, 1)

            If Not rs.EOF Then
                desconto_aplicado = 0.1
                MsgBox("Desconto de cliente aplicado (10%)", vbInformation)
            End If

        Catch ex As Exception
            MsgBox("Erro no CPF: " & ex.Message, vbCritical)

        Finally
            If rs IsNot Nothing AndAlso rs.State = 1 Then rs.Close()
        End Try

    End Sub

    ' ======================
    ' BUSCA PRODUTO AUTOMÁTICO
    ' ======================
    Private Sub txt_cod_Leave(sender As Object, e As EventArgs) Handles txt_cod.Leave
        BuscarProduto()
        AtualizarTotal()
    End Sub

    Private Sub BuscarProduto()

        If Not IsNumeric(txt_cod.Text) Then
            txt_nome.Clear()
            precoUnit = 0
            Exit Sub
        End If

        Dim rs As Object = Nothing

        Try
            rs = CreateObject("ADODB.Recordset")

            sql = "SELECT nome_prod, preco FROM tb_produtos WHERE codigo=" & txt_cod.Text
            rs.Open(sql, db, 3, 1)

            If Not rs.EOF Then
                txt_nome.Text = rs("nome_prod").Value
                precoUnit = CDbl(rs("preco").Value.ToString().Replace(",", "."))
            Else
                txt_nome.Clear()
                precoUnit = 0
            End If

        Catch ex As Exception
            MsgBox("Erro produto: " & ex.Message, vbCritical)

        Finally
            If rs IsNot Nothing AndAlso rs.State = 1 Then rs.Close()
        End Try

    End Sub

    ' ======================
    ' CONTROLE DE QUANTIDADE
    ' ======================
    Private Sub txt_qtde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtde.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Chr(8) Then e.Handled = True
    End Sub

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        AtualizarTotal()
    End Sub

    ' ======================
    ' CALCULA TOTAL
    ' ======================
    Private Sub AtualizarTotal()

        If txt_qtde.Text = "" Or precoUnit <= 0 Then
            txt_total.Text = "0,00"
            Exit Sub
        End If

        Dim qtd As Integer
        If Not Integer.TryParse(txt_qtde.Text, qtd) Then Exit Sub

        Dim subtotal = precoUnit * qtd
        Dim total = subtotal * (1 - desconto_aplicado)

        txt_total.Text = total.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"))

    End Sub

    ' ======================
    ' CHECA ESTOQUE
    ' ======================
    Private Function EstoqueSuficiente(cod As Integer, qtd As Integer) As Boolean

        Dim rs As Object = Nothing

        Try
            rs = CreateObject("ADODB.Recordset")
            sql = "SELECT quantidade FROM tb_produtos WHERE codigo=" & cod
            rs.Open(sql, db, 3, 1)

            If rs.EOF Then
                MsgBox("Produto não existe.", vbCritical)
                Return False
            End If

            Dim est As Integer = rs("quantidade").Value

            If est < qtd Then
                MsgBox("Estoque insuficiente. Disponível: " & est, vbExclamation)
                Return False
            End If

            Return True

        Catch ex As Exception
            MsgBox("Erro estoque: " & ex.Message, vbCritical)
            Return False

        Finally
            If rs IsNot Nothing AndAlso rs.State = 1 Then rs.Close()
        End Try

    End Function

    ' ======================
    ' BAIXA ESTOQUE
    ' ======================
    Private Sub BaixarEstoque(cod As Integer, qtd As Integer)
        sql = "UPDATE tb_produtos SET quantidade = quantidade - " & qtd &
              " WHERE codigo = " & cod
        db.Execute(sql)
    End Sub

    ' ======================
    ' ADICIONAR PRODUTO
    ' ======================
    Private Sub btn_adcionar_Click(sender As Object, e As EventArgs) Handles btn_adcionar.Click

        Try

            If txt_cpf.Text = "" Or txt_data.Text = "" Then
                MsgBox("Informe CPF e DATA antes de adicionar.", vbExclamation)
                Exit Sub
            End If

            If txt_cod.Text = "" Or txt_qtde.Text = "" Then
                MsgBox("Informe produto e quantidade.", vbExclamation)
                Exit Sub
            End If

            Dim cod = CInt(txt_cod.Text)
            Dim qtd = CInt(txt_qtde.Text)

            If Not EstoqueSuficiente(cod, qtd) Then Exit Sub

            BaixarEstoque(cod, qtd)

            Dim dataSQL = Date.Parse(txt_data.Text).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
            Dim totalSQL = Replace(txt_total.Text, ".", "")
            totalSQL = Replace(totalSQL, ",", ".")

            sql = "INSERT INTO pedidos (cpf_cliente, cod_prod, [data], nome_prod, quantidade, valor_total) VALUES (" &
                  "'" & txt_cpf.Text & "', " & cod & ", #" & dataSQL & "#, '" &
                  txt_nome.Text & "', " & qtd & ", " & totalSQL & ")"

            db.Execute(sql)

            MsgBox("Produto adicionado.", vbInformation)

            txt_cod.Clear()
            txt_nome.Clear()
            txt_qtde.Clear()
            txt_total.Text = "0,00"
            precoUnit = 0

            txt_cod.Focus()

        Catch ex As Exception
            MsgBox("Erro ao adicionar: " & ex.Message, vbCritical)
        End Try

    End Sub

    ' ======================
    ' FINALIZAR PEDIDO
    ' ======================
    Private Sub btn_salvar_pedidos_Click(sender As Object, e As EventArgs) Handles btn_salvar_pedidos.Click

        Try
            AtualizarTotalGeral()

            MsgBox("✅ Pedido salvo!" & vbCrLf &
                   "💰 Total: R$ " & totalGeral.ToString("N2", CultureInfo.GetCultureInfo("pt-BR")),
                   vbInformation)

            txt_cpf.Clear()
            txt_data.Clear()
            txt_cod.Clear()
            txt_nome.Clear()
            txt_qtde.Clear()
            txt_total.Text = "0,00"

            precoUnit = 0
            desconto_aplicado = 0
            totalGeral = 0

        Catch ex As Exception
            MsgBox("Erro ao salvar pedido: " & ex.Message, vbCritical)
        End Try

    End Sub

    ' ======================
    ' SOMA TOTAL DO PEDIDO
    ' ======================
    Private Sub AtualizarTotalGeral()

        Dim rs As Object = Nothing

        Try
            rs = CreateObject("ADODB.Recordset")

            sql = "SELECT SUM(valor_total) FROM pedidos WHERE cpf_cliente='" & txt_cpf.Text &
                  "' AND [data] = #" & Date.Parse(txt_data.Text).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture) & "#"

            rs.Open(sql, db, 3, 1)

            If Not IsDBNull(rs.Fields(0).Value) Then
                totalGeral = CDbl(rs.Fields(0).Value)
            Else
                totalGeral = 0
            End If

        Catch ex As Exception
            Throw

        Finally
            If rs IsNot Nothing AndAlso rs.State = 1 Then rs.Close()
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
End Class
