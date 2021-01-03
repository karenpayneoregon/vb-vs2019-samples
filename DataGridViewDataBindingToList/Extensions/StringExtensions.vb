Imports System.Runtime.CompilerServices

Namespace Extensions
    Module StringExtensions

        <Extension>
        Public Function Fixer(sender As String) As String
            If String.IsNullOrWhiteSpace(sender) Then
                Return "(none)"
            Else
                Return sender.Trim()
            End If
        End Function

    End Module
End Namespace