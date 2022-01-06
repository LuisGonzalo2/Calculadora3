using System;
using System.Collections.Generic;
namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Resta : IOperacion
    {
        public double Calcular(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}
