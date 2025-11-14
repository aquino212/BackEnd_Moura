using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Heranca
{
    public class Moto : Veiculo
    {
        public int QtdPessoas = 2;

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Capacidade Limitada a: {QtdPessoas}");

        }
    }
}