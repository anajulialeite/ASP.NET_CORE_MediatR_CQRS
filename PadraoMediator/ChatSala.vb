''' <summary>
''' A classe concreta  'ConcreteMediator' 
''' </summary>
Class Chatsala
    Inherits AbstractChatSala

    Private _participantes As New Dictionary(Of String, Participante)()

    Public Overrides Sub Registro(ByVal _participante As Participante)
        If Not _participantes.ContainsValue(_participante) Then
            _participantes(_participante.Nome) = _participante
        End If

        _participante.Chatsala = Me
    End Sub

    Public Overrides Sub Enviar(ByVal [de] As String, ByVal [para] As String, ByVal mensagem As String)
        Dim _participante As Participante = _participantes([para])
        If _participante IsNot Nothing Then
            _participante.Receber([de], mensagem)
        End If
    End Sub
End Class