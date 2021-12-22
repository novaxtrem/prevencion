Public Class VentanaAgregarNota

    Private Sub VentanaAgegarNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        tbAnotaciones.MaxLength = 8000
        If tbAnotaciones.TextLength > 0 Then
            lblMaximoCaracteres.Text = tbAnotaciones.TextLength & "/8000"
        Else
            lblMaximoCaracteres.Text = "0/8000"
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub tbAnotaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAnotaciones.TextChanged
        lblMaximoCaracteres.Text = tbAnotaciones.Text.Length & "/8000"
    End Sub

    Private Sub tbAnotaciones_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles tbAnotaciones.KeyPress   
        If Not (Asc(e.KeyChar) = 8) Then
                If Not ((Asc(e.KeyChar) >= 32 And Asc(e.KeyChar) <= 126) Or (Asc(e.KeyChar) >= 160 And Asc(e.KeyChar) <= 165) Or (Asc(e.KeyChar) = 13)) Then
                    tbAnotaciones.SelectionStart = tbAnotaciones.SelectionLength
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
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
End Class