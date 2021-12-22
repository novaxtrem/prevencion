Public Class Accion
    Protected _accion_id As String
    Protected _accion As String

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

End Class
