Imports System.IO
Imports System.Threading
Imports PowerShellGetTimeZoneDetailsNet5.Classes
Imports PowerShellGetTimeZoneDetailsNet5.Containers

Public Class Operations

    Public Delegate Sub FinishErrorDelegate(timeSpent As String)
    Public Shared Event FinishedEvent As FinishErrorDelegate

    Public Shared Async Function GetTimeZoneTask(cts As CancellationTokenSource) As Task(Of TimezoneItem)

        Const fileName = "timezone.json"

        If File.Exists(fileName) Then
            File.Delete(fileName)
        End If

        Dim start = New ProcessStartInfo With {
                    .FileName = "powershell.exe",
                    .RedirectStandardOutput = True,
                    .Arguments = "Get-TimeZone | ConvertTo-Json",
                    .CreateNoWindow = True
                }

        Using process As Process = Process.Start(start)

            Using reader = process.StandardOutput

                process.EnableRaisingEvents = True

                Dim fileContents = Await reader.ReadToEndAsync()

                Await File.WriteAllTextAsync(fileName, fileContents)

                StopWatcher.Instance.Start()

                Await process.WaitForExitAsync(cts.Token)

                StopWatcher.Instance.Stop()

                RaiseEvent FinishedEvent(StopWatcher.Instance.ElapsedFormatted)


                Dim json = Await File.ReadAllTextAsync(fileName)

                'Return JsonConvert.DeserializeObject(Of TimezoneItem)(json)
                Return JSonHelper.DeserializeObject(Of TimezoneItem)(json)

            End Using

        End Using

    End Function

    Public Shared Async Function GetComputerInformationTask(cts As CancellationTokenSource) As Task(Of MachineComputerInformation)

        Const fileName = "computerInformation.json"

        If File.Exists(fileName) Then
            File.Delete(fileName)

        End If

        Dim start = New ProcessStartInfo With {
                    .FileName = "powershell.exe",
                    .RedirectStandardOutput = True,
                    .Arguments = "Get-ComputerInfo | ConvertTo-Json",
                    .CreateNoWindow = True
                }

        Using process As Process = Process.Start(start)


            Using reader = process.StandardOutput

                process.EnableRaisingEvents = True

                Dim fileContents = Await reader.ReadToEndAsync()

                Await File.WriteAllTextAsync(fileName, fileContents)

                StopWatcher.Instance.Start()

                Await process.WaitForExitAsync(cts.Token)

                StopWatcher.Instance.Stop()

                RaiseEvent FinishedEvent(StopWatcher.Instance.ElapsedFormatted)


                Dim json = Await File.ReadAllTextAsync(fileName)

                ' if using Newtonsoft
                'Return JsonConvert.DeserializeObject(Of MachineComputerInformation)(json)

                ' using System.Text.Json
                Return JSonHelper.DeserializeObject(Of MachineComputerInformation)(json)

            End Using
        End Using
    End Function

End Class