Imports System.Collections.Specialized
Imports ChangeCursorDragDrop.Classes

Class MainWindow
    ''' <summary>
    ''' Start drag operation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Label_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)

        '
        ' CType(e.Source, Label).Content has the text for this label
        '
        Dim data As New DataObject(DataFormats.Text, CType(e.Source, Label).Content)

        DragDrop.DoDragDrop(CType(e.Source, DependencyObject), data, DragDropEffects.Copy)

    End Sub
    ''' <summary>
    ''' End drag operation, determine if the drop has files or text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Label_Drop(sender As Object, e As DragEventArgs)


        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim dataObject = CType(e.Data, DataObject)

            Dim fileNames As StringCollection = dataObject.GetFileDropList()
            Operations.IterateFiles(fileNames)
            'Operations.Inspect(fileNames)

            CType(e.Source, Label).Content = $"Count: {fileNames.Count}"

        ElseIf e.Data.GetDataPresent(DataFormats.Text) Then
            CType(e.Source, Label).Content = CStr(e.Data.GetData(DataFormats.Text))
        End If

    End Sub

    Private _customCursor As Cursor = Nothing

    Private Sub Label_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs)

        If e.Effects = DragDropEffects.Copy Then

            '
            ' Create cursor if not created yet (first time)
            '
            If _customCursor Is Nothing Then

                _customCursor = CursorHelper.CreateDropLabelCursorFromImage()

            End If

            '
            ' Set cursor
            '
            If _customCursor IsNot Nothing Then
                e.UseDefaultCursors = False
                Mouse.SetCursor(_customCursor)
            End If

        Else
            e.UseDefaultCursors = True
        End If

        e.Handled = True

    End Sub

End Class
