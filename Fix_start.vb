Module Module1

    Sub Main()
        Dim STR1, STR2, STR3 As String
        Dim CHAR1, CHAR2 As Char
        Dim X As Integer

        X = 0
        STR1 = ""
        STR2 = ""
        STR3 = ""
        CHAR1 = ""
        CHAR2 = ""

        Console.WriteLine("ENTER A STRING: ")
        STR1 = Console.ReadLine
        STR1 = UCase(STR1)

        CHAR1 = Left(STR1, 1)
        STR2 = Right(STR1, Len(STR1) - 1)
        For X = 1 To Len(STR2)
            CHAR2 = Mid(STR2, X, 1)
            If CHAR2 = CHAR1 Then
                STR3 = STR3 & "*"
            Else
                STR3 = STR3 & CHAR2
            End If
        Next

        Console.Write("PROCESSED STRING IS: " & CHAR1 & STR3)
        Console.ReadKey()

    End Sub
End Module
