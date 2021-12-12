Module Module1

    Sub Main()
        Dim Str1, Str2, FN, LN As String
        Dim Space, Length As Integer

        Str1 = ""
        Str2 = ""
        FN = ""
        LN = ""
        Space = 0
        Length = 0

        Console.Write("Please Enter String 1: ")
        Str1 = Console.ReadLine

        Console.Write("Please Enter String 2: ")
        Str2 = Console.ReadLine

        Space = InStr(Str1, " ")
        FN = Left(Str1, Space - 1)

        Space = InStr(Str2, " ")
        Length = Len(Str2)
        LN = Right(Str2, Length - Space)

        Console.Write("Full New Name: " & FN & " " & LN)
        Console.ReadKey()

    End Sub

End Module
