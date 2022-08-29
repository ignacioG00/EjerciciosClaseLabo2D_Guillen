using System;

namespace Ejercicio01_C2
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado=0;
            int numeroMaximo=0;
            int numeroMinimo=0;
            int promedioNumIngresados=0;
            int i = 0;

            do
            {
                Console.WriteLine("Ingrese un numero entre 100 y -100: /n");
                bool resultado = int.TryParse(Console.ReadLine(), out int numero);
                if (!resultado && Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Error. Ingrese un numero entre 100 y -100: /n");
                    resultado = int.TryParse(Console.ReadLine(), out numero);
                }
                numeroIngresado = numero;

                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                else
                    if (numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }
                promedioNumIngresados += numeroIngresado;

                i++;
            } while (i != 10);
            promedioNumIngresados = promedioNumIngresados / 10;
            Console.WriteLine("numero maximo: {0} num min: {1} prom numeros: {2} " ,numeroMaximo,numeroMinimo,promedioNumIngresados);
        }
    }

    
}
