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

    <Extension>
    Public Function ContainsAny(sender As String, ParamArray values As String()) As Boolean
        Return values.Any(Function(value) sender.Contains(value))
    End Function
End Module
