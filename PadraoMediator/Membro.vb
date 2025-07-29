''' <summary>
''' A classe 'ConcreteColleague' 
''' </summary>
Class Membro
    Inherits Participante

    ' Construtor
    Public Sub New(ByVal nome As String)
        MyBase.New(nome)
    End Sub
    'sobrescreve o método Receber
    Public Overrides Sub Receber(ByVal [de] As String, ByVal mensagem As String)
        Console.Write("para Membro : ")
        MyBase.Receber([de], mensagem)
    End Sub
End Class
