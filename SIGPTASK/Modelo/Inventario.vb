Public Class Inventario
    Protected _inventario_id As Integer
    Protected _sucursal_id As Integer
    Protected _nomreInvetario As String
    Protected _fecha As String
    Protected _fila_id As Integer
    Protected _objeto_id As Integer
    Protected _existencias As Integer
    Protected _cantidadRequerida As Integer
    Protected _estado As String
    Protected _empleadoCedulda As String
    Protected _nota As String

    Public Property nota As String
        Get
            Return _nota
        End Get
        Set(ByVal value As String)
            _nota = value
        End Set
    End Property

    Public Property empleadoCedula As String
        Get
            Return _empleadoCedulda
        End Get
        Set(ByVal value As String)
            _empleadoCedulda = value
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

    Public Property nombreInvetario As String
        Get
            Return _nomreInvetario
        End Get
        Set(ByVal value As String)
            _nomreInvetario = value
        End Set
    End Property
    Public Property sucursal_id As Integer
        Get
            Return _sucursal_id
        End Get
        Set(ByVal value As Integer)
            _sucursal_id = value
        End Set
    End Property

    Public Property filaID As Integer
        Get
            Return _fila_id
        End Get
        Set(ByVal value As Integer)
            _fila_id = value
        End Set
    End Property

    Public Property InventarioID As Integer
        Get
            Return _inventario_id
        End Get
        Set(ByVal value As Integer)
            _inventario_id = value
        End Set
    End Property

    Public Property objetoID As Integer
        Get
            Return _objeto_id
        End Get
        Set(ByVal value As Integer)
            _objeto_id = value
        End Set
    End Property

    Public Property existencias As Integer
        Get
            Return _existencias
        End Get
        Set(ByVal value As Integer)
            _existencias = value
        End Set
    End Property

    Public Property cantidadRequerida As Integer
        Get
            Return _cantidadRequerida
        End Get
        Set(ByVal value As Integer)
            _cantidadRequerida = value
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
