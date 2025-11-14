using Exercicio04;
using System;

Aluno aluno = new Aluno();
aluno.Nome = "Ivan";
aluno.Idade = 18;
aluno.Curso = "Desenvolvimento De Sistema";

Professor professor = new Professor();
professor.Nome = "Alexia";
professor.Idade = 24;
professor.Disciplina = "Desenvolvimento de Sistema";

Console.WriteLine("Aluno:");
Console.WriteLine("Nome: " + aluno.Nome);
Console.WriteLine("Idade: " + aluno.Idade);
Console.WriteLine("Curso: " + aluno.Curso);

Console.WriteLine("Professor:");
Console.WriteLine("Nome: " + professor.Nome);
Console.WriteLine("Idade: " + professor.Idade);
Console.WriteLine("Disciplina: " + professor.Disciplina);

