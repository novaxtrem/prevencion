<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCargoObjeto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCargoObjeto))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblAgregarObjeto = New System.Windows.Forms.Label()
        Me.tbObjeto = New System.Windows.Forms.TextBox()
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
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(38, 145)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(174, 145)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 30)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblAgregarObjeto
        '
        Me.lblAgregarObjeto.AutoSize = True
        Me.lblAgregarObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarObjeto.Location = New System.Drawing.Point(12, 32)
        Me.lblAgregarObjeto.Name = "lblAgregarObjeto"
        Me.lblAgregarObjeto.Size = New System.Drawing.Size(100, 16)
        Me.lblAgregarObjeto.TabIndex = 3
        Me.lblAgregarObjeto.Text = "Agregar Objeto"
        '
        'tbObjeto
        '
        Me.tbObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObjeto.Location = New System.Drawing.Point(12, 56)
        Me.tbObjeto.Multiline = True
        Me.tbObjeto.Name = "tbObjeto"
        Me.tbObjeto.Size = New System.Drawing.Size(282, 58)
        Me.tbObjeto.TabIndex = 4
        '
        'lblContadorCaracteres
        '
        Me.lblContadorCaracteres.AutoSize = True
        Me.lblContadorCaracteres.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorCaracteres.Location = New System.Drawing.Point(12, 122)
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
        Me.panelSuperior.TabIndex = 8
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
        'VentanaCargoObjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(306, 187)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.lblContadorCaracteres)
        Me.Controls.Add(Me.tbObjeto)
        Me.Controls.Add(Me.lblAgregarObjeto)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaCargoObjeto"
        Me.Text = "VentanaCargoObjeto"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblAgregarObjeto As System.Windows.Forms.Label
    Friend WithEvents tbObjeto As System.Windows.Forms.TextBox
    Friend WithEvents lblContadorCaracteres As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
End Class
