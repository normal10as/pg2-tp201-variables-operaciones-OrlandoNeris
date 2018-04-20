Module _1_6

    Sub main()

        Dim A As Byte = 1
        Dim B As Byte = 5
        Dim C As Byte = 2
        Dim x As Integer

        x = (B ^ 2 - 4 * A * C) / 2 * A
        Console.WriteLine("El resultado es : {0}", x)
        Console.ReadKey()


    End Sub

End Module
