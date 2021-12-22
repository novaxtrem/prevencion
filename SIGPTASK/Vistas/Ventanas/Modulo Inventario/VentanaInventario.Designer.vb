<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaInventario))
        Me.panelCentralPA = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInventariar = New System.Windows.Forms.Button()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.tbCedulaEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbEmpresaSeleccionada = New System.Windows.Forms.TextBox()
        Me.lblEmpresaElegida = New System.Windows.Forms.Label()
        Me.tbEmpleadoSucursal = New System.Windows.Forms.TextBox()
        Me.lblTotalEmpleadosSucursal = New System.Windows.Forms.Label()
        Me.tbNombreInventario = New System.Windows.Forms.TextBox()
        Me.lblNombreInventario = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.btnAgregarNota = New System.Windows.Forms.Button()
        Me.btnAgregarObjeto = New System.Windows.Forms.Button()
        Me.lblID_sucursal = New System.Windows.Forms.Label()
        Me.panelIzquierdo = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscarObjeto = New System.Windows.Forms.Button()
        Me.tbBuscarObjeto = New System.Windows.Forms.TextBox()
        Me.lblBuscarObjeto = New System.Windows.Forms.Label()
        Me.panelSupoerpuestoInformacion = New System.Windows.Forms.Panel()
        Me.PictureBoxFechaIzquierda = New System.Windows.Forms.PictureBox()
        Me.lblParaComenzarBus = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblElpaneldeAcc = New System.Windows.Forms.Label()
        Me.lblCuandoHayaSele = New System.Windows.Forms.Label()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInferior.SuspendLayout()
        Me.panelIzquierdo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSupoerpuestoInformacion.SuspendLayout()
        CType(Me.PictureBoxFechaIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCentralPA
        '
        Me.panelCentralPA.AutoScroll = True
        Me.panelCentralPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCentralPA.Location = New System.Drawing.Point(424, 113)
        Me.panelCentralPA.Name = "panelCentralPA"
        Me.panelCentralPA.Size = New System.Drawing.Size(856, 522)
        Me.panelCentralPA.TabIndex = 2
        '
        'btnInventariar
        '
        Me.btnInventariar.BackColor = System.Drawing.Color.White
        Me.btnInventariar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnInventariar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventariar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventariar.Location = New System.Drawing.Point(1150, 6)
        Me.btnInventariar.Name = "btnInventariar"
        Me.btnInventariar.Size = New System.Drawing.Size(130, 30)
        Me.btnInventariar.TabIndex = 14
        Me.btnInventariar.Text = "Inventariar"
        Me.btnInventariar.UseVisualStyleBackColor = False
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(1111, 70)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(161, 24)
        Me.tbMatricula.TabIndex = 47
        Me.tbMatricula.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(1036, 74)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 46
        Me.lblMatricula.Text = "| Matricula"
        '
        'tbCedulaEmpleado
        '
        Me.tbCedulaEmpleado.BackColor = System.Drawing.Color.White
        Me.tbCedulaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCedulaEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCedulaEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCedulaEmpleado.Location = New System.Drawing.Point(910, 70)
        Me.tbCedulaEmpleado.Name = "tbCedulaEmpleado"
        Me.tbCedulaEmpleado.ReadOnly = True
        Me.tbCedulaEmpleado.ShortcutsEnabled = False
        Me.tbCedulaEmpleado.Size = New System.Drawing.Size(120, 24)
        Me.tbCedulaEmpleado.TabIndex = 45
        Me.tbCedulaEmpleado.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(790, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "| Cedula Empleado"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1119, 39)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 43
        Me.lblFecha.Text = "| Fecha"
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(1172, 35)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(99, 24)
        Me.tbFecha.TabIndex = 42
        Me.tbFecha.TabStop = False
        '
        'tbEmpresaSeleccionada
        '
        Me.tbEmpresaSeleccionada.BackColor = System.Drawing.Color.White
        Me.tbEmpresaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpresaSeleccionada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpresaSeleccionada.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpresaSeleccionada.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresaSeleccionada.Location = New System.Drawing.Point(169, 35)
        Me.tbEmpresaSeleccionada.Name = "tbEmpresaSeleccionada"
        Me.tbEmpresaSeleccionada.ReadOnly = True
        Me.tbEmpresaSeleccionada.ShortcutsEnabled = False
        Me.tbEmpresaSeleccionada.Size = New System.Drawing.Size(616, 24)
        Me.tbEmpresaSeleccionada.TabIndex = 41
        Me.tbEmpresaSeleccionada.TabStop = False
        '
        'lblEmpresaElegida
        '
        Me.lblEmpresaElegida.AutoSize = True
        Me.lblEmpresaElegida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaElegida.Location = New System.Drawing.Point(5, 39)
        Me.lblEmpresaElegida.Name = "lblEmpresaElegida"
        Me.lblEmpresaElegida.Size = New System.Drawing.Size(139, 16)
        Me.lblEmpresaElegida.TabIndex = 40
        Me.lblEmpresaElegida.Text = "Empresa Seleccionada"
        '
        'tbEmpleadoSucursal
        '
        Me.tbEmpleadoSucursal.BackColor = System.Drawing.Color.White
        Me.tbEmpleadoSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpleadoSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpleadoSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpleadoSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadoSucursal.Location = New System.Drawing.Point(960, 35)
        Me.tbEmpleadoSucursal.Name = "tbEmpleadoSucursal"
        Me.tbEmpleadoSucursal.ReadOnly = True
        Me.tbEmpleadoSucursal.ShortcutsEnabled = False
        Me.tbEmpleadoSucursal.Size = New System.Drawing.Size(153, 24)
        Me.tbEmpleadoSucursal.TabIndex = 39
        Me.tbEmpleadoSucursal.TabStop = False
        '
        'lblTotalEmpleadosSucursal
        '
        Me.lblTotalEmpleadosSucursal.AutoSize = True
        Me.lblTotalEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmpleadosSucursal.Location = New System.Drawing.Point(790, 39)
        Me.lblTotalEmpleadosSucursal.Name = "lblTotalEmpleadosSucursal"
        Me.lblTotalEmpleadosSucursal.Size = New System.Drawing.Size(164, 16)
        Me.lblTotalEmpleadosSucursal.TabIndex = 38
        Me.lblTotalEmpleadosSucursal.Text = "| Empleados de la sucursal"
        '
        'tbNombreInventario
        '
        Me.tbNombreInventario.BackColor = System.Drawing.Color.White
        Me.tbNombreInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreInventario.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreInventario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreInventario.Location = New System.Drawing.Point(169, 70)
        Me.tbNombreInventario.Name = "tbNombreInventario"
        Me.tbNombreInventario.ShortcutsEnabled = False
        Me.tbNombreInventario.Size = New System.Drawing.Size(616, 24)
        Me.tbNombreInventario.TabIndex = 37
        Me.tbNombreInventario.TabStop = False
        '
        'lblNombreInventario
        '
        Me.lblNombreInventario.AutoSize = True
        Me.lblNombreInventario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInventario.Location = New System.Drawing.Point(5, 74)
        Me.lblNombreInventario.Name = "lblNombreInventario"
        Me.lblNombreInventario.Size = New System.Drawing.Size(137, 16)
        Me.lblNombreInventario.TabIndex = 36
        Me.lblNombreInventario.Text = "Nombre de Inventario"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1287, 25)
        Me.panelSuperior.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(7, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(1243, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 50
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(1264, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 49
        Me.pictureClose.TabStop = False
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.btnAgregarNota)
        Me.panelInferior.Controls.Add(Me.btnAgregarObjeto)
        Me.panelInferior.Controls.Add(Me.lblID_sucursal)
        Me.panelInferior.Controls.Add(Me.btnInventariar)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 641)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(1287, 42)
        Me.panelInferior.TabIndex = 49
        '
        'btnAgregarNota
        '
        Me.btnAgregarNota.BackColor = System.Drawing.Color.White
        Me.btnAgregarNota.FlatAppearance.BorderSize = 0
        Me.btnAgregarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarNota.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNota.Location = New System.Drawing.Point(147, 6)
        Me.btnAgregarNota.Name = "btnAgregarNota"
        Me.btnAgregarNota.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarNota.TabIndex = 32
        Me.btnAgregarNota.Text = "Agregar Nota"
        Me.btnAgregarNota.UseVisualStyleBackColor = False
        '
        'btnAgregarObjeto
        '
        Me.btnAgregarObjeto.BackColor = System.Drawing.Color.White
        Me.btnAgregarObjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarObjeto.Location = New System.Drawing.Point(11, 6)
        Me.btnAgregarObjeto.Name = "btnAgregarObjeto"
        Me.btnAgregarObjeto.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarObjeto.TabIndex = 31
        Me.btnAgregarObjeto.Text = "Agregar Objeto"
        Me.btnAgregarObjeto.UseVisualStyleBackColor = False
        '
        'lblID_sucursal
        '
        Me.lblID_sucursal.AutoSize = True
        Me.lblID_sucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_sucursal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID_sucursal.Location = New System.Drawing.Point(294, 13)
        Me.lblID_sucursal.Name = "lblID_sucursal"
        Me.lblID_sucursal.Size = New System.Drawing.Size(86, 16)
        Me.lblID_sucursal.TabIndex = 29
        Me.lblID_sucursal.Text = "lblID_sucursal"
        Me.lblID_sucursal.Visible = False
        '
        'panelIzquierdo
        '
        Me.panelIzquierdo.Controls.Add(Me.DataGridView1)
        Me.panelIzquierdo.Location = New System.Drawing.Point(12, 149)
        Me.panelIzquierdo.Name = "panelIzquierdo"
        Me.panelIzquierdo.Size = New System.Drawing.Size(406, 486)
        Me.panelIzquierdo.TabIndex = 50
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(406, 486)
        Me.DataGridView1.TabIndex = 0
        '
        'btnBuscarObjeto
        '
        Me.btnBuscarObjeto.BackColor = System.Drawing.Color.White
        Me.btnBuscarObjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscarObjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarObjeto.Location = New System.Drawing.Point(343, 113)
        Me.btnBuscarObjeto.Name = "btnBuscarObjeto"
        Me.btnBuscarObjeto.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscarObjeto.TabIndex = 51
        Me.btnBuscarObjeto.Text = "Buscar"
        Me.btnBuscarObjeto.UseVisualStyleBackColor = False
        '
        'tbBuscarObjeto
        '
        Me.tbBuscarObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarObjeto.Location = New System.Drawing.Point(108, 117)
        Me.tbBuscarObjeto.Name = "tbBuscarObjeto"
        Me.tbBuscarObjeto.Size = New System.Drawing.Size(229, 24)
        Me.tbBuscarObjeto.TabIndex = 52
        '
        'lblBuscarObjeto
        '
        Me.lblBuscarObjeto.AutoSize = True
        Me.lblBuscarObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarObjeto.Location = New System.Drawing.Point(12, 120)
        Me.lblBuscarObjeto.Name = "lblBuscarObjeto"
        Me.lblBuscarObjeto.Size = New System.Drawing.Size(90, 16)
        Me.lblBuscarObjeto.TabIndex = 53
        Me.lblBuscarObjeto.Text = "Buscar Objeto"
        '
        'panelSupoerpuestoInformacion
        '
        Me.panelSupoerpuestoInformacion.Controls.Add(Me.PictureBox3)
        Me.panelSupoerpuestoInformacion.Controls.Add(Me.lblElpaneldeAcc)
        Me.panelSupoerpuestoInformacion.Controls.Add(Me.lblCuandoHayaSele)
        Me.panelSupoerpuestoInformacion.Controls.Add(Me.PictureBoxFechaIzquierda)
        Me.panelSupoerpuestoInformacion.Controls.Add(Me.lblParaComenzarBus)
        Me.panelSupoerpuestoInformacion.Location = New System.Drawing.Point(424, 100)
        Me.panelSupoerpuestoInformacion.Name = "panelSupoerpuestoInformacion"
        Me.panelSupoerpuestoInformacion.Size = New System.Drawing.Size(863, 541)
        Me.panelSupoerpuestoInformacion.TabIndex = 54
        '
        'PictureBoxFechaIzquierda
        '
        Me.PictureBoxFechaIzquierda.Image = Global.SIGPTASK.My.Resources.Resources.flechaLeft
        Me.PictureBoxFechaIzquierda.Location = New System.Drawing.Point(3, 0)
        Me.PictureBoxFechaIzquierda.Name = "PictureBoxFechaIzquierda"
        Me.PictureBoxFechaIzquierda.Size = New System.Drawing.Size(49, 56)
        Me.PictureBoxFechaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFechaIzquierda.TabIndex = 5
        Me.PictureBoxFechaIzquierda.TabStop = False
        '
        'lblParaComenzarBus
        '
        Me.lblParaComenzarBus.AutoSize = True
        Me.lblParaComenzarBus.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParaComenzarBus.Location = New System.Drawing.Point(58, 17)
        Me.lblParaComenzarBus.Name = "lblParaComenzarBus"
        Me.lblParaComenzarBus.Size = New System.Drawing.Size(397, 23)
        Me.lblParaComenzarBus.TabIndex = 4
        Me.lblParaComenzarBus.Text = "Para comenzar busque o agregre un objeto"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SIGPTASK.My.Resources.Resources.Windows_2_icon
        Me.PictureBox3.Location = New System.Drawing.Point(407, 332)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'lblElpaneldeAcc
        '
        Me.lblElpaneldeAcc.AutoSize = True
        Me.lblElpaneldeAcc.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElpaneldeAcc.Location = New System.Drawing.Point(198, 299)
        Me.lblElpaneldeAcc.Name = "lblElpaneldeAcc"
        Me.lblElpaneldeAcc.Size = New System.Drawing.Size(458, 21)
        Me.lblElpaneldeAcc.TabIndex = 8
        Me.lblElpaneldeAcc.Text = "se cargara dentro de este panel, puede cargar tantos como desee"
        '
        'lblCuandoHayaSele
        '
        Me.lblCuandoHayaSele.AutoSize = True
        Me.lblCuandoHayaSele.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuandoHayaSele.Location = New System.Drawing.Point(222, 276)
        Me.lblCuandoHayaSele.Name = "lblCuandoHayaSele"
        Me.lblCuandoHayaSele.Size = New System.Drawing.Size(410, 21)
        Me.lblCuandoHayaSele.TabIndex = 7
        Me.lblCuandoHayaSele.Text = "el objeto (insumo / elemento de prevencion) seleccionado"
        '
        'VentanaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1287, 683)
        Me.Controls.Add(Me.panelSupoerpuestoInformacion)
        Me.Controls.Add(Me.lblBuscarObjeto)
        Me.Controls.Add(Me.tbBuscarObjeto)
        Me.Controls.Add(Me.btnBuscarObjeto)
        Me.Controls.Add(Me.panelIzquierdo)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.tbCedulaEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbEmpresaSeleccionada)
        Me.Controls.Add(Me.lblEmpresaElegida)
        Me.Controls.Add(Me.tbEmpleadoSucursal)
        Me.Controls.Add(Me.lblTotalEmpleadosSucursal)
        Me.Controls.Add(Me.tbNombreInventario)
        Me.Controls.Add(Me.lblNombreInventario)
        Me.Controls.Add(Me.panelCentralPA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaInventario"
        Me.Text = "VentanaCuestionario"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.panelIzquierdo.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSupoerpuestoInformacion.ResumeLayout(False)
        Me.panelSupoerpuestoInformacion.PerformLayout()
        CType(Me.PictureBoxFechaIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelCentralPA As System.Windows.Forms.FlowLayoutPanel




    Friend WithEvents btnInventariar As System.Windows.Forms.Button
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents tbCedulaEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents tbEmpresaSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresaElegida As System.Windows.Forms.Label
    Friend WithEvents tbEmpleadoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalEmpleadosSucursal As System.Windows.Forms.Label
    Friend WithEvents tbNombreInventario As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreInventario As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents panelIzquierdo As System.Windows.Forms.Panel
    Friend WithEvents lblID_sucursal As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarObjeto As System.Windows.Forms.Button
    Friend WithEvents tbBuscarObjeto As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscarObjeto As System.Windows.Forms.Label
    Friend WithEvents btnAgregarObjeto As System.Windows.Forms.Button
    Friend WithEvents btnAgregarNota As System.Windows.Forms.Button
    Friend WithEvents panelSupoerpuestoInformacion As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxFechaIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents lblParaComenzarBus As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblElpaneldeAcc As System.Windows.Forms.Label
    Friend WithEvents lblCuandoHayaSele As System.Windows.Forms.Label

End Class
