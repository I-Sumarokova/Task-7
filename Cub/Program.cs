using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба l=");
            double l = Convert.ToDouble(Console.ReadLine());
            double S, V;

            GetParam( l, out S, out V);
            Console.WriteLine("Площадь поверхности куба равна S ={0:F2}",S);
            Console.WriteLine("Объем куба равен V ={0:F2}", V);
            Console.ReadKey();

        }
        static void GetParam(double l, out double S, out double V)
        {
            S = (Math.Pow(l, 2)) * 6;
            V = Math.Pow(l, 3);
        }
    }
}
