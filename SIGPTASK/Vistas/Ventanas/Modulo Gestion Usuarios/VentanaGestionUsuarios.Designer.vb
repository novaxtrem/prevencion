<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaGestionUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaGestionUsuarios))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tbEmpleadoCedula = New System.Windows.Forms.TextBox()
        Me.tbEmpleadoNombre = New System.Windows.Forms.TextBox()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lblCedulaEmpleado = New System.Windows.Forms.Label()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblEmpleadoEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTipoEmpleado = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.lblAdmitoBorrar = New System.Windows.Forms.Label()
        Me.lblUsuarioConectado = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.lblBuscarUsuario = New System.Windows.Forms.Label()
        Me.btnBuscarPorUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAltaUsuario = New System.Windows.Forms.Button()
        Me.panelTabla = New System.Windows.Forms.Panel()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.tbBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.panelInferior.SuspendLayout()
        Me.panelSuperior.SuspendLayout()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTabla.SuspendLayout()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(277, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 30)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(407, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 30)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'tbEmpleadoCedula
        '
        Me.tbEmpleadoCedula.Enabled = False
        Me.tbEmpleadoCedula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadoCedula.Location = New System.Drawing.Point(207, 209)
        Me.tbEmpleadoCedula.Name = "tbEmpleadoCedula"
        Me.tbEmpleadoCedula.ReadOnly = True
        Me.tbEmpleadoCedula.Size = New System.Drawing.Size(254, 24)
        Me.tbEmpleadoCedula.TabIndex = 6
        '
        'tbEmpleadoNombre
        '
        Me.tbEmpleadoNombre.Enabled = False
        Me.tbEmpleadoNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadoNombre.Location = New System.Drawing.Point(146, 124)
        Me.tbEmpleadoNombre.Name = "tbEmpleadoNombre"
        Me.tbEmpleadoNombre.ReadOnly = True
        Me.tbEmpleadoNombre.Size = New System.Drawing.Size(381, 24)
        Me.tbEmpleadoNombre.TabIndex = 5
        '
        'tbMatricula
        '
        Me.tbMatricula.Enabled = False
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(207, 329)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.Size = New System.Drawing.Size(254, 24)
        Me.tbMatricula.TabIndex = 8
        '
        'tbDireccion
        '
        Me.tbDireccion.Enabled = False
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(207, 369)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.ReadOnly = True
        Me.tbDireccion.Size = New System.Drawing.Size(254, 24)
        Me.tbDireccion.TabIndex = 9
        '
        'tbTelefono
        '
        Me.tbTelefono.Enabled = False
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(207, 409)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(254, 24)
        Me.tbTelefono.TabIndex = 10
        '
        'tbEmail
        '
        Me.tbEmail.Enabled = False
        Me.tbEmail.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.Location = New System.Drawing.Point(207, 489)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(254, 24)
        Me.tbEmail.TabIndex = 11
        '
        'lblCedulaEmpleado
        '
        Me.lblCedulaEmpleado.AutoSize = True
        Me.lblCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaEmpleado.Location = New System.Drawing.Point(91, 214)
        Me.lblCedulaEmpleado.Name = "lblCedulaEmpleado"
        Me.lblCedulaEmpleado.Size = New System.Drawing.Size(111, 16)
        Me.lblCedulaEmpleado.TabIndex = 8
        Me.lblCedulaEmpleado.Text = "Empleado Cedula"
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(20, 128)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(120, 16)
        Me.lblNombreEmpleado.TabIndex = 9
        Me.lblNombreEmpleado.Text = "Empleado Nombre"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(77, 374)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(125, 16)
        Me.lblDireccion.TabIndex = 11
        Me.lblDireccion.Text = "Empleado Direccion"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(77, 334)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(125, 16)
        Me.lblMatricula.TabIndex = 10
        Me.lblMatricula.Text = "Empleado Matricula"
        '
        'lblEmpleadoEmail
        '
        Me.lblEmpleadoEmail.AutoSize = True
        Me.lblEmpleadoEmail.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleadoEmail.Location = New System.Drawing.Point(100, 494)
        Me.lblEmpleadoEmail.Name = "lblEmpleadoEmail"
        Me.lblEmpleadoEmail.Size = New System.Drawing.Size(102, 16)
        Me.lblEmpleadoEmail.TabIndex = 13
        Me.lblEmpleadoEmail.Text = "Empleado Email"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(80, 414)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(122, 16)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Empleado Telefono"
        '
        'lblTipoEmpleado
        '
        Me.lblTipoEmpleado.AutoSize = True
        Me.lblTipoEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEmpleado.Location = New System.Drawing.Point(105, 294)
        Me.lblTipoEmpleado.Name = "lblTipoEmpleado"
        Me.lblTipoEmpleado.Size = New System.Drawing.Size(97, 16)
        Me.lblTipoEmpleado.TabIndex = 14
        Me.lblTipoEmpleado.Text = "Empleado Tipo"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Enabled = False
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(207, 289)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(254, 24)
        Me.cmbTipo.TabIndex = 8
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(91, 454)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(111, 16)
        Me.lblCelular.TabIndex = 17
        Me.lblCelular.Text = "Empleado Celular"
        '
        'tbCelular
        '
        Me.tbCelular.Enabled = False
        Me.tbCelular.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCelular.Location = New System.Drawing.Point(207, 449)
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(254, 24)
        Me.tbCelular.TabIndex = 11
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.lblAdmitoBorrar)
        Me.panelInferior.Controls.Add(Me.lblUsuarioConectado)
        Me.panelInferior.Controls.Add(Me.btnCancelar)
        Me.panelInferior.Controls.Add(Me.btnAceptar)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 168)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(539, 40)
        Me.panelInferior.TabIndex = 18
        '
        'lblAdmitoBorrar
        '
        Me.lblAdmitoBorrar.AutoSize = True
        Me.lblAdmitoBorrar.ForeColor = System.Drawing.Color.White
        Me.lblAdmitoBorrar.Location = New System.Drawing.Point(134, 14)
        Me.lblAdmitoBorrar.Name = "lblAdmitoBorrar"
        Me.lblAdmitoBorrar.Size = New System.Drawing.Size(15, 13)
        Me.lblAdmitoBorrar.TabIndex = 3
        Me.lblAdmitoBorrar.Text = "N"
        '
        'lblUsuarioConectado
        '
        Me.lblUsuarioConectado.AutoSize = True
        Me.lblUsuarioConectado.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioConectado.Location = New System.Drawing.Point(15, 15)
        Me.lblUsuarioConectado.Name = "lblUsuarioConectado"
        Me.lblUsuarioConectado.Size = New System.Drawing.Size(105, 13)
        Me.lblUsuarioConectado.TabIndex = 2
        Me.lblUsuarioConectado.Text = "lblUsuarioConectado"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.ForeColor = System.Drawing.Color.Black
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(539, 25)
        Me.panelSuperior.TabIndex = 19
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(496, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 37
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(517, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 36
        Me.pictureClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(76, 252)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(126, 16)
        Me.lblNombreUsuario.TabIndex = 20
        Me.lblNombreUsuario.Text = "Empleado ""Usuario"""
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.Enabled = False
        Me.tbNombreUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreUsuario.Location = New System.Drawing.Point(207, 249)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.ReadOnly = True
        Me.tbNombreUsuario.Size = New System.Drawing.Size(254, 24)
        Me.tbNombreUsuario.TabIndex = 7
        '
        'lblBuscarUsuario
        '
        Me.lblBuscarUsuario.AutoSize = True
        Me.lblBuscarUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarUsuario.Location = New System.Drawing.Point(9, 47)
        Me.lblBuscarUsuario.Name = "lblBuscarUsuario"
        Me.lblBuscarUsuario.Size = New System.Drawing.Size(95, 16)
        Me.lblBuscarUsuario.TabIndex = 26
        Me.lblBuscarUsuario.Text = "Buscar Usuario"
        '
        'btnBuscarPorUsuario
        '
        Me.btnBuscarPorUsuario.BackColor = System.Drawing.Color.White
        Me.btnBuscarPorUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscarPorUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscarPorUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPorUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPorUsuario.Location = New System.Drawing.Point(402, 40)
        Me.btnBuscarPorUsuario.Name = "btnBuscarPorUsuario"
        Me.btnBuscarPorUsuario.Size = New System.Drawing.Size(122, 30)
        Me.btnBuscarPorUsuario.TabIndex = 4
        Me.btnBuscarPorUsuario.Text = "Buscar Usuario"
        Me.btnBuscarPorUsuario.UseVisualStyleBackColor = False
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Enabled = False
        Me.btnEditarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnEditarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsuario.Location = New System.Drawing.Point(274, 76)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(122, 30)
        Me.btnEditarUsuario.TabIndex = 29
        Me.btnEditarUsuario.Text = "Editar Usuario"
        Me.btnEditarUsuario.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.White
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(402, 76)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(122, 30)
        Me.btnBorrar.TabIndex = 30
        Me.btnBorrar.Text = "Borrar Usuario"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnAltaUsuario
        '
        Me.btnAltaUsuario.BackColor = System.Drawing.Color.White
        Me.btnAltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAltaUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltaUsuario.Location = New System.Drawing.Point(146, 76)
        Me.btnAltaUsuario.Name = "btnAltaUsuario"
        Me.btnAltaUsuario.Size = New System.Drawing.Size(122, 30)
        Me.btnAltaUsuario.TabIndex = 31
        Me.btnAltaUsuario.Text = "Alta Usuario"
        Me.btnAltaUsuario.UseVisualStyleBackColor = False
        '
        'panelTabla
        '
        Me.panelTabla.Controls.Add(Me.DataGridViewUsuarios)
        Me.panelTabla.Location = New System.Drawing.Point(0, 171)
        Me.panelTabla.Name = "panelTabla"
        Me.panelTabla.Size = New System.Drawing.Size(539, 342)
        Me.panelTabla.TabIndex = 33
        Me.panelTabla.Visible = False
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AllowUserToAddRows = False
        Me.DataGridViewUsuarios.AllowUserToDeleteRows = False
        Me.DataGridViewUsuarios.AllowUserToResizeColumns = False
        Me.DataGridViewUsuarios.AllowUserToResizeRows = False
        Me.DataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewUsuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewUsuarios.MultiSelect = False
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewUsuarios.RowHeadersVisible = False
        Me.DataGridViewUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(539, 342)
        Me.DataGridViewUsuarios.TabIndex = 0
        Me.DataGridViewUsuarios.Visible = False
        '
        'tbBuscarUsuario
        '
        Me.tbBuscarUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarUsuario.Location = New System.Drawing.Point(111, 42)
        Me.tbBuscarUsuario.Name = "tbBuscarUsuario"
        Me.tbBuscarUsuario.Size = New System.Drawing.Size(282, 24)
        Me.tbBuscarUsuario.TabIndex = 34
        '
        'VentanaGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 208)
        Me.Controls.Add(Me.tbBuscarUsuario)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.panelTabla)
        Me.Controls.Add(Me.btnAltaUsuario)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnBuscarPorUsuario)
        Me.Controls.Add(Me.lblBuscarUsuario)
        Me.Controls.Add(Me.tbNombreUsuario)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.tbCelular)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.lblTipoEmpleado)
        Me.Controls.Add(Me.lblEmpleadoEmail)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.lblCedulaEmpleado)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.tbEmpleadoNombre)
        Me.Controls.Add(Me.tbEmpleadoCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaGestionUsuarios"
        Me.Text = "VentanaAgregoEmpleado"
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTabla.ResumeLayout(False)
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents tbEmpleadoCedula As System.Windows.Forms.TextBox
    Friend WithEvents tbEmpleadoNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents tbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCedulaEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblEmpleadoEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblTipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents tbCelular As System.Windows.Forms.TextBox
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents tbNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscarUsuario As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPorUsuario As System.Windows.Forms.Button
    Friend WithEvents btnEditarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnAltaUsuario As System.Windows.Forms.Button
    Friend WithEvents lblUsuarioConectado As System.Windows.Forms.Label
    Friend WithEvents lblAdmitoBorrar As System.Windows.Forms.Label
    Friend WithEvents panelTabla As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents tbBuscarUsuario As System.Windows.Forms.TextBox
End Class
