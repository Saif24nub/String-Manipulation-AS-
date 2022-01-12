Module Module1

    Sub Main()
        Dim STR1 As String
        Dim CHAR1 As Char
        Dim VOWELCOUNT, X As Integer

        STR1 = " "
        CHAR1 = " "
        VOWELCOUNT = 0
        X = 0

        Console.WriteLine("ENTER A STRING: ")
        STR1 = Console.ReadLine

        STR1 = UCase(STR1)

        For X = 1 To Len(STR1)
            THISCHAR = Mid(STR1, X, 1)

            Select Case CHAR1
                Case "A" : VOWELCOUNT = VOWEL + 1
                Case "E" : VOWELCOUNT = VOWEL + 1
                Case "I" : VOWELCOUNT = VOWELCOUNT + 1
                Case "O" : VOWELCOUNT = VOWELCOUNT + 1
                Case "U" : VOWELCOUNT = VOWELCOUNT + 1

            End Select



        Next

        Console.WriteLine("VOWEL COUNTED ARE: " & VOWELCOUNT)
        Console.ReadKey()


    End Sub

End Module
