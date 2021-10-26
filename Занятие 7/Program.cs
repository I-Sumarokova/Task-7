using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону труегольника x1=");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону труегольника y1=");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону труегольника z1=");
            int z1 = Convert.ToInt32(Console.ReadLine());
            double p1,S1;

            Console.WriteLine("Введите сторону труегольника x2=");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону труегольника y2=");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону труегольника z2=");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double p2, S2;

            if (x1 > y1 + z1 || y1 > x1 + z1 || z1 > x1 + y1)
            {
                Console.WriteLine("Такого треугольника не существует");
               
            }
            else if (x2 > y2 + z2 || y2 > x2 + z2 || z2 > x2 + y2)
            {
                Console.WriteLine("Такого треугольника не существует");
               
            }

            GetParam1 (x1, y1, z1, out p1, out S1);
            GetParam2(x2, y2, z2, out p2, out S2);

            Console.Write("p1 = {0:F2}",p1);
            Console.Write("   S1 = {0:F2}",S1);
            Console.WriteLine();

            Console.Write("p2 = {0:F2}", p2);
            Console.Write("   S2 = {0:F2}", S2);
            Console.WriteLine();


            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого трегольника больше, S1={0:F2}", S1);
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь второго трегольника больше, S2={0:F2}", S2);
            }
            else
            {
                Console.WriteLine("Площади первого и второго трегольников равны, S={0:F2}", S2);
            }
            Console.ReadKey();

        }
        static void GetParam1(int x1, int y1, int z1, out double p1, out double S1)
        {
            p1 = (x1 + y1 + z1) * 0.5;
            S1 = Math.Sqrt((p1 * (p1 - x1) * (p1 - y1) * (p1 - z1)));
        }

        static void GetParam2(int x2, int y2, int z2, out double p2, out double S2)
        {
            p2 = (x2 + y2 + z2) * 0.5;
            S2 = Math.Sqrt((p2 * (p2 - x2) * (p2 - y2) * (p2 - z2)));
        }

    }

}
