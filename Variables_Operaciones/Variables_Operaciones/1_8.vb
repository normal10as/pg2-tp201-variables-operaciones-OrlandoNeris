Module _1_8


    Sub main()

        Const Diasdelaño As UShort = 365
        Const DiasdelaSemana As UShort = 7
        Const DiasLaborales As UShort = 5

        Console.WriteLine("Cantidad de semanas en un año: {0}", Diasdelaño / DiasdelaSemana)
        Console.WriteLine("Cantidad de semanas laborables en el año: {0}", Diasdelaño / DiasLaborales)

        Console.ReadKey()

    End Sub
End Module
