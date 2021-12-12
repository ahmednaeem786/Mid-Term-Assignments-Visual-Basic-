Module Module1

    Sub Main()
        Dim numberofdonuts As Integer

        numberofdonuts = 0

        Console.Write("how many donuts do you require ")
        numberofdonuts = Console.ReadLine

        If numberofdonuts >= 10 Then
            Console.WriteLine("Numebr Of Donuts are many")
        Else
            Console.WriteLine("Number of donuts: " & numberofdonuts)

        End If



        Console.ReadKey()
    End Sub

End Module
