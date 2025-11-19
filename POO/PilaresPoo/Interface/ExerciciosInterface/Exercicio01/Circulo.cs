using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosInterface
{
    public class Círculo : IForma
    {
       
        public  float PI = 3.14f;
        public  float Raio;
        

        public void CalcularArea()
        {
            float Area = PI * Raio * Raio;
            Console.WriteLine($"Area do circulo é: {Area}");
            
        }
    }
}