Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim char3 As Char
        Dim i As Integer

        str1 = ""
        char1 = ""
        char2 = ""
        str2 = ""
        i = 0

        Console.Write("Please Enter String To Process: ")
        str1 = Console.ReadLine

        Console.Write("Please enter the character you need to replace: ")
        char1 = Console.ReadLine

        Console.Write("Please enter the character which WILL replace: ")
        char2 = Console.ReadLine

        For i = 1 To Len(str1)
            char3 = Mid(str1, i, 1)
            If char1 <> char3 Then
                str2 = str2 + char3
            Else
                str2 = str2 + char2
            End If
        Next i


        Console.WriteLine("Processed string is " & str2)

        Console.ReadKey()


    End Sub

End Module
