''' <summary>
'''  A classe 'AbstractColleague'
''' </summary>
MustInherit Class Participante

    Private _chatsala As Chatsala
    Private _nome As String

    ' Construtor
    Public Sub New(ByVal nome As String)
        Me._nome = nome
    End Sub

    ' Pega o nome do participante
    Public ReadOnly Property Nome() As String
        Get
            Return _nome
        End Get
    End Property

    ' Pega a sala de chat
    Public Property Chatsala() As Chatsala
        Get
            Return _chatsala
        End Get
        Set(ByVal value As Chatsala)
            _chatsala = value
        End Set
    End Property

    ' Envia mensagem para um dado participante
    Public Sub Enviar(ByVal [para] As String, ByVal mensagem As String)
        _chatsala.Enviar(_nome, [para], mensagem)
    End Sub

    ' Recebe mensagem de um participante
    Public Overridable Sub Receber(ByVal [de] As String, ByVal mensagem As String)
        Console.WriteLine("{0} para {1}: '{2}'", [de], Nome, mensagem)
    End Sub

End Class
