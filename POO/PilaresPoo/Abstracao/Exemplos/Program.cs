using Exemplos;

Console.Clear();

ContaCorrente cc = new ContaCorrente(10);
System.Console.WriteLine($"Saldo inicial da conta: {cc.Saldo}");
cc.Depositar(0.5);
System.Console.WriteLine($"Saldo após depósito: R${cc.Saldo}");
cc.Sacar(10.01);
System.Console.WriteLine($"Saldo após saque: R${cc.Saldo}");

ContaCorrente cp = new ContaPoupanca(10);
System.Console.WriteLine($"Saldo inicial da conta: {cc.Saldo}");
cp.Depositar(0.5);
System.Console.WriteLine($"Saldo após depósito: R${cc.Saldo}");
cp.Sacar(10.01);
System.Console.WriteLine($"Saldo após saque: R${cc.Saldo}");