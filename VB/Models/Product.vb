Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ComponentModel.DataAnnotations

Public Class Product
    Private privateID As Integer
    <Required()> _
    Public Property ID() As Integer
        Get
            Return privateID
        End Get
        Set(ByVal value As Integer)
            privateID = value
        End Set
    End Property

    Private privateName As String
    <Required(), StringLength(100, MinimumLength:=10)> _
    Public Property Name() As String
        Get
            Return privateName
        End Get
        Set(ByVal value As String)
            privateName = value
        End Set
    End Property
End Class