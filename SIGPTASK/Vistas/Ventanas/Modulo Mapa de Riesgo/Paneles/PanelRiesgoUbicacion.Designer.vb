<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelRiesgoUbicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelRiesgoUbicacion))
        Me.pictureRiesgoElegido = New System.Windows.Forms.PictureBox()
        Me.lblIDRiesgo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.tbDescripcionRiesgo = New System.Windows.Forms.TextBox()
        Me.lblSolucion = New System.Windows.Forms.Label()
        Me.tbSolucionRiesgo = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.DateFechaResuelto = New System.Windows.Forms.DateTimePicker()
        Me.lblContadorCaracteresDescripcion = New System.Windows.Forms.Label()
        Me.lblContadorCaracteresSolucion = New System.Windows.Forms.Label()
        Me.lblResueltoPara = New System.Windows.Forms.Label()
        Me.lblNombreUbicacion = New System.Windows.Forms.Label()
        Me.tbNombreUbicacion = New System.Windows.Forms.TextBox()
        Me.ckbCritico = New System.Windows.Forms.CheckBox()
        Me.lblcoordenadaX = New System.Windows.Forms.Label()
        Me.lblcoordenadaY = New System.Windows.Forms.Label()
        Me.tbNombreRiesgo = New System.Windows.Forms.TextBox()
        Me.lblCumplidoEnFecha = New System.Windows.Forms.Label()
        CType(Me.pictureRiesgoElegido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureRiesgoElegido
        '
        Me.pictureRiesgoElegido.Location = New System.Drawing.Point(1, 0)
        Me.pictureRiesgoElegido.Name = "pictureRiesgoElegido"
        Me.pictureRiesgoElegido.Size = New System.Drawing.Size(82, 85)
        Me.pictureRiesgoElegido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureRiesgoElegido.TabIndex = 0
        Me.pictureRiesgoElegido.TabStop = False
        '
        'lblIDRiesgo
        '
        Me.lblIDRiesgo.AutoSize = True
        Me.lblIDRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDRiesgo.Location = New System.Drawing.Point(243, 142)
        Me.lblIDRiesgo.Name = "lblIDRiesgo"
        Me.lblIDRiesgo.Size = New System.Drawing.Size(74, 16)
        Me.lblIDRiesgo.TabIndex = 1
        Me.lblIDRiesgo.Text = "lblIDRiesgo"
        Me.lblIDRiesgo.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(6, 154)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 16)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripcion"
        '
        'tbDescripcionRiesgo
        '
        Me.tbDescripcionRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescripcionRiesgo.Location = New System.Drawing.Point(4, 173)
        Me.tbDescripcionRiesgo.Multiline = True
        Me.tbDescripcionRiesgo.Name = "tbDescripcionRiesgo"
        Me.tbDescripcionRiesgo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescripcionRiesgo.Size = New System.Drawing.Size(313, 45)
        Me.tbDescripcionRiesgo.TabIndex = 5
        '
        'lblSolucion
        '
        Me.lblSolucion.AutoSize = True
        Me.lblSolucion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolucion.Location = New System.Drawing.Point(6, 250)
        Me.lblSolucion.Name = "lblSolucion"
        Me.lblSolucion.Size = New System.Drawing.Size(57, 16)
        Me.lblSolucion.TabIndex = 6
        Me.lblSolucion.Text = "Solucion"
        '
        'tbSolucionRiesgo
        '
        Me.tbSolucionRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSolucionRiesgo.Location = New System.Drawing.Point(4, 269)
        Me.tbSolucionRiesgo.Multiline = True
        Me.tbSolucionRiesgo.Name = "tbSolucionRiesgo"
        Me.tbSolucionRiesgo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSolucionRiesgo.Size = New System.Drawing.Size(313, 45)
        Me.tbSolucionRiesgo.TabIndex = 7
        '
        'btnBorrar
        '
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(243, 336)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 40)
        Me.btnBorrar.TabIndex = 9
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'DateFechaResuelto
        '
        Me.DateFechaResuelto.CalendarTitleBackColor = System.Drawing.Color.Orange
        Me.DateFechaResuelto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaResuelto.Location = New System.Drawing.Point(98, 344)
        Me.DateFechaResuelto.MinDate = New Date(2010, 1, 31, 0, 0, 0, 0)
        Me.DateFechaResuelto.Name = "DateFechaResuelto"
        Me.DateFechaResuelto.Size = New System.Drawing.Size(130, 24)
        Me.DateFechaResuelto.TabIndex = 11
        Me.DateFechaResuelto.Value = New Date(2019, 10, 10, 0, 0, 0, 0)
        '
        'lblContadorCaracteresDescripcion
        '
        Me.lblContadorCaracteresDescripcion.AutoSize = True
        Me.lblContadorCaracteresDescripcion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorCaracteresDescripcion.Location = New System.Drawing.Point(6, 221)
        Me.lblContadorCaracteresDescripcion.Name = "lblContadorCaracteresDescripcion"
        Me.lblContadorCaracteresDescripcion.Size = New System.Drawing.Size(201, 16)
        Me.lblContadorCaracteresDescripcion.TabIndex = 12
        Me.lblContadorCaracteresDescripcion.Text = "Contador Caracteres Descripcion"
        '
        'lblContadorCaracteresSolucion
        '
        Me.lblContadorCaracteresSolucion.AutoSize = True
        Me.lblContadorCaracteresSolucion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorCaracteresSolucion.Location = New System.Drawing.Point(6, 317)
        Me.lblContadorCaracteresSolucion.Name = "lblContadorCaracteresSolucion"
        Me.lblContadorCaracteresSolucion.Size = New System.Drawing.Size(182, 16)
        Me.lblContadorCaracteresSolucion.TabIndex = 13
        Me.lblContadorCaracteresSolucion.Text = "Contador Caracteres Solucion"
        '
        'lblResueltoPara
        '
        Me.lblResueltoPara.AutoSize = True
        Me.lblResueltoPara.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResueltoPara.Location = New System.Drawing.Point(6, 348)
        Me.lblResueltoPara.Name = "lblResueltoPara"
        Me.lblResueltoPara.Size = New System.Drawing.Size(89, 16)
        Me.lblResueltoPara.TabIndex = 14
        Me.lblResueltoPara.Text = "Resuelto para"
        '
        'lblNombreUbicacion
        '
        Me.lblNombreUbicacion.AutoSize = True
        Me.lblNombreUbicacion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUbicacion.Location = New System.Drawing.Point(6, 96)
        Me.lblNombreUbicacion.Name = "lblNombreUbicacion"
        Me.lblNombreUbicacion.Size = New System.Drawing.Size(118, 16)
        Me.lblNombreUbicacion.TabIndex = 15
        Me.lblNombreUbicacion.Text = "Nombre Ubicacion"
        '
        'tbNombreUbicacion
        '
        Me.tbNombreUbicacion.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreUbicacion.Location = New System.Drawing.Point(4, 115)
        Me.tbNombreUbicacion.Name = "tbNombreUbicacion"
        Me.tbNombreUbicacion.Size = New System.Drawing.Size(313, 24)
        Me.tbNombreUbicacion.TabIndex = 16
        '
        'ckbCritico
        '
        Me.ckbCritico.AutoSize = True
        Me.ckbCritico.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbCritico.Location = New System.Drawing.Point(89, 65)
        Me.ckbCritico.Name = "ckbCritico"
        Me.ckbCritico.Size = New System.Drawing.Size(64, 20)
        Me.ckbCritico.TabIndex = 17
        Me.ckbCritico.Text = "Critico"
        Me.ckbCritico.UseVisualStyleBackColor = True
        '
        'lblcoordenadaX
        '
        Me.lblcoordenadaX.AutoSize = True
        Me.lblcoordenadaX.Location = New System.Drawing.Point(234, 9)
        Me.lblcoordenadaX.Name = "lblcoordenadaX"
        Me.lblcoordenadaX.Size = New System.Drawing.Size(81, 13)
        Me.lblcoordenadaX.TabIndex = 18
        Me.lblcoordenadaX.Text = "lblcoordenadaX"
        Me.lblcoordenadaX.Visible = False
        '
        'lblcoordenadaY
        '
        Me.lblcoordenadaY.AutoSize = True
        Me.lblcoordenadaY.Location = New System.Drawing.Point(234, 35)
        Me.lblcoordenadaY.Name = "lblcoordenadaY"
        Me.lblcoordenadaY.Size = New System.Drawing.Size(81, 13)
        Me.lblcoordenadaY.TabIndex = 19
        Me.lblcoordenadaY.Text = "lblcoordenadaY"
        Me.lblcoordenadaY.Visible = False
        '
        'tbNombreRiesgo
        '
        Me.tbNombreRiesgo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbNombreRiesgo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbNombreRiesgo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreRiesgo.Location = New System.Drawing.Point(89, 6)
        Me.tbNombreRiesgo.Multiline = True
        Me.tbNombreRiesgo.Name = "tbNombreRiesgo"
        Me.tbNombreRiesgo.ReadOnly = True
        Me.tbNombreRiesgo.Size = New System.Drawing.Size(139, 58)
        Me.tbNombreRiesgo.TabIndex = 20
        '
        'lblCumplidoEnFecha
        '
        Me.lblCumplidoEnFecha.AutoSize = True
        Me.lblCumplidoEnFecha.Location = New System.Drawing.Point(212, 65)
        Me.lblCumplidoEnFecha.Name = "lblCumplidoEnFecha"
        Me.lblCumplidoEnFecha.Size = New System.Drawing.Size(103, 13)
        Me.lblCumplidoEnFecha.TabIndex = 21
        Me.lblCumplidoEnFecha.Text = "lblCumplidoEnFecha"
        Me.lblCumplidoEnFecha.Visible = False
        '
        'PanelRiesgoUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(321, 381)
        Me.Controls.Add(Me.lblCumplidoEnFecha)
        Me.Controls.Add(Me.tbNombreRiesgo)
        Me.Controls.Add(Me.lblcoordenadaY)
        Me.Controls.Add(Me.lblcoordenadaX)
        Me.Controls.Add(Me.ckbCritico)
        Me.Controls.Add(Me.tbNombreUbicacion)
        Me.Controls.Add(Me.lblNombreUbicacion)
        Me.Controls.Add(Me.lblResueltoPara)
        Me.Controls.Add(Me.lblContadorCaracteresSolucion)
        Me.Controls.Add(Me.lblContadorCaracteresDescripcion)
        Me.Controls.Add(Me.DateFechaResuelto)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.tbSolucionRiesgo)
        Me.Controls.Add(Me.lblSolucion)
        Me.Controls.Add(Me.tbDescripcionRiesgo)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblIDRiesgo)
        Me.Controls.Add(Me.pictureRiesgoElegido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PanelRiesgoUbicacion"
        Me.Text = "PanelRiesgoAgregadoEnUbicacion"
        CType(Me.pictureRiesgoElegido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictureRiesgoElegido As System.Windows.Forms.PictureBox
    Friend WithEvents lblIDRiesgo As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents tbDescripcionRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents lblSolucion As System.Windows.Forms.Label
    Friend WithEvents tbSolucionRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents DateFechaResuelto As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblContadorCaracteresDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblContadorCaracteresSolucion As System.Windows.Forms.Label
    Friend WithEvents lblResueltoPara As System.Windows.Forms.Label
    Friend WithEvents lblNombreUbicacion As System.Windows.Forms.Label
    Friend WithEvents tbNombreUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents ckbCritico As System.Windows.Forms.CheckBox
    Friend WithEvents lblcoordenadaX As System.Windows.Forms.Label
    Friend WithEvents lblcoordenadaY As System.Windows.Forms.Label
    Friend WithEvents tbNombreRiesgo As System.Windows.Forms.TextBox
    Friend WithEvents lblCumplidoEnFecha As System.Windows.Forms.Label
End Class
