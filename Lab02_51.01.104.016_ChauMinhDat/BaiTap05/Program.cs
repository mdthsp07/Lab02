using System;
using System.Collections.Generic;

namespace Baitap05 // Sinh mảng ngẫu nhiên (File 2 - Bài 2)
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu n (n > 0): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n phai lon hon 0!");
                Console.ReadKey();
                return;
            }

            List<int> ml = new List<int>();
            Random rnd = new Random();

            // Phát sinh ngẫu nhiên
            for (int i = 0; i < n; i++)
            {
                ml.Add(rnd.Next(100)); // Sinh số từ 0 đến 99
            }

            Console.WriteLine("\nMang ban dau:");
            Console.WriteLine(string.Join(" ", ml));

            // Sắp xếp tăng dần
            ml.Sort();

            Console.WriteLine("\nMang sau khi sap xep tang dan:");
            Console.WriteLine(string.Join(" ", ml));

            Console.ReadKey();
        }
    }
}