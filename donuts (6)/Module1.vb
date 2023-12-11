Module Module1

    Sub Main()
        Dim count As Integer

        count = 0

        Console.WriteLine("Number of donuts:")
        count = Console.ReadLine

        If count >= 10 Then
            Console.WriteLine("Number of donuts : Many")
        Else
            Console.WriteLine("Number of donuts:" & count)
        End If
        Console.ReadKey()

    End Sub

End Module
