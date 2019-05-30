Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic

Module Database
    Public myconn As New MySqlConnection("Server=localhost; User Id=root; Password=; Database=integrador")

    Public Sub Check_Server()
        Try
            If myconn.State = ConnectionState.Closed Then
                myconn.Open()
            End If
        Catch ex As Exception
            MsgBox("Não foi possivel se conectar com base dados.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Falha ao Conectar")
            Application.Exit()
        End Try
    End Sub

    Public Sub queryHolder(ByRef SQLStatement As String)
        Dim cmd As MySqlCommand = New MySqlCommand
        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = myconn
            .ExecuteNonQuery()
        End With
    End Sub

End Module
