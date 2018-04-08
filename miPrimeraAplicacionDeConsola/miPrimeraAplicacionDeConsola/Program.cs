using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miPrimeraAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            double elPromedio = 0;
            double nota1 = 0;

            for (int i = 1; i <= 4; i++)
            {
                cadena = "";
                cadena = "Escriba la " + i.ToString() + "º nota: ";
                Console.Write(cadena);

                nota1= double.Parse(Console.ReadLine());
                elPromedio = elPromedio + nota1;

            }

            
            Console.WriteLine("El promedio final es: "+ elPromedio/4);
            Console.WriteLine();
            Console.WriteLine("Toque una tecla para salir");
            Console.WriteLine("Muchas gracias por utilizar esto");
            Console.ReadLine();
        }
    }
}
