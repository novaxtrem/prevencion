<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaControlCumplimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaControlCumplimiento))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.tbNombreSucursal = New System.Windows.Forms.TextBox()
        Me.lblNombreDeLaSucursal = New System.Windows.Forms.Label()
        Me.tbMapaRiesgoNombre = New System.Windows.Forms.TextBox()
        Me.lblNombreMapa = New System.Windows.Forms.Label()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.panelInferior = New System.Windows.Forms.Panel()
        Me.btnVerMapa = New System.Windows.Forms.Button()
        Me.lblMatriculaTecnicoConectado = New System.Windows.Forms.Label()
        Me.lblIDMapaRiesgo = New System.Windows.Forms.Label()
        Me.btnValidarControl = New System.Windows.Forms.Button()
        Me.lblRutaImagenMapa = New System.Windows.Forms.Label()
        Me.panelCentral = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInferior.SuspendLayout()
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
        Me.panelSuperior.Size = New System.Drawing.Size(923, 25)
        Me.panelSuperior.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(901, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 35
        Me.pictureClose.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(880, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 36
        Me.pictureMinimize.TabStop = False
        '
        'tbNombreSucursal
        '
        Me.tbNombreSucursal.BackColor = System.Drawing.Color.White
        Me.tbNombreSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreSucursal.Location = New System.Drawing.Point(160, 63)
        Me.tbNombreSucursal.Name = "tbNombreSucursal"
        Me.tbNombreSucursal.ReadOnly = True
        Me.tbNombreSucursal.ShortcutsEnabled = False
        Me.tbNombreSucursal.Size = New System.Drawing.Size(488, 24)
        Me.tbNombreSucursal.TabIndex = 39
        Me.tbNombreSucursal.TabStop = False
        '
        'lblNombreDeLaSucursal
        '
        Me.lblNombreDeLaSucursal.AutoSize = True
        Me.lblNombreDeLaSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeLaSucursal.Location = New System.Drawing.Point(12, 67)
        Me.lblNombreDeLaSucursal.Name = "lblNombreDeLaSucursal"
        Me.lblNombreDeLaSucursal.Size = New System.Drawing.Size(142, 16)
        Me.lblNombreDeLaSucursal.TabIndex = 38
        Me.lblNombreDeLaSucursal.Text = "Nombre de la Sucursal"
        '
        'tbMapaRiesgoNombre
        '
        Me.tbMapaRiesgoNombre.BackColor = System.Drawing.Color.White
        Me.tbMapaRiesgoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMapaRiesgoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMapaRiesgoNombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMapaRiesgoNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMapaRiesgoNombre.ForeColor = System.Drawing.Color.Black
        Me.tbMapaRiesgoNombre.Location = New System.Drawing.Point(160, 32)
        Me.tbMapaRiesgoNombre.Name = "tbMapaRiesgoNombre"
        Me.tbMapaRiesgoNombre.ReadOnly = True
        Me.tbMapaRiesgoNombre.ShortcutsEnabled = False
        Me.tbMapaRiesgoNombre.Size = New System.Drawing.Size(571, 24)
        Me.tbMapaRiesgoNombre.TabIndex = 41
        Me.tbMapaRiesgoNombre.TabStop = False
        '
        'lblNombreMapa
        '
        Me.lblNombreMapa.AutoSize = True
        Me.lblNombreMapa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreMapa.ForeColor = System.Drawing.Color.Black
        Me.lblNombreMapa.Location = New System.Drawing.Point(33, 36)
        Me.lblNombreMapa.Name = "lblNombreMapa"
        Me.lblNombreMapa.Size = New System.Drawing.Size(121, 16)
        Me.lblNombreMapa.TabIndex = 40
        Me.lblNombreMapa.Text = "Nombre del  Mapa"
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(726, 63)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(180, 24)
        Me.tbMatricula.TabIndex = 51
        Me.tbMatricula.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(654, 67)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 50
        Me.lblMatricula.Text = "| Matricula"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(737, 36)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 49
        Me.lblFecha.Text = "| Fecha"
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(788, 32)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(118, 24)
        Me.tbFecha.TabIndex = 48
        Me.tbFecha.TabStop = False
        '
        'panelInferior
        '
        Me.panelInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelInferior.Controls.Add(Me.btnVerMapa)
        Me.panelInferior.Controls.Add(Me.lblMatriculaTecnicoConectado)
        Me.panelInferior.Controls.Add(Me.lblIDMapaRiesgo)
        Me.panelInferior.Controls.Add(Me.btnValidarControl)
        Me.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelInferior.Location = New System.Drawing.Point(0, 775)
        Me.panelInferior.Name = "panelInferior"
        Me.panelInferior.Size = New System.Drawing.Size(923, 40)
        Me.panelInferior.TabIndex = 53
        '
        'btnVerMapa
        '
        Me.btnVerMapa.BackColor = System.Drawing.Color.White
        Me.btnVerMapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnVerMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerMapa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerMapa.Location = New System.Drawing.Point(596, 5)
        Me.btnVerMapa.Name = "btnVerMapa"
        Me.btnVerMapa.Size = New System.Drawing.Size(157, 30)
        Me.btnVerMapa.TabIndex = 51
        Me.btnVerMapa.Text = "Ver Mapa"
        Me.btnVerMapa.UseVisualStyleBackColor = False
        '
        'lblMatriculaTecnicoConectado
        '
        Me.lblMatriculaTecnicoConectado.AutoSize = True
        Me.lblMatriculaTecnicoConectado.ForeColor = System.Drawing.Color.White
        Me.lblMatriculaTecnicoConectado.Location = New System.Drawing.Point(115, 13)
        Me.lblMatriculaTecnicoConectado.Name = "lblMatriculaTecnicoConectado"
        Me.lblMatriculaTecnicoConectado.Size = New System.Drawing.Size(151, 13)
        Me.lblMatriculaTecnicoConectado.TabIndex = 50
        Me.lblMatriculaTecnicoConectado.Text = "lblMatriculaTecnicoConectado"
        Me.lblMatriculaTecnicoConectado.Visible = False
        '
        'lblIDMapaRiesgo
        '
        Me.lblIDMapaRiesgo.AutoSize = True
        Me.lblIDMapaRiesgo.ForeColor = System.Drawing.Color.White
        Me.lblIDMapaRiesgo.Location = New System.Drawing.Point(12, 13)
        Me.lblIDMapaRiesgo.Name = "lblIDMapaRiesgo"
        Me.lblIDMapaRiesgo.Size = New System.Drawing.Size(88, 13)
        Me.lblIDMapaRiesgo.TabIndex = 49
        Me.lblIDMapaRiesgo.Text = "lblIDMapaRiesgo"
        Me.lblIDMapaRiesgo.Visible = False
        '
        'btnValidarControl
        '
        Me.btnValidarControl.BackColor = System.Drawing.Color.White
        Me.btnValidarControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidarControl.Enabled = False
        Me.btnValidarControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnValidarControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidarControl.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidarControl.Location = New System.Drawing.Point(759, 5)
        Me.btnValidarControl.Name = "btnValidarControl"
        Me.btnValidarControl.Size = New System.Drawing.Size(157, 30)
        Me.btnValidarControl.TabIndex = 48
        Me.btnValidarControl.Text = "Validar Control"
        Me.btnValidarControl.UseVisualStyleBackColor = False
        '
        'lblRutaImagenMapa
        '
        Me.lblRutaImagenMapa.AutoSize = True
        Me.lblRutaImagenMapa.Location = New System.Drawing.Point(12, 96)
        Me.lblRutaImagenMapa.Name = "lblRutaImagenMapa"
        Me.lblRutaImagenMapa.Size = New System.Drawing.Size(102, 13)
        Me.lblRutaImagenMapa.TabIndex = 54
        Me.lblRutaImagenMapa.Text = "lblRutaImagenMapa"
        Me.lblRutaImagenMapa.Visible = False
        '
        'panelCentral
        '
        Me.panelCentral.AutoScroll = True
        Me.panelCentral.Location = New System.Drawing.Point(0, 116)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(923, 653)
        Me.panelCentral.TabIndex = 55
        '
        'VentanaControlCumplimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(923, 815)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.lblRutaImagenMapa)
        Me.Controls.Add(Me.panelInferior)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.tbMapaRiesgoNombre)
        Me.Controls.Add(Me.lblNombreMapa)
        Me.Controls.Add(Me.tbNombreSucursal)
        Me.Controls.Add(Me.lblNombreDeLaSucursal)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaControlCumplimiento"
        Me.Text = "VentanaControlCumplimiento"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInferior.ResumeLayout(False)
        Me.panelInferior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbNombreSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreDeLaSucursal As System.Windows.Forms.Label
    Friend WithEvents tbMapaRiesgoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreMapa As System.Windows.Forms.Label
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents panelInferior As System.Windows.Forms.Panel
    Friend WithEvents lblRutaImagenMapa As System.Windows.Forms.Label
    Friend WithEvents lblIDMapaRiesgo As System.Windows.Forms.Label
    Friend WithEvents btnValidarControl As System.Windows.Forms.Button
    Friend WithEvents panelCentral As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblMatriculaTecnicoConectado As System.Windows.Forms.Label
    Friend WithEvents btnVerMapa As System.Windows.Forms.Button
End Class
