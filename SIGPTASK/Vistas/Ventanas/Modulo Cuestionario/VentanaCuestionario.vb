Public Class VentanaCuestionario

    Protected preguntaAccion As New PreguntaAccion
    Protected ListPreguntaAccion As New List(Of PreguntaAccion)
    Protected panelSuperpuestoPre As New PanelSuperpuestoPregunta
    Protected panelSuperpuestoAccion As New PanelSuperpuestoAccion
    Private anotacion As String = ""
    Dim varPreguntaID As String = ""
    Dim varPregunta As String = ""
    Dim varRiesgoMuerte As String = ""
    Dim varAccionID As String = ""
    Dim varAccion As String = ""
    Protected preguntaElegida As New Pregunta
    Protected accionElegida As New Accion
    Dim preguntaABuscar As String = ""
    Dim accionABuscar As String = ""
    '////
    Dim preguntaEnMemoria As Boolean = False
    Dim estaCompletamenteSeguroEstaAccionNOsepuedeDesaser As String = ""
    Dim siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar As String = ""

    Private Sub VentanaCuestionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        totalEmpleadosSucursal = tbEmpleadoSucursal.Text
        Me.CenterToScreen()
        btnAgregarNota.Focus()
        Dim regDate As Date = Date.Now()
        Dim fechaCreacion As String = regDate.ToString("dd\/MM\/yyyy")
        tbFecha.Text = fechaCreacion
        '////
        idiomaMesajes()
        muestrotextoInteractivo()
        '////
        panelSuperpuestoPre.TopLevel = False
        panelSuperpuestoAccion.TopLevel = False
        '////
        panelDerechoAccion.Controls.Add(panelSuperpuestoAccion)
        panelSuperpuestoAccion.Show()
        DataGridAcciones.Hide()
        '///
        tbBuscarPregunta.MaxLength = 40
        tbBuscarAccion.MaxLength = 40
    End Sub

    '///DATAGRID PREGUNTAS
    Private Sub refrescoTablaPreguntas()
        DataGridPregunta.Rows.Clear()
        '///
        Dim listaPreguntas As New List(Of Pregunta)
        If tbBuscarPregunta.Text.Equals("Type question or just clic ""Search""") Or tbBuscarPregunta.Text.Equals("Tipea la pregunta o solo cliquea en ""Buscar""") Or preguntaABuscar.Equals("") Then
            listaPreguntas = ConsultoTodasLasPreguntas(listaPreguntas, conn)
        Else
            listaPreguntas = consultoPreguntasPorTexto(listaPreguntas, tbBuscarPregunta.Text, conn)
        End If
        DataGridPregunta.ColumnCount = 3
        '////
        DataGridPregunta.Columns(0).Name = varPreguntaID
        DataGridPregunta.Columns(0).Visible = False
        '////
        DataGridPregunta.Columns(1).Name = varPregunta
        DataGridPregunta.Columns(1).Width = 200
        '////
        DataGridPregunta.Columns(2).Name = varRiesgoMuerte
        DataGridPregunta.Columns(2).Width = 100

        For Each pregunta As Pregunta In listaPreguntas
            '////
            If pregunta.riesgoMuerte.Equals("S") Then
                pregunta.riesgoMuerte = "☠"
            Else
                pregunta.riesgoMuerte = "❤"
            End If
            '////
            Dim row As String() = New String() {pregunta.preguntaID, pregunta.pregunta, pregunta.riesgoMuerte}
            DataGridPregunta.Rows.Add(row)
        Next
        DataGridPregunta.ClearSelection()
        DataGridPregunta.Refresh()
        DataGridPregunta.Show()
    End Sub
    '///DATAGRID ACCIONES
    Private Sub refrescoTablaAcciones()
        DataGridAcciones.Rows.Clear()
        If preguntaEnMemoria = True Then

            DataGridAcciones.Show()
            Dim listaAcciones As New List(Of Accion)
            If tbBuscarAccion.Text.Equals("Type contingency or just clic ""Search""") Or tbBuscarAccion.Text.Equals("Tipea la accion o solo cliquea en ""Buscar""") Or accionABuscar.Equals("") Then
                listaAcciones = ConsultoTodasLasAcciones(listaAcciones, conn)
            Else
                listaAcciones = consultoAccionesPorTexto(listaAcciones, tbBuscarAccion.Text, conn)
            End If
            DataGridAcciones.ColumnCount = 2
            '////
            DataGridAcciones.Columns(0).Name = varAccionID
            DataGridAcciones.Columns(0).Visible = False
            '////
            DataGridAcciones.Columns(1).Name = varAccion
            DataGridAcciones.Columns(1).Width = 200
            '////

            For Each accion As Accion In listaAcciones
                Dim row As String() = New String() {accion.AccionID, accion.Accion}
                DataGridAcciones.Rows.Add(row)
            Next
            DataGridAcciones.ClearSelection()
            DataGridAcciones.Refresh()
            muestrotextoInteractivo()
            preguntaEnMemoria = False
        End If
    End Sub

    '//MANEJO LOS DATAGRIDS
    Private Sub DataGridPregunta_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridPregunta.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridPregunta.Rows(e.RowIndex)
            If selectedRow.Cells(0).Value = Not Equals("") Then
                preguntaElegida.preguntaID = selectedRow.Cells(0).Value.ToString
                preguntaElegida.pregunta = selectedRow.Cells(1).Value.ToString
                preguntaElegida.riesgoMuerte = selectedRow.Cells(2).Value.ToString
                '///
                DataGridPregunta.Hide()
                panelSuperpuestoPre.tbPreguntaSeleccionada.Text = selectedRow.Cells(1).Value.ToString
                panelIzquierdoPre.Controls.Add(panelSuperpuestoPre)
                panelSuperpuestoPre.Show()
                '///
                btnBuscarPregunta.Enabled = False
                btnBuscarAccion.Enabled = True
                '////
                panelSuperpuestoAccion.Hide()
                preguntaEnMemoria = True
                DataGridPregunta.ClearSelection()
                refrescoTablaAcciones()
            End If
        End If
    End Sub

    Private Sub DataGridAcciones_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridAcciones.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridAcciones.Rows(e.RowIndex)
            If selectedRow.Cells(0).Value = Not Equals("") Then
                accionElegida.AccionID = selectedRow.Cells(0).Value.ToString
                accionElegida.Accion = selectedRow.Cells(1).Value.ToString
                '///
                DataGridAcciones.Hide()
                DataGridPregunta.Show()
                panelSuperpuestoPre.tbPreguntaSeleccionada.Text = ""
                panelSuperpuestoPre.Hide()
                panelDerechoAccion.Controls.Add(panelSuperpuestoAccion)
                panelSuperpuestoAccion.Show()
                '////
                btnBuscarAccion.Enabled = False
                btnBuscarPregunta.Enabled = True
                '////
                DataGridAcciones.ClearSelection()
                cargoPanelPreAcc()
                panelSuperpuestoInformacionInicial.Hide()
            End If
        End If
    End Sub
    '//
    Private Sub cargoPanelPreAcc()
        Dim panelPreguntaAccion As New PanelPreguntaAccion
        panelPreguntaAccion.TopLevel = False
        '/////
        panelPreguntaAccion.lblID_pregunta.Text = preguntaElegida.preguntaID.ToString
        panelPreguntaAccion.tbPreguntaAgregada.Text = preguntaElegida.pregunta
        panelPreguntaAccion.lblRiesgoMuerte.Text = preguntaElegida.riesgoMuerte
        panelPreguntaAccion.lblID_Accion.Text = accionElegida.AccionID
        panelPreguntaAccion.tbAccionAgregada.Text = accionElegida.Accion
        '/////////
        If panelPreguntaAccion.lblRiesgoMuerte.Text.Equals("☠") Then
            panelPreguntaAccion.lblRiesgoMuerte.Text = "S"
            panelPreguntaAccion.lblCalavera.Visible = True
            '////
            panelPreguntaAccion.trackbarConsecuencia.Value = 3
            panelPreguntaAccion.trackbarConsecuencia.Enabled = False
        ElseIf panelPreguntaAccion.lblRiesgoMuerte.Text.Equals("❤") Then
            panelPreguntaAccion.lblRiesgoMuerte.Text = "N"
        End If
        '/////////
        panelCentralPA.Controls.Add(panelPreguntaAccion)
        panelCentralPA.Anchor = AnchorStyles.Right
        panelPreguntaAccion.Show()
    End Sub

    '//////////DESACTIVO BOTON
    Private Sub panelCentralPA_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelCentralPA.Paint
        If tbNombreCuestionario.Text.Length > 0 And panelCentralPA.HasChildren Then
            btnEvaluar.Enabled = True
            btnGuardarCuestionario.Enabled = True
        Else
            btnEvaluar.Enabled = False
            btnGuardarCuestionario.Enabled = False
        End If
    End Sub

    Private Sub btnAgregarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarNota.Click
        Dim vAgregarNota As New VentanaAgregarNota
        vAgregarNota.tbAnotaciones.Text = anotacion
        vAgregarNota.tbAnotaciones.Focus()
        vAgregarNota.tbAnotaciones.Select(vAgregarNota.tbAnotaciones.Text.Length, 0)
        vAgregarNota.tbAnotaciones.Refresh()
        If vAgregarNota.ShowDialog() = Windows.Forms.DialogResult.OK Then
            anotacion = vAgregarNota.tbAnotaciones.Text
        End If
    End Sub

    Private Sub tbNombreCuestionario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNombreCuestionario.TextChanged
        If tbNombreCuestionario.Text.Length <= 0 Then
            MessageBox.Show(noGuardaOCalculaSinTitulo)
            btnEvaluar.Enabled = False
            btnGuardarCuestionario.Enabled = False
            panelCentralPA.Refresh()
        Else
            panelCentralPA.Refresh()
        End If
    End Sub

    Private Sub btnAgregarPregunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPregunta.Click
        Dim ventanaAgregoPregunta As New VentanaCargarPregunta
        If ventanaAgregoPregunta.ShowDialog() = Windows.Forms.DialogResult.OK Then
            refrescoTablaPreguntas()
        End If
    End Sub

    Private Sub btnAgregarAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAccion.Click
        Dim ventanaAgregoAccion As New VentanaCargoAccion
        If ventanaAgregoAccion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            refrescoTablaAcciones()
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvaluar.Click

        Dim ventanaConfirmacion As New VentanaConfimracionGenerica
        ventanaConfirmacion.lblPreguntaOMensajeGenerico.Text = estaCompletamenteSeguroEstaAccionNOsepuedeDesaser
        ventanaConfirmacion.tbDatosSeleccionados.Text = siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar
        
        If ventanaConfirmacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim cuestionario As New Cuestionario
            Dim id_Cuestionario_ingresado As String = ""
            Dim estado As Boolean = False
            cuestionario.sucursalID = lblID_sucursal.Text
            cuestionario.empleadoCedula = tbCedulaEmpleado.Text
            cuestionario.cuestionarioNombre = tbNombreCuestionario.Text
            cuestionario.cuestionarioNota = anotacion.ToString
            '///////////
            Dim formattedDate As String = Date.Today.ToString(stringfechaFormatoSalidaInformix)
            cuestionario.cuestionarioFecha = formattedDate
            '//////////
            cuestionario.cuestionarioEstado = "T"
            id_Cuestionario_ingresado = AgregoCuestionario(cuestionario, id_Cuestionario_ingresado, conn)

            For Each panelPreguntaAccion As PanelPreguntaAccion In panelCentralPA.Controls
                '//////////////
                preguntaAccion.cuestionario_ID = id_Cuestionario_ingresado
                preguntaAccion.preguntaID = panelPreguntaAccion.lblID_pregunta.Text
                preguntaAccion.pregunta = panelPreguntaAccion.tbPreguntaAgregada.Text
                preguntaAccion.AccionID = panelPreguntaAccion.lblID_Accion.Text
                preguntaAccion.Accion = panelPreguntaAccion.tbAccionAgregada.Text
                preguntaAccion.riesgoMuerte = panelPreguntaAccion.lblRiesgoMuerte.Text
                '////EXPOSICION
                If panelPreguntaAccion.trackBarExpocision.Value = 0 Then
                    preguntaAccion.valorExposicion = 1
                ElseIf panelPreguntaAccion.trackBarExpocision.Value = 1 Then
                    preguntaAccion.valorExposicion = 2
                ElseIf panelPreguntaAccion.trackBarExpocision.Value = 2 Then
                    preguntaAccion.valorExposicion = 6
                ElseIf panelPreguntaAccion.trackBarExpocision.Value = 3 Then
                    preguntaAccion.valorExposicion = 10
                End If
                '////PROBABILIDAD
                If panelPreguntaAccion.trackbarProbabilidad.Value = 0 Then
                    preguntaAccion.valorProvabilidad = 1
                ElseIf panelPreguntaAccion.trackbarProbabilidad.Value = 1 Then
                    preguntaAccion.valorProvabilidad = 4
                ElseIf panelPreguntaAccion.trackbarProbabilidad.Value = 2 Then
                    preguntaAccion.valorProvabilidad = 7
                ElseIf panelPreguntaAccion.trackbarProbabilidad.Value = 3 Then
                    preguntaAccion.valorProvabilidad = 10
                End If
                '////CONCECUENCIA
                If panelPreguntaAccion.trackbarConsecuencia.Value = 0 Then
                    preguntaAccion.valorConsecuencia = 1
                ElseIf panelPreguntaAccion.trackbarConsecuencia.Value = 1 Then
                    preguntaAccion.valorConsecuencia = 4
                ElseIf panelPreguntaAccion.trackbarConsecuencia.Value = 2 Then
                    preguntaAccion.valorConsecuencia = 6
                ElseIf panelPreguntaAccion.trackbarConsecuencia.Value = 3 Then
                    preguntaAccion.valorConsecuencia = 10
                End If
                '////////////////////
                Dim respuesta As String
                If panelPreguntaAccion.rdbSI.Checked Then
                    respuesta = "S"
                Else
                    respuesta = "N"
                End If
                preguntaAccion.respuesta = respuesta
                '////////////////////
                If panelPreguntaAccion.tbPersonasExpuestas.Text.Equals("") Then
                    preguntaAccion.personasExpustas = 0
                Else
                    preguntaAccion.personasExpustas = panelPreguntaAccion.tbPersonasExpuestas.Text
                End If
                '////////////////////
                estado = AgregoIncidenciasCuestionario(preguntaAccion, conn, estado)
            Next
            If estado = True Then
                MessageBox.Show(generandoReporte)
                Me.Dispose()
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

    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblEmpresaElegida.Text = "Selected Company"
            lblTotalEmpleadosSucursal.Text = "| Workers amount"
            lblFecha.Text = "Date"
            lblNombreCuestionario.Text = "Questionary Name"
            lblCedulaEmpleado.Text = "| Employee ID"
            lblMatricula.Text = "| Register ID"
            lblBuscarPregunta.Text = "Find question's"
            btnBuscarPregunta.Text = "Search"
            lblBuscarAccion.Text = "Find Contingencies"
            btnBuscarAccion.Text = "Search"
            btnGuardarCuestionario.Text = "Save"
            btnAgregarPregunta.Text = "New Question"
            btnAgregarNota.Text = "Add note"
            btnAgregarAccion.Text = "New Contingency"
            btnEvaluar.Text = "Evaluate"
            '///
        End If
        estaCompletamenteSeguroEstaAccionNOsepuedeDesaser = lenguaje.estaCompletamenteSeguroEstaAccionNOsepuedeDesaser(estaCompletamenteSeguroEstaAccionNOsepuedeDesaser)
        siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar = lenguaje.siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar(siconfirmaEstaVentanaDaraeLAltaAlcuestionarioContinuar)
        varPreguntaID = lenguaje.varPreguntaID(varPreguntaID)
        varPregunta = lenguaje.varPregunta(varPregunta)
        varRiesgoMuerte = lenguaje.varRiesgoMuerte(varRiesgoMuerte)
        varAccionID = lenguaje.varAccionID(varAccionID)
        varAccion = lenguaje.varAccion(varAccion)
    End Sub

    Private Sub btnBuscarPregunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPregunta.Click
        refrescoTablaPreguntas()
        muestrotextoInteractivo()
    End Sub

    Private Sub btnBuscarAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAccion.Click
        refrescoTablaAcciones()
        muestrotextoInteractivo()
    End Sub

    Private Sub tbBuscarPregunta_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbBuscarPregunta.MouseClick
        tbBuscarPregunta.Text = ""
        tbBuscarPregunta.ForeColor = Color.Black
    End Sub

    Private Sub tbBuscarAccion_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbBuscarAccion.MouseClick
        tbBuscarAccion.Text = ""
        tbBuscarAccion.ForeColor = Color.Black
    End Sub

    Private Sub muestrotextoInteractivo()
        tbBuscarPregunta.ForeColor = Color.DimGray
        tbBuscarAccion.ForeColor = Color.DimGray
        '////
        If idiomaSeleccionado.Equals("ING") Then
            tbBuscarPregunta.Text = "Type question or just clic ""Search"""
            tbBuscarAccion.Text = "Type contingency or just clic ""Search"""
        Else
            tbBuscarPregunta.Text = "Tipea la pregunta o solo cliquea en ""Buscar"""
            tbBuscarAccion.Text = "Tipea la accion o solo cliquea en ""Buscar"""
        End If
    End Sub

    Private Sub tbBuscarPregunta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBuscarPregunta.TextChanged
        preguntaABuscar = tbBuscarPregunta.Text
    End Sub

    Private Sub tbBuscarAccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBuscarAccion.TextChanged
        accionABuscar = tbBuscarAccion.Text
    End Sub

    Private Sub btnBuscarPregunta_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPregunta.EnabledChanged
        If btnBuscarPregunta.Enabled = False Then
            tbBuscarPregunta.ReadOnly = True
            tbBuscarPregunta.Enabled = False
        Else
            tbBuscarPregunta.ReadOnly = False
            tbBuscarPregunta.Enabled = True
        End If
    End Sub

    Private Sub btnBuscarAccion_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAccion.EnabledChanged
        If btnBuscarAccion.Enabled = False Then
            tbBuscarAccion.ReadOnly = True
            tbBuscarAccion.Enabled = False
        Else
            tbBuscarAccion.ReadOnly = False
            tbBuscarAccion.Enabled = True
        End If
    End Sub

End Class