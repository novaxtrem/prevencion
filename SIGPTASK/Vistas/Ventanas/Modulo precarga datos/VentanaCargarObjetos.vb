Public Class VentanaCargoObjeto

    Dim objetoAgregadoConexito As String = ""
    Dim elObjetoDebeTenerContenido As String = ""
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim estado As Boolean = False
        If tbObjeto.TextLength > 0 Then
            Dim Objeto As New objeto
            Objeto.objeto = tbObjeto.Text
            estado = AgregoObjetoNuevo(Objeto, conn, estado)
            If estado = True Then
                MessageBox.Show(objetoAgregadoConexito)
                tbObjeto.Text = ""
                lblContadorCaracteres.Refresh()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            MessageBox.Show(elObjetoDebeTenerContenido)

        End If
    End Sub

    Private Sub VentanaCargoObjeto_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMesajes()
        tbObjeto.MaxLength = 180
        lblContadorCaracteres.Text = "0"
    End Sub

    Private Sub tbObjeto_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbObjeto.TextChanged
        lblContadorCaracteres.Text = tbObjeto.TextLength & "/180"
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

    '// IDIOMA
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblAgregarObjeto.Text = "Add object"

            btnCancelar.Text = "Cancel"
            btnAceptar.Text = "Acept"
        End If
        objetoAgregadoConexito = lenguaje.objetoAgregadoConexito(objetoAgregadoConexito)
        elObjetoDebeTenerContenido = lenguaje.elObjetoDebeTenerContenido(elObjetoDebeTenerContenido)
    End Sub

End Class