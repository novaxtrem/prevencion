Public Class CueSucEmp
    Inherits Cuestionario
    Protected _empresaRut As String
    Protected _sucursalNombre As String
    Protected _empleadoNombre As String
    Protected _matricula As String
    Protected _totalEmpleadosSucursal As Integer
    Protected _pregunta As String
    Protected _accion As String
    Protected _nivelConsecuencia As Double
    Protected _nivelExposicion As Double
    Protected _nivelProbabilidad As Double
    Protected _riesgoMuerte As String
    Protected _respuesta As String
    Protected _expuestos As Integer

    Public Property sucursalNombre As String
        Get
            Return _sucursalNombre
        End Get
        Set(ByVal value As String)
            _sucursalNombre = value
        End Set
    End Property
    Public Property empleadoNombre As String
        Get
            Return _empleadoNombre
        End Get
        Set(ByVal value As String)
            _empleadoNombre = value
        End Set
    End Property
    Public Property matricula As String
        Get
            Return _matricula
        End Get
        Set(ByVal value As String)
            _matricula = value
        End Set
    End Property

    Public Property empresaRUT As String
        Get
            Return _empresaRut
        End Get
        Set(ByVal value As String)
            _empresaRut = value
        End Set
    End Property

    Public Property totalEmpleadosSucursal As Integer
        Get
            Return _totalEmpleadosSucursal
        End Get
        Set(ByVal value As Integer)
            _totalEmpleadosSucursal = value
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

    Public Property accion As String
        Get
            Return _accion
        End Get
        Set(ByVal value As String)
            _accion = value
        End Set
    End Property

    Public Property nivelConsecuencia As Double
        Get
            Return _nivelConsecuencia
        End Get
        Set(ByVal value As Double)
            _nivelConsecuencia = value
        End Set
    End Property

    Public Property nivelExposicion As Double
        Get
            Return _nivelExposicion
        End Get
        Set(ByVal value As Double)
            _nivelExposicion = value
        End Set
    End Property

    Public Property nivelProbabilidad As Double

        Get
            Return _nivelProbabilidad
        End Get
        Set(ByVal value As Double)
            _nivelProbabilidad = value
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

    Public Property respuesta As String
        Get
            Return _respuesta
        End Get
        Set(ByVal value As String)
            _respuesta = value
        End Set
    End Property




    Public Property expuestos As Integer
        Get
            Return _expuestos
        End Get
        Set(ByVal value As Integer)
            _expuestos = value
        End Set
    End Property
End Class
