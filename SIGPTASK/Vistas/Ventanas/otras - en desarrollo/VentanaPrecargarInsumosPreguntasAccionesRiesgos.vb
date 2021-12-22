Public Class VentanaPrecargarInsumosPreguntasAccionesRiesgos

    Private Sub VentanaPrecargarInsumosPreguntasAccionesRiesgos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idiomaMesajes()
        Me.CenterToScreen()
    End Sub

    '////
    Private Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            btnAgregarAcciones.Text = "Add contigencies"
            btnAgregarPreguntas.Text = "Add questions"
            btnAgregarObjetos.Text = "Add objects"
            btnAgregarRiesgos.Text = "Add risk's"
        End If
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
        Dim cargPre As New VentanaCargarRiesgo
        cargPre.Show()
    End Sub
End Class