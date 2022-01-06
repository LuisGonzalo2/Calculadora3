using System;
using System.Collections.Generic;
using CapaLogica;
namespace Calculadora3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0 ;
            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            string respuesta = "";
            string pregunta = "Deseas Continuar? \n--> S o --> N";
            double iva = 1.12;
            double pi = 3.14;

            Console.WriteLine("Menu de Calculadora");
            //Variable operacion que referencia al algoritmo
            //Se instancia un default para que se pueda compilar sin ningun problema
            IOperacion operacion = new Suma();


            do
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Ingrese alguna de las siguientes opciones: \n1-Suma \n2-Resta \n3-Multiplicar \n4-Divir \n5-Iva \n6-Porcentaje \n7-Radio \n8-Salir");
                Console.WriteLine("-----------------------------------------------------");
                opcion = Convert.ToInt16(Console.ReadLine());

                if (opcion >= 8)
                {
                    break;
                }
                //Aqui se selecciona el algoritmo de acuerdo a la necesidad a calcular

                //Calcular Suma
                if (opcion == 1)
                {
                    do
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        operacion = new Suma();

                        resultado = operacion.Calcular(numero1, numero2);
                        Console.WriteLine("El resultado de la operaciones {0}", resultado);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
            
                    } while (respuesta.Equals("S"));
                }
                //Calcular Resta
                if (opcion == 2)
                {
                    do
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        operacion = new Resta();

                        resultado = operacion.Calcular(numero1, numero2);
                        Console.WriteLine("El resultado de la operaciones {0}", resultado);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Multiplicacion
                if (opcion == 3)
                {
                    do
                    {

                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        operacion = new Multiplicacion();

                        resultado = operacion.Calcular(numero1, numero2);
                        Console.WriteLine("El resultado de la operaciones {0}", resultado);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular el Division
                if (opcion == 4)
                {
                    do
                    {
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());

                        operacion = new Division();

                        
                        Division div = new Division();
                        Boolean validacion =  div.validar(numero1, numero2);
                        if(validacion == true)
                        {
                            resultado = operacion.Calcular(numero1, numero2);
                            Console.WriteLine("El resultado de la operaciones {0}", resultado);
                            Console.WriteLine(pregunta);
                            respuesta = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Error numero no valido");
                            Console.WriteLine(pregunta);
                            respuesta = Console.ReadLine();
                            Console.Clear();
                        }
                    } while (respuesta.Equals("S"));
                }

                
                //Calcular el Iva
                if (opcion == 5)
                {
                    do
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Ingresa el valor total");
                        Console.WriteLine("----------------------");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Iva impuesto = new Iva(valor1, iva);
                        Console.WriteLine("Subtotal " + impuesto.SubTotal());
                        Console.WriteLine("IVA " + impuesto.SacarImpuesto(impuesto.SubTotal()));
                        Console.WriteLine("Total " + valor1);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular el Porcentaje
                if (opcion == 6)
                {
                    do
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Ingresa El valor");
                        Console.WriteLine("----------------------");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el Porcentaje a Calcular");
                        decimal Numeroporcentaje = decimal.Parse(Console.ReadLine());
                        Porcentaje verPorcentaje = new Porcentaje(valor, Numeroporcentaje);
                        Console.WriteLine("El " + Numeroporcentaje + "% de " + valor + " es: " + verPorcentaje.SacarElPorcentaje());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Sacar el Radio
                if (opcion == 7)
                {
                    do
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Ingresa El valor de la circunferencia");
                        Console.WriteLine("-------------------------------------");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        Radio sacarRadio = new Radio(valor, pi);
                        Console.WriteLine("La circunferencia es: " + valor + "\nEl Radio es: " + sacarRadio.SacarRadio());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
            } while (respuesta.Equals("N")) ;
        }
    }
}
