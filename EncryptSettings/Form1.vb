

Public Class Form1
    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click
        My.Settings.UserName = Modules.EncryptString(Modules.ToSecureString("payne"))
        My.Settings.UserPassword = Modules.EncryptString(Modules.ToSecureString("@123Xder"))

        TextBox1.Text = My.Settings.UserName
    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        TextBox2.Text = Modules.ToInsecureString(Modules.DecryptString(My.Settings.UserName))
    End Sub
    ''' <summary>
    ''' Simple example
    ''' 1. Create json file with encrypted user name and password
    ''' 2. Read back the the json file and confirm the decryption works
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JsonOperations.CreateStructure()
        Dim userDetails = JsonOperations.Read()

        Console.WriteLine($"{userDetails.UserName}, {userDetails.UserPassword}, {userDetails.UseDefaultCredentials}")
    End Sub
End Class
