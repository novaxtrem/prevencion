Public Class VentanaMenuPricipal

    Private Sub VentanaMenuPricipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblUsuarioConectado.Text = cedulaUsuarioConectado
        lblMatricula.Text = matricula

        DoubleBuffered = True


        If idiomaSeleccionado.Equals("ING") Then
            btnAltaMApaCuestionarioInventario.Text = "Make Risk Maps, Questionary, Inventory"
            btnAltaPreguntasAccionesObjetosRiesgos.Text = "Add Questions, Aswers, Objects, Risks"
            '///
            btnAgregarPreguntas.Text = "Pre-load Questions"
            btnAgregarAcciones.Text = "Pre-load Actions"
            btnAgregarRiesgos.Text = "Pre-load Risk's"
            btnAgregarObjetos.Text = "Pre-load objetcs"
            '///
            btnGestionarSucursales.Text = "Admin Companies"
            btnReportes.Text = "Generate Reports"
            btnGestionUsuarios.Text = "Admin users"
        End If
    End Sub

    Private Sub btnCrearMapaRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaMApaCuestionarioInventario.Click
        Dim mapaRiesgo As New VentanaMapaRiesgo
        Dim ventanaNuevoMapaRiesgo As New VentanaCuestiInvenMapa
        panelPortaBotones.Hide()
        ventanaNuevoMapaRiesgo.ShowDialog()
    End Sub


    Private Sub btnGestionUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionUsuarios.Click
        Dim ventanaGestionUSuarios As New VentanaGestionUsuarios
        panelPortaBotones.Hide()
        ventanaGestionUSuarios.Show()
    End Sub



    Private Sub btnReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportes.Click
        Dim vSeleccionarTipoReporte As New VentanaSeleccionReportesYControl
        panelPortaBotones.Hide()
        vSeleccionarTipoReporte.panelControloYInspecciono.Hide()
        vSeleccionarTipoReporte.lblMatriculaTecnicoConectado.Text = Me.lblUsuarioConectado.Text
        vSeleccionarTipoReporte.lblSELECTOR.Text = "REPORTES"
        vSeleccionarTipoReporte.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prueba As New VentanaMapaRiesgo
        ' prueba.Show()
        Dim dsad As New VentanaInventario
        dsad.Show()
    End Sub


    '///////////BOLUDECES GRAFICAS
    '//CERRAR VENTANA
    Protected Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        conn.Close()
        Application.Exit()
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
    Private Sub btnGestionarSucursales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionarSucursales.Click

        Dim ventanaGestionSucursales As New VentanaGestionSucursales
        panelPortaBotones.Hide()
        ventanaGestionSucursales.lblUsuarioCOnectado.Text = Me.lblUsuarioConectado.Text
        ventanaGestionSucursales.ShowDialog()

    End Sub

    Private Sub btnGestionarPreguntasAccionesObjetosRiesgos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaPreguntasAccionesObjetosRiesgos.Click
        If panelPortaBotones.Visible = True Then
            panelPortaBotones.Hide()
        Else
            panelPortaBotones.Show()
        End If
        'Dim ventanaPrecarga As New VentanaPrecargarInsumosPreguntasAccionesRiesgos
        'ventanaPrecarga.Show()
    End Sub


    '////
    Private Sub btnAgregarObjetos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObjetos.Click
        Dim cargoObj As New VentanaCargoObjeto
        cargoObj.Show()
    End Sub

    Private Sub btnAgregarAcciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAcciones.Click
        Dim cargoAcc As New VentanaCargoAccion
        cargoAcc.Show()
    End Sub

    Private Sub btnAgregarRiesgos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRiesgos.Click
        Dim cargRies As New VentanaCargarRiesgo
        cargRies.Show()
    End Sub

    Private Sub btnAgregarPreguntas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPreguntas.Click
        Dim cargPre As New VentanaCargarPregunta
        cargPre.Show()
    End Sub
    '////

    Private Sub btnControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControl.Click
        Dim controloInspecciones As New VentanaSeleccionReportesYControl
        controloInspecciones.panelReportes.Hide()
        controloInspecciones.panelControloYInspecciono.Show()
        controloInspecciones.panelControloYInspecciono.BringToFront()
        controloInspecciones.lblSELECTOR.Text = "CONTROL"
        controloInspecciones.BringToFront()
        controloInspecciones.lblMatriculaTecnicoConectado.Text = Me.lblUsuarioConectado.Text
        controloInspecciones.Show()
    End Sub
End Class