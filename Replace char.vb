Module Module1

    Sub Main()

        Dim STR1, STR2 As String
        Dim THISCHAR, CHAR1, CHAR2 As Char
        Dim X As Integer

        STR1 = " "

        STR1 = " "
        STR2 = " "
        THISCHAR = " "
        CHAR1 = " "
        CHAR2 = " "
        X = 0

        Console.WriteLine("ENTER THE STRING: ")
        STR1 = Console.ReadLine

        Console.WriteLine("ENTER THE CHARACTER TO REMOVE")
        CHAR1 = Console.ReadLine

        Console.WriteLine("ENTER THE  CHARACTER TO REPLACE WITH")
        CHAR2 = Console.ReadLine

        For X = 1 To Len(STR1)
            THISCHAR = Mid(STR1, X, 1)
            If THISCHAR = CHAR1 Then
                STR2 = STR2 & CHAR2
            Else
                STR2=STR2 & THISCHAR 
            End If
        Next

        Console.WriteLine("PROCESSED STRING IS: " & STR2)
        Console.ReadKey()

    End Sub

End Module
