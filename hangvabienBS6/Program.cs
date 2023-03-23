using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chieu cao cua ban la: height = ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Can nang cua ban la: weight = ");
            double weight = double.Parse(Console.ReadLine());
            double BMI = weight / Math.Pow(height,2);
            string result = (BMI < 18.5) ? "thieu can" : (BMI >= 18.5 && BMI < 25) ? "binh thuong" : (BMI >= 25 && BMI < 30) ? "thua can" : "beo phi";
            Console.WriteLine("<--------------------------------->");
            Console.WriteLine("BMI cua ban cho thay ket qua: ban la dang {0}", result);
            Console.WriteLine("<--------------------------------->");
            Console.ReadKey();
        }
    }
}
