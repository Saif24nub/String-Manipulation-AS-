Module Module1

    Sub Main()

        Dim STR1, STR2 As String

        STR1 = ""
        STR2 = ""

        Console.WriteLine("ENTER STRING: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)

        If Right(STR1, 3) = "ING" Then
            Console.WriteLine("PROCESSED STRING IS:" & STR1 & "LY")
        ElseIf Len(STR1) >= 3 Then
            Console.WriteLine("PROCESSED STRING IS:" & STR1 & "ING")
        Else
            Console.WriteLine("PROCESSED STRING IS:" & STR1)

        End If
        Console.ReadKey()
    End Sub

End Module
