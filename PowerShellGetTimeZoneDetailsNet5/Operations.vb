Imports System.IO
Imports PowerShellGetTimeZoneDetailsNet5.Classes
Imports PowerShellGetTimeZoneDetailsNet5.Containers

Public Class Operations

    Public Shared Async Function GetTimeZoneTask() As Task(Of TimezoneItem)

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
                Await process.WaitForExitAsync()
                Dim json = Await File.ReadAllTextAsync(fileName)

                'Return JsonConvert.DeserializeObject(Of TimezoneItem)(json)
                Return JSonHelper.DeserializeObject(Of TimezoneItem)(json)

            End Using

        End Using

    End Function

    Public Shared Async Function GetComputerInformationTask() As Task(Of MachineComputerInformation)

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
                Await process.WaitForExitAsync()


                Dim json = Await File.ReadAllTextAsync(fileName)

                'Return JsonConvert.DeserializeObject(Of MachineComputerInformation)(json)
                Return JSonHelper.DeserializeObject(Of MachineComputerInformation)(json)


            End Using
        End Using
    End Function

End Class