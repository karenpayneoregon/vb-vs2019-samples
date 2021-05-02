Imports System.ComponentModel

Public Class Oshotfix
    <DisplayName("Hot fix id")>
    Public Property HotFixID() As String
    Public Property Description() As String
    <DisplayName("Installed on")>
    Public Property InstalledOn() As String
    <DisplayName("Fix Comments")>
    Public Property FixComments() As String
End Class