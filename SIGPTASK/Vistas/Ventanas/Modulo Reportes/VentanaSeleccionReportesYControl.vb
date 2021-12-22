Imports System.IO
Imports System.Drawing.Imaging

Public Class VentanaSeleccionReportesYControl
    '////
    Const riesgoInfimo As Double = 0.33
    Const riegoBajo As Double = ((100 ^ (1 / 3)) / 4)
    Const riesgoMedio As Double = (((100 ^ (1 / 3)) / 4) * 2)
    Const riesgoALto As Double = (((100 ^ (1 / 3)) / 4) * 3)
    Const riesgoExtremo As Double = ((100 ^ (1 / 3)))
    '////
    Dim variableSeleccion As String = ""
    Dim listaEmpresas As New List(Of Sucursal)
    Dim listaTecnicos As New List(Of Empleado)
    '////
    Dim ventanaReporteCuestionario As VentanaReporteCuestionario
    '////
    Dim variableDeCambiodeQuery As String = ""
    '////
    Dim ListaPanelesDetalle As New List(Of PanelIncidenciaDetalle)
    '////
    Dim varIDcuestionario As String = ""
    Dim varSucursalID As String = ""
    Dim varCuestionarioNombre As String = ""
    Dim varEmpresaRut As String = ""
    Dim varSucursalNombre As String = ""
    Dim varEmpleadoCedula As String = ""
    Dim varEmpleadoNombre As String = ""
    Dim varEmpleadoMatricula As String = ""
    Dim varCuestionarioFecha As String = ""
    Dim varPreguntaRealizada As String = ""
    Dim varAccionSugerida As String = ""
    Dim varRespuestaObetenida As String = ""
    Dim varRiesgoDeMuerte As String = ""
    Dim varGradoExposicion As String = ""
    Dim varGradoProbabilidad As String = ""
    Dim varGradoConsecuencia As String = ""
    Dim varTecnicoResponsable As String = ""
    Dim varFecha As String = ""
    Dim varNombreCuestionario As String = ""
    Dim varNombreSucursal As String = ""
    Dim estadoSucursal As String = ""
    Dim varRiesgoMuyBajo As String = ""
    Dim varRiesgoBajo As String = ""
    Dim varRiesgoModerado As String = ""
    Dim varRiesgoALto As String = ""
    Dim vaRiesgoExtremo As String = ""
    Dim EstaPreguntaImplicaRiesgoDeMuerte As String = ""
    Dim NoHayRiesgoDeMuerteAsociadoAEstaPregunta As String = ""
    Dim RespuestaContestadaInsactisfactoriamente As String = ""
    Dim ValoresDeProbabiliadInfimos As String = ""
    Dim ValoresDeProbabiliadBajos As String = ""
    Dim ValoresDeProbabiliadMedios As String = ""
    Dim ValoresDeProbabiliadAltos As String = ""
    Dim ValoresDeProbabiliadExtremos As String = ""
    Dim ValoresDeExposicionInfimos As String = ""
    Dim ValoresDeExposicionBajos As String = ""
    Dim ValoresDeExposicionMedios As String = ""
    Dim ValoresDeExposicionAltos As String = ""
    Dim ValoresDeExposicionExtremos As String = ""
    Dim ValoresDeConsecuenciaInfimos As String = ""
    Dim ValoresDeConsecuenciaBajos As String = ""
    Dim ValoresDeConsecuenciaMedios As String = ""
    Dim ValoresDeConsecuenciaAltos As String = ""
    Dim ValoresDeconsecuenciaExtremos As String = ""
    Dim RespuestaContestadaSatisfactoriamente As String = ""
    Dim noSeleccionoNada As String = ""
    Dim OcultarDetalles As String = ""
    Dim MostrarDetalles As String = ""
    Dim OcultarNotas As String = ""
    Dim MostrarNotas As String = ""
    Dim varNombreMapaRiesgo As String = ""
    Dim varUbicacionNombre As String = ""
    Dim varCritico As String = ""
    Dim varDescripcion As String = ""
    Dim varSolucion As String = ""
    Dim varPlazo As String = ""
    '////
    Dim varMapaID As String = ""
    Dim varPlanoRutaArchivo As String = ""
    Dim varEstado As String = ""
    Dim varMapaRiesgoNombre As String = ""
    '////
    Dim ID_SUCURSAL_ELEGIDA As Integer = 0
    '////
    Dim listaRiesgosMandoADibujar As New List(Of RiesgoUbicacion)
    Dim planoADibujar As New Mapa
    '////
    Private Sub VentanaSeleccionReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMensajes()
        listaEmpresas = CargoEmpresas(listaEmpresas, conn)
        listaTecnicos = CargoTecnicosPrevencionistas(listaTecnicos, conn)
        If idiomaSeleccionado.Equals("ING") Then
            lblMatricula.Location = New Point(480, 106)
            lblFiltrarTecnicoPrevencionista.Location = New Point(483, 76)
            lblFiltrarPorEmpresa.Location = New Point(40, 76)
            lblRUT.Location = New Point(75, 106)
        End If
        If lblSELECTOR.Text.Equals("CONTROL") Then
            cargoLaMovidaDelosMapas()
        Else

        End If

        For Each empresa As Sucursal In listaEmpresas
            comboListaEmpresas.Items.Add(empresa.sucursalID & " " & empresa.empresaRUT & " " & empresa.empresaNombre & " " & empresa.sucursalNombre)
        Next

        For Each tecnico As Empleado In listaTecnicos
            comboTecnicosPrevencinista.Items.Add(tecnico.empleadoCedula & " " & tecnico.empleadoNombre & " " & tecnico.matricula)
        Next
    End Sub
    '///
    Dim listaPanelUbicacionesConRiesgosParaControlar As New List(Of PanelControlCumplimiento)
    '///

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

    Private Sub btnReportesCuestionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        variableSeleccion = "cuestionario"
    End Sub

    Private Sub btnReportesMapasRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        variableSeleccion = "mapa_riesgo"
    End Sub

    Private Sub btnReporteInventarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        variableSeleccion = "inventario"
    End Sub

    Private Sub idiomaMensajes()
        If idiomaSeleccionado.Equals("ING") Then
            btnReportesCuestionarios.Text = "Questionary Reports"
            btnReportesMapasRiesgo.Text = "Risk Maps Reports"
            btnReporteInventarios.Text = "Inventory Reports"
            lblFiltrarPorEmpresa.Text = "Subsidiary Filter"
            lblRUT.Text = "RUT Filter"
            lblFiltrarTecnicoPrevencionista.Text = "Filter by Prevention technician"
            lblMatricula.Text = "Prevention technician Register"
            btnBuscar.Text = "Search"
            '///
        End If
        varIDcuestionario = lenguaje.varIDcuestionario(varIDcuestionario)
        varSucursalID = lenguaje.varSucursalID(varSucursalID)
        varCuestionarioNombre = lenguaje.varCuestionarioNombre(varCuestionarioNombre)
        varEmpresaRut = lenguaje.varEmpresaRut(varEmpresaRut)
        varSucursalNombre = lenguaje.varSucursalNombre(varSucursalNombre)
        varEmpleadoCedula = lenguaje.varEmpleadoCedula(varEmpleadoCedula)
        varEmpleadoNombre = lenguaje.varEmpleadoNombre(varEmpleadoNombre)
        varEmpleadoMatricula = lenguaje.varEmpleadoMatricula(varEmpleadoMatricula)
        varCuestionarioFecha = lenguaje.varCuestionarioFecha(varCuestionarioFecha)
        varPreguntaRealizada = lenguaje.varPreguntaRealizada(varPreguntaRealizada)
        varAccionSugerida = lenguaje.varAccionSugerida(varAccionSugerida)
        varRespuestaObetenida = lenguaje.varRespuestaObetenida(varRespuestaObetenida)
        varRiesgoDeMuerte = lenguaje.varRiesgoDeMuerte(varRiesgoDeMuerte)
        varGradoExposicion = lenguaje.varGradoExposicion(varGradoExposicion)
        varGradoProbabilidad = lenguaje.varGradoProbabilidad(varGradoProbabilidad)
        varGradoConsecuencia = lenguaje.varGradoConsecuencia(varGradoConsecuencia)
        varTecnicoResponsable = lenguaje.varTecnicoResponsable(varTecnicoResponsable)
        varFecha = lenguaje.varFecha(varFecha)
        varNombreCuestionario = lenguaje.varNombreCuestionario(varNombreCuestionario)
        varNombreSucursal = lenguaje.varNombreSucursal(varNombreSucursal)
        estadoSucursal = lenguaje.estadoSucursal(estadoSucursal)
        varRiesgoMuyBajo = lenguaje.varRiesgoMuyBajo(varRiesgoMuyBajo)
        varRiesgoBajo = lenguaje.varRiesgoBajo(varRiesgoBajo)
        varRiesgoModerado = lenguaje.varRiesgoModerado(varRiesgoModerado)
        varRiesgoALto = lenguaje.varRiesgoALto(varRiesgoALto)
        vaRiesgoExtremo = lenguaje.vaRiesgoExtremo(vaRiesgoExtremo)
        EstaPreguntaImplicaRiesgoDeMuerte = lenguaje.EstaPreguntaImplicaRiesgoDeMuerte(EstaPreguntaImplicaRiesgoDeMuerte)
        NoHayRiesgoDeMuerteAsociadoAEstaPregunta = lenguaje.NoHayRiesgoDeMuerteAsociadoAEstaPregunta(NoHayRiesgoDeMuerteAsociadoAEstaPregunta)
        RespuestaContestadaInsactisfactoriamente = lenguaje.RespuestaContestadaInsactisfactoriamente(RespuestaContestadaInsactisfactoriamente)
        ValoresDeProbabiliadInfimos = lenguaje.ValoresDeProbabiliadInfimos(ValoresDeProbabiliadInfimos)
        ValoresDeProbabiliadBajos = lenguaje.ValoresDeProbabiliadBajos(ValoresDeProbabiliadBajos)
        ValoresDeProbabiliadMedios = lenguaje.ValoresDeProbabiliadMedios(ValoresDeProbabiliadMedios)
        ValoresDeProbabiliadAltos = lenguaje.ValoresDeProbabiliadAltos(ValoresDeProbabiliadAltos)
        ValoresDeProbabiliadExtremos = lenguaje.ValoresDeProbabiliadExtremos(ValoresDeProbabiliadExtremos)
        ValoresDeExposicionInfimos = lenguaje.ValoresDeExposicionInfimos(ValoresDeExposicionInfimos)
        ValoresDeExposicionBajos = lenguaje.ValoresDeExposicionBajos(ValoresDeExposicionBajos)
        ValoresDeExposicionMedios = lenguaje.ValoresDeExposicionMedios(ValoresDeExposicionMedios)
        ValoresDeExposicionAltos = lenguaje.ValoresDeExposicionAltos(ValoresDeExposicionAltos)
        ValoresDeExposicionExtremos = lenguaje.ValoresDeExposicionExtremos(ValoresDeExposicionExtremos)
        ValoresDeConsecuenciaInfimos = lenguaje.ValoresDeConsecuenciaInfimos(ValoresDeConsecuenciaInfimos)
        ValoresDeConsecuenciaBajos = lenguaje.ValoresDeConsecuenciaBajos(ValoresDeConsecuenciaBajos)
        ValoresDeConsecuenciaMedios = lenguaje.ValoresDeConsecuenciaMedios(ValoresDeConsecuenciaMedios)
        ValoresDeConsecuenciaAltos = lenguaje.ValoresDeConsecuenciaAltos(ValoresDeConsecuenciaAltos)
        ValoresDeconsecuenciaExtremos = lenguaje.ValoresDeconsecuenciaExtremos(ValoresDeconsecuenciaExtremos)
        RespuestaContestadaSatisfactoriamente = lenguaje.RespuestaContestadaSatisfactoriamente(RespuestaContestadaSatisfactoriamente)
        noSeleccionoNada = lenguaje.noSeleccionoNada(noSeleccionoNada)
        OcultarDetalles = lenguaje.OcultarDetalles(OcultarDetalles)
        MostrarDetalles = lenguaje.MostrarDetalles(MostrarDetalles)
        OcultarNotas = lenguaje.OcultarNotas(OcultarNotas)
        MostrarNotas = lenguaje.MostrarNotas(MostrarNotas)
        '///
        varMapaID = lenguaje.varMapaID(varMapaID)
        varPlanoRutaArchivo = lenguaje.varPlanoRutaArchivo(varPlanoRutaArchivo)
        varEstado = lenguaje.varEstado(varEstado)
        varMapaRiesgoNombre = lenguaje.varMapaRiesgoNombre(varMapaRiesgoNombre)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Select Case variableSeleccion
            Case "CUESTIONARIO"
                
        End Select
    End Sub


    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Select Case variableSeleccion
            Case "CUESTIONARIO"
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    Dim selectedRow = DataGridView1.Rows(e.RowIndex)
                    Dim confirmacion As New VentanaConfimracionGenerica
                    '///
                    confirmacion.tbDatosSeleccionados.Text = selectedRow.Cells(0).Value.ToString & " " & selectedRow.Cells(5).Value.ToString
                    '///
                    If confirmacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim totalPreguntas As Integer = 0
                        Dim totalPreguntasConRiesgoDeMuerte As Integer = 0
                        Dim preguntasConRiesgoDeMuerteContestadasNO As Integer = 0
                        Dim preguntasContestadasNO As Integer = 0
                        Dim preguntasContestadasSI As Integer = 0
                        '///
                        ventanaReporteCuestionario = New VentanaReporteCuestionario
                        ListaPanelesDetalle = New List(Of PanelIncidenciaDetalle)
                        '///
                        AddHandler ventanaReporteCuestionario.btnMostrarDetalles.Click, AddressOf Me.btnMostrarDetalles_Click
                        AddHandler ventanaReporteCuestionario.btnMostrarNotas.Click, AddressOf Me.btnMostrarNotas_Click
                        AddHandler ventanaReporteCuestionario.btnImprimir.Click, AddressOf Me.btnImprimir_Click
                        '///
                        Dim listaIncidencias As New List(Of CueSucEmp)
                        listaIncidencias = consultoPreguntasYHagoGraficas(id_cuestionarioElejido:=selectedRow.Cells(0).Value, listaIncidenciasInfoCompleta:=listaIncidencias, conn:=conn)
                        '///

                        totalEmpleadosSucursal = listaIncidencias.Item(0).totalEmpleadosSucursal

                        Dim GP As Double = 0
                        Dim trabajadoresExpuestos As Integer = 0
                        Dim porcentajeExpuestos As Double = 0
                        Dim totalTrabajadores As Integer = 0
                        Dim FP As Double = 0
                        Dim GR As Double = 0

                        '///DATOS CABEZAL
                        ventanaReporteCuestionario.tbCuestionarioSeleccionado.Text = selectedRow.Cells(2).Value.ToString
                        ventanaReporteCuestionario.tbNombreSucursal.Text = selectedRow.Cells(4).Value.ToString
                        ventanaReporteCuestionario.tbNombreEmpleado.Text = selectedRow.Cells(6).Value.ToString
                        ventanaReporteCuestionario.tbEmpleadosSucursal.Text = selectedRow.Cells(6).Value.ToString
                        ventanaReporteCuestionario.tbFecha.Text = selectedRow.Cells(8).Value.ToString
                        '///
                        ventanaReporteCuestionario.tbEmpleadosSucursal.Text = listaIncidencias.Item(0).totalEmpleadosSucursal.ToString
                        ventanaReporteCuestionario.tbMatricula.Text = selectedRow.Cells(7).Value.ToString
                        '///
                        ventanaReporteCuestionario.tbnotas.Text = listaIncidencias.Item(0).cuestionarioNota.ToString
                        '///DATOS RESUMEN
                        ventanaReporteCuestionario.tbTotalPreguntasRealizadas.Text = listaIncidencias.Count
                        ventanaReporteCuestionario.tbPreguntasConRiesgoDeMuerte.Text = totalPreguntasConRiesgoDeMuerte
                        ventanaReporteCuestionario.tbRespuestasRiesgoMuerteContestadasMal.Text = preguntasConRiesgoDeMuerteContestadasNO
                        ventanaReporteCuestionario.tbRespuestasNO.Text = preguntasContestadasNO
                        ventanaReporteCuestionario.tbRespuestasSI.Text = preguntasContestadasSI
                        '///

                        For Each incidencia As CueSucEmp In listaIncidencias
                            totalTrabajadores = incidencia.totalEmpleadosSucursal
                            Dim panelIncidencia As New PanelIncidenciaDetalle
                            panelIncidencia.TopLevel = False
                            panelIncidencia.tbPreguntaHecha.Text = incidencia.pregunta
                            panelIncidencia.tbAccionSugerida.Text = incidencia.accion
                            '//// VALORES PARA EL FINE
                            panelIncidencia.tbNivelProbabilidad.Text = incidencia.nivelProbabilidad
                            panelIncidencia.tbNivelExposicion.Text = incidencia.nivelExposicion
                            panelIncidencia.tbNivelConsecuencia.Text = incidencia.nivelConsecuencia
                            '////
                            panelIncidencia.lblRespuesta.Text = incidencia.respuesta
                            panelIncidencia.lblRiesgoMuerteRes.Text = incidencia.riesgoMuerte
                            panelIncidencia.lblExpuestos.Text = incidencia.expuestos
                            panelIncidencia.tbRespuestaObetenida.Text = incidencia.respuesta
                            panelIncidencia.lblGPporPregunta.Text = incidencia.nivelProbabilidad * incidencia.nivelConsecuencia * incidencia.nivelExposicion
                            '///
                            GP = GP + incidencia.nivelProbabilidad * incidencia.nivelConsecuencia * incidencia.nivelExposicion
                            trabajadoresExpuestos = trabajadoresExpuestos + panelIncidencia.lblExpuestos.Text


                            If incidencia.riesgoMuerte.Equals("S") Then
                                '///ESTILO VISUAL
                                panelIncidencia.tbRiesgoMuerte.Text = EstaPreguntaImplicaRiesgoDeMuerte
                                panelIncidencia.tbRiesgoMuerte.Font = New Font(panelIncidencia.tbRiesgoMuerte.Font, FontStyle.Bold)
                                panelIncidencia.tbRiesgoMuerte.ForeColor = Color.Red
                                '///
                                totalPreguntasConRiesgoDeMuerte = totalPreguntasConRiesgoDeMuerte + 1
                            Else
                                panelIncidencia.tbRiesgoMuerte.Text = NoHayRiesgoDeMuerteAsociadoAEstaPregunta
                                panelIncidencia.tbRiesgoMuerte.ForeColor = Color.Black
                            End If
                            '///
                            If incidencia.respuesta.Equals("N") Then
                                panelIncidencia.tbRespuestaObetenida.Text = RespuestaContestadaInsactisfactoriamente
                                panelIncidencia.tbRespuestaObetenida.ForeColor = Color.Red
                                panelIncidencia.tbRespuestaObetenida.Font = New Font(panelIncidencia.tbRespuestaObetenida.Font, FontStyle.Bold)
                                '///
                                If incidencia.riesgoMuerte.Equals("S") Then
                                    preguntasConRiesgoDeMuerteContestadasNO = preguntasConRiesgoDeMuerteContestadasNO + 1
                                End If
                                preguntasContestadasNO = preguntasContestadasNO + 1
                            Else
                                '///PREGUNTAS CONTESTADAS SATISFACTORIAMENTE
                                '///ESTILO VISUAL
                                panelIncidencia.Height = 210
                                panelIncidencia.LineShape2.Visible = True
                                panelIncidencia.tbRespuestaObetenida.Text = RespuestaContestadaSatisfactoriamente
                                panelIncidencia.tbRespuestaObetenida.Font = New Font(panelIncidencia.tbRespuestaObetenida.Font, FontStyle.Bold)
                                panelIncidencia.tbRespuestaObetenida.ForeColor = Color.DarkBlue
                                '///
                                preguntasContestadasSI = preguntasContestadasSI + 1
                            End If
                            panelIncidencia.Show()
                            ListaPanelesDetalle.Add(panelIncidencia)
                            ventanaReporteCuestionario.FlowPanelDetalle.Controls.Add(panelIncidencia)
                        Next

                        '     _____  ______ _____  _____   ____  _   _   ______ _                                                         
                        '    |  __ \|  ____|  __ \|  __ \ / __ \| \ | | |  ____| |                                                        
                        '    | |__) | |__  | |__) | |  | | |  | |  \| | | |__  | |                                                        
                        '    |  ___/|  __| |  _  /| |  | | |  | | . ` | |  __| | |                                                        
                        '    | |    | |____| | \ \| |__| | |__| | |\  | | |____| |____                                                    
                        '    |_|  __|______|_|__\_\_____/_\____/|_| \_| |______|______|   __________                                      
                        '    |  \/  |   /\   |  __ \__   __|_   _| |    | |        /\    |___  / __ \                                     
                        '    | \  / |  /  \  | |__) | | |    | | | |    | |       /  \      / / |  | |                                    
                        '    | |\/| | / /\ \ |  _  /  | |    | | | |    | |      / /\ \    / /| |  | |                                    
                        '    | |  | |/ ____ \| | \ \  | |   _| |_| |____| |____ / ____ \  / /_| |__| |                                    
                        '    |_|  |_/_/____\_\_|  \_\ |_|__|_____|______|______/_/_ __\_\/_____\____/                                     
                        '        /\   / ____|   /\     |  __ \|  __ \ / __ \|  ____|  ____|                                               
                        '       /  \ | |       /  \    | |__) | |__) | |  | | |__  | |__                                                  
                        '      / /\ \| |      / /\ \   |  ___/|  _  /| |  | |  __| |  __|                                                 
                        '     / ____ \ |____ / ____ \  | |    | | \ \| |__| | |    | |____                                                
                        '    /_/____\_\_____/_/_  _\_\_|_|____|_|__\_\\____/|_| __ |______|_____                                          
                        '     / ____/ __ \|  __ \|  __ \|  ____/ ____|_   _|  \/  |/ __ \ / ____|                                         
                        '    | |   | |  | | |__) | |__) | |__ | |  __  | | | \  / | |  | | (___                                           
                        '    | |   | |  | |  _  /|  _  /|  __|| | |_ | | | | |\/| | |  | |\___ \                                          
                        '    | |___| |__| | | \ \| | \ \| |___| |__| |_| |_| |  | | |__| |____) |                                         
                        '     \_____\____/|_|__\_\_|  \_\______\_____|_____|_|  |_|\____/|_____/                                          
                        '    |  __ \ /\   |  __ \     /\     | |        /\                                                                
                        '    | |__) /  \  | |__) |   /  \    | |       /  \                                                               
                        '    |  ___/ /\ \ |  _  /   / /\ \   | |      / /\ \                                                              
                        '    | |  / ____ \| | \ \  / ____ \  | |____ / ____ \                                                             
                        '    |_|_/_/_ __\_\_|__\_\/_/  _ \_\_|______/_/    \_\____ _    _ _____                   _             _         
                        '    |__   __|  ____/ ____| \ | |_   _/ ____|   /\|__   __| |  | |  __ \     /\          | |  /\       | |  /\    
                        '       | |  | |__ | |    |  \| | | || |       /  \  | |  | |  | | |__) |   /  \         | | /  \      | | /  \   
                        '       | |  |  __|| |    | . ` | | || |      / /\ \ | |  | |  | |  _  /   / /\ \    _   | |/ /\ \ _   | |/ /\ \  
                        '       | |  | |___| |____| |\  |_| || |____ / ____ \| |  | |__| | | \ \  / ____ \  | |__| / ____ \ |__| / ____ \ 
                        '       |_|  |______\_____|_| \_|_____\_____/_/    \_\_|   \____/|_|  \_\/_/    \_\  \____/_/    \_\____/_/    \_\
                        '   

                        porcentajeExpuestos = ((trabajadoresExpuestos / totalTrabajadores) * 100) / listaIncidencias.Count
                        If porcentajeExpuestos < 21 Then
                            FP = 1
                        ElseIf porcentajeExpuestos > 20 And porcentajeExpuestos < 41 Then
                            FP = 2
                        ElseIf porcentajeExpuestos > 40 And porcentajeExpuestos < 61 Then
                            FP = 3
                        ElseIf porcentajeExpuestos > 60 And porcentajeExpuestos < 80 Then
                            FP = 4
                        ElseIf porcentajeExpuestos > 80 And porcentajeExpuestos < 101 Then
                            FP = 5
                        End If

                        ventanaReporteCuestionario.barraProgreso.Maximum = listaIncidencias.Count * 1000
                        ventanaReporteCuestionario.barraProgreso.Minimum = 0
                        GR = GP * FP
                        GP = (180 / listaIncidencias.Count) * 1000

                        If GP > 180 Then
                            GP = 180
                        ElseIf GP < 0 Then
                            GP = 0
                        End If

                        '/ HAGAMOS DE CUENTA QUE ES UNA TECH DEMO
                        ventanaReporteCuestionario.barraProgreso.Maximum = GR + 600 '/si lo numeros no cierran..
                        ventanaReporteCuestionario.barraProgreso.Value = GR
                        ventanaReporteCuestionario.lblAnguloDeGiro.Text = GP
                        '///DATOS VARIOS
                        ventanaReporteCuestionario.lblID_Cuestionario.Text = selectedRow.Cells(0).Value.ToString
                        ventanaReporteCuestionario.lblID_Sucursal.Text = selectedRow.Cells(1).Value.ToString

                        ventanaReporteCuestionario.Show()
                    Else
                        MessageBox.Show(noSeleccionoNada)
                    End If
                End If

            Case "CONTROLO Y OBSERVO"
                variableDeCambiodeQuery = "P"
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    Dim selectedRow = DataGridView1.Rows(e.RowIndex)
                    Dim confirmacion As New VentanaConfimracionGenerica
                    Dim ID_MAPA As Integer = 0
                    '///
                    confirmacion.tbDatosSeleccionados.Text = selectedRow.Cells(0).Value.ToString & " " & selectedRow.Cells(2).Value.ToString & " " & selectedRow.Cells(3).Value.ToString
                    ID_MAPA = selectedRow.Cells(0).Value.ToString
                    '///
                    If confirmacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim ventanaControlo As New VentanaControlCumplimiento
                        AddHandler ventanaControlo.btnVerMapa.Click, AddressOf Me.btnVerMapa_Click
                        '///
                        Dim listaUbicacionesConRiesgos As New List(Of RiesgoUbicacion)
                        Dim mapaRiesgoElegido As New Mapa
                        '/// CABEZAL PLATILLA CONTROL
                        mapaRiesgoElegido = ConsultoInformacionDelMapaElegido(mapaRiesgoElegido, ID_MAPA, conn, variableDeCambiodeQuery)
                        planoADibujar = mapaRiesgoElegido
                        listaUbicacionesConRiesgos = ConsultoMapaYHagoControl(mapaRiesgoElegido.mapaID, conn, listaUbicacionesConRiesgos, variableDeCambiodeQuery)
                        listaRiesgosMandoADibujar = listaUbicacionesConRiesgos
                        '///
                        ventanaControlo.tbMapaRiesgoNombre.Text = mapaRiesgoElegido.mapaRiesgoNombre.ToString
                        '///
                        ventanaControlo.tbNombreSucursal.Text = ConsultoNombreSucursalPorID(ventanaControlo.tbNombreSucursal.Text, mapaRiesgoElegido.sucursalID, conn)
                        ventanaControlo.tbMatricula.Text = ConsultoMatriculaPorCedula(ventanaControlo.tbMatricula.Text, mapaRiesgoElegido.empleadoCedula, conn)
                        '///
                        ventanaControlo.tbFecha.Text = mapaRiesgoElegido.fecha.ToString
                        '///

                        ventanaControlo.lblIDMapaRiesgo.Text = mapaRiesgoElegido.mapaID.ToString
                        ventanaControlo.lblRutaImagenMapa.Text = mapaRiesgoElegido.planoRutaArchivo.ToString
                        '///
                        If listaUbicacionesConRiesgos.Count > 0 Then
                            For Each ubicacionRiesgo As RiesgoUbicacion In listaUbicacionesConRiesgos
                                Dim panelUbicacionesRiesgos As New PanelControlCumplimiento
                                '///
                                panelUbicacionesRiesgos.TopLevel = False
                                '///
                                panelUbicacionesRiesgos.tbNombreUbicacion.Text = ubicacionRiesgo.ubicacionNombre.ToString
                                panelUbicacionesRiesgos.lblImagenUbicacion.Text = ubicacionRiesgo.riesgoIcono.ToString
                                panelUbicacionesRiesgos.lblCoordenadaX.Text = ubicacionRiesgo.coordendaX.ToString
                                panelUbicacionesRiesgos.lblCoordenadaY.Text = ubicacionRiesgo.coordenadaY.ToString
                                panelUbicacionesRiesgos.lblIncidenciaID.Text = ubicacionRiesgo.ubicacionID.ToString
                                panelUbicacionesRiesgos.lblIDRiesgo.Text = ubicacionRiesgo.riesgoID.ToString

                                '///
                                If ubicacionRiesgo.critico.Equals("S") Then
                                    panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                                    panelUbicacionesRiesgos.pictureBoxCritico.Visible = True
                                Else
                                    panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                                    panelUbicacionesRiesgos.pictureBoxCritico.Visible = False
                                End If
                                '///
                                panelUbicacionesRiesgos.tbObservacion.Text = ubicacionRiesgo.descripcion.ToString
                                panelUbicacionesRiesgos.tbSugerencia.Text = ubicacionRiesgo.solucion.ToString
                                panelUbicacionesRiesgos.tbFechaLimite.Text = ubicacionRiesgo.plazo.ToString
                                panelUbicacionesRiesgos.pictureBoxRiesgoImagen.Image = Image.FromFile(ubicacionRiesgo.riesgoIcono)
                                ventanaControlo.panelCentral.Controls.Add(panelUbicacionesRiesgos)
                                listaPanelUbicacionesConRiesgosParaControlar.Add(panelUbicacionesRiesgos)
                                panelUbicacionesRiesgos.Show()
                            Next
                            ventanaControlo.ShowDialog()

                        End If
                    End If
                End If

            Case "MAPAS"
                variableDeCambiodeQuery = "T"
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    Dim selectedRow = DataGridView1.Rows(e.RowIndex)
                    Dim confirmacion As New VentanaConfimracionGenerica
                    Dim ID_MAPA As Integer = 0
                    '///
                    confirmacion.tbDatosSeleccionados.Text = selectedRow.Cells(0).Value.ToString & " " & selectedRow.Cells(2).Value.ToString & " " & selectedRow.Cells(3).Value.ToString
                    ID_MAPA = selectedRow.Cells(0).Value.ToString
                    '///
                    If confirmacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim ventanaControlo As New VentanaControlCumplimiento
                        AddHandler ventanaControlo.btnVerMapa.Click, AddressOf Me.btnVerMapa_Click
                        '///
                        Dim listaUbicacionesConRiesgos As New List(Of RiesgoUbicacion)
                        Dim mapaRiesgoElegido As New Mapa
                        '/// CABEZAL PLATILLA CONTROL
                        mapaRiesgoElegido = ConsultoInformacionDelMapaElegido(mapaRiesgoElegido, ID_MAPA, conn, variableDeCambiodeQuery)
                        planoADibujar = mapaRiesgoElegido
                        listaUbicacionesConRiesgos = ConsultoMapaYHagoControl(mapaRiesgoElegido.mapaID, conn, listaUbicacionesConRiesgos, variableDeCambiodeQuery)
                        listaRiesgosMandoADibujar = listaUbicacionesConRiesgos
                        '///
                        ventanaControlo.tbMapaRiesgoNombre.Text = mapaRiesgoElegido.mapaRiesgoNombre.ToString
                        '///
                        ventanaControlo.tbNombreSucursal.Text = ConsultoNombreSucursalPorID(ventanaControlo.tbNombreSucursal.Text, mapaRiesgoElegido.sucursalID, conn)
                        ventanaControlo.tbMatricula.Text = ConsultoMatriculaPorCedula(ventanaControlo.tbMatricula.Text, mapaRiesgoElegido.empleadoCedula, conn)
                        '///
                        ventanaControlo.tbFecha.Text = mapaRiesgoElegido.fecha.ToString
                        '///
                        ventanaControlo.lblIDMapaRiesgo.Text = mapaRiesgoElegido.mapaID.ToString
                        ventanaControlo.lblRutaImagenMapa.Text = mapaRiesgoElegido.planoRutaArchivo.ToString
                        '///
                        If listaUbicacionesConRiesgos.Count > 0 Then
                            For Each ubicacionRiesgo As RiesgoUbicacion In listaUbicacionesConRiesgos
                                Dim panelUbicacionesRiesgos As New PanelControlCumplimiento
                                '///
                                panelUbicacionesRiesgos.TopLevel = False
                                '///
                                panelUbicacionesRiesgos.tbNombreUbicacion.Text = ubicacionRiesgo.ubicacionNombre.ToString
                                panelUbicacionesRiesgos.lblImagenUbicacion.Text = ubicacionRiesgo.riesgoIcono.ToString
                                panelUbicacionesRiesgos.lblCoordenadaX.Text = ubicacionRiesgo.coordendaX.ToString
                                panelUbicacionesRiesgos.lblCoordenadaY.Text = ubicacionRiesgo.coordenadaY.ToString
                                panelUbicacionesRiesgos.lblIncidenciaID.Text = ubicacionRiesgo.ubicacionID.ToString
                                panelUbicacionesRiesgos.lblIDRiesgo.Text = ubicacionRiesgo.riesgoID.ToString

                                '///

                                If ubicacionRiesgo.critico.Equals("S") Then
                                    panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                                    panelUbicacionesRiesgos.pictureBoxCritico.Visible = True
                                Else
                                    panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                                    panelUbicacionesRiesgos.pictureBoxCritico.Visible = False
                                End If
                                '///
                                panelUbicacionesRiesgos.tbObservacion.Text = ubicacionRiesgo.descripcion.ToString
                                panelUbicacionesRiesgos.tbSugerencia.Text = ubicacionRiesgo.solucion.ToString
                                panelUbicacionesRiesgos.tbFechaLimite.Text = ubicacionRiesgo.plazo.ToString
                                panelUbicacionesRiesgos.pictureBoxRiesgoImagen.Image = Image.FromFile(ubicacionRiesgo.riesgoIcono)
                                ventanaControlo.panelCentral.Controls.Add(panelUbicacionesRiesgos)
                                listaPanelUbicacionesConRiesgosParaControlar.Add(panelUbicacionesRiesgos)
                                panelUbicacionesRiesgos.radioButonNO.Enabled = False
                                panelUbicacionesRiesgos.radioButoSI.Enabled = False
                                panelUbicacionesRiesgos.Show()
                            Next
                            ventanaControlo.btnValidarControl.Hide()

                            ventanaControlo.ShowDialog()

                        End If
                    End If
                End If
                '////
            Case "INVENTARIO"

                '        ______ _   _   _____  ______  _____         _____  _____   ____  _      _      ____  
                '       |  ____| \ | | |  __ \|  ____|/ ____|  /\   |  __ \|  __ \ / __ \| |    | |    / __ \ 
                '       | |__  |  \| | | |  | | |__  | (___   /  \  | |__) | |__) | |  | | |    | |   | |  | |
                '       |  __| | . ` | | |  | |  __|  \___ \ / /\ \ |  _  /|  _  /| |  | | |    | |   | |  | |
                '       | |____| |\  | | |__| | |____ ____) / ____ \| | \ \| | \ \| |__| | |____| |___| |__| |
                '       |______|_| \_| |_____/|______|_____/_/    \_\_|  \_\_|  \_\\____/|______|______\____/ 
                '
                '
                '
                '                '    variableDeCambiodeQuery = "T"
                '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                '        Dim selectedRow = DataGridView1.Rows(e.RowIndex)
                '        Dim confirmacion As New VentanaConfimracionGenerica
                '        Dim ID_MAPA As Integer = 0
                '        '///
                '        confirmacion.tbDatosSeleccionados.Text = selectedRow.Cells(0).Value.ToString & " " & selectedRow.Cells(2).Value.ToString & " " & selectedRow.Cells(3).Value.ToString
                '        ID_MAPA = selectedRow.Cells(0).Value.ToString
                '        '///
                '        If confirmacion.ShowDialog = Windows.Forms.DialogResult.OK Then
                '            Dim ventanaInventarioResultado As New VentanaReporteInventario
                '            ' AddHandler ventanaControlo.btnVerMapa.Click, AddressOf Me.btnVerMapa_Click
                '            '///
                '            Dim listaUbicacionesConRiesgos As New List(Of RiesgoUbicacion)
                '            Dim mapaRiesgoElegido As New Mapa
                '            '/// CABEZAL PLATILLA CONTROL
                '            mapaRiesgoElegido = ConsultoInformacionDelMapaElegido(mapaRiesgoElegido, ID_MAPA, conn, variableDeCambiodeQuery)
                '            planoADibujar = mapaRiesgoElegido
                '            listaFilasDeInventario = ConsultoMapaYHagoControl(mapaRiesgoElegido.mapaID, conn, listaUbicacionesConRiesgos, variableDeCambiodeQuery)
                '            listaRiesgosMandoADibujar = listaUbicacionesConRiesgos
                '            '///
                '            ventanaControlo.tbMapaRiesgoNombre.Text = mapaRiesgoElegido.mapaRiesgoNombre.ToString
                '            '///
                '            ventanaControlo.tbNombreSucursal.Text = ConsultoNombreSucursalPorID(ventanaControlo.tbNombreSucursal.Text, mapaRiesgoElegido.sucursalID, conn)
                '            ventanaControlo.tbMatricula.Text = ConsultoMatriculaPorCedula(ventanaControlo.tbMatricula.Text, mapaRiesgoElegido.empleadoCedula, conn)
                '            '///
                '            ventanaControlo.tbFecha.Text = mapaRiesgoElegido.fecha.ToString
                '            '///
                '            ventanaControlo.lblIDMapaRiesgo.Text = mapaRiesgoElegido.mapaID.ToString
                '            ventanaControlo.lblRutaImagenMapa.Text = mapaRiesgoElegido.planoRutaArchivo.ToString
                '            '///
                '            If listaUbicacionesConRiesgos.Count > 0 Then
                '                For Each ubicacionRiesgo As RiesgoUbicacion In listaUbicacionesConRiesgos
                '                    Dim panelUbicacionesRiesgos As New PanelControlCumplimiento
                '                    '///
                '                    panelUbicacionesRiesgos.TopLevel = False
                '                    '///
                '                    panelUbicacionesRiesgos.tbNombreUbicacion.Text = ubicacionRiesgo.ubicacionNombre.ToString
                '                    panelUbicacionesRiesgos.lblImagenUbicacion.Text = ubicacionRiesgo.riesgoIcono.ToString
                '                    panelUbicacionesRiesgos.lblCoordenadaX.Text = ubicacionRiesgo.coordendaX.ToString
                '                    panelUbicacionesRiesgos.lblCoordenadaY.Text = ubicacionRiesgo.coordenadaY.ToString
                '                    panelUbicacionesRiesgos.lblIncidenciaID.Text = ubicacionRiesgo.ubicacionID.ToString
                '                    panelUbicacionesRiesgos.lblIDRiesgo.Text = ubicacionRiesgo.riesgoID.ToString
                '
                '                    '///
                '
                '                    If ubicacionRiesgo.critico.Equals("S") Then
                '                        panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                '                        panelUbicacionesRiesgos.pictureBoxCritico.Visible = True
                '                    Else
                '                        panelUbicacionesRiesgos.lblRiesgoCritico.Text = ubicacionRiesgo.critico.ToString
                '                        panelUbicacionesRiesgos.pictureBoxCritico.Visible = False
                '                    End If
                '                    '///
                '                    panelUbicacionesRiesgos.tbObservacion.Text = ubicacionRiesgo.descripcion.ToString
                '                    panelUbicacionesRiesgos.tbSugerencia.Text = ubicacionRiesgo.solucion.ToString
                '                    panelUbicacionesRiesgos.tbFechaLimite.Text = ubicacionRiesgo.plazo.ToString
                '                    panelUbicacionesRiesgos.pictureBoxRiesgoImagen.Image = Image.FromFile(ubicacionRiesgo.riesgoIcono)
                '                    ventanaControlo.panelCentral.Controls.Add(panelUbicacionesRiesgos)
                '                    listaPanelUbicacionesConRiesgosParaControlar.Add(panelUbicacionesRiesgos)
                '                    panelUbicacionesRiesgos.radioButonNO.Enabled = False
                '                    panelUbicacionesRiesgos.radioButoSI.Enabled = False
                '                    panelUbicacionesRiesgos.Show()
                '                Next
                '                ventanaControlo.btnValidarControl.Hide()
                '
                '                ventanaControlo.ShowDialog()
                '
                '            End If
                '        End If
                '    End If
                '

        End Select
    End Sub
    Dim estado As Integer = 0
    Private Sub btnMostrarDetalles_Click(ByVal sender As Object, ByVal e As EventArgs)
        '///MAKINA DE ESTADOS EN "ESTADO" PURO
        If estado = 0 Then
            ventanaReporteCuestionario.panelResumen.Hide()
            ventanaReporteCuestionario.btnMostrarDetalles.Text = OcultarDetalles
            ventanaReporteCuestionario.FlowPanelDetalle.AutoScroll = True
            estado = 1
        Else
            ventanaReporteCuestionario.btnMostrarDetalles.Text = MostrarDetalles
            ventanaReporteCuestionario.FlowPanelDetalle.AutoScroll = False
            ventanaReporteCuestionario.panelResumen.Show()
            estado = 0
        End If
    End Sub

    Dim otroEstado As Integer = 0
    Private Sub btnMostrarNotas_Click(ByVal sender As Object, ByVal e As EventArgs)
        If estado = 0 Then
            ventanaReporteCuestionario.panelNotas.Show()
            ventanaReporteCuestionario.btnMostrarNotas.Text = OcultarNotas
            estado = 1
        Else
            ventanaReporteCuestionario.btnMostrarNotas.Text = MostrarNotas
            ventanaReporteCuestionario.panelNotas.Hide()
            estado = 0
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As Object, ByVal e As EventArgs)
        '///
        Dim file As System.IO.StreamWriter
        '///
        Dim condicion As Integer = Int(Double.Parse(ventanaReporteCuestionario.lblAnguloDeGiro.Text))
        If condicion < 36 Then
            estadoSucursal = varRiesgoMuyBajo
        ElseIf condicion > 36 And condicion <= 72 Then
            estadoSucursal = varRiesgoBajo
        ElseIf condicion > 72 And condicion <= 108 Then
            estadoSucursal = varRiesgoModerado
        ElseIf condicion > 108 And condicion <= 144 Then
            estadoSucursal = varRiesgoALto
        ElseIf condicion > 144 Then
            estadoSucursal = vaRiesgoExtremo
        End If
        '///
        file = My.Computer.FileSystem.OpenTextFileWriter("D:\inventario.html", False)
        file.WriteLine("<!DOCTYPE html>")
        file.WriteLine("<html>")
        file.WriteLine("    <head>")
        file.WriteLine("        <meta charset=""utf-8"">")
        file.WriteLine("        <title>" & ventanaReporteCuestionario.lblID_Cuestionario.Text & "</title>")
        file.WriteLine("        <style>")
        file.WriteLine("            * {font-family: Arial, Helvetica, sans-serif;}")
        file.WriteLine("            th, td {padding: 8px;text-align: left;border-bottom: 1px solid #ddd;}")
        file.WriteLine("            table {border-collapse: collapse;width: 80vw; align=""center"">}")
        file.WriteLine("            tr:hover {background-color:#F1F1F1; page-break-inside:avoid; page-break-after:auto}")
        file.WriteLine("            .sc-gauge  { width:200px; height:200px; margin:5% auto }")
        file.WriteLine("            .sc-background { position:relative; height:100px; margin-bottom:10px; background-color:grey; border-radius:150px 150px 0 0; overflow:hidden; text-align:center; }")
        file.WriteLine("            .sc-mask { position:absolute; top:20px; right:20px; left:20px; height:80px; background-color:white; border-radius:150px 150px 0 0 }")
        file.WriteLine("            .sc-percentage { position:absolute; top:100px; left:-200%; width:400%; height:400%; margin-left:100px; background-color:orange; }")
        file.WriteLine("            .sc-percentage { transform:rotate(" & Int(Double.Parse(ventanaReporteCuestionario.lblAnguloDeGiro.Text)) & "deg); transform-origin:top center; }")
        file.WriteLine("        </style>")
        file.WriteLine("    </head>")
        file.WriteLine("    <body>")
        file.WriteLine("        <div>")
        file.WriteLine("            <h2>" & varNombreCuestionario & " " & ventanaReporteCuestionario.tbCuestionarioSeleccionado.Text & "</h2>")
        file.WriteLine("            <h2>" & varNombreSucursal & " " & ventanaReporteCuestionario.tbNombreSucursal.Text & "</h2>")
        file.WriteLine("            <h2>" & varTecnicoResponsable & " " & ventanaReporteCuestionario.tbNombreEmpleado.Text & "</h2>")
        file.WriteLine("            <h3>" & varFecha & " " & ventanaReporteCuestionario.tbFecha.Text & "</h3>")
        file.WriteLine("        </div>")
        file.WriteLine("        <div class=""sc-gauge"">")
        file.WriteLine("            <div class=""sc-background"">")
        file.WriteLine("                <div class=""sc-percentage""></div>")
        file.WriteLine("                <div class=""sc-mask""></div>")
        file.WriteLine("            </div>")
        file.WriteLine("                <h2><center>" & estadoSucursal & "</center></h2>")
        file.WriteLine("        </div>")
        file.WriteLine("        <div style=""overflow-x:80vh;"">")
        file.WriteLine("            <table style=""page-break-inside:auto; margin: auto !important;"">")
        file.WriteLine("                <tr style=""page-break-inside:avoid; page-break-after:auto""> ")
        file.WriteLine("                    <th>" & varPreguntaRealizada & "</th>")
        file.WriteLine("                    <th>" & varAccionSugerida & "</th>")
        file.WriteLine("                    <th>" & varRespuestaObetenida & "</th>")
        file.WriteLine("                    <th>" & varRiesgoDeMuerte & "</th>")
        file.WriteLine("                    <th>" & varGradoExposicion & "</th>")
        file.WriteLine("                    <th>" & varGradoProbabilidad & "</th>")
        file.WriteLine("                    <th>" & varGradoConsecuencia & "</th>")
        file.WriteLine("                </tr>")
        For Each Panel In ListaPanelesDetalle
            If Not Panel.tbPreguntaHecha.Equals("") Then
                file.WriteLine("        <tr>")
                file.WriteLine("            <td>" & Panel.tbPreguntaHecha.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbAccionSugerida.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbRespuestaObetenida.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbRiesgoMuerte.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbNivelExposicion.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbNivelProbabilidad.Text & "</td>")
                file.WriteLine("            <td>" & Panel.tbNivelConsecuencia.Text & "</td>")
                file.WriteLine("        </tr>")
            End If
        Next
        file.WriteLine("            </table>")
        file.WriteLine("        </div>")
        file.WriteLine("    </body>")
        file.WriteLine("</html>")
        file.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.lblSELECTOR.Text.Equals("CONTROL") Then
            variableSeleccion = "CONTROLO Y OBSERVO"
        Else
            variableSeleccion = "MAPAS"
        End If

        Dim listaMapasPendientesEvaluar As New List(Of Mapa)
        listaMapasPendientesEvaluar = ConsultoMapasPendientesDeEvaluacion(listaMapasPendientesEvaluar, conn, variableDeCambiodeQuery)
        If listaMapasPendientesEvaluar.Count > 0 Then

            Dim NOMBRE_SUCURSAL As String = ""

            DataGridView1.Rows.Clear()
            DataGridView1.ColumnCount = 8
            '////
            DataGridView1.Columns(0).Name = varMapaID
            DataGridView1.Columns(0).Visible = False
            '////
            DataGridView1.Columns(1).Name = varSucursalID
            DataGridView1.Columns(1).Visible = False
            '////
            DataGridView1.Columns(2).Name = varSucursalNombre
            DataGridView1.Columns(2).Width = 300
            '////
            DataGridView1.Columns(3).Name = varMapaRiesgoNombre
            DataGridView1.Columns(3).Width = 453
            '////
            DataGridView1.Columns(4).Name = varEmpleadoCedula
            DataGridView1.Columns(4).Width = 90
            '////
            DataGridView1.Columns(5).Name = varFecha
            '////
            DataGridView1.Columns(6).Name = varPlanoRutaArchivo
            DataGridView1.Columns(6).Visible = False
            '////
            DataGridView1.Columns(7).Name = varEstado
            DataGridView1.Columns(7).Visible = False
            '////
            For Each mapa As Mapa In listaMapasPendientesEvaluar
                NOMBRE_SUCURSAL = ConsultoNombreSucursalPorID(NOMBRE_SUCURSAL, mapa.sucursalID, conn)
                Dim row As String() = New String() {mapa.mapaID, mapa.sucursalID, NOMBRE_SUCURSAL, mapa.mapaRiesgoNombre, mapa.empleadoCedula, mapa.fecha, mapa.planoRutaArchivo, mapa.estado}
                DataGridView1.Rows.Add(row)
            Next
            DataGridView1.Refresh()
            '////
        End If

    End Sub

    Private Sub btnReportesCuestionarios_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportesCuestionarios.Click
        cargoLaMovidaDeLosCuestioanrios()
    End Sub

    Private Sub btnVerMapa_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim ventanaDibujoMapa As New VentanaMuestoMapaRiesgoFinalizado
        AddHandler ventanaDibujoMapa.btnExportarReporte.Click, AddressOf Me.btnImprimirMapa_Click

        ventanaDibujoMapa.pictureBoxPlano.Image = Image.FromFile(planoADibujar.planoRutaArchivo.ToString)
        ventanaDibujoMapa.Show()
        For Each riesgoExistente As RiesgoUbicacion In listaRiesgosMandoADibujar
            Dim riesgo As New PictureBox
            riesgo.BackColor = Color.White
            ventanaDibujoMapa.panelPortaPlano.Controls.Add(riesgo)
            riesgo.Location = New Point((Integer.Parse(riesgoExistente.coordendaX)), Integer.Parse(riesgoExistente.coordenadaY))
            riesgo.Image = Image.FromFile(riesgoExistente.riesgoIcono.ToString)
            riesgo.Size = New Size(48, 48)
            riesgo.SizeMode = PictureBoxSizeMode.Zoom
            riesgo.Name = riesgoExistente.ubicacionNombre.ToString
            AddHandler riesgo.MouseEnter, AddressOf Me.Imagen_MouseEnter
            AddHandler riesgo.MouseLeave, AddressOf Me.Imagen_MouseLeave
            riesgo.BringToFront()
            riesgo.Show()
        Next
        ventanaDibujoMapa.Refresh()
    End Sub

    '///TOOL TIP NOMBRE UBICACION MOUSE HOVER
    Dim tipUbicacion As New ToolTip
    Private Sub Imagen_MouseEnter(ByVal sender As PictureBox, ByVal e As EventArgs)
        sender.Size = New Size(96, 96)
        tipUbicacion.Active = True
        tipUbicacion.Show(sender.Name, sender, New Drawing.Point(0, sender.Height - 50))
    End Sub

    Private Sub Imagen_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        sender.Size = New Size(48, 48)
        tipUbicacion.Active = False
    End Sub

    Private Sub btnImprimirMapa_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim file As System.IO.StreamWriter
        '///
        Dim image As Image
        Dim enBase64 As String
        Dim imageArray As Byte()
        Dim base64ImageRepresentation As String
        '///

        Dim rutaDondeGuardar As String = "D:\"
        Dim stringNombreArchivo As String = "mapa_" & planoADibujar.mapaID & "_" & planoADibujar.mapaRiesgoNombre & ".html"
        file = My.Computer.FileSystem.OpenTextFileWriter(rutaDondeGuardar & stringNombreArchivo, False)
        file.WriteLine("<!DOCTYPE html>")
        file.WriteLine("<html>")
        file.WriteLine("    <head>")
        ' file.WriteLine("        <link href=""data:image/x-icon;base64,""" & enBase64 & """rel=""icon"" type=""image/x-icon"" />")
        file.WriteLine("        <meta charset=""utf-8"">")
        file.WriteLine("        <title>" & planoADibujar.mapaID.ToString & "</title>")
        file.WriteLine("        <style>")
        file.WriteLine("            * {font-family: Arial, Helvetica, sans-serif;}")
        file.WriteLine("            th, td {padding: 8px;text-align: left;border-bottom: 1px solid #ddd;}")
        file.WriteLine("            table {border-collapse: collapse;width: 80vw; align=""center"">}")
        file.WriteLine("            tr:hover {background-color:#F1F1F1; page-break-inside:avoid; page-break-after:auto}")
        file.WriteLine("            .center {display: block;margin-left: auto;margin-right: auto;width: 50%;}")
        file.WriteLine("        </style>")
        file.WriteLine("    </head>")
        file.WriteLine("    <body>")
        file.WriteLine("        <div>")
        file.WriteLine("            <h2>" & varNombreMapaRiesgo & " " & planoADibujar.mapaRiesgoNombre.ToString & "</h2>")
        file.WriteLine("            <h2>" & varTecnicoResponsable & " " & planoADibujar.empleadoCedula.ToString & "</h2>")
        file.WriteLine("            <h3>" & varFecha & " " & planoADibujar.fecha.ToString & "</h3>")
        file.WriteLine("        </div>")
        file.WriteLine("        <div class=""sc-gauge"">")
        file.WriteLine("                <div class=""imagenMapa""></div>")
        '///
        '///CON ESTO DESPEGO, QUE HAGO? AGARRO LA RUTA DE LA IMAGEN Y LA DIBUJO TEMPORALMENTE EN UN IMAGE
        'TRASFORMO LA IMAGE A UN STRING DE BASE64, INCRUSTO EL STRING EN HTML Y LE APLICO EL DECODE PARA QUE VUELVA A DIBUJAR LA IMAGEN
        'NADIE LO HIZO JAMAS A ESTO EN EL ITI LE PONGO LA FICHA, DIGA LA VERDAD PROFE JAJA
        image = image.FromFile(planoADibujar.planoRutaArchivo.ToString)
        imageArray = System.IO.File.ReadAllBytes(planoADibujar.planoRutaArchivo.ToString)
        base64ImageRepresentation = Convert.ToBase64String(imageArray)
        '///
        Using ms As New MemoryStream()
            ' Convert Image to byte[]  
            image.Save(ms, image.RawFormat)
            Dim imageBytes As Byte() = ms.ToArray()
            ' Convert byte[] to Base64 String  
            enBase64 = Convert.ToBase64String(imageBytes)
        End Using
        '///
        file.WriteLine("                <img src=""data:image/png;base64," & enBase64 & """alt= Mapa"" class=""center"" style=""position=fixed;"">")
        file.WriteLine("                <div class=""sc-mask""></div>")
        file.WriteLine("                <h2><center>" & estadoSucursal & "</center></h2>")
        file.WriteLine("        </div>")
        file.WriteLine("        <div style=""overflow-x:80vh;"">")
        file.WriteLine("            <table style=""page-break-inside:auto; margin: auto !important;"">")
        file.WriteLine("                <tr style=""page-break-inside:avoid; page-break-after:auto""> ")
        file.WriteLine("                    <th>" & varUbicacionNombre & "</th>")
        file.WriteLine("                    <th>" & varCritico & "</th>")
        file.WriteLine("                    <th>" & varDescripcion & "</th>")
        file.WriteLine("                    <th>" & varSolucion & "</th>")
        file.WriteLine("                    <th>" & varPlazo & "</th>")
        file.WriteLine("                </tr>")
        For Each riesgoObtenido In listaRiesgosMandoADibujar
            If Not riesgoObtenido.Equals("") Then
                file.WriteLine("        <tr>")
                file.WriteLine("            <td>" & riesgoObtenido.ubicacionNombre.ToString & "</td>")
                file.WriteLine("            <td>" & riesgoObtenido.critico.ToString & "</td>")
                file.WriteLine("            <td>" & riesgoObtenido.descripcion.ToString & "</td>")
                file.WriteLine("            <td>" & riesgoObtenido.solucion.ToString & "</td>")
                file.WriteLine("            <td>" & riesgoObtenido.plazo & "</td>")
                file.WriteLine("        </tr>")
            End If
        Next
        file.WriteLine("            </table>")
        file.WriteLine("        </div>")
        file.WriteLine("    </body>")
        file.WriteLine("</html>")
        file.Close()
        '///
    End Sub

    Private Sub btnBuscarConFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarConFiltros.Click
        MessageBox.Show("no implementado aun")
    End Sub



    Private Sub cargoLaMovidaDelosMapas()
        variableSeleccion = "CONTROLO Y OBSERVO"
        Dim listaMapasPendientesEvaluar As New List(Of Mapa)
        variableDeCambiodeQuery = "P"
        listaMapasPendientesEvaluar = ConsultoMapasPendientesDeEvaluacion(listaMapasPendientesEvaluar, conn, variableDeCambiodeQuery)
        If listaMapasPendientesEvaluar.Count > 0 Then

            Dim NOMBRE_SUCURSAL As String = ""

            DataGridView1.Rows.Clear()
            DataGridView1.ColumnCount = 8
            '////
            DataGridView1.Columns(0).Name = varMapaID
            DataGridView1.Columns(0).Visible = False
            '////
            DataGridView1.Columns(1).Name = varSucursalID
            DataGridView1.Columns(1).Visible = False
            '////
            DataGridView1.Columns(2).Name = varSucursalNombre
            DataGridView1.Columns(2).Width = 300
            '////
            DataGridView1.Columns(3).Name = varMapaRiesgoNombre
            DataGridView1.Columns(3).Width = 453
            '////
            DataGridView1.Columns(4).Name = varEmpleadoCedula
            DataGridView1.Columns(4).Width = 90
            '////
            DataGridView1.Columns(5).Name = varFecha
            '////
            DataGridView1.Columns(6).Name = varPlanoRutaArchivo
            DataGridView1.Columns(6).Visible = False
            '////
            DataGridView1.Columns(7).Name = varEstado
            DataGridView1.Columns(7).Visible = False
            '////
            For Each mapa As Mapa In listaMapasPendientesEvaluar
                NOMBRE_SUCURSAL = ConsultoNombreSucursalPorID(NOMBRE_SUCURSAL, mapa.sucursalID, conn)
                Dim row As String() = New String() {mapa.mapaID, mapa.sucursalID, NOMBRE_SUCURSAL, mapa.mapaRiesgoNombre, mapa.empleadoCedula, mapa.fecha, mapa.planoRutaArchivo, mapa.estado}
                DataGridView1.Rows.Add(row)
            Next
            DataGridView1.Refresh()
            '////
        End If

    End Sub

    Private Sub cargoLaMovidaDelosMapasLectura()
        Dim listaMapasTerminados As New List(Of Mapa)
        variableSeleccion = "MAPAS"
        variableDeCambiodeQuery = "T"
        listaMapasTerminados = ConsultoMapasPendientesDeEvaluacion(listaMapasTerminados, conn, variableDeCambiodeQuery)
        If listaMapasTerminados.Count > 0 Then

            Dim NOMBRE_SUCURSAL As String = ""

            DataGridView1.Rows.Clear()
            DataGridView1.ColumnCount = 8
            '////
            DataGridView1.Columns(0).Name = varMapaID
            DataGridView1.Columns(0).Visible = False
            '////
            DataGridView1.Columns(1).Name = varSucursalID
            DataGridView1.Columns(1).Visible = False
            '////
            DataGridView1.Columns(2).Name = varSucursalNombre
            DataGridView1.Columns(2).Width = 300
            '////
            DataGridView1.Columns(3).Name = varMapaRiesgoNombre
            DataGridView1.Columns(3).Width = 453
            '////
            DataGridView1.Columns(4).Name = varEmpleadoCedula
            DataGridView1.Columns(4).Width = 90
            '////
            DataGridView1.Columns(5).Name = varFecha
            '////
            DataGridView1.Columns(6).Name = varPlanoRutaArchivo
            DataGridView1.Columns(6).Visible = False
            '////
            DataGridView1.Columns(7).Name = varEstado
            DataGridView1.Columns(7).Visible = False
            '////
            For Each mapa As Mapa In listaMapasTerminados
                NOMBRE_SUCURSAL = ConsultoNombreSucursalPorID(NOMBRE_SUCURSAL, mapa.sucursalID, conn)
                Dim row As String() = New String() {mapa.mapaID, mapa.sucursalID, NOMBRE_SUCURSAL, mapa.mapaRiesgoNombre, mapa.empleadoCedula, mapa.fecha, mapa.planoRutaArchivo, mapa.estado}
                DataGridView1.Rows.Add(row)
            Next
            DataGridView1.Refresh()
            '////
        End If
    End Sub

    Private Sub btnReportesMapasRiesgo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportesMapasRiesgo.Click
        cargoLaMovidaDelosMapasLectura()
    End Sub

    Private Sub cargoLaMovidaDeLosCuestioanrios()
        variableSeleccion = "CUESTIONARIO"
        Dim listaCuestionarios As New List(Of CueSucEmp)
        DataGridView1.Rows.Clear()
        If String.IsNullOrEmpty(comboListaEmpresas.Text) Then
            listaCuestionarios = consultoCuestionariosNoFiltros(listaCuestionarios, conn)
            DataGridView1.ColumnCount = 9
            '////
            DataGridView1.Columns(0).Name = varIDcuestionario
            DataGridView1.Columns(0).Visible = False
            '////
            DataGridView1.Columns(1).Name = varSucursalID
            DataGridView1.Columns(1).Visible = False
            '////
            DataGridView1.Columns(2).Name = varCuestionarioNombre
            DataGridView1.Columns(2).Width = 400
            '////
            DataGridView1.Columns(3).Name = varEmpresaRut
            '////
            DataGridView1.Columns(4).Name = varSucursalNombre
            DataGridView1.Columns(4).Width = 250
            '////
            DataGridView1.Columns(5).Name = varEmpleadoCedula
            DataGridView1.Columns(5).Visible = False
            '////
            DataGridView1.Columns(6).Name = varEmpleadoNombre
            DataGridView1.Columns(6).Width = 170
            '///
            DataGridView1.Columns(7).Name = varEmpleadoMatricula
            DataGridView1.Columns(7).Width = 120
            '///
            DataGridView1.Columns(8).Name = varCuestionarioFecha
            DataGridView1.Columns(8).Width = 80
            '///
            For Each cuestionarioCustom As CueSucEmp In listaCuestionarios
                Dim row As String() = New String() {cuestionarioCustom.cuestionarioID, cuestionarioCustom.sucursalID, cuestionarioCustom.cuestionarioNombre, cuestionarioCustom.empresaRUT, cuestionarioCustom.sucursalNombre, cuestionarioCustom.empleadoCedula, cuestionarioCustom.empleadoNombre, cuestionarioCustom.matricula, cuestionarioCustom.cuestionarioFecha}
                DataGridView1.Rows.Add(row)
            Next
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub btnReporteInventarios_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteInventarios.Click
        consultoLaMovidaDelosInventarios()
    End Sub

    Private Sub consultoLaMovidaDelosInventarios()
        variableSeleccion = "INVENTARIO"
        Dim listaInventarios As New List(Of Inventario)
        DataGridView1.Rows.Clear()
        If String.IsNullOrEmpty(comboListaEmpresas.Text) Then
            listaInventarios = consultoInventariosNoFiltros(listaInventarios, conn)
            DataGridView1.ColumnCount = 9
            '////
            DataGridView1.Columns(0).Name = varIDcuestionario
            DataGridView1.Columns(0).Visible = False
            '////
            DataGridView1.Columns(1).Name = varSucursalID
            DataGridView1.Columns(1).Visible = False
            '////
            DataGridView1.Columns(2).Name = varCuestionarioNombre
            DataGridView1.Columns(2).Width = 400
            '////
            DataGridView1.Columns(3).Name = varEmpresaRut
            '////
            DataGridView1.Columns(4).Name = varSucursalNombre
            DataGridView1.Columns(4).Width = 250
            '////
            DataGridView1.Columns(5).Name = varEmpleadoCedula
            DataGridView1.Columns(5).Visible = False
            '////
            DataGridView1.Columns(6).Name = varEmpleadoNombre
            DataGridView1.Columns(6).Width = 170
            '///
            DataGridView1.Columns(7).Name = varEmpleadoMatricula
            DataGridView1.Columns(7).Width = 120
            '///
            DataGridView1.Columns(8).Name = varCuestionarioFecha
            DataGridView1.Columns(8).Width = 80
            '///
            For Each inventarioCustom As Inventario In listaInventarios
                Dim row As String() = New String() {inventarioCustom.InventarioID, inventarioCustom.sucursal_id, inventarioCustom.nombreInvetario, inventarioCustom.fecha, _
                                                    inventarioCustom.nota}
                DataGridView1.Rows.Add(row)
            Next
            DataGridView1.Refresh()
        End If
    End Sub

End Class