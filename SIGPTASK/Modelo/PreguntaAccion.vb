Public Class PreguntaAccion
    Protected _pregunta_id As String
    Protected _pregunta As String
    Protected _riesgoMuerte As String
    Protected _accion_id As String
    Protected _accion As String
    Protected _considerar As String
    Protected _valorConsecuencia As Double
    Protected _valorExposicion As Double
    Protected _valorProvabilidad As Double
    Protected _respuesta As String
    Protected _cuestionario_ID As String
    Protected _personasExpuestas As String

    Public Property personasExpustas As String
        Get
            Return _personasExpuestas
        End Get
        Set(ByVal value As String)
            _personasExpuestas = value
        End Set
    End Property

    Public Property cuestionario_ID As String
        Get
            Return _cuestionario_ID
        End Get
        Set(ByVal value As String)
            _cuestionario_ID = value
        End Set
    End Property



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

    Public Property AccionID As String
        Get
            Return _accion_id
        End Get
        Set(ByVal value As String)
            _accion_id = value
        End Set
    End Property

    Public Property Accion As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
        End Set
    End Property


    Public Property Considerar As String
        Get
            Return _considerar
        End Get
        Set(ByVal value As String)
            _considerar = value
        End Set
    End Property


    Public Property valorExposicion As Double
        Get
            Return _valorExposicion
        End Get
        Set(ByVal value As Double)
            _valorExposicion = value
        End Set
    End Property

    Public Property valorProvabilidad As Double
        Get
            Return _valorProvabilidad
        End Get
        Set(ByVal value As Double)
            _valorProvabilidad = value
        End Set
    End Property

    Public Property valorConsecuencia As Double
        Get
            Return _valorConsecuencia
        End Get
        Set(ByVal value As Double)
            _valorConsecuencia = value
        End Set
    End Property

    Public Property respuesta As String
        Get
            Return _respuesta
        End Get
        Set(ByVal value As String)
            _respuesta = value
        End Set
    End Property

End Class
