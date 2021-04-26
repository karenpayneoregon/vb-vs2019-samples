Imports System.ComponentModel

Public Class FormatStringConverter
    Inherits StringConverter

    Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function
    Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
        Return True
    End Function
    Public Overrides Function GetStandardValues(context As ITypeDescriptorContext) As StandardValuesCollection
        Dim list As New List(Of String) From {
                "(select)",
                "Jim",
                "Mary",
                "Frank",
                "Karen"
                }
        Return New StandardValuesCollection(list)
    End Function
End Class