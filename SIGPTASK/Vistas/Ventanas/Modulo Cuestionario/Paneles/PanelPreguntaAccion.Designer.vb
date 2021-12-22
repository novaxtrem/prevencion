<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelPreguntaAccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelPreguntaAccion))
        Me.lblID_pregunta = New System.Windows.Forms.Label()
        Me.lblID_Accion = New System.Windows.Forms.Label()
        Me.grupoSINO = New System.Windows.Forms.GroupBox()
        Me.rdbNO = New System.Windows.Forms.RadioButton()
        Me.rdbSI = New System.Windows.Forms.RadioButton()
        Me.tbPreguntaAgregada = New System.Windows.Forms.TextBox()
        Me.tbAccionAgregada = New System.Windows.Forms.TextBox()
        Me.lblGradoExposicion = New System.Windows.Forms.Label()
        Me.lblGradoProbavilidad = New System.Windows.Forms.Label()
        Me.lblGradoConsecuencia = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblRiesgoMuerte = New System.Windows.Forms.Label()
        Me.lblCantidadExpuestos = New System.Windows.Forms.Label()
        Me.tbPersonasExpuestas = New System.Windows.Forms.TextBox()
        Me.trackBarExpocision = New System.Windows.Forms.TrackBar()
        Me.trackbarProbabilidad = New System.Windows.Forms.TrackBar()
        Me.trackbarConsecuencia = New System.Windows.Forms.TrackBar()
        Me.lblCalavera = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.grupoSINO.SuspendLayout()
        CType(Me.trackBarExpocision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackbarProbabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackbarConsecuencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID_pregunta
        '
        Me.lblID_pregunta.AutoSize = True
        Me.lblID_pregunta.Location = New System.Drawing.Point(80, 42)
        Me.lblID_pregunta.Name = "lblID_pregunta"
        Me.lblID_pregunta.Size = New System.Drawing.Size(76, 13)
        Me.lblID_pregunta.TabIndex = 0
        Me.lblID_pregunta.Text = "lblID_pregunta"
        Me.lblID_pregunta.Visible = False
        '
        'lblID_Accion
        '
        Me.lblID_Accion.AutoSize = True
        Me.lblID_Accion.Location = New System.Drawing.Point(34, 75)
        Me.lblID_Accion.Name = "lblID_Accion"
        Me.lblID_Accion.Size = New System.Drawing.Size(67, 13)
        Me.lblID_Accion.TabIndex = 1
        Me.lblID_Accion.Text = "lblID_Accion"
        Me.lblID_Accion.Visible = False
        '
        'grupoSINO
        '
        Me.grupoSINO.Controls.Add(Me.rdbNO)
        Me.grupoSINO.Controls.Add(Me.rdbSI)
        Me.grupoSINO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grupoSINO.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoSINO.Location = New System.Drawing.Point(240, 25)
        Me.grupoSINO.Name = "grupoSINO"
        Me.grupoSINO.Size = New System.Drawing.Size(53, 63)
        Me.grupoSINO.TabIndex = 2
        Me.grupoSINO.TabStop = False
        '
        'rdbNO
        '
        Me.rdbNO.AutoSize = True
        Me.rdbNO.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNO.Location = New System.Drawing.Point(6, 36)
        Me.rdbNO.Name = "rdbNO"
        Me.rdbNO.Size = New System.Drawing.Size(46, 20)
        Me.rdbNO.TabIndex = 1
        Me.rdbNO.TabStop = True
        Me.rdbNO.Text = "NO"
        Me.rdbNO.UseVisualStyleBackColor = True
        '
        'rdbSI
        '
        Me.rdbSI.AutoSize = True
        Me.rdbSI.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSI.Location = New System.Drawing.Point(6, 13)
        Me.rdbSI.Name = "rdbSI"
        Me.rdbSI.Size = New System.Drawing.Size(36, 20)
        Me.rdbSI.TabIndex = 0
        Me.rdbSI.TabStop = True
        Me.rdbSI.Text = "SI"
        Me.rdbSI.UseVisualStyleBackColor = True
        '
        'tbPreguntaAgregada
        '
        Me.tbPreguntaAgregada.BackColor = System.Drawing.Color.White
        Me.tbPreguntaAgregada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPreguntaAgregada.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreguntaAgregada.Location = New System.Drawing.Point(8, 17)
        Me.tbPreguntaAgregada.Margin = New System.Windows.Forms.Padding(5)
        Me.tbPreguntaAgregada.Multiline = True
        Me.tbPreguntaAgregada.Name = "tbPreguntaAgregada"
        Me.tbPreguntaAgregada.ReadOnly = True
        Me.tbPreguntaAgregada.Size = New System.Drawing.Size(225, 82)
        Me.tbPreguntaAgregada.TabIndex = 3
        '
        'tbAccionAgregada
        '
        Me.tbAccionAgregada.BackColor = System.Drawing.Color.White
        Me.tbAccionAgregada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAccionAgregada.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccionAgregada.Location = New System.Drawing.Point(301, 17)
        Me.tbAccionAgregada.Margin = New System.Windows.Forms.Padding(5)
        Me.tbAccionAgregada.Multiline = True
        Me.tbAccionAgregada.Name = "tbAccionAgregada"
        Me.tbAccionAgregada.ReadOnly = True
        Me.tbAccionAgregada.Size = New System.Drawing.Size(227, 82)
        Me.tbAccionAgregada.TabIndex = 4
        '
        'lblGradoExposicion
        '
        Me.lblGradoExposicion.AutoSize = True
        Me.lblGradoExposicion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoExposicion.ForeColor = System.Drawing.Color.Black
        Me.lblGradoExposicion.Location = New System.Drawing.Point(148, 118)
        Me.lblGradoExposicion.Name = "lblGradoExposicion"
        Me.lblGradoExposicion.Size = New System.Drawing.Size(111, 16)
        Me.lblGradoExposicion.TabIndex = 5
        Me.lblGradoExposicion.Text = "Grado Exposicion"
        '
        'lblGradoProbavilidad
        '
        Me.lblGradoProbavilidad.AutoSize = True
        Me.lblGradoProbavilidad.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoProbavilidad.ForeColor = System.Drawing.Color.Black
        Me.lblGradoProbavilidad.Location = New System.Drawing.Point(9, 118)
        Me.lblGradoProbavilidad.Name = "lblGradoProbavilidad"
        Me.lblGradoProbavilidad.Size = New System.Drawing.Size(124, 16)
        Me.lblGradoProbavilidad.TabIndex = 6
        Me.lblGradoProbavilidad.Text = "Grado Probabilidad"
        '
        'lblGradoConsecuencia
        '
        Me.lblGradoConsecuencia.AutoSize = True
        Me.lblGradoConsecuencia.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradoConsecuencia.ForeColor = System.Drawing.Color.Black
        Me.lblGradoConsecuencia.Location = New System.Drawing.Point(265, 118)
        Me.lblGradoConsecuencia.Name = "lblGradoConsecuencia"
        Me.lblGradoConsecuencia.Size = New System.Drawing.Size(128, 16)
        Me.lblGradoConsecuencia.TabIndex = 7
        Me.lblGradoConsecuencia.Text = "Grado Consecuencia"
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(450, 155)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(78, 30)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblRiesgoMuerte
        '
        Me.lblRiesgoMuerte.AutoSize = True
        Me.lblRiesgoMuerte.Location = New System.Drawing.Point(121, 75)
        Me.lblRiesgoMuerte.Name = "lblRiesgoMuerte"
        Me.lblRiesgoMuerte.Size = New System.Drawing.Size(83, 13)
        Me.lblRiesgoMuerte.TabIndex = 13
        Me.lblRiesgoMuerte.Text = "lblRiesgoMuerte"
        Me.lblRiesgoMuerte.Visible = False
        '
        'lblCantidadExpuestos
        '
        Me.lblCantidadExpuestos.AutoSize = True
        Me.lblCantidadExpuestos.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadExpuestos.ForeColor = System.Drawing.Color.Black
        Me.lblCantidadExpuestos.Location = New System.Drawing.Point(411, 106)
        Me.lblCantidadExpuestos.Name = "lblCantidadExpuestos"
        Me.lblCantidadExpuestos.Size = New System.Drawing.Size(123, 16)
        Me.lblCantidadExpuestos.TabIndex = 14
        Me.lblCantidadExpuestos.Text = "Personas Expuestas"
        '
        'tbPersonasExpuestas
        '
        Me.tbPersonasExpuestas.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPersonasExpuestas.Location = New System.Drawing.Point(428, 125)
        Me.tbPersonasExpuestas.Name = "tbPersonasExpuestas"
        Me.tbPersonasExpuestas.Size = New System.Drawing.Size(100, 24)
        Me.tbPersonasExpuestas.TabIndex = 15
        '
        'trackBarExpocision
        '
        Me.trackBarExpocision.LargeChange = 1
        Me.trackBarExpocision.Location = New System.Drawing.Point(146, 134)
        Me.trackBarExpocision.Maximum = 3
        Me.trackBarExpocision.Name = "trackBarExpocision"
        Me.trackBarExpocision.Size = New System.Drawing.Size(115, 45)
        Me.trackBarExpocision.TabIndex = 16
        '
        'trackbarProbabilidad
        '
        Me.trackbarProbabilidad.LargeChange = 1
        Me.trackbarProbabilidad.Location = New System.Drawing.Point(14, 134)
        Me.trackbarProbabilidad.Maximum = 3
        Me.trackbarProbabilidad.Name = "trackbarProbabilidad"
        Me.trackbarProbabilidad.Size = New System.Drawing.Size(115, 45)
        Me.trackbarProbabilidad.TabIndex = 17
        '
        'trackbarConsecuencia
        '
        Me.trackbarConsecuencia.LargeChange = 1
        Me.trackbarConsecuencia.Location = New System.Drawing.Point(272, 134)
        Me.trackbarConsecuencia.Maximum = 3
        Me.trackbarConsecuencia.Name = "trackbarConsecuencia"
        Me.trackbarConsecuencia.Size = New System.Drawing.Size(115, 45)
        Me.trackbarConsecuencia.TabIndex = 18
        '
        'lblCalavera
        '
        Me.lblCalavera.AutoSize = True
        Me.lblCalavera.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalavera.ForeColor = System.Drawing.Color.Red
        Me.lblCalavera.Location = New System.Drawing.Point(391, 154)
        Me.lblCalavera.Name = "lblCalavera"
        Me.lblCalavera.Size = New System.Drawing.Size(48, 33)
        Me.lblCalavera.TabIndex = 19
        Me.lblCalavera.Text = "☠"
        Me.lblCalavera.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(537, 197)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 526
        Me.LineShape1.X2 = 8
        Me.LineShape1.Y1 = 190
        Me.LineShape1.Y2 = 190
        '
        'PanelPreguntaAccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(537, 197)
        Me.Controls.Add(Me.tbPreguntaAgregada)
        Me.Controls.Add(Me.lblID_pregunta)
        Me.Controls.Add(Me.lblRiesgoMuerte)
        Me.Controls.Add(Me.lblID_Accion)
        Me.Controls.Add(Me.lblCalavera)
        Me.Controls.Add(Me.trackbarConsecuencia)
        Me.Controls.Add(Me.trackbarProbabilidad)
        Me.Controls.Add(Me.trackBarExpocision)
        Me.Controls.Add(Me.tbPersonasExpuestas)
        Me.Controls.Add(Me.lblCantidadExpuestos)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblGradoConsecuencia)
        Me.Controls.Add(Me.lblGradoProbavilidad)
        Me.Controls.Add(Me.lblGradoExposicion)
        Me.Controls.Add(Me.tbAccionAgregada)
        Me.Controls.Add(Me.grupoSINO)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelPreguntaAccion"
        Me.Text = "PanelPreguntaAccion"
        Me.grupoSINO.ResumeLayout(False)
        Me.grupoSINO.PerformLayout()
        CType(Me.trackBarExpocision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackbarProbabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackbarConsecuencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID_pregunta As System.Windows.Forms.Label
    Friend WithEvents lblID_Accion As System.Windows.Forms.Label
    Friend WithEvents grupoSINO As System.Windows.Forms.GroupBox
    Friend WithEvents rdbNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSI As System.Windows.Forms.RadioButton
    Friend WithEvents tbPreguntaAgregada As System.Windows.Forms.TextBox
    Friend WithEvents tbAccionAgregada As System.Windows.Forms.TextBox
    Friend WithEvents lblGradoExposicion As System.Windows.Forms.Label
    Friend WithEvents lblGradoProbavilidad As System.Windows.Forms.Label
    Friend WithEvents lblGradoConsecuencia As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblRiesgoMuerte As System.Windows.Forms.Label
    Friend WithEvents lblCantidadExpuestos As System.Windows.Forms.Label
    Friend WithEvents tbPersonasExpuestas As System.Windows.Forms.TextBox
    Friend WithEvents trackBarExpocision As System.Windows.Forms.TrackBar
    Friend WithEvents trackbarProbabilidad As System.Windows.Forms.TrackBar
    Friend WithEvents trackbarConsecuencia As System.Windows.Forms.TrackBar
    Friend WithEvents lblCalavera As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
