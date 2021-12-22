Public Class Riesgo

    Protected _riesgo_id As String
    Protected _nombreRiesgo As String
    Protected _iconoRiesgo As String

    Public Property riesgoID As String
        Get
            Return _riesgo_id
        End Get
        Set(ByVal value As String)
            _riesgo_id = value
        End Set
    End Property

    Public Property nombreRiesgo As String
        Get
            Return _nombreRiesgo
        End Get
        Set(ByVal value As String)
            _nombreRiesgo = value
        End Set
    End Property

    Public Property iconoRiesgo As String
        Get
            Return _iconoRiesgo
        End Get
        Set(ByVal value As String)
            _iconoRiesgo = value
        End Set
    End Property
End Class
