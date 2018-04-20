Module _1_16

    'Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como
    'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada.

    Sub main()

        Dim fecha As Date = Today
        Dim diasadicionados As Integer = 54

        Console.WriteLine("La fecha ingresada es {0}", fecha)
        Console.WriteLine("La Cantidad de dias a agregar son {0}", diasadicionados)
        Console.WriteLine("La fecha final seria: {0}", fecha.AddDays(diasadicionados))

        Console.ReadKey()

    End Sub
End Module
