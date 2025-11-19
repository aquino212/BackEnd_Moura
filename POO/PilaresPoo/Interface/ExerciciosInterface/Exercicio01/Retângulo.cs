using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosInterface
{
    public class retângulo : IForma
    {
        public float Largura;
        public float Altura;


        public retângulo(float largura, float altura)
        {
            Largura = largura;

            Altura = altura;
        }
        public void CalcularArea()
        {
            float Area = Largura * Altura;
            Console.WriteLine($"Area do retângulo: {Area}");
            
        }
    }
}