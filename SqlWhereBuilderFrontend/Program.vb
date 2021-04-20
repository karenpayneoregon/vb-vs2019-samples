Imports System
Imports System.Data
Imports SqlHelpers

Module Program
    Sub Main(args As String())
        Dim contacts = New List(Of String) From {"Assistant Sales Agent", "Owner"}
        Examples.ReadCustomersByContactType(contacts)
        Console.ReadLine()
    End Sub
End Module

Public Class Examples
    Private Shared ConnectionStringWorks As String =
                       "Data Source=.\SQLEXPRESS;" &
                       "Initial Catalog=NorthWind2020;" &
                       "Integrated Security=True"
    Public Shared Function ReadCustomersByContactType(pContactTitleList As List(Of String)) As DataTable

        'mHasException = False

        ' field which the WHERE IN will use
        Dim parameterPrefix = "CT.ContactTitle"

        ' Base SELECT Statement
        Dim selectStatement =
                <SQL>
            SELECT C.CustomerIdentifier ,
                   C.CompanyName ,
                   Contacts.FirstName + ' ' + Contacts.LastName AS ContactName, 
                   C.ContactTypeIdentifier ,
                   FORMAT(C.ModifiedDate, 'MM-dd-yyyy', 'en-US') AS ModifiedDate,
                   CT.ContactTitle
            FROM   dbo.Customers AS C
            INNER JOIN dbo.ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier
            INNER JOIN dbo.Contacts ON C.ContactId = Contacts.ContactId  AND CT.ContactTypeIdentifier = Contacts.ContactTypeIdentifier 
            WHERE <%= parameterPrefix %> IN ({0})
            ORDER BY C.CompanyName
            </SQL>.Value

        ' Builds the SELECT statement minus values
        Dim CommandText = BuildWhereInClause(selectStatement, parameterPrefix, pContactTitleList)

        Dim dt As New DataTable

        Using cn As New SqlClient.SqlConnection With {.ConnectionString = ConnectionStringWorks}

            Using cmd As New SqlClient.SqlCommand With {.Connection = cn}

                cmd.CommandText = CommandText

                '
                ' Add values for command parameters
                '
                cmd.AddParamsToCommand(parameterPrefix, pContactTitleList)

                Try
                    cn.Open()

                    dt.Load(cmd.ExecuteReader)

                Catch ex As Exception
                    Console.WriteLine()
                    'mHasException = True
                    'mLastException = ex
                End Try

            End Using
        End Using

        Return dt

    End Function
End Class
