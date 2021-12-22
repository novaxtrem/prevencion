Imports Microsoft.VisualBasic.PowerPacks.Printing

Public Class VentanaMuestoMapaRiesgoFinalizado
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

    '///////////BOLUDECES GRAFICAS
    '//CERRAR VENTANA
    Protected Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub

    Private Sub VentanaMuestoMapaRiesgoFinalizado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub pictureMapaRiesgo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        lblCoordenadasMouseClic.Text = e.Location().ToString

    End Sub


    Private Sub pictureMapaRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblCoordenadasMouseClic.Text = MousePosition.ToString
    End Sub

    Private Sub pictureBoxPlano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxPlano.Click
        lblCoordenadasMouseClic.Text = New Point(pictureBoxPlano.PointToClient(Control.MousePosition).X, (panelPortaPlano.PointToClient(Control.MousePosition).Y)).ToString

    End Sub

End Class