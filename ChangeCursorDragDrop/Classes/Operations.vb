Imports System.Collections.Specialized
Imports System.Text

Namespace Classes
    ''' <summary>
    ''' Helper methods to assist in seeing drop results when of
    ''' type file.
    ''' </summary>
    Public Class Operations
        ''' <summary>
        ''' Iterate dropped files into a StringBuilder and display
        ''' </summary>
        ''' <param name="fileNames"></param>
        Public Shared Sub IterateFiles(fileNames As StringCollection)
            Dim sb As New StringBuilder()

            For Each fileName In fileNames
                sb.AppendLine(fileName)
            Next

            Debug.WriteLine(sb.ToString())

        End Sub
        ''' <summary>
        ''' Flatten selected files and display as a string
        ''' </summary>
        ''' <param name="fileNames"></param>
        Public Shared Sub Inspect(fileNames As StringCollection)

            Debug.WriteLine(
                String.Join(
                    Environment.NewLine,
                    fileNames.Cast(Of String).ToArray()))
        End Sub
    End Class
End Namespace