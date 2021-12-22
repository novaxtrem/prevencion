Public Class PanelRiesgo

    Private Sub PanelRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblIdRiesgo.Visible = False
        lblRiesgoNom.Visible = False
        lblRutaIcono.Visible = False
    End Sub

    Private Sub pictureRiesgo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureRiesgo.MouseEnter
        '////HACEMOS TRAMPA CON ESTAS VARIABLES....PERO FUNCIONA Y ES SENCILLO!!!
        ID_Riesgo = lblIdRiesgo.Text
        NOMBRE_Riesgo = lblRiesgoNom.Text
        RUTA_icono = lblRutaIcono.Text
        esImagen = True
    End Sub




    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        If Me.ClientRectangle.Contains(Me.PointToClient(Control.MousePosition)) Then
            Return
        Else
            MyBase.OnMouseLeave(e)
            ID_Riesgo = ""
            NOMBRE_Riesgo = ""
            RUTA_icono = ""
            esImagen = False
        End If
    End Sub
End Class