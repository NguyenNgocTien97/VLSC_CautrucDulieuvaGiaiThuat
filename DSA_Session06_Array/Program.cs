using System;

namespace DSA_Session06_Array
{
    class Program
    {
        // Biến toàn cục (Global) để lưu trữ mảng đang làm việc
        static int[] currentArray;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=====================================");
                Console.WriteLine("    MODULE QUẢN LÝ MẢNG (MIDTERM)    ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Tạo mảng số ngẫu nhiên");
                Console.WriteLine("2. In mảng hiện tại");
                Console.WriteLine("3. Sắp xếp mảng (Bubble Sort)");
                Console.WriteLine("4. Tìm kiếm nhị phân (Binary Search)");
                Console.WriteLine("0. Thoát phần mềm");
                Console.WriteLine("=====================================");
                Console.Write("Mời bạn chọn tính năng (0-4): ");

                // Xử lý ngoại lệ khi nhập chữ thay vì số
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập số nguyên!");
                    choice = -1; // Gán giá trị khác 0 để tiếp tục vòng lặp
                    continue;
                }

                switch (choice)
                {
                    case 1: GenerateRandomArray(); break;
                    case 2: PrintArray(); break;
                    case 3: BubbleSort(); break;
                    case 4: ExecuteBinarySearch(); break;
                    case 0: Console.WriteLine("Đóng hệ thống. Chúc các em điểm cao!"); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            } while (choice != 0);
        }

        // --- CÁC HÀM XỬ LÝ (Định nghĩa bên ngoài hàm Main) ---

        static void GenerateRandomArray()
        {
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên dương!");
            }

            currentArray = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                currentArray[i] = rand.Next(1, 100);
            }
            Console.WriteLine($"=> Đã tạo mảng thành công với {n} phần tử!");
        }

        static void PrintArray()
        {
            if (currentArray == null)
            {
                Console.WriteLine("Lỗi: Mảng chưa được khởi tạo!");
                return;
            }
            Console.Write("Dữ liệu mảng: ");
            foreach (int num in currentArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void BubbleSort()
        {
            if (currentArray == null) { Console.WriteLine("Lỗi: Mảng rỗng!"); return; }

            int n = currentArray.Length;
            int swapCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (currentArray[j] > currentArray[j + 1])
                    {
                        int temp = currentArray[j];
                        currentArray[j] = currentArray[j + 1];
                        currentArray[j + 1] = temp;
                        swapCount++;
                    }
                }
            }
            Console.WriteLine($"=> Đã sắp xếp mảng tăng dần. Tốn {swapCount} lần hoán đổi.");
        }

        static void ExecuteBinarySearch()
        {
            if (currentArray == null) { Console.WriteLine("Lỗi: Mảng rỗng!"); return; }

            Console.Write("Nhập số cần tìm: ");
            int target;
            if (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Lỗi: Giá trị tìm kiếm phải là số nguyên!");
                return;
            }

            int left = 0;
            int right = currentArray.Length - 1;
            int position = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (currentArray[mid] == target)
                {
                    position = mid;
                    break;
                }
                if (currentArray[mid] < target) left = mid + 1;
                else right = mid - 1;
            }

            if (position != -1)
                Console.WriteLine($"=> Tuyệt vời! Đã tìm thấy số {target} tại vị trí Index = {position}.");
            else
                Console.WriteLine($"=> Không tìm thấy số {target} trong mảng. (Lưu ý: Mảng phải được sắp xếp trước khi tìm kiếm!)");
        }
    }
}