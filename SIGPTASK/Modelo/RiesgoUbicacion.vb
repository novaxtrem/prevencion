Public Class RiesgoUbicacion
    Inherits Mapa
    Protected _ubicacion_id As Integer
    'hereda mapa_id
    Protected _ubicacion_nombre As String
    Protected _critco As String
    Protected _riesgo_id As Integer
    Protected _descripcion As String
    Protected _solucion As String
    Protected _plazo As String
    Protected _coordenada_x As String
    Protected _coordenada_y As String
    Protected _riesgoIcono As String
    Protected _cumplidoEnFecha As String

    Public Property cumplidoEnfecha As String
        Get
            Return _cumplidoEnFecha
        End Get
        Set(ByVal value As String)
            _cumplidoEnFecha = value
        End Set
    End Property

    Public Property riesgoIcono As String
        Get
            Return _riesgoIcono
        End Get
        Set(ByVal value As String)
            _riesgoIcono = value
        End Set
    End Property

    Public Property ubicacionID As Integer
        Get
            Return _ubicacion_id
        End Get
        Set(ByVal value As Integer)
            _ubicacion_id = value
        End Set
    End Property
    'hereda mapa id

    Public Property ubicacionNombre As String
        Get
            Return _ubicacion_nombre
        End Get
        Set(ByVal value As String)
            _ubicacion_nombre = value
        End Set
    End Property

    Public Property critico As String
        Get
            Return _critco
        End Get
        Set(ByVal value As String)
            _critco = value
        End Set
    End Property

    Public Property riesgoID As String
        Get
            Return _riesgo_id
        End Get
        Set(ByVal value As String)
            _riesgo_id = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property solucion As String
        Get
            Return _solucion
        End Get
        Set(ByVal value As String)
            _solucion = value
        End Set
    End Property

    Public Property plazo As String
        Get
            Return _plazo
        End Get
        Set(ByVal value As String)
            _plazo = value
        End Set
    End Property

    Public Property coordendaX As String
        Get
            Return _coordenada_x
        End Get
        Set(ByVal value As String)
            _coordenada_x = value
        End Set
    End Property

    Public Property coordenadaY As String
        Get
            Return _coordenada_y
        End Get
        Set(ByVal value As String)
            _coordenada_y = value
        End Set
    End Property
End Class
