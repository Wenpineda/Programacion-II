using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio: Un programa que pida al usuario 4 números, 
 * los memorice (utilizando una tabla), calcule su media aritmética y
 * después muestre en pantalla la media y los datos tecleados.*/

namespace EjercicioClase_02
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Ingrese cuatro numeros 4 \n");
                Console.ResetColor();

                int[] numeros = new int[4];
                int suma;

                Console.ForegroundColor= ConsoleColor.Cyan;
                WriteLine("Ingrese el numero 1: ");
                numeros[0] = int.Parse(Console.ReadLine());

                WriteLine("Ingrese el numero 2: ");
                numeros[1] = int.Parse(Console.ReadLine());

                WriteLine("Ingrese el numero 3: ");
                numeros[2] = int.Parse(Console.ReadLine());

                WriteLine("Ingrese el numero 4: ");
                numeros[3] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
                Console.ResetColor();

                Console.ForegroundColor=ConsoleColor.Green;
                WriteLine("La media aritmetica de los numeros " + numeros[0] + " - " + numeros[1] + " - " + numeros[2] + " - " + numeros[3] + " es de: " + suma);
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                WriteLine("Ocurrio un error en la ejecucion del programa " + e.Message);
                Console.ResetColor();
            }
        }

    }
}