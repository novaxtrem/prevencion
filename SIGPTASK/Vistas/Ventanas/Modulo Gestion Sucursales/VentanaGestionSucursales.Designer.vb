<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaGestionSucursales
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaGestionSucursales))
        Me.lblSucursal_id = New System.Windows.Forms.Label()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.lblEmpresaRUT = New System.Windows.Forms.Label()
        Me.lblEmpresaNombre = New System.Windows.Forms.Label()
        Me.lblSucursalDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbEmpresaNombre = New System.Windows.Forms.TextBox()
        Me.tbEmpresaRut = New System.Windows.Forms.TextBox()
        Me.tbSucursalNombre = New System.Windows.Forms.TextBox()
        Me.tbSucursalDireccion = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregarEmpresa = New System.Windows.Forms.Button()
        Me.tbEmpleadosSucursal = New System.Windows.Forms.TextBox()
        Me.lblEmpleadosSucursal = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblConsultarEmpresa = New System.Windows.Forms.Label()
        Me.panelDetallesEmpresa = New System.Windows.Forms.Panel()
        Me.DataGridEmpresas = New System.Windows.Forms.DataGridView()
        Me.chekCasaCentral = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbBuscarEmpresa = New System.Windows.Forms.TextBox()
        Me.btnEditarSucursal = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.lblUsuarioCOnectado = New System.Windows.Forms.Label()
        Me.panelSuperior.SuspendLayout()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetallesEmpresa.SuspendLayout()
        CType(Me.DataGridEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSucursal_id
        '
        Me.lblSucursal_id.AutoSize = True
        Me.lblSucursal_id.Location = New System.Drawing.Point(363, 19)
        Me.lblSucursal_id.Name = "lblSucursal_id"
        Me.lblSucursal_id.Size = New System.Drawing.Size(72, 13)
        Me.lblSucursal_id.TabIndex = 0
        Me.lblSucursal_id.Text = "lblSucursal_id"
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(24, 80)
        Me.lblSucursalNombre.Name = "lblSucursalNombre"
        Me.lblSucursalNombre.Size = New System.Drawing.Size(109, 16)
        Me.lblSucursalNombre.TabIndex = 1
        Me.lblSucursalNombre.Text = "Nombre Sucursal"
        '
        'lblEmpresaRUT
        '
        Me.lblEmpresaRUT.AutoSize = True
        Me.lblEmpresaRUT.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaRUT.Location = New System.Drawing.Point(101, 19)
        Me.lblEmpresaRUT.Name = "lblEmpresaRUT"
        Me.lblEmpresaRUT.Size = New System.Drawing.Size(32, 16)
        Me.lblEmpresaRUT.TabIndex = 2
        Me.lblEmpresaRUT.Text = "RUT"
        '
        'lblEmpresaNombre
        '
        Me.lblEmpresaNombre.AutoSize = True
        Me.lblEmpresaNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaNombre.Location = New System.Drawing.Point(21, 50)
        Me.lblEmpresaNombre.Name = "lblEmpresaNombre"
        Me.lblEmpresaNombre.Size = New System.Drawing.Size(112, 16)
        Me.lblEmpresaNombre.TabIndex = 3
        Me.lblEmpresaNombre.Text = "Nombre Empresa"
        '
        'lblSucursalDireccion
        '
        Me.lblSucursalDireccion.AutoSize = True
        Me.lblSucursalDireccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalDireccion.Location = New System.Drawing.Point(19, 121)
        Me.lblSucursalDireccion.Name = "lblSucursalDireccion"
        Me.lblSucursalDireccion.Size = New System.Drawing.Size(114, 16)
        Me.lblSucursalDireccion.TabIndex = 4
        Me.lblSucursalDireccion.Text = "Direccion Sucursal"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(74, 162)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(59, 16)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Telefono"
        '
        'tbEmpresaNombre
        '
        Me.tbEmpresaNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresaNombre.Location = New System.Drawing.Point(139, 45)
        Me.tbEmpresaNombre.Name = "tbEmpresaNombre"
        Me.tbEmpresaNombre.Size = New System.Drawing.Size(478, 24)
        Me.tbEmpresaNombre.TabIndex = 9
        '
        'tbEmpresaRut
        '
        Me.tbEmpresaRut.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresaRut.Location = New System.Drawing.Point(139, 15)
        Me.tbEmpresaRut.Name = "tbEmpresaRut"
        Me.tbEmpresaRut.ReadOnly = True
        Me.tbEmpresaRut.Size = New System.Drawing.Size(188, 24)
        Me.tbEmpresaRut.TabIndex = 8
        '
        'tbSucursalNombre
        '
        Me.tbSucursalNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSucursalNombre.Location = New System.Drawing.Point(139, 75)
        Me.tbSucursalNombre.Name = "tbSucursalNombre"
        Me.tbSucursalNombre.Size = New System.Drawing.Size(478, 24)
        Me.tbSucursalNombre.TabIndex = 10
        '
        'tbSucursalDireccion
        '
        Me.tbSucursalDireccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSucursalDireccion.Location = New System.Drawing.Point(139, 105)
        Me.tbSucursalDireccion.Multiline = True
        Me.tbSucursalDireccion.Name = "tbSucursalDireccion"
        Me.tbSucursalDireccion.Size = New System.Drawing.Size(478, 48)
        Me.tbSucursalDireccion.TabIndex = 12
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(139, 158)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(145, 24)
        Me.tbTelefono.TabIndex = 13
        '
        'btnAgregarEmpresa
        '
        Me.btnAgregarEmpresa.BackColor = System.Drawing.Color.White
        Me.btnAgregarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregarEmpresa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAgregarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAgregarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAgregarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpresa.Location = New System.Drawing.Point(646, 56)
        Me.btnAgregarEmpresa.Name = "btnAgregarEmpresa"
        Me.btnAgregarEmpresa.Size = New System.Drawing.Size(207, 30)
        Me.btnAgregarEmpresa.TabIndex = 3
        Me.btnAgregarEmpresa.Text = "Agregar Empresa / Sucursal"
        Me.btnAgregarEmpresa.UseVisualStyleBackColor = False
        '
        'tbEmpleadosSucursal
        '
        Me.tbEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadosSucursal.Location = New System.Drawing.Point(474, 158)
        Me.tbEmpleadosSucursal.Name = "tbEmpleadosSucursal"
        Me.tbEmpleadosSucursal.Size = New System.Drawing.Size(143, 24)
        Me.tbEmpleadosSucursal.TabIndex = 14
        '
        'lblEmpleadosSucursal
        '
        Me.lblEmpleadosSucursal.AutoSize = True
        Me.lblEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleadosSucursal.Location = New System.Drawing.Point(343, 162)
        Me.lblEmpleadosSucursal.Name = "lblEmpleadosSucursal"
        Me.lblEmpleadosSucursal.Size = New System.Drawing.Size(125, 16)
        Me.lblEmpleadosSucursal.TabIndex = 15
        Me.lblEmpleadosSucursal.Text = "Empleados Sucursal"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(860, 25)
        Me.panelSuperior.TabIndex = 17
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(816, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 39
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(837, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 38
        Me.pictureClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'lblConsultarEmpresa
        '
        Me.lblConsultarEmpresa.AutoSize = True
        Me.lblConsultarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultarEmpresa.Location = New System.Drawing.Point(7, 41)
        Me.lblConsultarEmpresa.Name = "lblConsultarEmpresa"
        Me.lblConsultarEmpresa.Size = New System.Drawing.Size(198, 16)
        Me.lblConsultarEmpresa.TabIndex = 18
        Me.lblConsultarEmpresa.Text = "Consultar Empresas / Sucursales"
        '
        'panelDetallesEmpresa
        '
        Me.panelDetallesEmpresa.Controls.Add(Me.DataGridEmpresas)
        Me.panelDetallesEmpresa.Controls.Add(Me.chekCasaCentral)
        Me.panelDetallesEmpresa.Controls.Add(Me.btnCancelar)
        Me.panelDetallesEmpresa.Controls.Add(Me.btnAceptar)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbEmpresaRut)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblSucursal_id)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblSucursalNombre)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbEmpleadosSucursal)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblEmpresaRUT)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblEmpleadosSucursal)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblEmpresaNombre)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblSucursalDireccion)
        Me.panelDetallesEmpresa.Controls.Add(Me.lblTelefono)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbEmpresaNombre)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbTelefono)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbSucursalNombre)
        Me.panelDetallesEmpresa.Controls.Add(Me.tbSucursalDireccion)
        Me.panelDetallesEmpresa.Location = New System.Drawing.Point(4, 4)
        Me.panelDetallesEmpresa.Name = "panelDetallesEmpresa"
        Me.panelDetallesEmpresa.Size = New System.Drawing.Size(634, 240)
        Me.panelDetallesEmpresa.TabIndex = 19
        '
        'DataGridEmpresas
        '
        Me.DataGridEmpresas.AllowUserToAddRows = False
        Me.DataGridEmpresas.AllowUserToDeleteRows = False
        Me.DataGridEmpresas.AllowUserToResizeColumns = False
        Me.DataGridEmpresas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEmpresas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridEmpresas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEmpresas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridEmpresas.Location = New System.Drawing.Point(3, 3)
        Me.DataGridEmpresas.Name = "DataGridEmpresas"
        Me.DataGridEmpresas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEmpresas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridEmpresas.RowHeadersVisible = False
        Me.DataGridEmpresas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridEmpresas.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridEmpresas.Size = New System.Drawing.Size(628, 234)
        Me.DataGridEmpresas.TabIndex = 20
        '
        'chekCasaCentral
        '
        Me.chekCasaCentral.AutoSize = True
        Me.chekCasaCentral.Enabled = False
        Me.chekCasaCentral.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chekCasaCentral.Location = New System.Drawing.Point(517, 15)
        Me.chekCasaCentral.Name = "chekCasaCentral"
        Me.chekCasaCentral.Size = New System.Drawing.Size(100, 20)
        Me.chekCasaCentral.TabIndex = 11
        Me.chekCasaCentral.Text = "Casa Central"
        Me.chekCasaCentral.UseVisualStyleBackColor = True
        Me.chekCasaCentral.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(380, 197)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 30)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(502, 197)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 30)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(538, 56)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'tbBuscarEmpresa
        '
        Me.tbBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarEmpresa.Location = New System.Drawing.Point(7, 60)
        Me.tbBuscarEmpresa.Name = "tbBuscarEmpresa"
        Me.tbBuscarEmpresa.Size = New System.Drawing.Size(523, 24)
        Me.tbBuscarEmpresa.TabIndex = 1
        '
        'btnEditarSucursal
        '
        Me.btnEditarSucursal.BackColor = System.Drawing.Color.White
        Me.btnEditarSucursal.Enabled = False
        Me.btnEditarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEditarSucursal.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.btnEditarSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnEditarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEditarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarSucursal.Location = New System.Drawing.Point(644, 7)
        Me.btnEditarSucursal.Name = "btnEditarSucursal"
        Me.btnEditarSucursal.Size = New System.Drawing.Size(207, 30)
        Me.btnEditarSucursal.TabIndex = 16
        Me.btnEditarSucursal.Text = "Editar Sucursal"
        Me.btnEditarSucursal.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(644, 43)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(207, 30)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar Empresa / Sucursal"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.White
        Me.panelContenedor.Controls.Add(Me.btnEliminar)
        Me.panelContenedor.Controls.Add(Me.btnEditarSucursal)
        Me.panelContenedor.Controls.Add(Me.panelDetallesEmpresa)
        Me.panelContenedor.Location = New System.Drawing.Point(3, 92)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(857, 247)
        Me.panelContenedor.TabIndex = 29
        '
        'lblUsuarioCOnectado
        '
        Me.lblUsuarioCOnectado.AutoSize = True
        Me.lblUsuarioCOnectado.Location = New System.Drawing.Point(248, 41)
        Me.lblUsuarioCOnectado.Name = "lblUsuarioCOnectado"
        Me.lblUsuarioCOnectado.Size = New System.Drawing.Size(107, 13)
        Me.lblUsuarioCOnectado.TabIndex = 30
        Me.lblUsuarioCOnectado.Text = "lblUsuarioCOnectado"
        Me.lblUsuarioCOnectado.Visible = False
        '
        'VentanaGestionSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 345)
        Me.Controls.Add(Me.lblUsuarioCOnectado)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.tbBuscarEmpresa)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblConsultarEmpresa)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.btnAgregarEmpresa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaGestionSucursales"
        Me.Text = "VentanaAgregarSucursal"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetallesEmpresa.ResumeLayout(False)
        Me.panelDetallesEmpresa.PerformLayout()
        CType(Me.DataGridEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSucursal_id As System.Windows.Forms.Label
    Friend WithEvents lblSucursalNombre As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaRUT As System.Windows.Forms.Label
    Friend WithEvents lblEmpresaNombre As System.Windows.Forms.Label
    Friend WithEvents lblSucursalDireccion As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents tbEmpresaNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbEmpresaRut As System.Windows.Forms.TextBox
    Friend WithEvents tbSucursalNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbSucursalDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarEmpresa As System.Windows.Forms.Button
    Friend WithEvents tbEmpleadosSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpleadosSucursal As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents lblConsultarEmpresa As System.Windows.Forms.Label
    Friend WithEvents panelDetallesEmpresa As System.Windows.Forms.Panel
    Friend WithEvents DataGridEmpresas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents tbBuscarEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditarSucursal As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents panelContenedor As System.Windows.Forms.Panel
    Friend WithEvents chekCasaCentral As System.Windows.Forms.CheckBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioCOnectado As System.Windows.Forms.Label
End Class
