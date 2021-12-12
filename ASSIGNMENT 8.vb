Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim char1, char2 As Char
        Dim i As Integer


        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        i = 0

        Console.Write("Please enter string to be processed: ")
        str1 = Console.ReadLine
        str1 = LCase(str1)
        char1 = Left(str1, 1)

        str2 = str2 & char1
        For i = 1 To Len(str1)
            char2 = Mid(str1, i + 1, 1)
            If char2 = char1 Then
                char2 = "*"

            End If

            str2 = str2 & char2


        Next
        Console.WriteLine("Output String is =" & str2)























        Console.ReadKey()
    End Sub

End Module
