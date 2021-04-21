Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class NorthWindContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=NorthWindConnection")
    End Sub

    Public Overridable Property Contacts As DbSet(Of Contact)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
