Module Module1

    Sub Main()
        Dim str1 As String
        Dim notstr, badstr As String
        Dim notposition, badposition As Integer


        str1 = ""
        notstr = "not"
        badstr = "bad"
        notposition = 0
        badposition = 0

        Console.Write("Please enter string to be processed; ")
        str1 = Console.ReadLine

        notposition = InStr(str1, notstr)
        badposition = InStr(str1, badstr)

        If badposition > notposition Then
            Console.Write("Processed String Is: " & Left(str1, notposition - 1) & "good" & Mid(str1, badposition + 3, Len(str1)))
        End If



        Console.ReadKey()
    End Sub

End Module
