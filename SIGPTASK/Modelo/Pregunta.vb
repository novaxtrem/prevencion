Public Class Pregunta
    Private _pregunta_id As String
    Private _pregunta As String
    Private _riesgoMuerte As String

    Public Property preguntaID As String
        Get
            Return _pregunta_id
        End Get
        Set(ByVal value As String)
            _pregunta_id = value
        End Set
    End Property

    Public Property pregunta As String
        Get
            Return _pregunta
        End Get
        Set(ByVal value As String)
            _pregunta = value
        End Set
    End Property

    Public Property riesgoMuerte As String
        Get
            Return _riesgoMuerte
        End Get
        Set(ByVal value As String)
            _riesgoMuerte = value
        End Set
    End Property
End Class
