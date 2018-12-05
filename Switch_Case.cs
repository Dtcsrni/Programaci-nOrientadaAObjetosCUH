using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizado por Erick Renato Vega Cerón
//26 de noviembre del 2018

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            do
            {
                Console.WriteLine("Elige una operacion a realizar \n 1.-Area Cuadrado 2.- Area Cubo 3.-Area triangulo 4.-Area Circulo 5.-Salir");
                dia = int.Parse(Console.ReadLine());
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Area Cuadrado\n Ingrese la altura del cuadrado");
                        float altura = int.Parse(Console.ReadLine());
                        altura *= altura;
                        Console.WriteLine("El area es " + altura);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Area Cubo\n Ingrese un lado del cubo");
                        float lado = int.Parse(Console.ReadLine());
                        lado = 6 * (lado * lado);
                        Console.WriteLine("El area es " + lado);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Area triangulo\n Ingrese la base del triangulo");
                        float bases = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area triangulo\n Ingrese la altura del triangulo");
                        float alturaa = int.Parse(Console.ReadLine());
                        float area = (bases * alturaa) / 2;
                        Console.WriteLine("El area es " + area);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Area Círculo\n Ingrese el radio del circulo");
                        float radio = int.Parse(Console.ReadLine());
                        double area1 = Math.PI * (radio * radio);
                        Console.WriteLine("El area es " + area1);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            } while (dia!=5);
        }
    }
}
