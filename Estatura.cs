using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> estrato1 = new List<double>();
            List<double> estrato2 = new List<double>();
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Introduce la estatura de un niño de estrato A");
                double estatura1 = double.Parse(Console.ReadLine());
                estrato1.Add(estatura1);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Introduce la estatura de un niño de estrato B");
                double estatura2 = double.Parse(Console.ReadLine());
                estrato2.Add(estatura2);
            }
            Console.Clear();
            double suma1 = 0;
            double suma2 = 0;
            Console.WriteLine("La lista de los niños de estrato A es: ");
            foreach (double elemento in estrato1)
            {
                suma1 = suma1 + elemento;
                Console.WriteLine(elemento);
            }
            
            
            Console.WriteLine("La lista de los niños de estrato B es: ");
            foreach (double elemento in estrato2)
            {
                suma2 = suma2 + elemento;
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            double promedio1;
            double promedio2;
            promedio1 = suma1 / 5;
            promedio2 = suma2 / 5;

            if (promedio1 > promedio2)
            {
                Console.WriteLine("La estatura de los niños del estrato A es mayor que los del estrato B");
            }
            else if (promedio1 == promedio2)
            {
                Console.WriteLine("La estatura de los niños de ambos estratos no presenta diferencia");
            }
            else
            {
                Console.WriteLine("La estatura de los niños del estrato B es mayor");
            }
            Console.ReadKey();

        }
    }
}
