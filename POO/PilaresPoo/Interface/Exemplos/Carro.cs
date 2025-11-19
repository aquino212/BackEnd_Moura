using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {
        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, String m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($@"Infomações do Veículo: Marca: {Marca} Modelo: {Modelo} Ano: {Ano} Cor: {Cor}");

        }
        public void Acelerar()
        {
            Console.WriteLine($"carro acelerando... Vrum Vrum");

        }

        public void Frear()
        {
            Console.WriteLine($"Carro Freiando... irrrrrrrrrrrrrh");

        }

        public void cortandoDeGiro()
        {
            throw new NotImplementedException();
        }

        public void Derrapando()
        {
            throw new NotImplementedException();
        }
    }
}