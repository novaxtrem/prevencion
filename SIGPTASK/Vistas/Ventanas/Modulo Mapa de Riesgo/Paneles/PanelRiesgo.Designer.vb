<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelRiesgo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelRiesgo))
        Me.lblIdRiesgo = New System.Windows.Forms.Label()
        Me.lblRutaIcono = New System.Windows.Forms.Label()
        Me.lblRiesgoNom = New System.Windows.Forms.Label()
        Me.pictureRiesgo = New System.Windows.Forms.PictureBox()
        CType(Me.pictureRiesgo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdRiesgo
        '
        Me.lblIdRiesgo.AutoSize = True
        Me.lblIdRiesgo.Location = New System.Drawing.Point(9, 13)
        Me.lblIdRiesgo.Name = "lblIdRiesgo"
        Me.lblIdRiesgo.Size = New System.Drawing.Size(59, 13)
        Me.lblIdRiesgo.TabIndex = 0
        Me.lblIdRiesgo.Text = "lblIdRiesgo"
        '
        'lblRutaIcono
        '
        Me.lblRutaIcono.AutoSize = True
        Me.lblRutaIcono.Location = New System.Drawing.Point(9, 43)
        Me.lblRutaIcono.Name = "lblRutaIcono"
        Me.lblRutaIcono.Size = New System.Drawing.Size(67, 13)
        Me.lblRutaIcono.TabIndex = 1
        Me.lblRutaIcono.Text = "lblRutaIcono"
        '
        'lblRiesgoNom
        '
        Me.lblRiesgoNom.AutoSize = True
        Me.lblRiesgoNom.Location = New System.Drawing.Point(9, 77)
        Me.lblRiesgoNom.Name = "lblRiesgoNom"
        Me.lblRiesgoNom.Size = New System.Drawing.Size(72, 13)
        Me.lblRiesgoNom.TabIndex = 2
        Me.lblRiesgoNom.Text = "lblRiesgoNom"
        '
        'pictureRiesgo
        '
        Me.pictureRiesgo.BackColor = System.Drawing.Color.White
        Me.pictureRiesgo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureRiesgo.Location = New System.Drawing.Point(0, 0)
        Me.pictureRiesgo.Name = "pictureRiesgo"
        Me.pictureRiesgo.Size = New System.Drawing.Size(89, 102)
        Me.pictureRiesgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureRiesgo.TabIndex = 3
        Me.pictureRiesgo.TabStop = False
        '
        'PanelRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(89, 102)
        Me.Controls.Add(Me.pictureRiesgo)
        Me.Controls.Add(Me.lblRiesgoNom)
        Me.Controls.Add(Me.lblRutaIcono)
        Me.Controls.Add(Me.lblIdRiesgo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelRiesgo"
        Me.Text = "PanelRiesgo"
        CType(Me.pictureRiesgo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIdRiesgo As System.Windows.Forms.Label
    Friend WithEvents lblRutaIcono As System.Windows.Forms.Label
    Friend WithEvents lblRiesgoNom As System.Windows.Forms.Label
    Friend WithEvents pictureRiesgo As System.Windows.Forms.PictureBox
End Class
