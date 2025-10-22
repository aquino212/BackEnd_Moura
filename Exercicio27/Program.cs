using System.Diagnostics.Contracts;

int qtdUsuario = 0;
int contador = 1;
Console.WriteLine("Quantos Numeros vc quer Digitar");
qtdUsuario = int.Parse(Console.ReadLine());

while (contador <= qtdUsuario)
{
    Console.WriteLine($"Digite Um Numero:");
    int batata = int.Parse(Console.ReadLine());
    if (batata % 2 == 0)
    {
        Console.WriteLine($"Numero Digitado eh Par: {batata}");
    } 
}