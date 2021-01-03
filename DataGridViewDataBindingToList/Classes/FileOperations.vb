Imports System.IO
Imports System.Text

Namespace Classes
    Public Class FileOperations

        ''' <summary>
        ''' Uses File.ReadAllLines in tangent with a ValueTuple where the return types
        ''' are a List(Of Customer) and Nothing is the read was successful while if there
        ''' was an error the List may be empty or have several customers along with the exception
        ''' object which throw the exception e.g. file missing, incorrect column count, conversion
        ''' issue.
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadCustomerFile(
             fileName As String,
             countryList As List(Of Country)) As (List As List(Of Customer),
                 Exception As Exception)

            Dim customers = New List(Of Customer)()

            Try

                Dim lines = File.ReadAllLines(fileName)

                For Each line As String In lines

                    ' split line by comma
                    Dim lineParts = line.Split(","c)

                    ' must have six elements
                    If lineParts.Length <> 6 Then
                        Continue For
                    End If

                    ' for this code sample there are numbers in the last element,
                    ' in the wild there should be an assertion if the last element
                    ' is a valid integer.
                    Dim countryId = Convert.ToInt32(lineParts(5))

                    '
                    ' Get country name from country identifier
                    '
                    Dim currentCountryName = countryList.FirstOrDefault(Function(country) country.CountryIdentifier = countryId).Name

                    ' customer id must be an integer
                    Dim identifier As Integer = 0
                    If Not Integer.TryParse(lineParts(0), identifier) Then
                        Continue For
                    End If

                    customers.Add(New Customer() With {
                                     .CustomerIdentifier = identifier,
                                     .CompanyName = lineParts(1),
                                     .ContactName = lineParts(3),
                                     .ContactTitle = lineParts(2),
                                     .City = lineParts(4),
                                     .CountryIdentifier = countryId,
                                     .CountryName = currentCountryName
                                 })

                Next


            Catch ex As Exception
                Return (customers, ex)
            End Try

            Return (customers, Nothing)

        End Function
        Public Shared Sub SaveCustomers(fileName As String, customers As List(Of Customer))

            Dim sb As New StringBuilder

            Dim ordered = customers.OrderBy(Function(customer) customer.CustomerIdentifier).ToList()
            For Each customer As Customer In ordered
                sb.AppendLine(customer.ItemArray)
            Next

            File.WriteAllText(fileName, sb.ToString())

        End Sub
        ''' <summary>
        ''' Read country id and name into a strong type list of Country
        ''' </summary>
        ''' <param name="fileName"></param>
        ''' <returns></returns>
        Public Shared Function ReadCountries(fileName As String) As List(Of Country)

            Try

                Return File.ReadAllLines(fileName).Select(
                Function(country)
                    Dim linePart() As String

                    linePart = country.Split(","c)

                    Return New Country With {.CountryIdentifier = CInt(linePart(0)), .Name = linePart(1)}

                End Function).ToList()

            Catch ex As Exception
                Return New List(Of Country)
            End Try

        End Function

    End Class
End Namespace