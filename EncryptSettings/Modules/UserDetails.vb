

Public Class UserDetails
    Public Property UserName() As String
    Public Property UserPassword() As String
    Public Property UseDefaultCredentials() As Boolean

    Public Overrides Function ToString() As String
        Return UserName
    End Function
End Class