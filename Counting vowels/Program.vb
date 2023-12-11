Imports System

Module Program
    Sub Main()
        Dim str1, vowels As String
        Dim vchar, char1 As Char
        Dim count, vcount As Integer

        vowels = "AaEeIiOoUu"
        str1 = ""
        vcount = 0

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine

        For count = 1 To Len(vowels)
            vchar = Mid(vowels, count, 1)
            For count1 = 1 To Len(str1)
                char1 = Mid(str1, count1, 1)
                If char1 = vchar Then
                    vcount = vcount + 1
                End If
            Next
        Next

        Console.WriteLine("The total number of vowels are " & vcount)
        Console.ReadKey()
    End Sub
End Module
