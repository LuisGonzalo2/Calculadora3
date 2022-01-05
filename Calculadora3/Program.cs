using System;
using CapaLogica;
namespace Calculadora3
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            double iva = 1.12;
            double pi = 3.14;
            do
            {
                Console.WriteLine("Menu Prueba");
                int opcion = int.Parse(Console.ReadLine());
                //Calcular Resta
                if (opcion == 1)
                {
                    do
                    {
                        Console.WriteLine("Valor 1");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Valor 2");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Resta miResta = new Resta(valor1, valor2);

                        Console.WriteLine(miResta.Restar());
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Suma
                if (opcion == 2)
                {
                    Suma sumar = new Suma();
                    do
                    {
                        Console.WriteLine("Ingresa el numero a sumar");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Ingresa los valores a Sumar");
                            decimal numero = decimal.Parse(Console.ReadLine());
                            sumar.agregar(numero);
                        }
                        Console.WriteLine(sumar.Sumar());
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Multiplicacion
                if (opcion == 3)
                {
                    
                    do
                    {
                        Console.WriteLine("Valor 1");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Valor 2");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Multiplicacion multi = new Multiplicacion(valor1, valor2);
                        Console.WriteLine(multi.Multiplicar());
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Division
                if (opcion == 4)
                {
                    
                    do
                    {
                        Console.WriteLine("Valor 1");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Valor 2");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Division div = new Division(valor1, valor2);
                        Boolean validacion = div.validar(valor1, valor2);
                        if(validacion == true)
                        {
                            Console.WriteLine(div.Dividir());
                            Console.WriteLine("Deseas continuar?");
                            respuesta = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Error numero no valido");
                            Console.WriteLine("Deseas continuar?");
                            respuesta = Console.ReadLine();
                        }

                    } while (respuesta.Equals("S"));
                }
                //Calcular el Iva
                if(opcion == 5)
                {
                    do
                    {
                        Console.WriteLine("Valor 1");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Iva impuesto = new Iva(valor1, iva);
                        Console.WriteLine("Subtotal "+impuesto.SubTotal());
                        Console.WriteLine("IVA "+impuesto.SacarImpuesto(impuesto.SubTotal()));
                        Console.WriteLine("Total "+valor1);
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();

                    } while (respuesta.Equals("S"));
                }
                //calcular el Porcentaje
                if(opcion == 6)
                {
                    do
                    {
                        Console.WriteLine("Ingresa El valor");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el Porcentaje a Calcular");
                        decimal Numeroporcentaje = decimal.Parse(Console.ReadLine());
                        Porcentaje verPorcentaje = new Porcentaje(valor,Numeroporcentaje);
                        Console.WriteLine("El "+Numeroporcentaje+"% de "+valor+" es: "+ verPorcentaje.SacarElPorcentaje());
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();

                    } while (respuesta.Equals("S"));
                }
                //Sacar el Radio
                if(opcion == 7)
                {
                    do
                    {
                        Console.WriteLine("Ingresa El valor de la circunferencia");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        Radio sacarRadio = new Radio(valor,pi);
                        Console.WriteLine("La circunferencia es: "+valor+"\nEl Radio es: "+sacarRadio.SacarRadio());
                        Console.WriteLine("Deseas continuar?");
                        respuesta = Console.ReadLine();
                    } while (respuesta.Equals("S"));
                }
            } while (respuesta.Equals("N"));

        }
    }
}
