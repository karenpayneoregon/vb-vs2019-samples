# About

Build dynamic WHERE IN for SQL-Server

- TechNet article: [VB.NET Windows Forms Create SQL WHERE IN from delimited values with custom controls](https://social.technet.microsoft.com/wiki/contents/articles/53293.vb-net-windows-forms-create-sql-where-in-from-delimited-values-with-custom-controls.aspx)
- GitHub : [repository](https://github.com/karenpayneoregon/WindowsFormsTextBoxWhereClause)

---

![img](../assets/sql-server.png)

[Data script](https://gist.github.com/karenpayneoregon/40a6e1158ff29819286a39b7f1ed1ae8)

---


 
![img](../assets/Versions.png)

![img](../assets/vb1.png)

---

**Base module**

```csharp
Public Module SqlWhereInParameterBuilder
    Public Function BuildWhereInClause(Of T)(partialClause As String, paramPrefix As String, parameters As IEnumerable(Of T)) As String

        paramPrefix = StripFunction(paramPrefix)

        Dim parameterNames = parameters.Select(
            Function(paramText, paramNumber) $"@{paramPrefix.Replace(".", "")}{paramNumber}").ToArray()

        Dim whereInClause = String.Format(partialClause.Trim(), String.Join(",", parameterNames))

        Return whereInClause

    End Function
    <Extension>
    Public Sub AddParamsToCommand(Of T)(cmd As SqlCommand, paramPrefix As String, parameters As IEnumerable(Of T))
        paramPrefix = StripFunction(paramPrefix)

        Dim parameterValues = parameters.Select(Function(paramText) paramText).ToArray()
        Dim parameterNames() As String = parameterValues.Select(
            Function(paramText, paramNumber) $"@{paramPrefix.Replace(".", "")}{paramNumber}").ToArray()

        For index As Integer = 0 To parameterNames.Length - 1
            cmd.Parameters.AddWithValue(parameterNames(index), parameterValues(index))
        Next

        '
        ' Display what a hacker would see
        '
        If Debugger.IsAttached Then
            Console.WriteLine(cmd.CommandText)
            Debug.WriteLine(cmd.CommandText)
        End If

    End Sub

    Private Function StripFunction(pValue As String) As String
        If pValue.Contains("(") Then
            Dim regularExpressionPattern As String = "(?<=\()[^}]*(?=\))"
            Dim re As New Regex(regularExpressionPattern)
            Return re.Matches(pValue)(0).ToString()
        Else
            Return pValue
        End If
    End Function
End Module
```