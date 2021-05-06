Namespace Classes
    ''' <summary>
    ''' Single instance class for a StopWatch
    ''' </summary>
    Public NotInheritable Class StopWatcher
        ''' <summary>
        ''' Creates a thread safe instance of this class
        ''' </summary>
        Private Shared ReadOnly Lazy As New Lazy(Of StopWatcher)(Function() New StopWatcher())

        ''' <summary>
        ''' StopWatch for measuring time.
        ''' </summary>
        Private _stopwatch As Stopwatch

        ''' <summary>
        ''' Inaccessible constructor
        ''' </summary>
        Private Sub New()
            _stopwatch = New Stopwatch()
        End Sub

        ''' <summary>
        ''' Start timer
        ''' </summary>
        ''' <remarks>
        ''' First reset the stop watch to get fresh calculations
        ''' </remarks>
        Public Sub Start()
            _stopwatch = New Stopwatch()
            _stopwatch.Start()
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
        Public ReadOnly Property ElapsedFormatted() As String
            Get
                [Stop]()
                Return Elapsed.ToString("mm\:ss\.fff")
            End Get
        End Property

        ''' <summary>
        ''' Access point to methods and properties
        ''' </summary>
        Public Shared ReadOnly Property Instance() As StopWatcher
            Get
                Return Lazy.Value
            End Get
        End Property

    End Class
End Namespace