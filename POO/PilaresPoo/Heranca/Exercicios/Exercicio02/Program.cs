using Exercicio02;

Funcionario funcionario = new Funcionario();
funcionario.Nome = "Ivan";
funcionario.SalarioBase = 15000;

Gerente gerente = new Gerente();
gerente.Nome = "Alexia";
gerente.SalarioBase = 50000;
gerente.BonusAd = 11000;

Console.WriteLine("=== Salários ===");
Console.WriteLine($"{funcionario.Nome}");
Console.WriteLine($"{gerente.Nome}");

