Public Class AdminForm
    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.ExitThread()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomersTableAdapter.Fill(Me.AppDataSet.Customers)
        Text = $"User Role: {My.Application.UserRole}"
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) _
        Handles CustomersBindingNavigatorSaveItem.Click

        Validate()

        CustomersBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(Me.AppDataSet)

    End Sub
End Class