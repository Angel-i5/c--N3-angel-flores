// See https://aka.ms/new-console-template for more information


using System;


    
        Console.WriteLine("Ingrese el inicio del rango:");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el fin del rango:");
        int fin = int.Parse(Console.ReadLine());

List<int> primosEncontrados = new List<int>();

        for (int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
            {
                primosEncontrados.Add(i);
            }
        }
Console.WriteLine($"Números primos encontrados entre {inicio} y {fin}:");
        foreach (int primo in primosEncontrados)
        {
            Console.Write(primo + ",");
        };
     
    

     bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        if (numero == 2)
        {
            return true;
        }

        if (numero % 2 == 0)
        {
            return false;
        }

     
        int limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    };









