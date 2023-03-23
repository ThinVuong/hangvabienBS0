using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangvabienBS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So tien gui: ");
            int tienGui = int.Parse(Console.ReadLine());
            Console.Write("Lai suat (%nam): ");
            double lai = double.Parse(Console.ReadLine());
            Console.Write("So thang gui: ");
            int thangGui = int.Parse(Console.ReadLine());
            double tienLai = tienGui * lai / 1200 * thangGui;
            Console.WriteLine("<--------------------------------------->");
            Console.WriteLine("So tien lai nhan duoc: {0} d", tienLai);        
            Console.WriteLine("Tong so tien nhan duoc: {0} d", tienGui+tienLai);
            Console.WriteLine("<--------------------------------------->");
            Console.ReadKey();
        }
    }
}
