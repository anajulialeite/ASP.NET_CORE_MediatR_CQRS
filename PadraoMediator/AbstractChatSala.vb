''' <summary>
''' A classe abstrata 'Mediator'
''' </summary>
MustInherit Class AbstractChatSala
    Public MustOverride Sub Registro(ByVal participante As Participante)
    Public MustOverride Sub Enviar(ByVal [de] As String, ByVal [para] As String, ByVal message As String)
End Class
