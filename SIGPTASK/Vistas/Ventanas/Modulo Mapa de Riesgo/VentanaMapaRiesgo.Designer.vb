<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaMapaRiesgo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaMapaRiesgo))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.lblcoordenadas = New System.Windows.Forms.Label()
        Me.FlowLayoutPanelRiesgos = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblempresaElegida = New System.Windows.Forms.Label()
        Me.tbEmpresaSeleccionada = New System.Windows.Forms.TextBox()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCedulaEmpleado = New System.Windows.Forms.Label()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.btnAgregarNuevoRiesgo = New System.Windows.Forms.Button()
        Me.btnCargarPlano = New System.Windows.Forms.Button()
        Me.btnIngresarMapaDeRiesgo = New System.Windows.Forms.Button()
        Me.tbMapaRiesgoNombre = New System.Windows.Forms.TextBox()
        Me.lblNombreMapa = New System.Windows.Forms.Label()
        Me.tbCedulaEmpleado = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblID_SucursalElegida = New System.Windows.Forms.Label()
        Me.lblPlanoRutaArchivo = New System.Windows.Forms.Label()
        Me.panelPortaPlano = New System.Windows.Forms.Panel()
        Me.pictureBoxPlano = New System.Windows.Forms.PictureBox()
        Me.panenlSuperpuestoInformacion = New System.Windows.Forms.Panel()
        Me.lblMensajeParaComenzar = New System.Windows.Forms.Label()
        Me.PictureBoxImagenFlecha = New System.Windows.Forms.PictureBox()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInferior.SuspendLayout()
        Me.panelPortaPlano.SuspendLayout()
        CType(Me.pictureBoxPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panenlSuperpuestoInformacion.SuspendLayout()
        CType(Me.PictureBoxImagenFlecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.panelSuperior.Size = New System.Drawing.Size(1271, 25)
        Me.panelSuperior.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(1228, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 35
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(1249, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 34
        Me.pictureClose.TabStop = False
        '
        'lblcoordenadas
        '
        Me.lblcoordenadas.AutoSize = True
        Me.lblcoordenadas.Location = New System.Drawing.Point(255, 57)
        Me.lblcoordenadas.Name = "lblcoordenadas"
        Me.lblcoordenadas.Size = New System.Drawing.Size(79, 13)
        Me.lblcoordenadas.TabIndex = 37
        Me.lblcoordenadas.Text = "lblcoordenadas"
        Me.lblcoordenadas.Visible = False
        '
        'FlowLayoutPanelRiesgos
        '
        Me.FlowLayoutPanelRiesgos.AutoScroll = True
        Me.FlowLayoutPanelRiesgos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanelRiesgos.Location = New System.Drawing.Point(0, 76)
        Me.FlowLayoutPanelRiesgos.Name = "FlowLayoutPanelRiesgos"
        Me.FlowLayoutPanelRiesgos.Size = New System.Drawing.Size(219, 676)
        Me.FlowLayoutPanelRiesgos.TabIndex = 49
        '
        'lblempresaElegida
        '
        Me.lblempresaElegida.AutoSize = True
        Me.lblempresaElegida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempresaElegida.Location = New System.Drawing.Point(12, 34)
        Me.lblempresaElegida.Name = "lblempresaElegida"
        Me.lblempresaElegida.Size = New System.Drawing.Size(139, 16)
        Me.lblempresaElegida.TabIndex = 40
        Me.lblempresaElegida.Text = "Empresa Seleccionada"
        '
        'tbEmpresaSeleccionada
        '
        Me.tbEmpresaSeleccionada.BackColor = System.Drawing.Color.White
        Me.tbEmpresaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbEmpresaSeleccionada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmpresaSeleccionada.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbEmpresaSeleccionada.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpresaSeleccionada.Location = New System.Drawing.Point(154, 30)
        Me.tbEmpresaSeleccionada.Name = "tbEmpresaSeleccionada"
        Me.tbEmpresaSeleccionada.ReadOnly = True
        Me.tbEmpresaSeleccionada.ShortcutsEnabled = False
        Me.tbEmpresaSeleccionada.Size = New System.Drawing.Size(468, 24)
        Me.tbEmpresaSeleccionada.TabIndex = 41
        Me.tbEmpresaSeleccionada.TabStop = False
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(1156, 30)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(99, 24)
        Me.tbFecha.TabIndex = 42
        Me.tbFecha.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1105, 34)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 43
        Me.lblFecha.Text = "| Fecha"
        '
        'lblCedulaEmpleado
        '
        Me.lblCedulaEmpleado.AutoSize = True
        Me.lblCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaEmpleado.Location = New System.Drawing.Point(625, 34)
        Me.lblCedulaEmpleado.Name = "lblCedulaEmpleado"
        Me.lblCedulaEmpleado.Size = New System.Drawing.Size(118, 16)
        Me.lblCedulaEmpleado.TabIndex = 44
        Me.lblCedulaEmpleado.Text = "| Cedula Empleado"
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(941, 30)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(161, 24)
        Me.tbMatricula.TabIndex = 47
        Me.tbMatricula.TabStop = False
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.btnAgregarNuevoRiesgo)
        Me.panelInferior.Controls.Add(Me.btnCargarPlano)
        Me.panelInferior.Controls.Add(Me.btnIngresarMapaDeRiesgo)
        Me.panelInferior.Controls.Add(Me.tbMapaRiesgoNombre)
        Me.panelInferior.Controls.Add(Me.lblNombreMapa)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 758)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(1271, 42)
        Me.panelInferior.TabIndex = 48
        '
        'btnAgregarNuevoRiesgo
        '
        Me.btnAgregarNuevoRiesgo.BackColor = System.Drawing.Color.White
        Me.btnAgregarNuevoRiesgo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarNuevoRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAgregarNuevoRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAgregarNuevoRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNuevoRiesgo.Location = New System.Drawing.Point(5, 6)
        Me.btnAgregarNuevoRiesgo.Name = "btnAgregarNuevoRiesgo"
        Me.btnAgregarNuevoRiesgo.Size = New System.Drawing.Size(175, 30)
        Me.btnAgregarNuevoRiesgo.TabIndex = 38
        Me.btnAgregarNuevoRiesgo.Text = "Nuevo riesgo"
        Me.btnAgregarNuevoRiesgo.UseVisualStyleBackColor = False
        '
        'btnCargarPlano
        '
        Me.btnCargarPlano.BackColor = System.Drawing.Color.White
        Me.btnCargarPlano.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarPlano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCargarPlano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCargarPlano.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarPlano.Location = New System.Drawing.Point(225, 6)
        Me.btnCargarPlano.Name = "btnCargarPlano"
        Me.btnCargarPlano.Size = New System.Drawing.Size(175, 30)
        Me.btnCargarPlano.TabIndex = 2
        Me.btnCargarPlano.Text = "Cargar Plano"
        Me.btnCargarPlano.UseVisualStyleBackColor = False
        '
        'btnIngresarMapaDeRiesgo
        '
        Me.btnIngresarMapaDeRiesgo.BackColor = System.Drawing.Color.White
        Me.btnIngresarMapaDeRiesgo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarMapaDeRiesgo.Enabled = False
        Me.btnIngresarMapaDeRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnIngresarMapaDeRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnIngresarMapaDeRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarMapaDeRiesgo.Location = New System.Drawing.Point(1085, 6)
        Me.btnIngresarMapaDeRiesgo.Name = "btnIngresarMapaDeRiesgo"
        Me.btnIngresarMapaDeRiesgo.Size = New System.Drawing.Size(175, 30)
        Me.btnIngresarMapaDeRiesgo.TabIndex = 8
        Me.btnIngresarMapaDeRiesgo.Text = "Generar Mapa de Riesgo"
        Me.btnIngresarMapaDeRiesgo.UseVisualStyleBackColor = False
        '
        'tbMapaRiesgoNombre
        '
        Me.tbMapaRiesgoNombre.BackColor = System.Drawing.Color.White
        Me.tbMapaRiesgoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMapaRiesgoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMapaRiesgoNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMapaRiesgoNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapaRiesgoNombre.Location = New System.Drawing.Point(546, 9)
        Me.tbMapaRiesgoNombre.Name = "tbMapaRiesgoNombre"
        Me.tbMapaRiesgoNombre.ReadOnly = True
        Me.tbMapaRiesgoNombre.ShortcutsEnabled = False
        Me.tbMapaRiesgoNombre.Size = New System.Drawing.Size(522, 24)
        Me.tbMapaRiesgoNombre.TabIndex = 37
        Me.tbMapaRiesgoNombre.TabStop = False
        '
        'lblNombreMapa
        '
        Me.lblNombreMapa.AutoSize = True
        Me.lblNombreMapa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMapa.ForeColor = System.Drawing.Color.White
        Me.lblNombreMapa.Location = New System.Drawing.Point(408, 13)
        Me.lblNombreMapa.Name = "lblNombreMapa"
        Me.lblNombreMapa.Size = New System.Drawing.Size(121, 16)
        Me.lblNombreMapa.TabIndex = 36
        Me.lblNombreMapa.Text = "Nombre del  Mapa"
        '
        'tbCedulaEmpleado
        '
        Me.tbCedulaEmpleado.BackColor = System.Drawing.Color.White
        Me.tbCedulaEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbCedulaEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbCedulaEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbCedulaEmpleado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCedulaEmpleado.Location = New System.Drawing.Point(746, 30)
        Me.tbCedulaEmpleado.Name = "tbCedulaEmpleado"
        Me.tbCedulaEmpleado.ReadOnly = True
        Me.tbCedulaEmpleado.ShortcutsEnabled = False
        Me.tbCedulaEmpleado.Size = New System.Drawing.Size(120, 24)
        Me.tbCedulaEmpleado.TabIndex = 45
        Me.tbCedulaEmpleado.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(869, 34)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 46
        Me.lblMatricula.Text = "| Matricula"
        '
        'lblID_SucursalElegida
        '
        Me.lblID_SucursalElegida.AutoSize = True
        Me.lblID_SucursalElegida.Location = New System.Drawing.Point(12, 57)
        Me.lblID_SucursalElegida.Name = "lblID_SucursalElegida"
        Me.lblID_SucursalElegida.Size = New System.Drawing.Size(110, 13)
        Me.lblID_SucursalElegida.TabIndex = 17
        Me.lblID_SucursalElegida.Text = "lblID_SucursalElegida"
        Me.lblID_SucursalElegida.Visible = False
        '
        'lblPlanoRutaArchivo
        '
        Me.lblPlanoRutaArchivo.AutoSize = True
        Me.lblPlanoRutaArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPlanoRutaArchivo.Location = New System.Drawing.Point(146, 57)
        Me.lblPlanoRutaArchivo.Name = "lblPlanoRutaArchivo"
        Me.lblPlanoRutaArchivo.Size = New System.Drawing.Size(103, 13)
        Me.lblPlanoRutaArchivo.TabIndex = 18
        Me.lblPlanoRutaArchivo.Text = "lblPlanoRutaArchivo"
        Me.lblPlanoRutaArchivo.Visible = False
        '
        'panelPortaPlano
        '
        Me.panelPortaPlano.AllowDrop = True
        Me.panelPortaPlano.AutoScroll = True
        Me.panelPortaPlano.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelPortaPlano.BackColor = System.Drawing.Color.Gray
        Me.panelPortaPlano.Controls.Add(Me.pictureBoxPlano)
        Me.panelPortaPlano.Location = New System.Drawing.Point(225, 76)
        Me.panelPortaPlano.Name = "panelPortaPlano"
        Me.panelPortaPlano.Size = New System.Drawing.Size(1046, 676)
        Me.panelPortaPlano.TabIndex = 50
        '
        'pictureBoxPlano
        '
        Me.pictureBoxPlano.Location = New System.Drawing.Point(3, 3)
        Me.pictureBoxPlano.Name = "pictureBoxPlano"
        Me.pictureBoxPlano.Size = New System.Drawing.Size(100, 50)
        Me.pictureBoxPlano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBoxPlano.TabIndex = 0
        Me.pictureBoxPlano.TabStop = False
        '
        'panenlSuperpuestoInformacion
        '
        Me.panenlSuperpuestoInformacion.Controls.Add(Me.lblMensajeParaComenzar)
        Me.panenlSuperpuestoInformacion.Controls.Add(Me.PictureBoxImagenFlecha)
        Me.panenlSuperpuestoInformacion.Location = New System.Drawing.Point(225, 73)
        Me.panenlSuperpuestoInformacion.Name = "panenlSuperpuestoInformacion"
        Me.panenlSuperpuestoInformacion.Size = New System.Drawing.Size(1046, 685)
        Me.panenlSuperpuestoInformacion.TabIndex = 1
        '
        'lblMensajeParaComenzar
        '
        Me.lblMensajeParaComenzar.AutoSize = True
        Me.lblMensajeParaComenzar.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeParaComenzar.Location = New System.Drawing.Point(294, 320)
        Me.lblMensajeParaComenzar.Name = "lblMensajeParaComenzar"
        Me.lblMensajeParaComenzar.Size = New System.Drawing.Size(549, 30)
        Me.lblMensajeParaComenzar.TabIndex = 1
        Me.lblMensajeParaComenzar.Text = "Para Comenzar cargue un plano de area, por favor"
        '
        'PictureBoxImagenFlecha
        '
        Me.PictureBoxImagenFlecha.Image = Global.SIGPTASK.My.Resources.Resources.Aicon
        Me.PictureBoxImagenFlecha.Location = New System.Drawing.Point(33, 598)
        Me.PictureBoxImagenFlecha.Name = "PictureBoxImagenFlecha"
        Me.PictureBoxImagenFlecha.Size = New System.Drawing.Size(85, 78)
        Me.PictureBoxImagenFlecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxImagenFlecha.TabIndex = 0
        Me.PictureBoxImagenFlecha.TabStop = False
        '
        'VentanaMapaRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1271, 800)
        Me.Controls.Add(Me.panenlSuperpuestoInformacion)
        Me.Controls.Add(Me.lblcoordenadas)
        Me.Controls.Add(Me.panelPortaPlano)
        Me.Controls.Add(Me.FlowLayoutPanelRiesgos)
        Me.Controls.Add(Me.lblPlanoRutaArchivo)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.lblID_SucursalElegida)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.tbCedulaEmpleado)
        Me.Controls.Add(Me.lblCedulaEmpleado)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbEmpresaSeleccionada)
        Me.Controls.Add(Me.lblempresaElegida)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaMapaRiesgo"
        Me.Text = "t"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.panelPortaPlano.ResumeLayout(False)
        Me.panelPortaPlano.PerformLayout()
        CType(Me.pictureBoxPlano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panenlSuperpuestoInformacion.ResumeLayout(False)
        Me.panenlSuperpuestoInformacion.PerformLayout()
        CType(Me.PictureBoxImagenFlecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelPortaPlano As System.Windows.Forms.Panel
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMapaRiesgo As System.Windows.Forms.PictureBox
    Friend WithEvents FlowLayoutPanelRiesgos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblempresaElegida As System.Windows.Forms.Label
    Friend WithEvents tbEmpresaSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCedulaEmpleado As System.Windows.Forms.Label
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarNuevoRiesgo As System.Windows.Forms.Button
    Friend WithEvents btnCargarPlano As System.Windows.Forms.Button
    Friend WithEvents btnIngresarMapaDeRiesgo As System.Windows.Forms.Button
    Friend WithEvents tbMapaRiesgoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreMapa As System.Windows.Forms.Label
    Friend WithEvents tbCedulaEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblID_SucursalElegida As System.Windows.Forms.Label
    Friend WithEvents lblPlanoRutaArchivo As System.Windows.Forms.Label
    Friend WithEvents lblcoordenadas As System.Windows.Forms.Label
    Friend WithEvents pictureBoxPlano As System.Windows.Forms.PictureBox
    Friend WithEvents panenlSuperpuestoInformacion As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeParaComenzar As System.Windows.Forms.Label
    Friend WithEvents PictureBoxImagenFlecha As System.Windows.Forms.PictureBox
End Class
