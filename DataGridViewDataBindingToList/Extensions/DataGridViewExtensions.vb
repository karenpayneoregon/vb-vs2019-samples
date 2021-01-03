Imports System.IO
Imports System.Runtime.CompilerServices

Namespace Extensions

    Module DataGridViewExtensions
        ''' <summary>
        ''' Expand all DataGridViewColumns 
        ''' </summary>
        ''' <param name="sender"></param>
        <Extension>
        Public Sub ExpandColumns(sender As DataGridView)

            For Each column As DataGridViewColumn In sender.Columns
                If column.ValueType IsNot Nothing AndAlso column.ValueType.Name <> "ICollection`1" Then
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        End Sub
        ''' <summary>
        ''' Is current cell type a ComboBox
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Extension()>
        Public Function IsComboBoxCell(sender As DataGridViewCell) As Boolean

            Dim result As Boolean = False

            If sender.EditType IsNot Nothing Then
                If sender.EditType Is GetType(DataGridViewComboBoxEditingControl) Then
                    result = True
                End If
            End If

            Return result

        End Function
    End Module
End Namespace