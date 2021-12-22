<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaSeleccionReportesYControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaSeleccionReportesYControl))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReporteInventarios = New System.Windows.Forms.Button()
        Me.btnReportesMapasRiesgo = New System.Windows.Forms.Button()
        Me.btnReportesCuestionarios = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblFiltrarPorEmpresa = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.tbRUT = New System.Windows.Forms.TextBox()
        Me.comboListaEmpresas = New System.Windows.Forms.ComboBox()
        Me.comboTecnicosPrevencinista = New System.Windows.Forms.ComboBox()
        Me.lblFiltrarTecnicoPrevencionista = New System.Windows.Forms.Label()
        Me.lblRUT = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSELECTOR = New System.Windows.Forms.Label()
        Me.lblMatriculaTecnicoConectado = New System.Windows.Forms.Label()
        Me.panelReportes = New System.Windows.Forms.Panel()
        Me.panelControloYInspecciono = New System.Windows.Forms.Panel()
        Me.panelFiltros = New System.Windows.Forms.Panel()
        Me.btnBuscarConFiltros = New System.Windows.Forms.Button()
        Me.lblFiltrarPor = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblMapasPEndientesRevision = New System.Windows.Forms.Label()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelReportes.SuspendLayout()
        Me.panelControloYInspecciono.SuspendLayout()
        Me.panelFiltros.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(985, 28)
        Me.panelSuperior.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(960, 6)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 33
        Me.pictureClose.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(939, 6)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 34
        Me.pictureMinimize.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.Gray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 149)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(985, 456)
        Me.DataGridView1.TabIndex = 37
        '
        'btnReporteInventarios
        '
        Me.btnReporteInventarios.BackColor = System.Drawing.Color.White
        Me.btnReporteInventarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReporteInventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnReporteInventarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteInventarios.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteInventarios.Location = New System.Drawing.Point(389, 57)
        Me.btnReporteInventarios.Name = "btnReporteInventarios"
        Me.btnReporteInventarios.Size = New System.Drawing.Size(221, 30)
        Me.btnReporteInventarios.TabIndex = 49
        Me.btnReporteInventarios.Text = "Reportes de inventarios"
        Me.btnReporteInventarios.UseVisualStyleBackColor = False
        '
        'btnReportesMapasRiesgo
        '
        Me.btnReportesMapasRiesgo.BackColor = System.Drawing.Color.White
        Me.btnReportesMapasRiesgo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportesMapasRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnReportesMapasRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportesMapasRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesMapasRiesgo.Location = New System.Drawing.Point(616, 57)
        Me.btnReportesMapasRiesgo.Name = "btnReportesMapasRiesgo"
        Me.btnReportesMapasRiesgo.Size = New System.Drawing.Size(221, 30)
        Me.btnReportesMapasRiesgo.TabIndex = 48
        Me.btnReportesMapasRiesgo.Text = "Reportes de Mapas de riesgo"
        Me.btnReportesMapasRiesgo.UseVisualStyleBackColor = False
        '
        'btnReportesCuestionarios
        '
        Me.btnReportesCuestionarios.BackColor = System.Drawing.Color.White
        Me.btnReportesCuestionarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportesCuestionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnReportesCuestionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportesCuestionarios.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportesCuestionarios.Location = New System.Drawing.Point(162, 57)
        Me.btnReportesCuestionarios.Name = "btnReportesCuestionarios"
        Me.btnReportesCuestionarios.Size = New System.Drawing.Size(221, 30)
        Me.btnReportesCuestionarios.TabIndex = 47
        Me.btnReportesCuestionarios.Text = "Reportes de cuestionarios"
        Me.btnReportesCuestionarios.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(843, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 30)
        Me.btnBuscar.TabIndex = 46
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblFiltrarPorEmpresa
        '
        Me.lblFiltrarPorEmpresa.AutoSize = True
        Me.lblFiltrarPorEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrarPorEmpresa.Location = New System.Drawing.Point(26, 35)
        Me.lblFiltrarPorEmpresa.Name = "lblFiltrarPorEmpresa"
        Me.lblFiltrarPorEmpresa.Size = New System.Drawing.Size(121, 16)
        Me.lblFiltrarPorEmpresa.TabIndex = 40
        Me.lblFiltrarPorEmpresa.Text = "Filtrar por Empresa"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(18, 64)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(110, 16)
        Me.lblMatricula.TabIndex = 44
        Me.lblMatricula.Text = "Matricula Tecnico"
        '
        'tbMatricula
        '
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(134, 30)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.Size = New System.Drawing.Size(138, 24)
        Me.tbMatricula.TabIndex = 45
        '
        'tbRUT
        '
        Me.tbRUT.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRUT.Location = New System.Drawing.Point(134, 60)
        Me.tbRUT.Name = "tbRUT"
        Me.tbRUT.Size = New System.Drawing.Size(138, 24)
        Me.tbRUT.TabIndex = 42
        '
        'comboListaEmpresas
        '
        Me.comboListaEmpresas.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboListaEmpresas.FormattingEnabled = True
        Me.comboListaEmpresas.Location = New System.Drawing.Point(162, 27)
        Me.comboListaEmpresas.Name = "comboListaEmpresas"
        Me.comboListaEmpresas.Size = New System.Drawing.Size(448, 24)
        Me.comboListaEmpresas.TabIndex = 41
        '
        'comboTecnicosPrevencinista
        '
        Me.comboTecnicosPrevencinista.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboTecnicosPrevencinista.FormattingEnabled = True
        Me.comboTecnicosPrevencinista.Location = New System.Drawing.Point(616, 27)
        Me.comboTecnicosPrevencinista.Name = "comboTecnicosPrevencinista"
        Me.comboTecnicosPrevencinista.Size = New System.Drawing.Size(221, 24)
        Me.comboTecnicosPrevencinista.TabIndex = 38
        '
        'lblFiltrarTecnicoPrevencionista
        '
        Me.lblFiltrarTecnicoPrevencionista.AutoSize = True
        Me.lblFiltrarTecnicoPrevencionista.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrarTecnicoPrevencionista.Location = New System.Drawing.Point(623, 8)
        Me.lblFiltrarTecnicoPrevencionista.Name = "lblFiltrarTecnicoPrevencionista"
        Me.lblFiltrarTecnicoPrevencionista.Size = New System.Drawing.Size(201, 16)
        Me.lblFiltrarTecnicoPrevencionista.TabIndex = 39
        Me.lblFiltrarTecnicoPrevencionista.Text = "Filtrar por Tecnico Prevencionista"
        '
        'lblRUT
        '
        Me.lblRUT.AutoSize = True
        Me.lblRUT.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRUT.Location = New System.Drawing.Point(96, 34)
        Me.lblRUT.Name = "lblRUT"
        Me.lblRUT.Size = New System.Drawing.Size(32, 16)
        Me.lblRUT.TabIndex = 43
        Me.lblRUT.Text = "RUT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSELECTOR)
        Me.Panel1.Controls.Add(Me.lblMatriculaTecnicoConectado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 605)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 40)
        Me.Panel1.TabIndex = 51
        '
        'lblSELECTOR
        '
        Me.lblSELECTOR.AutoSize = True
        Me.lblSELECTOR.ForeColor = System.Drawing.Color.White
        Me.lblSELECTOR.Location = New System.Drawing.Point(194, 14)
        Me.lblSELECTOR.Name = "lblSELECTOR"
        Me.lblSELECTOR.Size = New System.Drawing.Size(64, 13)
        Me.lblSELECTOR.TabIndex = 52
        Me.lblSELECTOR.Text = "SELECTOR"
        Me.lblSELECTOR.Visible = False
        '
        'lblMatriculaTecnicoConectado
        '
        Me.lblMatriculaTecnicoConectado.AutoSize = True
        Me.lblMatriculaTecnicoConectado.ForeColor = System.Drawing.Color.White
        Me.lblMatriculaTecnicoConectado.Location = New System.Drawing.Point(12, 14)
        Me.lblMatriculaTecnicoConectado.Name = "lblMatriculaTecnicoConectado"
        Me.lblMatriculaTecnicoConectado.Size = New System.Drawing.Size(151, 13)
        Me.lblMatriculaTecnicoConectado.TabIndex = 51
        Me.lblMatriculaTecnicoConectado.Text = "lblMatriculaTecnicoConectado"
        '
        'panelReportes
        '
        Me.panelReportes.BackColor = System.Drawing.Color.White
        Me.panelReportes.Controls.Add(Me.lblFiltrarPorEmpresa)
        Me.panelReportes.Controls.Add(Me.btnReportesCuestionarios)
        Me.panelReportes.Controls.Add(Me.lblFiltrarTecnicoPrevencionista)
        Me.panelReportes.Controls.Add(Me.btnReporteInventarios)
        Me.panelReportes.Controls.Add(Me.btnReportesMapasRiesgo)
        Me.panelReportes.Controls.Add(Me.comboListaEmpresas)
        Me.panelReportes.Controls.Add(Me.btnBuscar)
        Me.panelReportes.Controls.Add(Me.comboTecnicosPrevencinista)
        Me.panelReportes.Location = New System.Drawing.Point(0, 56)
        Me.panelReportes.Name = "panelReportes"
        Me.panelReportes.Size = New System.Drawing.Size(985, 87)
        Me.panelReportes.TabIndex = 53
        '
        'panelControloYInspecciono
        '
        Me.panelControloYInspecciono.BackColor = System.Drawing.Color.White
        Me.panelControloYInspecciono.Controls.Add(Me.panelFiltros)
        Me.panelControloYInspecciono.Controls.Add(Me.PictureBox2)
        Me.panelControloYInspecciono.Controls.Add(Me.lblMapasPEndientesRevision)
        Me.panelControloYInspecciono.Location = New System.Drawing.Point(0, 30)
        Me.panelControloYInspecciono.Name = "panelControloYInspecciono"
        Me.panelControloYInspecciono.Size = New System.Drawing.Size(985, 113)
        Me.panelControloYInspecciono.TabIndex = 51
        '
        'panelFiltros
        '
        Me.panelFiltros.Controls.Add(Me.btnBuscarConFiltros)
        Me.panelFiltros.Controls.Add(Me.lblRUT)
        Me.panelFiltros.Controls.Add(Me.lblFiltrarPor)
        Me.panelFiltros.Controls.Add(Me.tbRUT)
        Me.panelFiltros.Controls.Add(Me.tbMatricula)
        Me.panelFiltros.Controls.Add(Me.lblMatricula)
        Me.panelFiltros.Location = New System.Drawing.Point(592, 10)
        Me.panelFiltros.Name = "panelFiltros"
        Me.panelFiltros.Size = New System.Drawing.Size(383, 93)
        Me.panelFiltros.TabIndex = 54
        '
        'btnBuscarConFiltros
        '
        Me.btnBuscarConFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscarConFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscarConFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarConFiltros.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarConFiltros.Location = New System.Drawing.Point(281, 40)
        Me.btnBuscarConFiltros.Name = "btnBuscarConFiltros"
        Me.btnBuscarConFiltros.Size = New System.Drawing.Size(93, 30)
        Me.btnBuscarConFiltros.TabIndex = 54
        Me.btnBuscarConFiltros.Text = "Filtrar"
        Me.btnBuscarConFiltros.UseVisualStyleBackColor = True
        '
        'lblFiltrarPor
        '
        Me.lblFiltrarPor.AutoSize = True
        Me.lblFiltrarPor.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrarPor.Location = New System.Drawing.Point(167, 6)
        Me.lblFiltrarPor.Name = "lblFiltrarPor"
        Me.lblFiltrarPor.Size = New System.Drawing.Size(73, 21)
        Me.lblFiltrarPor.TabIndex = 53
        Me.lblFiltrarPor.Text = "Filtar por"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SIGPTASK.My.Resources.Resources.critico
        Me.PictureBox2.Location = New System.Drawing.Point(9, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'lblMapasPEndientesRevision
        '
        Me.lblMapasPEndientesRevision.AutoSize = True
        Me.lblMapasPEndientesRevision.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMapasPEndientesRevision.Location = New System.Drawing.Point(62, 40)
        Me.lblMapasPEndientesRevision.Name = "lblMapasPEndientesRevision"
        Me.lblMapasPEndientesRevision.Size = New System.Drawing.Size(458, 26)
        Me.lblMapasPEndientesRevision.TabIndex = 51
        Me.lblMapasPEndientesRevision.Text = "Mapas de riesgo pendientes de visita de Control"
        '
        'VentanaSeleccionReportesYControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 645)
        Me.Controls.Add(Me.panelReportes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.panelControloYInspecciono)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaSeleccionReportesYControl"
        Me.Text = "VentanaSeleccionHistoricos"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelReportes.ResumeLayout(False)
        Me.panelReportes.PerformLayout()
        Me.panelControloYInspecciono.ResumeLayout(False)
        Me.panelControloYInspecciono.PerformLayout()
        Me.panelFiltros.ResumeLayout(False)
        Me.panelFiltros.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnReporteInventarios As System.Windows.Forms.Button
    Friend WithEvents btnReportesMapasRiesgo As System.Windows.Forms.Button
    Friend WithEvents btnReportesCuestionarios As System.Windows.Forms.Button
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblFiltrarPorEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents tbRUT As System.Windows.Forms.TextBox
    Friend WithEvents comboListaEmpresas As System.Windows.Forms.ComboBox
    Friend WithEvents comboTecnicosPrevencinista As System.Windows.Forms.ComboBox
    Friend WithEvents lblFiltrarTecnicoPrevencionista As System.Windows.Forms.Label
    Friend WithEvents lblRUT As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelReportes As System.Windows.Forms.Panel
    Friend WithEvents panelControloYInspecciono As System.Windows.Forms.Panel
    Friend WithEvents lblMatriculaTecnicoConectado As System.Windows.Forms.Label
    Friend WithEvents lblSELECTOR As System.Windows.Forms.Label
    Friend WithEvents lblMapasPEndientesRevision As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents panelFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblFiltrarPor As System.Windows.Forms.Label
    Friend WithEvents btnBuscarConFiltros As System.Windows.Forms.Button
End Class
