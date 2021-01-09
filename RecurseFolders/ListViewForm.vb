Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports FileHelpers
Imports RecurseFolders.LanguageExtensions

Public Class ListViewForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()
    Private Async Sub TraverseButton_Click(sender As Object, e As EventArgs) Handles TraverseButton.Click
        If ListView1.Items.Count > 0 Then
            ListView1.Items.Clear()
        End If

        Await Task.Delay(100)

        ProcessingLabel.Visible = True
        ProcessedTitleLabel.Visible = True

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

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False

        FocustListView()

    End Sub
    Private Sub FocustListView()
        ListView1.FocusedItem = ListView1.Items(0)
        ListView1.Items(0).Selected = True
        ActiveControl = ListView1
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        _cts.Cancel()
        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False
    End Sub

    Private Sub ListViewForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False

        OperationsListView.Cancelled = False
        AddHandler OperationsListView.OnTraverseEvent, AddressOf OnTraverseEvent
        ListView1.SetDoubleBuffered()
        ContextMenuStrip1.Items.Cast(Of ToolStripItem)().ToList().ForEach(Sub(item) AddHandler item.Click, AddressOf ContextMenuStrip1_Click)

    End Sub

    Private Async Sub OnTraverseEvent(information As DirectoryItem)

        ListView1.InvokeIfRequired(Sub(listView)
                                       listView.Items.Add(New ListViewItem(information.ItemArray))
                                       'listView.FocusedItem = listView.Items(listView.Items.Count - 1)
                                       'listView.Items(listView.Items.Count - 1).Selected = True
                                       'listView.Items(listView.Items.Count - 1).EnsureVisible()



                                   End Sub)

        ProcessingLabel.InvokeIfRequired(Sub(label)
                                             label.Text = $"{ListView1.Items.Count}"
                                         End Sub)
        Await Task.Delay(1)

    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs)
        FolderTextBox.Text = CType(sender, ToolStripMenuItem).Text
    End Sub
End Class