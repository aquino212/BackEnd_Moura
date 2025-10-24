double media;
double frequencia;

Console.Write("Informe a média do aluno: ");
media = double.Parse(Console.ReadLine());

Console.Write("Informe a frequência do aluno (%): ");
frequencia = double.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por falta");
}
else
{
    if (media >= 5)
    {
        Console.WriteLine("Aluno aprovado");
    }
    else if (media >= 4)
    {
        Console.WriteLine("Aluno em recuperação");
    }
    else
    {
        Console.WriteLine("Aluno reprovado por média");
    }
}
