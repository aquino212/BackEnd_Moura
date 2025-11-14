using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    namespace Empresa
    {
        public class Funcionario
        {
            public string Nome;
            public double SalarioBase;

            public double CalcularSalario()
            {
                return SalarioBase;
            }
        }

        public class Gerente : Funcionario
        {
            public double Bonus;

            public double CalcularSalario()
            {
                return SalarioBase + Bonus;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Funcionario f = new Funcionario();
                f.Nome = "Carlos";
                f.SalarioBase = 3000;

                Gerente g = new Gerente();
                g.Nome = "Ana";
                g.SalarioBase = 5000;
                g.Bonus = 2000;

                Console.WriteLine($"{f.Nome} - Salário: R${f.CalcularSalario()}");
                Console.WriteLine($"{g.Nome} - Salário Total: R${g.CalcularSalario()}");
            }
        }
    }
}
