using System;
using static System.Console;

namespace ListStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int codigo;
            string carrera;
            int longitud, indice = 0, indiceEditar, opc, menu = 1;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t////////LISTA DE Estudiantes////////");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t************************************");
            Console.ResetColor();
            Console.WriteLine();
            try
            {
                WriteLine("Ingrese el tamaño de la lista de estudiantes (Multiplo de 4): ");
                longitud = Convert.ToInt32(ReadLine());
               string[] RegEstudiante = new string[longitud];

                while (menu != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    WriteLine("1- Registrar nuevo estudiante");
                    WriteLine("2- Mostrar lista de estudiantes");
                    WriteLine("3- Buscar un estudiante");
                    WriteLine("4- Editar registo de estudiante");
                    WriteLine("5- Eliminar registro de estudiante");
                    WriteLine("6- Salir del programa\n");
                    Console.ResetColor();
                    opc = Convert.ToInt32(ReadLine());
                    Console.WriteLine();
                    switch (opc)
                    {
                        //Insertar nuevos registros de estudiantes
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 1\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                WriteLine("*- Ingrese el nombre: ");
                                nombre = ReadLine();
                                WriteLine("*- Ingrese el apellido: ");
                                apellido = ReadLine();
                                WriteLine("*- Ingres el codigo de estudiante: ");
                                codigo = Convert.ToInt32(ReadLine());
                                WriteLine("*- Ingrese la carrera de estudio: ");
                                carrera = ReadLine();
                                Console.ResetColor();
                                if (indice < RegEstudiante.Length)
                                {
                                    RegEstudiante[indice] = nombre;
                                    RegEstudiante[indice+1] = apellido;
                                    RegEstudiante[indice+2] = Convert.ToString(codigo);
                                    RegEstudiante[indice+3] = carrera;
                                    indice += 4;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    WriteLine("Almacemiento lleno!!");
                                    Console.ResetColor();
                                }
                                break;
                            }
                            //Mostrar todos los registros de estudiantes
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 2\n");
                                Console.ResetColor();
                                for (int i=0; i< indice; i+=4 )
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    WriteLine(+i+" - "+RegEstudiante[i]+" - "+RegEstudiante[i+1]+" - "+RegEstudiante[i+2]+" - "+RegEstudiante[i+3]);
                                    Console.ResetColor();
                                }
                                break;
                            }
                        case 3:
                            //Buscar un registro de estudiante por nombre
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 3\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                WriteLine("*- Ingrese el nombre del estudiante a buscar: ");
                                nombre = ReadLine();
                                Console.WriteLine();
                                Console.ResetColor();
                                if (indice != 0 && indice < RegEstudiante.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegEstudiante[i] == nombre)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            WriteLine(i + " - " + RegEstudiante[i] + " - " + RegEstudiante[i + 1] + " - " + RegEstudiante[i + 2] + " - " + RegEstudiante[i + 3]);
                                            Console.ResetColor();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    WriteLine("El almacemiento esta vacio!!");
                                    Console.ResetColor();
                                }
                                break;
                            }
                                //Editar un registro de estudiante
                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 4\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                WriteLine("*- Ingrese el dato a modificar del estudiante");
                                nombre = ReadLine();
                                Console.ResetColor();
                                if (indice !=0 && indice < RegEstudiante.Length)
                                {
                                    for (int i=0; i<indice; i++)
                                    {
                                        if (RegEstudiante[i]==nombre)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            WriteLine("*- Ingrese la nueva información: ");
                                            nombre = ReadLine();
                                            RegEstudiante[i] = nombre;
                                            Console.ResetColor();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    WriteLine("El almacenamiento esta vacio!!");
                                    Console.ResetColor();
                                }
                                break;
                            }
                            //Eliminar Registro de estudiantes
                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 5\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                WriteLine("*- Ingrese el nombre del estudinates: ");
                                nombre = ReadLine();
                                Console.ResetColor();
                                if (indice !=0 && indice < RegEstudiante.Length)
                                {
                                    for (int i=0; i<indice; i++)
                                    {
                                        if (RegEstudiante[i]==nombre)
                                        {
                                            for (int j=i; j<indice; j++)
                                            {
                                                RegEstudiante[j] = RegEstudiante[j + 4];                                                
                                            }
                                            indice -= 4;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    WriteLine("El almacenamiento esta vacio!!");
                                    Console.ResetColor();
                                }
                                break;
                            }
                        case 6:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Opcion: 5\n");       
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Usted ha descidido salir de la aplicacion!");
                                menu = 0;
                                Console.WriteLine();
                                Console.WriteLine("Presione ENTER para continuar");
                                Console.ResetColor();
                                break;
                            }
                        default:
                            WriteLine("La opción elejida no es valida");
                            break;

                            
                    }
                }
            }
            catch (Exception e)
            {
                WriteLine("Ocurrio un error en la ejecución del programa " + e.Message);
            }
            

        
        }
    }
}
