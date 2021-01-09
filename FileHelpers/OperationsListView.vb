Imports System.IO
Imports System.Threading

Public Class OperationsListView


    Public Delegate Sub OnException(exception As Exception)
    ''' <summary>
    ''' Callback for subscribers to know about a problem
    ''' </summary>
    Public Shared Event OnExceptionEvent As OnException

    Public Delegate Sub OnUnauthorizedAccessException(message As String)
    Public Shared Event UnauthorizedAccessExceptionEvent As OnUnauthorizedAccessException

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

        Dim di As New DirectoryItem With {
            .Name = directoryInfo.Name,
            .Location = Path.GetDirectoryName(directoryInfo.Name),
            .Modified = directoryInfo.LastAccessTime
        }

        RaiseEvent OnTraverseEvent(di)
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
            ' Only raise exceptions, not cancellation request
            '
            If TypeOf ex Is OperationCanceledException Then

                Cancelled = True

            ElseIf TypeOf ex Is UnauthorizedAccessException Then

                RaiseEvent UnauthorizedAccessExceptionEvent($"Access denied '{ex.Message.StringBetweenQuotes()}'")

            Else

                RaiseEvent OnExceptionEvent(ex)

            End If
        End Try


    End Function
End Class
