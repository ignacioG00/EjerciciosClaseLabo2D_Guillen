using Biblioteca_De_Clases;
using System;

namespace Ejercicio02_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                bool resultado = int.TryParse(Console.ReadLine(), out int numero);
                if (!resultado)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                    resultado = int.TryParse(Console.ReadLine(), out numero);
                }
                acumulador += numero;
                Console.WriteLine("¿Desea continuar? (S/N)");

            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.WriteLine("el numero acumulado es: " + acumulador);
        }
    }
}
