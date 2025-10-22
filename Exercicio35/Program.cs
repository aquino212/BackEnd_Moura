Console.Write("Digite o número de repetições: ");
int x = int.Parse(Console.ReadLine());

int contador = 1;

while (contador <= x)
{
    Console.WriteLine();
    Console.WriteLine($"Repetição {contador}:");

    Console.Write("Digite o primeiro número: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
        Console.WriteLine($"O maior número é: {n1}");
    else if (n2 > n1)
        Console.WriteLine($"O maior número é: {n2}");
    else
        Console.WriteLine("Você sabe que os dois são iguais.");

    contador++;
}



