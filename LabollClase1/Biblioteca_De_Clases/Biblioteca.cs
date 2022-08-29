using System;
using System.Text;

namespace Biblioteca_De_Clases
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta) 
        {
            respuesta = respuesta.ToLower();
            return (respuesta == "s");
        }
    }

    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            int numeroBinario = 0;
            int divisor = 2;
            int digito = 0;

            for (int i = numeroEntero % divisor, j = 0; numeroEntero > 0; numeroEntero /= divisor, i = numeroEntero % divisor, j++)
            {
                digito = i % divisor;
                numeroBinario += digito * (int)Math.Pow(10, j);
            }
            numeroEntero = numeroBinario;

            return ("Conversion hecha: " + numeroEntero);
        }
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numero = 0;
            int digito = 0;
            int divisor = 10;

            for (int i = numeroEntero, j = 0 ; i > 0; i /= divisor, j++)
            {
                digito = i % divisor;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }
    }

    public class Calculadora 
    {
 
        public static int Calcular(int operandoUno, int operandoDos ,string operacion) 
        {
            int resultado= 0;
            switch (operacion)
            {
                case "/":
                    if (Validar(operandoDos))
                    {
                        resultado = operandoUno / operandoDos;
                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar la operacion.");
                    }
                   
                    break;
                case "+":
                    resultado = operandoUno + operandoDos;
                    break;
                case "*":
                    resultado = operandoUno * operandoDos;
                    break;
                case "-":
                    resultado = operandoUno - operandoDos;
                    break;
                default:
                    Console.WriteLine("Error. El operando es invalido.");
                    break;
            }

            return resultado;
        }
        private static bool Validar(int operando) 
        {
            return operando != 0;
        }
    }

    public class CalculadoraDeArea 
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double basse , double altura) 
        {
            return (basse * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    public class Tablas 
    {
        public static StringBuilder HacerTablas(int numero) 
        {
            StringBuilder tabla = new StringBuilder(50);

            Console.WriteLine("Tabla de multiplicar del número {0}:",numero);

            for (int i = 1; i < 10; i++)
            {
                int resultado = numero * i;
                
                tabla.AppendFormat("{0} x {1} = {2} \n", numero, i, resultado);
            }
            return tabla;
        }
    }

}
