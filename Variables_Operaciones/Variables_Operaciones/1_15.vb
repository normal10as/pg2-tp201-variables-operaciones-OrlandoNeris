Module _1_15

    ' Crear un programa que lea separadamente un número de día (1 a 31) y una hora (0 a 24).
    ' Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla.
    Sub main()

        Dim dia As Integer = 31
        Dim hora As Integer = 15


        Dim fechahora As New Date(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)

        Console.WriteLine(fechahora)

        Console.ReadKey()



    End Sub

End Module
