
namespace CapaLogica
{
    public class Multiplicacion
    {
        public decimal NumeroUno { get; set; }
        public decimal NumeroDos { get; set; }
        public Multiplicacion()
        {
            
        }
        public Multiplicacion(decimal numeroUno, decimal numeroDos)
        {
            this.NumeroDos = numeroDos;
            this.NumeroUno = numeroUno;
        }
        public decimal Multiplicar()
        {
            return this.NumeroUno * this.NumeroDos;
        }

    }
}