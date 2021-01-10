Imports System.IO

Public Class BasicsForm
    ''' <summary>
    ''' Works great for smaller folders but for larger will
    ''' cause the application user interface to become unresponsive
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetFilesConventionalButton_Click(sender As Object, e As EventArgs) _
        Handles GetFilesConventionalButton.Click

        Dim folderName = "C:\OED\Dotnetland\VS2019"
        Dim files() As String = Directory.GetFiles(folderName, "*.vb", SearchOption.AllDirectories)
        MessageBox.Show($"Found {files.Length} files")

    End Sub

    Private Async Sub GetFilesConventionalTaskButton_Click(sender As Object, e As EventArgs) _
        Handles GetFilesConventionalTaskButton.Click

        Dim folderName = "C:\OED\Dotnetland\VS2019"

        Dim foundCount = Await Task.Run(
            Function()
                Dim files() As String = Directory.GetFiles(folderName, "*.vb", SearchOption.AllDirectories)
                Return files.Length
            End Function)

        MessageBox.Show($"Found {foundCount} files")

    End Sub

    Private Async Sub CrossThreadViolationButton_Click(sender As Object, e As EventArgs) _
        Handles CrossThreadViolationButton.Click

        Dim folderName = "C:\OED\Dotnetland\VS2019"

        Await Task.Run(
            Sub()

                Dim files() As String = Directory.GetFiles(folderName, "*.vb", SearchOption.AllDirectories)

                For Each file As String In files
                    ListBox1.Items.Add(file)
                Next
            End Sub)

    End Sub

    Private Async Sub CrossThreadFixButton_Click(sender As Object, e As EventArgs) _
        Handles CrossThreadFixButton.Click

        Dim folderName = "C:\OED\Dotnetland\VS2019"

        Await Task.Run(
            Sub()

                Dim files() As String = Directory.GetFiles(folderName, "*.vb", SearchOption.AllDirectories)

                For Each file As String In files

                    ListBox1.Invoke(
                        Sub()
                            ListBox1.Items.Add(file)
                        End Sub)
                Next
            End Sub)

    End Sub
End Class