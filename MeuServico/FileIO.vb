Public Class FileIO
    Public Shared Sub EscrevaNoArquivo(strEscrever As String)
        Dim stream As IO.StreamWriter = Nothing 'Transfere
        Try
            stream = New IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\arquivo.txt", True)
            stream.Write(strEscrever) 'Escreve o texto passado
            stream.Flush() 'Salva as mudanças
            stream.Close() 'Fecha a stream
        Catch ex As Exception

        End Try
    End Sub
End Class
