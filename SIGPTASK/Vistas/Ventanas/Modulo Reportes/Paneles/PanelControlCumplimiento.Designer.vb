<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelControlCumplimiento
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
        Me.grupCumplidoEnfecha = New System.Windows.Forms.GroupBox()
        Me.pictureBoxCritico = New System.Windows.Forms.PictureBox()
        Me.radioButonNO = New System.Windows.Forms.RadioButton()
        Me.radioButoSI = New System.Windows.Forms.RadioButton()
        Me.lblCoordenadaX = New System.Windows.Forms.Label()
        Me.lblIDRiesgo = New System.Windows.Forms.Label()
        Me.lblCoordenadaY = New System.Windows.Forms.Label()
        Me.tbSugerencia = New System.Windows.Forms.TextBox()
        Me.tbObservacion = New System.Windows.Forms.TextBox()
        Me.lblSugerencia = New System.Windows.Forms.Label()
        Me.lblRiesgoCritico = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblImagenUbicacion = New System.Windows.Forms.Label()
        Me.lblIncidenciaID = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pictureBoxRiesgoImagen = New System.Windows.Forms.PictureBox()
        Me.lblFechaLimite = New System.Windows.Forms.Label()
        Me.tbFechaLimite = New System.Windows.Forms.TextBox()
        Me.lblNombreUbicacion = New System.Windows.Forms.Label()
        Me.tbNombreUbicacion = New System.Windows.Forms.TextBox()
        Me.grupCumplidoEnfecha.SuspendLayout()
        CType(Me.pictureBoxCritico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRiesgoImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupCumplidoEnfecha
        '
        Me.grupCumplidoEnfecha.Controls.Add(Me.pictureBoxCritico)
        Me.grupCumplidoEnfecha.Controls.Add(Me.radioButonNO)
        Me.grupCumplidoEnfecha.Controls.Add(Me.radioButoSI)
        Me.grupCumplidoEnfecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupCumplidoEnfecha.Location = New System.Drawing.Point(759, 37)
        Me.grupCumplidoEnfecha.Name = "grupCumplidoEnfecha"
        Me.grupCumplidoEnfecha.Size = New System.Drawing.Size(136, 78)
        Me.grupCumplidoEnfecha.TabIndex = 2
        Me.grupCumplidoEnfecha.TabStop = False
        Me.grupCumplidoEnfecha.Text = "Cumplido en Fecha"
        '
        'pictureBoxCritico
        '
        Me.pictureBoxCritico.Image = Global.SIGPTASK.My.Resources.Resources.danger
        Me.pictureBoxCritico.Location = New System.Drawing.Point(87, 25)
        Me.pictureBoxCritico.Name = "pictureBoxCritico"
        Me.pictureBoxCritico.Size = New System.Drawing.Size(41, 38)
        Me.pictureBoxCritico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxCritico.TabIndex = 2
        Me.pictureBoxCritico.TabStop = False
        Me.pictureBoxCritico.Visible = False
        '
        'radioButonNO
        '
        Me.radioButonNO.AutoSize = True
        Me.radioButonNO.Location = New System.Drawing.Point(6, 45)
        Me.radioButonNO.Name = "radioButonNO"
        Me.radioButonNO.Size = New System.Drawing.Size(46, 20)
        Me.radioButonNO.TabIndex = 1
        Me.radioButonNO.Text = "NO"
        Me.radioButonNO.UseVisualStyleBackColor = True
        '
        'radioButoSI
        '
        Me.radioButoSI.AutoSize = True
        Me.radioButoSI.Checked = True
        Me.radioButoSI.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButoSI.Location = New System.Drawing.Point(6, 19)
        Me.radioButoSI.Name = "radioButoSI"
        Me.radioButoSI.Size = New System.Drawing.Size(36, 20)
        Me.radioButoSI.TabIndex = 0
        Me.radioButoSI.TabStop = True
        Me.radioButoSI.Text = "SI"
        Me.radioButoSI.UseVisualStyleBackColor = True
        '
        'lblCoordenadaX
        '
        Me.lblCoordenadaX.AutoSize = True
        Me.lblCoordenadaX.Location = New System.Drawing.Point(446, 83)
        Me.lblCoordenadaX.Name = "lblCoordenadaX"
        Me.lblCoordenadaX.Size = New System.Drawing.Size(82, 13)
        Me.lblCoordenadaX.TabIndex = 3
        Me.lblCoordenadaX.Text = "lblCoordenadaX"
        Me.lblCoordenadaX.Visible = False
        '
        'lblIDRiesgo
        '
        Me.lblIDRiesgo.AutoSize = True
        Me.lblIDRiesgo.Location = New System.Drawing.Point(544, 61)
        Me.lblIDRiesgo.Name = "lblIDRiesgo"
        Me.lblIDRiesgo.Size = New System.Drawing.Size(61, 13)
        Me.lblIDRiesgo.TabIndex = 4
        Me.lblIDRiesgo.Text = "lblIDRiesgo"
        Me.lblIDRiesgo.Visible = False
        '
        'lblCoordenadaY
        '
        Me.lblCoordenadaY.AutoSize = True
        Me.lblCoordenadaY.Location = New System.Drawing.Point(446, 61)
        Me.lblCoordenadaY.Name = "lblCoordenadaY"
        Me.lblCoordenadaY.Size = New System.Drawing.Size(82, 13)
        Me.lblCoordenadaY.TabIndex = 5
        Me.lblCoordenadaY.Text = "lblCoordenadaY"
        Me.lblCoordenadaY.Visible = False
        '
        'tbSugerencia
        '
        Me.tbSugerencia.BackColor = System.Drawing.Color.White
        Me.tbSugerencia.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSugerencia.Location = New System.Drawing.Point(107, 49)
        Me.tbSugerencia.Multiline = True
        Me.tbSugerencia.Name = "tbSugerencia"
        Me.tbSugerencia.ReadOnly = True
        Me.tbSugerencia.Size = New System.Drawing.Size(320, 69)
        Me.tbSugerencia.TabIndex = 8
        Me.tbSugerencia.TabStop = False
        '
        'tbObservacion
        '
        Me.tbObservacion.BackColor = System.Drawing.Color.White
        Me.tbObservacion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObservacion.Location = New System.Drawing.Point(433, 49)
        Me.tbObservacion.Multiline = True
        Me.tbObservacion.Name = "tbObservacion"
        Me.tbObservacion.ReadOnly = True
        Me.tbObservacion.Size = New System.Drawing.Size(320, 69)
        Me.tbObservacion.TabIndex = 9
        Me.tbObservacion.TabStop = False
        '
        'lblSugerencia
        '
        Me.lblSugerencia.AutoSize = True
        Me.lblSugerencia.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSugerencia.Location = New System.Drawing.Point(429, 28)
        Me.lblSugerencia.Name = "lblSugerencia"
        Me.lblSugerencia.Size = New System.Drawing.Size(87, 21)
        Me.lblSugerencia.TabIndex = 11
        Me.lblSugerencia.Text = "Sugerencia"
        '
        'lblRiesgoCritico
        '
        Me.lblRiesgoCritico.AutoSize = True
        Me.lblRiesgoCritico.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiesgoCritico.Location = New System.Drawing.Point(628, 62)
        Me.lblRiesgoCritico.Name = "lblRiesgoCritico"
        Me.lblRiesgoCritico.Size = New System.Drawing.Size(88, 14)
        Me.lblRiesgoCritico.TabIndex = 12
        Me.lblRiesgoCritico.Text = "lblRiesgoCritico"
        Me.lblRiesgoCritico.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Observacion"
        '
        'lblImagenUbicacion
        '
        Me.lblImagenUbicacion.AutoSize = True
        Me.lblImagenUbicacion.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagenUbicacion.Location = New System.Drawing.Point(161, 61)
        Me.lblImagenUbicacion.Name = "lblImagenUbicacion"
        Me.lblImagenUbicacion.Size = New System.Drawing.Size(113, 16)
        Me.lblImagenUbicacion.TabIndex = 14
        Me.lblImagenUbicacion.Text = "lblImagenUbicacion"
        Me.lblImagenUbicacion.Visible = False
        '
        'lblIncidenciaID
        '
        Me.lblIncidenciaID.AutoSize = True
        Me.lblIncidenciaID.Location = New System.Drawing.Point(620, 33)
        Me.lblIncidenciaID.Name = "lblIncidenciaID"
        Me.lblIncidenciaID.Size = New System.Drawing.Size(77, 13)
        Me.lblIncidenciaID.TabIndex = 15
        Me.lblIncidenciaID.Text = "lblIncidenciaID"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(899, 125)
        Me.ShapeContainer1.TabIndex = 16
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 14
        Me.LineShape1.X2 = 890
        Me.LineShape1.Y1 = 121
        Me.LineShape1.Y2 = 121
        '
        'pictureBoxRiesgoImagen
        '
        Me.pictureBoxRiesgoImagen.Location = New System.Drawing.Point(9, 4)
        Me.pictureBoxRiesgoImagen.Name = "pictureBoxRiesgoImagen"
        Me.pictureBoxRiesgoImagen.Size = New System.Drawing.Size(92, 114)
        Me.pictureBoxRiesgoImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxRiesgoImagen.TabIndex = 10
        Me.pictureBoxRiesgoImagen.TabStop = False
        '
        'lblFechaLimite
        '
        Me.lblFechaLimite.AutoSize = True
        Me.lblFechaLimite.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaLimite.Location = New System.Drawing.Point(703, 8)
        Me.lblFechaLimite.Name = "lblFechaLimite"
        Me.lblFechaLimite.Size = New System.Drawing.Size(86, 16)
        Me.lblFechaLimite.TabIndex = 17
        Me.lblFechaLimite.Text = "| Fecha Limite"
        '
        'tbFechaLimite
        '
        Me.tbFechaLimite.BackColor = System.Drawing.Color.White
        Me.tbFechaLimite.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaLimite.Location = New System.Drawing.Point(788, 4)
        Me.tbFechaLimite.Name = "tbFechaLimite"
        Me.tbFechaLimite.ReadOnly = True
        Me.tbFechaLimite.Size = New System.Drawing.Size(107, 24)
        Me.tbFechaLimite.TabIndex = 18
        '
        'lblNombreUbicacion
        '
        Me.lblNombreUbicacion.AutoSize = True
        Me.lblNombreUbicacion.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUbicacion.Location = New System.Drawing.Point(107, 6)
        Me.lblNombreUbicacion.Name = "lblNombreUbicacion"
        Me.lblNombreUbicacion.Size = New System.Drawing.Size(177, 21)
        Me.lblNombreUbicacion.TabIndex = 19
        Me.lblNombreUbicacion.Text = "Nombre de la Ubicacion"
        '
        'tbNombreUbicacion
        '
        Me.tbNombreUbicacion.BackColor = System.Drawing.Color.White
        Me.tbNombreUbicacion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreUbicacion.Location = New System.Drawing.Point(283, 4)
        Me.tbNombreUbicacion.Name = "tbNombreUbicacion"
        Me.tbNombreUbicacion.ReadOnly = True
        Me.tbNombreUbicacion.Size = New System.Drawing.Size(414, 24)
        Me.tbNombreUbicacion.TabIndex = 20
        '
        'PanelControlCumplimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(899, 125)
        Me.Controls.Add(Me.tbObservacion)
        Me.Controls.Add(Me.tbSugerencia)
        Me.Controls.Add(Me.tbNombreUbicacion)
        Me.Controls.Add(Me.lblNombreUbicacion)
        Me.Controls.Add(Me.tbFechaLimite)
        Me.Controls.Add(Me.lblFechaLimite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRiesgoCritico)
        Me.Controls.Add(Me.lblSugerencia)
        Me.Controls.Add(Me.pictureBoxRiesgoImagen)
        Me.Controls.Add(Me.lblCoordenadaY)
        Me.Controls.Add(Me.lblIDRiesgo)
        Me.Controls.Add(Me.lblCoordenadaX)
        Me.Controls.Add(Me.grupCumplidoEnfecha)
        Me.Controls.Add(Me.lblImagenUbicacion)
        Me.Controls.Add(Me.lblIncidenciaID)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelControlCumplimiento"
        Me.Text = "PanelControlCumplimiento"
        Me.grupCumplidoEnfecha.ResumeLayout(False)
        Me.grupCumplidoEnfecha.PerformLayout()
        CType(Me.pictureBoxCritico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRiesgoImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupCumplidoEnfecha As System.Windows.Forms.GroupBox
    Friend WithEvents radioButonNO As System.Windows.Forms.RadioButton
    Friend WithEvents radioButoSI As System.Windows.Forms.RadioButton
    Friend WithEvents lblCoordenadaX As System.Windows.Forms.Label
    Friend WithEvents lblIDRiesgo As System.Windows.Forms.Label
    Friend WithEvents lblCoordenadaY As System.Windows.Forms.Label
    Friend WithEvents tbSugerencia As System.Windows.Forms.TextBox
    Friend WithEvents tbObservacion As System.Windows.Forms.TextBox
    Friend WithEvents pictureBoxRiesgoImagen As System.Windows.Forms.PictureBox
    Friend WithEvents lblSugerencia As System.Windows.Forms.Label
    Friend WithEvents lblRiesgoCritico As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblImagenUbicacion As System.Windows.Forms.Label
    Friend WithEvents lblIncidenciaID As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pictureBoxCritico As System.Windows.Forms.PictureBox
    Friend WithEvents lblFechaLimite As System.Windows.Forms.Label
    Friend WithEvents tbFechaLimite As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreUbicacion As System.Windows.Forms.Label
    Friend WithEvents tbNombreUbicacion As System.Windows.Forms.TextBox
End Class
