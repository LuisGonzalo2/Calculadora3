using System;
using System.Collections.Generic;
namespace CapaLogica
{
    public class Iva
    {
        public decimal Numero { get; set; }
        public double Impuesto { get; set; }
        public Iva()
        {  
        }
        public Iva(decimal valor, double iva)
        {
            this.Numero = valor;
            this.Impuesto = iva;
        }

        public decimal SubTotal()
        {
            decimal div = Numero / Convert.ToDecimal(Impuesto);
            return div;
        }
        public decimal SacarImpuesto(decimal subtotal)
        {
            return Numero - subtotal;
        }

    }
}
