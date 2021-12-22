Public Class VentanaCuestiInvenMapa

    Dim preguntas As String
    Dim sucursalID As String
    Dim sucursalNombre As String
    Dim empresaNombre As String
    Dim empresa As New Sucursal
    '//////
    Dim varEmpresaRut As String = ""
    Dim varEmpresaNombre As String = ""
    Dim varSucursalNombre As String = ""
    Dim varSucursalDireccion As String = ""
    Dim varSucursalTelefono As String = ""
    Dim varEmpresaEstado As String = ""
    Dim varEmpresaTotalEmpleados As String = ""
    Dim empresaSeleccionada As String = ""
    Dim variableSeleccion As String = ""
    '///
    Dim seleccionoEmpresa As Boolean = False
    '///
    Dim confirmaSeleccionEmpresa As String = ""
    '//////
    Dim confirmado As Boolean = False

    Private Sub VenatanaNuevoMapaRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idiomaMesajes()
        tbBuscarEmpresa.MaxLength = 70
        tbNombreDelCoso.MaxLength = 70
        Me.CenterToScreen()
    End Sub

    Private Sub btnNuevoMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoMapa.Click
        variableSeleccion = "MAPA" '//esta validacion esta demas, pero ta..hagamos de cuenta que es onda "Test-driven development"
        If Not variableSeleccion.Equals("") Then '//y hagamos de cuenta que esto son pseudo unit tests
            confirmo()
            If confirmado = True Then
                If variableSeleccion.Equals("MAPA") Then
                    Dim ventanaMapa As New VentanaMapaRiesgo
                    '////CARGO DATOS CABEZAL MAPA
                    ventanaMapa.tbCedulaEmpleado.Text = cedulaUsuarioConectado
                    ventanaMapa.lblID_SucursalElegida.Text = empresa.sucursalID.ToString
                    ventanaMapa.tbEmpresaSeleccionada.Text = empresa.empresaRUT.ToString & " | " & empresa.empresaNombre.ToString & " | " & empresa.sucursalNombre
                    ventanaMapa.tbMapaRiesgoNombre.Text = tbNombreDelCoso.Text
                    ventanaMapa.tbMatricula.Text = matricula.ToString
                    '////
                    ventanaMapa.ShowDialog()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevoCuestionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCuestionario.Click
        variableSeleccion = "CUESTIONARIO"
        If Not variableSeleccion.Equals("") Then
            confirmo()
            If confirmado = True Then
                If variableSeleccion.Equals("CUESTIONARIO") Then
                    Dim ventanaCuestionario As New VentanaCuestionario
                    '////CARGO DATOS CABEZAL CUESTIONARIO
                    ventanaCuestionario.tbCedulaEmpleado.Text = cedulaUsuarioConectado
                    ventanaCuestionario.lblID_sucursal.Text = empresa.sucursalID.ToString
                    ventanaCuestionario.tbEmpresaSeleccionada.Text = empresa.empresaRUT.ToString & " | " & empresa.empresaNombre.ToString & " | " & empresa.sucursalNombre
                    ventanaCuestionario.tbEmpleadoSucursal.Text = empresa.totalEmpleadosSucursal.ToString
                    ventanaCuestionario.tbNombreCuestionario.Text = tbNombreDelCoso.Text
                    ventanaCuestionario.tbMatricula.Text = matricula.ToString
                    ventanaCuestionario.ShowDialog()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub btnNuevoInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoInventario.Click
        variableSeleccion = "INVENTARIO"
        If Not variableSeleccion.Equals("") Then
            confirmo()
            If confirmado = True Then
                If variableSeleccion.Equals("INVENTARIO") Then
                    Dim ventanaInventario As New VentanaInventario
                    '////CARGO DATOS CABEZAL INVENTARIO
                    ventanaInventario.tbCedulaEmpleado.Text = cedulaUsuarioConectado
                    ventanaInventario.lblID_sucursal.Text = empresa.sucursalID.ToString
                    ventanaInventario.tbEmpresaSeleccionada.Text = empresa.empresaRUT.ToString & " | " & empresa.empresaNombre.ToString & " | " & empresa.sucursalNombre
                    ventanaInventario.tbEmpleadoSucursal.Text = empresa.totalEmpleadosSucursal.ToString
                    ventanaInventario.tbNombreInventario.Text = tbNombreDelCoso.Text
                    ventanaInventario.tbMatricula.Text = matricula.ToString
                    '////
                    ventanaInventario.ShowDialog()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim listaSucursales As New List(Of Sucursal)
        DataGridView1.Rows.Clear()
        If tbBuscarEmpresa.Text.Equals("") Then
            listaSucursales = ConsultoTodasLasSucursales(listaSucursales, conn)
        ElseIf IsNumeric(tbBuscarEmpresa.Text) = True Then
            listaSucursales = consultoSucursalesPorRUT(listaSucursales, conn, tbBuscarEmpresa.Text.ToLower)
        Else
            listaSucursales = consultoEmpresaPorNombre(listaSucursales, tbBuscarEmpresa.Text.ToLower, conn)
        End If
        '////
        DataGridView1.ColumnCount = 8
        '////
        DataGridView1.Columns(0).Name = varSucursalID
        DataGridView1.Columns(0).Visible = False
        '////
        DataGridView1.Columns(1).Name = varEmpresaRut
        '////
        DataGridView1.Columns(2).Name = varEmpresaNombre
        DataGridView1.Columns(2).Width = 268
        '////
        DataGridView1.Columns(3).Name = varSucursalNombre
        DataGridView1.Columns(3).Width = 270
        '////
        DataGridView1.Columns(4).Name = varSucursalDireccion
        DataGridView1.Columns(4).Visible = False
        '////
        DataGridView1.Columns(5).Name = varSucursalTelefono
        DataGridView1.Columns(5).Visible = False
        '////
        DataGridView1.Columns(6).Name = varEmpresaEstado
        DataGridView1.Columns(6).Visible = False
        '////
        DataGridView1.Columns(7).Name = varEmpresaTotalEmpleados
        DataGridView1.Columns(7).Width = 160
        '////
        For Each empresa As Sucursal In listaSucursales
            Dim row As String() = New String() {empresa.sucursalID, empresa.empresaRUT, empresa.empresaNombre, empresa.sucursalNombre, empresa.sucursalDireccion, empresa.telefono, empresa.estado, empresa.totalEmpleadosSucursal}
            DataGridView1.Rows.Add(row)
        Next
        DataGridView1.ClearSelection()
        DataGridView1.Refresh()
        '////
        tbBuscarEmpresa.Text = ""
    End Sub

    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            confirmaSeleccionEmpresa = "Confirm Selected Comapny"
            lblBuscarEmpresa.Text = "Find Company"
            btnBuscar.Text = "Search"
            lblSeleccionarEmpresa.Text = "Select the Company"
            btnNuevoCuestionario.Text = "Make new Questionary"
            btnNuevoInventario.Text = "Make new Inventory"
            btnNuevoMapa.Text = "Make new Risk Map"
            lblNombre.Text = "Name"
            tbNombreDelCoso.Text = "Type a name"
        Else
            confirmaSeleccionEmpresa = "Confirma Seleccion de la Empresa"
            tbNombreDelCoso.ForeColor = Color.DimGray
            tbNombreDelCoso.Text = "Tipea el nombre"
        End If
        varEmpresaRut = lenguaje.varEmpresaRut(varEmpresaRut)
        varEmpresaNombre = lenguaje.varEmpresaNombre(varEmpresaNombre)
        varSucursalNombre = lenguaje.varSucursalNombre(varSucursalNombre)
        varSucursalDireccion = lenguaje.varSucursalDireccion(varSucursalDireccion)
        varSucursalTelefono = lenguaje.varSucursalTelefono(varSucursalTelefono)
        varEmpresaEstado = lenguaje.varEmpresaEstado(varEmpresaEstado)
        varEmpresaTotalEmpleados = lenguaje.varEmpresaTotalEmpleados(varEmpresaTotalEmpleados)
        empresaSeleccionada = lenguaje.empresaSeleccionada(empresaSeleccionada)

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            empresa.sucursalID = selectedRow.Cells(0).Value.ToString
            empresa.empresaRUT = selectedRow.Cells(1).Value.ToString
            empresa.empresaNombre = selectedRow.Cells(2).Value.ToString
            empresa.sucursalNombre = selectedRow.Cells(3).Value.ToString
            empresa.sucursalDireccion = selectedRow.Cells(4).Value.ToString
            empresa.telefono = selectedRow.Cells(5).Value.ToString
            empresa.estado = selectedRow.Cells(6).Value.ToString
            empresa.totalEmpleadosSucursal = selectedRow.Cells(7).Value.ToString
            '///
            tbNombreDelCoso.ReadOnly = False
        Else
            tbNombreDelCoso.ReadOnly = True
        End If
    End Sub

    Private Sub tbNombreDelCoso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombreDelCoso.KeyPress
        If tbNombreDelCoso.Text.Equals("") Or tbNombreDelCoso.Text.Equals("Type a name") Or tbNombreDelCoso.Text.Equals("Tipea el nombre") Then
            btnNuevoCuestionario.Enabled = False
            btnNuevoInventario.Enabled = False
            btnNuevoMapa.Enabled = False
        Else
            btnNuevoCuestionario.Enabled = True
            btnNuevoInventario.Enabled = True
            btnNuevoMapa.Enabled = True
        End If
    End Sub

    Private Sub confirmo()
        Dim ventanaConfirmacion As New VentanaConfimracionGenerica
        ventanaConfirmacion.lblPreguntaOMensajeGenerico.Text = confirmaSeleccionEmpresa
        ventanaConfirmacion.tbDatosSeleccionados.Text = empresa.empresaRUT & " " & empresa.empresaNombre & " " & empresa.sucursalNombre
        If ventanaConfirmacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            confirmado = True
        Else
            DataGridView1.ClearSelection()
            '//
            tbNombreDelCoso.ReadOnly = True
            tbNombreDelCoso.Text = ""
            '//
            btnNuevoCuestionario.Enabled = False
            btnNuevoInventario.Enabled = False
            btnNuevoMapa.Enabled = False
            '//
            variableSeleccion = ""
            confirmado = False
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
    '//MUEVO LA WINDOW FIN
    '//CIERRO LA WINDOW
    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub

    Private Sub tbNombreDelCoso_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbNombreDelCoso.MouseClick
        tbNombreDelCoso.Text = ""
        tbNombreDelCoso.ForeColor = Color.Black
    End Sub

End Class