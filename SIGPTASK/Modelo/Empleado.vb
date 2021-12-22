Public Class Empleado
    Protected _empleadoID As Integer
    Protected _empleadoCedula As Integer
    Protected _empleadoNombre As String
    Protected _empleadoUsername As String
    Protected _empleadoTipo As String
    Protected _matricula As String
    Protected _empleadoDireccion As String
    Protected _empleadoTelefono As Integer
    Protected _empleadoCelular As Integer
    Protected _empleadoEmail As String

    Public Property empleadoID As Integer
        Get
            Return _empleadoID
        End Get
        Set(ByVal value As Integer)
            _empleadoID = value
        End Set
    End Property
    Public Property empleadoCedula As Integer
        Get
            Return _empleadoCedula
        End Get
        Set(ByVal value As Integer)
            _empleadoCedula = value
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

    Public Property empleadoUsername As String
        Get
            Return _empleadoUsername
        End Get
        Set(ByVal value As String)
            _empleadoUsername = value
        End Set
    End Property

    Public Property empleadoTipo As String
        Get
            Return _empleadoTipo
        End Get
        Set(ByVal value As String)
            _empleadoTipo = value
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

    Public Property empleadoDireccion As String
        Get
            Return _empleadoDireccion
        End Get
        Set(ByVal value As String)
            _empleadoDireccion = value
        End Set
    End Property
    Public Property empleadoTelefono As Integer
        Get
            Return _empleadoTelefono
        End Get
        Set(ByVal value As Integer)
            _empleadoTelefono = value
        End Set
    End Property
    Public Property empleadoCelular As Integer
        Get
            Return _empleadoCelular
        End Get
        Set(ByVal value As Integer)
            _empleadoCelular = value
        End Set
    End Property

    Public Property empleadoEmail As String
        Get
            Return _empleadoEmail
        End Get
        Set(ByVal value As String)
            _empleadoEmail = value
        End Set
    End Property
End Class
