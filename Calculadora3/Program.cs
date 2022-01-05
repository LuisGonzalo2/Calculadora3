using System;
using CapaLogica;
namespace Calculadora3
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            string pregunta = "Deseas Continuar? \n--> S o --> N";
            double iva = 1.12;
            double pi = 3.14;
            do
            {
                Console.WriteLine("Escoge la Opcion:");
                Console.WriteLine("1. Resta");
                Console.WriteLine("2. Suma");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Iva");
                Console.WriteLine("6. Porcentaje");
                Console.WriteLine("7. Radio");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                //Calcular Resta
                if (opcion == 1)
                {
                    do
                    {
                        Console.WriteLine("Ingresa el primer valor a restar");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor a restar");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Resta miResta = new Resta(valor1, valor2);

                        Console.WriteLine(miResta.Restar());
                        Console.WriteLine(pregunta);

                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Suma
                if (opcion == 2)
                {
                    Suma sumar = new Suma();
                    do
                    {
                        Console.WriteLine("Ingresa los numeros a sumar");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Ingresa los valores a Sumar");
                            decimal numero = decimal.Parse(Console.ReadLine());
                            sumar.agregar(numero);
                        }
                        Console.WriteLine(sumar.Sumar());
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
                        Console.WriteLine("Ingresa el primer valor a multiplicar");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor a multiplicar");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Multiplicacion multi = new Multiplicacion(valor1, valor2);
                        Console.WriteLine(multi.Multiplicar());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Division
                if (opcion == 4)
                {
                    
                    do
                    {
                        Console.WriteLine("Ingresa el Primer valor a dividir");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo valor a dividir");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Division div = new Division(valor1, valor2);
                        Boolean validacion = div.validar(valor1, valor2);
                        if(validacion == true)
                        {
                            Console.WriteLine(div.Dividir());
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
                if(opcion == 5)
                {
                    do
                    {
                        Console.WriteLine("Ingresa el valor total");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Iva impuesto = new Iva(valor1, iva);
                        Console.WriteLine("Subtotal "+impuesto.SubTotal());
                        Console.WriteLine("IVA "+impuesto.SacarImpuesto(impuesto.SubTotal()));
                        Console.WriteLine("Total "+valor1);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
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
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
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
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
            } while (respuesta.Equals("N"));

        }
    }
}
