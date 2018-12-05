using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos_Lista
{
    class Lista_Autos
    {



        static void Main(string[] args)
        {
            Auto autos = new Auto();
            List<Auto> lista_Auto = new List<Auto>();

            int opcion;
            do
            {
                do
                {
                    Console.WriteLine("||||Bienvenido||||||||");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1. Busqueda por matricula");
                    
                    Console.WriteLine("5. Salir");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion > 5);
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresa la matricula a buscar:");
                        int buscar = int.Parse(Console.ReadLine());
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

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;


                    case 4:
                        

                        break;

                    case 5:

                        break;
                }
            } while (opcion != 5);

        }
    }
}
