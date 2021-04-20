Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports FileHelpers

Namespace LanguageExtensions

    Public Module ListViewExtensions
        <Extension>
        Public Function GetSelectedItem(listView1 As ListView) As ListViewItem
            Return (If(listView1.SelectedItems.Count > 0, listView1.SelectedItems(0), Nothing))
        End Function
        <Extension>
        Public Function GetSelectedItemTag(listView1 As ListView) As DirectoryItem
            Return (If(listView1.SelectedItems.Count > 0, CType(listView1.SelectedItems(0).Tag, DirectoryItem), Nothing))
        End Function
        <Extension>
        Public Sub SetDoubleBuffered(listView As ListView, Optional value As Boolean = True)

            listView.
                GetType().
                GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic).
                SetValue(listView, value)

        End Sub
    End Module
End Namespace