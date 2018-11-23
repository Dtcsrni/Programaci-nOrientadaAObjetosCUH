using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estaturas2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> estrato1 = new List<float>();
            List<float> estrato2 = new List<float>();
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Introduce la estatura de un niño de estrato A");
                float estatura1 = float.Parse(Console.ReadLine());
                estrato1.Add(estatura1);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine("Introduce la estatura de un niño de estrato B");
                float estatura2 = float.Parse(Console.ReadLine());
                estrato2.Add(estatura2);
            }
            Console.Clear();
            float suma1 = 0;
            float suma2 = 0;
            Console.WriteLine("La lista de los niños de estrato A es: ");
            foreach (float elemento in estrato1)
            {
                suma1 = suma1 + elemento;
                Console.WriteLine(elemento);
            }


            Console.WriteLine("La lista de los niños de estrato B es: ");
            foreach (float elemento in estrato2)
            {
                suma2 = suma2 + elemento;
                Console.WriteLine(elemento);
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            float promedio1;
            float promedio2;
            float porcentaje1;
            promedio1 = suma1 / 5;
            promedio2 = suma2 / 5;

            if (promedio1 > promedio2)
            {
                Console.Write("La estatura de los niños del estrato A es mayor que los del estrato B ");
                porcentaje1 = (promedio2 * 100) / promedio1;
                porcentaje1 = 100 - porcentaje1;
                if(porcentaje1>10)
                Console.Write("pues su porcentaje de alturas es de "+porcentaje1+" lo que supera o iguala el 10%, por lo que la hipótesis es cierta");
                else
                {
                Console.Write("aunque la diferencia de alturas es de " + porcentaje1 + " lo que no supera o iguala el 10%, por lo que la hipótesis es falsa en este caso");
                }

            }
            else if (promedio1 == promedio2)
            {
                Console.WriteLine("La estatura de los niños de ambos estratos no presenta diferencia, la hipótesis es falsa");
            }
            else
            {
                Console.WriteLine("La estatura de los niños del estrato B es mayor ");
                porcentaje1 = (promedio1 * 100) / promedio2;
                porcentaje1 = 100 - porcentaje1;
                Console.Write("pues su porcentaje de alturas es " + porcentaje1 + " mayor,  por lo que la hipótesis es falsa");

            }
            Console.ReadKey();

        }
    }
}
