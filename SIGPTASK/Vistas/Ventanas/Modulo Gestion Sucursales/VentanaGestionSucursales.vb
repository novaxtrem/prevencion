Public Class VentanaGestionSucursales
    Dim ventanaFullSize = New Size(860, 345)
    Dim vetanaMinSize = New Size(860, 345)

    Dim varEmpresaRut As String = ""
    Dim varSucursalID As String = ""
    Dim varEmpresaNombre As String = ""
    Dim varSucursalNombre As String = ""
    Dim varSucursalDireccion As String = ""
    Dim varSucursalTelefono As String = ""
    Dim varEmpresaEstado As String = ""
    Dim varEmpresaTotalEmpleados As String = ""
    '///
    Dim empresa As New Sucursal
    '///
    Dim variableDeSeleccion As String = ""
    '///
    Dim avisado As Boolean = False
    Dim esEmpresaNueva As Boolean = False
    '///
    Dim empresaNOMBRE_ORIGEN As String = ""
    Dim empresaNOMBRE_SUCURSAL_ORIGEN As String = ""
    Dim empresaDIRECCION_SUCURSAL_ORIGEN As String = ""
    Dim empresaTELEFONO_ORIGEN As String = ""
    Dim empresaEMPLEADOS_SUCURSAL As Integer = 0
    '///
    Dim empresaEditadaCorrectamente As String = ""
    Dim sucursalEditadaCorrectamente As String = ""
    Dim haOcurridoUnProblemaContacteASistemas As String = ""
    Dim atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales As String = ""
    '///
    Dim varCasaCentral As String = ""
    Dim correcto As String = ""
    Dim debeCompletarLaInformacionParaAgregarLaEmpresa As String = ""
    '///
    Dim elRutNoPuedeEstarEnblanco As String = ""
    Dim elNombreDeLaEmpresaNoPuedeEstarEnBlanco As String = ""
    Dim elNombredeLaSucursalNopuedeEstarEnBlanco As String = ""
    Dim laDireccionNoPuedeEstarEnBlanco As String = ""
    Dim IngreseLacantidadDeEmpleados As String = ""
    '///VALIDACIONES    
    Dim validoNombreEmpresa As Boolean = False
    Dim validoRUTEmpresa As Boolean = False
    Dim validoNombreSucursal As Boolean = False
    Dim validoDireccion As Boolean = False
    Dim validoEmpleados As Boolean = False
    '///
    Dim solonumeros As String = ""
    Dim numeroExcedemaximo As String = ""

    Private Sub btnAgregarEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEmpresa.Click
        esEmpresaNueva = True
        variableDeSeleccion = "NUEVA EMPRESA"
        If Me.Size <> ventanaFullSize Then
            Me.Size = ventanaFullSize
        End If
        '///
        DataGridEmpresas.Visible = False
        panelDetallesEmpresa.Visible = True
        panelContenedor.Visible = True
        '///
        tbEmpresaRut.ReadOnly = False


        Me.CenterToScreen()

    End Sub

    Private Sub VentanaAgregarEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        maximocampos()
        todoaMayuscula()
        idiomaMesajes()
    End Sub

    Private Sub tbEmpresaRut_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEmpresaRut.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                tbEmpresaRut.Text = "solo numeros"
                tbEmpresaRut.Refresh()
                Threading.Thread.Sleep(100)
                tbEmpresaRut.Text = ""
            End If
        End If
    End Sub


    'VALIDACION CAMPOS
    'VALIDO TELEFONO
    Private Sub tbTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTelefono.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                tbTelefono.Text = solonumeros
                tbTelefono.Refresh()
                Threading.Thread.Sleep(80)
                tbTelefono.Clear()
                e.Handled = True
            Else
                If ((Not tbTelefono.Text.Equals("")) AndAlso (Int64.Parse(tbTelefono.Text) > 2147483647)) Then
                    tbTelefono.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    'VALIDO NUMERO EMPLEADOS
    Private Sub tbEmpleadosSucursal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEmpleadosSucursal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                tbEmpleadosSucursal.Text = solonumeros
                tbEmpleadosSucursal.Refresh()
                Threading.Thread.Sleep(80)
                tbEmpleadosSucursal.Clear()
                e.Handled = True
            Else
                If ((Not tbEmpleadosSucursal.Text.Equals("")) AndAlso (Int64.Parse(tbEmpleadosSucursal.Text) > 2147483647)) Then
                    tbEmpleadosSucursal.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        limpioTextboxes()
        Dim listaSucursales As New List(Of Sucursal)
        DataGridEmpresas.Rows.Clear()
        Me.CenterToScreen()
        '////
        If Me.Size <> ventanaFullSize Then
            Me.Size = ventanaFullSize
            Me.CenterToScreen()
        End If
        If DataGridEmpresas.Visible = False Then
            DataGridEmpresas.Visible = True
        End If

        panelContenedor.Visible = True
        '///
        If tbBuscarEmpresa.Text.Equals("") Then
            listaSucursales = ConsultoTodasLasSucursales(listaSucursales, conn)
        ElseIf IsNumeric(tbBuscarEmpresa.Text) = True Then
            listaSucursales = consultoSucursalesPorRUT(listaSucursales, conn, tbBuscarEmpresa.Text)
        Else
            listaSucursales = consultoEmpresaPorNombre(listaSucursales, tbBuscarEmpresa.Text, conn)
        End If
        '////
        DataGridEmpresas.ColumnCount = 8
        '////
        DataGridEmpresas.Columns(0).Name = varSucursalID
        DataGridEmpresas.Columns(0).Visible = False
        '////
        DataGridEmpresas.Columns(1).Name = varEmpresaRut
        '////
        DataGridEmpresas.Columns(2).Name = varEmpresaNombre
        DataGridEmpresas.Columns(2).Width = 268
        '////
        DataGridEmpresas.Columns(3).Name = varSucursalNombre
        DataGridEmpresas.Columns(3).Width = 270
        '////
        DataGridEmpresas.Columns(4).Name = varSucursalDireccion
        DataGridEmpresas.Columns(4).Visible = True
        '////
        DataGridEmpresas.Columns(5).Name = varSucursalTelefono
        DataGridEmpresas.Columns(5).Visible = True
        '////
        DataGridEmpresas.Columns(6).Name = varEmpresaEstado
        DataGridEmpresas.Columns(6).Visible = False
        '////
        DataGridEmpresas.Columns(7).Name = varEmpresaTotalEmpleados
        DataGridEmpresas.Columns(7).Width = 60
        '////
        For Each empresa As Sucursal In listaSucursales
            Dim row As String() = New String() {empresa.sucursalID, empresa.empresaRUT, empresa.empresaNombre, empresa.sucursalNombre, empresa.sucursalDireccion, empresa.telefono, empresa.estado, empresa.totalEmpleadosSucursal}
            DataGridEmpresas.Rows.Add(row)
        Next
        DataGridEmpresas.ClearSelection()
        DataGridEmpresas.Refresh()
        '////
        tbBuscarEmpresa.Text = ""
    End Sub

    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            lblConsultarEmpresa.Text = "Search Company"
            lblEmpresaNombre.Text = "Company name"
            lblEmpresaNombre.Location = New Point(40, 50)
            lblSucursalNombre.Text = "Subsidiary name"
            lblSucursalNombre.Location = New Point(35, 80)
            lblSucursalDireccion.Text = "Subsidiary address"
            lblTelefono.Text = "Phone"
            lblTelefono.Location = New Point(95, 162)
            lblEmpleadosSucursal.Text = "Subisidiary employees"
            lblEmpleadosSucursal.Location = New Point(335, 162)
            btnAgregarEmpresa.Text = "Add Company / Subsidiary"
            '///
            btnBuscar.Text = "Search"
            btnEditarSucursal.Text = "Edit Company / Subsidiary"
            btnEliminar.Text = "Delete Company / Subsidiary"
            chekCasaCentral.Text = "Main House"
            btnAceptar.Text = "Acept"
            btnCancelar.Text = "Cancel"
        Else

        End If
        varEmpresaRut = lenguaje.varEmpresaRut(varEmpresaRut)
        varEmpresaNombre = lenguaje.varEmpresaNombre(varEmpresaNombre)
        varSucursalNombre = lenguaje.varSucursalNombre(varSucursalNombre)
        varSucursalDireccion = lenguaje.varSucursalDireccion(varSucursalDireccion)
        varSucursalTelefono = lenguaje.varSucursalTelefono(varSucursalTelefono)
        varEmpresaEstado = lenguaje.varEmpresaEstado(varEmpresaEstado)
        varEmpresaTotalEmpleados = lenguaje.varEmpresaTotalEmpleados(varEmpresaTotalEmpleados)
        atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales = lenguaje.atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales(atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales)
        sucursalEditadaCorrectamente = lenguaje.sucursalEditadaCorrectamente(sucursalEditadaCorrectamente)
        empresaEditadaCorrectamente = lenguaje.empresaEditadaCorrectamente(empresaEditadaCorrectamente)

        '///
        elRutNoPuedeEstarEnblanco = lenguaje.elRutNoPuedeEstarEnblanco(elRutNoPuedeEstarEnblanco)
        elNombreDeLaEmpresaNoPuedeEstarEnBlanco = lenguaje.elNombreDeLaEmpresaNoPuedeEstarEnBlanco(elNombreDeLaEmpresaNoPuedeEstarEnBlanco)
        elNombredeLaSucursalNopuedeEstarEnBlanco = lenguaje.elNombredeLaSucursalNopuedeEstarEnBlanco(elNombredeLaSucursalNopuedeEstarEnBlanco)
        laDireccionNoPuedeEstarEnBlanco = lenguaje.laDireccionNoPuedeEstarEnBlanco(laDireccionNoPuedeEstarEnBlanco)
        IngreseLacantidadDeEmpleados = lenguaje.IngreseLacantidadDeEmpleados(IngreseLacantidadDeEmpleados)
        '////
        correcto = lenguaje.correcto(correcto)
        debeCompletarLaInformacionParaAgregarLaEmpresa = lenguaje.debeCompletarLaInformacionParaAgregarLaEmpresa(debeCompletarLaInformacionParaAgregarLaEmpresa)
        solonumeros = lenguaje.solonumeros(solonumeros)
        numeroExcedemaximo = lenguaje.numeroExcedemaximo(numeroExcedemaximo)
        '///
        varCasaCentral = lenguaje.varCasaCentral(varCasaCentral)
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridEmpresas.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridEmpresas.Rows(e.RowIndex)
            empresa.sucursalID = selectedRow.Cells(0).Value.ToString
            empresa.empresaRUT = selectedRow.Cells(1).Value.ToString
            empresa.empresaNombre = selectedRow.Cells(2).Value.ToString
            empresa.sucursalNombre = selectedRow.Cells(3).Value.ToString
            empresa.sucursalDireccion = selectedRow.Cells(4).Value.ToString
            empresa.telefono = selectedRow.Cells(5).Value.ToString
            empresa.estado = selectedRow.Cells(6).Value.ToString
            empresa.totalEmpleadosSucursal = selectedRow.Cells(7).Value.ToString
            '///
            btnEditarSucursal.Enabled = True
            btnEliminar.Enabled = True
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


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Select Case variableDeSeleccion
            Case "ACTUALIZAR"
                If tbEmpresaNombre.Text.Equals(empresaNOMBRE_ORIGEN) Then
                    Dim estadoEdicion As Boolean = False
                    Dim empresaEditada As New Sucursal
                    empresaEditada.empresaRUT = tbEmpresaRut.Text
                    empresaEditada.sucursalID = lblSucursal_id.Text
                    empresaEditada.empresaNombre = tbEmpresaNombre.Text
                    empresaEditada.sucursalNombre = tbSucursalNombre.Text
                    empresaEditada.sucursalDireccion = tbSucursalDireccion.Text
                    empresaEditada.telefono = tbTelefono.Text
                    empresaEditada.totalEmpleadosSucursal = tbEmpleadosSucursal.Text
                    '///
                    estadoEdicion = actualizoCamposSucursal(empresaEditada, estadoEdicion, conn)
                    limpioCampos()
                    If estadoEdicion = True Then
                        MessageBox.Show(sucursalEditadaCorrectamente)
                        If Me.Size <> vetanaMinSize Then
                            Me.Size = vetanaMinSize
                            Me.CenterToScreen()
                        End If
                        limpioCampos()
                    Else
                        MessageBox.Show(haOcurridoUnProblemaContacteASistemas)
                        limpioCampos()
                    End If
                Else
                    Dim estadoEdicion As Boolean = False
                    Dim empresaEditada As New Sucursal
                    empresaEditada.empresaRUT = tbEmpresaRut.Text
                    empresaEditada.sucursalID = lblSucursal_id.Text
                    empresaEditada.empresaNombre = tbEmpresaNombre.Text
                    empresaEditada.sucursalNombre = tbSucursalNombre.Text
                    empresaEditada.sucursalDireccion = tbSucursalDireccion.Text
                    empresaEditada.telefono = tbTelefono.Text
                    empresaEditada.totalEmpleadosSucursal = tbEmpleadosSucursal.Text
                    '///
                    estadoEdicion = actualizoNombreDeEmpresaParaTodasLasSucursalesConMismoRUT(empresaEditada, estadoEdicion, conn)
                    estadoEdicion = actualizoCamposSucursal(empresaEditada, estadoEdicion, conn)
                    limpioCampos()
                    If estadoEdicion = True Then
                        MessageBox.Show(empresaEditadaCorrectamente)
                        limpioCampos()
                    Else
                        MessageBox.Show(haOcurridoUnProblemaContacteASistemas)
                        limpioCampos()
                    End If

                End If
            Case "NUEVA EMPRESA"

                If (validoRUTEmpresa = True AndAlso validoNombreEmpresa = True AndAlso validoRUTEmpresa = True AndAlso validoNombreSucursal = True AndAlso validoDireccion = True AndAlso validoEmpleados = True) Then
                    Dim empresaNueva As New Sucursal
                    Dim ok As Boolean = True
                    Dim estado As Boolean = False
                    empresaNueva.empresaNombre = tbEmpresaNombre.Text.ToLower
                    empresaNueva.empresaRUT = tbEmpresaRut.Text
                    empresaNueva.sucursalNombre = tbSucursalNombre.Text.ToLower
                    empresaNueva.sucursalDireccion = tbSucursalDireccion.Text
                    If tbTelefono.Text.Equals("") Then
                        empresaNueva.telefono = 0
                    Else
                        empresaNueva.telefono = tbTelefono.Text
                    End If

                    empresaNueva.totalEmpleadosSucursal = tbEmpleadosSucursal.Text
                    '///
                    empresaNueva.estado = "A"
                    estado = AgregoEmpresaNueva(empresaNueva, conn, estado)
                    If estado = True Then
                        MessageBox.Show(correcto)
                        Me.Dispose()
                    Else
                        MessageBox.Show(haOcurridoUnProblemaContacteASistemas)
                    End If
                Else
                    MessageBox.Show(debeCompletarLaInformacionParaAgregarLaEmpresa)
                End If
        End Select
    End Sub

    Private Sub btnEditarSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarSucursal.Click
        variableDeSeleccion = "ACTUALIZAR"
        avisado = False

        If Me.Size <> ventanaFullSize Then
            Me.Size = New Size(ventanaFullSize)
        End If
        If tbEmpresaRut.ReadOnly = False Then
            tbEmpresaRut.ReadOnly = True
        End If

        If Not empresa.sucursalID.Equals("") Then
            lblSucursal_id.Text = empresa.sucursalID
            '///
            tbEmpresaRut.Text = empresa.empresaRUT
            tbEmpresaNombre.Text = empresa.empresaNombre
            tbSucursalNombre.Text = empresa.sucursalNombre
            tbSucursalDireccion.Text = empresa.sucursalDireccion
            tbTelefono.Text = empresa.telefono
            tbEmpleadosSucursal.Text = empresa.totalEmpleadosSucursal
            '///
            empresaNOMBRE_ORIGEN = empresa.empresaNombre
            '///
            panelDetallesEmpresa.Visible = True
            DataGridEmpresas.Hide()
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim ventanaConfirmarBorrado As New VentanaConfirmacionBorrado
        ventanaConfirmarBorrado.lblUSUARIO_CONECTADO.Text = lblUsuarioCOnectado.Text
        ventanaConfirmarBorrado.lblID_SUCURSAL_BORRAR.Text = empresa.sucursalID
        ventanaConfirmarBorrado.lblRUT_BORRAR.Text = empresa.empresaRUT
        ventanaConfirmarBorrado.ShowDialog()
    End Sub

    Private Sub tbEmpresaNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEmpresaNombre.KeyPress
        If avisado = False AndAlso esEmpresaNueva = False Then
            MessageBox.Show(atencionSeActualizaraElNombreDeEmpresaParaTodasLasSucursales)
            avisado = True
        End If
    End Sub

    Private Sub limpioCampos()

        varEmpresaRut = ""
        varSucursalID = ""
        varEmpresaNombre = ""
        varSucursalNombre = ""
        varSucursalDireccion = ""
        varSucursalTelefono = ""
        varEmpresaEstado = ""
        varEmpresaTotalEmpleados = ""
        empresaNOMBRE_ORIGEN = ""
        empresaNOMBRE_SUCURSAL_ORIGEN = ""
        empresaDIRECCION_SUCURSAL_ORIGEN = ""
        empresaTELEFONO_ORIGEN = 0
        empresaEMPLEADOS_SUCURSAL = 0
        '////
        limpioTextboxes()
        '////

    End Sub

    Private Sub maximocampos()
        tbBuscarEmpresa.MaxLength = varCaracteresMaximoTextBoxBuscarEmpresa
        tbEmpresaRut.MaxLength = varCaracteresMaximoRUT
        tbEmpresaNombre.MaxLength = varCaracteresMaximoNombreEmppresa
        tbSucursalNombre.MaxLength = varCaracteresMaximoSucursalNombre
        tbSucursalDireccion.MaxLength = varCaracteresMaximoSucursalDireccion
        tbTelefono.MaxLength = varCaracteresMaximoTelefono
        tbEmpleadosSucursal.MaxLength = varCaracteresMaximoEmpleadosSucursal
    End Sub

    Private Sub todoaMayuscula()
        tbBuscarEmpresa.Text.ToUpper()
        tbEmpresaRut.Text.ToUpper()
        tbEmpresaNombre.Text.ToUpper()
        tbSucursalNombre.Text.ToUpper()
        tbSucursalDireccion.Text.ToUpper()
        tbTelefono.Text.ToUpper()
        tbEmpleadosSucursal.Text.ToUpper()
    End Sub

    Private Sub limpioTextboxes()
        '///
        lblSucursal_id.Text = ""
        '///
        tbEmpresaRut.Text = ""
        tbEmpresaNombre.Text = ""
        tbSucursalNombre.Text = ""
        tbSucursalDireccion.Text = ""
        tbTelefono.Text = ""
        tbEmpleadosSucursal.Text = ""
    End Sub

    Private Sub chekCasaCentral_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chekCasaCentral.CheckStateChanged
        If chekCasaCentral.Checked Then
            tbSucursalNombre.Text = varCasaCentral
        Else
            tbSucursalNombre.Text = ""
        End If
    End Sub


    Private Sub tbEmpresaRut_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpresaRut.Leave
        If tbEmpresaRut.Text.Equals("") Then
            MessageBox.Show(elRutNoPuedeEstarEnblanco)
            validoRUTEmpresa = False
        Else
            validoRUTEmpresa = True
        End If
    End Sub

    Private Sub tbEmpresaNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpresaNombre.Leave
        If tbEmpresaNombre.Text.Equals("") Then
            MessageBox.Show(elNombreDeLaEmpresaNoPuedeEstarEnBlanco)
            validoNombreEmpresa = False
        Else
            validoNombreEmpresa = True
        End If
    End Sub
    '///////VALIDACION SUCURSAL 
    Dim enBlanco As Boolean = False

    Private Sub tbSucursalNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSucursalNombre.Leave
        If tbSucursalNombre.Text.Equals("") Then
            enBlanco = True
            validoNombreSucursal = False
        Else
            validoNombreSucursal = True
        End If
    End Sub

    Private Sub chekCasaCentral_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chekCasaCentral.Leave
        If enBlanco = True Then
            MessageBox.Show(elNombredeLaSucursalNopuedeEstarEnBlanco)
        Else
            enBlanco = False
        End If
    End Sub
    '///////

    Private Sub tbSucursalDireccion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSucursalDireccion.Leave
        If tbSucursalDireccion.Text.Equals("") Then
            MessageBox.Show(laDireccionNoPuedeEstarEnBlanco)
            validoDireccion = False
        Else
            validoDireccion = True
        End If
    End Sub

    Private Sub tbEmpleadosSucursal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpleadosSucursal.Leave
        If tbEmpleadosSucursal.Text.Equals("") Then
            MessageBox.Show(IngreseLacantidadDeEmpleados)
            validoEmpleados = False
        Else
            validoEmpleados = True
        End If
    End Sub
  
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

End Class