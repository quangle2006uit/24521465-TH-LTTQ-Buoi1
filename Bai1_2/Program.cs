using System;

namespace ConsoleApp1
{

    //class Bai1
    //{

    //    private static bool IsSoNguyenTo(int a)
    //    {
    //        if (a <= 1)
    //            return false;
    //        for (int i = 2; i <= Math.Sqrt(a); i++)
    //        {
    //            if (a % i == 0)
    //                return false;
    //        }
    //        return true;
    //    }
    //    private static int SoChinhPhuongMin(int[] a, int n)
    //    {
    //        for (int i = 0; i < n; i++)
    //            if (a[i] >= 0 && (Math.Sqrt(a[i]) - Convert.ToInt32(Math.Sqrt(a[i])) == 0))
    //                return a[i];
    //        return -1;
    //    }
    //    private static long TinhTongSoLe(int[] a, int n)
    //    {
    //        long Sum = 0;
    //        for (int i = 0; i < n; i++)
    //        {
    //            if (a[i] % 2 != 0)
    //                Sum += a[i];
    //        }
    //        return Sum;
    //    }
    //    public static void TaoMang()
    //    {
    //        //    Console.WriteLine("Tao Mang Ngau Nhien , Nhap Vao Kich thuoc mang : ");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int[] a = new int[n];
    //        for (int i = 0; i < n; i++)
    //        {
    //            Random Rdm = new Random();
    //            a[i] = Rdm.Next(-100, 101);
    //        }
    //        Console.WriteLine("Xuat Mang :");
    //        for (int i = 0; i < n; i++)
    //            Console.Write(a[i] + " ");
    //        Console.WriteLine();
    //        // Bai1.a
    //        Console.WriteLine("Tong So Le Trong Mang : " + TinhTongSoLe(a, n));
    //        // Bai1.b
    //        int Count = 0;
    //        for (int i = 0; i < n; i++)
    //        {
    //            if (IsSoNguyenTo(a[i]))
    //                Count++;
    //        }
    //        Console.WriteLine("Dem So Nguyen To Trong Mang : " + Count);
    //        // Bai1.c
    //        if (SoChinhPhuongMin(a, n) == -1)
    //            Console.WriteLine("Khong co so chinh phuong");
    //        else
    //            Console.WriteLine("so chinh phuong nho nhat = " + SoChinhPhuongMin(a, n));
    //    }
    //}
    class Bai2
    {
        private static bool IsSoNguyenTo(int a)
        {
            if (a <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        public static void TinhTongSoNguyenTo()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

                long sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsSoNguyenTo(i))
                    sum += i;
            }
            Console.WriteLine("Tong so nguyen to be hon n : " + sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Bai2.TinhTongSoNguyenTo();
        }
    }
}
