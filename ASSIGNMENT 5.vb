Module Module1

    Sub Main()
        'Finding Vowels In A String

        Dim str1 As String
        Dim i, vowelscounter As Integer
        Dim char1 As Char
        Dim acounter, ecounter, icounter, ocounter, ucounter As Integer


        str1 = ""
        char1 = ""
        i = 0
        vowelscounter = 0
        acounter = 0
        ecounter = 0
        icounter = 0
        ocounter = 0
        ucounter = 0


        Console.Write("Please Enter String Which Is To Be Processed: ")
        str1 = Console.ReadLine


        For i = 1 To Len(str1)
            char1 = Mid(str1, i, 1)
            char1 = UCase(char1)
            If char1 = "A" Then
                vowelscounter = vowelscounter + 1
                acounter = acounter + 1
            ElseIf char1 = "E" Then
                ecounter = ecounter + 1
                vowelscounter = vowelscounter + 1
            ElseIf char1 = "I" Then
                icounter = icounter + 1
                vowelscounter = vowelscounter + 1
            ElseIf char1 = "O" Then
                ocounter = ocounter + 1
                vowelscounter = vowelscounter + 1
            ElseIf char1 = "U" Then
                ucounter = ucounter + 1
                vowelscounter = vowelscounter + 1
            End If


        Next i

        Console.WriteLine("Vowels In String Are: " & vowelscounter)
        Console.WriteLine("Number Of A's are: " & acounter)
        Console.WriteLine("Number Of E's are: " & ecounter)
        Console.WriteLine("Number Of I's are: " & icounter)
        Console.WriteLine("Number Of O's are: " & ocounter)
        Console.WriteLine("Number Of U's are: " & ucounter)



        Console.ReadKey()
    End Sub

End Module
