Public Class frmCambio
    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        If IsNumeric(textPesos.Text) AndAlso IsNumeric(textCotizacion.Text) Then
            Dim rutaTxt As String = "C:\Users\usuario\Desktop\Examen Parcial Jimenez\Parcial Logica Jimenez\Historial.txt"
            textDolaresFinal.Text = textPesos.Text / textCotizacion.Text
            My.Computer.FileSystem.WriteAllText(rutaTxt, textDolaresFinal.Text & vbLf, True)
        Else
            MsgBox("Ingresar Valores Numericos")
        End If
    End Sub
End Class