Public Class Cuestionario
    Protected _cuestionario_id As Integer
    Protected _sucursal_id As Integer
    Protected _empleado_cedula As Integer
    Protected _cuestionario_nombre As String
    Protected _cuestionario_fecha As String
    Protected _cuestionario_estado As String
    Protected _cuestionario_nota As String

    Public Property cuestionarioNota As String
        Get
            Return _cuestionario_nota
        End Get
        Set(ByVal value As String)
            _cuestionario_nota = value
        End Set
    End Property

    Public Property cuestionarioID As Integer
        Get
            Return _cuestionario_id
        End Get
        Set(ByVal value As Integer)
            _cuestionario_id = value
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

    Public Property empleadoCedula As Integer
        Get
            Return _empleado_cedula
        End Get
        Set(ByVal value As Integer)
            _empleado_cedula = value
        End Set
    End Property

    Public Property cuestionarioNombre As String
        Get
            Return _cuestionario_nombre
        End Get
        Set(ByVal value As String)
            _cuestionario_nombre = value
        End Set
    End Property
    Public Property cuestionarioFecha As String
        Get
            Return _cuestionario_fecha
        End Get
        Set(ByVal value As String)
            _cuestionario_fecha = value
        End Set
    End Property

    Public Property cuestionarioEstado As String
        Get
            Return _cuestionario_estado
        End Get
        Set(ByVal value As String)
            _cuestionario_estado = value
        End Set
    End Property
End Class
