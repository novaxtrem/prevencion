Public Class VentanaInventario

    Dim objeto As New objeto
    Dim varObjetoID As String = ""
    Dim varObjetoNombre As String = ""
    Dim anotacion As String = ""
    Private Sub VentanaInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim regDate As Date = Date.Now()
        Dim fechaCreacion As String = regDate.ToString("dd\/MM\/yyyy")
        tbFecha.Text = fechaCreacion
        idiomaMesajes()
    End Sub

    Private Sub btnInventariar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventariar.Click
        Dim estado As Boolean = False
        Dim id_inventario_ingresado As Integer = 0
        Dim inventario As New Inventario
        inventario.sucursal_id = lblID_sucursal.Text
        inventario.nombreInvetario = tbNombreInventario.Text
        '//FECHA
        Dim formattedDate As String = Date.Today.ToString("MM-dd-yyyy")
        inventario.fecha = formattedDate
        '//
        inventario.empleadoCedula = tbCedulaEmpleado.Text
        inventario.estado = "A"
        inventario.nota = anotacion
        id_inventario_ingresado = AgregoInventario(inventario, id_inventario_ingresado, conn)
        '//////////
        For Each panelInventario As PanelInventario In panelCentralPA.Controls
            Dim filaInventario As New Inventario
            filaInventario.InventarioID = id_inventario_ingresado
            filaInventario.objetoID = panelInventario.lblObjetoID.Text
            filaInventario.existencias = panelInventario.tbExistencias.Text
            filaInventario.cantidadRequerida = panelInventario.tbCantidadRequerida.Text
            '////
            Dim normalizoLaEntradaAEspaniol As String = ""
            normalizoLaEntradaAEspaniol = panelInventario.comboEstado.SelectedItem
            If idiomaSeleccionado.Equals("ING") Then
                Select Case normalizoLaEntradaAEspaniol
                    Case "OBSOLETE"
                        filaInventario.estado = "OBSOLETO"
                    Case "BROKEN"
                        filaInventario.estado = "ROTO"
                    Case "LIFETIME EXPIRED"
                        filaInventario.estado = "VENCIDO"
                    Case "SPENT"
                        filaInventario.estado = "AGOTADO"
                    Case "BAD"
                        filaInventario.estado = "MALO"
                    Case "NORMAL"
                        filaInventario.estado = "NORMAL"
                    Case "GOOD"
                        filaInventario.estado = "BUENO"
                    Case "EXCELLENT"
                        filaInventario.estado = "EXCELENTE"
                End Select
            Else
                filaInventario.estado = panelInventario.comboEstado.SelectedItem
            End If
            '///
            '////
            estado = AgregoObjetosInventario(filaInventario, conn, estado)
        Next
        If estado = True Then
            MessageBox.Show("Inventario Agregado correctamente" & Environment.NewLine & "generando reporte web")
            Me.Dispose()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarObjeto.Click
        refrescoTablaObjetos()
    End Sub

    Sub idiomaMesajes()
        varObjetoID = lenguaje.varObjetoID(varObjetoID)
        varObjetoNombre = lenguaje.varObjetoNombre(varObjetoNombre)
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridView1.Rows(e.RowIndex)
            If selectedRow.Cells(0).Value = Not Equals("") Then
                Dim panelInventario As New PanelInventario
                panelInventario.lblObjetoID.Text = selectedRow.Cells(0).Value.ToString
                panelInventario.tbObjetoSeleccionado.Text = selectedRow.Cells(1).Value.ToString
                panelInventario.TopLevel = False
                panelCentralPA.Controls.Add(panelInventario)
                panelInventario.Show()
                '///
                panelSupoerpuestoInformacion.Hide()
            End If
        End If
    End Sub
    Private Sub btnAgregarNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarNota.Click
        Dim vAgregarNota As New VentanaAgregarNota
        vAgregarNota.tbAnotaciones.Text = anotacion
        If vAgregarNota.ShowDialog() = Windows.Forms.DialogResult.OK Then
            anotacion = vAgregarNota.tbAnotaciones.Text
        End If
    End Sub

    '//MINIMIZAR
    Protected Sub pictureMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '//SOMBRA
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property
    '//MUEVO LA WINDOW
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelSuperior.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '//MUEVO LA WINDOW FIN
    '//CIERRO WINDOW
    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnAgregarObjeto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObjeto.Click
        Dim ventanaAgregoObjeto As New VentanaCargoObjeto
        If ventanaAgregoObjeto.ShowDialog() = Windows.Forms.DialogResult.OK Then
            refrescoTablaObjetos()
        End If

    End Sub

    Private Sub refrescoTablaObjetos()
        DataGridView1.Rows.Clear()
        Dim listaObjetos As New List(Of objeto)
        If tbBuscarObjeto.Text.Equals("") Then
            listaObjetos = ConsultoTodosLosObjetos(listaObjetos, conn)
        Else
            '     listaObjetos = consultoObjetoPoneleQueEspecifico(listaObjetos, conn, tbBuscarObjeto.Text)
        End If
        DataGridView1.ColumnCount = 2
        '////
        DataGridView1.Columns(0).Name = varObjetoID
        DataGridView1.Columns(0).Visible = False
        '////
        DataGridView1.Columns(1).Name = varObjetoNombre
        DataGridView1.Columns(1).Width = 363
        '////
        For Each objeto As objeto In listaObjetos
            Dim row As String() = New String() {objeto.objetoID, objeto.objeto}
            DataGridView1.Rows.Add(row)
        Next
        DataGridView1.ClearSelection()
        DataGridView1.Refresh()
        tbBuscarObjeto.Text = ""
    End Sub

End Class