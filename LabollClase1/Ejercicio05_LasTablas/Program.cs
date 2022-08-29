using System;
using Biblioteca_De_Clases;

namespace Ejercicio05_LasTablas
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroIngresado;
            do
            {
                Console.WriteLine("Ingrese un numero para ver sus tablas del 1 al 9: ");
                bool resultado = int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (!resultado)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                    resultado = int.TryParse(Console.ReadLine(), out numeroIngresado);
                }

                Console.WriteLine(Tablas.HacerTablas(numeroIngresado));

                Console.WriteLine("¿Desea continuar? (S/N)");

            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }


}
