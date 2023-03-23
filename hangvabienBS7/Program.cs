using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ho ten cua ban: ");
            string hoTen = Console.ReadLine();
            string ho = hoTen.Substring(0, hoTen.IndexOf(" "));
            string hoDem = hoTen.Substring(hoTen.IndexOf(" ")+1,hoTen.LastIndexOf(" ")-hoTen.IndexOf(" "));
            string ten = hoTen.Substring(hoTen.LastIndexOf(" ") + 1, hoTen.Length - 1 - hoTen.LastIndexOf(" "));
            Console.WriteLine("<------------------------------->");
            Console.WriteLine("Ho cua ban la: {0}", ho);
            Console.WriteLine("Ho dem cua ban la: {0}", hoDem);
            Console.WriteLine("Ten cua ban la: {0}", ten);
            Console.WriteLine("<------------------------------->");
            Console.ReadKey();
        }
    }
}
