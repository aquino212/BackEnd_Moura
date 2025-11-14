using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Exercicios.Exercicio05
{
    public class ContaPoupanca : Conta
    {
        public void CalcularRendimento()
        {
            Saldo = Saldo + (Saldo * 0.02);
        }
    }
}
