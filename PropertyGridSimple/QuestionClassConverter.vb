Imports System.ComponentModel
Imports System.Globalization

Public Class QuestionClassConverter
    Inherits BooleanConverter

    Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As CultureInfo, value As Object, destType As Type) As Object
        Return If(DirectCast(value, Boolean), "Yes", "No way")
    End Function

    Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As CultureInfo, ByVal value As Object) As Object
        Return DirectCast(value, String) = "Yes"
    End Function
End Class