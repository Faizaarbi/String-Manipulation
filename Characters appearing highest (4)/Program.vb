Imports System

Module Program
    Sub Main()
        Dim str1 As String
        Dim x, i, highest, count As Integer
        Dim char1, char2, char3 As Char

        str1 = ""
        x = 0
        highest = 0
        count = 0
        char1 = ""
        char2 = ""

        Console.WriteLine("Enter a string:")
        str1 = Console.ReadLine


        For x = 1 To Len(str1)
            char1 = Mid(str1, x, 1)
            count = 0
            For i = 1 To Len(str1)
                char2 = Mid(str1, i, 1)
                If char2 = char1 Then
                    count = count + 1
                End If

            Next

            If count > highest Then
                highest = count
                char3 = char1
            End If
        Next
        Console.WriteLine(char3 & " appeared " & highest & " number of times.")
        Console.ReadKey()

    End Sub
End Module
