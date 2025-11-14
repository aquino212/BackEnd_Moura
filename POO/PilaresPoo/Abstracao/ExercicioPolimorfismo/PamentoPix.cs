using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPolimorfismo
{
    public class PamentoPix : Pagamento
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