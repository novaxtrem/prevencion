<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCargarRiesgo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCargarRiesgo))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblNombreRiesgo = New System.Windows.Forms.Label()
        Me.tbNombreRiesgo = New System.Windows.Forms.TextBox()
        Me.btnCargarImagendelRiesgo = New System.Windows.Forms.Button()
        Me.pictureRiesgoPreview = New System.Windows.Forms.PictureBox()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.lblRutaArchivo = New System.Windows.Forms.Label()
        CType(Me.pictureRiesgoPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(12, 132)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 30)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(139, 132)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 30)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblNombreRiesgo
        '
        Me.lblNombreRiesgo.AutoSize = True
        Me.lblNombreRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreRiesgo.Location = New System.Drawing.Point(12, 35)
        Me.lblNombreRiesgo.Name = "lblNombreRiesgo"
        Me.lblNombreRiesgo.Size = New System.Drawing.Size(101, 16)
        Me.lblNombreRiesgo.TabIndex = 3
        Me.lblNombreRiesgo.Text = "Nombre Riesgo"
        '
        'tbNombreRiesgo
        '
        Me.tbNombreRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreRiesgo.Location = New System.Drawing.Point(12, 54)
        Me.tbNombreRiesgo.Name = "tbNombreRiesgo"
        Me.tbNombreRiesgo.Size = New System.Drawing.Size(247, 24)
        Me.tbNombreRiesgo.TabIndex = 4
        '
        'btnCargarImagendelRiesgo
        '
        Me.btnCargarImagendelRiesgo.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnCargarImagendelRiesgo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCargarImagendelRiesgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCargarImagendelRiesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagendelRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarImagendelRiesgo.Location = New System.Drawing.Point(12, 96)
        Me.btnCargarImagendelRiesgo.Name = "btnCargarImagendelRiesgo"
        Me.btnCargarImagendelRiesgo.Size = New System.Drawing.Size(247, 30)
        Me.btnCargarImagendelRiesgo.TabIndex = 7
        Me.btnCargarImagendelRiesgo.Text = "Cargar Imagen del Riesgo"
        Me.btnCargarImagendelRiesgo.UseVisualStyleBackColor = True
        '
        'pictureRiesgoPreview
        '
        Me.pictureRiesgoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureRiesgoPreview.Location = New System.Drawing.Point(265, 35)
        Me.pictureRiesgoPreview.Name = "pictureRiesgoPreview"
        Me.pictureRiesgoPreview.Size = New System.Drawing.Size(117, 127)
        Me.pictureRiesgoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureRiesgoPreview.TabIndex = 8
        Me.pictureRiesgoPreview.TabStop = False
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
        Me.panelSuperior.Size = New System.Drawing.Size(390, 25)
        Me.panelSuperior.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(347, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 37
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(368, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 36
        Me.pictureClose.TabStop = False
        '
        'lblRutaArchivo
        '
        Me.lblRutaArchivo.AutoSize = True
        Me.lblRutaArchivo.Location = New System.Drawing.Point(0, 81)
        Me.lblRutaArchivo.Name = "lblRutaArchivo"
        Me.lblRutaArchivo.Size = New System.Drawing.Size(76, 13)
        Me.lblRutaArchivo.TabIndex = 10
        Me.lblRutaArchivo.Text = "lblRutaArchivo"
        Me.lblRutaArchivo.Visible = False
        '
        'VentanaCargarRiesgo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 171)
        Me.Controls.Add(Me.lblRutaArchivo)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.pictureRiesgoPreview)
        Me.Controls.Add(Me.btnCargarImagendelRiesgo)
        Me.Controls.Add(Me.tbNombreRiesgo)
        Me.Controls.Add(Me.lblNombreRiesgo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaCargarRiesgo"
        Me.Text = "VentanaAgregoRiesgo"
        CType(Me.pictureRiesgoPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblNombreRiesgo As System.Windows.Forms.Label
    Friend WithEvents tbNombreRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents btnCargarImagendelRiesgo As System.Windows.Forms.Button
    Friend WithEvents pictureRiesgoPreview As System.Windows.Forms.PictureBox
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRutaArchivo As System.Windows.Forms.Label
End Class
