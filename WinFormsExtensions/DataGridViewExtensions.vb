Imports System.Windows.Forms

Public Module DataGridViewExtensions
    ''' <summary>
    ''' Expand all columns and suitable for working with Entity Framework in regards to ICollection`1 column types.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="sizable">Undue DataGridViewAutoSizeColumnMode.AllCells which makes manual resizing possible</param>
    Public Sub ExpandColumns(sender As DataGridView, Optional sizable As Boolean = False)

        For Each column As DataGridViewColumn In sender.Columns
            If column.ValueType.Name <> "ICollection`1" Then
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Next

        If Not sizable Then
            Return
        End If

        For index As Integer = 0 To sender.Columns.Count - 1

            Dim columnWidth As Integer = sender.Columns(index).Width

            sender.Columns(index).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            sender.Columns(index).Width = columnWidth

        Next

    End Sub
End Module
