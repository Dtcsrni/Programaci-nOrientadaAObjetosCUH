using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productos = new List<string>();
            List<double> precios = new List<double>();
            string sino;
            do
            {
                Console.WriteLine("||||Bienvenido||||");
                Console.WriteLine("Ingresa un producto a la lista");
                string producto = Console.ReadLine();
                productos.Add(producto);
                Console.WriteLine("Ingresa el precio del producto");
                double precio = double.Parse(Console.ReadLine());
                precios.Add(precio);
                Console.WriteLine("Deseas dar de alta otro producto? S/N");
                sino = Console.ReadLine();
            } while (sino == "s" | sino == "S");
            int c = 0;
            int maxi = productos.Count();
            while (c < maxi)
            {
                Console.WriteLine("-Producto: " + productos[c] + " su precio es $" + precios[c]);
                c++;
            }
            Console.WriteLine("\nDeseas cambiar el precio de algún producto? S/N");
            string sino1 = Console.ReadLine();
            int c1 = 0;
            int maxi1 = productos.Count();
            if(sino1=="s" | sino1 == "S")
            {
                int posicion=0;
                string modifica;
                do {
                    Console.Clear();
                    Console.WriteLine("Ingresa el producto a modificar");
                    modifica = Console.ReadLine();
                     posicion = productos.IndexOf(modifica);
                    if (posicion == -1)
                    {
                        Console.WriteLine("No existe el producto, intente de nuevo ");
                        Console.ReadKey();
                    }
                } while (posicion == -1 );






                Console.WriteLine("Ingresa el nuevo precio del producto");
                double nuevo = double.Parse(Console.ReadLine());
                precios[posicion] = nuevo;
                while (c1 < maxi1)
                {
                    Console.WriteLine("Producto " + productos[c1] + " su precio es $" + precios[c1]);
                    c1++;
                    
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Gracias por usar este programa, ADIOS"); ;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Gracias por usar este programa, ADIOS");
                Console.ReadKey();
            }
            Console.ReadKey();



        }
    }
}
