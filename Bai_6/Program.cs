using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{

    internal class Program
    {
        static public bool IsSoNguyenTo(int Nums)
        {
            if (Nums <= 0) return false;
            for (int i = 2; i <= Math.Sqrt(Nums); i++)
                if (Nums % i == 0) return false;
            return true;
        }
        static public void XuatMaTran(int[,] MaTran, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(MaTran[i, j] + " ");
                Console.WriteLine();
            }
        }
        static public void TimMaxMin(int[,] MaTran, int n, int m)
        {
            int Min = MaTran[0, 0];
            int Max = MaTran[0, 0];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (Min > MaTran[i, j])
                        Min = MaTran[i, j];
                    if (Max < MaTran[i, j])
                        Max = MaTran[i, j];
                }
            Console.WriteLine("Gia tri lon nhat trong bang la : " + Max);
            Console.WriteLine("Gia tri be nhat trong bang la : " + Min);

        }
        static public void TimDongCoGiaTriLonNhat(int[,] MaTran, int n, int m)
        {
            int Donglonnhat = 0;
            int GiaTriDongLonNhat = 0;
            for (int i = 0; i < m; i++) { GiaTriDongLonNhat += MaTran[0, i]; }
            for (int i = 0; i < n; i++)
            {
                int Count = 0;
                for (int j = 0; j < m; j++)
                    Count += MaTran[i, j];
                if (Count > GiaTriDongLonNhat)
                {
                    GiaTriDongLonNhat = Count;
                    Donglonnhat = i;
                }
            }
        }
        static public void TongSoNguyenTo(int[,] MaTran, int n, int m)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    if (IsSoNguyenTo(MaTran[i, j]))
                        Sum += MaTran[i, j];
            }
        }

        static void Main(string[] args)
        {
            // nhap m cot va n dong
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            // Ma tran ngau nhien
            if (n <= 0 || m <= 0)
            {
                Console.WriteLine("So Cot Hoac Dong Cua Ma Tran Khong Hop Le!");
                return;
            }
            int[,] MaTran = new int[n, m];
            Random Rand = new Random();

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    MaTran[i, j] = Rand.Next(-100, 101);
            // a Xuat Mang
            XuatMaTran(MaTran, n, m);
            // b max min trong ma tran
            TimMaxMin(MaTran, n, m);

            // c  Dong lon Nhat
            TimDongCoGiaTriLonNhat(MaTran, n, m);
            //Tong so nguyen to
            TongSoNguyenTo(MaTran, n, m);
            //Xoa 1 dong
            Console.WriteLine("Nhap Dong Can Xoa : ");
            int k = Convert.ToInt32(Console.ReadLine());
            k--;
            if (k >= 0 && k < n)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        MaTran[i - 1, j] = MaTran[i, j];
                }
                n--;
                Console.WriteLine("Ma Tran sau khi Xoa Dong " + (k+1));
                XuatMaTran(MaTran, n, m);
            }
            else
            {
                Console.WriteLine("dong xoa khong hop le");
            }
            // Xoa Cot Co Tong Lon Nhat
            int Max = MaTran[0, 0];
            k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (Max < MaTran[i, j])
                    {
                        Max = MaTran[i, j];
                        k = j;
                    }

            for (int i = 0; i < n; i++)
            {
                for (int j = k + 1; j < m; j++)
                    MaTran[i, j - 1] = MaTran[i, j];
            }
            m--;
            Console.WriteLine("Ma Tran Sau Khi Xoa cot chua phan tu lon nhat");
            XuatMaTran(MaTran, n, m);

        }

    }
}

