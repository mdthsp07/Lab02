using System;
using System.Collections.Generic;

namespace Baitap01 //Mảng động List (File 1 - Bài 1)
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mang = new List<string>();
            string tmp;

            Console.WriteLine("--- NHAP DANH SACH (Go 'stop' de ket thuc) ---");
            while (true)
            {
                Console.Write("Nhap ten hang hoa: ");
                tmp = Console.ReadLine().Trim();
                if (tmp.ToUpper() == "STOP") break;
                mang.Add(tmp);
            }

            XuatMang(mang);

            // Tìm kiếm
            Console.Write("\nNhap ten hang hoa can tim: ");
            tmp = Console.ReadLine().Trim();
            if (mang.Contains(tmp))
            {
                Console.WriteLine("Tim thay {0} tai vi tri {1}", tmp, mang.IndexOf(tmp));

                // Xóa
                Console.Write("Ban co muon xoa hang hoa nay? (y/n): ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    mang.Remove(tmp);
                    Console.WriteLine("Da xoa! Danh sach sau khi xoa:");
                    XuatMang(mang);
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay!");
            }

            // Thêm vào vị trí bất kỳ
            Console.Write("\nNhap vi tri index muon chen them: ");
            int index = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten hang hoa muon chen: ");
            string newItem = Console.ReadLine();

            if (index >= 0 && index <= mang.Count)
            {
                mang.Insert(index, newItem);
                Console.WriteLine("Danh sach sau khi chen:");
                XuatMang(mang);
            }
            else
            {
                Console.WriteLine("Vi tri khong hop le!");
            }

            Console.ReadKey();
        }

        static void XuatMang(List<string> M)
        {
            Console.WriteLine("Danh sach hien tai: " + string.Join(", ", M));
        }
    }
}