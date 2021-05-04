Imports System.ComponentModel

Namespace Containers
    Public Class Osuptime
        Public Property Ticks() As Long
        Public Property Days() As Integer
        Public Property Hours() As Integer
        Public Property Milliseconds() As Integer
        Public Property Minutes() As Integer
        Public Property Seconds() As Integer
        <DisplayName("Total days")>
        Public Property TotalDays() As Single
        <DisplayName("Total hours")>
        Public Property TotalHours() As Single
        <DisplayName("Total milliseconds")>
        Public Property TotalMilliseconds() As Single
        <DisplayName("Total minutes")>
        Public Property TotalMinutes() As Single
        <DisplayName("Total seconds")>
        Public Property TotalSeconds() As Single
        Public Overrides Function ToString() As String
            Return $"{Hours} hours {Minutes} minutes {Days} days"
        End Function

    End Class
End Namespace