Module Module1

    Sub Main()
        Dim str1 As String
        Dim i As Integer
        Dim char1 As Char
        Dim char2 As Char
        Dim char3 As Char
        Dim digitcount As Integer
        Dim alphacount As Integer
        Dim specialcount As Integer
        Dim characterposition As Integer


        str1 = ""
        i = 0
        char1 = ""
        char2 = ""
        char3 = ""
        digitcount = 0
        alphacount = 0
        specialcount = 0


        Console.Write("Please Enter String which is to be processed: ")
        str1 = Console.ReadLine

        Console.Write("Please Enter Character which needs to be counted: ")
        char1 = Console.ReadLine

        str1 = UCase(str1)
        char1 = UCase(char1)

        For i = 1 To Len(str1)
            char3 = Mid(str1, i, 1)
            If char3 = char1 Then
                characterposition = characterposition + 1

            End If

        Next

        For i = 1 To Len(str1)
            char2 = Mid(str1, i, 1)
            If char2 >= "A" And char2 <= "Z" Then
                alphacount = alphacount + 1
            ElseIf char2 >= "0" And char2 <= "9" Then
                digitcount = digitcount + 1
            Else : specialcount = specialcount + 1
            End If



        Next

        Console.WriteLine("Number Of Alphabets Are: " & alphacount)
        Console.WriteLine("Number Of Digits Are: " & digitcount)
        Console.WriteLine("Number Of special characters Are: " & specialcount)
        Console.WriteLine("Number Of Times your enter character occured was : " & characterposition)






        Console.ReadKey()

















    End Sub

End Module
