Public Class UserForm
    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = $"User Role: {My.Application.UserRole}"
    End Sub
    Private Sub UserForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.ExitThread()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class