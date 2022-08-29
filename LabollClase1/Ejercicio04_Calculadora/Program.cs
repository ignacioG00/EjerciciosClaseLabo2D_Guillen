using Biblioteca_De_Clases;
using System;

namespace Ejercicio04_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int operandoUno;
            int operandoDos;
            string operacion;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                bool resultado = int.TryParse(Console.ReadLine(), out  operandoUno);
                if (!resultado)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                    resultado = int.TryParse(Console.ReadLine(), out operandoUno);
                }

                Console.WriteLine("Ingrese un segundo numero: ");
                resultado = int.TryParse(Console.ReadLine(), out operandoDos);
                if (!resultado)
                {
                    Console.WriteLine("Error. Ingrese un segundo numero: ");
                    resultado = int.TryParse(Console.ReadLine(), out operandoDos);
                }

                Console.WriteLine("Ingrese una operacion: ");
                operacion= Console.ReadLine();

                Console.WriteLine (Calculadora.Calcular(operandoUno, operandoDos, operacion));

                Console.WriteLine("¿Desea continuar? (S/N)");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }
}
