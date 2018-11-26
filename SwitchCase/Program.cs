using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elige un día de la semana \n 1.-Lunes 2.- Martes 3.-Miercoles 4.-Jueves 5.-Viernes");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("El día que elegiste es LUNES");
                    break;
                case 2:
                    Console.WriteLine("El día que elegiste es MARTES");
                    break;
                case 3:
                    Console.WriteLine("El día que elegiste es MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("El día que elegiste es JUEVES");
                    break;
                case 5:
                    Console.WriteLine("El día que elegiste es VIERNES");
                    break;
            }
            Console.ReadKey();
        }
    }
}
