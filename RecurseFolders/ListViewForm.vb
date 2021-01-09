Imports System.IO
Imports System.Threading
Imports FileHelpers
Imports RecurseFolders.LanguageExtensions

Public Class ListViewForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()
    Private Async Sub TraverseButton_Click(sender As Object, e As EventArgs) Handles TraverseButton.Click
        If String.IsNullOrWhiteSpace(FolderTextBox.Text) Then
            MessageBox.Show("Please select a folder")
            Exit Sub
        End If

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        OperationsListView.Cancelled = False
        Await OperationsListView.RecursiveFolders(New DirectoryInfo(FolderTextBox.Text), _cts.Token)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
    End Sub

    Private Sub ListViewForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        OperationsListView.Cancelled = False
        AddHandler OperationsListView.OnTraverseEvent, AddressOf OnTraverseEvent
    End Sub

    Private Sub OnTraverseEvent(information As DirectoryItem)

        ListView1.InvokeIfRequired(
            Sub(listView)
                listView.Items.Add(New ListViewItem(information.ItemArray))
            End Sub)

    End Sub
End Class