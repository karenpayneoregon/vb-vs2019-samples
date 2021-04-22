

Public Class Form1
    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click
        My.Settings.UserName = Modules.EncryptString(Modules.ToSecureString("payne"))
        My.Settings.UserPassword = Modules.EncryptString(Modules.ToSecureString("@123Xder"))

        TextBox1.Text = My.Settings.UserName
    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        TextBox2.Text = Modules.ToInsecureString(Modules.DecryptString(My.Settings.UserName))
    End Sub
End Class
