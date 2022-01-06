using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    // La interfaz de la strategy declara operaciones comunes a todos los admitidos
    public interface IOperacion
    {
        //recordar que en las Interfaces puedo recibir
        double Calcular(double num1, double num2);
    }
}
