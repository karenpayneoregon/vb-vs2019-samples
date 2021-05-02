

Public Class Form1
    Private Async Sub GetTimeZoneDetailsButton_Click(sender As Object, e As EventArgs) Handles GetTimeZoneDetailsButton.Click

        Dim timeZoneDetails = Await Operations.GetTimeZoneTask()
        DisplayNameTextBox.Text = timeZoneDetails.DaylightName

    End Sub

    Private Async Sub ComputerInfoButton_Click(sender As Object, e As EventArgs) Handles ComputerInfoButton.Click

        Dim details = Await Operations.GetComputerInformationTask()
        PropertyGrid1.SelectedObject = details

    End Sub
End Class