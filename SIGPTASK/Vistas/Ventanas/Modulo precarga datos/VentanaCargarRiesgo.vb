Imports System.IO
Imports System.Threading

Public Class VentanaCargarRiesgo
    Dim estado As Boolean = False
    Dim correcto As Boolean = False
    '///
    Dim TipoImagen As String = ""
    Dim noSeleccionoArchivo As String = ""
    Dim riesgoAgregadoConExito As String = ""
    Dim riesgoNOagregado As String = ""
    '///
    Dim hilo As New Thread(AddressOf Me.invocoYControloBoton)

    Private Sub VentanaAgregoRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMesajes()
        tbNombreRiesgo.MaxLength = 40

        '/// HILO
        hilo.IsBackground = True
        hilo.Start()
        '///
    End Sub
    '//HILO
    Private Function invocoYControloBoton()
        Do
            If btnAceptar.InvokeRequired = True Then
                If tbNombreRiesgo.Text.Length > 0 AndAlso Not Me.pictureRiesgoPreview.Image Is Nothing Then
                    Me.Invoke(Sub() btnAceptar.Enabled = True)
                Else
                    Me.Invoke(Sub() btnAceptar.Enabled = False)
                End If
            End If
        Loop
    End Function

    '// IDIOMA
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblNombreRiesgo.Text = "Risk Name"
            btnCargarImagendelRiesgo.Text = "Load image for a Risk"
            btnCancelar.Text = "Cancel"
            btnAceptar.Text = "Acept"
        End If
        TipoImagen = lenguaje.TipoImagen(TipoImagen)
        noSeleccionoArchivo = lenguaje.noSeleccionoArchivo(noSeleccionoArchivo)
        riesgoAgregadoConExito = lenguaje.riesgoAgregadoConExito(riesgoAgregadoConExito)
        riesgoNOagregado = lenguaje.riesgoNOagregado(riesgoNOagregado)
    End Sub
    '//
    Private Sub btnSelecionarImagenRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarImagendelRiesgo.Click
        cargoImagenRiesgo()
    End Sub
    Private Sub cargoImagenRiesgo()
        Dim open As New OpenFileDialog()
        open.Filter = TipoImagen & "(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png"
        open.ShowDialog()
        If open.SafeFileName.Contains(".") Then
            lblRutaArchivo.Text = Path.GetDirectoryName(open.FileName) & "\" & open.SafeFileName.ToString
            pictureRiesgoPreview.Image = Image.FromFile(open.FileName)
            correcto = True
        Else
            MessageBox.Show(noSeleccionoArchivo)
            correcto = False
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim riesgo As New Riesgo
        riesgo.nombreRiesgo = tbNombreRiesgo.Text
        riesgo.iconoRiesgo = lblRutaArchivo.Text
        estado = InsertoRiesgo(riesgo, conn, estado)
        If estado = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            hilo.Abort()
            MessageBox.Show(riesgoAgregadoConExito)
            Me.Dispose()
        Else
            hilo.Abort()
            MessageBox.Show(riesgoNOagregado)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        hilo.Abort()
        Me.Dispose()
    End Sub
    '///////////BOLUDECES GRAFICAS
    '///CERROR LA WINDOW
    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        hilo.Abort()
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

End Class