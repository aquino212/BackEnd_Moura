using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;

        public void ExibirInfo()
        {
            System.Console.WriteLine($"Marca: {Marca}");
            System.Console.WriteLine($"Modelo: {Modelo}");
            System.Console.WriteLine($"Ano: {Ano}");
            System.Console.WriteLine($"Quants portas: {QtdPortas}");
        }
    }
}