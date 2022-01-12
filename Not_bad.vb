Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim Count, NotPos, BadPos As Integer
        Dim ThisChar As Char

        str1 = ""
        str2 = ""
        ThisChar = ""
        Count = 0
        BadPos = 0
        NotPos = 0

        Console.Write("Enter a string: ")
        str1 = LCase(Console.ReadLine())

        NotPos = InStr(str1, "not")
        If NotPos = 0 Then
            Console.Write("String does not contain the word 'not' ")
            Console.ReadKey()
            End
        Else
            BadPos = InStr(str1, "bad")
            If BadPos = 0 Then
                Console.Write("String does not contain the word 'bad' ")
                Console.ReadKey()
                End

            ElseIf NotPos > BadPos Then
                Console.Write("String Unchanged: " & str1)
            End If
        End If

        If NotPos < BadPos Then
            For Count = 1 To Len(str1)
                ThisChar = Mid(str1, Count, 1)

                If Count = NotPos Then
                    str2 = str2 + "good"
                    Count = BadPos + 3
                Else
                    str2 = str2 + ThisChar
                End If
            Next
            Console.Write("The processed string is: " & str2)
        End If

        Console.ReadKey()
    End Sub

End Module
