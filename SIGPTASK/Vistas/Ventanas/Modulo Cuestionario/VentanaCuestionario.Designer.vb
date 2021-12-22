<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCuestionario
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCuestionario))
        Me.panelCentralPA = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNombreCuestionario = New System.Windows.Forms.Label()
        Me.tbNombreCuestionario = New System.Windows.Forms.TextBox()
        Me.lblTotalEmpleadosSucursal = New System.Windows.Forms.Label()
        Me.tbEmpleadoSucursal = New System.Windows.Forms.TextBox()
        Me.lblEmpresaElegida = New System.Windows.Forms.Label()
        Me.tbEmpresaSeleccionada = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.panelIzquierdoPre = New System.Windows.Forms.Panel()
        Me.DataGridPregunta = New System.Windows.Forms.DataGridView()
        Me.panelDerechoAccion = New System.Windows.Forms.Panel()
        Me.DataGridAcciones = New System.Windows.Forms.DataGridView()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.lblID_sucursal = New System.Windows.Forms.Label()
        Me.btnEvaluar = New System.Windows.Forms.Button()
        Me.btnAgregarAccion = New System.Windows.Forms.Button()
        Me.lblCuestionarioID = New System.Windows.Forms.Label()
        Me.btnAgregarPregunta = New System.Windows.Forms.Button()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnAgregarNota = New System.Windows.Forms.Button()
        Me.btnGuardarCuestionario = New System.Windows.Forms.Button()
        Me.lblCedulaEmpleado = New System.Windows.Forms.Label()
        Me.tbCedulaEmpleado = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lblBuscarPregunta = New System.Windows.Forms.Label()
        Me.tbBuscarPregunta = New System.Windows.Forms.TextBox()
        Me.btnBuscarPregunta = New System.Windows.Forms.Button()
        Me.lblBuscarAccion = New System.Windows.Forms.Label()
        Me.tbBuscarAccion = New System.Windows.Forms.TextBox()
        Me.btnBuscarAccion = New System.Windows.Forms.Button()
        Me.panelSuperpuestoInformacionInicial = New System.Windows.Forms.Panel()
        Me.lblElpaneldeAcc = New System.Windows.Forms.Label()
        Me.lblCuandoHayaSele = New System.Windows.Forms.Label()
        Me.lblParaComenzarBus = New System.Windows.Forms.Label()
        Me.lblCargaraPanel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFechaDerrecha = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFechaIzquierda = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.panelIzquierdoPre.SuspendLayout()
        CType(Me.DataGridPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDerechoAccion.SuspendLayout()
        CType(Me.DataGridAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        Me.panelInferior.SuspendLayout()
        Me.panelSuperpuestoInformacionInicial.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFechaDerrecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFechaIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelCentralPA
        '
        Me.panelCentralPA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCentralPA.AutoScroll = True
        Me.panelCentralPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelCentralPA.Location = New System.Drawing.Point(363, 117)
        Me.panelCentralPA.Name = "panelCentralPA"
        Me.panelCentralPA.Size = New System.Drawing.Size(560, 517)
        Me.panelCentralPA.TabIndex = 2
        '
        'lblNombreCuestionario
        '
        Me.lblNombreCuestionario.AutoSize = True
        Me.lblNombreCuestionario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCuestionario.Location = New System.Drawing.Point(5, 75)
        Me.lblNombreCuestionario.Name = "lblNombreCuestionario"
        Me.lblNombreCuestionario.Size = New System.Drawing.Size(153, 16)
        Me.lblNombreCuestionario.TabIndex = 5
        Me.lblNombreCuestionario.Text = "Nombre de Cuestionario"
        '
        'tbNombreCuestionario
        '
        Me.tbNombreCuestionario.BackColor = System.Drawing.Color.White
        Me.tbNombreCuestionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreCuestionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreCuestionario.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreCuestionario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreCuestionario.Location = New System.Drawing.Point(169, 71)
        Me.tbNombreCuestionario.Name = "tbNombreCuestionario"
        Me.tbNombreCuestionario.ReadOnly = True
        Me.tbNombreCuestionario.ShortcutsEnabled = False
        Me.tbNombreCuestionario.Size = New System.Drawing.Size(616, 24)
        Me.tbNombreCuestionario.TabIndex = 7
        Me.tbNombreCuestionario.TabStop = False
        '
        'lblTotalEmpleadosSucursal
        '
        Me.lblTotalEmpleadosSucursal.AutoSize = True
        Me.lblTotalEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmpleadosSucursal.Location = New System.Drawing.Point(790, 40)
        Me.lblTotalEmpleadosSucursal.Name = "lblTotalEmpleadosSucursal"
        Me.lblTotalEmpleadosSucursal.Size = New System.Drawing.Size(164, 16)
        Me.lblTotalEmpleadosSucursal.TabIndex = 12
        Me.lblTotalEmpleadosSucursal.Text = "| Empleados de la sucursal"
        '
        'tbEmpleadoSucursal
        '
        Me.tbEmpleadoSucursal.BackColor = System.Drawing.Color.White
        Me.tbEmpleadoSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpleadoSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpleadoSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpleadoSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadoSucursal.Location = New System.Drawing.Point(967, 36)
        Me.tbEmpleadoSucursal.Name = "tbEmpleadoSucursal"
        Me.tbEmpleadoSucursal.ReadOnly = True
        Me.tbEmpleadoSucursal.ShortcutsEnabled = False
        Me.tbEmpleadoSucursal.Size = New System.Drawing.Size(153, 24)
        Me.tbEmpleadoSucursal.TabIndex = 15
        Me.tbEmpleadoSucursal.TabStop = False
        '
        'lblEmpresaElegida
        '
        Me.lblEmpresaElegida.AutoSize = True
        Me.lblEmpresaElegida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpresaElegida.Location = New System.Drawing.Point(5, 40)
        Me.lblEmpresaElegida.Name = "lblEmpresaElegida"
        Me.lblEmpresaElegida.Size = New System.Drawing.Size(139, 16)
        Me.lblEmpresaElegida.TabIndex = 16
        Me.lblEmpresaElegida.Text = "Empresa Seleccionada"
        '
        'tbEmpresaSeleccionada
        '
        Me.tbEmpresaSeleccionada.BackColor = System.Drawing.Color.White
        Me.tbEmpresaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpresaSeleccionada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpresaSeleccionada.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpresaSeleccionada.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresaSeleccionada.Location = New System.Drawing.Point(169, 36)
        Me.tbEmpresaSeleccionada.Name = "tbEmpresaSeleccionada"
        Me.tbEmpresaSeleccionada.ReadOnly = True
        Me.tbEmpresaSeleccionada.ShortcutsEnabled = False
        Me.tbEmpresaSeleccionada.Size = New System.Drawing.Size(616, 24)
        Me.tbEmpresaSeleccionada.TabIndex = 17
        Me.tbEmpresaSeleccionada.TabStop = False
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(1178, 36)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(99, 24)
        Me.tbFecha.TabIndex = 21
        Me.tbFecha.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1125, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 22
        Me.lblFecha.Text = "| Fecha"
        '
        'panelIzquierdoPre
        '
        Me.panelIzquierdoPre.Controls.Add(Me.DataGridPregunta)
        Me.panelIzquierdoPre.Location = New System.Drawing.Point(0, 151)
        Me.panelIzquierdoPre.Name = "panelIzquierdoPre"
        Me.panelIzquierdoPre.Size = New System.Drawing.Size(357, 483)
        Me.panelIzquierdoPre.TabIndex = 23
        '
        'DataGridPregunta
        '
        Me.DataGridPregunta.AllowUserToAddRows = False
        Me.DataGridPregunta.AllowUserToDeleteRows = False
        Me.DataGridPregunta.AllowUserToResizeColumns = False
        Me.DataGridPregunta.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPregunta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridPregunta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridPregunta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridPregunta.BackgroundColor = System.Drawing.Color.White
        Me.DataGridPregunta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPregunta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridPregunta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPregunta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridPregunta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridPregunta.Location = New System.Drawing.Point(0, 0)
        Me.DataGridPregunta.MultiSelect = False
        Me.DataGridPregunta.Name = "DataGridPregunta"
        Me.DataGridPregunta.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPregunta.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridPregunta.RowHeadersVisible = False
        Me.DataGridPregunta.RowHeadersWidth = 50
        Me.DataGridPregunta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPregunta.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridPregunta.RowTemplate.ReadOnly = True
        Me.DataGridPregunta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridPregunta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPregunta.Size = New System.Drawing.Size(357, 483)
        Me.DataGridPregunta.TabIndex = 0
        Me.DataGridPregunta.TabStop = False
        '
        'panelDerechoAccion
        '
        Me.panelDerechoAccion.Controls.Add(Me.DataGridAcciones)
        Me.panelDerechoAccion.Location = New System.Drawing.Point(929, 151)
        Me.panelDerechoAccion.Name = "panelDerechoAccion"
        Me.panelDerechoAccion.Size = New System.Drawing.Size(358, 483)
        Me.panelDerechoAccion.TabIndex = 24
        '
        'DataGridAcciones
        '
        Me.DataGridAcciones.AllowUserToAddRows = False
        Me.DataGridAcciones.AllowUserToDeleteRows = False
        Me.DataGridAcciones.AllowUserToResizeColumns = False
        Me.DataGridAcciones.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAcciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAcciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridAcciones.BackgroundColor = System.Drawing.Color.White
        Me.DataGridAcciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAcciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAcciones.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridAcciones.Location = New System.Drawing.Point(0, 0)
        Me.DataGridAcciones.MultiSelect = False
        Me.DataGridAcciones.Name = "DataGridAcciones"
        Me.DataGridAcciones.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAcciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridAcciones.RowHeadersVisible = False
        Me.DataGridAcciones.RowHeadersWidth = 50
        Me.DataGridAcciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAcciones.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridAcciones.RowTemplate.ReadOnly = True
        Me.DataGridAcciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridAcciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAcciones.Size = New System.Drawing.Size(358, 483)
        Me.DataGridAcciones.TabIndex = 0
        Me.DataGridAcciones.TabStop = False
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.PictureBox2)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1287, 25)
        Me.panelSuperior.TabIndex = 28
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.lblID_sucursal)
        Me.panelInferior.Controls.Add(Me.btnEvaluar)
        Me.panelInferior.Controls.Add(Me.btnAgregarAccion)
        Me.panelInferior.Controls.Add(Me.lblCuestionarioID)
        Me.panelInferior.Controls.Add(Me.btnAgregarPregunta)
        Me.panelInferior.Controls.Add(Me.lblEstado)
        Me.panelInferior.Controls.Add(Me.btnAgregarNota)
        Me.panelInferior.Controls.Add(Me.btnGuardarCuestionario)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 643)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(1287, 40)
        Me.panelInferior.TabIndex = 29
        '
        'lblID_sucursal
        '
        Me.lblID_sucursal.AutoSize = True
        Me.lblID_sucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_sucursal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblID_sucursal.Location = New System.Drawing.Point(922, 12)
        Me.lblID_sucursal.Name = "lblID_sucursal"
        Me.lblID_sucursal.Size = New System.Drawing.Size(86, 16)
        Me.lblID_sucursal.TabIndex = 28
        Me.lblID_sucursal.Text = "lblID_sucursal"
        Me.lblID_sucursal.Visible = False
        '
        'btnEvaluar
        '
        Me.btnEvaluar.BackColor = System.Drawing.Color.White
        Me.btnEvaluar.FlatAppearance.BorderSize = 0
        Me.btnEvaluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnEvaluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluar.Location = New System.Drawing.Point(1161, 5)
        Me.btnEvaluar.Name = "btnEvaluar"
        Me.btnEvaluar.Size = New System.Drawing.Size(120, 30)
        Me.btnEvaluar.TabIndex = 14
        Me.btnEvaluar.Text = "Evaluar"
        Me.btnEvaluar.UseVisualStyleBackColor = False
        '
        'btnAgregarAccion
        '
        Me.btnAgregarAccion.BackColor = System.Drawing.Color.White
        Me.btnAgregarAccion.FlatAppearance.BorderSize = 0
        Me.btnAgregarAccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAccion.Location = New System.Drawing.Point(723, 5)
        Me.btnAgregarAccion.Name = "btnAgregarAccion"
        Me.btnAgregarAccion.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarAccion.TabIndex = 27
        Me.btnAgregarAccion.Text = "Agregar Accion"
        Me.btnAgregarAccion.UseVisualStyleBackColor = False
        '
        'lblCuestionarioID
        '
        Me.lblCuestionarioID.AutoSize = True
        Me.lblCuestionarioID.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioID.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCuestionarioID.Location = New System.Drawing.Point(240, 12)
        Me.lblCuestionarioID.Name = "lblCuestionarioID"
        Me.lblCuestionarioID.Size = New System.Drawing.Size(107, 16)
        Me.lblCuestionarioID.TabIndex = 6
        Me.lblCuestionarioID.Text = "lblCuestionarioID"
        Me.lblCuestionarioID.Visible = False
        '
        'btnAgregarPregunta
        '
        Me.btnAgregarPregunta.BackColor = System.Drawing.Color.White
        Me.btnAgregarPregunta.FlatAppearance.BorderSize = 0
        Me.btnAgregarPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPregunta.Location = New System.Drawing.Point(451, 5)
        Me.btnAgregarPregunta.Name = "btnAgregarPregunta"
        Me.btnAgregarPregunta.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarPregunta.TabIndex = 26
        Me.btnAgregarPregunta.Text = "Agregar Pregunta"
        Me.btnAgregarPregunta.UseVisualStyleBackColor = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEstado.Location = New System.Drawing.Point(162, 12)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(62, 16)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "lblEstado"
        Me.lblEstado.Visible = False
        '
        'btnAgregarNota
        '
        Me.btnAgregarNota.BackColor = System.Drawing.Color.White
        Me.btnAgregarNota.FlatAppearance.BorderSize = 0
        Me.btnAgregarNota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarNota.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNota.Location = New System.Drawing.Point(587, 5)
        Me.btnAgregarNota.Name = "btnAgregarNota"
        Me.btnAgregarNota.Size = New System.Drawing.Size(130, 30)
        Me.btnAgregarNota.TabIndex = 25
        Me.btnAgregarNota.Text = "Agregar Nota"
        Me.btnAgregarNota.UseVisualStyleBackColor = False
        '
        'btnGuardarCuestionario
        '
        Me.btnGuardarCuestionario.BackColor = System.Drawing.Color.White
        Me.btnGuardarCuestionario.FlatAppearance.BorderSize = 0
        Me.btnGuardarCuestionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnGuardarCuestionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCuestionario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCuestionario.Location = New System.Drawing.Point(8, 5)
        Me.btnGuardarCuestionario.Name = "btnGuardarCuestionario"
        Me.btnGuardarCuestionario.Size = New System.Drawing.Size(120, 30)
        Me.btnGuardarCuestionario.TabIndex = 18
        Me.btnGuardarCuestionario.Text = "Guardar"
        Me.btnGuardarCuestionario.UseVisualStyleBackColor = False
        Me.btnGuardarCuestionario.Visible = False
        '
        'lblCedulaEmpleado
        '
        Me.lblCedulaEmpleado.AutoSize = True
        Me.lblCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaEmpleado.Location = New System.Drawing.Point(790, 75)
        Me.lblCedulaEmpleado.Name = "lblCedulaEmpleado"
        Me.lblCedulaEmpleado.Size = New System.Drawing.Size(118, 16)
        Me.lblCedulaEmpleado.TabIndex = 32
        Me.lblCedulaEmpleado.Text = "| Cedula Empleado"
        '
        'tbCedulaEmpleado
        '
        Me.tbCedulaEmpleado.BackColor = System.Drawing.Color.White
        Me.tbCedulaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCedulaEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCedulaEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCedulaEmpleado.Location = New System.Drawing.Point(910, 71)
        Me.tbCedulaEmpleado.Name = "tbCedulaEmpleado"
        Me.tbCedulaEmpleado.ReadOnly = True
        Me.tbCedulaEmpleado.ShortcutsEnabled = False
        Me.tbCedulaEmpleado.Size = New System.Drawing.Size(120, 24)
        Me.tbCedulaEmpleado.TabIndex = 33
        Me.tbCedulaEmpleado.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(1036, 75)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 34
        Me.lblMatricula.Text = "| Matricula"
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(1128, 71)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(149, 24)
        Me.tbMatricula.TabIndex = 35
        Me.tbMatricula.TabStop = False
        '
        'lblBuscarPregunta
        '
        Me.lblBuscarPregunta.AutoSize = True
        Me.lblBuscarPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarPregunta.Location = New System.Drawing.Point(5, 102)
        Me.lblBuscarPregunta.Name = "lblBuscarPregunta"
        Me.lblBuscarPregunta.Size = New System.Drawing.Size(102, 16)
        Me.lblBuscarPregunta.TabIndex = 56
        Me.lblBuscarPregunta.Text = "Buscar Pregunta"
        '
        'tbBuscarPregunta
        '
        Me.tbBuscarPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarPregunta.Location = New System.Drawing.Point(5, 121)
        Me.tbBuscarPregunta.Name = "tbBuscarPregunta"
        Me.tbBuscarPregunta.Size = New System.Drawing.Size(271, 24)
        Me.tbBuscarPregunta.TabIndex = 55
        Me.tbBuscarPregunta.TabStop = False
        '
        'btnBuscarPregunta
        '
        Me.btnBuscarPregunta.BackColor = System.Drawing.Color.White
        Me.btnBuscarPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPregunta.Location = New System.Drawing.Point(282, 117)
        Me.btnBuscarPregunta.Name = "btnBuscarPregunta"
        Me.btnBuscarPregunta.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscarPregunta.TabIndex = 54
        Me.btnBuscarPregunta.Text = "Buscar"
        Me.btnBuscarPregunta.UseVisualStyleBackColor = False
        '
        'lblBuscarAccion
        '
        Me.lblBuscarAccion.AutoSize = True
        Me.lblBuscarAccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarAccion.Location = New System.Drawing.Point(929, 102)
        Me.lblBuscarAccion.Name = "lblBuscarAccion"
        Me.lblBuscarAccion.Size = New System.Drawing.Size(88, 16)
        Me.lblBuscarAccion.TabIndex = 57
        Me.lblBuscarAccion.Text = "Buscar Accion"
        '
        'tbBuscarAccion
        '
        Me.tbBuscarAccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarAccion.Location = New System.Drawing.Point(929, 120)
        Me.tbBuscarAccion.Name = "tbBuscarAccion"
        Me.tbBuscarAccion.Size = New System.Drawing.Size(271, 24)
        Me.tbBuscarAccion.TabIndex = 59
        Me.tbBuscarAccion.TabStop = False
        '
        'btnBuscarAccion
        '
        Me.btnBuscarAccion.BackColor = System.Drawing.Color.White
        Me.btnBuscarAccion.Enabled = False
        Me.btnBuscarAccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscarAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarAccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarAccion.Location = New System.Drawing.Point(1206, 117)
        Me.btnBuscarAccion.Name = "btnBuscarAccion"
        Me.btnBuscarAccion.Size = New System.Drawing.Size(75, 30)
        Me.btnBuscarAccion.TabIndex = 58
        Me.btnBuscarAccion.Text = "Buscar"
        Me.btnBuscarAccion.UseVisualStyleBackColor = False
        '
        'panelSuperpuestoInformacionInicial
        '
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.PictureBox3)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.lblCargaraPanel)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.PictureBoxFechaDerrecha)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.PictureBoxFechaIzquierda)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.lblElpaneldeAcc)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.lblCuandoHayaSele)
        Me.panelSuperpuestoInformacionInicial.Controls.Add(Me.lblParaComenzarBus)
        Me.panelSuperpuestoInformacionInicial.Location = New System.Drawing.Point(363, 102)
        Me.panelSuperpuestoInformacionInicial.Name = "panelSuperpuestoInformacionInicial"
        Me.panelSuperpuestoInformacionInicial.Size = New System.Drawing.Size(560, 540)
        Me.panelSuperpuestoInformacionInicial.TabIndex = 60
        '
        'lblElpaneldeAcc
        '
        Me.lblElpaneldeAcc.AutoSize = True
        Me.lblElpaneldeAcc.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElpaneldeAcc.Location = New System.Drawing.Point(126, 263)
        Me.lblElpaneldeAcc.Name = "lblElpaneldeAcc"
        Me.lblElpaneldeAcc.Size = New System.Drawing.Size(385, 21)
        Me.lblElpaneldeAcc.TabIndex = 2
        Me.lblElpaneldeAcc.Text = "el panel de Acciones (contigencias) al seleccioanar una"
        '
        'lblCuandoHayaSele
        '
        Me.lblCuandoHayaSele.AutoSize = True
        Me.lblCuandoHayaSele.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuandoHayaSele.Location = New System.Drawing.Point(135, 240)
        Me.lblCuandoHayaSele.Name = "lblCuandoHayaSele"
        Me.lblCuandoHayaSele.Size = New System.Drawing.Size(376, 21)
        Me.lblCuandoHayaSele.TabIndex = 1
        Me.lblCuandoHayaSele.Text = "cuando haya seleccionado una pregunta se habilitará"
        '
        'lblParaComenzarBus
        '
        Me.lblParaComenzarBus.AutoSize = True
        Me.lblParaComenzarBus.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParaComenzarBus.Location = New System.Drawing.Point(58, 20)
        Me.lblParaComenzarBus.Name = "lblParaComenzarBus"
        Me.lblParaComenzarBus.Size = New System.Drawing.Size(432, 23)
        Me.lblParaComenzarBus.TabIndex = 0
        Me.lblParaComenzarBus.Text = "Para comenzar busque o agregre una pregunta"
        '
        'lblCargaraPanel
        '
        Me.lblCargaraPanel.AutoSize = True
        Me.lblCargaraPanel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaraPanel.Location = New System.Drawing.Point(184, 468)
        Me.lblCargaraPanel.Name = "lblCargaraPanel"
        Me.lblCargaraPanel.Size = New System.Drawing.Size(183, 16)
        Me.lblCargaraPanel.TabIndex = 5
        Me.lblCargaraPanel.Text = "cargará un panel en esta área"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SIGPTASK.My.Resources.Resources.Windows_2_icon
        Me.PictureBox3.Location = New System.Drawing.Point(369, 454)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBoxFechaDerrecha
        '
        Me.PictureBoxFechaDerrecha.Image = Global.SIGPTASK.My.Resources.Resources.flechaRigth
        Me.PictureBoxFechaDerrecha.Location = New System.Drawing.Point(517, 240)
        Me.PictureBoxFechaDerrecha.Name = "PictureBoxFechaDerrecha"
        Me.PictureBoxFechaDerrecha.Size = New System.Drawing.Size(40, 42)
        Me.PictureBoxFechaDerrecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFechaDerrecha.TabIndex = 4
        Me.PictureBoxFechaDerrecha.TabStop = False
        '
        'PictureBoxFechaIzquierda
        '
        Me.PictureBoxFechaIzquierda.Image = Global.SIGPTASK.My.Resources.Resources.flechaLeft
        Me.PictureBoxFechaIzquierda.Location = New System.Drawing.Point(3, 3)
        Me.PictureBoxFechaIzquierda.Name = "PictureBoxFechaIzquierda"
        Me.PictureBoxFechaIzquierda.Size = New System.Drawing.Size(49, 56)
        Me.PictureBoxFechaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFechaIzquierda.TabIndex = 3
        Me.PictureBoxFechaIzquierda.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(1244, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 32
        Me.pictureMinimize.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox2.Location = New System.Drawing.Point(-53, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(1265, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 29
        Me.pictureClose.TabStop = False
        '
        'VentanaCuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1287, 683)
        Me.Controls.Add(Me.panelSuperpuestoInformacionInicial)
        Me.Controls.Add(Me.tbBuscarAccion)
        Me.Controls.Add(Me.btnBuscarAccion)
        Me.Controls.Add(Me.lblBuscarAccion)
        Me.Controls.Add(Me.lblBuscarPregunta)
        Me.Controls.Add(Me.tbBuscarPregunta)
        Me.Controls.Add(Me.btnBuscarPregunta)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.tbCedulaEmpleado)
        Me.Controls.Add(Me.lblCedulaEmpleado)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.panelDerechoAccion)
        Me.Controls.Add(Me.panelIzquierdoPre)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbEmpresaSeleccionada)
        Me.Controls.Add(Me.lblEmpresaElegida)
        Me.Controls.Add(Me.tbEmpleadoSucursal)
        Me.Controls.Add(Me.lblTotalEmpleadosSucursal)
        Me.Controls.Add(Me.tbNombreCuestionario)
        Me.Controls.Add(Me.lblNombreCuestionario)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.panelCentralPA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaCuestionario"
        Me.Text = "VentanaCuestionario"
        Me.panelIzquierdoPre.ResumeLayout(False)
        CType(Me.DataGridPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDerechoAccion.ResumeLayout(False)
        CType(Me.DataGridAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.panelSuperpuestoInformacionInicial.ResumeLayout(False)
        Me.panelSuperpuestoInformacionInicial.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFechaDerrecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFechaIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelCentralPA As System.Windows.Forms.FlowLayoutPanel



    Friend WithEvents clAgregar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblNombreCuestionario As System.Windows.Forms.Label
    Friend WithEvents lblCuestionarioID As System.Windows.Forms.Label
    Friend WithEvents tbNombreCuestionario As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalEmpleadosSucursal As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents btnEvaluar As System.Windows.Forms.Button
    Friend WithEvents tbEmpleadoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpresaElegida As System.Windows.Forms.Label
    Friend WithEvents tbEmpresaSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarCuestionario As System.Windows.Forms.Button
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents panelIzquierdoPre As System.Windows.Forms.Panel
    Friend WithEvents panelDerechoAccion As System.Windows.Forms.Panel

    Friend WithEvents btnAgregarNota As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPregunta As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAccion As System.Windows.Forms.Button
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents lblCedulaEmpleado As System.Windows.Forms.Label
    Friend WithEvents tbCedulaEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblID_sucursal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBuscarPregunta As System.Windows.Forms.Label
    Friend WithEvents tbBuscarPregunta As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarPregunta As System.Windows.Forms.Button
    Friend WithEvents lblBuscarAccion As System.Windows.Forms.Label
    Friend WithEvents tbBuscarAccion As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarAccion As System.Windows.Forms.Button
    Friend WithEvents DataGridPregunta As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridAcciones As System.Windows.Forms.DataGridView
    Friend WithEvents panelSuperpuestoInformacionInicial As System.Windows.Forms.Panel
    Friend WithEvents lblElpaneldeAcc As System.Windows.Forms.Label
    Friend WithEvents lblCuandoHayaSele As System.Windows.Forms.Label
    Friend WithEvents lblParaComenzarBus As System.Windows.Forms.Label
    Friend WithEvents PictureBoxFechaIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxFechaDerrecha As System.Windows.Forms.PictureBox
    Friend WithEvents lblCargaraPanel As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
