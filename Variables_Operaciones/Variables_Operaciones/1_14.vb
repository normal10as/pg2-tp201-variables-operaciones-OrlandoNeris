Module _1_14
    '   Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los
    '   siguientes valores en el momento de la ejecución: día del año, mes, hora y minuto
    Sub main()

        Console.WriteLine("Dia del año actual: " & Today.Day)
        Console.WriteLine("Mes del año: " & Today.Month)
        Console.WriteLine("Hora del dia: " & Today.Hour)
        Console.WriteLine("Minuto del dia: " & Today.Minute)

        Console.ReadKey()

    End Sub

End Module
