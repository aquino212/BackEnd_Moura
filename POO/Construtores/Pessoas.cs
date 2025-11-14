using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Console.WriteLine($"Objetivo criado");
        }

        public Pessoa(string n, int i, string xpto)
        {
            Nome = n;
            Idade = i;
            Console.WriteLine($"Seu texto é: {xpto}");
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;

        }

        public Pessoa(string n)
        {
            Nome = n;
        }

        //métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}