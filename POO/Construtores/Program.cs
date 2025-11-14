using Construtores;

Pessoa Ivan = new Pessoa("Ivan Aquino", 18);
Pessoa Arthur = new Pessoa("Arthur Batista", 18);

Ivan.ExibirDados();
Arthur.ExibirDados();

Pessoa rthur = new Pessoa($"Arthur", 18, "Gosta de morango");