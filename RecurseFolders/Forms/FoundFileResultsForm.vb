Imports System.Text
Imports FileHelpers

Public Class FoundFileResultsForm
    Public FoundFileList As New List(Of FoundFile)

    Private Sub FoundFileResultsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim sb As New StringBuilder

        'For Each foundFile As FoundFile In FoundFileList

        '    sb.AppendLine(foundFile.ToString())
        '    sb.AppendLine(New String("-"c, 40))

        'Next


        For Each foundFile As FoundFile In FoundFileList

            sb.AppendLine(foundFile.FileName)
            sb.AppendLine(New String("-"c, 40))

        Next

        TextBox1.Text = sb.ToString()

    End Sub
End Class