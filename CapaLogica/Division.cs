using System;
using System.Collections.Generic;

namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Division:IOperacion
    {
        public double Calcular(double num1, double num2)
        {
            return num1 / num2;
        }
        public Boolean validar(double numeroUno, double numeroDos)
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