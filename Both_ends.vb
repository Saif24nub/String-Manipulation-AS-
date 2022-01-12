Module Module1

    Sub Main()
        Dim STR1, STR2, CHAR1, CHAR2 As String
        STR1 = ""
        STR2 = ""
        CHAR1 = ""
        CHAR2 = ""


        Console.WriteLine("ENTER A STRING: ")
        STR1 = Console.ReadLine

        If Len(STR1) > 2 Then
            CHAR1 = Left(STR1, 2)
            CHAR2 = Right(STR1, 2)
            STR2 = CHAR1 + CHAR2

            Console.WriteLine("PROCESSED STRING IS: " & STR2)

        Else
            Console.WriteLine("Output:" & STR1)

        End If

        Console.ReadKey()

    End Sub

End Module
