<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculosMetricos
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
        Me.lblIDCuestionario = New System.Windows.Forms.Label()
        Me.lblFechaCuestioanrio = New System.Windows.Forms.Label()
        Me.lblCedulaTecnico = New System.Windows.Forms.Label()
        Me.tbTotalPreguntasRealizadas = New System.Windows.Forms.TextBox()
        Me.tbRespuestasRiesgoMuerteContestadasMal = New System.Windows.Forms.TextBox()
        Me.tbRespuestasBien = New System.Windows.Forms.TextBox()
        Me.tbPreguntasConRiesgoDeMuerte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbRespuestasMal = New System.Windows.Forms.TextBox()
        Me.panelGraficas = New System.Windows.Forms.Panel()
        Me.lblExtremo = New System.Windows.Forms.Label()
        Me.lblAlto = New System.Windows.Forms.Label()
        Me.lblMedio = New System.Windows.Forms.Label()
        Me.lblBajo = New System.Windows.Forms.Label()
        Me.lblNulo = New System.Windows.Forms.Label()
        Me.barGradoPeligrosidad = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.panelGraficas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblIDCuestionario
        '
        Me.lblIDCuestionario.AutoSize = True
        Me.lblIDCuestionario.Location = New System.Drawing.Point(29, 28)
        Me.lblIDCuestionario.Name = "lblIDCuestionario"
        Me.lblIDCuestionario.Size = New System.Drawing.Size(78, 13)
        Me.lblIDCuestionario.TabIndex = 0
        Me.lblIDCuestionario.Text = "ID cuestionario"
        '
        'lblFechaCuestioanrio
        '
        Me.lblFechaCuestioanrio.AutoSize = True
        Me.lblFechaCuestioanrio.Location = New System.Drawing.Point(1090, 28)
        Me.lblFechaCuestioanrio.Name = "lblFechaCuestioanrio"
        Me.lblFechaCuestioanrio.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaCuestioanrio.TabIndex = 1
        Me.lblFechaCuestioanrio.Text = "Fecha Inspeccion"
        '
        'lblCedulaTecnico
        '
        Me.lblCedulaTecnico.AutoSize = True
        Me.lblCedulaTecnico.Location = New System.Drawing.Point(782, 28)
        Me.lblCedulaTecnico.Name = "lblCedulaTecnico"
        Me.lblCedulaTecnico.Size = New System.Drawing.Size(82, 13)
        Me.lblCedulaTecnico.TabIndex = 2
        Me.lblCedulaTecnico.Text = "Cedula Tecnico"
        '
        'tbTotalPreguntasRealizadas
        '
        Me.tbTotalPreguntasRealizadas.Location = New System.Drawing.Point(218, 96)
        Me.tbTotalPreguntasRealizadas.Name = "tbTotalPreguntasRealizadas"
        Me.tbTotalPreguntasRealizadas.Size = New System.Drawing.Size(43, 20)
        Me.tbTotalPreguntasRealizadas.TabIndex = 3
        Me.tbTotalPreguntasRealizadas.Text = "10"
        '
        'tbRespuestasRiesgoMuerteContestadasMal
        '
        Me.tbRespuestasRiesgoMuerteContestadasMal.Location = New System.Drawing.Point(398, 201)
        Me.tbRespuestasRiesgoMuerteContestadasMal.Name = "tbRespuestasRiesgoMuerteContestadasMal"
        Me.tbRespuestasRiesgoMuerteContestadasMal.Size = New System.Drawing.Size(43, 20)
        Me.tbRespuestasRiesgoMuerteContestadasMal.TabIndex = 4
        '
        'tbRespuestasBien
        '
        Me.tbRespuestasBien.Location = New System.Drawing.Point(398, 247)
        Me.tbRespuestasBien.Name = "tbRespuestasBien"
        Me.tbRespuestasBien.Size = New System.Drawing.Size(43, 20)
        Me.tbRespuestasBien.TabIndex = 5
        '
        'tbPreguntasConRiesgoDeMuerte
        '
        Me.tbPreguntasConRiesgoDeMuerte.Location = New System.Drawing.Point(218, 144)
        Me.tbPreguntasConRiesgoDeMuerte.Name = "tbPreguntasConRiesgoDeMuerte"
        Me.tbPreguntasConRiesgoDeMuerte.Size = New System.Drawing.Size(43, 20)
        Me.tbPreguntasConRiesgoDeMuerte.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Preguntas realizadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Preguntas con riesgo de muerte"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Preguntas con riesgo de muerte contestadas insactifactoriamente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Preguntas con cobertura de riesgo satisfactorio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Preguntas con cobertura de riesgo insatisfactorias"
        '
        'tbRespuestasMal
        '
        Me.tbRespuestasMal.Location = New System.Drawing.Point(398, 298)
        Me.tbRespuestasMal.Name = "tbRespuestasMal"
        Me.tbRespuestasMal.Size = New System.Drawing.Size(43, 20)
        Me.tbRespuestasMal.TabIndex = 12
        '
        'panelGraficas
        '
        Me.panelGraficas.Controls.Add(Me.TextBox1)
        Me.panelGraficas.Controls.Add(Me.lblExtremo)
        Me.panelGraficas.Controls.Add(Me.lblAlto)
        Me.panelGraficas.Controls.Add(Me.lblMedio)
        Me.panelGraficas.Controls.Add(Me.lblBajo)
        Me.panelGraficas.Controls.Add(Me.lblNulo)
        Me.panelGraficas.Controls.Add(Me.barGradoPeligrosidad)
        Me.panelGraficas.Location = New System.Drawing.Point(489, 60)
        Me.panelGraficas.Name = "panelGraficas"
        Me.panelGraficas.Size = New System.Drawing.Size(534, 445)
        Me.panelGraficas.TabIndex = 13
        '
        'lblExtremo
        '
        Me.lblExtremo.AutoSize = True
        Me.lblExtremo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtremo.Location = New System.Drawing.Point(402, 19)
        Me.lblExtremo.Name = "lblExtremo"
        Me.lblExtremo.Size = New System.Drawing.Size(29, 31)
        Me.lblExtremo.TabIndex = 6
        Me.lblExtremo.Text = "0"
        '
        'lblAlto
        '
        Me.lblAlto.AutoSize = True
        Me.lblAlto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlto.Location = New System.Drawing.Point(321, 19)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(29, 31)
        Me.lblAlto.TabIndex = 5
        Me.lblAlto.Text = "0"
        '
        'lblMedio
        '
        Me.lblMedio.AutoSize = True
        Me.lblMedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedio.Location = New System.Drawing.Point(216, 19)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(29, 31)
        Me.lblMedio.TabIndex = 4
        Me.lblMedio.Text = "0"
        '
        'lblBajo
        '
        Me.lblBajo.AutoSize = True
        Me.lblBajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBajo.Location = New System.Drawing.Point(115, 19)
        Me.lblBajo.Name = "lblBajo"
        Me.lblBajo.Size = New System.Drawing.Size(29, 31)
        Me.lblBajo.TabIndex = 3
        Me.lblBajo.Text = "0"
        '
        'lblNulo
        '
        Me.lblNulo.AutoSize = True
        Me.lblNulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNulo.Location = New System.Drawing.Point(22, 19)
        Me.lblNulo.Name = "lblNulo"
        Me.lblNulo.Size = New System.Drawing.Size(29, 31)
        Me.lblNulo.TabIndex = 2
        Me.lblNulo.Text = "0"
        '
        'barGradoPeligrosidad
        '
        Me.barGradoPeligrosidad.ForeColor = System.Drawing.Color.Chartreuse
        Me.barGradoPeligrosidad.Location = New System.Drawing.Point(37, 53)
        Me.barGradoPeligrosidad.Name = "barGradoPeligrosidad"
        Me.barGradoPeligrosidad.Size = New System.Drawing.Size(386, 51)
        Me.barGradoPeligrosidad.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 223)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 149)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "SELECT nivel_consecuencia, nivel_exposicion, nivel_probabilidad, riesgo_muerte  F" & _
            "ROM root.incidencia INNER JOIN root.preguntas"
        '
        'CalculosMetricos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 538)
        Me.Controls.Add(Me.panelGraficas)
        Me.Controls.Add(Me.tbRespuestasMal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPreguntasConRiesgoDeMuerte)
        Me.Controls.Add(Me.tbRespuestasBien)
        Me.Controls.Add(Me.tbRespuestasRiesgoMuerteContestadasMal)
        Me.Controls.Add(Me.tbTotalPreguntasRealizadas)
        Me.Controls.Add(Me.lblCedulaTecnico)
        Me.Controls.Add(Me.lblFechaCuestioanrio)
        Me.Controls.Add(Me.lblIDCuestionario)
        Me.Name = "CalculosMetricos"
        Me.Text = "CalculosMetricos"
        Me.panelGraficas.ResumeLayout(False)
        Me.panelGraficas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIDCuestionario As System.Windows.Forms.Label
    Friend WithEvents lblFechaCuestioanrio As System.Windows.Forms.Label
    Friend WithEvents lblCedulaTecnico As System.Windows.Forms.Label
    Friend WithEvents tbTotalPreguntasRealizadas As System.Windows.Forms.TextBox
    Friend WithEvents tbRespuestasRiesgoMuerteContestadasMal As System.Windows.Forms.TextBox
    Friend WithEvents tbRespuestasBien As System.Windows.Forms.TextBox
    Friend WithEvents tbPreguntasConRiesgoDeMuerte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbRespuestasMal As System.Windows.Forms.TextBox
    Friend WithEvents panelGraficas As System.Windows.Forms.Panel
    Friend WithEvents barGradoPeligrosidad As System.Windows.Forms.ProgressBar
    Friend WithEvents lblExtremo As System.Windows.Forms.Label
    Friend WithEvents lblAlto As System.Windows.Forms.Label
    Friend WithEvents lblMedio As System.Windows.Forms.Label
    Friend WithEvents lblBajo As System.Windows.Forms.Label
    Friend WithEvents lblNulo As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
