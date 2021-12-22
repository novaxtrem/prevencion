<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaConfirmacionBorrado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaConfirmacionBorrado))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBorrarSoloSucursal = New System.Windows.Forms.Button()
        Me.tbMensajeAlerta = New System.Windows.Forms.TextBox()
        Me.lblConfirme = New System.Windows.Forms.Label()
        Me.tbConfimacionDeBorrado = New System.Windows.Forms.TextBox()
        Me.btnBorrarTodasLasSucursales = New System.Windows.Forms.Button()
        Me.lblID_SUCURSAL_BORRAR = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUSUARIO_CONECTADO = New System.Windows.Forms.Label()
        Me.lblHORA_SISTEMA = New System.Windows.Forms.Label()
        Me.lblRUT_BORRAR = New System.Windows.Forms.Label()
        Me.panelSuperior.SuspendLayout()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(422, 25)
        Me.panelSuperior.TabIndex = 0
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(378, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 41
        Me.pictureMinimize.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(399, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 40
        Me.pictureClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnBorrarSoloSucursal
        '
        Me.btnBorrarSoloSucursal.Enabled = False
        Me.btnBorrarSoloSucursal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBorrarSoloSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBorrarSoloSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarSoloSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarSoloSucursal.Location = New System.Drawing.Point(255, 172)
        Me.btnBorrarSoloSucursal.Name = "btnBorrarSoloSucursal"
        Me.btnBorrarSoloSucursal.Size = New System.Drawing.Size(155, 30)
        Me.btnBorrarSoloSucursal.TabIndex = 1
        Me.btnBorrarSoloSucursal.Text = "BORAR SUCURSAL"
        Me.btnBorrarSoloSucursal.UseVisualStyleBackColor = True
        '
        'tbMensajeAlerta
        '
        Me.tbMensajeAlerta.BackColor = System.Drawing.Color.White
        Me.tbMensajeAlerta.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMensajeAlerta.Location = New System.Drawing.Point(10, 31)
        Me.tbMensajeAlerta.Multiline = True
        Me.tbMensajeAlerta.Name = "tbMensajeAlerta"
        Me.tbMensajeAlerta.ReadOnly = True
        Me.tbMensajeAlerta.Size = New System.Drawing.Size(400, 105)
        Me.tbMensajeAlerta.TabIndex = 2000
        Me.tbMensajeAlerta.TabStop = False
        '
        'lblConfirme
        '
        Me.lblConfirme.AutoSize = True
        Me.lblConfirme.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirme.Location = New System.Drawing.Point(185, 146)
        Me.lblConfirme.Name = "lblConfirme"
        Me.lblConfirme.Size = New System.Drawing.Size(64, 16)
        Me.lblConfirme.TabIndex = 3
        Me.lblConfirme.Text = "Confirme:"
        '
        'tbConfimacionDeBorrado
        '
        Me.tbConfimacionDeBorrado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfimacionDeBorrado.Location = New System.Drawing.Point(255, 142)
        Me.tbConfimacionDeBorrado.Name = "tbConfimacionDeBorrado"
        Me.tbConfimacionDeBorrado.Size = New System.Drawing.Size(155, 24)
        Me.tbConfimacionDeBorrado.TabIndex = 4
        '
        'btnBorrarTodasLasSucursales
        '
        Me.btnBorrarTodasLasSucursales.Enabled = False
        Me.btnBorrarTodasLasSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBorrarTodasLasSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBorrarTodasLasSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarTodasLasSucursales.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarTodasLasSucursales.Location = New System.Drawing.Point(10, 172)
        Me.btnBorrarTodasLasSucursales.Name = "btnBorrarTodasLasSucursales"
        Me.btnBorrarTodasLasSucursales.Size = New System.Drawing.Size(155, 30)
        Me.btnBorrarTodasLasSucursales.TabIndex = 5
        Me.btnBorrarTodasLasSucursales.Text = "BORRAR TODO"
        Me.btnBorrarTodasLasSucursales.UseVisualStyleBackColor = True
        '
        'lblID_SUCURSAL_BORRAR
        '
        Me.lblID_SUCURSAL_BORRAR.AutoSize = True
        Me.lblID_SUCURSAL_BORRAR.Location = New System.Drawing.Point(23, 47)
        Me.lblID_SUCURSAL_BORRAR.Name = "lblID_SUCURSAL_BORRAR"
        Me.lblID_SUCURSAL_BORRAR.Size = New System.Drawing.Size(144, 13)
        Me.lblID_SUCURSAL_BORRAR.TabIndex = 6
        Me.lblID_SUCURSAL_BORRAR.Text = "lblID_SUCURSAL_BORRAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "lblRUT_EMPRESA_BORRAR"
        '
        'lblUSUARIO_CONECTADO
        '
        Me.lblUSUARIO_CONECTADO.AutoSize = True
        Me.lblUSUARIO_CONECTADO.Location = New System.Drawing.Point(23, 74)
        Me.lblUSUARIO_CONECTADO.Name = "lblUSUARIO_CONECTADO"
        Me.lblUSUARIO_CONECTADO.Size = New System.Drawing.Size(139, 13)
        Me.lblUSUARIO_CONECTADO.TabIndex = 8
        Me.lblUSUARIO_CONECTADO.Text = "lblUSUARIO_CONECTADO"
        '
        'lblHORA_SISTEMA
        '
        Me.lblHORA_SISTEMA.AutoSize = True
        Me.lblHORA_SISTEMA.Location = New System.Drawing.Point(243, 74)
        Me.lblHORA_SISTEMA.Name = "lblHORA_SISTEMA"
        Me.lblHORA_SISTEMA.Size = New System.Drawing.Size(101, 13)
        Me.lblHORA_SISTEMA.TabIndex = 9
        Me.lblHORA_SISTEMA.Text = "lblHORA_SISTEMA"
        '
        'lblRUT_BORRAR
        '
        Me.lblRUT_BORRAR.AutoSize = True
        Me.lblRUT_BORRAR.Location = New System.Drawing.Point(23, 107)
        Me.lblRUT_BORRAR.Name = "lblRUT_BORRAR"
        Me.lblRUT_BORRAR.Size = New System.Drawing.Size(92, 13)
        Me.lblRUT_BORRAR.TabIndex = 10
        Me.lblRUT_BORRAR.Text = "lblRUT_BORRAR"
        '
        'VentanaConfirmacionBorrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(422, 215)
        Me.Controls.Add(Me.tbMensajeAlerta)
        Me.Controls.Add(Me.lblRUT_BORRAR)
        Me.Controls.Add(Me.lblHORA_SISTEMA)
        Me.Controls.Add(Me.lblUSUARIO_CONECTADO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblID_SUCURSAL_BORRAR)
        Me.Controls.Add(Me.btnBorrarTodasLasSucursales)
        Me.Controls.Add(Me.tbConfimacionDeBorrado)
        Me.Controls.Add(Me.lblConfirme)
        Me.Controls.Add(Me.btnBorrarSoloSucursal)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaConfirmacionBorrado"
        Me.Text = "Form1"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents btnBorrarSoloSucursal As System.Windows.Forms.Button
    Friend WithEvents tbMensajeAlerta As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirme As System.Windows.Forms.Label
    Friend WithEvents tbConfimacionDeBorrado As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrarTodasLasSucursales As System.Windows.Forms.Button
    Friend WithEvents lblID_SUCURSAL_BORRAR As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents lblUSUARIO_CONECTADO As System.Windows.Forms.Label
    Friend WithEvents lblHORA_SISTEMA As System.Windows.Forms.Label
    Friend WithEvents lblRUT_BORRAR As System.Windows.Forms.Label
End Class
