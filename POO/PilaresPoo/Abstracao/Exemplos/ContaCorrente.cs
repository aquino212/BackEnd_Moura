using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class ContaCorrente : ContaBancaria
    {
        public double Saldo = 0;
        private double TaxaSaque = 5;

        public ContaCorrente(double saldoInicial)
        {
            Saldo = saldoInicial;
        }
        public override void Depositar(double valor)
        {
            if(valor <= 0)
            {
                System.Console.WriteLine($"O valor do depósito deve ser positivo");
                return;
            }
            Saldo += valor;
        }
        public override void Sacar(double valor)
        {

            double TotalComTaxa = (valor / 100 * TaxaSaque) + valor;
            if(valor <= 0 || Saldo < TotalComTaxa)
            {
                System.Console.WriteLine($"O valor do saque deve ser positivo e ter dinheiro na conta");
                return;
            }

            Saldo -= TotalComTaxa;
            throw new NotImplementedException();
        }
    }
}