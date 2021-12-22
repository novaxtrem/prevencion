<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelInventario))
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.tbExistencias = New System.Windows.Forms.TextBox()
        Me.tbCantidadRequerida = New System.Windows.Forms.TextBox()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.lblCantidadRequerida = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.comboEstado = New System.Windows.Forms.ComboBox()
        Me.tbObjetoSeleccionado = New System.Windows.Forms.TextBox()
        Me.lblObjetoID = New System.Windows.Forms.Label()
        Me.lblObjeto = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(753, 23)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(80, 30)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'tbExistencias
        '
        Me.tbExistencias.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExistencias.Location = New System.Drawing.Point(328, 27)
        Me.tbExistencias.Name = "tbExistencias"
        Me.tbExistencias.ShortcutsEnabled = False
        Me.tbExistencias.Size = New System.Drawing.Size(110, 24)
        Me.tbExistencias.TabIndex = 4
        '
        'tbCantidadRequerida
        '
        Me.tbCantidadRequerida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCantidadRequerida.Location = New System.Drawing.Point(457, 27)
        Me.tbCantidadRequerida.Name = "tbCantidadRequerida"
        Me.tbCantidadRequerida.ShortcutsEnabled = False
        Me.tbCantidadRequerida.Size = New System.Drawing.Size(110, 24)
        Me.tbCantidadRequerida.TabIndex = 5
        '
        'lblExistencias
        '
        Me.lblExistencias.AutoSize = True
        Me.lblExistencias.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencias.Location = New System.Drawing.Point(348, 7)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(70, 16)
        Me.lblExistencias.TabIndex = 6
        Me.lblExistencias.Text = "Existencias"
        '
        'lblCantidadRequerida
        '
        Me.lblCantidadRequerida.AutoSize = True
        Me.lblCantidadRequerida.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadRequerida.Location = New System.Drawing.Point(450, 6)
        Me.lblCantidadRequerida.Name = "lblCantidadRequerida"
        Me.lblCantidadRequerida.Size = New System.Drawing.Size(124, 16)
        Me.lblCantidadRequerida.TabIndex = 7
        Me.lblCantidadRequerida.Text = "Cantidad Requerida"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(636, 7)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 16)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "Estado"
        '
        'comboEstado
        '
        Me.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboEstado.FormattingEnabled = True
        Me.comboEstado.Items.AddRange(New Object() {"ROTO", "AGOTADO", "MALO", "BUENO", "VENCIDO", "EXCELENTE"})
        Me.comboEstado.Location = New System.Drawing.Point(580, 27)
        Me.comboEstado.Name = "comboEstado"
        Me.comboEstado.Size = New System.Drawing.Size(160, 24)
        Me.comboEstado.TabIndex = 9
        '
        'tbObjetoSeleccionado
        '
        Me.tbObjetoSeleccionado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObjetoSeleccionado.Location = New System.Drawing.Point(13, 27)
        Me.tbObjetoSeleccionado.Name = "tbObjetoSeleccionado"
        Me.tbObjetoSeleccionado.ReadOnly = True
        Me.tbObjetoSeleccionado.Size = New System.Drawing.Size(305, 24)
        Me.tbObjetoSeleccionado.TabIndex = 10
        '
        'lblObjetoID
        '
        Me.lblObjetoID.AutoSize = True
        Me.lblObjetoID.Location = New System.Drawing.Point(111, 9)
        Me.lblObjetoID.Name = "lblObjetoID"
        Me.lblObjetoID.Size = New System.Drawing.Size(59, 13)
        Me.lblObjetoID.TabIndex = 11
        Me.lblObjetoID.Text = "lblObjetoID"
        Me.lblObjetoID.Visible = False
        '
        'lblObjeto
        '
        Me.lblObjeto.AutoSize = True
        Me.lblObjeto.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjeto.Location = New System.Drawing.Point(13, 7)
        Me.lblObjeto.Name = "lblObjeto"
        Me.lblObjeto.Size = New System.Drawing.Size(48, 16)
        Me.lblObjeto.TabIndex = 12
        Me.lblObjeto.Text = "Objeto"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(845, 66)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 827
        Me.LineShape1.Y1 = 60
        Me.LineShape1.Y2 = 60
        '
        'PanelInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 66)
        Me.Controls.Add(Me.lblObjeto)
        Me.Controls.Add(Me.lblObjetoID)
        Me.Controls.Add(Me.tbObjetoSeleccionado)
        Me.Controls.Add(Me.comboEstado)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblCantidadRequerida)
        Me.Controls.Add(Me.lblExistencias)
        Me.Controls.Add(Me.tbCantidadRequerida)
        Me.Controls.Add(Me.tbExistencias)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PanelInventario"
        Me.Text = "PAnelInventarioFIla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents tbExistencias As System.Windows.Forms.TextBox
    Friend WithEvents tbCantidadRequerida As System.Windows.Forms.TextBox
    Friend WithEvents lblExistencias As System.Windows.Forms.Label
    Friend WithEvents lblCantidadRequerida As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents comboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents tbObjetoSeleccionado As System.Windows.Forms.TextBox
    Friend WithEvents lblObjetoID As System.Windows.Forms.Label
    Friend WithEvents lblObjeto As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
