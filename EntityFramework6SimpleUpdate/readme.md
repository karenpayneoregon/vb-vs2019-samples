# About 

.NET Framework 4.8, using Entity Framework 6, update a single record.

**Requires**

:heavy_check_mark: The following [script](https://gist.github.com/karenpayneoregon/40a6e1158ff29819286a39b7f1ed1ae8) to create/populate the database.

![img](assets/ConventionFramework.png) ![img](assets/sql-server.png)

![img](assets/entityframework_2.png)

```csharp
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
```

### Notes

Using Entity Framework Core is even easier while reverse engineering a database requires more work then with Entity Framework 6 with `VB.NET` but not `C#`.


