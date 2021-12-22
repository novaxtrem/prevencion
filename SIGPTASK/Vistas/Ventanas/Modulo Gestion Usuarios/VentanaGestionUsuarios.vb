Public Class VentanaGestionUsuarios
    Dim solonumeros As String = ""
    Dim numeroExcedemaximo As String = ""
    Dim laCedulaOElusuarioYaExisteEnlaBase As String = ""
    Dim empleadoAgregadoConExito As String = ""
    Dim haOcurridoUnProblemaContacteASistemas As String = ""
    Dim valido As Boolean = False
    Dim variableDeSeleccion As String
    '///
    Dim varIDUsuario As String = ""
    Dim varEmpleadoCedula As String = ""
    Dim varUSUARIONombre As String = ""
    Dim varEmpleadoUSERNAME As String = ""
    Dim varEmpleadoTIPO As String = ""
    Dim varEmpleadoMAtricula As String = ""
    Dim varEmpleadoDireccion As String = ""
    Dim varEmpleadoTelefono As String = ""
    Dim varEmpleadoCelular As String = ""
    Dim varEmpleadoEmail As String = ""
    '///
    Dim listaEmpleado As New List(Of Empleado)
    '///
    Private Sub VentanaAgregoEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMesajes()
        limpioCampos()
        tbBuscarUsuario.MaxLength = 80
        tbEmpleadoNombre.MaxLength = 80
        tbEmpleadoCedula.MaxLength = 10
        tbNombreUsuario.MaxLength = 80
        tbMatricula.MaxLength = 80
        tbDireccion.MaxLength = 80
        tbTelefono.MaxLength = 8
        tbCelular.MaxLength = 9
        tbEmail.MaxLength = 80
    End Sub
    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            btnAltaUsuario.Text = "Add User"
            btnEditarUsuario.Text = "Edit User"
            btnBorrar.Text = "Delete User"
            '///
            lblBuscarUsuario.Text = "Search user"
          '  lblBuscarUsuario.Location = New Point(36, 89)
            '///
            lblNombreEmpleado.Text = "Employee Name"
            lblNombreEmpleado.Location = New Point(40, 131)
            '///
            lblCedulaEmpleado.Text = "Employee ID"
            lblCedulaEmpleado.Location = New Point(124, 213)
            '///
            lblNombreUsuario.Text = "Employee username"
            lblNombreUsuario.Location = New Point(78, 253)
            '///
            lblTipoEmpleado.Text = "Emplyee Type"
            lblTipoEmpleado.Location = New Point(115, 293)
            '///
            lblMatricula.Text = "Technician Register ID"
            lblMatricula.Location = New Point(70, 333)
            '///
            lblDireccion.Text = "Employee Address"
            lblDireccion.Location = New Point(86, 373)
            '///
            lblTelefono.Text = "Employee Phone"
            lblTelefono.Location = New Point(100, 413)
            '///
            lblCelular.Text = "Emplyee Cellphone"
            lblCelular.Location = New Point(85, 453)
            '///
            lblEmpleadoEmail.Text = "Empolyee Email"
            lblEmpleadoEmail.Location = New Point(103, 493)
            '///
            cmbTipo.Items.Add("ADMINISTRATIVE")
            cmbTipo.Items.Add("PREVENTION TECHNICIAN")
            cmbTipo.Items.Add("IT SYSADMIN")
            '///
            btnBuscarPorUsuario.Text = "Username Search"
            btnAceptar.Text = "Acept"
            btnCancelar.Text = "Cancel"
        Else
            '///
            cmbTipo.Items.Add("ADMINISTRATIVO")
            cmbTipo.Items.Add("PREVENCIONISTA")
            cmbTipo.Items.Add("ADMINISTRADOR IT")
            '///


        End If
        solonumeros = lenguaje.solonumeros(solonumeros)
        numeroExcedemaximo = lenguaje.numeroExcedemaximo(numeroExcedemaximo)
        laCedulaOElusuarioYaExisteEnlaBase = lenguaje.laCedulaOElusuarioYaExisteEnlaBase(laCedulaOElusuarioYaExisteEnlaBase)
        empleadoAgregadoConExito = lenguaje.empleadoAgregadoConExito(empleadoAgregadoConExito)
        haOcurridoUnProblemaContacteASistemas = lenguaje.haOcurridoUnProblemaContacteASistemas(haOcurridoUnProblemaContacteASistemas)
        '///

        varIDUsuario = lenguaje.varIDUsuario(varIDUsuario)
        varEmpleadoCedula = lenguaje.varEmpleadoCedula(varEmpleadoCedula)
        varUSUARIONombre = lenguaje.varUSUARIONombre(varUSUARIONombre)
        varEmpleadoUSERNAME = lenguaje.varEmpleadoUSERNAME(varEmpleadoUSERNAME)
        varEmpleadoTIPO = lenguaje.varEmpleadoTIPO(varEmpleadoTIPO)
        varEmpleadoMAtricula = lenguaje.varEmpleadoMatricula(varEmpleadoMAtricula)
        varEmpleadoDireccion = lenguaje.varEmpleadoDireccion(varEmpleadoDireccion)
        varEmpleadoTelefono = lenguaje.varEmpleadoTelefono(varEmpleadoTelefono)
        varEmpleadoCelular = lenguaje.varEmpleadoCelular(varEmpleadoCelular)
        varEmpleadoEmail = lenguaje.varEmpleadoEmail(varEmpleadoEmail)




    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim empleado As New Empleado
        '///
        empleado.empleadoNombre = tbEmpleadoNombre.Text
        empleado.empleadoCedula = tbEmpleadoCedula.Text
        empleado.empleadoUsername = tbNombreUsuario.Text
        '////
        Dim normalizoLaEntradaAEspaniol As String = ""
        normalizoLaEntradaAEspaniol = cmbTipo.SelectedItem.ToString
        If idiomaSeleccionado.Equals("ING") Then
            Select Case normalizoLaEntradaAEspaniol
                Case "ADMINISTRATIVE"
                    empleado.empleadoTipo = "ADMINISTRATIVO"
                Case "PREVENTION TECHNICIAN"
                    empleado.empleadoTipo = "PREVENCIONISTA"
                Case "IT SYSADMIN"
                    empleado.empleadoTipo = "ADMINISTRADOR IT"
            End Select
        Else
            empleado.empleadoTipo = cmbTipo.SelectedItem.ToString
        End If
        '///
        If tbMatricula.Equals("") Then
            empleado.matricula = ""
        Else
            empleado.matricula = tbMatricula.Text
        End If
        '///
        If tbDireccion.Text.Equals("") Then
            empleado.empleadoDireccion = ""
        Else
            empleado.empleadoDireccion = tbDireccion.Text
        End If

        '///
        If tbTelefono.Text.Equals("") Then
            empleado.empleadoTelefono = 0
        Else
            empleado.empleadoTelefono = tbTelefono.Text
        End If
        '///
        If tbCelular.Text.Equals("") Then
            empleado.empleadoCelular = 0
        Else
            empleado.empleadoCelular = tbCelular.Text
        End If
        '///
        If tbEmail.Text.Equals("") Then
            empleado.empleadoEmail = ""
        Else
            empleado.empleadoEmail = tbEmail.Text
        End If
        '///
        Dim filasDevueltas As Integer = 0
        filasDevueltas = consultoExistenciaEmpleado(empleado.empleadoUsername, empleado.empleadoCedula, conn, filasDevueltas)
        '///
        If filasDevueltas > 0 Then
            MessageBox.Show(laCedulaOElusuarioYaExisteEnlaBase)
        Else
            Dim estado As Boolean = False
            estado = insertoEmpleado(empleado, conn, estado)
            If estado = True Then
                MessageBox.Show(empleadoAgregadoConExito)
                limpioCampos()
            Else
                MessageBox.Show(haOcurridoUnProblemaContacteASistemas)
                limpioCampos()
            End If
        End If
        limpioCampos()
    End Sub

    Private Sub btnAltaUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaUsuario.Click
        variableDeSeleccion = "ALTA"
        limpioCampos()
        If Me.Size <> New Size(536, 572) Then
            Me.Size = New Size(536, 572)
        End If
        If panelTabla.Visible = True Then
            panelTabla.Visible = False
        End If
        If DataGridViewUsuarios.Visible = True Then
            DataGridViewUsuarios.Visible = False
        End If


        Me.CenterToParent()
        tbEmpleadoNombre.ReadOnly = False
        '///
        tbEmpleadoNombre.Enabled = True
        tbMatricula.Enabled = True
        tbDireccion.Enabled = True
        tbTelefono.Enabled = True
        tbCelular.Enabled = True
        tbEmail.Enabled = True
    End Sub

    Private Sub tbEmpleadoNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpleadoNombre.TextChanged
        If tbEmpleadoNombre.Text.Equals("") Then
            tbEmpleadoCedula.ReadOnly = True
        Else
            tbEmpleadoCedula.ReadOnly = False
            tbEmpleadoCedula.Enabled = True
        End If
    End Sub

    Private Sub tbEmpleadoCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpleadoCedula.TextChanged
        If tbEmpleadoCedula.Text.Equals("") Then
            tbNombreUsuario.ReadOnly = True
        Else
            tbEmpleadoCedula.Enabled = True
            '///
            tbNombreUsuario.Enabled = True
            tbNombreUsuario.ReadOnly = False

        End If
    End Sub

    Private Sub tbNombreUSuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNombreUsuario.TextChanged
        If tbNombreUsuario.Text.Equals("") Then
            cmbTipo.Enabled = False
        Else
            cmbTipo.Enabled = True
        End If
    End Sub


    Private Sub cmbTipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedValueChanged

        If (cmbTipo.SelectedIndex = 1) Then
            tbMatricula.ReadOnly = False
            tbMatricula.Text = ""
            tbDireccion.Text = ""
            tbDireccion.ReadOnly = True
        Else
            tbMatricula.ReadOnly = True
            tbDireccion.ReadOnly = False
            tbDireccion.Text = ""
            tbMatricula.Text = ""
        End If

    End Sub

    Private Sub tbMatricula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMatricula.TextChanged
        If ((tbMatricula.ReadOnly = False) And tbMatricula.Text.Equals("")) Then
            tbDireccion.ReadOnly = True
            tbDireccion.Text = ""
        Else
            tbDireccion.ReadOnly = False
        End If
    End Sub

    Private Sub tbDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDireccion.TextChanged
        If tbDireccion.Text.Equals("") Then
            btnAceptar.Enabled = False
        Else
            valido = True
            btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    '//CONTROLES
    Private Sub tbEmpleadoCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbEmpleadoCedula.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                tbEmpleadoCedula.Text = solonumeros
                tbEmpleadoCedula.Refresh()
                Threading.Thread.Sleep(80)
                tbEmpleadoCedula.Clear()
                e.Handled = True
            Else
                If ((Not tbEmpleadoCedula.Text.Equals("")) AndAlso (Int64.Parse(tbEmpleadoCedula.Text) > 2147483647)) Then
                    tbEmpleadoCedula.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub

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

    Private Sub tbCelular_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCelular.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                tbCelular.Text = solonumeros
                tbCelular.Refresh()
                Threading.Thread.Sleep(80)
                tbCelular.Clear()
                e.Handled = True
            Else
                If ((Not tbCelular.Text.Equals("")) AndAlso (Int64.Parse(tbCelular.Text) > 2147483647)) Then
                    tbCelular.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    '//CONTROLES

    Private Sub limpioCampos()

        tbBuscarUsuario.Text = ""
        '///
        tbEmpleadoNombre.Text = ""
        tbEmpleadoCedula.Text = ""
        tbNombreUsuario.Text = ""
        cmbTipo.SelectedIndex = -1
        tbMatricula.Text = ""
        tbDireccion.Text = ""
        tbTelefono.Text = ""
        tbCelular.Text = ""
        tbEmail.Text = ""
    End Sub

    Private Sub btnEditarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarUsuario.Click
        variableDeSeleccion = "MODIFICAR"
        If Me.Size <> New Size(536, 572) Then
            Me.Size = New Size(536, 572)
        End If

        Me.CenterToParent()
    End Sub


    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        variableDeSeleccion = "BORRAR"
        If Me.Size <> New Size(536, 572) Then
            Me.Size = New Size(536, 572)
        End If
        Me.CenterToParent()
    End Sub


    Private Sub parametrosDatagrid()
        '///
        If panelTabla.Visible = False Then
            panelTabla.Visible = True
        End If
        If DataGridViewUsuarios.Visible = False Then
            DataGridViewUsuarios.Visible = True
        End If
        '///
        DataGridViewUsuarios.ColumnCount = 10
        '///
        DataGridViewUsuarios.Columns(0).Name = varIDUsuario
        DataGridViewUsuarios.Columns(0).Visible = False
        '///
        DataGridViewUsuarios.Columns(1).Name = varEmpleadoCedula
        DataGridViewUsuarios.Columns(1).Visible = True
        '///
        DataGridViewUsuarios.Columns(2).Name = varUSUARIONombre
        DataGridViewUsuarios.Columns(2).Visible = True
        '///
        DataGridViewUsuarios.Columns(3).Name = varEmpleadoUSERNAME
        DataGridViewUsuarios.Columns(3).Visible = True
        '///
        DataGridViewUsuarios.Columns(4).Name = varEmpleadoTIPO
        DataGridViewUsuarios.Columns(4).Visible = True
        '///
        DataGridViewUsuarios.Columns(5).Name = varEmpleadoMAtricula
        DataGridViewUsuarios.Columns(5).Visible = True
        '///
        DataGridViewUsuarios.Columns(6).Name = varEmpleadoDireccion
        DataGridViewUsuarios.Columns(6).Visible = True
        '///
        DataGridViewUsuarios.Columns(7).Name = varEmpleadoTelefono
        DataGridViewUsuarios.Columns(7).Visible = True
        '///
        DataGridViewUsuarios.Columns(8).Name = varEmpleadoCelular
        DataGridViewUsuarios.Columns(8).Visible = True
        '///
        DataGridViewUsuarios.Columns(9).Name = varEmpleadoEmail
        DataGridViewUsuarios.Columns(9).Visible = True
        '///
    End Sub

    Private Sub btnBuscarPorUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPorUsuario.Click


        If Not tbBuscarUsuario.Text.Equals("") Then
            listaEmpleado.Clear()
            listaEmpleado = consultoUsuarioPoTexto(listaEmpleado, tbBuscarUsuario.Text, conn)
            If listaEmpleado.Count = 0 Then
                MessageBox.Show("no hayado")
            Else
                If Me.Size <> New Size(536, 572) Then
                    Me.Size = New Size(536, 572)
                End If
                '///
                Me.CenterToParent()
                parametrosDatagrid()
                For Each empleadoEcontrado As Empleado In listaEmpleado
                    DataGridViewUsuarios.Rows.Clear()
                    DataGridViewUsuarios.Refresh()
                    Dim row As String() = New String() {empleadoEcontrado.empleadoID, empleadoEcontrado.empleadoCedula, empleadoEcontrado.empleadoNombre, empleadoEcontrado.empleadoUsername, _
                                                        empleadoEcontrado.empleadoTipo, empleadoEcontrado.matricula, empleadoEcontrado.empleadoDireccion, empleadoEcontrado.empleadoTelefono, _
                                                        empleadoEcontrado.empleadoCelular, empleadoEcontrado.empleadoEmail}
                    DataGridViewUsuarios.Rows.Add(row)
                    DataGridViewUsuarios.Refresh()
                Next
            End If
        Else
            listaEmpleado.Clear()
            DataGridViewUsuarios.Rows.Clear()
            listaEmpleado = consultoTodosEmpleados(listaEmpleado, conn)
            If listaEmpleado.Count = 0 Then
                MessageBox.Show("no hayado")
            Else
                If Me.Size <> New Size(536, 572) Then
                    Me.Size = New Size(536, 572)
                End If
                '///
                Me.CenterToParent()
                parametrosDatagrid()
                For Each empleadoEcontrado As Empleado In listaEmpleado
                    DataGridViewUsuarios.Refresh()
                    Dim row As String() = New String() {empleadoEcontrado.empleadoID, empleadoEcontrado.empleadoCedula, empleadoEcontrado.empleadoNombre, empleadoEcontrado.empleadoUsername, _
                                                        empleadoEcontrado.empleadoTipo, empleadoEcontrado.matricula, empleadoEcontrado.empleadoDireccion, empleadoEcontrado.empleadoTelefono, _
                                                        empleadoEcontrado.empleadoCelular, empleadoEcontrado.empleadoEmail}
                    DataGridViewUsuarios.Rows.Add(row)
                    DataGridViewUsuarios.Refresh()
                Next
            End If
        End If
    End Sub
End Class