Imports System.IO
Imports System.Runtime.CompilerServices

''' <summary>
''' Single instance class for a StopWatch
''' </summary>
Public NotInheritable Class StopWatcher

    Private Shared ReadOnly Lazy As New Lazy(Of StopWatcher)(Function() New StopWatcher())
    ''' <summary>
    ''' Where to log details
    ''' </summary>
    Private fileName As String = "Log.txt"
    ''' <summary>
    ''' Should log to file
    ''' </summary>
    ''' <returns></returns>
    Public Property Log() As Boolean
    Private ReadOnly _stopwatch As Stopwatch

    Private Sub New()
        _stopwatch = New Stopwatch()
    End Sub

    ''' <summary>
    ''' Start timer
    ''' </summary>
    Public Sub Start(<CallerMemberName> Optional callerName As String = Nothing)

        _stopwatch.Reset()
        _stopwatch.Start()

        If Log Then
            LogDetails(Nothing, callerName)
        End If

    End Sub

    ''' <summary>
    ''' Stop for measuring stop watch Elapsed time
    ''' </summary>
    Public Sub [Stop]()
        _stopwatch.Stop()
    End Sub
    ''' <summary>
    ''' Get elapsed time as a TimeSpan
    ''' </summary>
    Public ReadOnly Property Elapsed() As TimeSpan
        Get
            [Stop]()
            Return _stopwatch.Elapsed
        End Get
    End Property

    ''' <summary>
    ''' Format elapsed time to minutes, seconds, milliseconds
    ''' </summary>
    Public ReadOnly Property ElapsedFormatted(<CallerMemberName> Optional callerName As String = Nothing) As String
        Get
            [Stop]()
            Dim formatted = Elapsed.ToString("mm\:ss\.fff")
            If Log Then
                LogDetails(formatted, callerName)
            End If
            Return formatted
        End Get
    End Property
    Private Sub LogDetails(elapsedTime As String, callerName As String, Optional isStart As Boolean = True)

        Const dateFormat = "yyyy/MM/dd HH:mm:ss"

        If File.Exists(fileName) Then
            Dim contents = File.ReadAllLines(fileName).ToList()

            If isStart Then
                contents.Add($"{Now.ToString(dateFormat)},{elapsedTime},{callerName}")
            Else
                contents.Add($"{Now.ToString(dateFormat)},{callerName}")
            End If

            File.WriteAllLines(fileName, contents.ToArray())

        Else

            If isStart Then
                File.WriteAllText(fileName, $"{Now.ToString(dateFormat)},{callerName}")
            Else
                File.WriteAllText(fileName, $"{Now.ToString(dateFormat)},{elapsedTime},{callerName}")
            End If

        End If

    End Sub
    ''' <summary>
    ''' Access point to methods and properties
    ''' </summary>
    Public Shared ReadOnly Property Instance() As StopWatcher
        Get
            Return Lazy.Value
        End Get
    End Property

End Class
