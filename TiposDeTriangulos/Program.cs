while (true)
{
    float lado1 = 0;
    float lado2 = 0;
    float lado3 = 0;
    do
    {
        do
        {
            Console.Write("Digite o lado 1 do triângulo: ");
            lado1 = float.Parse(Console.ReadLine());
            if (lado1 == 0 || lado1 < 0)
            {
                Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
                Console.WriteLine("-------------------------------------------------------------------\n");
            }
        } while (lado1 == 0 || lado1 < 0);


        do
        {
            Console.Write("Digite o lado 2 do triângulo: ");
            lado2 = float.Parse(Console.ReadLine());
            if (lado2 == 0 || lado2 < 0)
            {
                Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
                Console.WriteLine("-------------------------------------------------------------------\n");
            }
        } while (lado2 == 0 || lado2 < 0);


        do
        {
            Console.Write("Digite o lado 3 do triângulo: ");
            lado3 = float.Parse(Console.ReadLine());
            if (lado3 == 0 || lado3 < 0)
            {
                Console.WriteLine("\n|O lado de um triângulo não pode ser menor ou igual a zero!");
                Console.WriteLine("-------------------------------------------------------------------\n");
            }
        } while (lado3 == 0 || lado3 < 0);

        if(lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2)
        {
            Console.WriteLine("\nOs valores informados não formam um triângulo.");
            Console.WriteLine("----------------------------------------------------\n\n");
        }

    } while (lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2);

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