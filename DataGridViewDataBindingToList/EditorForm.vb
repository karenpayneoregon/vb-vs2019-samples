Imports DataGridViewDataBindingToList.Classes
''' <summary>
''' Basic edit customer with no validating
''' </summary>
Public Class EditorForm
    Private ReadOnly _currentCustomer As Customer
    Public ReadOnly Property Customer() As Customer
        Get
            Return _currentCustomer
        End Get
    End Property
    ''' <summary>
    ''' Setup data binding to current customer in parent DataGridView
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <param name="countryList"></param>
    Public Sub New(customer As Customer, countryList As List(Of Country))
        InitializeComponent()

        _currentCustomer = customer

        CompanyNameTextBox.DataBindings.Add("Text", _currentCustomer, "CompanyName")
        CityTextBox.DataBindings.Add("Text", _currentCustomer, "City")

        CountryComboBox.DataSource = countryList
        CountryComboBox.SelectedIndex = CountryComboBox.FindString(_currentCustomer.CountryName)

        TitleTextBox.DataBindings.Add("Text", _currentCustomer, "ContactTitle")
        ContactNameTextBox.DataBindings.Add("Text", _currentCustomer, "ContactName")

    End Sub

    Private Sub EditorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CompanyNameTextBox.SelectionLength = 0
    End Sub
    ''' <summary>
    ''' Update customer country information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        _currentCustomer.CountryIdentifier = CType(CountryComboBox.SelectedItem, Country).CountryIdentifier
        _currentCustomer.CountryName = CType(CountryComboBox.SelectedItem, Country).Name
    End Sub
End Class