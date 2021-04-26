﻿Imports System.ComponentModel

Public Class AppSettings
    <Category("Main"), DisplayName("About"), Description("Some text to say about this property")>
    Public Property Description() As String
    <Category("Section 1"), Description("Priority of something")>
    Public Property Priority() As Priority
    <Category("Section 2"), Description("Person name")>
    Public Property Assigned() As String
    <Description("Name of the thing")>
    Public Property Name() As String

    <Description("Whether activated or not")>
    Public Property Activated() As Boolean

    <Description("Rank of the thing")>
    Public Property Rank() As Integer

    <Description("extra free-form attributes on this thing.")> <Editor("System.Windows.Forms.Design.StringCollectionEditor," & "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
                                                                       GetType(Drawing.Design.UITypeEditor))>
    <TypeConverter(GetType(MyConverter))>
    Public ReadOnly Property ExtraStuff() As List(Of String)
        Get
            If _attributes Is Nothing Then
                _attributes = New List(Of String)()
            End If
            Return _attributes
        End Get
    End Property
    Private _attributes As List(Of String)
    Private _formatString As String

    <TypeConverter(GetType(FormatStringConverter))>
    Public Property Names() As String
        Get
            Return _formatString
        End Get
        Set(ByVal value As String)
            _formatString = value
        End Set
    End Property
End Class