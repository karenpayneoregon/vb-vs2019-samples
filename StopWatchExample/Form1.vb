Public Class Form1
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StopWatcher.Instance.Start()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StopWatcher.Instance.Stop()
        ListBox1.Items.Add(StopWatcher.Instance.ElapsedFormatted("Whatever"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StopWatcher.Instance.Log = True
    End Sub
End Class
