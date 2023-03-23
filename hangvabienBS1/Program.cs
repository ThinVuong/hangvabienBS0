using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.Write($"Nhap so nguyen {nameof(a)}: ");
            a = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so nguyen {nameof(b)}: ");
            b = int.Parse(Console.ReadLine());
            Console.Write($"Nhap so nguyen {nameof(c)}: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("<---------------------------------->");
            Console.WriteLine("So lon nhat trong 3 so la {0}", Math.Max(a, Math.Max(b,c)));
            Console.WriteLine("<---------------------------------->");
            Console.ReadKey();
        }
    }
}
