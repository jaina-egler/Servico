Public Class MeuServico


    Dim tmp As Timers.Timer

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Adicione código aqui para iniciar seu serviço. Este método deve ajustar
        ' o que é necessário para que seu serviço possa executar seu trabalho.
        tmp = New Timers.Timer()
        tmp.Interval = 1000 'Intervalo de tempo do timer, acontece a cada 1 segundo
        AddHandler tmp.Elapsed, AddressOf Teste
        tmp.Enabled = True
        FileIO.EscrevaNoArquivo("Comecei... " + vbNewLine)
    End Sub

    Protected Overrides Sub OnStop()
        ' Adicione código aqui para realizar qualquer limpeza necessária para parar seu serviço.
        tmp.Enabled = False
        FileIO.EscrevaNoArquivo("Parou " + vbNewLine)
    End Sub
    Private Sub Teste(obj As Object, e As EventArgs)
        FileIO.EscrevaNoArquivo("Foi 1 segundo " + vbNewLine)
    End Sub
End Class
