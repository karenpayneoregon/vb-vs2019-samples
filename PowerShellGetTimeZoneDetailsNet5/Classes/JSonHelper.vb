Imports System.IO
Imports System.Text.Json
Imports JsonForVbLibrary

Public Class JSonHelper
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <typeparam name="TModel"></typeparam>
    ''' <param name="json"></param>
    ''' <returns></returns>
    Public Shared Function JSonToObject(Of TModel)(json As String) As TModel
        Dim options As New JsonSerializerOptions()
        options.Converters.Add(New UnixEpochDateTimeConverter())

        'Dim options = New JsonSerializerOptions With {.WriteIndented = True}
        Return JsonSerializer.Deserialize(Of TModel)(json, options)
    End Function

    Public Shared Function JSonToList(Of T)(jsonString As String) As List(Of T)
        Dim options As New JsonSerializerOptions()
        options.Converters.Add(New UnixEpochDateTimeConverter())

        Return JsonSerializer.Deserialize(Of List(Of T))(jsonString)
    End Function

    ''' <summary>
    ''' Write T to json file
    ''' </summary>
    ''' <typeparam name="T">Type</typeparam>
    ''' <param name="type">Type</param>
    ''' <param name="path">File name with optional path</param>
    ''' <returns></returns>
    Public Shared Function JsonToObjectFormatted(Of T)(type As T, path As String) As Boolean
        Throw New NotImplementedException()
    End Function

    ''' <summary>
    ''' Serialize a list to a file
    ''' </summary>
    ''' <typeparam name="TModel"></typeparam>
    ''' <param name="sender">Type to serialize</param>
    ''' <param name="fileName">File json to this file</param>
    ''' <param name="format">true to format json, otherwise no formatting</param>
    ''' <returns>Value Tuple, on success return true/null, otherwise false and the exception thrown</returns>
    Public Shared Function JsonToListFormatted(Of TModel)(sender As List(Of TModel), fileName As String, Optional format As Boolean = True) As (result As Boolean, exception As Exception)

        Try

            Dim options = New JsonSerializerOptions With {.WriteIndented = True}
            File.WriteAllText(fileName, JsonSerializer.Serialize(sender, If(format, options, Nothing)))

            Return (True, Nothing)

        Catch e As Exception
            Return (False, e)
        End Try

    End Function
End Class
