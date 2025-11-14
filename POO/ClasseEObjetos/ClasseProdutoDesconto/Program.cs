using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;

namespace ClasseEObjetos
{
    public class Produto
    {
        // Atributos
        public string Nome;
        public double Preco;

        // Método para aplicar desconto
        public void AplicarDesconto(double percentual)
        {
            double desconto = Preco * (percentual / 100);
            Preco -= desconto;

            Console.WriteLine($"Desconto de {percentual}% aplicado com sucesso!");
            Console.WriteLine($"Novo preço do produto ({Nome}): R${Preco:F2}\n");
        }
    }
}
