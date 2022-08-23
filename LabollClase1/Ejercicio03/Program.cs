using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            bool resultado = int.TryParse(Console.ReadLine(), out int numero);

            numIngresado = numero;

            int numerosPrimosContados = 0;

            int acumulador = 2;
       

            for (int i = 2; i < numIngresado; i++)
            {
                bool esPrimo = true;
                if (acumulador % i == 0)
                {
                    for (int b = i + 1; b < numIngresado+1; b++)
                    {
                        if (acumulador % b == 0)
                        {
                            esPrimo = false;
                            b = numIngresado;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine("los numeros primos son: {0}", acumulador);
                    }
                }
                acumulador++;
            }
        }
    }
}
