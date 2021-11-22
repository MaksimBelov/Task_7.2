using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            CalcCube(a, out double V, out double S);
            Console.WriteLine();
            Console.WriteLine("Объем куба: {0}", V);
            Console.WriteLine("Площадь поверхности куба: {0}", S);
            Console.ReadKey();
        }
        static void CalcCube (double a, out double V, out double S)
        {
            V = Math.Round(Math.Pow(a, 3), 2);
            S = 6 * a * a;
        }

    }
}
