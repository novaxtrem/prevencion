Public Class Mapa
    Protected _mapa_id As Integer
    Protected _sucursa_id As Integer
    Protected _mapa_riesgo_nombre As String
    Protected _empleado_cedula As Integer
    Protected _fecha As String
    Protected _plano_ruta_archivo As String
    Protected _estado As String
    Protected _controladoPor As String

    Public Property controladoPor As String
        Get
            Return _controladoPor
        End Get
        Set(ByVal value As String)
            _controladoPor = value
        End Set
    End Property
    Public Property mapaID As Integer
        Get
            Return _mapa_id
        End Get
        Set(ByVal value As Integer)
            _mapa_id = value
        End Set
    End Property

    Public Property sucursalID As Integer
        Get
            Return _sucursa_id
        End Get
        Set(ByVal value As Integer)
            _sucursa_id = value
        End Set
    End Property

    Public Property mapaRiesgoNombre As String
        Get
            Return _mapa_riesgo_nombre
        End Get
        Set(ByVal value As String)
            _mapa_riesgo_nombre = value
        End Set
    End Property

    Public Property empleadoCedula As Integer
        Get
            Return _empleado_cedula
        End Get
        Set(ByVal value As Integer)
            _empleado_cedula = value
        End Set
    End Property

    Public Property fecha As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property planoRutaArchivo As String
        Get
            Return _plano_ruta_archivo
        End Get
        Set(ByVal value As String)
            _plano_ruta_archivo = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property
End Class
