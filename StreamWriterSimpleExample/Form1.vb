Imports StreamWriterExample.Classes

Public Class Form1

    Private Sub WriteButton_Click(sender As Object, e As EventArgs) Handles WriteButton.Click

        Dim person As New Person With {
            .FirstName = "Line 1",
            .MiddleName = "Line 2",
            .LastName = "Line 3",
            .EmployeeNumber = "Line 4",
            .Department = "Line 5",
            .Telephone = "Line 6",
            .Extension = "Line 7",
            .Email = "Line 8"
        }

        '
        ' There are no checks to see if the folder exists so make sure to create the
        ' folder before running the code below.
        '
        Dim fileName = "C:\OED\Person.txt"

        Dim result = FileOperations.WriteData(person, fileName)

        If result.Success Then
            MessageBox.Show("Done")
        Else
            MessageBox.Show(result.Exception.Message)
        End If

    End Sub
End Class