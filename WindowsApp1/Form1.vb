Imports System.IO
Imports System.Net.Http
Imports System.Threading

Public Class Form1

    Private _cancellationTokenSource As New CancellationTokenSource()

    Private Async Function Demo(token As CancellationToken, secondsDelay As Integer) As Task(Of String)

        While True
            Try

                Await Task.Delay(secondsDelay, token)

                Using client = New HttpClient()

                    Dim response = Await client.GetAsync("http://httpbin.org/get",
                                                 HttpCompletionOption.ResponseHeadersRead)

                    response.EnsureSuccessStatusCode()

                    Using stream = Await response.Content.ReadAsStreamAsync()
                        Using streamReader As New StreamReader(stream)
                            Return Await streamReader.ReadToEndAsync()
                        End Using
                    End Using
                End Using

            Catch httpRequestException As HttpRequestException
                Const msg = "Response status code does not indicate success: 404 (NOT FOUND)."
                If httpRequestException.Message.Contains(msg) Then
                    Console.WriteLine("404 error")
                End If

                If token.IsCancellationRequested Then
                    token.ThrowIfCancellationRequested()
                    Return String.Empty
                End If

            Catch generalException As Exception
                Console.WriteLine(generalException.Message)
            End Try
        End While

        Return String.Empty

    End Function

    Private Async Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click

        If _cancellationTokenSource.IsCancellationRequested Then
            _cancellationTokenSource.Dispose()
            _cancellationTokenSource = New CancellationTokenSource()
        End If

        Try
            Dim contents = Await Demo(_cancellationTokenSource.Token, 5)
            Console.WriteLine(contents)
        Catch ex As Exception
            Console.WriteLine("Failed")
        End Try

    End Sub

    Private Sub CancelDemo2Button_Click(sender As Object, e As EventArgs) Handles CancelDemo2Button.Click
        _cancellationTokenSource.Cancel()
    End Sub
End Class
