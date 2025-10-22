Console.Write("Quantos números você quer digitar? ");
int qtdNumeros = int.Parse(Console.ReadLine());
string pares = "Pares:";
string impares = "Impares:";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}º número:");
    int numerosDigitado = int.Parse(Console.ReadLine());

    if (numerosDigitado % 2 == 0)
    {
        pares += numerosDigitado.ToString() + ",";
    }
    else
    {
        impares += numerosDigitado.ToString() + ",";
    }
}

Console.Clear();
Console.WriteLine($"RESULTADO:");
Console.WriteLine()
Console.WriteLine
Console.WriteLine













List<int> pares = new();
List<int> impares = new();

for (int i = 1; i <= quantidade; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
        pares.Add(numero);
    else
        impares.Add(numero);
}

Console.WriteLine();
Console.WriteLine("=== Números Pares ===");
if (pares.Count > 0)
    Console.WriteLine(string.Join(", ", pares));
else
    Console.WriteLine("Nenhum número par foi digitado.");

Console.WriteLine();
Console.WriteLine("=== Números Ímpares ===");
if (impares.Count > 0)
    Console.WriteLine(string.Join(", ", impares));
else
    Console.WriteLine("Nenhum número ímpar foi digitado.");
