using System;
using System.Diagnostics;
// AUthor: Nguyen Ngoc Tien - 2500113793
//Muc Tieu:
//Bai 1: loi chao thong minh
//yeu cau: nhap ten va MSSV, in ra loi chao
//code 
// su dung console.Readline() de gan bien

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap ho ten: ");
        String name = Console.ReadLine();
        Console.Write("Nhap MSSV: ");
        String mssv = Console.ReadLine();
        Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv}) den voi lop CTDL&GT!");

// Bai 2: May tinh co ban
// Yeu cau: Nhap 2 so nguyen a va b. Tinh va in ra tong, hieu, tich, thuong
// huong dan: du lieu tu ban phim luon la string
// cac em phai dung int.Parse() de chuyenn ve so nguyen to truoc khi tinh toan
    Console.Write("Nhap so a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Nhap so b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Tong: {a + b}");
    Console.WriteLine($"Hieu: {a - b}");
    Console.WriteLine($"Tich: {a * b}");
    if (b != 0)
        {
            Console.WriteLine($"Thuong: {(double)a / b}");
        }else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }

        // Bai 3: Ky thuat hoan doi(Swap)
    // yeu cau: cho 2 bien so x=5, y=10, hay doi gia tri cua chung de x=10, y=5
    // de doi nuoc cho nhau em can them 1 ly rong(bien temp)
    int x = 5, y = 10;
    Console.WriteLine($"Truoc khi swap: x={x}, y={y}");
    int temp = x; //temp = 5
    x = y; // x = 10
    y = temp; // y = 5;
    Console.WriteLine($"Sau khi swap: x={x}, y={y}");
    }
}




