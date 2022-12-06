using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Payment
    {
        private string code = "TINDER2022";

        public void MaKhuyenMai(string promocode)
        {
            if (promocode == code)
                Console.WriteLine("Nhap ma khuyen mai thanh cong");
            Console.WriteLine("Nhap ma khuyen mai khong thanh cong");
        }
        public void NangCapTinder()
        {
            Console.WriteLine("1. Tinder Platinum");
            Console.WriteLine("2. Tinder Gold");
            Console.WriteLine("3. Tinder Plus");
            int x = Console.Read();
            bool gd = GiaoDich(x);

            switch (x)
            {
                case 1:
                    if (gd)
                        Console.WriteLine("Ban dang so huu Tinder Platinum");
                    break;
                case 2:
                    if (gd)
                        Console.WriteLine("Ban dang so huu Tinder Gold");
                    break;
                case 3:
                    if (gd)
                        Console.WriteLine("Ban dang so huu Tinder Plus");
                    break;
            }

        }
        public bool GiaoDich(int x)
        {
            Console.WriteLine("1. 12 months");
            Console.WriteLine("2. 6 months");
            Console.WriteLine("3. 1 months");
            switch (x)
            {
                case 1:
                    Console.WriteLine("Giao dich thanh cong");
                    return true;
                case 2:
                    Console.WriteLine("Giao dich thanh cong");
                    return true;
                case 3:
                    Console.WriteLine("Giao dich thanh cong");
                    return true;
            }
            return true;
        }
    }
}
