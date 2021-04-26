Imports System.ComponentModel
Imports System.Globalization

Public Class MyConverter
    Inherits TypeConverter

    Public Overrides Function ConvertTo(
                                        context As ITypeDescriptorContext,
                                        culture As CultureInfo, value As Object,
                                        destinationType As Type) As Object

        Dim list As List(Of String) = TryCast(value, List(Of String))

        If destinationType Is GetType(String) Then
            Return String.Join(",", list.ToArray())
        End If

        Return MyBase.ConvertTo(context, culture, value, destinationType)

    End Function
End Class