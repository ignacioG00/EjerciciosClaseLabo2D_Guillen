using Biblioteca_De_Clases;
using System;

namespace Ejercicio03_C2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroDecimal = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Conversor.ConvertirDecimalABinario(numeroDecimal));

            int numeroBinario = int.Parse(Console.ReadLine());

            Console.WriteLine("el numero {0} pasado a decimal es {1}" , numeroBinario, Conversor.ConvertirBinarioADecimal(numeroBinario)); ;
        }
    }    
}
