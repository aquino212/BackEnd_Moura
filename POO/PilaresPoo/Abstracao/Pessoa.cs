using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao
{
    public class Pessoa : Animal
    {
        public string Nome;
        public int Idade;

        public override void FazerSom()
        {

        }

        public override void Mover()
        {
            System.Console.WriteLine($"Plac Plac Plac");
        }
        public void Dormir()
        {
            
        }

    }
}