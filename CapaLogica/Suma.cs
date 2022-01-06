using System;
using System.Collections.Generic;


namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Suma:IOperacion
    {
        public double Calcular(double num1, double num2)
        {
            return num1 + num2;
        }

        //    public List<decimal> numeros { get; set; }
        //    public Suma()
        //    {
        //        numeros = new List<decimal>();
        //    }
        //    public void agregar(decimal numero)
        //    {
        //        numeros.Add(numero);
        //    }
        //    public decimal Sumar()
        //    {
        //        decimal resultado = 0;
        //        foreach (var item in this.numeros)
        //        {
        //            resultado += item;
        //        }
        //        return resultado;
        //    }

    }
}
