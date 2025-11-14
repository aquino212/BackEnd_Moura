using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class AgenciaBancaria
    {

        public string Titular ="";
        public float Saldo;
        public void Depositar(float valor)
        {
            if (valor > 0 && valor >= Saldo)

                Saldo += valor;
            Console.WriteLine($"Depósito efetuado com sucesso!");
            Console.WriteLine($"Novo Saldo: {Saldo: F2}");
            return;
        }
        
    
        public void Sacar(float valor)
        {
            Saldo -= valor;
        } 
    }
}