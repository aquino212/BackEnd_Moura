using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;


        public void Acelerar()
        {
            System.Console.WriteLine($"Acelerando o Veiculo");
        }

    }
}