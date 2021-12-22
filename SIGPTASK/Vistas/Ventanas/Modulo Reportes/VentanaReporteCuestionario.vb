Public Class VentanaReporteCuestionario
    '//HAY QUE APROLIJAR ESTE CODIGO DESPUES; O KIZA NO; QUIEN SABE
    Dim giro As Double = 0
    Private SecondCount As Integer = 0
    Private puntero As Bitmap = My.Resources.imagenFrente
    Dim ImagenFondo As Bitmap = My.Resources.imagenFondoNEW
    Private WithEvents timer1 As New Timer With {.Interval = 1}
    Dim conteo As Integer = 0
    Dim giroPositivo As Boolean = True
    '//ESPECIAL THANKS http://www.vbforums.com/showthread.php?876991-Analog-Clock-with-GDI
    '//
    Private Sub Form4_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        idiomaMesajes()
        DoubleBuffered = True
        giro = Int(Double.Parse(lblAnguloDeGiro.Text))

        If giro > 90 Then
            giroPositivo = True
            giro = giro - 90
            timer1.Start()
        ElseIf giro < 90 Then
            giroPositivo = False
            giro = 90 - giro
            timer1.Start()
        ElseIf giro = 90 Then
            timer1.Stop()
        End If
    End Sub
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            '///
            lblFecha.Text = "Date"
            lblFecha.Location = New Point(1140, 38)
            '///
            btnMostrarNotas.Text = "Show Notes"
            btnMostrarDetalles.Text = "Show Details"
            btnImprimir.Text = "Print"
            '///
            lblCuestionarioSeleccionado.Text = "Selected Questionary"
            lblCuestionarioSeleccionado.Location = New Point(41, 38)
            '///
            lblNombreDeLaSucursal.Text = "Subsidiary Name"
            lblNombreDeLaSucursal.Location = New Point(55, 73)
            '///
            lblNombreEmpleado.Text = "Employee Name"
            lblNombreEmpleado.Location = New Point(610, 71)
            '///
            lblTotalEmpleadosSucursal.Text = "Subsidiary workers"
            lblTotalEmpleadosSucursal.Location = New Point(845, 38)
            '///
            tbCuestionarioSeleccionado.Size = New Size(655, 24)
            tbNombreSucursal.Size = New Size(423, 24)
            '///
            lblMatricula.Text = "Register ID"
            lblNotas.Text = "NOTES"
            lblResumen.Text = "SUMARY"
            lblPreguntasRealizadas.Text = "questions asked"
            lblPreguntasConriesgoDeMuerte.Text = "questions with death risk"
            lblPreguntasRiesgoMuerteInsactisfactorias.Text = "Death risk questions answered unsatisfactorily"
            lblPreguntasInsactisfactorias.Text = "Risk coverage questions unsatisfactory"
            lblPreguntasSatisfactorias.Text = "Satisfactory questions"
            '///
            lblGradoPeligrosidad.Text = "DANGER RANK"
            lblGradoPeligrosidad.Location = New Point(250, 149)
            '///
            lblGradoRepercucion.Text = "IMPACT RANK"
            lblGradoRepercucion.Location = New Point(250, 513)
            '///
        End If
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        If conteo = giro Then
            timer1.Stop()
        End If
        SecondCount += 1  'factor for fast time 
        conteo = conteo + 1
        lblConteo.Text = conteo
        Invalidate()
    End Sub
    Private Sub Form4_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Me.Paint
        With e.Graphics
            Dim m As Single
            Dim rb As Integer
            rb = CInt((puntero.Height / 2))
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            Dim attr1 As New System.Drawing.Imaging.ImageAttributes
            .TranslateTransform(CSng(Me.ClientSize.Width / 3.5), CSng(Me.ClientSize.Height / 1.65)) '/POSICION EN PANTALLA

            .DrawImage(ImagenFondo, New Rectangle(-rb, -rb, ImagenFondo.Width, ImagenFondo.Height), 0, 0, ImagenFondo.Width, ImagenFondo.Height, GraphicsUnit.Pixel, attr1)

            If giroPositivo = True Then
                '  Console.WriteLine(giroPositivo)
                m = CSng((SecondCount) * -1)
                .RotateTransform(-m)
                rb = CInt((puntero.Height / 2))
                .DrawImage(puntero, New Rectangle(-rb, -rb, puntero.Width, puntero.Height), 0, 0, puntero.Width, puntero.Height, GraphicsUnit.Pixel)
            Else
                '  Console.WriteLine(giroPositivo)
                m = CSng((SecondCount))
                .RotateTransform(-m)
                rb = CInt((puntero.Height / 2))
                .DrawImage(puntero, New Rectangle(-rb, -rb, puntero.Width, puntero.Height), 0, 0, puntero.Width, puntero.Height, GraphicsUnit.Pixel)
            End If
            .RotateTransform(m)
        End With
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