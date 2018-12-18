using System;
using System.IO;
namespace archivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            String respuesta, matricula, nombre, carrera, grupo, turno,registro;
            //Creamos el archivo
            StreamWriter escritura = File.AppendText("c:/users/ismael/alumnos.txt");
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
                escritura.WriteLine(registro);
                Console.Write("Deseas dar de alta otro alumno (S/N)");
                respuesta = Console.ReadLine();
            } while (respuesta.Equals("S"));
            //Escribimos en el archivo
            //texto.WriteLine("Bienvenido a las clases de Programación Orientada a Objetos");
            escritura.Close();

            StreamReader lectura;
            StreamWriter escribir;
            String cadena, alumno, nuevoNombre;
            bool encontrado;
            encontrado = false;
            String[] campos = new string[5];
            try
            {
                lectura = File.OpenText("c:/users/ismael/alumnos.txt");
                escribir = File.CreateText("c:/users/ismael/tmp.txt");
                Console.Write("Ingresa la matrícula del alumno a modificar:");
                alumno = Console.ReadLine();
                cadena = lectura.ReadLine();
                
                while (cadena!=null)
                {
                    campos = cadena.Split(",");
                    if (campos[0].Equals(alumno))
                    {
                        encontrado = true;
                        Console.WriteLine("Matrícula" + campos[0]);
                        Console.WriteLine("Nombre" + campos[1]);
                        Console.WriteLine("Carrera" + campos[2]);
                        Console.WriteLine("Grupo" + campos[3]);
                        Console.WriteLine("Turno" + campos[4]);
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Ingresa el nuevo nombre del alumno: ");
                        nuevoNombre = Console.ReadLine();
                        escribir.WriteLine(campos[0] + "," + nuevoNombre + "," + campos[2] + "," + campos[3] + "," + campos[4]);
                        Console.WriteLine("Registro modificado");
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }
                    cadena = lectura.ReadLine();
                }
                if (encontrado == false)
                {
                    Console.WriteLine("El alumno no se encuentra en el archivo");
                }
                lectura.Close();
                escribir.Close();
                File.Delete("c:/users/ismael/alumnos.txt");
                File.Move("c:/users/ismael/tmp.txt", "c:/users/ismael/alumnos.txt");
            }catch(FileNotFoundException fe)
            {
                Console.WriteLine("Error" + fe.Message);
            }
            StreamReader lectura1;
            StreamWriter escribir1;
            String cadena1, alumno1;
            bool encontrado1;
            encontrado1 = false;
            String[] campos1 = new string[5];
            try
            {
                lectura1 = File.OpenText("c:/users/ismael/alumnos.txt");
                escribir1 = File.CreateText("c:/users/ismael/tmp.txt");
                Console.Write("Ingresa la matrícula del alumno a eliminar:");
                alumno1 = Console.ReadLine();
                cadena1 = lectura1.ReadLine();

                while (cadena1!= null)
                {
                    campos1 = cadena1.Split(",");
                    if (campos1[0].Equals(alumno1))
                    {
                        encontrado1 = true;
                    }
                    else
                    {
                        escribir1.WriteLine(cadena1);
                        
                    }
                    cadena1 = lectura1.ReadLine();
                }
                Console.WriteLine("Registro eliminado");
                if (encontrado1 == false)
                {
                    Console.WriteLine("El alumno no se encuentra en el archivo");
                }
                lectura1.Close();
                escribir1.Close();
                File.Delete("c:/users/ismael/alumnos.txt");
                File.Move("c:/users/ismael/tmp.txt", "c:/users/ismael/alumnos.txt");
            }
            catch (FileNotFoundException fe)
            {
                Console.WriteLine("Error" + fe.Message);
            }
            Console.ReadKey();
        }
    }
}
