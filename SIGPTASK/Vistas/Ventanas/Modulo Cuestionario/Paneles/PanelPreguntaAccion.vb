Imports System.Threading

Public Class PanelPreguntaAccion
    Dim noAdmitido As String = ""
    Dim ayudaProbabilidad As String = ""
    Dim solonumeros As String = ""
    Dim numeroExcedemaximo As String = ""

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Me.Dispose()
    End Sub

    Private Sub PanelPreguntaAccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False
        idiomaMesajes()
        rdbSI.Checked = True
        tbPersonasExpuestas.Text = 0
        Me.CenterToParent()
    End Sub

    Sub idiomaMesajes()
        If idiomaSeleccionado.Equals("ING") Then
            ayudaProbabilidad = "Probability level, lower is beter"
            '///
        Else
            ayudaProbabilidad = "nivel de provavilidad, niveles mas bajos son mejores"
        End If
        noAdmitido = lenguaje.noAdmitido(noAdmitido)
        solonumeros = lenguaje.solonumeros(solonumeros)
        numeroExcedemaximo = lenguaje.numeroExcedemaximo(numeroExcedemaximo)
    End Sub


    Private Sub tbPersonasExpuestas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbPersonasExpuestas.KeyPress
        Dim numero As Double = 0
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                tbPersonasExpuestas.Text = solonumeros
                tbPersonasExpuestas.Refresh()
                Threading.Thread.Sleep(80)
                tbPersonasExpuestas.Clear()
                e.Handled = True
            Else
                If ((Not tbPersonasExpuestas.Text.Equals("")) AndAlso (Int64.Parse(tbPersonasExpuestas.Text) > 2147483647)) Then
                    tbPersonasExpuestas.Text = ""
                    MessageBox.Show(numeroExcedemaximo)
                    e.Handled = True

                ElseIf Double.TryParse(tbPersonasExpuestas.Text, numero) > totalEmpleadosSucursal Then
                    MessageBox.Show(noPuedeHaberMasExpuestosQueEmpleados)
                    tbPersonasExpuestas.Refresh()
                    tbPersonasExpuestas.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub rdbSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSI.CheckedChanged
        Me.trackbarConsecuencia.Enabled = False
        Me.trackBarExpocision.Enabled = False
        Me.trackbarProbabilidad.Enabled = False
        Me.tbPersonasExpuestas.Enabled = False
        Me.tbPersonasExpuestas.Text = ""
    End Sub

    Private Sub rdbNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbNO.CheckedChanged
        If Me.lblRiesgoMuerte.Text.Equals("S") Then
            Me.trackbarConsecuencia.Enabled = False
        Else
            Me.trackbarConsecuencia.Enabled = True
        End If

        Me.trackBarExpocision.Enabled = True
        Me.trackbarProbabilidad.Enabled = True
        Me.tbPersonasExpuestas.Enabled = True
    End Sub

End Class