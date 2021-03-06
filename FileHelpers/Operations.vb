Imports System.IO
Imports System.Threading
Public Class Operations
    Public Delegate Sub OnDelete(status As String)
    ''' <summary>
    ''' Callback for subscribers to see what is being worked on
    ''' </summary>
    Public Shared Event OnDeleteEvent As OnDelete

    Public Delegate Sub OnException(exception As Exception)
    ''' <summary>
    ''' Callback for subscribers to know about a problem
    ''' </summary>
    Public Shared Event OnExceptionEvent As OnException

    Public Delegate Sub OnUnauthorizedAccessException(message As String)
    Public Shared Event UnauthorizedAccessExceptionEvent As OnUnauthorizedAccessException

    Public Delegate Sub OnTraverseFolder(status As String)
    ''' <summary>
    ''' Callback for when a folder is being processed
    ''' </summary>
    Public Shared Event OnTraverseEvent As OnTraverseFolder

    Public Delegate Sub OnTraverseExcludeFolder(sender As String)
    ''' <summary>
    ''' Callback when a folder is being excluded
    ''' </summary>
    Public Shared Event OnTraverseExcludeFolderEvent As OnTraverseExcludeFolder
    ''' <summary>
    ''' For traversing folders, if a cancellation is requested stop processing folders.
    ''' </summary>
    Public Shared Cancelled As Boolean = False
    ''' <summary>
    ''' For RecursiveDelete, so we don't need to carry this around in a recursive procedure
    ''' </summary>
    Public Shared ProcessDirectory As New List(Of String) From {"netcoreapp2.1", "RecentActions"}

    ''' <summary>
    ''' Base template for removing a folder structure. Unlike RecursiveFolders
    ''' which has cancellation and error trapping this procedure does not but with a
    ''' little effort it can.
    ''' </summary>
    ''' <param name="directoryInformation"></param>
    Public Shared Sub RecursiveDelete(directoryInformation As DirectoryInfo)

        If Not directoryInformation.Exists Then
            RaiseEvent OnDeleteEvent("Nothing to process")
            Return
        End If

        Dim attr = File.GetAttributes(directoryInformation.FullName)

        If attr.HasFlag(FileAttributes.Directory) Then

            If ProcessDirectory.Contains(directoryInformation.Name) Then
                RaiseEvent OnDeleteEvent($"Folder: {directoryInformation.FullName}")
            End If

        End If


        For Each dir As DirectoryInfo In directoryInformation.EnumerateDirectories()
            Try
                RecursiveDelete(dir)
            Catch ex As Exception
                RaiseEvent OnExceptionEvent(ex)
            End Try
        Next

        If ProcessDirectory.Contains(directoryInformation.Name) Then
            directoryInformation.Delete(True)
        End If


    End Sub
    ''' <summary>
    ''' Process directory tree
    ''' </summary>
    ''' <param name="directoryInfo">Full path wrapped in a DirectoryInfo variable</param>
    ''' <param name="excludeFileExtensions">string array to filter what folders to exclude</param>
    ''' <param name="ct">Token to cancel operation</param>
    Public Shared Async Function RecursiveFolders(directoryInfo As DirectoryInfo, excludeFileExtensions As String(), ct As CancellationToken) As Task

        If Not directoryInfo.Exists Then
            RaiseEvent OnTraverseEvent("Nothing to process")
            Return
        End If

        If Not excludeFileExtensions.Any(AddressOf directoryInfo.FullName.Contains) Then
            Await Task.Delay(1)
            RaiseEvent OnTraverseEvent(directoryInfo.FullName)

        Else
            RaiseEvent OnTraverseExcludeFolderEvent(directoryInfo.FullName)
        End If

        Dim folder As DirectoryInfo

        Try
            Await Task.Run(Async Function()

                               For Each dir As DirectoryInfo In directoryInfo.EnumerateDirectories()

                                   folder = dir

                                   If (folder.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden OrElse
                                      (folder.Attributes And FileAttributes.System) = FileAttributes.System OrElse
                                      (folder.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then

                                       RaiseEvent OnTraverseExcludeFolderEvent($"* {folder.FullName}")

                                       Continue For

                                   End If

                                   If Not Cancelled Then

                                       Await Task.Delay(1)
                                       Await RecursiveFolders(folder, excludeFileExtensions, ct)

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
            ' In OperationsListView class the UnauthorizedAccessException
            ' and general exceptions are ignored.
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

    ''' <summary>
    ''' Example that will run freely and the app will be unresponsive which
    ''' is how many developers approach reading folders and only try with a smaller
    ''' folder structure but larger structures will freeze the app thus we
    ''' need to consider an asynchronous method.
    ''' </summary>
    ''' <param name="path">Folder to work with</param>
    ''' <param name="indentLevel">Indent level for display with Console.WriteLine</param>
    Public Shared Sub RecursiveFolders(path As String, indentLevel As Integer)

        Try

            If (File.GetAttributes(path) And FileAttributes.ReparsePoint) <> FileAttributes.ReparsePoint Then

                For Each folder As String In Directory.GetDirectories(path)
                    Debug.WriteLine($"{New String(" "c, indentLevel)}{IO.Path.GetFileName(folder)}")
                    RecursiveFolders(folder, indentLevel + 2)
                Next

            End If

        Catch unauthorized As UnauthorizedAccessException
            '
            ' Show folder which failed by deny access
            '
            Debug.WriteLine($"{unauthorized.Message}")
        End Try
    End Sub

End Class
