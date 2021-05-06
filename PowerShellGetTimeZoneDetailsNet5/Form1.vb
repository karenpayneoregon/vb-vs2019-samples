
Imports System.Threading
Imports PowerShellGetTimeZoneDetailsNet5.Classes

Public Class Form1
    Private Async Sub GetTimeZoneDetailsButton_Click(sender As Object, e As EventArgs) Handles GetTimeZoneDetailsButton.Click

        Dim cancellationTokenSource As New CancellationTokenSource(TimeSpan.FromSeconds(2))

        TimeLabel.Text = ""

        Dim timeZoneDetails = Await Operations.GetTimeZoneTask(cancellationTokenSource)
        DisplayNameTextBox.Text = timeZoneDetails.DaylightName

    End Sub

    Private Async Sub ComputerInfoButton_Click(sender As Object, e As EventArgs) Handles ComputerInfoButton.Click

        TimeLabel.Text = ""

        If PropertyGrid1.SelectedObject IsNot Nothing Then
            PropertyGrid1.SelectedObject = Nothing
        End If

        Dim cancellationTokenSource As New CancellationTokenSource(TimeSpan.FromSeconds(2))

        Dim details = Await Operations.GetComputerInformationTask(cancellationTokenSource)

        PropertyGrid1.SelectedObject = details
        PropertyGrid1.CollapseAllGridItems()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler Operations.FinishedEvent, AddressOf FinishedOperation
    End Sub

    Private Sub FinishedOperation(timespent As String)
        TimeLabel.Text = timespent
    End Sub

    Private Sub StartTimerButton_Click(sender As Object, e As EventArgs) Handles StartTimerButton.Click
        StopWatcher.Instance.Start()
    End Sub

    Private Sub StopTimerButton_Click(sender As Object, e As EventArgs) Handles StopTimerButton.Click
        TimeLabel.Text = StopWatcher.Instance.ElapsedFormatted
    End Sub
End Class