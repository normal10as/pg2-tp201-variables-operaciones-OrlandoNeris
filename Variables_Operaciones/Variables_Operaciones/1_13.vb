Module _1_13

    Sub main()
        Dim valor As Integer
        Dim mayor As Integer

        Console.WriteLine("Ingrese primer valor: ")
        valor = Console.ReadLine
        mayor = valor

        Console.WriteLine("Ingrese segundo valor: ")
        valor = Console.ReadLine

        If valor > mayor Then
            mayor = valor
        End If

        Console.WriteLine("Ingrese tercer valor: ")
        valor = Console.ReadLine

        If valor > mayor Then
            mayor = valor
        End If

        Console.WriteLine("El mayor de los numeros ingresados es: " & mayor)
        Console.ReadKey()

    End Sub
End Module
