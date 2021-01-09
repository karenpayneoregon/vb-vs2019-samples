Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Public Module StringExtensions
    <Extension>
    Public Function StringBetweenQuotes(sender As String) As String
        Dim match As Match = Regex.Match(sender, "'([^']*)")

        If match.Success Then
            Return match.Groups(1).Value
        Else
            Return sender
        End If
    End Function
End Module
