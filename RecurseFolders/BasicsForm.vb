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

    Private Sub IntermediateGetFilesButton_Click(sender As Object, e As EventArgs) Handles IntermediateGetFilesButton.Click

        Dim folderName = "C:\OED\Dotnetland\VS2019"

        For Each file In TraverseDirectory(folderName, Function(fileInfo) fileInfo.Extension = ".png")
            Debug.WriteLine(file.FullName)
        Next

        Debug.WriteLine("Done.")

    End Sub

    Private Shared Iterator Function TraverseDirectory(path As String, predicatePattern As Func(Of FileInfo, Boolean)) As IEnumerable(Of FileInfo)

        Dim directoryStack = New Stack(Of DirectoryInfo)()
        directoryStack.Push(New DirectoryInfo(path))

        Do While directoryStack.Count > 0

            Dim dir = directoryStack.Pop()

            Try
                For Each di In dir.GetDirectories()
                    directoryStack.Push(di)
                Next
            Catch e1 As UnauthorizedAccessException
                Debug.WriteLine($"Unauthorized: {e1.Message}")
                Continue Do ' We don't have access to this directory, so skip it
            End Try

            For Each fi In dir.GetFiles().Where(predicatePattern) ' "Pattern" is a function
                Yield fi
            Next
        Loop

    End Function
End Class