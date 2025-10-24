int quantidade;
double preco;
double total;

Console.Write("Informe o número de maçãs compradas: ");
quantidade = int.Parse(Console.ReadLine());

if (quantidade < 12)
{
    preco = 0.30;
}
else
{
    preco = 0.25;
}

total = quantidade * preco;

Console.WriteLine("Valor total da compra: R$ " + total);

