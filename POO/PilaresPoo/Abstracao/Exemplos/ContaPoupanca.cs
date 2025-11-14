using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 0;
        private double TaxaSaque = 3;//3% de taxa de saque
        

        public ContaPoupanca(double saldoInicial)
        {
            
        }

        public override void Depositar(double valor)
        {
            
        }

        public override void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
       
    }
}