<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelSuperpuestoPregunta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelSuperpuestoPregunta))
        Me.lblPreguntaSeleccionada = New System.Windows.Forms.Label()
        Me.tbPreguntaSeleccionada = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPreguntaSeleccionada
        '
        Me.lblPreguntaSeleccionada.AutoSize = True
        Me.lblPreguntaSeleccionada.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntaSeleccionada.Location = New System.Drawing.Point(19, 178)
        Me.lblPreguntaSeleccionada.Name = "lblPreguntaSeleccionada"
        Me.lblPreguntaSeleccionada.Size = New System.Drawing.Size(147, 21)
        Me.lblPreguntaSeleccionada.TabIndex = 1
        Me.lblPreguntaSeleccionada.Text = "Seleccione la accion"
        '
        'tbPreguntaSeleccionada
        '
        Me.tbPreguntaSeleccionada.BackColor = System.Drawing.Color.White
        Me.tbPreguntaSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPreguntaSeleccionada.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPreguntaSeleccionada.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPreguntaSeleccionada.Location = New System.Drawing.Point(23, 202)
        Me.tbPreguntaSeleccionada.Multiline = True
        Me.tbPreguntaSeleccionada.Name = "tbPreguntaSeleccionada"
        Me.tbPreguntaSeleccionada.ReadOnly = True
        Me.tbPreguntaSeleccionada.Size = New System.Drawing.Size(290, 82)
        Me.tbPreguntaSeleccionada.TabIndex = 2
        '
        'PanelSuperpuestoPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 476)
        Me.Controls.Add(Me.tbPreguntaSeleccionada)
        Me.Controls.Add(Me.lblPreguntaSeleccionada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelSuperpuestoPregunta"
        Me.Text = "panelSuperpuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPreguntaSeleccionada As System.Windows.Forms.Label
    Friend WithEvents tbPreguntaSeleccionada As System.Windows.Forms.TextBox
End Class
