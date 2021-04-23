Imports System.IO
Imports Newtonsoft.Json

Public Class UserDetails
    Public Property UserName() As String
    Public Property UserPassword() As String
    Public Property UseDefaultCredentials() As Boolean

    Public Overrides Function ToString() As String
        Return UserName
    End Function
End Class
Public Class Operations

    Public Shared Function Read(Optional fileName As String = "userData.json") As UserDetails
        Dim Results As New UserDetails()

        If Not File.Exists(fileName) Then
            Return Results
        End If

        Dim json = File.ReadAllText(fileName)
        Results = JsonConvert.DeserializeObject(Of UserDetails)(json)
        Results.UserName = Modules.ToInsecureString(Modules.DecryptString(Results.UserName))
        Results.UserPassword = Modules.ToInsecureString(Modules.DecryptString(Results.UserPassword))
        Return Results

    End Function
    Public Shared Sub Write(userDetails As UserDetails, Optional fileName As String = "userData.json")
        Dim json = JsonConvert.SerializeObject(userDetails, Formatting.Indented, New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore})

        File.WriteAllText(fileName, json)
    End Sub

    Public Shared Sub CreateStructure()
        Dim item As New UserDetails With {
                .UseDefaultCredentials = False,
                .UserName = Modules.EncryptString(Modules.ToSecureString("payne")),
                .UserPassword = Modules.EncryptString(Modules.ToSecureString("@123Xder"))
                }
        Write(item)
    End Sub

End Class
