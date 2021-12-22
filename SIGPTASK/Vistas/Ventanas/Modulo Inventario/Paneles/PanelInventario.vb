Public Class PanelInventario
    Dim solonumeros As String = ""
    Dim numeroExcedemaximo As String = ""

    Private Sub PAnelInventarioFIla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboEstado.Items.Clear()
        idiomaMesajes()
        comboEstado.SelectedIndex = 0
    End Sub

    Sub idiomaMesajes()
        '///
        If idiomaSeleccionado.Equals("ING") Then
            comboEstado.Items.Add("OBSOLETE")
            comboEstado.Items.Add("BROKEN")
            comboEstado.Items.Add("LIFETIME EXPIRED")
            comboEstado.Items.Add("SPENT")
            comboEstado.Items.Add("BAD")
            comboEstado.Items.Add("NORMAL")
            comboEstado.Items.Add("GOOD")
            comboEstado.Items.Add("EXCELLENT")
        Else
            comboEstado.Items.Add("OBSOLETO")
            comboEstado.Items.Add("ROTO")
            comboEstado.Items.Add("VENCIDO")
            comboEstado.Items.Add("AGOTADO")
            comboEstado.Items.Add("MALO")
            comboEstado.Items.Add("NORMAL")
            comboEstado.Items.Add("BUENO")
            comboEstado.Items.Add("EXCELENTE")
        End If
        '///
        If idiomaSeleccionado.Equals("ING") Then
            lblObjeto.Text = "Objetc"
            lblExistencias.Text = "Stock"
            lblCantidadRequerida.Text = "Quantity Required"
            lblEstado.Text = "State"
            btnBorrar.Text = "Delete"
            '///
        End If
        solonumeros = lenguaje.solonumeros(solonumeros)
        numeroExcedemaximo = lenguaje.numeroExcedemaximo(numeroExcedemaximo)
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Me.Dispose()
    End Sub

    Private Sub tbExistencias_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbExistencias.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                tbExistencias.Text = solonumeros
                tbExistencias.Refresh()
                Threading.Thread.Sleep(80)
                tbExistencias.Clear()
                e.Handled = True
            Else
                If ((Not tbExistencias.Text.Equals("")) AndAlso (Int64.Parse(tbExistencias.Text) > 2147483647)) Then
                    tbExistencias.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    '////
    Private Sub tbCantidadRequerida_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCantidadRequerida.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                tbCantidadRequerida.Text = solonumeros
                tbCantidadRequerida.Refresh()
                Threading.Thread.Sleep(80)
                tbCantidadRequerida.Clear()
                e.Handled = True
            Else
                If ((Not tbCantidadRequerida.Text.Equals("")) AndAlso (Int64.Parse(tbCantidadRequerida.Text) > 2147483647)) Then
                    tbCantidadRequerida.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True
                End If
            End If
        End If
    End Sub
    '////

End Class