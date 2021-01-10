Public Class FoundFile
    Implements IEquatable(Of FoundFile)

    Public Property FileName() As String
    Public Property LineNumber() As Integer
    Public Property Text() As String

    Public Overloads Function Equals(other As FoundFile) As Boolean _
        Implements IEquatable(Of FoundFile).Equals

        If ReferenceEquals(Nothing, other) Then Return False
        If ReferenceEquals(Me, other) Then Return True

        Return String.Equals(
            FileName, other.FileName) AndAlso
               LineNumber = other.LineNumber AndAlso
               String.Equals(Text, other.Text)
    End Function

    Public Overloads Overrides Function Equals(obj As Object) As Boolean

        If ReferenceEquals(Nothing, obj) Then Return False
        If ReferenceEquals(Me, obj) Then Return True
        If obj.GetType IsNot Me.GetType Then Return False

        Return Equals(DirectCast(obj, FoundFile))
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return HashCode.Combine(FileName, LineNumber, Text)
    End Function

    Public Overrides Function ToString() As String
        Return $"{FileName}{vbCrLf}{LineNumber}{vbCrLf}{Text}"
    End Function
End Class