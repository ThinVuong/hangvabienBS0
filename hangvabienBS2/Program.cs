using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap nhiet dộ theo do C: input = ");
            double input = double.Parse(Console.ReadLine());
            double output = (input * 9 / 5) + 32;
            Console.WriteLine("<----------------------------->");
            Console.WriteLine("Nhiet do vua nhap theo do F la: output = {0}", output);
            Console.WriteLine("<----------------------------->");
            Console.ReadKey();
        }
    }
}
