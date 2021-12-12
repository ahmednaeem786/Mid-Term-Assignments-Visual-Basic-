Module Module1

    Sub Main()
        ' Find the character that appears most number of times in an
        ' entered string and output it.

        Dim str1 As String
        Dim char1 As Char
        Dim char2 As Char
        Dim char3 As Char
        Dim highest As Integer
        Dim countoccur As Integer
        Dim i As Integer
        Dim j As Integer


        str1 = ""
        char1 = ""
        i = 0
        char2 = ""
        char3 = ""
        highest = 0
        j = 0


        Console.Write("Please Enter String: ")
        str1 = Console.ReadLine

        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            countoccur = 0

        Next
        For j = 1 To Len(str1)
            char2 = Mid(str1, j, 1)
            If char2 = char1 Then countoccur = countoccur + 1

        Next

        If countoccur > highest Then
            highest = countoccur
            char3 = char1
        End If


        Console.WriteLine("This character Appeared: " & char1)
        Console.WriteLine(countoccur & " number of times")




        Console.ReadKey()
    End Sub

End Module
