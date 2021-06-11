Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New Object() {"CountMe"})
        DataGridView1.Rows.Add(New Object() {"CountMe"})
        DataGridView1.Rows.Add(New Object() {"Other"})
        DataGridView1.Rows.Add(New Object() {"CountMe"})
        DataGridView1.Rows.Add(New Object() {"CountMe"})
        DataGridView1.Rows.Add(New Object() {"CountMe"})
        DataGridView1.Rows.Add(New Object() {"Other"})
    End Sub

    Private Sub CountButton_Click(sender As Object, e As EventArgs) Handles CountButton.Click
        Dim valueToFind = "CountMe"
        Dim count = DataGridView1.Rows.OfType(Of DataGridViewRow).
                Count(Function(row)
                          Return Not row.IsNewRow AndAlso
                                 String.Compare(CStr(row.Cells("Column1").Value), valueToFind,
                                                StringComparison.InvariantCultureIgnoreCase) = 0
                      End Function)

        CountLabel.Text = count.ToString()

        If (count > 0) Then
            MessageBox.Show("Exist!")
        Else
            MessageBox.Show("Nothing here!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim someArray As String() = {"1", "2", "3", "4", "5"}
        For rowIndex As Integer = 0 To DataGridView1.RowCount - 1

            If rowIndex <= someArray.Length - 1 Then
                DataGridView1.Rows(rowIndex).Cells("Column1").Value = someArray(rowIndex)
                Console.WriteLine(DataGridView1.Rows(rowIndex).Cells("Column1").Value)

            End If
        Next
    End Sub
End Class
