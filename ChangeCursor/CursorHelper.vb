Imports System.Threading

Public Class CursorHelper
    ''' <summary>
    ''' Change mouse cursor to wait for five seconds.
    ''' </summary>
    Public Shared Sub ChangeToWait(Optional mlliSeconds As Integer = 5000)

        Task.Factory.StartNew(
            Sub()

                Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = Cursors.Wait)

                Try
                    Thread.Sleep(mlliSeconds)
                Finally
                    Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = Nothing)
                End Try

            End Sub)

    End Sub
    Public Shared Sub ChangeTo(cursor As Cursor, Optional mlliSeconds As Integer = 5000)

        Task.Factory.StartNew(
            Sub()

                Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = cursor)

                Try
                    Thread.Sleep(mlliSeconds)
                Finally
                    Windows.Application.Current.Dispatcher.Invoke(Sub() Mouse.OverrideCursor = Nothing)
                End Try

            End Sub)

    End Sub
End Class