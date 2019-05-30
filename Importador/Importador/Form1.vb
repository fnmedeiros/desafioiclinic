Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class Form1
    Private Sub btnOpenCsv_Click(sender As Object, e As EventArgs) Handles btnOpenCsv.Click
        Dim vnValorTotal As Decimal
        Dim vnDesconto As Decimal
        Dim vnValorComDesconto As Decimal
        Dim vsTelefone As String



        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Csv File|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor

                Dim lines As List(Of String) = File.ReadAllLines(ofd.FileName).ToList()
                Dim list As List(Of Pessoa) = New List(Of Pessoa)
                For i As Integer = 1 To lines.Count - 1
                    Dim data As String() = lines(i).Split(";")

                    vnValorTotal = Decimal.Parse(data(4).Replace(".", ","))
                    vnDesconto = Decimal.Parse(data(5).Replace(".", ",")) / 100
                    vnValorComDesconto = vnValorTotal * vnDesconto

                    vsTelefone = "+55" + data(3).Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
                    list.Add(New Pessoa() With {
                        .Id = data(0),
                        .Nome = data(1),
                        .Email = data(2),
                        .Telefone = vsTelefone,
                        .Valor_total = vnValorTotal,
                        .Valor_com_desconto = Math.Round(vnValorComDesconto, 2)
                    })
                Next
                PessoaBindingSource.DataSource = list
                Cursor = Cursors.Default
            End If
        End Using
    End Sub

    Private Sub btnOpenXml_Click(sender As Object, e As EventArgs) Handles btnOpenXml.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Xml File|*.xml"}
            If ofd.ShowDialog() = DialogResult.OK Then

                Cursor = Cursors.WaitCursor


                Dim xmlDoc As New Xml.XmlDocument
                Dim vnValorTotal As Decimal
                Dim vnDesconto As Decimal
                Dim vnValorComDesconto As Decimal
                Dim vsTelefone As String
                Dim vsId As String
                Dim vsNome As String
                Dim vsEmail As String

                Dim list As List(Of Pessoa) = New List(Of Pessoa)

                xmlDoc.Load(ofd.FileName)

                Dim node As XmlNode = xmlDoc.SelectSingleNode("//records")

                If node IsNot Nothing Then
                    For x As Integer = 0 To node.ChildNodes.Count - 1

                        With node.ChildNodes.Item(x)
                            vnValorTotal = Decimal.Parse(.ChildNodes(4).InnerText.ToString.Replace(".", ","))
                            vnDesconto = 0
                            vnValorComDesconto = 0
                            vsTelefone = "+55" + .ChildNodes(3).InnerText.ToString.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
                            vsId = .ChildNodes(0).InnerText.ToString
                            vsNome = .ChildNodes(1).InnerText.ToString
                            vsEmail = .ChildNodes(2).InnerText.ToString

                            list.Add(New Pessoa() With {
                                .Id = vsId,
                                .Nome = vsNome,
                                .Email = vsEmail,
                                .Telefone = vsTelefone,
                                .Valor_total = Math.Round(vnValorTotal, 2),
                                .Valor_com_desconto = Math.Round(vnValorComDesconto, 2)
                            })
                        End With

                    Next
                    PessoaBindingSource.DataSource = list
                End If

                Cursor = Cursors.Default
            End If
        End Using
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim id As Int16
        Dim nome As String
        Dim email As String
        Dim telefone As String
        Dim vlr_total As Decimal
        Dim vlr_com_desconto As Decimal
        Dim existeRegistro As Boolean = False

        Cursor = Cursors.WaitCursor

        For Each linha As DataGridViewRow In tblRegistros.Rows
            id = linha.Cells(0).Value
            nome = linha.Cells(1).Value
            email = linha.Cells(2).Value
            telefone = linha.Cells(3).Value
            vlr_total = linha.Cells(4).Value
            vlr_com_desconto = linha.Cells(5).Value

            Dim query As String = "INSERT INTO `usuarios`(`id`, `nome`, `email`, `telefone`, `valor_total`, `valor_com_desconto`) VALUES ('" & id & "','" & nome & "','" & email & "','" & telefone & "','" & vlr_total & "','" & vlr_com_desconto & "')"
            queryHolder(query)
            existeRegistro = True
        Next

        Cursor = Cursors.Default

        If existeRegistro = True Then
            MsgBox("Registros importados com sucesso!", MsgBoxStyle.OkOnly, "Atenção")
            tblRegistros.Rows.Clear()
        Else
            MsgBox("Não existe registro para importar na tabela, verifique!", MsgBoxStyle.Critical & MsgBoxStyle.OkOnly, "Atenção")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Check_Server()
    End Sub
End Class
