using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using execicioPolimorfismo;

namespace ExercicioPolimorfismo
{
    public class PagamentoPix : Pagamento
    {
        private float desconto = 5;
        public float VslorCompra;
        public override float CalcularTotal()
        {
            float ValorDesconto = ValorCompra / 100 * desconto;
            return ValorCompra = ValorCompra - ValorDesconto;
        }
    }
}