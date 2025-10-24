int golsCorinthians;
int golsTime2;

Console.Write("Informe os gols do Corinthians: ");
golsCorinthians = int.Parse(Console.ReadLine());

Console.Write("Informe os gols do segundo time: ");
golsTime2 = int.Parse(Console.ReadLine());

if (golsCorinthians > golsTime2)
{
    Console.WriteLine("Vitória do Corinthians!");
}
else if (golsTime2 > golsCorinthians)
{
    Console.WriteLine("Vitória do segundo time!");
}
else
{
    Console.WriteLine("Empate!");
}
