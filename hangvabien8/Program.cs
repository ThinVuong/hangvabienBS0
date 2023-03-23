using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hangvabien8
{
    internal class Program
    {
        struct thongTinSP
        {
            public string tenSP;
            public int soLuong;
            public int giaSP;
        }
        static void Main(string[] args)
        {
            thongTinSP a = new thongTinSP();
            a = NhapTTSP();
            double thueVAT = (double) 8/100;
            Func<int, int, int>giaChuaVAT = (x,y) => x*y;
            Func<int,double> giaVAT = x => x + thueVAT * x;
            Console.WriteLine("<------------------------------->");
            Console.WriteLine("Gia chua VAT: {0}",giaChuaVAT(a.soLuong,a.giaSP));
            Console.WriteLine("Gia VAT: {0}",giaVAT(giaChuaVAT(a.soLuong,a.giaSP)));
            Console.WriteLine("<------------------------------->");
            Console.ReadKey();

        }
        static thongTinSP NhapTTSP()
        {
            thongTinSP x = new thongTinSP();
            Console.Write("Ten san pham duoc mua la: ");
            x.tenSP = Console.ReadLine();
            Console.Write("So luong san pham duoc mua la: ");
            x.soLuong = int.Parse(Console.ReadLine());
            Console.Write("Gia san pham duoc mua la: ");
            x.giaSP = int.Parse(Console.ReadLine());
            return x; 
        }
    }
}
