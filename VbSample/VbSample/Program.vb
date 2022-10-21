Imports System

Module Program
    Sub Main(args As String())
        'CallingFunctions()
        Dim objSample As New SampleClass()
        objSample.StringProperty = "Vb like english"
        objSample.PrintSomeValue()
        Dim value As String = objSample.GetSomeValue()
        Console.WriteLine("value: " + value)

        Dim objRectangle As New Rectangle()
        Dim drawn As String = objRectangle.Draw()
        objRectangle.Display()
        Console.WriteLine(drawn)

    End Sub

    Private Sub CallingFunctions()
        Add()
        Subtract(500, 200)
        Multiply(25, 25)
        Divide(25, 5)
        Dim names As List(Of String) = ReturnNames()
        For index = 0 To names.Count - 1
            Console.WriteLine(names(index))
        Next
    End Sub

    Private Function ReturnNames() As List(Of String)
        Dim strNames As New List(Of String)
        strNames.Add("EEna")
        strNames.Add("MEEna")
        strNames.Add("DEEka")
        Return strNames
    End Function

    Private Sub Divide(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 / v2)
    End Sub

    Private Sub Multiply(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 * v2)
    End Sub

    Private Sub Subtract(v1 As Integer, v2 As Integer)
        Console.WriteLine(v1 - v2)
    End Sub

    Private Sub Add()
        Dim n1 As Integer = 100
        Dim n2 As Integer = 100
        Dim result As Integer = n1 + n2
        Console.WriteLine(result)
    End Sub
End Module
