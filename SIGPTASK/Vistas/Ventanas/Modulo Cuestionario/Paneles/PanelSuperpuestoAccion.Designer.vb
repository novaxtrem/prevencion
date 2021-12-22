<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelSuperpuestoAccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelSuperpuestoAccion))
        Me.lblTextoGenerico = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTextoGenerico
        '
        Me.lblTextoGenerico.AutoSize = True
        Me.lblTextoGenerico.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoGenerico.Location = New System.Drawing.Point(32, 228)
        Me.lblTextoGenerico.Name = "lblTextoGenerico"
        Me.lblTextoGenerico.Size = New System.Drawing.Size(284, 21)
        Me.lblTextoGenerico.TabIndex = 0
        Me.lblTextoGenerico.Text = "Debe seleccionar una pregunta primero"
        '
        'PanelSuperpuestoAccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(352, 515)
        Me.Controls.Add(Me.lblTextoGenerico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelSuperpuestoAccion"
        Me.Text = "PanelSuperpuestoAccionvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTextoGenerico As System.Windows.Forms.Label
End Class
