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
            Autos autos = new Autos();
            List<Autos> lista_Auto = new List<Autos>();

            int opcion;
            do
            {
                do
                {
                    Console.WriteLine("||||Bienvenido||||||||");
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1. Agregar auto");
                    Console.WriteLine("2. Busqueda por matricula");
                    Console.WriteLine("3. Mostrar autos en base de datos");
                    Console.WriteLine("5. Salir");
                    opcion = int.Parse(Console.ReadLine());
                } while (opcion < 1 || opcion > 5);
                switch (opcion)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Ingrese La matricula:");
                        autos.Matricula = Console.ReadLine();
                        Console.WriteLine("Ingrese la marca:");
                        autos.Marca = Console.ReadLine();
                        Console.WriteLine("Ingrese el modelo:");
                        autos.Modelo = Console.ReadLine();
                        Console.WriteLine("Ingrese el año del auto:");
                        autos.Anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el color del auto:");
                        autos.Color = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de puertas:");
                        autos.NoPuertas = int.Parse(Console.ReadLine());

                        lista_Auto.Add(autos);


                        Console.Clear();
                        Console.WriteLine("----Elemento agregado-------------");
                        Console.WriteLine("Matrícula: " + autos.Matricula);
                        Console.WriteLine("Marca: " + autos.Marca);
                        Console.WriteLine("Modelo: " + autos.Modelo);
                        Console.WriteLine("Año: " + autos.Anio);
                        Console.WriteLine("Color: " + autos.Color);
                        Console.WriteLine("Numero de puertas: " + autos.NoPuertas);
                        Console.WriteLine("");
                        Console.WriteLine("------------------------------");
                        Console.ReadKey();


                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa la matricula a buscar:");
                        string buscar = Console.ReadLine();
                        foreach (Autos auto in lista_Auto)
                        {
                            if (auto.Matricula == buscar)
                            {
                                Autos autobuscar = new Autos();
                                int posicion = lista_Auto.IndexOf(auto);
                                Console.WriteLine("Se ha encontrado el auto. La matricula es" + auto.Matricula+ " y la marca es "+auto.Marca);
                            }
                            else
                            {
                                Console.WriteLine("No existe tal auto");
                            }
                        }
                        break;

                    case 3:
                        
                        
                        foreach (Autos elemento in lista_Auto)
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Matrícula: " + elemento.Matricula);
                            Console.WriteLine("Marca: " + elemento.Marca);
                            Console.WriteLine("Modelo: " + elemento.Modelo);
                            Console.WriteLine("Año: " + elemento.Anio);
                            Console.WriteLine("Color: " + elemento.Color);
                            Console.WriteLine("Numero de puertas: " + elemento.NoPuertas);
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------");
                        }
                        Console.ReadKey();
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
