<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelIncidenciaDetalle
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
        Me.tbPreguntaHecha = New System.Windows.Forms.TextBox()
        Me.tbAccionSugerida = New System.Windows.Forms.TextBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.lblRespustaObtenida = New System.Windows.Forms.Label()
        Me.lblNivelExposicion = New System.Windows.Forms.Label()
        Me.lblNivelProbabilidad = New System.Windows.Forms.Label()
        Me.lblNivelConsecuencia = New System.Windows.Forms.Label()
        Me.lblRiesgoMuerte = New System.Windows.Forms.Label()
        Me.tbRespuestaObetenida = New System.Windows.Forms.TextBox()
        Me.tbRiesgoMuerte = New System.Windows.Forms.TextBox()
        Me.tbNivelExposicion = New System.Windows.Forms.TextBox()
        Me.tbNivelProbabilidad = New System.Windows.Forms.TextBox()
        Me.tbNivelConsecuencia = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblGPporPregunta = New System.Windows.Forms.Label()
        Me.lblExpuestos = New System.Windows.Forms.Label()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.lblRiesgoMuerteRes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbPreguntaHecha
        '
        Me.tbPreguntaHecha.BackColor = System.Drawing.Color.White
        Me.tbPreguntaHecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPreguntaHecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreguntaHecha.Location = New System.Drawing.Point(6, 27)
        Me.tbPreguntaHecha.Multiline = True
        Me.tbPreguntaHecha.Name = "tbPreguntaHecha"
        Me.tbPreguntaHecha.ReadOnly = True
        Me.tbPreguntaHecha.Size = New System.Drawing.Size(459, 54)
        Me.tbPreguntaHecha.TabIndex = 0
        Me.tbPreguntaHecha.TabStop = False
        '
        'tbAccionSugerida
        '
        Me.tbAccionSugerida.BackColor = System.Drawing.Color.White
        Me.tbAccionSugerida.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbAccionSugerida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccionSugerida.Location = New System.Drawing.Point(6, 112)
        Me.tbAccionSugerida.Multiline = True
        Me.tbAccionSugerida.Name = "tbAccionSugerida"
        Me.tbAccionSugerida.ReadOnly = True
        Me.tbAccionSugerida.Size = New System.Drawing.Size(459, 54)
        Me.tbAccionSugerida.TabIndex = 1
        Me.tbAccionSugerida.TabStop = False
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(6, 9)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(60, 16)
        Me.lblPregunta.TabIndex = 2
        Me.lblPregunta.Text = "Pregunta"
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccion.Location = New System.Drawing.Point(6, 96)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(46, 16)
        Me.lblAccion.TabIndex = 3
        Me.lblAccion.Text = "Accion"
        '
        'lblRespustaObtenida
        '
        Me.lblRespustaObtenida.AutoSize = True
        Me.lblRespustaObtenida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespustaObtenida.Location = New System.Drawing.Point(3, 181)
        Me.lblRespustaObtenida.Name = "lblRespustaObtenida"
        Me.lblRespustaObtenida.Size = New System.Drawing.Size(126, 16)
        Me.lblRespustaObtenida.TabIndex = 5
        Me.lblRespustaObtenida.Text = "Respuesta Obtenida"
        '
        'lblNivelExposicion
        '
        Me.lblNivelExposicion.AutoSize = True
        Me.lblNivelExposicion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelExposicion.Location = New System.Drawing.Point(3, 280)
        Me.lblNivelExposicion.Name = "lblNivelExposicion"
        Me.lblNivelExposicion.Size = New System.Drawing.Size(70, 16)
        Me.lblNivelExposicion.TabIndex = 6
        Me.lblNivelExposicion.Text = "Exposicion"
        '
        'lblNivelProbabilidad
        '
        Me.lblNivelProbabilidad.AutoSize = True
        Me.lblNivelProbabilidad.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelProbabilidad.Location = New System.Drawing.Point(3, 247)
        Me.lblNivelProbabilidad.Name = "lblNivelProbabilidad"
        Me.lblNivelProbabilidad.Size = New System.Drawing.Size(83, 16)
        Me.lblNivelProbabilidad.TabIndex = 7
        Me.lblNivelProbabilidad.Text = "Probabilidad"
        '
        'lblNivelConsecuencia
        '
        Me.lblNivelConsecuencia.AutoSize = True
        Me.lblNivelConsecuencia.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelConsecuencia.Location = New System.Drawing.Point(3, 313)
        Me.lblNivelConsecuencia.Name = "lblNivelConsecuencia"
        Me.lblNivelConsecuencia.Size = New System.Drawing.Size(87, 16)
        Me.lblNivelConsecuencia.TabIndex = 8
        Me.lblNivelConsecuencia.Text = "Consecuencia"
        '
        'lblRiesgoMuerte
        '
        Me.lblRiesgoMuerte.AutoSize = True
        Me.lblRiesgoMuerte.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRiesgoMuerte.Location = New System.Drawing.Point(3, 216)
        Me.lblRiesgoMuerte.Name = "lblRiesgoMuerte"
        Me.lblRiesgoMuerte.Size = New System.Drawing.Size(113, 16)
        Me.lblRiesgoMuerte.TabIndex = 9
        Me.lblRiesgoMuerte.Text = "Riesgo de Muerte"
        '
        'tbRespuestaObetenida
        '
        Me.tbRespuestaObetenida.BackColor = System.Drawing.Color.White
        Me.tbRespuestaObetenida.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbRespuestaObetenida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRespuestaObetenida.Location = New System.Drawing.Point(130, 177)
        Me.tbRespuestaObetenida.Name = "tbRespuestaObetenida"
        Me.tbRespuestaObetenida.ReadOnly = True
        Me.tbRespuestaObetenida.Size = New System.Drawing.Size(335, 24)
        Me.tbRespuestaObetenida.TabIndex = 10
        Me.tbRespuestaObetenida.TabStop = False
        '
        'tbRiesgoMuerte
        '
        Me.tbRiesgoMuerte.BackColor = System.Drawing.Color.White
        Me.tbRiesgoMuerte.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbRiesgoMuerte.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRiesgoMuerte.Location = New System.Drawing.Point(130, 212)
        Me.tbRiesgoMuerte.Name = "tbRiesgoMuerte"
        Me.tbRiesgoMuerte.ReadOnly = True
        Me.tbRiesgoMuerte.Size = New System.Drawing.Size(335, 24)
        Me.tbRiesgoMuerte.TabIndex = 11
        Me.tbRiesgoMuerte.TabStop = False
        '
        'tbNivelExposicion
        '
        Me.tbNivelExposicion.BackColor = System.Drawing.Color.White
        Me.tbNivelExposicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNivelExposicion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNivelExposicion.Location = New System.Drawing.Point(130, 276)
        Me.tbNivelExposicion.Name = "tbNivelExposicion"
        Me.tbNivelExposicion.ReadOnly = True
        Me.tbNivelExposicion.Size = New System.Drawing.Size(335, 24)
        Me.tbNivelExposicion.TabIndex = 12
        Me.tbNivelExposicion.TabStop = False
        '
        'tbNivelProbabilidad
        '
        Me.tbNivelProbabilidad.BackColor = System.Drawing.Color.White
        Me.tbNivelProbabilidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNivelProbabilidad.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNivelProbabilidad.Location = New System.Drawing.Point(130, 243)
        Me.tbNivelProbabilidad.Name = "tbNivelProbabilidad"
        Me.tbNivelProbabilidad.ReadOnly = True
        Me.tbNivelProbabilidad.Size = New System.Drawing.Size(335, 24)
        Me.tbNivelProbabilidad.TabIndex = 13
        Me.tbNivelProbabilidad.TabStop = False
        '
        'tbNivelConsecuencia
        '
        Me.tbNivelConsecuencia.BackColor = System.Drawing.Color.White
        Me.tbNivelConsecuencia.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNivelConsecuencia.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNivelConsecuencia.Location = New System.Drawing.Point(130, 309)
        Me.tbNivelConsecuencia.Name = "tbNivelConsecuencia"
        Me.tbNivelConsecuencia.ReadOnly = True
        Me.tbNivelConsecuencia.Size = New System.Drawing.Size(335, 24)
        Me.tbNivelConsecuencia.TabIndex = 14
        Me.tbNivelConsecuencia.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(473, 350)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.Visible = False
        Me.LineShape2.X1 = 12
        Me.LineShape2.X2 = 459
        Me.LineShape2.Y1 = 206
        Me.LineShape2.Y2 = 206
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 457
        Me.LineShape1.Y1 = 342
        Me.LineShape1.Y2 = 342
        '
        'lblGPporPregunta
        '
        Me.lblGPporPregunta.AutoSize = True
        Me.lblGPporPregunta.Location = New System.Drawing.Point(259, 90)
        Me.lblGPporPregunta.Name = "lblGPporPregunta"
        Me.lblGPporPregunta.Size = New System.Drawing.Size(90, 13)
        Me.lblGPporPregunta.TabIndex = 16
        Me.lblGPporPregunta.Text = "lblGPporPregunta"
        Me.lblGPporPregunta.Visible = False
        '
        'lblExpuestos
        '
        Me.lblExpuestos.AutoSize = True
        Me.lblExpuestos.Location = New System.Drawing.Point(391, 90)
        Me.lblExpuestos.Name = "lblExpuestos"
        Me.lblExpuestos.Size = New System.Drawing.Size(66, 13)
        Me.lblExpuestos.TabIndex = 17
        Me.lblExpuestos.Text = "lblExpuestos"
        Me.lblExpuestos.Visible = False
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(281, 9)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(68, 13)
        Me.lblRespuesta.TabIndex = 18
        Me.lblRespuesta.Text = "lblRespuesta"
        Me.lblRespuesta.Visible = False
        '
        'lblRiesgoMuerteRes
        '
        Me.lblRiesgoMuerteRes.AutoSize = True
        Me.lblRiesgoMuerteRes.Location = New System.Drawing.Point(355, 9)
        Me.lblRiesgoMuerteRes.Name = "lblRiesgoMuerteRes"
        Me.lblRiesgoMuerteRes.Size = New System.Drawing.Size(102, 13)
        Me.lblRiesgoMuerteRes.TabIndex = 19
        Me.lblRiesgoMuerteRes.Text = "lblRiesgoMuerteRes"
        Me.lblRiesgoMuerteRes.Visible = False
        '
        'PanelIncidenciaDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 350)
        Me.Controls.Add(Me.lblRiesgoMuerteRes)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.lblExpuestos)
        Me.Controls.Add(Me.lblGPporPregunta)
        Me.Controls.Add(Me.tbNivelConsecuencia)
        Me.Controls.Add(Me.tbNivelProbabilidad)
        Me.Controls.Add(Me.tbNivelExposicion)
        Me.Controls.Add(Me.tbRiesgoMuerte)
        Me.Controls.Add(Me.tbRespuestaObetenida)
        Me.Controls.Add(Me.lblRiesgoMuerte)
        Me.Controls.Add(Me.lblNivelConsecuencia)
        Me.Controls.Add(Me.lblNivelProbabilidad)
        Me.Controls.Add(Me.lblNivelExposicion)
        Me.Controls.Add(Me.lblRespustaObtenida)
        Me.Controls.Add(Me.lblAccion)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.tbAccionSugerida)
        Me.Controls.Add(Me.tbPreguntaHecha)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelIncidenciaDetalle"
        Me.Text = "PanelDetalles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbPreguntaHecha As System.Windows.Forms.TextBox
    Friend WithEvents tbAccionSugerida As System.Windows.Forms.TextBox
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents lblRespustaObtenida As System.Windows.Forms.Label
    Friend WithEvents lblNivelExposicion As System.Windows.Forms.Label
    Friend WithEvents lblNivelProbabilidad As System.Windows.Forms.Label
    Friend WithEvents lblNivelConsecuencia As System.Windows.Forms.Label
    Friend WithEvents lblRiesgoMuerte As System.Windows.Forms.Label
    Friend WithEvents tbRespuestaObetenida As System.Windows.Forms.TextBox
    Friend WithEvents tbRiesgoMuerte As System.Windows.Forms.TextBox
    Friend WithEvents tbNivelExposicion As System.Windows.Forms.TextBox
    Friend WithEvents tbNivelProbabilidad As System.Windows.Forms.TextBox
    Friend WithEvents tbNivelConsecuencia As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblGPporPregunta As System.Windows.Forms.Label
    Friend WithEvents lblExpuestos As System.Windows.Forms.Label
    Friend WithEvents lblRespuesta As System.Windows.Forms.Label
    Friend WithEvents lblRiesgoMuerteRes As System.Windows.Forms.Label
End Class
