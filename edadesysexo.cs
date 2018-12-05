using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Eres hombre o mujer? hombre/mujer");
            String sexo = Console.ReadLine();
            Console.WriteLine("¿Eres sano? Si/No");
            String salud = Console.ReadLine();
            if (edad >= 18)
            {
                if (sexo == "hombre")
                {
                    if (salud == "si")
                    {
                        Console.WriteLine("DEBES hacer tu servicio militar, pues eres sano, macho y grande");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Tu salud no te permite hacer servicio");
                        Console.ReadKey();
                    }

                }
                else
                {
                    if (salud == "si")
                    {
                        Console.WriteLine("Puedes hacer tu servicio militar opcionalmente");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Tu salud no te permite hacer servicio");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("Eres muy pequeño para hacer servicio, niño");
                Console.ReadKey();
            }
            
            
        }
    }
}
