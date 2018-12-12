using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista_Alumnoss
{
    class Alumnoclase
    {



        static void Main(string[] args)
        {
            Alumno alumnos = new Alumno();
            List<Alumno> lista_alumno = new List<Alumno>();

            int opcion;
            do
            {
                do
                {
                    Console.WriteLine("||||Bienvenido||||||Menu Opciones||");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1. Ingresar a un alumno");
                    Console.WriteLine("2. Modifica un nombre de la lista");
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

                        StreamWriter escritura = File.AppendText("C:/alumnos.txt");

                        escritura.WriteLine(alumnos.Nombre+""+alumnos.Carrera+""+alumnos.Turno+""+alumnos.Grupo+""+alumnos.Matricula);

                        escritura.Close();

                        Console.Clear();
                        Console.WriteLine("\n--Datos de alumno " + alumnos.Nombre + " agregados a la base \n");

                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa la matricula:");
                        int modifica = int.Parse(Console.ReadLine());
                        foreach (Alumno alumno in lista_alumno)
                        {
                            if (alumno.Matricula == modifica)
                            {
                                Alumno alumnomodif = new Alumno();
                                int posicion = lista_alumno.IndexOf(alumno);
                                Console.Write("Ingresa el nuevo nombre del alumno");
                                alumnomodif.Nombre = Console.ReadLine();
                                lista_alumno[posicion].Nombre = alumnomodif.Nombre;
                                Console.Write("Ingresa la nueva carrera del alumno: ");
                                alumnomodif.Carrera = Console.ReadLine();
                                lista_alumno[posicion].Carrera = alumnomodif.Carrera;
                                Console.Write("Ingresa el nuevo grupo del alumno");
                                alumnomodif.Grupo = Console.ReadLine();
                                lista_alumno[posicion].Grupo = alumnomodif.Grupo;
                                Console.Write("Ingresa el nuevo turno del alumno: ");
                                alumnomodif.Turno = Console.ReadLine();
                                lista_alumno[posicion].Turno = alumnomodif.Turno;
                            }

                        }



                        break;

                    case 3:
                        Console.Write("Ingresa la matricula del alumno a eliminar");
                        int elimina = int.Parse(Console.ReadLine());
                        lista_alumno.RemoveAll(alumno => alumno.Matricula == elimina);
                        Console.Write("El registro del alumno se eliminó con exito \n");
                        Console.Write("");
                        break;


                    case 4:
                        foreach (Alumno elemento in lista_alumno)
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Matrícula: " + elemento.Matricula);
                            Console.WriteLine("Nombre: " + elemento.Nombre);
                            Console.WriteLine("Carrera: " + elemento.Carrera);
                            Console.WriteLine("Grupo: " + elemento.Grupo);
                            Console.WriteLine("Turno: " + elemento.Turno);
                            Console.WriteLine("");
                        }

                        break;

                    case 5:

                        break;
                }
            } while (opcion != 5);

        }
    }
}
