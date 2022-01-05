

namespace CapaLogica
{
    public class Porcentaje
    {
        public decimal Numero { get; set; }
        public decimal NumeroPorcentaje { get; set; }
        public Porcentaje()
        {

        }
        public Porcentaje(decimal valor, decimal porciento)
        {
            this.Numero = valor;
            this.NumeroPorcentaje = porciento;
        }
        public decimal SacarElPorcentaje()
        {
            return (Numero* NumeroPorcentaje) / 100;
        }

    }
}
