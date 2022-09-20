using Biblioteca_De_Clases;

namespace Ejercicio09_CalcularUnFactorial;
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un numero para calcular el factorial: \n");

                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CalcularFactorial(numeroIngresado));


                Console.WriteLine("¿Desea continuar? (S/N)");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }

        public static int CalcularFactorial(int numero)
        {
            for (int i = numero - 1; i > 1; i--)
            {
                numero = numero * i;
            }
            return numero;
        }
    }