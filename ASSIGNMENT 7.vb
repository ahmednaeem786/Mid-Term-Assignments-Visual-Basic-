Module Module1

    Sub Main()
        Dim i As Integer
        Dim str1 As String
        Dim str2 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim char3 As Char
        Dim char4 As Char


        i = 0
        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        char4 = ""


        Console.Write("Please Input a string which has >2 words: ")
        str1 = Console.ReadLine

        If Len(str1) > 2 Then
            char1 = Mid(str1, 1, 1)
            char2 = Mid(str1, 2, 1)

            char3 = Right(str1, 2)
            char4 = Right(str1, 1)


            Console.Write(char1 & char2 & char3 & char4)
        Else

            Console.WriteLine(str1)

        End If




        Console.ReadKey()
    End Sub

End Module
