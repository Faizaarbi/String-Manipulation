Imports System

Module Program
    Sub Main()
        Dim str1, str2, char3 As String
        Dim char1, char2 As Char

        str1 = ""
        str2 = ""
        char3 = ""
        char1 = ""
        char2 = ""

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine
        Console.WriteLine("Enter character to replace:")
        char1 = Console.ReadLine()
        Console.WriteLine("Enter character to replace with:")
        char2 = Console.ReadLine

        For x = 1 To Len(str1)
            char3 = Mid(str1, x, 1)
            If char3 = char1 Then
                char3 = char2
            End If
            str2 = str2 & char3
        Next

        Console.WriteLine("New String:" & str2)
        Console.ReadKey()

    End Sub
End Module
