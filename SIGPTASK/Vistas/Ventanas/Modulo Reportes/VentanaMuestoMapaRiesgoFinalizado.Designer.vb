<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaMuestoMapaRiesgoFinalizado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaMuestoMapaRiesgoFinalizado))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.lblCoordenadasMouseClic = New System.Windows.Forms.Label()
        Me.panelPortaPlano = New System.Windows.Forms.Panel()
        Me.pictureBoxPlano = New System.Windows.Forms.PictureBox()
        Me.btnExportarReporte = New System.Windows.Forms.Button()
        Me.panenInferior = New System.Windows.Forms.Panel()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPortaPlano.SuspendLayout()
        CType(Me.pictureBoxPlano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panenInferior.SuspendLayout()
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
        Me.panelSuperior.Size = New System.Drawing.Size(1057, 25)
        Me.panelSuperior.TabIndex = 20
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
        Me.pictureMinimize.Location = New System.Drawing.Point(1014, 5)
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
        Me.pictureClose.Location = New System.Drawing.Point(1035, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 34
        Me.pictureClose.TabStop = False
        '
        'lblCoordenadasMouseClic
        '
        Me.lblCoordenadasMouseClic.AutoSize = True
        Me.lblCoordenadasMouseClic.Location = New System.Drawing.Point(12, 13)
        Me.lblCoordenadasMouseClic.Name = "lblCoordenadasMouseClic"
        Me.lblCoordenadasMouseClic.Size = New System.Drawing.Size(129, 13)
        Me.lblCoordenadasMouseClic.TabIndex = 37
        Me.lblCoordenadasMouseClic.Text = "lblCoordenadasMouseClic"
        Me.lblCoordenadasMouseClic.Visible = False
        '
        'panelPortaPlano
        '
        Me.panelPortaPlano.AutoScroll = True
        Me.panelPortaPlano.BackColor = System.Drawing.Color.White
        Me.panelPortaPlano.Controls.Add(Me.pictureBoxPlano)
        Me.panelPortaPlano.Location = New System.Drawing.Point(0, 26)
        Me.panelPortaPlano.Name = "panelPortaPlano"
        Me.panelPortaPlano.Size = New System.Drawing.Size(1057, 582)
        Me.panelPortaPlano.TabIndex = 58
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
        'btnExportarReporte
        '
        Me.btnExportarReporte.BackColor = System.Drawing.Color.White
        Me.btnExportarReporte.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExportarReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnExportarReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnExportarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarReporte.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportarReporte.Location = New System.Drawing.Point(885, 5)
        Me.btnExportarReporte.Name = "btnExportarReporte"
        Me.btnExportarReporte.Size = New System.Drawing.Size(165, 30)
        Me.btnExportarReporte.TabIndex = 59
        Me.btnExportarReporte.Text = "Exportar reporte"
        Me.btnExportarReporte.UseVisualStyleBackColor = False
        '
        'panenInferior
        '
        Me.panenInferior.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panenInferior.Controls.Add(Me.lblCoordenadasMouseClic)
        Me.panenInferior.Controls.Add(Me.btnExportarReporte)
        Me.panenInferior.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panenInferior.Location = New System.Drawing.Point(0, 609)
        Me.panenInferior.Name = "panenInferior"
        Me.panenInferior.Size = New System.Drawing.Size(1057, 40)
        Me.panenInferior.TabIndex = 59
        '
        'VentanaMuestoMapaRiesgoFinalizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1057, 649)
        Me.Controls.Add(Me.panenInferior)
        Me.Controls.Add(Me.panelPortaPlano)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaMuestoMapaRiesgoFinalizado"
        Me.Text = "VentanaMuestoMapaRiesgoFinalizado"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPortaPlano.ResumeLayout(False)
        Me.panelPortaPlano.PerformLayout()
        CType(Me.pictureBoxPlano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panenInferior.ResumeLayout(False)
        Me.panenInferior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblCoordenadasMouseClic As System.Windows.Forms.Label
    Friend WithEvents panelPortaPlano As System.Windows.Forms.Panel
    Friend WithEvents pictureBoxPlano As System.Windows.Forms.PictureBox
    Friend WithEvents btnExportarReporte As System.Windows.Forms.Button
    Friend WithEvents panenInferior As System.Windows.Forms.Panel
End Class
