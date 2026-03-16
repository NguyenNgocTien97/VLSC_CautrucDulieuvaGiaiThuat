class Program
{
    static int TinhTong(int n)
    {
        if (n == 1) return 1;
        return n + TinhTong(n - 1);
    }

    static long giaiThuaVongLap(int n)
    {
        long Ketqua = 1;
        for (int i = 1; i <= n; i++)
        {
            Ketqua *= i;
        }
        return Ketqua;
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap n de tinh tong: ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Tong S({n}) = {TinhTong(n)}");
        Console.WriteLine($"Giai thua cua {n} la {giaiThuaVongLap(n)}");
    }
}