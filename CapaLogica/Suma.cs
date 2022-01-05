
using System.Collections.Generic;


namespace CapaLogica
{
    public class Suma
    {
        public List<decimal> numeros { get; set; }
        public Suma()
        {
            numeros = new List<decimal>();
        }
        public void agregar(decimal numero)
        {
            numeros.Add(numero);
        }
        public decimal Sumar()
        {
            decimal resultado = 0;
            foreach (var item in this.numeros)
            {
                resultado += item;
            }
            return resultado;
        }

    }
}
