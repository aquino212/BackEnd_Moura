using ExercicioPolimorfismo;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 2300;
float valorPagar = compraPix.CalcularTotal();
System.Console.WriteLine($"Produto: Smartphone");
System.Console.WriteLine($"Preço: {compraPix.ValorCompra}");
System.Console.WriteLine($"Pagamento com desconto: {valorPagar}");

System.Console.WriteLine();

PagamentoCartao comprarCartao = new PagamentoCartao();
comprarCartao.ValorCompra = 50;

System.Console.WriteLine($"Produto: Caneca");
System.Console.WriteLine($"Preço: {compraPix.ValorCompra}");
System.Console.WriteLine($"Pagamento com acréscimo: {valorCartao.CalcularTotal()}");
