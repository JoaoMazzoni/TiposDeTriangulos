﻿while (true)
{
    int lado1 = 0;
    int lado2 = 0;
    int lado3 = 0;

    do
    {
        Console.Write("Digite o lado 1 do triângulo: ");
        lado1 = int.Parse(Console.ReadLine());
        if (lado1 == 0 || lado1 < 0)
        {
            Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
            Console.WriteLine("-------------------------------------------------------------------\n");
        }
    } while (lado1 == 0 || lado1 < 0);


    do
    {
        Console.Write("Digite o lado 2 do triângulo: ");
        lado2 = int.Parse(Console.ReadLine());
        if (lado2 == 0 || lado2 < 0)
        {
            Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
            Console.WriteLine("-------------------------------------------------------------------\n");
        }
    } while (lado2 == 0 || lado2 < 0);


    do
    {
        Console.Write("Digite o lado 3 do triângulo: ");
        lado3 = int.Parse(Console.ReadLine());
        if (lado3 == 0 || lado3 < 0)
        {
            Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
            Console.WriteLine("-------------------------------------------------------------------\n");
        }
    } while (lado3 == 0 || lado3 < 0);

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("\n|O triângulo é equilátero.");
    }

    else if (lado1 == lado2 && lado2 != lado3)
    {
        Console.WriteLine("\n|O triângulo é isósceles.");
    }

    else
    {
        Console.WriteLine("\n|O triângulo é escaleno.");
    }

    Console.WriteLine("\n\nPressione qualquer tecla: ");
    Console.ReadKey();
    Console.Clear();

}