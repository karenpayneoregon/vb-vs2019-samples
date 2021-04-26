Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection

Friend Class DrinkDosesConverter
    Inherits EnumConverter

    Private _enumType As Type
    ''' <summary />Initializing instance</summary />
    ''' <param name=""type"" />type Enum</param />
    ''' this is only one function, that you must
    ''' change. All another functions for enums
    ''' you can use by Ctrl+C/Ctrl+V
    Public Sub New(ByVal type As Type)
        MyBase.New(type)
        _enumType = type
    End Sub

    Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destType As Type) As Boolean
        Return destType Is GetType(String)
    End Function

    Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destType As Type) As Object
        Dim fi As FieldInfo = _enumType.GetField(System.Enum.GetName(_enumType, value))
        Dim dna As DescriptionAttribute = CType(Attribute.GetCustomAttribute(fi, GetType(DescriptionAttribute)), DescriptionAttribute)

        If dna IsNot Nothing Then
            Return dna.Description
        Else
            Return value.ToString()
        End If
    End Function

    Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal srcType As Type) As Boolean
        Return srcType Is GetType(String)
    End Function

    Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object

        For Each fi As FieldInfo In _enumType.GetFields()
            Dim dna As DescriptionAttribute = CType(Attribute.GetCustomAttribute(fi,
            GetType(DescriptionAttribute)), DescriptionAttribute)

            If (dna IsNot Nothing) AndAlso (DirectCast(value, String) = dna.Description) Then
                Return System.Enum.Parse(_enumType, fi.Name)
            End If
        Next

        Return System.Enum.Parse(_enumType, DirectCast(value, String))
    End Function
End Class