Namespace Classes
    Public Class Person
        Public Property FirstName() As String
        Public Property MiddleName() As String
        Public Property LastName() As String
        Public Property EmployeeNumber() As String
        Public Property Department() As String
        Public Property Telephone() As String
        Public Property Extension() As String
        Public Property Email() As String

        Public Overrides Function ToString() As String
            Return $"{FirstName} {LastName}"
        End Function
    End Class
End NameSpace