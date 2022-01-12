Module Module1

    Sub Main()
        Dim STR1, STR2 As String
        Dim A, B, C, D, E As String

        STR1 = ""
        STR2 = ""
        A = ""
        C = ""
        D = ""
        E = ""

        Console.WriteLine("ENTER FIRST STRING: ")
        STR1 = Console.ReadLine

        Console.WriteLine("ENTER SECOND STRING: ")
        STR2 = Console.ReadLine

        A = Left(STR1, 2)
        B = Left(STR2, 2)
        C = Right(STR1, Len(STR1) - 2)
        D = Right(STR2, Len(STR2) - 2)
        E = B + C + " " + A + D

        Console.WriteLine("PROCESSED STRING IS: " + E)
        Console.ReadKey()

    End Sub

End Module
