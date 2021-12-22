Public Class PanelRiesgoUbicacion

    Private Sub PanelRiesgoAgregadoEnUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '////
        DateFechaResuelto.Format = DateTimePickerFormat.Custom
        DateFechaResuelto.CustomFormat = "dd/MM/yyyy"
        DateFechaResuelto.MinDate = Today 'jaja contenplad mi astucia
        '////
        tbDescripcionRiesgo.MaxLength = 180
        tbSolucionRiesgo.MaxLength = 180
        tbNombreUbicacion.MaxLength = 60
        lblContadorCaracteresDescripcion.Text = "0/180"
        lblContadorCaracteresSolucion.Text = "0/180"
        '///

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbDescripcionRiesgo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDescripcionRiesgo.TextChanged
        lblContadorCaracteresDescripcion.Text = tbDescripcionRiesgo.TextLength & "/180"
    End Sub

    Private Sub tbSolucionRiesgo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSolucionRiesgo.TextChanged
        lblContadorCaracteresSolucion.Text = tbSolucionRiesgo.TextLength & "/180"
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        If Me.ClientRectangle.Contains(Me.PointToClient(Control.MousePosition)) Then
            Return
        Else
            MyBase.OnMouseLeave(e)
            pictureRiesgoElegido.Width = 48
            pictureRiesgoElegido.Height = 48
            Me.Width = 48
            Me.Height = 48
        End If
    End Sub

    Private Sub pictureRiesgoElegido_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSolucionRiesgo.MouseEnter, tbNombreUbicacion.MouseEnter, tbDescripcionRiesgo.MouseEnter, pictureRiesgoElegido.MouseEnter, MyBase.MouseEnter, lblSolucion.MouseEnter, lblResueltoPara.MouseEnter, lblNombreUbicacion.MouseEnter, lblIDRiesgo.MouseEnter, lblDescripcion.MouseEnter, lblcoordenadaY.MouseEnter, lblcoordenadaX.MouseEnter, lblContadorCaracteresSolucion.MouseEnter, lblContadorCaracteresDescripcion.MouseEnter, DateFechaResuelto.MouseEnter, ckbCritico.MouseEnter, btnBorrar.MouseEnter
        Me.Height = 381
        Me.Width = 321
        Me.pictureRiesgoElegido.Width = 82
        Me.pictureRiesgoElegido.Height = 85
        Me.BringToFront()
    End Sub

    
    Private Sub pictureRiesgoElegido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureRiesgoElegido.Click
        Me.Dispose()
    End Sub

End Class