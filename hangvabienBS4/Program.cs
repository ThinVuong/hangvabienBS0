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
            Console.Write("Lai suat (%nam) hoac ten ngan hang: ");
            string laiStr=Console.ReadLine();
            double lai;
            switch(laiStr)
            {
                case "ABBank":
                    lai = 5.65;
                    break;
                case "Agribank":
                    lai = 4.9;
                    break;
                case "Timo":
                    lai = 6;
                    break;
                case "Bac A":
                    lai = 6;
                    break;
                case "Bao Viet":
                    lai = 5.65;
                    break;
                case "BIDV":
                    lai = 4.9;
                    break;
                case "CBBank":
                    lai = 3.8;
                    break;
                case "Dong A":
                    lai = 5.5;
                    break;
                case "GPBank":
                    lai = 6;
                    break;
                case "Hong Leong":
                    lai = 5.5;
                    break;
                case "Indovina":
                    lai = 5.8;
                    break;
                case "Kien Long":
                    lai = 6;
                    break;
                case "MSB":
                    lai = 6;
                    break;
                case "MB":
                    lai = 5.8;
                    break;
                case "Nam A Bank":
                    lai = 6;
                    break;
                case "NCB":
                    lai = 6;
                    break;
                case "OCB":
                    lai = 5.7;
                    break;
                case "OceanBank":
                    lai = 6;
                    break;
                case "PGBank":
                    lai = 6;
                    break;
                case "PublicBank":
                    lai = 5.8;
                    break;
                case "PVcomBank":
                    lai = 5.7;
                    break;
                case "Saigonbank":
                    lai = 6;
                    break;
                case "SCB":
                    lai = 6;
                    break;
                case "SeABANK":
                    lai = 5.7;
                    break;
                case "SHB":
                    lai = 6;
                    break;
                case "TBBank":
                    lai = 5.8;
                    break;
                case "VIB":
                    lai = 6;
                    break;
                case "VietCapitalBank":
                    lai = 6;
                    break;
                case "VietcomBank":
                    lai = 4.9;
                    break;
                case "VietinBank":
                    lai = 4.9;
                    break;
                case "VPBank":
                    lai = 6;
                    break;
                case "VRB":
                    lai = 0;
                    break;
                default:
                    if (double.TryParse(laiStr, out lai))
                    {
                        lai = double.Parse(laiStr);
                    }
                    else
                    {
                        Console.WriteLine("Khong co ngan hang nay");
                    }
                    break;
            }
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
