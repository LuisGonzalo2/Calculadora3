using System;
namespace CapaLogica
{
    public class Radio
    {
        public decimal Numero { get; set; }
        public double Pi { get; set; }

        public Radio()
        {

        }
        public Radio(decimal valor, double pi)
        {
            this.Numero = valor;
            this.Pi = pi;
        }

        public decimal SacarRadio()
        {
            return Numero /(2 * Convert.ToDecimal(Pi));
        }
    }
}
