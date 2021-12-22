Public Class VentanaElijoRiesgo
    Dim varRiesgoID As String = ""
    Dim varRiesgo As String = ""
    Dim varRiesgoIcono As String = ""
   
    Protected _ID_Riesgo As String = ""
    Protected _nombre_Riesgo As String = ""
    Protected _icono_Riesgo As String = ""

    Overloads Function ShowDialog(ByVal id_riesgo As String, ByVal nombre_riesgo As String, ByVal icono_riesgo As String)
        Me.ShowDialog()
        id_riesgo = _ID_Riesgo.ToString
        nombre_riesgo = _nombre_Riesgo.ToString
        icono_riesgo = _icono_Riesgo.ToString
        Return (id_riesgo & "¿" & nombre_riesgo & "¿" & icono_riesgo)
    End Function

    Private Sub refrescoTablaRiesgos()
        DataGridRiesgos.Rows.Clear()
        Dim listaRiesgos As New List(Of Riesgo)
        listaRiesgos = ConsultoTodosLosRiesgos(listaRiesgos, conn)
        DataGridRiesgos.ColumnCount = 3
        '////
        DataGridRiesgos.Columns(0).Name = varRiesgoID
        DataGridRiesgos.Columns(0).Visible = False
        '////
        DataGridRiesgos.Columns(1).Name = varRiesgo
        DataGridRiesgos.Columns(1).Width = 230
        '////
        DataGridRiesgos.Columns(2).Name = varRiesgoIcono
        DataGridRiesgos.Columns(2).Visible = False
        '////
        Dim columnaImagen As New DataGridViewImageColumn
        columnaImagen.HeaderText = "coso"
        columnaImagen.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridRiesgos.Columns.Add(columnaImagen)
        '////
        For Each riesgo As Riesgo In listaRiesgos
            Dim pseudoRow As Object() = New Object() {riesgo.riesgoID, riesgo.nombreRiesgo, riesgo.iconoRiesgo, Image.FromFile(riesgo.iconoRiesgo)}
            DataGridRiesgos.Rows.Add(pseudoRow)
        Next
        DataGridRiesgos.ClearSelection()
        DataGridRiesgos.Refresh()
    End Sub

    Private Sub DataGridRiesgos_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridRiesgos.CellMouseClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = DataGridRiesgos.Rows(e.RowIndex)
            If selectedRow.Cells(0).Value = Not Equals("") Then
                _ID_Riesgo = selectedRow.Cells(0).Value.ToString
                _nombre_Riesgo = selectedRow.Cells(1).Value.ToString
                _icono_Riesgo = selectedRow.Cells(2).Value.ToString
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Dispose()
            End If
        End If
    End Sub


    Private Sub pictureClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
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


    Private Sub VentanaElijoRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refrescoTablaRiesgos()
        Me.CenterToParent()
    End Sub

    Private Sub tbnNuevoRiesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnNuevoRiesgo.Click
        Dim vetanaNuevoRiesgo As New VentanaCargarRiesgo
        vetanaNuevoRiesgo.ShowDialog()
        If vetanaNuevoRiesgo.DialogResult = Windows.Forms.DialogResult.OK Then
            refrescoTablaRiesgos()
        End If
    End Sub
End Class