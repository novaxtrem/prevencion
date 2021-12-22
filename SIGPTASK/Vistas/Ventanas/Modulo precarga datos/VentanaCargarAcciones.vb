Public Class VentanaCargoAccion

    Dim accionAgregadaConexito As String = ""
    Dim laAccionRequiereContenido As String = ""


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub VentanaCargoAccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tbAccion.MaxLength = 180
        lblContadorCaracteres.Text = "0/180"
        idiomaMesajes()
    End Sub

    Private Sub tbAccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAccion.TextChanged
        lblContadorCaracteres.Text = tbAccion.TextLength & "/180"
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim estado As Boolean = False
        If tbAccion.TextLength > 0 Then
            Dim Accion As New Accion
            Accion.Accion = tbAccion.Text
            estado = AgregoAccionNueva(Accion, conn, estado)
            If estado = True Then
                MessageBox.Show(accionAgregadaConexito)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                tbAccion.Text = ""
                lblContadorCaracteres.Refresh()
            End If
        Else
            MessageBox.Show(laAccionRequiereContenido)
        End If
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
    '/////
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblAgregarAccion.Text = "Add Action"
            btnAceptar.Text = "Acept"
            btnCancelar.Text = "Cancel"
        End If

        accionAgregadaConexito = lenguaje.accionAgregadaConexito(accionAgregadaConexito)
        laAccionRequiereContenido = lenguaje.laAccionRequiereContenido(laAccionRequiereContenido)
    End Sub
End Class
