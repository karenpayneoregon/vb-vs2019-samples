Imports System.IO
Imports System.Threading

Public Class OperationsListView
    ''' <summary>
    ''' Container for files containing SearchText
    ''' </summary>
    Public Shared FoundFileList As New List(Of FoundFile)

    Public Delegate Sub OnTraverseFolder(information As DirectoryItem)
    ''' <summary>
    ''' Callback for when a folder is being processed
    ''' </summary>
    Public Shared Event OnTraverseEvent As OnTraverseFolder

    ''' <summary>
    ''' For traversing folders, if a cancellation is requested stop processing folders.
    ''' </summary>
    Public Shared Cancelled As Boolean = False

    ''' <summary>
    ''' Text to search for in files
    ''' </summary>
    Public Shared SearchText As String

    Public Shared Async Function RecursiveFolders(
          directoryInfo As DirectoryInfo,
          ct As CancellationToken,
          Optional fileType As String = "*.txt") As Task

        If Not directoryInfo.Exists Then
            Return
        End If

        '
        ' Let's say you are traversing folders with Git repositories, we don't
        ' want to include their folders.
        '
        If Not directoryInfo.FullName.ContainsAny(".git", "\obj") Then

            Dim di As New DirectoryItem With {
                        .Location = Path.GetDirectoryName(directoryInfo.FullName),
                        .Name = directoryInfo.Name,
                        .Modified = directoryInfo.CreationTime
                    }

            IterateFiles(di.Location, fileType)

            RaiseEvent OnTraverseEvent(di)

        End If

        Await Task.Delay(1)

        Dim folder As DirectoryInfo

        Try

            Await Task.Run(Async Function()

                               For Each dir As DirectoryInfo In directoryInfo.EnumerateDirectories()

                                   folder = dir

                                   If Not Cancelled Then

                                       IterateFiles(dir.FullName, fileType)
                                       Await Task.Delay(1)
                                       Await RecursiveFolders(folder, ct)

                                   Else
                                       Return
                                   End If

                                   If ct.IsCancellationRequested Then
                                       ct.ThrowIfCancellationRequested()
                                   End If

                               Next

                           End Function)

        Catch ex As Exception
            '
            ' Operations.RecursiveFolders showed how to recognize
            ' folders that access has been denied, here these exceptions
            ' are ignored. A developer can integrate those exceptions here
            ' if so desired.
            '
            If TypeOf ex Is OperationCanceledException Then

                Cancelled = True

            End If
        End Try

    End Function
    Public Shared Sub IterateFiles(folderName As String, fileType As String)

        If String.IsNullOrWhiteSpace(SearchText) Then
            Exit Sub
        End If

        Dim files = Directory.GetFiles(folderName, fileType)

        If files.Length > 0 Then
            For Each fileName As String In files
                Dim current = fileName

                Dim result = File.
                        ReadLines(fileName).
                        Select(Function(text, index) New With {
                                      Key text,
                                      Key .LineNumber = index + 1
                        }).
                        Where(Function(anonymous) anonymous.text.Contains(SearchText)).
                        ToList()

                If result.Count > 0 Then

                    For Each foundFileItem In From anonymous In result Select item = New FoundFile() With {
                            .Text = anonymous.text,
                            .LineNumber = anonymous.LineNumber,
                            .FileName = current} Where Not FoundFileList.Contains(item)

                        FoundFileList.Add(foundFileItem)

                    Next

                End If

            Next
        End If

    End Sub
End Class