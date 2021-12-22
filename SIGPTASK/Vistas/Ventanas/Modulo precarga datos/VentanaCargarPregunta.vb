Public Class VentanaCargarPregunta

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub VentanaCargoPregunta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tbPregunta.MaxLength = 180
        lblContadorCaracteres.Text = "0"
        idiomaMesajes()
    End Sub

    Private Sub tbPregunta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPregunta.TextChanged
        lblContadorCaracteres.Text = tbPregunta.TextLength & "/180"
    End Sub
    Dim PreguntaAgregadaConExito As String = ""
    Dim laPreguntaDebeTenerContenido As String = ""
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim estado As Boolean = False
        If tbPregunta.TextLength > 0 Then
            Dim pregunta As New Pregunta
            pregunta.pregunta = tbPregunta.Text
            If ckbRiesgoMuerte.Checked Then
                pregunta.riesgoMuerte = "S"
            Else
                pregunta.riesgoMuerte = "N"
            End If
            estado = AgregoPreguntaNueva(pregunta, conn, estado)
            If estado = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show(PreguntaAgregadaConExito)
                tbPregunta.Text = ""
                lblContadorCaracteres.Refresh()
                ckbRiesgoMuerte.Checked = False
            End If
        Else
            MessageBox.Show(laPreguntaDebeTenerContenido)

        End If
    End Sub

    '// IDIOMA
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblAgregarPregunta.Text = "Insert question"
            ckbRiesgoMuerte.Text = "Death Risk"
            btnCancelar.Text = "Cancel"
            btnAceptar.Text = "Acept"
        End If
        PreguntaAgregadaConExito = lenguaje.PreguntaAgregadaConExito(PreguntaAgregadaConExito)
        laPreguntaDebeTenerContenido = lenguaje.laPreguntaDebeTenerContenido(laPreguntaDebeTenerContenido)

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
    '///CIERRO LA WINDOW
    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub


End Class