using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArreglo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ° Nombre: Juan Carlos Castellón Rivera
            ° Docente: Silvia Gigdalia Ticay Lopez
            ° Fecha: 9 de septiembre del 2024
            ° Programa 1 (Ejemplo 1): Arreglo de 10 Posiciones que suma los números pares e impares del arreglo
            */

            Console.WriteLine("Juan Castellón - 09/09/24");
            Console.WriteLine("Arreglo de 10 Posiciones + Suma de Números Pares e Impares");
            Console.WriteLine("");

            const int tam = 10;
            int[] numeros = new int[tam];
            int sumapar = 0, sumaimpar = 0;
            Console.WriteLine("Digite los datos del Arreglo...");
            Console.WriteLine();
            for (int i = 0; i < tam; i++)
            { //Lectura y suma de números
                Console.Write("Ingresa un Número: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    sumapar += numeros[i];
                }
                else
                {
                    sumaimpar += numeros[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Datos del Arreglo:");
            for (int i = 0; i < tam; i++)
            { //Muestra en pantalla de números del arreglo
                Console.Write("{0}, ", numeros[i]);
            }

            //Muestra en pantalla de la suma par e impar de números
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Suma de Números Pares: {0}", sumapar);
            Console.WriteLine("");
            Console.Write("Suma de Números Impares: {0}", sumaimpar);

            Console.ReadKey();
        }
    }
}
