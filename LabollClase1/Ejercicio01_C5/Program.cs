using Biblioteca_De_Clases;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio01_C5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             1.Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
            2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
            3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
            •Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
            •Pida al usuario elegir el número del producto que quiere
            •Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió
            •El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
            BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO (que contenga nombre y precio del producto)
             */
            Producto pizza = new(10,"pizza");
            Producto papas = new(20, "papas");
            Producto milanesa = new(30, "milanesa");
            Producto fideos = new(50, "fideos");
            Producto ensalada = new(60, "ensalada");
            Producto paty = new(70, "paty");
            Producto arosDeCebolla = new(90, "arosDeCebolla");
            Producto chori = new(80, "chori");
            Producto bondiola = new(100, "bondiola");
            Producto vacio = new(110, "vacio");


            Dictionary<int,Producto> maquinaExpendedora = new Dictionary<int, Producto>();

            maquinaExpendedora.Add(0, pizza);
            maquinaExpendedora.Add(1, papas);
            maquinaExpendedora.Add(2, milanesa);
            maquinaExpendedora.Add(3, fideos);
            maquinaExpendedora.Add(4, ensalada);
            maquinaExpendedora.Add(5, paty);
            maquinaExpendedora.Add(6, arosDeCebolla);
            maquinaExpendedora.Add(7, chori);
            maquinaExpendedora.Add(8, bondiola);
            maquinaExpendedora.Add(9, vacio);

            do
            {
                Console.WriteLine("Bienvenidos al Restaurante! \n");
                Console.WriteLine("Elija una comida de la lista");
                foreach (var item in maquinaExpendedora)
                {
                    
                    Console.WriteLine("{0} -> {1} ",item.Key ,item.Value.nombre);
                }

                Console.WriteLine("\n Elija el producto:");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El producto que eligio es ['{0}'] que vale : {1} pesos", maquinaExpendedora[numeroIngresado].nombre, maquinaExpendedora[numeroIngresado].precio); 
                maquinaExpendedora.Remove(numeroIngresado);   

                Console.WriteLine("¿Desea continuar? (S/N)");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("Gracias por su compra!");

            


        }
    }
}