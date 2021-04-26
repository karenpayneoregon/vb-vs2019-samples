

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim item As New AppSettings With {
                .Assigned = "Jim",
                .Description = "TODO",
                .Priority = Priority.Low,
                .Question = False,
                .Names = "Karen"}

        PropertyGrid1.SelectedObject = item
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        Dim currentValues = CType(PropertyGrid1.SelectedObject, AppSettings)
        Console.WriteLine()
    End Sub
End Class