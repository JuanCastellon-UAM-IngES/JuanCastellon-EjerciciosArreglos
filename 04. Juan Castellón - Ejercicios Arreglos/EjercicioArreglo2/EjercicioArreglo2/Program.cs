using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace EjercicioArreglo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ° Nombre: Juan Carlos Castellón Rivera
            ° Docente: Silvia Gigdalia Ticay Lopez
            ° Fecha: 13 de septiembre del 2024
            ° Programa 3 (Ejercicio 1): Arreglo que reserve boletos de una aerolínea
            */

            Console.WriteLine("Juan Castellón - 13/09/24");
            Console.WriteLine("Sistema de Reservaciones de Aerolínea");
            Console.WriteLine("");

            //Declaramos un arreglo unidimensional que registrara los 10 boletos disponibles en ambas secciones
            int[] boletos = new int[10];
            //Declaramos 3 variables que se usaran como opciones, y 2 que se usaran para determinar el número de boleto
            //Los boletos de fumar inician desde 0 (1-5) igual que el indice del arreglo, y los de No Fumar desde 5 (6-10)
            int op, opf, opnf, boletof = 0, boletonf = 5;

            //Usamos un "do while" para que se repita el menu en caso que se ingrese algo incorrecto
            do
            {
                //Le solicitados a la persona que decida en que sección desea registrarse
                Console.WriteLine("Bienvenido a nuestro sistema de reservación de boletos!");
                Console.WriteLine("Seleccione una de nuestras dos secciones en la que desea abordar:");
                Console.WriteLine("");
                Console.Write("Escriba 1 para 'Fumar', Escriba 2 para 'No Fumar': ");
                op = int.Parse(Console.ReadLine());

                //Usamos un "if" para que se registre el boleto de una persona dependiendo de que eligio
                if (op == 1)
                {
                    //Usamos otro "if" para determinar que los asientos en dicha sección (Fumar) no esten llenos
                    if (boletof < 5)
                    {
                        //Se asigna el número de boleto al índice del arreglo, sumando en 1 para registrarlo ya que esta en 0 (y pase de 0 hasta 1 - 5)
                        boletos[boletof] = boletof + 1;
                        Console.WriteLine("");
                        //Imprimimos el número de boleto con el arreglo y la sección hospedada (Fumar)
                        Console.WriteLine("Boleto Registrado en la sección Fumar!");
                        Console.WriteLine("Número de Boleto: {0}, Sección: Fumar", boletos[boletof]);
                        //Aumentamos el número del boleto conforme se realice el proceso de registro
                        boletof++;
                    }
                    //Usamos un "else" por el dado caso que los asientos se encuentren llenos en la sección (Fumar)
                    else
                    {
                        //Nuevamente usamos un "do while" por si se ingresa una opción invalida y que el menu de opciones se repita
                        do
                        {
                            //Le informamos al usuario que si desea ir a la otra sección (No Fumar)
                            Console.WriteLine("");
                            Console.WriteLine("La sección 'Fumar' se encuentra llena en estos momentos... ");
                            Console.WriteLine("Desea registrarse en la sección 'No Fumar'? ");
                            Console.Write("Escriba 1 para 'Si', Escriba 2 para 'No': ");
                            opf = int.Parse(Console.ReadLine());

                            //Usamos un "if" para verificar la opción del usuario
                            if (opf == 1)
                            {
                                //Verificamos nuevamente con un "if" que los asientos en la otra sección (No Fumar) no esten llenos
                                if (boletonf < 10)
                                {
                                    //En dado caso que no esten llenos, registramos de la misma forma el boleto de la persona
                                    boletos[boletonf] = boletonf + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Boleto Registrado en la sección No Fumar!");
                                    Console.WriteLine("Número de Boleto: {0}, Sección: No Fumar", boletos[boletonf]);
                                    boletonf++;
                                }
                                //Usamos un "else" en dado caso si lo esten y le informamos al usuario de ello
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("La sección 'No Fumar' ya se encuentra llena...");
                                    Console.WriteLine("");
                                    //Le informamos también del proximo vuelo el cual tendra más secciones disponibles
                                    Console.WriteLine("El proximo vuelo con más secciones disponibles sera en 3 horas...");
                                    Console.WriteLine("Esperemos entienda nuestras dificultades, gracias!");
                                }
                            }
                            //Usamos un "else if" para verificar si la opción elegida fue distinta
                            else if (opf == 2)
                            {
                                Console.WriteLine("");
                                //Le informamos del proximo vuelo el cual tendra más secciones disponibles
                                Console.WriteLine("El proximo vuelo con más secciones disponibles sera en 3 horas...");
                                Console.WriteLine("Esperemos entienda nuestras dificultades, gracias!");
                            }
                            //Usamos un "else" por si no se ingreso una opción valida, y le informamos a la persona
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ingreso una opción no valida, intente de nuevo...");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                            }
                        }
                        //Con el "while" verificamos que se ingrese opciones correctas, en caso contrario, continuara con la función "do"
                        while (opf != 1 && opf != 2);
                    }

                }
                //Usamos un "else if" para que se realice el registro de los boletos de la otra sección
                else if (op == 2)
                {
                    //Usamos otro "if" para determinar que los boletos en dicha sección (No Fumar) no esten llenos
                    if (boletonf < 10)
                    {
                        //Se asigna el número de boleto al índice del arreglo, sumando en 1 para registrarlo ya que esta en 5 (y pase de 5 hasta 6 - 10)
                        boletos[boletonf] = boletonf + 1;
                        Console.WriteLine("");
                        ////Imprimimos el número de boleto con el arreglo y la sección hospedada (No Fumar)
                        Console.WriteLine("Boleto Registrado en la sección No Fumar!");
                        Console.WriteLine("Número de Boleto: {0}, Sección: No Fumar", boletos[boletonf]);
                        //Aumentamos el número del boleto conforme se realice el proceso de registro
                        boletonf++;
                    }
                    //Usamos un "else" por el dado caso que los asientos se encuentren llenos en la sección (No Fumar)
                    else
                    {
                        //Nuevamente usamos un "do while" por si se ingresa una opción invalida y que el menu de opciones se repita
                        do
                        {
                            Console.WriteLine("");
                            //Le informamos al usuario que si desea ir a la otra sección (Fumar)
                            Console.WriteLine("La sección 'No Fumar' se encuentra llena en estos momentos... ");
                            Console.WriteLine("Desea registrarse en la sección 'Fumar'? ");
                            Console.Write("Escriba 1 para 'Si', Escriba 2 para 'No': ");
                            opnf = int.Parse(Console.ReadLine());

                            //Usamos un "if" para verificar la opción del usuario
                            if (opnf == 1)
                            {
                                //Verificamos nuevamente con un "if" que los asientos en la otra sección (Fumar) no esten llenos
                                if (boletof < 5)
                                {
                                    //En dado caso que no esten llenos, registramos de la misma forma el boleto de la persona
                                    boletos[boletof] = boletof + 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Boleto Registrado en la sección Fumar!");
                                    Console.WriteLine("Número de Boleto: {0}, Sección: Fumar", boletos[boletof]);
                                    boletof++;
                                }
                                //Usamos un "else" en dado caso si lo esten y le informamos al usuario de ello
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("La sección 'Fumar' ya se encuentra llena...");
                                    Console.WriteLine("");
                                    Console.WriteLine("El proximo vuelo con más secciones disponibles sera en 3 horas...");
                                    Console.WriteLine("Esperemos entienda nuestras dificultades, gracias!");

                                }
                            }
                            //Usamos un "else if" para verificar si la opción elegida fue distinta
                            else if (opnf == 2)
                            {
                                Console.WriteLine("");
                                //Le informamos del proximo vuelo el cual tendra más secciones disponibles
                                Console.WriteLine("El proximo vuelo con más secciones disponibles sera en 3 horas...");
                                Console.WriteLine("Esperemos entienda nuestras dificultades, gracias!");
                            }
                            //Usamos un "else" por si no se ingreso una opción valida, y le informamos a la persona
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ingreso una opción no valida, intente de nuevo...");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("");
                            }
                        }
                        //Con el "while" verificamos que se ingrese opciones correctas, en caso contrario, continuara con la función "do"
                        while (opnf != 1 && opnf != 2);
                    }
                }
                //Usamos un "else" para informarle al usuario que la opción ingresada no es valida
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingreso una opción no valida, intente de nuevo...");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            //Con el "while" determinamos que la opción ingresada es valida, si no lo es, repetira el proceso con el "do"
            while (boletof < 5 || boletonf < 10);

            Console.ReadKey();
        }
    }
}
