Imports System.ComponentModel

Namespace Containers

    Public Class TimezoneItem
        Public Property Id() As String
        <DisplayName("Display name")>
        Public Property DisplayName() As String
        <DisplayName("Standard name")>
        Public Property StandardName() As String
        <DisplayName("Daylight name")>
        Public Property DaylightName() As String
        <DisplayName("Base Utc Offset")>
        Public Property BaseUtcOffset() As BaseUtcOffset
        <DisplayName("Supports daylight saving")>
        Public Property SupportsDaylightSavingTime() As Boolean
    End Class
End Namespace