Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

''' <summary>
''' Contains methods to create dynamic WHERE IN conditions on a single field
''' </summary>
''' <remarks>
''' These methods are not meant to handle every single condition, they are
''' for simple IN clauses e.g. 
''' 
''' WHERE SomeField IN (1,2,3)
''' WHERE SomeField IN ('June','April')
''' WHERE YEAR(SomeField) IN (2008,2007,2018)
''' WHERE SomeField IN ('4-4-1960','9-22-1989')
''' 
''' If a function is year that has arguments these methods will not handle
''' them "as is".
''' 
''' </remarks>
Public Module SqlWhereInParameterBuilder
    ''' <summary>
    ''' Create a SQL SELECT statement which is then passed off to
    ''' AddParamsToCommand to create a parameter for each value.
    ''' </summary>
    ''' <typeparam name="T">SELECT Statement with WHERE condition</typeparam>
    ''' <param name="partialClause">Base SQL SELECT statement</param>
    ''' <param name="paramPrefix">WHERE IN field</param>
    ''' <param name="parameters">Value list for WHERE IN</param>
    ''' <returns>SELECT Statement with WHERE condition ready to populate values</returns>
    Public Function BuildWhereInClause(Of T)(partialClause As String, paramPrefix As String, parameters As IEnumerable(Of T)) As String

        paramPrefix = StripFunction(paramPrefix)

        Dim parameterNames = parameters.Select(
            Function(paramText, paramNumber) $"@{paramPrefix.Replace(".", "")}{paramNumber}").ToArray()

        Dim whereInClause = String.Format(partialClause.Trim(), String.Join(",", parameterNames))

        Return whereInClause

    End Function
    ''' <summary>
    ''' Create a parameter for each value in parameters
    ''' </summary>
    ''' <typeparam name="T">Command with parameters setup</typeparam>
    ''' <param name="cmd">Command object</param>
    ''' <param name="paramPrefix">Field name for the WHERE IN</param>
    ''' <param name="parameters">Values for the WHERE IN</param>
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
    ''' <summary>
    ''' Used to get a field name from a function e.g. YEAR(ActiveDate)
    ''' which will return ActiveDate.
    ''' </summary>
    ''' <param name="pValue"></param>
    ''' <returns></returns>
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