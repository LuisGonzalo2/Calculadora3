namespace CapaLogica
{
    public class Resta
    {
        public decimal NumeroUno { get; set; }
        public decimal NumeroDos { get; set; }
        public Resta() { }

        public Resta(decimal numeroUno, decimal numeroDos)
        {
            this.NumeroDos = numeroDos;
            this.NumeroUno = numeroUno;
        }
        public decimal Restar()
        {
            return this.NumeroUno - this.NumeroDos;
        }
    }
}
