Public Class PanelIncidenciaDetalle

    Private Sub PanelDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        Me.CenterToParent()
        idiomaMesajes()
    End Sub

    Sub idiomaMesajes()
        '///
        If idiomaSeleccionado.Equals("ING") Then
            lblPregunta.Text = "Question"
            lblAccion.Text = "Action"
            lblRespustaObtenida.Text = "Asnwer obtained"
            lblRiesgoMuerte.Text = "Death Risk"
            lblNivelProbabilidad.Text = "Probability"
            lblNivelExposicion.Text = "Exposition"
            lblNivelConsecuencia.Text = "Consequence"
        End If
        '///
     

    End Sub
End Class