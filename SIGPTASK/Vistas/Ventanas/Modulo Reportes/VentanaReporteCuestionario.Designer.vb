<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaReporteCuestionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaReporteCuestionario))
        Me.barraProgreso = New System.Windows.Forms.ProgressBar()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.tbCuestionarioSeleccionado = New System.Windows.Forms.TextBox()
        Me.lblCuestionarioSeleccionado = New System.Windows.Forms.Label()
        Me.tbEmpleadosSucursal = New System.Windows.Forms.TextBox()
        Me.lblTotalEmpleadosSucursal = New System.Windows.Forms.Label()
        Me.tbNombreSucursal = New System.Windows.Forms.TextBox()
        Me.lblNombreDeLaSucursal = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.btnMostrarNotas = New System.Windows.Forms.Button()
        Me.lblQvalorFinal = New System.Windows.Forms.Label()
        Me.lblvBase = New System.Windows.Forms.Label()
        Me.btnMostrarDetalles = New System.Windows.Forms.Button()
        Me.lblFinalRiskValue = New System.Windows.Forms.Label()
        Me.lblConteo = New System.Windows.Forms.Label()
        Me.lblAnguloDeGiro = New System.Windows.Forms.Label()
        Me.lblID_Sucursal = New System.Windows.Forms.Label()
        Me.lblID_Cuestionario = New System.Windows.Forms.Label()
        Me.tbNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.panelResumen = New System.Windows.Forms.Panel()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.tbRespuestasNO = New System.Windows.Forms.TextBox()
        Me.lblPreguntasInsactisfactorias = New System.Windows.Forms.Label()
        Me.lblPreguntasSatisfactorias = New System.Windows.Forms.Label()
        Me.lblPreguntasRiesgoMuerteInsactisfactorias = New System.Windows.Forms.Label()
        Me.lblPreguntasConriesgoDeMuerte = New System.Windows.Forms.Label()
        Me.lblPreguntasRealizadas = New System.Windows.Forms.Label()
        Me.tbPreguntasConRiesgoDeMuerte = New System.Windows.Forms.TextBox()
        Me.tbRespuestasSI = New System.Windows.Forms.TextBox()
        Me.tbRespuestasRiesgoMuerteContestadasMal = New System.Windows.Forms.TextBox()
        Me.tbTotalPreguntasRealizadas = New System.Windows.Forms.TextBox()
        Me.FlowPanelDetalle = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblGradoPeligrosidad = New System.Windows.Forms.Label()
        Me.lblGradoRepercucion = New System.Windows.Forms.Label()
        Me.panelNotas = New System.Windows.Forms.Panel()
        Me.lblNotas = New System.Windows.Forms.Label()
        Me.tbnotas = New System.Windows.Forms.TextBox()
        Me.panelSuperior.SuspendLayout()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInferior.SuspendLayout()
        Me.panelResumen.SuspendLayout()
        Me.FlowPanelDetalle.SuspendLayout()
        Me.panelNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'barraProgreso
        '
        Me.barraProgreso.Location = New System.Drawing.Point(171, 563)
        Me.barraProgreso.Name = "barraProgreso"
        Me.barraProgreso.Size = New System.Drawing.Size(391, 32)
        Me.barraProgreso.TabIndex = 3
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(1160, 69)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(119, 24)
        Me.tbMatricula.TabIndex = 47
        Me.tbMatricula.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(1086, 73)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 46
        Me.lblMatricula.Text = "| Matricula"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1129, 38)
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
        Me.tbFecha.Location = New System.Drawing.Point(1180, 34)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(99, 24)
        Me.tbFecha.TabIndex = 42
        Me.tbFecha.TabStop = False
        '
        'tbCuestionarioSeleccionado
        '
        Me.tbCuestionarioSeleccionado.BackColor = System.Drawing.Color.White
        Me.tbCuestionarioSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCuestionarioSeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCuestionarioSeleccionado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCuestionarioSeleccionado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCuestionarioSeleccionado.Location = New System.Drawing.Point(173, 34)
        Me.tbCuestionarioSeleccionado.Name = "tbCuestionarioSeleccionado"
        Me.tbCuestionarioSeleccionado.ReadOnly = True
        Me.tbCuestionarioSeleccionado.ShortcutsEnabled = False
        Me.tbCuestionarioSeleccionado.Size = New System.Drawing.Size(616, 24)
        Me.tbCuestionarioSeleccionado.TabIndex = 41
        Me.tbCuestionarioSeleccionado.TabStop = False
        '
        'lblCuestionarioSeleccionado
        '
        Me.lblCuestionarioSeleccionado.AutoSize = True
        Me.lblCuestionarioSeleccionado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuestionarioSeleccionado.Location = New System.Drawing.Point(6, 38)
        Me.lblCuestionarioSeleccionado.Name = "lblCuestionarioSeleccionado"
        Me.lblCuestionarioSeleccionado.Size = New System.Drawing.Size(162, 16)
        Me.lblCuestionarioSeleccionado.TabIndex = 40
        Me.lblCuestionarioSeleccionado.Text = "Cuestionario Seleccionado"
        '
        'tbEmpleadosSucursal
        '
        Me.tbEmpleadosSucursal.BackColor = System.Drawing.Color.White
        Me.tbEmpleadosSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpleadosSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpleadosSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleadosSucursal.Location = New System.Drawing.Point(971, 34)
        Me.tbEmpleadosSucursal.Name = "tbEmpleadosSucursal"
        Me.tbEmpleadosSucursal.ReadOnly = True
        Me.tbEmpleadosSucursal.ShortcutsEnabled = False
        Me.tbEmpleadosSucursal.Size = New System.Drawing.Size(153, 24)
        Me.tbEmpleadosSucursal.TabIndex = 39
        Me.tbEmpleadosSucursal.TabStop = False
        '
        'lblTotalEmpleadosSucursal
        '
        Me.lblTotalEmpleadosSucursal.AutoSize = True
        Me.lblTotalEmpleadosSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmpleadosSucursal.Location = New System.Drawing.Point(794, 38)
        Me.lblTotalEmpleadosSucursal.Name = "lblTotalEmpleadosSucursal"
        Me.lblTotalEmpleadosSucursal.Size = New System.Drawing.Size(164, 16)
        Me.lblTotalEmpleadosSucursal.TabIndex = 38
        Me.lblTotalEmpleadosSucursal.Text = "| Empleados de la sucursal"
        '
        'tbNombreSucursal
        '
        Me.tbNombreSucursal.BackColor = System.Drawing.Color.White
        Me.tbNombreSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreSucursal.Location = New System.Drawing.Point(173, 69)
        Me.tbNombreSucursal.Name = "tbNombreSucursal"
        Me.tbNombreSucursal.ReadOnly = True
        Me.tbNombreSucursal.ShortcutsEnabled = False
        Me.tbNombreSucursal.Size = New System.Drawing.Size(405, 24)
        Me.tbNombreSucursal.TabIndex = 37
        Me.tbNombreSucursal.TabStop = False
        '
        'lblNombreDeLaSucursal
        '
        Me.lblNombreDeLaSucursal.AutoSize = True
        Me.lblNombreDeLaSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeLaSucursal.Location = New System.Drawing.Point(25, 73)
        Me.lblNombreDeLaSucursal.Name = "lblNombreDeLaSucursal"
        Me.lblNombreDeLaSucursal.Size = New System.Drawing.Size(142, 16)
        Me.lblNombreDeLaSucursal.TabIndex = 36
        Me.lblNombreDeLaSucursal.Text = "Nombre de la Sucursal"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1287, 25)
        Me.panelSuperior.TabIndex = 48
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
        Me.pictureMinimize.TabIndex = 53
        Me.pictureMinimize.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
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
        Me.pictureClose.TabIndex = 52
        Me.pictureClose.TabStop = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(1162, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(118, 30)
        Me.btnImprimir.TabIndex = 49
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.btnMostrarNotas)
        Me.panelInferior.Controls.Add(Me.lblQvalorFinal)
        Me.panelInferior.Controls.Add(Me.lblvBase)
        Me.panelInferior.Controls.Add(Me.btnMostrarDetalles)
        Me.panelInferior.Controls.Add(Me.lblFinalRiskValue)
        Me.panelInferior.Controls.Add(Me.lblConteo)
        Me.panelInferior.Controls.Add(Me.lblAnguloDeGiro)
        Me.panelInferior.Controls.Add(Me.lblID_Sucursal)
        Me.panelInferior.Controls.Add(Me.lblID_Cuestionario)
        Me.panelInferior.Controls.Add(Me.btnImprimir)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 643)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(1287, 40)
        Me.panelInferior.TabIndex = 51
        '
        'btnMostrarNotas
        '
        Me.btnMostrarNotas.BackColor = System.Drawing.Color.White
        Me.btnMostrarNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnMostrarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnMostrarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarNotas.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarNotas.Location = New System.Drawing.Point(868, 5)
        Me.btnMostrarNotas.Name = "btnMostrarNotas"
        Me.btnMostrarNotas.Size = New System.Drawing.Size(142, 30)
        Me.btnMostrarNotas.TabIndex = 59
        Me.btnMostrarNotas.Text = "Mostrar Notas"
        Me.btnMostrarNotas.UseVisualStyleBackColor = False
        '
        'lblQvalorFinal
        '
        Me.lblQvalorFinal.AutoSize = True
        Me.lblQvalorFinal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQvalorFinal.ForeColor = System.Drawing.Color.White
        Me.lblQvalorFinal.Location = New System.Drawing.Point(603, 9)
        Me.lblQvalorFinal.Name = "lblQvalorFinal"
        Me.lblQvalorFinal.Size = New System.Drawing.Size(92, 19)
        Me.lblQvalorFinal.TabIndex = 58
        Me.lblQvalorFinal.Text = "lblQvalorFinal"
        Me.lblQvalorFinal.Visible = False
        '
        'lblvBase
        '
        Me.lblvBase.AutoSize = True
        Me.lblvBase.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvBase.ForeColor = System.Drawing.Color.White
        Me.lblvBase.Location = New System.Drawing.Point(517, 9)
        Me.lblvBase.Name = "lblvBase"
        Me.lblvBase.Size = New System.Drawing.Size(58, 19)
        Me.lblvBase.TabIndex = 57
        Me.lblvBase.Text = "lblvBase"
        Me.lblvBase.Visible = False
        '
        'btnMostrarDetalles
        '
        Me.btnMostrarDetalles.BackColor = System.Drawing.Color.White
        Me.btnMostrarDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnMostrarDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnMostrarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarDetalles.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDetalles.Location = New System.Drawing.Point(1015, 5)
        Me.btnMostrarDetalles.Name = "btnMostrarDetalles"
        Me.btnMostrarDetalles.Size = New System.Drawing.Size(142, 30)
        Me.btnMostrarDetalles.TabIndex = 1
        Me.btnMostrarDetalles.Text = "Mostrar Detalles"
        Me.btnMostrarDetalles.UseVisualStyleBackColor = False
        '
        'lblFinalRiskValue
        '
        Me.lblFinalRiskValue.AutoSize = True
        Me.lblFinalRiskValue.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalRiskValue.ForeColor = System.Drawing.Color.White
        Me.lblFinalRiskValue.Location = New System.Drawing.Point(723, 9)
        Me.lblFinalRiskValue.Name = "lblFinalRiskValue"
        Me.lblFinalRiskValue.Size = New System.Drawing.Size(110, 19)
        Me.lblFinalRiskValue.TabIndex = 56
        Me.lblFinalRiskValue.Text = "lblFInalRiskValue"
        Me.lblFinalRiskValue.Visible = False
        '
        'lblConteo
        '
        Me.lblConteo.AutoSize = True
        Me.lblConteo.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConteo.ForeColor = System.Drawing.Color.White
        Me.lblConteo.Location = New System.Drawing.Point(421, 9)
        Me.lblConteo.Name = "lblConteo"
        Me.lblConteo.Size = New System.Drawing.Size(68, 19)
        Me.lblConteo.TabIndex = 55
        Me.lblConteo.Text = "lblConteo"
        Me.lblConteo.Visible = False
        '
        'lblAnguloDeGiro
        '
        Me.lblAnguloDeGiro.AutoSize = True
        Me.lblAnguloDeGiro.BackColor = System.Drawing.Color.Transparent
        Me.lblAnguloDeGiro.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnguloDeGiro.ForeColor = System.Drawing.Color.White
        Me.lblAnguloDeGiro.Location = New System.Drawing.Point(283, 9)
        Me.lblAnguloDeGiro.Name = "lblAnguloDeGiro"
        Me.lblAnguloDeGiro.Size = New System.Drawing.Size(110, 19)
        Me.lblAnguloDeGiro.TabIndex = 54
        Me.lblAnguloDeGiro.Text = "lblAnguloDeGiro"
        Me.lblAnguloDeGiro.Visible = False
        '
        'lblID_Sucursal
        '
        Me.lblID_Sucursal.AutoSize = True
        Me.lblID_Sucursal.BackColor = System.Drawing.Color.Transparent
        Me.lblID_Sucursal.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_Sucursal.ForeColor = System.Drawing.Color.White
        Me.lblID_Sucursal.Location = New System.Drawing.Point(160, 9)
        Me.lblID_Sucursal.Name = "lblID_Sucursal"
        Me.lblID_Sucursal.Size = New System.Drawing.Size(95, 19)
        Me.lblID_Sucursal.TabIndex = 53
        Me.lblID_Sucursal.Text = "lblID_Sucursal"
        Me.lblID_Sucursal.Visible = False
        '
        'lblID_Cuestionario
        '
        Me.lblID_Cuestionario.AutoSize = True
        Me.lblID_Cuestionario.BackColor = System.Drawing.Color.Transparent
        Me.lblID_Cuestionario.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_Cuestionario.ForeColor = System.Drawing.Color.White
        Me.lblID_Cuestionario.Location = New System.Drawing.Point(12, 9)
        Me.lblID_Cuestionario.Name = "lblID_Cuestionario"
        Me.lblID_Cuestionario.Size = New System.Drawing.Size(120, 19)
        Me.lblID_Cuestionario.TabIndex = 52
        Me.lblID_Cuestionario.Text = "lblID_Cuestionario"
        Me.lblID_Cuestionario.Visible = False
        '
        'tbNombreEmpleado
        '
        Me.tbNombreEmpleado.BackColor = System.Drawing.Color.White
        Me.tbNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreEmpleado.Location = New System.Drawing.Point(717, 69)
        Me.tbNombreEmpleado.Name = "tbNombreEmpleado"
        Me.tbNombreEmpleado.ReadOnly = True
        Me.tbNombreEmpleado.ShortcutsEnabled = False
        Me.tbNombreEmpleado.Size = New System.Drawing.Size(363, 24)
        Me.tbNombreEmpleado.TabIndex = 53
        Me.tbNombreEmpleado.TabStop = False
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(584, 73)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(127, 16)
        Me.lblNombreEmpleado.TabIndex = 52
        Me.lblNombreEmpleado.Text = "| Nombre Empleado"
        '
        'panelResumen
        '
        Me.panelResumen.Controls.Add(Me.lblResumen)
        Me.panelResumen.Controls.Add(Me.tbRespuestasNO)
        Me.panelResumen.Controls.Add(Me.lblPreguntasInsactisfactorias)
        Me.panelResumen.Controls.Add(Me.lblPreguntasSatisfactorias)
        Me.panelResumen.Controls.Add(Me.lblPreguntasRiesgoMuerteInsactisfactorias)
        Me.panelResumen.Controls.Add(Me.lblPreguntasConriesgoDeMuerte)
        Me.panelResumen.Controls.Add(Me.lblPreguntasRealizadas)
        Me.panelResumen.Controls.Add(Me.tbPreguntasConRiesgoDeMuerte)
        Me.panelResumen.Controls.Add(Me.tbRespuestasSI)
        Me.panelResumen.Controls.Add(Me.tbRespuestasRiesgoMuerteContestadasMal)
        Me.panelResumen.Controls.Add(Me.tbTotalPreguntasRealizadas)
        Me.panelResumen.Location = New System.Drawing.Point(3, 3)
        Me.panelResumen.Name = "panelResumen"
        Me.panelResumen.Size = New System.Drawing.Size(502, 532)
        Me.panelResumen.TabIndex = 0
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumen.Location = New System.Drawing.Point(32, 84)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(186, 47)
        Me.lblResumen.TabIndex = 34
        Me.lblResumen.Text = "RESUMEN"
        '
        'tbRespuestasNO
        '
        Me.tbRespuestasNO.BackColor = System.Drawing.Color.White
        Me.tbRespuestasNO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbRespuestasNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbRespuestasNO.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRespuestasNO.Location = New System.Drawing.Point(430, 299)
        Me.tbRespuestasNO.Name = "tbRespuestasNO"
        Me.tbRespuestasNO.ReadOnly = True
        Me.tbRespuestasNO.Size = New System.Drawing.Size(58, 21)
        Me.tbRespuestasNO.TabIndex = 33
        Me.tbRespuestasNO.TabStop = False
        '
        'lblPreguntasInsactisfactorias
        '
        Me.lblPreguntasInsactisfactorias.AutoSize = True
        Me.lblPreguntasInsactisfactorias.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntasInsactisfactorias.Location = New System.Drawing.Point(32, 303)
        Me.lblPreguntasInsactisfactorias.Name = "lblPreguntasInsactisfactorias"
        Me.lblPreguntasInsactisfactorias.Size = New System.Drawing.Size(302, 16)
        Me.lblPreguntasInsactisfactorias.TabIndex = 32
        Me.lblPreguntasInsactisfactorias.Text = "Preguntas con cobertura de riesgo insatisfactorias"
        '
        'lblPreguntasSatisfactorias
        '
        Me.lblPreguntasSatisfactorias.AutoSize = True
        Me.lblPreguntasSatisfactorias.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntasSatisfactorias.Location = New System.Drawing.Point(32, 345)
        Me.lblPreguntasSatisfactorias.Name = "lblPreguntasSatisfactorias"
        Me.lblPreguntasSatisfactorias.Size = New System.Drawing.Size(287, 16)
        Me.lblPreguntasSatisfactorias.TabIndex = 31
        Me.lblPreguntasSatisfactorias.Text = "Preguntas con cobertura de riesgo satisfactorio"
        '
        'lblPreguntasRiesgoMuerteInsactisfactorias
        '
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.AutoSize = True
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.Location = New System.Drawing.Point(32, 259)
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.Name = "lblPreguntasRiesgoMuerteInsactisfactorias"
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.Size = New System.Drawing.Size(390, 16)
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.TabIndex = 30
        Me.lblPreguntasRiesgoMuerteInsactisfactorias.Text = "Preguntas con riesgo de muerte contestadas insactifactoriamente"
        '
        'lblPreguntasConriesgoDeMuerte
        '
        Me.lblPreguntasConriesgoDeMuerte.AutoSize = True
        Me.lblPreguntasConriesgoDeMuerte.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntasConriesgoDeMuerte.Location = New System.Drawing.Point(32, 209)
        Me.lblPreguntasConriesgoDeMuerte.Name = "lblPreguntasConriesgoDeMuerte"
        Me.lblPreguntasConriesgoDeMuerte.Size = New System.Drawing.Size(196, 16)
        Me.lblPreguntasConriesgoDeMuerte.TabIndex = 29
        Me.lblPreguntasConriesgoDeMuerte.Text = "Preguntas con riesgo de muerte"
        '
        'lblPreguntasRealizadas
        '
        Me.lblPreguntasRealizadas.AutoSize = True
        Me.lblPreguntasRealizadas.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntasRealizadas.Location = New System.Drawing.Point(32, 159)
        Me.lblPreguntasRealizadas.Name = "lblPreguntasRealizadas"
        Me.lblPreguntasRealizadas.Size = New System.Drawing.Size(129, 16)
        Me.lblPreguntasRealizadas.TabIndex = 28
        Me.lblPreguntasRealizadas.Text = "Preguntas realizadas"
        '
        'tbPreguntasConRiesgoDeMuerte
        '
        Me.tbPreguntasConRiesgoDeMuerte.BackColor = System.Drawing.Color.White
        Me.tbPreguntasConRiesgoDeMuerte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPreguntasConRiesgoDeMuerte.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPreguntasConRiesgoDeMuerte.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreguntasConRiesgoDeMuerte.Location = New System.Drawing.Point(276, 205)
        Me.tbPreguntasConRiesgoDeMuerte.Name = "tbPreguntasConRiesgoDeMuerte"
        Me.tbPreguntasConRiesgoDeMuerte.ReadOnly = True
        Me.tbPreguntasConRiesgoDeMuerte.Size = New System.Drawing.Size(58, 21)
        Me.tbPreguntasConRiesgoDeMuerte.TabIndex = 27
        Me.tbPreguntasConRiesgoDeMuerte.TabStop = False
        '
        'tbRespuestasSI
        '
        Me.tbRespuestasSI.BackColor = System.Drawing.Color.White
        Me.tbRespuestasSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbRespuestasSI.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbRespuestasSI.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRespuestasSI.Location = New System.Drawing.Point(430, 341)
        Me.tbRespuestasSI.Name = "tbRespuestasSI"
        Me.tbRespuestasSI.ReadOnly = True
        Me.tbRespuestasSI.Size = New System.Drawing.Size(58, 21)
        Me.tbRespuestasSI.TabIndex = 26
        Me.tbRespuestasSI.TabStop = False
        '
        'tbRespuestasRiesgoMuerteContestadasMal
        '
        Me.tbRespuestasRiesgoMuerteContestadasMal.BackColor = System.Drawing.Color.White
        Me.tbRespuestasRiesgoMuerteContestadasMal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbRespuestasRiesgoMuerteContestadasMal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbRespuestasRiesgoMuerteContestadasMal.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRespuestasRiesgoMuerteContestadasMal.Location = New System.Drawing.Point(430, 255)
        Me.tbRespuestasRiesgoMuerteContestadasMal.Name = "tbRespuestasRiesgoMuerteContestadasMal"
        Me.tbRespuestasRiesgoMuerteContestadasMal.ReadOnly = True
        Me.tbRespuestasRiesgoMuerteContestadasMal.Size = New System.Drawing.Size(58, 21)
        Me.tbRespuestasRiesgoMuerteContestadasMal.TabIndex = 25
        Me.tbRespuestasRiesgoMuerteContestadasMal.TabStop = False
        '
        'tbTotalPreguntasRealizadas
        '
        Me.tbTotalPreguntasRealizadas.BackColor = System.Drawing.Color.White
        Me.tbTotalPreguntasRealizadas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbTotalPreguntasRealizadas.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbTotalPreguntasRealizadas.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalPreguntasRealizadas.Location = New System.Drawing.Point(276, 155)
        Me.tbTotalPreguntasRealizadas.Name = "tbTotalPreguntasRealizadas"
        Me.tbTotalPreguntasRealizadas.ReadOnly = True
        Me.tbTotalPreguntasRealizadas.Size = New System.Drawing.Size(58, 21)
        Me.tbTotalPreguntasRealizadas.TabIndex = 24
        Me.tbTotalPreguntasRealizadas.TabStop = False
        '
        'FlowPanelDetalle
        '
        Me.FlowPanelDetalle.Controls.Add(Me.panelResumen)
        Me.FlowPanelDetalle.Location = New System.Drawing.Point(778, 102)
        Me.FlowPanelDetalle.Name = "FlowPanelDetalle"
        Me.FlowPanelDetalle.Size = New System.Drawing.Size(509, 535)
        Me.FlowPanelDetalle.TabIndex = 54
        '
        'lblGradoPeligrosidad
        '
        Me.lblGradoPeligrosidad.AutoSize = True
        Me.lblGradoPeligrosidad.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoPeligrosidad.Location = New System.Drawing.Point(165, 149)
        Me.lblGradoPeligrosidad.Name = "lblGradoPeligrosidad"
        Me.lblGradoPeligrosidad.Size = New System.Drawing.Size(403, 47)
        Me.lblGradoPeligrosidad.TabIndex = 36
        Me.lblGradoPeligrosidad.Text = "GRADO PELIGROSIDAD"
        '
        'lblGradoRepercucion
        '
        Me.lblGradoRepercucion.AutoSize = True
        Me.lblGradoRepercucion.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoRepercucion.Location = New System.Drawing.Point(169, 513)
        Me.lblGradoRepercucion.Name = "lblGradoRepercucion"
        Me.lblGradoRepercucion.Size = New System.Drawing.Size(392, 47)
        Me.lblGradoRepercucion.TabIndex = 55
        Me.lblGradoRepercucion.Text = "GRADO REPERCUSIÓN"
        '
        'panelNotas
        '
        Me.panelNotas.Controls.Add(Me.lblNotas)
        Me.panelNotas.Controls.Add(Me.tbnotas)
        Me.panelNotas.Location = New System.Drawing.Point(5, 102)
        Me.panelNotas.Name = "panelNotas"
        Me.panelNotas.Size = New System.Drawing.Size(767, 535)
        Me.panelNotas.TabIndex = 56
        Me.panelNotas.Visible = False
        '
        'lblNotas
        '
        Me.lblNotas.AutoSize = True
        Me.lblNotas.Font = New System.Drawing.Font("Microsoft Tai Le", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotas.Location = New System.Drawing.Point(3, 9)
        Me.lblNotas.Name = "lblNotas"
        Me.lblNotas.Size = New System.Drawing.Size(139, 47)
        Me.lblNotas.TabIndex = 35
        Me.lblNotas.Text = "NOTAS"
        '
        'tbnotas
        '
        Me.tbnotas.Location = New System.Drawing.Point(0, 67)
        Me.tbnotas.Multiline = True
        Me.tbnotas.Name = "tbnotas"
        Me.tbnotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbnotas.Size = New System.Drawing.Size(767, 468)
        Me.tbnotas.TabIndex = 0
        '
        'VentanaReporteCuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1287, 683)
        Me.Controls.Add(Me.panelNotas)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.lblGradoRepercucion)
        Me.Controls.Add(Me.lblGradoPeligrosidad)
        Me.Controls.Add(Me.FlowPanelDetalle)
        Me.Controls.Add(Me.tbNombreEmpleado)
        Me.Controls.Add(Me.lblNombreEmpleado)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbCuestionarioSeleccionado)
        Me.Controls.Add(Me.lblCuestionarioSeleccionado)
        Me.Controls.Add(Me.tbEmpleadosSucursal)
        Me.Controls.Add(Me.lblTotalEmpleadosSucursal)
        Me.Controls.Add(Me.tbNombreSucursal)
        Me.Controls.Add(Me.lblNombreDeLaSucursal)
        Me.Controls.Add(Me.barraProgreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaReporteCuestionario"
        Me.Text = "pruebaUNOEPIC"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.panelResumen.ResumeLayout(False)
        Me.panelResumen.PerformLayout()
        Me.FlowPanelDetalle.ResumeLayout(False)
        Me.panelNotas.ResumeLayout(False)
        Me.panelNotas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barraProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents tbCuestionarioSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents lblCuestionarioSeleccionado As System.Windows.Forms.Label
    Friend WithEvents tbEmpleadosSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalEmpleadosSucursal As System.Windows.Forms.Label
    Friend WithEvents tbNombreSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreDeLaSucursal As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblID_Cuestionario As System.Windows.Forms.Label
    Friend WithEvents tbNombreEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lblID_Sucursal As System.Windows.Forms.Label
    Friend WithEvents lblAnguloDeGiro As System.Windows.Forms.Label
    Friend WithEvents lblConteo As System.Windows.Forms.Label
    Friend WithEvents lblFinalRiskValue As System.Windows.Forms.Label
    Friend WithEvents panelResumen As System.Windows.Forms.Panel
    Friend WithEvents lblResumen As System.Windows.Forms.Label
    Friend WithEvents tbRespuestasNO As System.Windows.Forms.TextBox
    Friend WithEvents lblPreguntasInsactisfactorias As System.Windows.Forms.Label
    Friend WithEvents lblPreguntasSatisfactorias As System.Windows.Forms.Label
    Friend WithEvents lblPreguntasRiesgoMuerteInsactisfactorias As System.Windows.Forms.Label
    Friend WithEvents lblPreguntasConriesgoDeMuerte As System.Windows.Forms.Label
    Friend WithEvents lblPreguntasRealizadas As System.Windows.Forms.Label
    Friend WithEvents tbPreguntasConRiesgoDeMuerte As System.Windows.Forms.TextBox
    Friend WithEvents tbRespuestasSI As System.Windows.Forms.TextBox
    Friend WithEvents tbRespuestasRiesgoMuerteContestadasMal As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalPreguntasRealizadas As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrarDetalles As System.Windows.Forms.Button
    Friend WithEvents FlowPanelDetalle As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblGradoPeligrosidad As System.Windows.Forms.Label
    Friend WithEvents lblGradoRepercucion As System.Windows.Forms.Label
    Friend WithEvents lblvBase As System.Windows.Forms.Label
    Friend WithEvents lblQvalorFinal As System.Windows.Forms.Label
    Friend WithEvents btnMostrarNotas As System.Windows.Forms.Button
    Friend WithEvents panelNotas As System.Windows.Forms.Panel
    Friend WithEvents lblNotas As System.Windows.Forms.Label
    Friend WithEvents tbnotas As System.Windows.Forms.TextBox
End Class
