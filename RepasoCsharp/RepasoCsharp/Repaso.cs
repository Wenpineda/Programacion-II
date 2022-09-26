using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoCsharp
{
    class Repaso
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.WriteLine("\t┌────────────────────────────────────┐");
            Console.WriteLine("\t│        ---- ESTRUCTURAS ----       │");
            Console.WriteLine("\t│            ---- DE ----            │");
            Console.WriteLine("\t│          ---- CONTROL ----         │");
            Console.WriteLine("\t└────────────────────────────────────┘\n");
            Console.ResetColor();
            Console.WriteLine("Elige una de las opciones\n");
            
            bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("1. Sumar dos numeros prefijados ");
                    Console.WriteLine("2. Ejemplo con if-else (edad)");
                    Console.WriteLine("3. Ejemplo con While (factorial)");
                    Console.WriteLine("4. Ejmplo con do-while (clave)");
                    Console.WriteLine("5. Ejemplo con for (multiplicador)");
                    Console.WriteLine("6. Salir!!\n");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: //SUMA DE 2 PREFIJOS
                            int primerNumero;
                            int SegundoNumero;
                            int Suma; /*Guardare el valor para usarlo mas tarde*/

                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\nIngrese un numero: ");
                            primerNumero = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese otro numero: ");
                            SegundoNumero = Convert.ToInt32(Console.ReadLine());
                            Suma = primerNumero + SegundoNumero;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("la suma de {0} y {1} es {2}", primerNumero, SegundoNumero, Suma);
                            break;
                        case 2: //IF-ELSE
                            int edad;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Ingrese su edad: ");
                            edad = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            if (edad >= 18)
                            {
                                Console.WriteLine("Usted es Mayor de edad");
                            }
                            else
                            {
                                Console.WriteLine("Usted es Menor de edad");
                            }
                            break;
                        case 3: //WHILE
                            int fac = 1, x, n;
                            string linea;
                            x = 1;
                            Console.ForegroundColor= ConsoleColor.Green;
                            Console.Write("Ingrese un numero entero: ");
                            linea = Console.ReadLine();
                            n = int.Parse(linea);
                            while (x <= n)
                            {
                                fac = fac * x;
                                x = x + 1;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("La factorial es: " + fac);
                            Console.ReadKey();
                            break;
                        case 4: //DO-WHILE
                            string valida = "hola";
                            string clave;

                            do
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Introduzca su clave: ");
                                clave = Console.ReadLine();
                                if (clave != valida)
                                {
                                    Console.WriteLine("No valida!");
                                }
                            } while (clave != valida);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Valida!!");
                            break;
                        case 5: //FOR
                            int w;
                            string lines;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("Ingrese multiplicador: ");
                            lines = Console.ReadLine();
                            w = int.Parse(lines);
                            for (int i = 1; i <= 15; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write(i + " x " + w + " = " + i * w + "\n");
                            }
                            Console.ReadKey();
                            break;

                        case 6://SALIR
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Has elegido salir de la aplicación");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ResetColor();
                            salir = true;
                            break;                
                        default:
                            Console.WriteLine();
                            break;
                    }
                }
                catch (FormatException e)
                {

                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();

            }
        }
    }
}
