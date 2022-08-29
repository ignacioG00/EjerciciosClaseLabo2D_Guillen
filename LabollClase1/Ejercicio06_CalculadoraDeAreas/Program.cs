using Biblioteca_De_Clases;
using System;

namespace Ejercicio06_CalculadoraDeAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;
            float numeroIngresadoDos;
            string figura;
            bool resultado;
            do
            {
                Console.WriteLine("Ingrese que tipo de area calcular: (Cuadrado,triangulo,circulo) ");
                figura = Console.ReadLine();

                switch (figura)
                {
                    case "cuadrado":
                        Console.WriteLine("Ingrese la medida del lado: ");
                         resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        if (!resultado)
                        {
                            Console.WriteLine("Error. Ingrese la medida del lado: ");
                            resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        }
                        Console.WriteLine("El area del cuadrado es: {0}" ,CalculadoraDeArea.CalcularAreaCuadrado(numeroIngresado));
                        break;

                    case "triangulo":
                        Console.WriteLine("Ingrese la medida de la base: ");
                        resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        if (!resultado)
                        {
                            Console.WriteLine("Error. la medida de la base: ");
                            resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        }

                        Console.WriteLine("Ingrese la medida de la altura: ");
                        resultado = float.TryParse(Console.ReadLine(), out numeroIngresadoDos);
                        if (!resultado)
                        {
                            Console.WriteLine("Error. la medida de la altura: ");
                            resultado = float.TryParse(Console.ReadLine(), out numeroIngresadoDos);
                        }
                        Console.WriteLine("El area del triangulo es: {0}" ,CalculadoraDeArea.CalcularAreaTriangulo(numeroIngresado, numeroIngresadoDos)); 
                        break;

                    case "circulo":
                        Console.WriteLine("Ingrese la medida del radio: ");
                        resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        if (!resultado)
                        {
                            Console.WriteLine("Error. Ingrese la medida del radio: ");
                            resultado = float.TryParse(Console.ReadLine(), out numeroIngresado);
                        }
                        Console.WriteLine("El area del circulo es: {0}" , CalculadoraDeArea.CalcularAreaCirculo(numeroIngresado));
                        break;

                    default:
                        Console.WriteLine("Error. No se puede calcular el area de ese objeto o no existe. ");
                        break;
                }
                
                Console.WriteLine("¿Desea continuar? (S/N)");

            } while (Validador.ValidarRespuesta(Console.ReadLine()));
        }
    }
}
