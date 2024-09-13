using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArreglo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ° Nombre: Juan Carlos Castellón Rivera
            ° Docente: Silvia Gigdalia Ticay Lopez
            ° Fecha: 9 de septiembre del 2024
            ° Programa 2 (Ejemplo 2): Arreglo Bidimensional que suma las filas, las columas, y los números pares e impares del arreglo
            */

            Console.WriteLine("Juan Castellón - 09/09/24");
            Console.WriteLine("Arreglo Bidimensional + Suma de Filas, Columnas, Números Pares e Impares");
            Console.WriteLine("");

            int[,] tabla = new int[3, 3];
            int[] sumaf = new int[3];
            int[] sumac = new int[3];
            int sumapar = 0, sumaimpar = 0, contf = 0, contc = 0;
            int f, c; //F = Filas, C = Columnas

            Console.WriteLine("Digite los Datos del Arreglo...");
            Console.WriteLine("");

            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write("Digite el Número: ");
                    tabla[f, c] = int.Parse(Console.ReadLine());

                    sumaf[f] += tabla[f, c];
                    sumac[c] += tabla[f, c];

                    //Usamos un "if" y un módulo para determinar si los números del arreglo son pares o impares
                    if (tabla[f, c] % 2 == 0)
                    {
                        sumapar += tabla[f, c];
                    }
                    else
                    {
                        sumaimpar += tabla[f, c];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Imprimiendo el Arreglo...");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    //Mostrar cada número dentro del arreglo en forma de matriz
                    Console.Write("{0} ", tabla[f, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
            for (f = 0; f < 3; f++)
            {
                //Mostrar el número de fila y la suma de los número en dicha fila
                contf = contf + 1;
                Console.WriteLine("La suma de la fila {0} es: {1}", contf, sumaf[f]);
            }

            Console.WriteLine("");
            for (c = 0; c < 3; c++)
            {
                //Mostrar el número de columna y la suma de los número en dicha columna
                contc = contc + 1;
                Console.WriteLine("La suma de la columna {0} es: {1}", contc, sumac[c]);
            }

            //Mostrar la suma de los números pares e impares
            Console.WriteLine("");
            Console.WriteLine("La suma de los números pares es: {0}", sumapar);
            Console.WriteLine("La suma de los números impares es: {0}", sumaimpar);

            Console.ReadKey();
        }
    }
}
