string cargo;
double salario, salarioNovo = 0;


Console.WriteLine($"Digite o cargo do funcionario producao, admnistrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"Digite o salario do funcionario");

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065);
}
else if (cargo == "administrativo")
{
    salarioNovo = salario + (salario * 0.075);
}
else if (cargo == "diretoria")
{
    salarioNovo = salario + (salario * 0.12);
}

