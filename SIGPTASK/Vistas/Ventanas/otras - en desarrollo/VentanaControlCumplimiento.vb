Public Class VentanaControlCumplimiento

    Dim controlRealizadosatisfactoriamente As String = ""

    Dim algofallo As String = ""


    Private Sub VentanaControlCumplimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tipoUsuario.Equals("PREVENCIONISTA") Then
            btnValidarControl.Enabled = True
        Else
            btnValidarControl.Enabled = False
        End If
        Me.CenterToScreen()
        lblMatriculaTecnicoConectado.Text = matricula.ToString
        idiomaMesajes()
    End Sub
    '///////////BOLUDECES GRAFICAS
    '//CERRAR VENTANA
    Protected Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub
    '//MINIMIZAR
    Protected Sub pictureMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '//SOMBRA
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    '//MUEVO LA WINDOW
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '//MUEVO LA WINDOW FIN

    Private Sub btnValidarControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidarControl.Click
        Dim actualizado As Boolean = False
        Dim actualizoUbicaciones As Boolean = False

        actualizado = actualizoEstadoDelMapadeRiesgo(lblMatriculaTecnicoConectado.Text, lblIDMapaRiesgo.Text, actualizado, conn)


        For Each panelConRiesgo As PanelControlCumplimiento In panelCentral.Controls
            Dim riesgo As New RiesgoUbicacion

            If panelConRiesgo.radioButoSI.Checked Then
                riesgo.cumplidoEnfecha = "S"
            Else
                riesgo.cumplidoEnfecha = "N"
            End If
            riesgo.ubicacionID = panelConRiesgo.lblIncidenciaID.Text
            actualizoUbicaciones = actualizoCumplimiento(lblIDMapaRiesgo.Text, riesgo, actualizoUbicaciones, conn)
        Next
        If actualizado = True AndAlso actualizoUbicaciones = True Then
            MessageBox.Show(controlRealizadosatisfactoriamente)
        Else
            MessageBox.Show(algofallo)
        End If
    End Sub

    '// IDIOMA
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblNombreMapa.Text = "Name of Map"
            lblNombreDeLaSucursal.Text = "Subsidiary name"
            lblMatricula.Text = "Register"
            lblFecha.Text = "Date"
            btnVerMapa.Text = "Show map"
            btnValidarControl.Text = "Validate Inspection"
        End If
        controlRealizadosatisfactoriamente = lenguaje.controlRealizadosatisfactoriamente(controlRealizadosatisfactoriamente)
        algofallo = lenguaje.algofallo(algofallo)
    End Sub

End Class