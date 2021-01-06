
Public Class LoginForm
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        Dim getLoginDetails As AppDataSet.UsersDataTable = Me.UsersTableAdapter.GetDataByLogin(txtUserName.Text, txtPassword.Text)
        Dim result As AppDataSet.UsersRow = getLoginDetails.FirstOrDefault()

        If result IsNot Nothing Then
            Hide()
            Dim f As New Form1(result.UserRole)
            f.ShowDialog()
        Else
            MessageBox.Show($"Contact an admin")
            Application.ExitThread()
        End If

    End Sub
End Class
