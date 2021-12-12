Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim ing As String
        Dim ly As String
        Dim position As Integer

        position = 0

        str1 = ""
        ing = "ing"
        ly = "ly"

        Console.Write("Please Enter String To Process: ")
        str1 = Console.ReadLine

        str1 = LCase(str1)

        If Len(str1) >= 3 Then
            If Right(str1, 3) <> ing Then
                Console.Write(str1 & ing)
            ElseIf Right(str1, 3) = ing Then
                position = InStr(str1, ing)
                str2 = Left(str1, position - 1)
                Console.WriteLine(str2 & ly)


            End If
        Else : Console.Write(str1)

        End If




        Console.ReadKey()


    End Sub

End Module
