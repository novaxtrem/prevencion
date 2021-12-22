<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaCuestiInvenMapa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaCuestiInvenMapa))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tbNombreDelCoso = New System.Windows.Forms.TextBox()
        Me.lblSeleccionarEmpresa = New System.Windows.Forms.Label()
        Me.tbBuscarEmpresa = New System.Windows.Forms.TextBox()
        Me.lblBuscarEmpresa = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNuevoMapa = New System.Windows.Forms.Button()
        Me.btnNuevoCuestionario = New System.Windows.Forms.Button()
        Me.btnNuevoInventario = New System.Windows.Forms.Button()
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureMinimize = New System.Windows.Forms.PictureBox()
        Me.pictureClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(52, 434)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'tbNombreDelCoso
        '
        Me.tbNombreDelCoso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbNombreDelCoso.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombreDelCoso.Location = New System.Drawing.Point(115, 430)
        Me.tbNombreDelCoso.Name = "tbNombreDelCoso"
        Me.tbNombreDelCoso.ReadOnly = True
        Me.tbNombreDelCoso.Size = New System.Drawing.Size(567, 24)
        Me.tbNombreDelCoso.TabIndex = 4
        '
        'lblSeleccionarEmpresa
        '
        Me.lblSeleccionarEmpresa.AutoSize = True
        Me.lblSeleccionarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarEmpresa.Location = New System.Drawing.Point(12, 65)
        Me.lblSeleccionarEmpresa.Name = "lblSeleccionarEmpresa"
        Me.lblSeleccionarEmpresa.Size = New System.Drawing.Size(129, 16)
        Me.lblSeleccionarEmpresa.TabIndex = 16
        Me.lblSeleccionarEmpresa.Text = "Seleccionar Empresa"
        '
        'tbBuscarEmpresa
        '
        Me.tbBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBuscarEmpresa.Location = New System.Drawing.Point(147, 35)
        Me.tbBuscarEmpresa.Name = "tbBuscarEmpresa"
        Me.tbBuscarEmpresa.Size = New System.Drawing.Size(523, 24)
        Me.tbBuscarEmpresa.TabIndex = 1
        '
        'lblBuscarEmpresa
        '
        Me.lblBuscarEmpresa.AutoSize = True
        Me.lblBuscarEmpresa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEmpresa.Location = New System.Drawing.Point(40, 39)
        Me.lblBuscarEmpresa.Name = "lblBuscarEmpresa"
        Me.lblBuscarEmpresa.Size = New System.Drawing.Size(101, 16)
        Me.lblBuscarEmpresa.TabIndex = 19
        Me.lblBuscarEmpresa.Text = "Buscar Empresa"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(687, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 89)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(801, 334)
        Me.DataGridView1.TabIndex = 3
        '
        'btnNuevoMapa
        '
        Me.btnNuevoMapa.BackColor = System.Drawing.Color.White
        Me.btnNuevoMapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoMapa.Enabled = False
        Me.btnNuevoMapa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNuevoMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnNuevoMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevoMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoMapa.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoMapa.Location = New System.Drawing.Point(497, 5)
        Me.btnNuevoMapa.Name = "btnNuevoMapa"
        Me.btnNuevoMapa.Size = New System.Drawing.Size(185, 30)
        Me.btnNuevoMapa.TabIndex = 7
        Me.btnNuevoMapa.Text = "Nuevo Mapa de Riesgo"
        Me.btnNuevoMapa.UseVisualStyleBackColor = False
        '
        'btnNuevoCuestionario
        '
        Me.btnNuevoCuestionario.BackColor = System.Drawing.Color.White
        Me.btnNuevoCuestionario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoCuestionario.Enabled = False
        Me.btnNuevoCuestionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNuevoCuestionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnNuevoCuestionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevoCuestionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCuestionario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCuestionario.Location = New System.Drawing.Point(115, 5)
        Me.btnNuevoCuestionario.Name = "btnNuevoCuestionario"
        Me.btnNuevoCuestionario.Size = New System.Drawing.Size(185, 30)
        Me.btnNuevoCuestionario.TabIndex = 5
        Me.btnNuevoCuestionario.Text = "Nuevo Cuestionario"
        Me.btnNuevoCuestionario.UseVisualStyleBackColor = False
        '
        'btnNuevoInventario
        '
        Me.btnNuevoInventario.BackColor = System.Drawing.Color.White
        Me.btnNuevoInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevoInventario.Enabled = False
        Me.btnNuevoInventario.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNuevoInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnNuevoInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnNuevoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoInventario.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoInventario.Location = New System.Drawing.Point(306, 5)
        Me.btnNuevoInventario.Name = "btnNuevoInventario"
        Me.btnNuevoInventario.Size = New System.Drawing.Size(185, 30)
        Me.btnNuevoInventario.TabIndex = 6
        Me.btnNuevoInventario.Text = "Nuevo Inventario"
        Me.btnNuevoInventario.UseVisualStyleBackColor = False
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
        Me.panelSuperior.Size = New System.Drawing.Size(801, 25)
        Me.panelSuperior.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIGPTASK.My.Resources.Resources.task_logo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
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
        Me.pictureMinimize.Location = New System.Drawing.Point(753, 5)
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
        Me.pictureClose.Location = New System.Drawing.Point(774, 5)
        Me.pictureClose.Name = "pictureClose"
        Me.pictureClose.Size = New System.Drawing.Size(15, 15)
        Me.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClose.TabIndex = 35
        Me.pictureClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnNuevoMapa)
        Me.Panel1.Controls.Add(Me.btnNuevoInventario)
        Me.Panel1.Controls.Add(Me.btnNuevoCuestionario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 462)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 40)
        Me.Panel1.TabIndex = 27
        '
        'VentanaCuestiInvenMapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 502)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.panelSuperior)
        Me.Controls.Add(Me.tbNombreDelCoso)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbBuscarEmpresa)
        Me.Controls.Add(Me.lblBuscarEmpresa)
        Me.Controls.Add(Me.lblSeleccionarEmpresa)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VentanaCuestiInvenMapa"
        Me.Text = "VenatanaNuevoMapaRiesgo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents tbNombreDelCoso As System.Windows.Forms.TextBox
    Friend WithEvents lblSeleccionarEmpresa As System.Windows.Forms.Label
    Friend WithEvents tbBuscarEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscarEmpresa As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnNuevoMapa As System.Windows.Forms.Button
    Friend WithEvents btnNuevoCuestionario As System.Windows.Forms.Button
    Friend WithEvents btnNuevoInventario As System.Windows.Forms.Button
    Friend WithEvents panelSuperior As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pictureMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents pictureClose As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
