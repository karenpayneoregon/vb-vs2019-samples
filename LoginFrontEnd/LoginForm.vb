Imports WindowsApplication1.Enums

Public Class LoginForm
    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        Dim getLoginDetails As AppDataSet.UsersDataTable =
                UsersTableAdapter.GetDataByLogin(txtUserName.Text, txtPassword.Text)

        Dim result As AppDataSet.UsersRow = getLoginDetails.FirstOrDefault()

        If result IsNot Nothing Then
            Hide()
            '
            ' See ApplicationEvents.vb
            '
            My.Application.UserRole = DirectCast([Enum].Parse(GetType(UserRoles), result.UserRole), UserRoles)
            If My.Application.UserRole = UserRoles.Admin Then
                Dim f As New AdminForm()
                f.ShowDialog()
            Else
                Dim f As New UserForm()
                f.ShowDialog()
            End If


        Else
            MessageBox.Show($"Contact an admin")
            Application.ExitThread()
        End If

    End Sub
End Class
