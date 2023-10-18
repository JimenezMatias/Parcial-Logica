Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If textPsw.Text = "izo" And textName1.Text = "izo" Then
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("Usuario y Contraseña incorrectos")

        End If
    End Sub
End Class