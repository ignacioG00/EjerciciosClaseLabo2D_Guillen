using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            
            int numerosPrimosContados = 0;
            int contadorDeDivisores = 0;
            string respuesta;

            do
            {
                bool resultado = int.TryParse(Console.ReadLine(), out int numero);
                numIngresado = numero;

                for (int i = 2; i < numIngresado; i++)
                {
                    for (int b = 1; b < numIngresado; b++)
                    {
                        if (contadorDeDivisores > 2)
                        {
                            break;
                        }
                        else if (i % b == 0)
                        {
                            contadorDeDivisores++;
                        }
                    }
                    if (contadorDeDivisores == 2)
                    {
                        Console.WriteLine(i);
                    }
                    contadorDeDivisores = 0;
                }
                Console.WriteLine("¿Desea seguir operando? s/n");
                respuesta = Console.ReadLine();
            } while (respuesta != "n");
        }
    }
}
