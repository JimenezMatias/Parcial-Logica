Public Class frmLotes
    Private Sub btnCalcularLotes_Click(sender As Object, e As EventArgs) Handles btnCalcularLotes.Click
        If IsNumeric(textLargo.Text) AndAlso IsNumeric(textAncho.Text) Then
            textLotesFinal.Text = CDec(textLargo.Text) * CDec(textAncho.Text)
        Else
            MsgBox("Ingresar valores numericos.")
        End If
    End Sub
End Class