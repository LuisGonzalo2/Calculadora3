using System;

namespace CapaLogica
{
    public class Division
    {
        public decimal NumeroUno { get; set; }
        public decimal NumeroDos { get; set; }
        public Division()
        {

        }
        public Division(decimal numeroUno, decimal numeroDos)
        {
            this.NumeroDos = numeroDos;
            this.NumeroUno = numeroUno;
        }
        public decimal Dividir()
        {
            return this.NumeroUno / this.NumeroDos;
        }

        public Boolean validar(decimal numeroUno, decimal numeroDos)
        {
            Boolean validacion = true;
            if (numeroUno > 0 && numeroDos > 0)
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }
            
            return validacion;
        }

    }
}