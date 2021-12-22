<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCargarPregunta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCargarPregunta))
        Me.ckbRiesgoMuerte = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblAgregarPregunta = New System.Windows.Forms.Label()
        Me.tbPregunta = New System.Windows.Forms.TextBox()
        Me.lblID_pregunta = New System.Windows.Forms.Label()
        Me.lblContadorCaracteres = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ckbRiesgoMuerte
        '
        Me.ckbRiesgoMuerte.AutoSize = True
        Me.ckbRiesgoMuerte.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbRiesgoMuerte.Location = New System.Drawing.Point(181, 115)
        Me.ckbRiesgoMuerte.Name = "ckbRiesgoMuerte"
        Me.ckbRiesgoMuerte.Size = New System.Drawing.Size(113, 20)
        Me.ckbRiesgoMuerte.TabIndex = 0
        Me.ckbRiesgoMuerte.Text = "Riesgo Muerte"
        Me.ckbRiesgoMuerte.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(38, 147)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(97, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(158, 147)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(97, 30)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblAgregarPregunta
        '
        Me.lblAgregarPregunta.AutoSize = True
        Me.lblAgregarPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarPregunta.Location = New System.Drawing.Point(9, 36)
        Me.lblAgregarPregunta.Name = "lblAgregarPregunta"
        Me.lblAgregarPregunta.Size = New System.Drawing.Size(112, 16)
        Me.lblAgregarPregunta.TabIndex = 3
        Me.lblAgregarPregunta.Text = "Agregar Pregunta"
        '
        'tbPregunta
        '
        Me.tbPregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPregunta.Location = New System.Drawing.Point(12, 55)
        Me.tbPregunta.Multiline = True
        Me.tbPregunta.Name = "tbPregunta"
        Me.tbPregunta.Size = New System.Drawing.Size(282, 58)
        Me.tbPregunta.TabIndex = 4
        '
        'lblID_pregunta
        '
        Me.lblID_pregunta.AutoSize = True
        Me.lblID_pregunta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_pregunta.Location = New System.Drawing.Point(202, 36)
        Me.lblID_pregunta.Name = "lblID_pregunta"
        Me.lblID_pregunta.Size = New System.Drawing.Size(92, 16)
        Me.lblID_pregunta.TabIndex = 5
        Me.lblID_pregunta.Text = "lblID_pregunta"
        Me.lblID_pregunta.Visible = False
        '
        'lblContadorCaracteres
        '
        Me.lblContadorCaracteres.AutoSize = True
        Me.lblContadorCaracteres.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorCaracteres.Location = New System.Drawing.Point(9, 116)
        Me.lblContadorCaracteres.Name = "lblContadorCaracteres"
        Me.lblContadorCaracteres.Size = New System.Drawing.Size(139, 16)
        Me.lblContadorCaracteres.TabIndex = 6
        Me.lblContadorCaracteres.Text = "lblContadorCaracteres"
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
        Me.panelSuperior.Size = New System.Drawing.Size(306, 25)
        Me.panelSuperior.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(262, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 39
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(283, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 38
        Me.pictureClose.TabStop = False
        '
        'VentanaCargarPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 187)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.lblContadorCaracteres)
        Me.Controls.Add(Me.lblID_pregunta)
        Me.Controls.Add(Me.tbPregunta)
        Me.Controls.Add(Me.lblAgregarPregunta)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.ckbRiesgoMuerte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaCargarPregunta"
        Me.Text = "VentanaCargoPregunta"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ckbRiesgoMuerte As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarPregunta As System.Windows.Forms.Label
    Friend WithEvents tbPregunta As System.Windows.Forms.TextBox
    Friend WithEvents lblID_pregunta As System.Windows.Forms.Label
    Friend WithEvents lblContadorCaracteres As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
End Class
