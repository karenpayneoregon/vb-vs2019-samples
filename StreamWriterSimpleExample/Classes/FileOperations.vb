Imports System.IO

Namespace Classes

    Public Class FileOperations
        ' requires NuGet package ValueTuple for return type
        ' https://www.nuget.org/packages/System.ValueTuple/
        Public Shared Function WriteData(sender As Person, fileName As String) As _
            (Success As Boolean, Exception As Exception)

            Try

                If File.Exists(fileName) Then
                    File.Delete(fileName)
                End If

                Using sw As New StreamWriter(fileName, False)

                    sw.WriteLine(sender.FirstName)
                    sw.WriteLine(sender.MiddleName)
                    sw.WriteLine(sender.LastName)
                    sw.WriteLine(sender.EmployeeNumber)
                    sw.WriteLine(sender.Department)
                    sw.WriteLine(sender.Telephone)
                    sw.WriteLine(sender.Extension)
                    sw.WriteLine(sender.Email)
                End Using

                Return (true, Nothing)

            Catch ex As Exception

                Return (True, ex)

            End Try
        End Function
        Public Shared Function Validate(fileName As String) As Boolean
            If File.Exists(fileName) Then
                Return File.ReadAllLines(fileName).Length = 18
            Else
                Return False
            End If
        End Function
    End Class
End NameSpace