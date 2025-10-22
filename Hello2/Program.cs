string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("Olá, qual é o seu nome?");
nome = Console.Readline();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.Readline();

Console.WriteLine("Qual é a sua idade?");
idade = int.Parse(Console.Readline());

Console.WriteLine("Qual é o saldo bancário?");
saldoBancario = float.Parse(Console.Readline());

Console.WriteLine("Quanto foi seu investimento?");
investimentos = float.Parse(Console.Readline());

Console.Clear();
Sonsole.WriteLine($"Nome: {nome} {sobrenomeDoFulano}");
Sonsole.WriteLine($"Idade do {nome} é {idade}");
Sonsole.WriteLine($"Saldo Bancário: {saldoBancario}");
Sonsole.WriteLine($"Investimento este ano: R${investimentos}");