Imports System

Module Program
    Sub Main()
        Dim str1 As String
        Dim count, count1 As Integer
        Dim char1, char2 As Char

        str1 = ""
        count = 0
        count1 = 0
        char1 = ""
        char2 = ""

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine
        Console.WriteLine("Enter Character to count:")
        char1 = Console.ReadLine

        For count = 1 To Len(str1)
            char2 = Mid(str1, count, 1)
            If LCase(char2) = LCase(char1) Then
                count1 = count1 + 1
            End If
        Next
        Console.WriteLine(count1)
        Console.ReadKey()
    End Sub
End Module
