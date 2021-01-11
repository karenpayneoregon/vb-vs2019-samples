Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports FileHelpers
Imports RecurseFolders.Classes
Imports RecurseFolders.LanguageExtensions

Public Class ListViewForm
    ''' <summary>
    ''' Provides an opportunity to cancel traversal of folders
    ''' </summary>
    Private _cts As New CancellationTokenSource()
    Private Async Sub TraverseButton_Click(sender As Object, e As EventArgs) Handles TraverseButton.Click

        If FoldersListView.Items.Count > 0 Then
            FoldersListView.Items.Clear()
        End If

        Await Task.Delay(1)


        If String.IsNullOrWhiteSpace(FolderTextBox.Text) Then
            MessageBox.Show("Please select a folder")
            Exit Sub
        End If

        If Not Directory.Exists(FolderTextBox.Text) Then
            MessageBox.Show($"{FolderTextBox.Text} folder does not exist")
            Exit Sub
        End If

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        OperationsListView.SearchText = SearchTokenTextBox.Text

        ProcessingLabel.Visible = True
        ProcessedTitleLabel.Visible = True

        OperationsListView.Cancelled = False

        Await OperationsListView.RecursiveFolders(New DirectoryInfo(FolderTextBox.Text), _cts.Token)

        FoldersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False

        FocusListView()

        If String.IsNullOrWhiteSpace(OperationsListView.SearchText) Then
            Exit Sub
        End If

        If OperationsListView.FoundFileList.Count = 0 Then
            MessageBox.Show("Nothing to show")
        Else
            Dim resultForm = New FoundFileResultsForm
            resultForm.FoundFileList = OperationsListView.FoundFileList

            Try
                resultForm.ShowDialog()
            Finally
                resultForm.Dispose()
            End Try
        End If
    End Sub
    Private Sub FocusListView()
        FoldersListView.FocusedItem = FoldersListView.Items(0)
        FoldersListView.Items(0).Selected = True
        ActiveControl = FoldersListView
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        CancelOperation()
    End Sub

    Private Sub CancelOperation()
        _cts.Cancel()
        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False
    End Sub

    Private Sub ListViewForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ProcessingLabel.Visible = False
        ProcessedTitleLabel.Visible = False

        OperationsListView.Cancelled = False
        AddHandler OperationsListView.OnTraverseEvent, AddressOf OnTraverseEvent
        FoldersListView.SetDoubleBuffered()
        FolderSelectionContextMenuStrip.Items.Cast(Of ToolStripItem)().ToList().ForEach(Sub(item) AddHandler item.Click, AddressOf ContextMenuStrip1_Click)
        SetCueText(FolderTextBox, "Right click for selections")
    End Sub

    Private Async Sub OnTraverseEvent(information As DirectoryItem)

        Await Task.Delay(100)

        FoldersListView.InvokeIfRequired(Sub(listView)
                                             listView.Items.Add(New ListViewItem(information.ItemArray))
                                         End Sub)

        ProcessingLabel.InvokeIfRequired(Sub(label)
                                             label.Text = $"{FoldersListView.Items.Count}"
                                         End Sub)


    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs)

        Dim selection = CType(sender, ToolStripMenuItem).Text

        If selection = "Documents" Then
            FolderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Else
            FolderTextBox.Text = selection
        End If

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData <> Keys.Escape Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        CancelOperation()

        Return True

    End Function
    ''' <summary>
    ''' No folders, stop context menu from opening
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenFolderContextMenuStrip_Opening(sender As Object, e As ComponentModel.CancelEventArgs) _
        Handles OpenFolderContextMenuStrip.Opening

        If FoldersListView.Items.Count = 0 Then
            e.Cancel = True
        Else
            '
            ' Get selected
            '
        End If
    End Sub
End Class