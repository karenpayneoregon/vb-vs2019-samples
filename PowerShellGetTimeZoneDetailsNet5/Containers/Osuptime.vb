Namespace Containers
    Public Class Osuptime
        Public Property Ticks() As Long
        Public Property Days() As Integer
        Public Property Hours() As Integer
        Public Property Milliseconds() As Integer
        Public Property Minutes() As Integer
        Public Property Seconds() As Integer
        Public Property TotalDays() As Single
        Public Property TotalHours() As Single
        Public Property TotalMilliseconds() As Single
        Public Property TotalMinutes() As Single
        Public Property TotalSeconds() As Single
        Public Overrides Function ToString() As String
            Return $"{Hours} hours {Minutes} minutes {Days} days"
        End Function

    End Class
End Namespace