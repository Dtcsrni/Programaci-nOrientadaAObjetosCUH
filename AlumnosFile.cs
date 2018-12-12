using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista_Alumnoss
{
    class AlumnosFile
    {


        
        static void Main(string[] args)
        {
            Alumno alumnos = new Alumno();
            string ruta = "C:/Users/EA-25-6/Desktop/alumnos.txt";

            int opcion;
            do
            {
                do
                {
                    Console.WriteLine("||||Bienvenido||||||Menu Opciones||");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1. Ingresar a un alumno");
                    Console.WriteLine("2. buscar un nombre de la lista");
                    Console.WriteLine("3. Borra un nombre de la lista");
                    Console.WriteLine("4. Imprime en pantalla la lista completa");
                    Console.WriteLine("5. Salir");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion > 5);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre completo:");
                        alumnos.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la carrera:");
                        alumnos.Carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese el turno:");
                        alumnos.Turno = Console.ReadLine();
                        Console.WriteLine("Ingrese un grupo:");
                        alumnos.Grupo = Console.ReadLine();
                        Console.WriteLine("Ingrese la matricula:");
                        alumnos.Matricula = int.Parse(Console.ReadLine());

                        StreamWriter escritura = File.AppendText(ruta);

                        escritura.WriteLine(alumnos.Nombre+","+alumnos.Carrera+","+alumnos.Turno+","+alumnos.Grupo+","+alumnos.Matricula);

                        escritura.Close();

                        Console.Clear();
                        Console.WriteLine("\n--Datos de alumno " + alumnos.Nombre + " agregados a la base \n");

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa la matricula del alumno a buscar:");
                        int buscar = int.Parse(Console.ReadLine());

                        string alumno;
                        try
                        {
                            StreamReader lectura = File.OpenText(ruta);
                            Console.Write("Ingresa la matricula del alumno a buscar");
                            
                        }



                        break;

                    case 3:
                        


                    case 4:
                        

                    case 5:

                        break;
                }
            } while (opcion != 5);

        }
    }
}
