using System;

class Program
{
    // Hàm đệ quy tính giai thừa 
    static long giaiThua(int n)
    {
        //1. trường hợp cơ sở: 0! = 1 va 1! = 1
        if (n <= 1) return 1;

        //2. bước đệ quy: n! = n * (n - 1)!
        return n * giaiThua(n - 1);
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int tinhTong(int n)
    {
        if (n == 1) return 1;
        return n + tinhTong(n - 1);
    }

    static long giaiThuaVongLap(int n)
    {
        long Ketqua = 1;
        for (int i = 1 ; i <= n; i++)
        {
            Ketqua *= i;
        }
        return Ketqua;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("{0}! = {1}", n, giaiThua(n));
        Console.WriteLine("Fibonacci{0} = {1}", n, Fibonacci(n));
        
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap n de tinh tong: ");
        n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Tong S({n}) = {tinhTong(n)}");
        Console.WriteLine($"Giai thua cua {n} la {giaiThuaVongLap(n)}");
    }
}