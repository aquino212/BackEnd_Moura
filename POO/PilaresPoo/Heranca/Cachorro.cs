using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca
{
    public class Cachorro : Animal
    {
        public string nome;
        public string raça;
        public string idade;
       
       public void ExibirInfo()
        {
             System.Console.WriteLine($"Nome{nome}, Raça{raça} Idade ");
        }
        public void FazerSom()
        {
            System.Console.WriteLine($"Au Au");
        }
    }
}