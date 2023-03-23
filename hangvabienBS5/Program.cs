using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a = ");
            int a = int.Parse(Console.ReadLine());
            string chanLe;
            Console.WriteLine("<------------------------------------->");
            if (a%2==0)
            {
                chanLe = "chan";
            }
            else
            {
                chanLe = "le";
            }
            Console.WriteLine($"a la so {chanLe}");
            Console.WriteLine("<------------------------------------->");
            Console.ReadKey();

        }
    }
}
