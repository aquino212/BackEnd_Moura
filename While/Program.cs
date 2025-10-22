int contador = 1;

Console.WriteLine($"Quantas vezes vc quer rodar o while?");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= qtdVezes)
{
    Console.WriteLine($"Contador é: {contador}");
    Thread.Sleep(10000);
    contador++;
}

