Imports System.IO
Imports System.Text.Json
Imports JsonForVbLibrary

Namespace Classes

    Public Class JSonHelper
        ''' <summary>
        ''' Deserialize from Json string to TModel
        ''' </summary>
        ''' <typeparam name="TModel">Type to deserialize Json to</typeparam>
        ''' <param name="json">Valid json for deserialize TModel too.</param>
        ''' <returns>single instance of TModel</returns>
        Public Shared Function DeserializeObject(Of TModel)(json As String) As TModel

            Dim options As New JsonSerializerOptions()
            options.Converters.Add(New UnixEpochDateTimeConverter())


            Return JsonSerializer.Deserialize(Of TModel)(json, options)

        End Function
        ''' <summary>
        ''' Deserialize from Json string to List(Of TModel)
        ''' </summary>
        ''' <typeparam name="TModel">Type to deserialize Json to</typeparam>
        ''' <param name="json">Valid json for deserialize TModel too</param>
        ''' <returns>List(Of TModel)</returns>
        Public Shared Function JSonToList(Of TModel)(json As String) As List(Of TModel)

            Dim options As New JsonSerializerOptions()
            options.Converters.Add(New UnixEpochDateTimeConverter())

            Return JsonSerializer.Deserialize(Of List(Of TModel))(json)

        End Function

        ''' <summary>
        ''' Write T to json file
        ''' </summary>
        ''' <typeparam name="TModel">Type</typeparam>
        ''' <param name="sender">Type</param>
        ''' <param name="fileName">File name with optional path</param>
        ''' <returns></returns>
        Public Shared Function ObjectToJsonFormatted(Of TModel)(sender As TModel, fileName As String) As Boolean
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
End Namespace