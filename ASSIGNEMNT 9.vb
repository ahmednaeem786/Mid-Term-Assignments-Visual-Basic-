Module Module1

    Sub Main()
        Dim str1, str2, str11, str22 As String

        Dim i As Integer
        str1 = ""
        str2 = ""
        str11 = ""
        str22 = ""
        i = 0

        Console.WriteLine("Please Enter String 1: ")
        str1 = Console.ReadLine

        Console.WriteLine("Please Enter String 2: ")
        str2 = Console.ReadLine

        str11 = Left(str1, 2)
        str22 = Left(str2, 2)

        
        Console.WriteLine(str22 & Mid(str1, 3, Len(str1)) & " " & str11 & Mid(str2, 3, Len(str2)))



            Console.ReadKey()
    End Sub

End Module
