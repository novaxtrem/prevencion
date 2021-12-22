<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaLogin))
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.tbUsuario = New System.Windows.Forms.TextBox()
        Me.tbContrasena = New System.Windows.Forms.TextBox()
        Me.pictureBoxTaskLogo = New System.Windows.Forms.PictureBox()
        Me.linkLabelIngles = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.lvlVersion = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.pictureBoxTaskLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(306, 116)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(53, 16)
        Me.lblNombreUsuario.TabIndex = 0
        Me.lblNombreUsuario.Text = "Usuario"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(306, 146)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(74, 16)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarSesion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(170, 180)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(130, 30)
        Me.btnIniciarSesion.TabIndex = 2
        Me.btnIniciarSesion.Text = "Iniciar Sesion"
        Me.btnIniciarSesion.UseVisualStyleBackColor = True
        '
        'tbUsuario
        '
        Me.tbUsuario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuario.Location = New System.Drawing.Point(170, 113)
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.Size = New System.Drawing.Size(130, 24)
        Me.tbUsuario.TabIndex = 3
        Me.tbUsuario.Text = "lyampa"
        '
        'tbContrasena
        '
        Me.tbContrasena.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContrasena.Location = New System.Drawing.Point(170, 143)
        Me.tbContrasena.Name = "tbContrasena"
        Me.tbContrasena.Size = New System.Drawing.Size(130, 24)
        Me.tbContrasena.TabIndex = 4
        Me.tbContrasena.Text = "1234"
        Me.tbContrasena.UseSystemPasswordChar = True
        '
        'pictureBoxTaskLogo
        '
        Me.pictureBoxTaskLogo.Image = Global.SIGPTASK.My.Resources.Resources.fenix_dos
        Me.pictureBoxTaskLogo.Location = New System.Drawing.Point(80, 39)
        Me.pictureBoxTaskLogo.Name = "pictureBoxTaskLogo"
        Me.pictureBoxTaskLogo.Size = New System.Drawing.Size(135, 149)
        Me.pictureBoxTaskLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxTaskLogo.TabIndex = 6
        Me.pictureBoxTaskLogo.TabStop = False
        '
        'linkLabelIngles
        '
        Me.linkLabelIngles.AutoSize = True
        Me.linkLabelIngles.LinkColor = System.Drawing.Color.Orange
        Me.linkLabelIngles.Location = New System.Drawing.Point(317, 262)
        Me.linkLabelIngles.Name = "linkLabelIngles"
        Me.linkLabelIngles.Size = New System.Drawing.Size(54, 13)
        Me.linkLabelIngles.TabIndex = 8
        Me.linkLabelIngles.TabStop = True
        Me.linkLabelIngles.Text = "ENGLISH"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Orange
        Me.LinkLabel1.Location = New System.Drawing.Point(377, 262)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "ESPAÑOL"
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(425, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 30
        Me.pictureClose.TabStop = False
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.Transparent
        Me.panelSuperior.Controls.Add(Me.LinkLabel2)
        Me.panelSuperior.Controls.Add(Me.lvlVersion)
        Me.panelSuperior.Controls.Add(Me.pictureBoxTaskLogo)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(447, 284)
        Me.panelSuperior.TabIndex = 31
        '
        'lvlVersion
        '
        Me.lvlVersion.AutoSize = True
        Me.lvlVersion.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlVersion.Location = New System.Drawing.Point(3, 267)
        Me.lvlVersion.Name = "lvlVersion"
        Me.lvlVersion.Size = New System.Drawing.Size(71, 14)
        Me.lvlVersion.TabIndex = 32
        Me.lvlVersion.Text = "version 0.7.3"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Orange
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 5)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 13)
        Me.LinkLabel2.TabIndex = 32
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Manual Sin Terminar"
        '
        'VentanaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(447, 284)
        Me.Controls.Add(Me.pictureClose)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.linkLabelIngles)
        Me.Controls.Add(Me.tbContrasena)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.btnIniciarSesion)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblNombreUsuario)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaLogin"
        Me.Text = "Form1"
        CType(Me.pictureBoxTaskLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        Me.panelSuperior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasena As System.Windows.Forms.Label
    Friend WithEvents btnIniciarSesion As System.Windows.Forms.Button
    Friend WithEvents tbUsuario As System.Windows.Forms.TextBox
    Friend WithEvents tbContrasena As System.Windows.Forms.TextBox
    Friend WithEvents pictureBoxTaskLogo As System.Windows.Forms.PictureBox
    Friend WithEvents linkLabelIngles As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents lvlVersion As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
