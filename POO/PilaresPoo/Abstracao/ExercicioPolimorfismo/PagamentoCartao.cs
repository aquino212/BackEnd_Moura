using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class PagamentoCartao : Pagamento
    {
        private float acrecimo = 5.38f;
        public float ValorCompra;
        public override float CalcularTotal()
        {
           float ValorAcrescimo = ValorCompra / 100 * acrecimo;

           return ValorCompra = ValorCompra + ValorAcrescimo;
        }
    }
}