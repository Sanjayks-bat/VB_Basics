﻿Public Class SampleClass
    Private strProperty As String
    Public Property StringProperty() As String
        Get
            Return strProperty
        End Get
        Set(ByVal value As String)
            strProperty = value
        End Set
    End Property

    Public Function GetSomeValue() As String
        Return "A new Vb Function"
    End Function

    Public Sub PrintSomeValue()
        Console.WriteLine("Printing values from sample class")
    End Sub
End Class
