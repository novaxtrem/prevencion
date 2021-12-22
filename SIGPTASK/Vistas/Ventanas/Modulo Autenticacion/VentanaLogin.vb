Public Class VentanaLogin
    Dim debeIngresarUsuario As String = ""
    Dim debeIngresarContrasenia As String = ""
    Dim usuarioOContraseniaError As String = ""
    Dim ingresarEmpleadoEnBase As String = ""
    Dim noTienePermisoParaAccederAlsistema As String = ""
    Private Sub VentanaLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idiomaMensajes()
    End Sub

    Private Sub btnIniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciarSesion.Click
        Dim ok As Boolean = True
        If tbUsuario.Text.Equals("") Then
            MessageBox.Show(debeIngresarUsuario)
            ok = False
        ElseIf tbContrasena.Text.Equals("") Then
                MessageBox.Show(debeIngresarContrasenia)
            ok = False
        End If
        If ok = True Then
            conn = ConectoBase(conn, tbUsuario.Text, tbContrasena.Text)
            If conn.State = ConnectionState.Open Then
                cedulaUsuarioConectado = consultoCedulaEmpleado(tbUsuario.Text, conn, cedulaUsuarioConectado)
                tipoUsuario = consultoTipo(cedulaUsuarioConectado, conn, tipoUsuario)
                If String.IsNullOrEmpty(tipoUsuario) Then
                    MessageBox.Show(ingresarEmpleadoEnBase)
                Else
                    Select Case tipoUsuario.ToString
                        Case "PREVENCIONISTA"
                            matricula = consultoMatricula(cedulaUsuarioConectado, conn, matricula)
                            Dim menuPrincipal As New VentanaMenuPricipal
                            '///
                            menuPrincipal.btnGestionUsuarios.Enabled = False
                            menuPrincipal.btnGestionUsuarios.Visible = True
                            '///
                            menuPrincipal.Show()
                            Me.Dispose()
                        Case "ADMINISTRADOR IT"
                            Dim menuPrincipal As New VentanaMenuPricipal
                            '///
                            menuPrincipal.btnGestionUsuarios.Enabled = True
                            menuPrincipal.btnGestionUsuarios.Visible = True
                            '///
                            menuPrincipal.btnAltaMApaCuestionarioInventario.Enabled = False
                            menuPrincipal.btnAltaPreguntasAccionesObjetosRiesgos.Enabled = False
                            menuPrincipal.btnGestionarSucursales.Enabled = False
                            menuPrincipal.btnReportes.Enabled = False
                            menuPrincipal.btnControl.Enabled = False
                            '///
                            menuPrincipal.Show()
                            Me.Dispose()
                        Case "ADMINISTRATIVO"
                            Dim menuPrincipal As New VentanaMenuPricipal
                            '///
                            menuPrincipal.btnGestionUsuarios.Enabled = False
                            menuPrincipal.btnGestionUsuarios.Visible = True
                            menuPrincipal.btnAltaMApaCuestionarioInventario.Enabled = False
                            menuPrincipal.btnControl.Enabled = False
                            '///
                            menuPrincipal.Show()
                            Me.Dispose()
                        Case "DADO DE BAJA"
                            MessageBox.Show(noTienePermisoParaAccederAlsistema)
                    End Select
                End If
            Else
                MessageBox.Show(usuarioOContraseniaError)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        idiomaSeleccionado = "ING"
        lblNombreUsuario.Text = "Username"
        lblContrasena.Text = "password"
        btnIniciarSesion.Text = "login"
        idiomaMensajes()
    End Sub

    Private Sub idiomaMensajes()
        debeIngresarUsuario = lenguaje.debeIngresarUsuario(debeIngresarUsuario)
        debeIngresarContrasenia = lenguaje.debeIngresarContrasenia(debeIngresarContrasenia)
        usuarioOContraseniaError = lenguaje.usuarioOContraseniaError(usuarioOContraseniaError)
        ingresarEmpleadoEnBase = lenguaje.ingresarEmpleadoEnBase(ingresarEmpleadoEnBase)
        noTienePermisoParaAccederAlsistema = lenguaje.noTienePermisoParaAccederAlsistema(noTienePermisoParaAccederAlsistema)
    End Sub

    Private Sub linkLabelIngles_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabelIngles.LinkClicked
        idiomaSeleccionado = "ING"
        lblNombreUsuario.Text = "Username"
        lblContrasena.Text = "password"
        btnIniciarSesion.Text = "login"
        idiomaMensajes()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        idiomaSeleccionado = "ESP"
        lblNombreUsuario.Text = "Usuario"
        lblContrasena.Text = "Contraseña"
        btnIniciarSesion.Text = "Iniciar Sesion"
        idiomaMensajes()
    End Sub

    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        If Not conn Is Nothing Then
            If ConnectionState.Open Then
                conn.Close()
            End If
        End If
        Me.Dispose()
        Application.Exit()
    End Sub

    '///////////BOLUDECES GRAFICAS
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
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseDown, pictureBoxTaskLogo.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove, pictureBoxTaskLogo.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseUp, pictureBoxTaskLogo.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '//MUEVO LA WINDOW FIN

 


    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("el manual esta dentro de la carpeta del software esta hecho en bootrap, esta sin terminar, para variar")
        'Dim webAddress As String = Application.StartupPath() & "\webES\index.html"
        'MessageBox.Show(webAddress)
        'Process.Start(webAddress)
    End Sub
End Class
