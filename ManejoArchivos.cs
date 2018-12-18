using System;
using System.IO;
namespace archivos1
{
    class Program
    {
        static void Main(string[] args)
        {


            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("||||Bienvenido||||");
                Console.WriteLine("Ingrese acción a realizar");
                Console.WriteLine("1.-Agregar Alumno\n2.-Modificar alumno\n3.-Eliminar alumno\n4.-Consultar alumno");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        String respuesta, matricula, nombre, carrera, grupo, turno, registro;
                        //Creamos el archivo
                        StreamWriter escritura1 = File.AppendText("C:/archivo/archivo.txt");
                        do
                        {
                            
                            Console.WriteLine("Ingresa la matrícula de un alumno: ");
                            matricula = Console.ReadLine();
                            Console.WriteLine("Ingresa el nombre de un alumno: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingresa la carrera de un alumno: ");
                            carrera = Console.ReadLine();
                            Console.WriteLine("Ingresa el grupo de un alumno: ");
                            grupo = Console.ReadLine();
                            Console.WriteLine("Ingresa el turno de un alumno: ");
                            turno = Console.ReadLine();
                            registro = matricula + "," + nombre + "," + carrera + "," + grupo + "," + turno;
                            escritura1.WriteLine(registro);
                            Console.Write("Deseas dar de alta otro alumno (s/n)");
                            respuesta = Console.ReadLine();
                        } while (respuesta!="n");
                        //Escribimos en el archivo
                        //texto.WriteLine("Bienvenido a las clases de Programación Orientada a Objetos");
                        escritura1.Close();
                        break;
                    case 2:
                        StreamReader lectura11;
                        StreamWriter escribir11;
                        String cadena11, alumno11, nuevoNombre11;
                        bool encontrado11;
                        encontrado11 = false;
                        String[] campos11 = new string[5];
                        try
                        {
                            lectura11 = File.OpenText("C:/archivo/archivo.txt");
                            escribir11 = File.CreateText("C:/archivo/tmp.txt");
                            Console.Write("Ingresa la matrícula del alumno a modificar:");
                            alumno11 = Console.ReadLine();
                            cadena11 = lectura11.ReadLine();

                            while (cadena11 != null)
                            {
                                campos11 = cadena11.Split(',');
                                if (campos11[0].Equals(alumno11))
                                {
                                    encontrado11 = true;
                                    Console.WriteLine("Matrícula: " + campos11[0]);
                                    Console.WriteLine("Nombre: " + campos11[1]);
                                    Console.WriteLine("Carrera: " + campos11[2]);
                                    Console.WriteLine("Grupo: " + campos11[3]);
                                    Console.WriteLine("Turno: " + campos11[4]);
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Ingresa el nuevo nombre del alumno: ");
                                    nuevoNombre11 = Console.ReadLine();
                                    escribir11.WriteLine(campos11[0] + "," + nuevoNombre11 + "," + campos11[2] + "," + campos11[3] + "," + campos11[4]);
                                    Console.WriteLine("Registro modificado");
                                }
                                else
                                {
                                    escribir11.WriteLine(cadena11);
                                }
                                cadena11 = lectura11.ReadLine();
                            }
                            if (encontrado11 == false)
                            {
                                Console.WriteLine("El alumno no se encuentra en el archivo");
                            }
                            lectura11.Close();
                            escribir11.Close();
                            File.Delete("C:/archivo/archivo.txt");
                            File.Move("C:/archivo/tmp.txt", "C:/archivo/archivo.txt");
                        }
                        catch (FileNotFoundException fe)
                        {
                            Console.WriteLine("Error" + fe.Message);
                        }
                        break;
                    case 3:
                        StreamReader lectura12;
                        StreamWriter escribir12;
                        String cadena12, alumno12;
                        bool encontrado12;
                        encontrado12 = false;
                        String[] campos12 = new string[5];
                        try
                        {
                            lectura12 = File.OpenText("C:/archivo/archivo.txt");
                            escribir12 = File.CreateText("C:/archivo/tmp.txt");
                            Console.Write("Ingresa la matrícula del alumno a eliminar:");
                            alumno12 = Console.ReadLine();
                            cadena12 = lectura12.ReadLine();

                            while (cadena12 != null)
                            {
                                campos12 = cadena12.Split(',');
                                if (campos12[0].Equals(alumno12))
                                {
                                    encontrado12 = true;
                                }
                                else
                                {
                                    escribir12.WriteLine(cadena12);

                                }
                                cadena12 = lectura12.ReadLine();
                            }
                            Console.WriteLine("Registro eliminado");
                            if (encontrado12 == false)
                            {
                                Console.WriteLine("El alumno no se encuentra en el archivo");
                            }
                            lectura12.Close();
                            escribir12.Close();
                            File.Delete("C:/archivo/archivo.txt");
                            File.Move("C:/archivo/tmp.txt", "C:/archivo/archivo.txt");
                        }
                        catch (FileNotFoundException fe)
                        {
                            Console.WriteLine("Error" + fe.Message);
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        StreamReader lectura15;
                        StreamWriter escribir15;
                        String cadena15, alumno15, nuevoNombre15;
                        bool encontrado15;
                        encontrado15 = false;
                        String[] campos15 = new string[5];
                        try
                        {
                            lectura15 = File.OpenText("C:/archivo/archivo.txt");
                            escribir15 = File.CreateText("C:/archivo/tmp.txt");
                            Console.Write("Ingresa la matrícula del alumno a consultar:");
                            alumno15 = Console.ReadLine();
                            cadena15 = lectura15.ReadLine();

                            
                                campos15 = cadena15.Split(',');
                                if (campos15[0].Equals(alumno15))
                                {
                                    encontrado15 = true;
                                    Console.WriteLine("Matrícula: " + campos15[0]);
                                    Console.WriteLine("Nombre: " + campos15[1]);
                                    Console.WriteLine("Carrera: " + campos15[2]);
                                    Console.WriteLine("Grupo: " + campos15[3]);
                                    Console.WriteLine("Turno: " + campos15[4]);
                                    Console.WriteLine("---------------------------------------------------");
                                    Console.WriteLine("Presione tecla para continuar");
                                    nuevoNombre15 = Console.ReadLine();
                                 }
                                                            
                            
                            if (!encontrado15)
                            {
                                Console.WriteLine("El alumno no se encuentra en el archivo");
                            }
                            lectura15.Close();
                            escribir15.Close();
                            File.Delete("C:/archivo/archivo.txt");
                            File.Move("C:/archivo/tmp.txt", "C:/archivo/archivo.txt");
                        }
                        catch (FileNotFoundException fe)
                        {
                            Console.WriteLine("Error" + fe.Message);
                        }
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No existe tal opcion");
                        break;

                }
            } while (opcion != 5);


            //Creamos el archivo




        }
    }
}
