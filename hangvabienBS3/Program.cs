using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[2];
            double[] b = new double[2];
            Console.WriteLine("Nhap toa do diem A:");
            Console.Write("\tx = ");
            a[0] = double.Parse(Console.ReadLine());
            Console.Write("\ty = ");
            a[1] = double.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap toa do diem A:");
            Console.Write("\tx = ");
            b[0] = double.Parse(Console.ReadLine());
            Console.Write("\ty = ");
            b[1] = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2));
            Console.WriteLine("<------------------------------>");
            Console.WriteLine("Khoang cach giua 2 diem la: {0}", distance);
            Console.WriteLine("<------------------------------>");
            Console.ReadKey();
        }
    }
}
