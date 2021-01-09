Imports System.Reflection
Imports System.Runtime.CompilerServices

Namespace LanguageExtensions

    Public Module ListViewExtensions
        <Extension>
        Public Sub SetDoubleBuffered(listView As ListView, Optional value As Boolean = True)

            listView.
                GetType().
                GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).
                SetValue(listView, value)

        End Sub
    End Module
End Namespace