<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaReporteInventario
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
        Me.tbInventarioSeleccionadoSeleccionado = New System.Windows.Forms.TextBox()
        Me.lblInventarioSeleccionado = New System.Windows.Forms.Label()
        Me.tbNombreSucursal = New System.Windows.Forms.TextBox()
        Me.lblNombreDeLaSucursal = New System.Windows.Forms.Label()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tbFecha = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanelObjetosInventario = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbInventarioSeleccionadoSeleccionado
        '
        Me.tbInventarioSeleccionadoSeleccionado.BackColor = System.Drawing.Color.White
        Me.tbInventarioSeleccionadoSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbInventarioSeleccionadoSeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbInventarioSeleccionadoSeleccionado.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbInventarioSeleccionadoSeleccionado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInventarioSeleccionadoSeleccionado.Location = New System.Drawing.Point(179, 33)
        Me.tbInventarioSeleccionadoSeleccionado.Name = "tbInventarioSeleccionadoSeleccionado"
        Me.tbInventarioSeleccionadoSeleccionado.ReadOnly = True
        Me.tbInventarioSeleccionadoSeleccionado.ShortcutsEnabled = False
        Me.tbInventarioSeleccionadoSeleccionado.Size = New System.Drawing.Size(630, 24)
        Me.tbInventarioSeleccionadoSeleccionado.TabIndex = 45
        Me.tbInventarioSeleccionadoSeleccionado.TabStop = False
        '
        'lblInventarioSeleccionado
        '
        Me.lblInventarioSeleccionado.AutoSize = True
        Me.lblInventarioSeleccionado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventarioSeleccionado.Location = New System.Drawing.Point(12, 37)
        Me.lblInventarioSeleccionado.Name = "lblInventarioSeleccionado"
        Me.lblInventarioSeleccionado.Size = New System.Drawing.Size(162, 16)
        Me.lblInventarioSeleccionado.TabIndex = 44
        Me.lblInventarioSeleccionado.Text = "Cuestionario Seleccionado"
        '
        'tbNombreSucursal
        '
        Me.tbNombreSucursal.BackColor = System.Drawing.Color.White
        Me.tbNombreSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombreSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNombreSucursal.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNombreSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreSucursal.Location = New System.Drawing.Point(179, 68)
        Me.tbNombreSucursal.Name = "tbNombreSucursal"
        Me.tbNombreSucursal.ReadOnly = True
        Me.tbNombreSucursal.ShortcutsEnabled = False
        Me.tbNombreSucursal.Size = New System.Drawing.Size(587, 24)
        Me.tbNombreSucursal.TabIndex = 43
        Me.tbNombreSucursal.TabStop = False
        '
        'lblNombreDeLaSucursal
        '
        Me.lblNombreDeLaSucursal.AutoSize = True
        Me.lblNombreDeLaSucursal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeLaSucursal.Location = New System.Drawing.Point(31, 72)
        Me.lblNombreDeLaSucursal.Name = "lblNombreDeLaSucursal"
        Me.lblNombreDeLaSucursal.Size = New System.Drawing.Size(142, 16)
        Me.lblNombreDeLaSucursal.TabIndex = 42
        Me.lblNombreDeLaSucursal.Text = "Nombre de la Sucursal"
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSuperior.Controls.Add(Me.pictureClose)
        Me.panelSuperior.Controls.Add(Me.pictureMinimize)
        Me.panelSuperior.Controls.Add(Me.PictureBox1)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(973, 25)
        Me.panelSuperior.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'pictureClose
        '
        Me.pictureClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureClose.Image = Global.SIGPTASK.My.Resources.Resources.cancel
        Me.pictureClose.Location = New System.Drawing.Point(950, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 37
        Me.pictureClose.TabStop = False
        '
        'pictureMinimize
        '
        Me.pictureMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureMinimize.Image = Global.SIGPTASK.My.Resources.Resources.minimize
        Me.pictureMinimize.Location = New System.Drawing.Point(929, 5)
        Me.pictureMinimize.Name = "pictureMinimize"
        Me.pictureMinimize.Size = New System.Drawing.Size(15, 15)
        Me.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureMinimize.TabIndex = 38
        Me.pictureMinimize.TabStop = False
        '
        'tbMatricula
        '
        Me.tbMatricula.BackColor = System.Drawing.Color.White
        Me.tbMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbMatricula.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMatricula.Location = New System.Drawing.Point(846, 68)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.ReadOnly = True
        Me.tbMatricula.ShortcutsEnabled = False
        Me.tbMatricula.Size = New System.Drawing.Size(119, 24)
        Me.tbMatricula.TabIndex = 51
        Me.tbMatricula.TabStop = False
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.Location = New System.Drawing.Point(772, 72)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(69, 16)
        Me.lblMatricula.TabIndex = 50
        Me.lblMatricula.Text = "| Matricula"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(815, 37)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 16)
        Me.lblFecha.TabIndex = 49
        Me.lblFecha.Text = "| Fecha"
        '
        'tbFecha
        '
        Me.tbFecha.BackColor = System.Drawing.Color.White
        Me.tbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFecha.Location = New System.Drawing.Point(866, 33)
        Me.tbFecha.Name = "tbFecha"
        Me.tbFecha.ReadOnly = True
        Me.tbFecha.ShortcutsEnabled = False
        Me.tbFecha.Size = New System.Drawing.Size(99, 24)
        Me.tbFecha.TabIndex = 48
        Me.tbFecha.TabStop = False
        '
        'FlowLayoutPanelObjetosInventario
        '
        Me.FlowLayoutPanelObjetosInventario.Location = New System.Drawing.Point(0, 109)
        Me.FlowLayoutPanelObjetosInventario.Name = "FlowLayoutPanelObjetosInventario"
        Me.FlowLayoutPanelObjetosInventario.Size = New System.Drawing.Size(973, 480)
        Me.FlowLayoutPanelObjetosInventario.TabIndex = 52
        '
        'reporteInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(973, 601)
        Me.Controls.Add(Me.FlowLayoutPanelObjetosInventario)
        Me.Controls.Add(Me.tbMatricula)
        Me.Controls.Add(Me.lblMatricula)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.tbFecha)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.tbInventarioSeleccionadoSeleccionado)
        Me.Controls.Add(Me.lblInventarioSeleccionado)
        Me.Controls.Add(Me.tbNombreSucursal)
        Me.Controls.Add(Me.lblNombreDeLaSucursal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reporteInventario"
        Me.Text = "reporteCuestionario"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbInventarioSeleccionadoSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents lblInventarioSeleccionado As System.Windows.Forms.Label
    Friend WithEvents tbNombreSucursal As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreDeLaSucursal As System.Windows.Forms.Label
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents tbFecha As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanelObjetosInventario As System.Windows.Forms.FlowLayoutPanel
End Class
