Module Module1

    Sub Main()
        'Cria uma sala de chat (chatsala)
        Dim chatsala As New Chatsala()

        ' cria participantes e faz o registro
        Dim Macoratti As Participante = New Membro("Macoratti")
        Dim Miriam As Participante = New Membro("Miriam")
        Dim Jefferson As Participante = New Membro("Jefferson")
        Dim Janice As Participante = New Membro("Janice")
        Dim Jessica As Participante = New NaoMembro("Jessica")

        'registra os participantes
        chatsala.Registro(Macoratti)
        chatsala.Registro(Miriam)
        chatsala.Registro(Jefferson)
        chatsala.Registro(Janice)
        chatsala.Registro(Jessica)

        ' Inicia o chat 
        Jessica.Enviar("Janice", "Olá, Janice!")
        Miriam.Enviar("Jefferson", "Como vai você")
        Jefferson.Enviar("Macoratti", "Tudo bem")
        Miriam.Enviar("Janice", "Como você esta ?")
        Janice.Enviar("Jessica", "Tudo tranquilo...")

        ' aguarda...
        Console.ReadKey()
    End Sub

End Module