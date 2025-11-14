using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Exercicios.Exercicio05
{
    public class Conta
    {
        public int Numero;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
