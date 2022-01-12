Module Module1

    Sub Main()

        Dim DONUTS As Integer

        DONUTS = 0

        Console.WriteLine("ENTER NUMBER OF DONUTS:")
        DONUTS = Console.ReadLine

        If DONUTS >= 10 Then
            Console.WriteLine("MANY")
        Else
            Console.WriteLine("NUMBER OF DONUTS:" & DONUTS)

        End If

        Console.ReadKey()


    End Sub

End Module
