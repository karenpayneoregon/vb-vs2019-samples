Module Module1

    Sub Main()
        Dim contact As New Contact With {
                .ContactId = 2,
                .FirstName = "Ana",
                .LastName = "Trujillo"}

        Debug.WriteLine(DataOperations.Update(contact))

    End Sub

End Module
