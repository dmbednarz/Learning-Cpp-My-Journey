Module Module1

    Sub Main()

        Dim name As String = "Daniel Bednarz"

        Dim nameArray() As Char = name.ToCharArray()



        Console.WriteLine("My Name is Daniel Bednarz")
        Array.Reverse(nameArray)
        Console.Write("My name backwards is : ")

        For Each item As String In nameArray
            Console.Write(item)
        Next
        Console.ReadLine()


    End Sub

End Module
