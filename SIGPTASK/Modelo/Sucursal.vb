Public Class Sucursal
    Protected _sucursal_id As Integer
    Protected _empresaRut As String
    Protected _empresaNombre As String
    Protected _sucursalNombre As String
    Protected _sucursalDireccion As String
    Protected _telefono As Integer
    Protected _sucursalEstado As String
    Protected _totalEmpleadosSucursal As Integer

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

    Public Property sucursalID As Integer
        Get
            Return _sucursal_id
        End Get
        Set(ByVal value As Integer)
            _sucursal_id = value
        End Set
    End Property

    

    Public Property empresaNombre As String
        Get
            Return _empresaNombre
        End Get
        Set(ByVal value As String)
            _empresaNombre = value
        End Set
    End Property


    Public Property sucursalNombre As String
        Get
            Return _sucursalNombre
        End Get
        Set(ByVal value As String)
            _sucursalNombre = value
        End Set
    End Property


    Public Property sucursalDireccion As String
        Get
            Return _sucursalDireccion
        End Get
        Set(ByVal value As String)
            _sucursalDireccion = value
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _telefono
        End Get
        Set(ByVal value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property estado As String
        Get
            Return _sucursalEstado
        End Get
        Set(ByVal value As String)
            _sucursalEstado = value
        End Set
    End Property

End Class
