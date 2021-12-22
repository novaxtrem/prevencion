Public Class CalculosMetricos

    Private Sub CalculosMetricos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim variable As Int16 = 200
        Dim escala As Int32 = 100 * tbTotalPreguntasRealizadas.Text
        barGradoPeligrosidad.Maximum = escala

        lblExtremo.Text = escala
        lblMedio.Text = escala / 2
        lblBajo.Text = escala / 4
        lblAlto.Text = (escala / 4) * 3

        If variable < 250 Then
            barGradoPeligrosidad.Value = variable
        ElseIf variable > 250 Then
            barGradoPeligrosidad.ForeColor = Color.YellowGreen
        End If

        For value As Integer = 0 To tbTotalPreguntasRealizadas.Text

        Next


    End Sub

End Class