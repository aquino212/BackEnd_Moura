using Construtores;
using MetodoConstrutores;

// Pessoa Ivan = new Pessoa("Ivan Aquino", 18);
// Pessoa Arthur = new Pessoa("Arthur Batista", 18);

// Ivan.ExibirDados();
// Arthur.ExibirDados();

// Pessoa rthur = new Pessoa($"Arthur", 18, "Gosta de morango");


//Carro AstonMartin = new Carro("Aston Martin", "Continental", 2013);



//System.Console.WriteLine($"O Carro Desejado é {AstonMartin.Marca} {AstonMartin.Modelo} {AstonMartin.Ano}");

 Aluno Ivan = new Aluno();
 Ivan.Nome = "Ivan";
Ivan.Nota = 8;
 Ivan.ExibirDados();

Aluno Arthur = new Aluno("Arthur", 10);
 Arthur.ExibirDados();

 Produto celular = new Produto("Sansung", 1700, 20);
 celular.ExibirDados();