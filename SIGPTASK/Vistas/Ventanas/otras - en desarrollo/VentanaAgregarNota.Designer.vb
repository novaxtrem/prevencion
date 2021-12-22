<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaAgregarNota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaAgregarNota))
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbAnotaciones = New System.Windows.Forms.TextBox()
        Me.lblMaximoCaracteres = New System.Windows.Forms.Label()
        Me.lblAgregarAnotaciones = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(725, 10)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(630, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'tbAnotaciones
        '
        Me.tbAnotaciones.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAnotaciones.Location = New System.Drawing.Point(6, 54)
        Me.tbAnotaciones.Multiline = True
        Me.tbAnotaciones.Name = "tbAnotaciones"
        Me.tbAnotaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbAnotaciones.Size = New System.Drawing.Size(798, 439)
        Me.tbAnotaciones.TabIndex = 2
        '
        'lblMaximoCaracteres
        '
        Me.lblMaximoCaracteres.AutoSize = True
        Me.lblMaximoCaracteres.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximoCaracteres.ForeColor = System.Drawing.Color.White
        Me.lblMaximoCaracteres.Location = New System.Drawing.Point(12, 17)
        Me.lblMaximoCaracteres.Name = "lblMaximoCaracteres"
        Me.lblMaximoCaracteres.Size = New System.Drawing.Size(46, 16)
        Me.lblMaximoCaracteres.TabIndex = 3
        Me.lblMaximoCaracteres.Text = "Label1"
        '
        'lblAgregarAnotaciones
        '
        Me.lblAgregarAnotaciones.AutoSize = True
        Me.lblAgregarAnotaciones.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarAnotaciones.Location = New System.Drawing.Point(3, 35)
        Me.lblAgregarAnotaciones.Name = "lblAgregarAnotaciones"
        Me.lblAgregarAnotaciones.Size = New System.Drawing.Size(307, 16)
        Me.lblAgregarAnotaciones.TabIndex = 4
        Me.lblAgregarAnotaciones.Text = "Agregue todas las anotaciones que crea pertinente"
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
        Me.panelSuperior.Size = New System.Drawing.Size(812, 28)
        Me.panelSuperior.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(767, 6)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 34
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(788, 6)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 33
        Me.pictureClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMaximoCaracteres)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 498)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 47)
        Me.Panel1.TabIndex = 6
        '
        'VentanaAgregarNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.lblAgregarAnotaciones)
        Me.Controls.Add(Me.tbAnotaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaAgregarNota"
        Me.Text = "VentanaAgegarNota"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents tbAnotaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblMaximoCaracteres As System.Windows.Forms.Label
    Friend WithEvents lblAgregarAnotaciones As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
