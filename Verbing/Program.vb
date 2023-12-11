Imports System

Module Program
    Sub Main()
        Dim str1, a, b, c As String

        str1 = ""
        a = "ing"
        b = "ly"
        c = ""

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine

        If Len(str1) >= 3 Then
            If Right(str1, 3) = a Then
                c = Mid(str1, 1, 3) & b
            Else
                c = str1 & a
            End If
        Else
            c = str1
        End If
        Console.WriteLine(c)
        Console.ReadKey()

    End Sub
End Module
