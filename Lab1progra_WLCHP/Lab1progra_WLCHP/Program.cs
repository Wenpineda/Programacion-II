using System;

namespace Lab1progra_WLCHP
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomlibro, autor, edicion, pais;
            int fecha, longitud, indice = 0, indiceedit, opc, menu = 1;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t*************************************");
            Console.WriteLine("\t*       //   Bienvenidos    //      *");
            Console.WriteLine("\t*  //       BIBLIOTECA 24/7     //  *");
            Console.WriteLine("\t*      //        UwU        //      *");
            Console.WriteLine("\t*************************************");
            Console.ResetColor();
            Console.WriteLine();
            try
            {
                Console.WriteLine("Ingresa el tamaño de la lista de los libros porfavor: ");
                longitud = Convert.ToInt32(Console.ReadLine());
                string[] RegLibros = new string[longitud];

                while (menu != 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("1-Registrar un nuevo Libro");
                    Console.WriteLine("2-Mostrar los Libros registrados");
                    Console.WriteLine("3-Buscar un Libro");
                    Console.WriteLine("4-Editar un Libro");
                    Console.WriteLine("5-Eliminar un Libro");
                    Console.WriteLine("6-Salir\n");
                    Console.ResetColor();

                    opc = Convert.ToInt32(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ingrese el nombre del libro: ");
                            nomlibro = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del autor del libro: ");
                            autor = Console.ReadLine();
                            Console.WriteLine("Ingrese la edicion del libro: ");
                            edicion = Console.ReadLine();
                            Console.WriteLine("Ingrese el pais: ");
                            pais = Console.ReadLine();
                            Console.WriteLine("Ingrese la fecha o el año de publicacion del libro: ");
                            fecha = Convert.ToInt32(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();

                            if (indice < RegLibros.Length)
                            {
                                RegLibros[indice] = nomlibro;
                                RegLibros[indice + 1] = autor ;
                                RegLibros[indice + 2 ] = edicion;
                                RegLibros[indice + 3] = pais;
                                RegLibros[indice + 4] = Convert.ToString(fecha);
                                indice += 5;
                            }
                            else
                            {
                                Console.WriteLine("El almacenamiento esta lleno");
                            }
                            break;
                        case 2:
                            {
                                for (int i = 0; i < indice; i+= 5)
                                {
                                    Console.WriteLine(i + " " + RegLibros[i] + " " + RegLibros[i + 1] + " " + RegLibros[i + 2] + " " + RegLibros[i + 3] + " " + RegLibros[i + 4] );
                                    Console.WriteLine();
                                }

                            }

                            break;
                        case 3:
                            {
                                Console.WriteLine("Igrese el nombre del libroa buscar: ");
                                nomlibro = Console.ReadLine();
                                if (indice != 0 && indice < RegLibros.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegLibros[i] == nomlibro )
                                        {
                                            Console.WriteLine(i + " " + RegLibros[i] + " " + RegLibros[i + 1] + " " + RegLibros[i + 2] + " " + RegLibros[i + 3] + " " + RegLibros[i + 4]);
                                            Console.WriteLine();
                                        }
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("El almacenamiento esta vacio");
                                }
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Ingrese le dato a modificar del libro: ");
                                nomlibro = Console.ReadLine();
                                if (indice != 0 && indice < RegLibros.Length)
                                {
                                    for (int i = 0; i < indice; i++)
                                    {
                                        if (RegLibros [i] == nomlibro)
                                        {
                                            Console.WriteLine("Ingrese la nueva informacion: ");
                                            nomlibro = Console.ReadLine();
                                            RegLibros[i] = nomlibro;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El almacenamiento esta vacio");
                                }
                            }
                            break;
                        case 5:
                            Console.WriteLine("Ingese el nombre del libro a eliminar");
                            nomlibro = Console.ReadLine();
                            if (indice != 0 && indice < RegLibros.Length)
                            {
                                for (int i = 0; i < indice; i++)
                                {
                                    if (RegLibros[i] == nomlibro)
                                    {
                                        for (int j = i; j < indice; j++)
                                        {
                                            RegLibros[i] = RegLibros[i + 5];
                                        }
                                        indice -= 5;
                                    }
                                }
                            }
                            else
                            {

                            }
                            break;
                        case 6:
                            menu = 0;
                            break;
                        default:
                            Console.WriteLine("La opcion que ha elegido no es valida");
                            break;
                    }
                }
            }
            catch (Exception e )
            {

                Console.WriteLine("Ha ocurrido un error durante la ejecucion del programa!" + e.Message);
            }
        }
    }
}
