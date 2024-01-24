using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_ve_nha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luaChon;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Cua hang dien thoai");
                Console.WriteLine("1. Them dien thoai");
                Console.WriteLine("2. them dien thoai chi tiet");
                Console.WriteLine("3. tim dien thoai");
                Console.WriteLine("4. dang/ngung kinh doanh");
                Console.WriteLine("5. thoat");
                Console.WriteLine("------------------------");
                Console.WriteLine("Moi ban chon: ");

                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("1. Them dien thoai");
                        break;
                    case 2:
                        Console.WriteLine("2. them dien thoai chi tiet");
                        break;
                    case 3:
                        Console.WriteLine("3.tim dien thoai");
                        break;
                    case 4:
                        Console.WriteLine("dang/ngung kinh doanh");
                        break;

                    default:
                        Console.WriteLine("Moi ban nhap lai");
                        break;
                }

            } while (luaChon != 5);
            Console.ReadLine();
        }
    }
}
