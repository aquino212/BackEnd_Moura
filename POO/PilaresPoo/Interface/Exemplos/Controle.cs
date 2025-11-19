using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Controle : IControle
    {

        public int NivelDeVolume = 50;
        public int VolumeMaximo = 50;

        public void AlmentarVolume()
        {
            if (NivelDeVolume == VolumeMaximo)
            {
                Console.WriteLine($"Volume Maximo atingido {VolumeMaximo}");
                return;
            }
        NivelDeVolume++;
        Console.WriteLine($"Volume: {NivelDeVolume}");
        }

        public void Desligar()
        {
        Console.WriteLine($"Desligando a TV...");
        
        }

        public void DiminuirVolume()
        {
        Console.WriteLine($"Volume: {NivelDeVolume}");
        
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}