Module _1_10

    Sub main()

        Dim monto As Integer
        Dim interesanual As Single = 0.25
        Dim diasinvertidos As Integer
        Dim interes As Single

        Console.WriteLine("Ingrese monto a calcular: ")
        monto = Console.ReadLine
        Console.WriteLine("Ingrese cantidad de dias a calcular: ")
        diasinvertidos = Console.ReadLine

        interes = (interesanual * diasinvertidos * monto) / 360

        Console.WriteLine("El interes producido es de: {0}", interes)
        Console.WriteLine("El monto + interes es de: {0}", monto + interes)
        Console.ReadKey()

    End Sub
End Module
