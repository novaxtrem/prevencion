Public Class objeto
    Protected _objeto_id As String
    Protected _objeto As String

    Public Property objetoID As String
        Get
            Return _objeto_id
        End Get
        Set(ByVal value As String)
            _objeto_id = value
        End Set
    End Property

    Public Property objeto As String
        Get
            Return _objeto
        End Get
        Set(ByVal value As String)
            _objeto = value
        End Set
    End Property

End Class
