Imports System.IO

Public Module DirectoryExtensions
    <Runtime.CompilerServices.Extension>
    Public Function GetFilesByExtensions(dir As DirectoryInfo, ParamArray extensions() As String) As IEnumerable(Of FileInfo)
        If extensions Is Nothing Then
            Throw New ArgumentNullException("extensions")
        End If
        Dim files As IEnumerable(Of FileInfo) = dir.EnumerateFiles()
        Return files.Where(Function(f) extensions.Contains(f.Extension))
    End Function

End Module
