Imports System.Data.Entity

Public Class DataOperations

    Public Shared Function Update(pContact As Contact) As Boolean

        Using context As New NorthWindContext

            Dim contact = context.Contacts.Find(pContact.ContactId)

            If contact IsNot Nothing Then

                contact.FirstName = pContact.FirstName
                contact.LastName = pContact.LastName

                context.Entry(contact).State = EntityState.Modified

                Return context.SaveChanges() = 1

            Else
                Return False
            End If
        End Using

    End Function

End Class

