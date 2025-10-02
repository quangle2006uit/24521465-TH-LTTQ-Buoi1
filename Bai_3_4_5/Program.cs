using System;
using System.Linq.Expressions;

namespace Bai_3_4_5
{
    class Time
    {
        private int Ngay;
        private int Thang;
        private int Nam;

        public bool KiemTraNamNhuan()
        {
            if (Nam % 4 == 0 && Nam % 100 != 0 || Nam % 400 == 0)
                return true;
            return false;
        }
        public bool KiemTraTime()
        {
            if (Ngay > 0 && Ngay < 32 && (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12))
                return true;
            else if (Ngay > 0 && Ngay < 31 && (Thang == 4 || Thang == 6 || Thang == 9 || Thang == 11))
                return true;
            else if (Ngay > 0 && Ngay < 29 && Thang == 2 && KiemTraNamNhuan() == false)
                return true;
            else if (Ngay > 0 && Ngay < 30 && Thang == 2 && KiemTraNamNhuan() == true)
                return true;
            else
                return false;
        }
        public bool KiemTraThang()
        {
            if (Thang >= 1 && Thang <= 12) return true;
            return false;
        }
        public void Nhap()
        {

                string input = Console.ReadLine();
                string[] path = input.Split('/');

                Ngay = Convert.ToInt32(path[0]);
                Thang = Convert.ToInt32(path[1]);
                Nam = Convert.ToInt32(path[2]);
            Console.WriteLine("Bai 3: ");
            if (KiemTraTime() == false)
                Console.WriteLine("Thoi Gian Khong Hop Le");
            else
                Console.WriteLine("Ngay Thang Nam Hop Le");
        }
        public void InNgayCuaThang()
        {
            if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
                Console.WriteLine("Ngay Cua Thang " + Thang + " La : " + 31);
            else if (Thang == 4 || Thang == 6 || Thang == 9 || Thang == 11)
                Console.WriteLine("Ngay Cua Thang " + Thang + " La : " + 30);
            else if (Thang == 2 && KiemTraNamNhuan() == false)
                Console.WriteLine("Ngay Cua Thang " + Thang + " La : " + 28);
            else
                Console.WriteLine("Ngay Cua Thang " + Thang + " La : " + 29);
        }
        public void XuatSoNgayTrongTuan()
        {
            if (Thang == 1 || Thang == 2)
            {
                Thang += 12;
                Nam -= 1;
            }

            int K = Nam % 100;
            int J = Nam / 100;
            long SoNgay = (Ngay + (13 * (Thang + 1)) / 5 + K + K / 4 + J / 4 + 5 * J) % 7; ;
            switch (SoNgay)
            {
                case 0: Console.WriteLine("Thu Bay"); break;
                case 1: Console.WriteLine("Chu Nhat"); break;
                case 2: Console.WriteLine("Thu Hai"); break;
                case 3: Console.WriteLine("Thu Ba"); break;
                case 4: Console.WriteLine("Thu Tu"); break;
                case 5: Console.WriteLine("Thu Nam"); break;
                case 6: Console.WriteLine("Thu Sau"); break;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Nhap();
            if (time.KiemTraTime() == true)
            {
                Console.WriteLine("Bai 4: ");
                time.InNgayCuaThang();
                Console.WriteLine("Bai 5: ");
                time.XuatSoNgayTrongTuan();
            }
            else
            {
                if(time.KiemTraThang() == true)
                {
                    Console.WriteLine("Bai 4: ");
                    time.InNgayCuaThang();
                }
                else
                {
                    Console.WriteLine("Bai 4: ");
                    Console.WriteLine("Thang Khong Hop Le");
                }
                    Console.WriteLine("Bai 5: ");
                Console.WriteLine("Thoi Gian Khong Hop Le");
                 
            }
        }
    }
}
