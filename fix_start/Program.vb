Imports System

Module Program
    Sub Main()
        Dim str1 As String
        Dim str2, char1 As Char

        str1 = ""

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine

        str2 = Left(str1, 1)
        Console.Write(str2)

        For count = 1 To Len(str1) - 1
            char1 = Mid(str1, (count + 1), 1)
            If char1 = str2 Then
                char1 = "*"
            End If
            Console.Write(char1)
        Next
        Console.ReadKey()
    End Sub
End Module
