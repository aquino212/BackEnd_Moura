int lado1;
int lado2;
int lado3;

Console.Write("Informe o primeiro lado do triângulo: ");
lado1 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo lado do triângulo: ");
lado2 = int.Parse(Console.ReadLine());

Console.Write("Informe o terceiro lado do triângulo: ");
lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}
else
{
    if (lado1 == lado2 && lado1 != lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else if (lado1 == lado3 && lado1 != lado2)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else if (lado2 == lado3 && lado2 != lado1)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}

