Imports System.IO
Imports System.Threading

Public Class OperationsListView

    Public Delegate Sub OnTraverseFolder(information As DirectoryItem)
    ''' <summary>
    ''' Callback for when a folder is being processed
    ''' </summary>
    Public Shared Event OnTraverseEvent As OnTraverseFolder

    ''' <summary>
    ''' For traversing folders, if a cancellation is requested stop processing folders.
    ''' </summary>
    Public Shared Cancelled As Boolean = False
    Public Shared Async Function RecursiveFolders(directoryInfo As DirectoryInfo, ct As CancellationToken) As Task

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

            RaiseEvent OnTraverseEvent(di)

        End If

        Await Task.Delay(1)

        Dim folder As DirectoryInfo

        Try
            Await Task.Run(Async Function()

                               For Each dir As DirectoryInfo In directoryInfo.EnumerateDirectories()

                                   folder = dir

                                   If Not Cancelled Then

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
End Class
