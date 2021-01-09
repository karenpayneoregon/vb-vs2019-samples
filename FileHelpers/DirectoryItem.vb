Public Class DirectoryItem
    Public Property Name() As String
    Public Property Location() As String
    Public Property Modified() As DateTime
    Public ReadOnly Property ItemArray() As String()
        Get
            Return New String() {Location, Name, Modified.ToShortDateString()}
        End Get
    End Property
    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
