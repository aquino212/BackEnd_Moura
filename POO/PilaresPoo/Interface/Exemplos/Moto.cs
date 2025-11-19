using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor
    {

        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        public Moto(string c, String m, string md, int a)
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

        public void cortandoDeGiro()
        {
         Console.WriteLine($@"Moto cortando de giro...  BRÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁ
            BRÁ BRÁ BRÁ BRÁ BRÁÁÁÁÁÁÁÁÁÁ
            TÁ TÁ TÁ TÁ TÁ TÁÁÁÁÁÁÁÁ
            PRRRRRAAAAAAAAAAAMMMMMMM
            BRÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓÓ!!");
        }

        public void Derrapando()
        {
            Console.WriteLine($@"Moto derapando... SKRRRRRRRRRRRRRRRRRRRRRRRRRRR
            SKRÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁÁ
            VRRRRRRRRRRRRRRRR–SKRRRTTTTTTTT!!");

        }

        public void Frear()
        {
            throw new NotImplementedException();
        }

        public void Acelerar()
        {
            throw new NotImplementedException();
        }
    }
}