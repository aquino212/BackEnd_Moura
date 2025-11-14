using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public double BonusAd;

        public double CalcSalario()
        {
            return SalarioBase + BonusAd;
        }
    }
}