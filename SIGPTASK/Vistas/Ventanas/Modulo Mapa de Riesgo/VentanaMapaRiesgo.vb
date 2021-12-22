
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Threading

Public Class VentanaMapaRiesgo
    Private m_PanStartPoint As New Point
    Dim correcto As Boolean = False
    Dim ubicacionAgregadaYconfirmada As Boolean = False
    Dim ubicacionImagenPlanoRiesgo As String
    '////
    Dim noSeleccionoNingunRiesgo As String = ""
    Dim SeborraranloscambiosEfectuados As String = ""
    Dim TipoImagen As String = ""
    Dim noSeleccionoArchivo As String = ""
    Dim planoIngresadoConExitoGenerandoReporte As String = ""
    Dim hayUbicacionesSinNombreRectifique As String = ""
    Dim ahCocurridoUnProblema As String = ""
    Dim ubicacionSinNombre As String = ""
    Dim haOcurridoUnProblemaContacteASistemas As String = ""
    Dim sinDescripcion As String = ""
    Dim sinAgregarSolucion As String = ""
    Dim debeAgregarRiesgosAlMapa As String = ""
    '////


    Private Sub VentanaMapaRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMesajes()
        '///
        cargoRiesgosEnPanel()
        '////
        AllowDrop = True
        panelPortaPlano.AllowDrop = True
        pictureBoxPlano.Enabled = False
        panelPortaPlano.Enabled = False
        '////
        Dim regDate As Date = Date.Now()
        Dim fechaCreacion As String = regDate.ToString("dd\/MM\/yyyy")
        tbFecha.Text = fechaCreacion
    End Sub

    '////CARGO EL PLANO
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarPlano.Click

        If panelPortaPlano.Controls.Count > 1 Then
            Dim ventanaConfirmacion As New VentanaConfimracionGenerica
            ventanaConfirmacion.tbDatosSeleccionados.Text = SeborraranloscambiosEfectuados
            If ventanaConfirmacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
                For Each panelRiesgo As PanelRiesgoUbicacion In panelPortaPlano.Controls
                    panelRiesgo.Dispose()
                Next
                cargoPlano()
            End If
        Else
            cargoPlano()
        End If
    End Sub

    Private Sub cargoPlano()
        Dim open As New OpenFileDialog()
        open.Filter = TipoImagen & "(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png"
        open.ShowDialog()
        If open.SafeFileName.Contains(".") Then
            Me.pictureBoxPlano.Enabled = True
            pictureBoxPlano.Image = Image.FromFile(open.FileName)
            pictureBoxPlano.Enabled = True
            pictureBoxPlano.BringToFront()
            pictureBoxPlano.Show()
            correcto = True
            panelPortaPlano.Enabled = True
            ubicacionImagenPlanoRiesgo = Path.GetDirectoryName(open.FileName) & "\" & open.SafeFileName
            lblPlanoRutaArchivo.Text = ubicacionImagenPlanoRiesgo.ToString
            '///
            btnIngresarMapaDeRiesgo.Enabled = True
            panenlSuperpuestoInformacion.Hide()
        Else
            MessageBox.Show(noSeleccionoArchivo)
            correcto = False
            btnIngresarMapaDeRiesgo.Enabled = False
            panenlSuperpuestoInformacion.Show()
        End If
    End Sub

    Private Sub cargoRiesgosEnPanel()

        Dim listaRiesgos As New List(Of Riesgo)
        listaRiesgos = ConsultoTodosLosRiesgos(listaRiesgos, conn)
        For Each riesgo As Riesgo In listaRiesgos
            Dim panelriesgo As New PanelRiesgo
            panelriesgo.TopLevel = False
            panelriesgo.lblIdRiesgo.Text = riesgo.riesgoID.ToString
            panelriesgo.lblRiesgoNom.Text = riesgo.nombreRiesgo.ToString
            panelriesgo.lblRutaIcono.Text = riesgo.iconoRiesgo.ToString
            panelriesgo.pictureRiesgo.Image = Image.FromFile(panelriesgo.lblRutaIcono.Text)
            '////
            AddHandler panelriesgo.pictureRiesgo.DragEnter, AddressOf Me.panelImagen_DragEnter
            AddHandler panelriesgo.pictureRiesgo.MouseDown, AddressOf Me.MuevoRiesgo_MouseDown
            '////
            FlowLayoutPanelRiesgos.Controls.Add(panelriesgo)
            '////
            panelriesgo.Show()
        Next
    End Sub

    '///MOVIDA CONTUNDENTE, HAY CODIGO FUERTE ACA
    Private Sub MuevoRiesgo_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles FlowLayoutPanelRiesgos.MouseDown
        If Not ID_Riesgo.Equals("") Then
            If esImagen = True Then
                sender.DoDragDrop(sender.Image, DragDropEffects.All)
            Else
                sender.DoDragDrop(sender.Image, DragDropEffects.None)
            End If
        End If
    End Sub
    '///
    Private Sub FlowLayoutPanelRiesgos_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowLayoutPanelRiesgos.MouseEnter
        esImagen = False
        ID_Riesgo = ""
        NOMBRE_Riesgo = ""
        RUTA_icono = ""
    End Sub
    '///
    Private Sub Panel1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles panelPortaPlano.DragDrop
        Dim imagen As New PictureBox

        '///////////
        Dim panelUbicacionRiesgo As New PanelRiesgoUbicacion
        panelUbicacionRiesgo.TopLevel = False
        '////
        panelUbicacionRiesgo.Location = New Point(panelPortaPlano.PointToClient(Control.MousePosition).X, (panelPortaPlano.PointToClient(Control.MousePosition).Y))
        '///    
        Dim realX As Integer = 0
        Dim realY As Integer = 0
        '///
        lblcoordenadas.Text = panelUbicacionRiesgo.Location.ToString
        panelUbicacionRiesgo.lblcoordenadaX.Text = pictureBoxPlano.PointToClient(Control.MousePosition).X
        panelUbicacionRiesgo.lblcoordenadaY.Text = pictureBoxPlano.PointToClient(Control.MousePosition).Y
        '////
        panelUbicacionRiesgo.lblIDRiesgo.Text = ID_Riesgo.ToString
        panelUbicacionRiesgo.tbNombreRiesgo.Text = NOMBRE_Riesgo.ToString
        panelUbicacionRiesgo.pictureRiesgoElegido.Image = Image.FromFile(RUTA_icono)
        '////
        panelPortaPlano.Controls.Add(panelUbicacionRiesgo)
        panelUbicacionRiesgo.Show()
        panelUbicacionRiesgo.BringToFront()
    End Sub
    '///
    Private Sub panelImagen_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles panelPortaPlano.DragEnter
        If e.Data.GetDataPresent(GetType(Bitmap)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    '///////MANDO DATOS A PERSISTENCIA
    Private Sub btnIngresarMapaDeRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarMapaDeRiesgo.Click
        Dim mapa As New Mapa

        mapa.sucursalID = lblID_SucursalElegida.Text
        mapa.mapaRiesgoNombre = tbMapaRiesgoNombre.Text
        mapa.empleadoCedula = tbCedulaEmpleado.Text
        mapa.controladoPor = ""
        '///////////
        Dim formattedDate As String = Date.Today.ToString(stringfechaFormatoSalidaInformix)
        mapa.fecha = formattedDate
        '//////////
        mapa.planoRutaArchivo = lblPlanoRutaArchivo.Text
        mapa.estado = "P"

        Dim id_plano_ingresado As Integer
        id_plano_ingresado = AgregoMapaRiesgo(mapa, id_plano_ingresado, conn)
        If Not id_plano_ingresado.ToString.Equals("") = True Then
            mandoUbicaiones(id_plano_ingresado)
        Else
            MessageBox.Show(ahCocurridoUnProblema)
        End If
    End Sub
    Private Sub mandoUbicaiones(ByVal id_plano_ingresado As Integer)
        Dim formattedDate As String = Date.Today.ToString(stringfechaFormatoSalidaInformix)
        Dim listaRiesgoUbicacion As New List(Of RiesgoUbicacion)
        Dim estado As Boolean = False
        For Each ubicacionAgregada As PanelRiesgoUbicacion In panelPortaPlano.Controls.OfType(Of PanelRiesgoUbicacion)()
            If (ubicacionAgregada.GetType() Is GetType(PanelRiesgoUbicacion)) Then
                Dim ubicacion As New RiesgoUbicacion
                ubicacion.mapaID = id_plano_ingresado
                '////
                If ubicacionAgregada.tbNombreUbicacion.Text.Equals("") Then
                    ubicacion.ubicacionNombre = ubicacionSinNombre
                Else
                    ubicacion.ubicacionNombre = ubicacionAgregada.tbNombreUbicacion.Text
                End If

                If ubicacionAgregada.ckbCritico.Checked = True Then
                    ubicacion.critico = "S"
                Else
                    ubicacion.critico = "N"
                End If
                '///
                ubicacion.riesgoID = ubicacionAgregada.lblIDRiesgo.Text
                '////
                If ubicacionAgregada.tbDescripcionRiesgo.Text.Equals("") Then
                    ubicacion.descripcion = sinDescripcion
                Else
                    ubicacion.descripcion = ubicacionAgregada.tbDescripcionRiesgo.Text
                End If
                '////
                If ubicacionAgregada.tbSolucionRiesgo.Text.Equals("") Then
                    ubicacion.solucion = sinAgregarSolucion
                Else
                    ubicacion.solucion = ubicacionAgregada.tbSolucionRiesgo.Text
                End If
                '///////////
                formattedDate = ubicacionAgregada.DateFechaResuelto.Value.ToString(stringfechaFormatoSalidaInformix)
                ubicacion.plazo = formattedDate
                '//////////
                ubicacion.cumplidoEnfecha = ""
                '//////////
                ubicacion.coordendaX = ubicacionAgregada.lblcoordenadaX.Text
                ubicacion.coordenadaY = ubicacionAgregada.lblcoordenadaY.Text
                listaRiesgoUbicacion.Add(ubicacion)
            End If
        Next
        For Each ubicacion As RiesgoUbicacion In listaRiesgoUbicacion
            estado = AgregoRiesgosMapa(ubicacion, conn, estado)
        Next
        If estado = True Then
            MessageBox.Show(planoIngresadoConExitoGenerandoReporte)
            Me.Dispose()
        Else
            MessageBox.Show(debeAgregarRiesgosAlMapa)
        End If
    End Sub

 
    '///IDIOMA
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            TipoImagen = "Files img"
            lblempresaElegida.Text = "Selected Company"
            lblCedulaEmpleado.Text = "Emplyee ID"
            lblMatricula.Text = "Register ID"
            lblFecha.Text = "Date"
            btnAgregarNuevoRiesgo.Text = "Add New Risk"
            btnCargarPlano.Text = "Load Floorplan"
            lblNombreMapa.Text = "Risk Map Name"
            btnIngresarMapaDeRiesgo.Text = "Make Risk Map"
        Else
            TipoImagen = "Tipo imagen"
        End If
        hayUbicacionesSinNombreRectifique = lenguaje.hayUbicacionesSinNombreRectifique(hayUbicacionesSinNombreRectifique)
        planoIngresadoConExitoGenerandoReporte = lenguaje.planoIngresadoConExitoGenerandoReporte(planoIngresadoConExitoGenerandoReporte)
        noSeleccionoNingunRiesgo = lenguaje.noSeleccionoNingunRiesgo(noSeleccionoNingunRiesgo)
        SeborraranloscambiosEfectuados = lenguaje.SeborraranloscambiosEfectuados(SeborraranloscambiosEfectuados)
        noSeleccionoArchivo = lenguaje.noSeleccionoArchivo(noSeleccionoArchivo)
        ahCocurridoUnProblema = lenguaje.haOcurridoUnProblemaContacteASistemas(ahCocurridoUnProblema)
        ubicacionSinNombre = lenguaje.ubicacionSinNombre(ubicacionSinNombre)
        haOcurridoUnProblemaContacteASistemas = lenguaje.haOcurridoUnProblemaContacteASistemas(haOcurridoUnProblemaContacteASistemas)
        sinDescripcion = lenguaje.sinDescripcion(sinDescripcion)
        sinAgregarSolucion = lenguaje.sinAgregarSolucion(sinAgregarSolucion)
        debeAgregarRiesgosAlMapa = lenguaje.debeAgregarRiesgosAlMapa(debeAgregarRiesgosAlMapa)
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

    Private Sub btnAgregarNuevoRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarNuevoRiesgo.Click
        Dim ventanaCargoRiesgo As New VentanaCargarRiesgo
        ventanaCargoRiesgo.ShowDialog()
        If ventanaCargoRiesgo.DialogResult = Windows.Forms.DialogResult.OK Then
            ventanaCargoRiesgo.Dispose()
            FlowLayoutPanelRiesgos.Controls.Clear()
            cargoRiesgosEnPanel()
        End If
    End Sub

    Private Sub pictureBoxPlano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxPlano.Click

        lblcoordenadas.Text = New Point(pictureBoxPlano.PointToClient(Control.MousePosition).X, (pictureBoxPlano.PointToClient(Control.MousePosition).Y)).ToString

    End Sub

End Class