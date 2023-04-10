using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);

            int minumero;
            int intentos = 0;
            Console.WriteLine("introduce un numero entre 0 y 100");

            do
            {
                intentos++;
                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No es un numero Exeption");
                    Console.WriteLine(ex.Message);
                    minumero = 0;
                }
           

                if (minumero > aleatorio) Console.WriteLine("El numero es mas Bajo");
                if (minumero < aleatorio) Console.WriteLine("El numero es mas Alto");


            } while (aleatorio != minumero);

            Console.WriteLine($"CORRECTO HAS NECESITADO {intentos} intentos");

        }
    }
}
