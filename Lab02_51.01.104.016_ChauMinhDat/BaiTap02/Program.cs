using System;
using System.Collections.Generic;

namespace Baitap02 //Struct HangHoa (File 1 - Bài 2 & File 2 - Bài 3)
{
    class Program
    {
        struct HangHoa
        {
            public int MaMH;
            public string TenMH;
            public int SoLuong;
            public double DonGia;

            public HangHoa(int ma, string ten, int sl, double dg)
            {
                MaMH = ma; TenMH = ten; SoLuong = sl; DonGia = dg;
            }

            public double ThanhTien()
            {
                return SoLuong * DonGia;
            }
        }

        static void Main(string[] args)
        {
            List<HangHoa> danhSach = new List<HangHoa>();

            // 1. Nhập danh sách
            do
            {
                HangHoa hh = new HangHoa();
                Console.Write("Nhap Ma MH: "); hh.MaMH = int.Parse(Console.ReadLine());
                Console.Write("Nhap Ten MH: "); hh.TenMH = Console.ReadLine();
                Console.Write("Nhap So Luong: "); hh.SoLuong = int.Parse(Console.ReadLine());
                Console.Write("Nhap Don Gia: "); hh.DonGia = double.Parse(Console.ReadLine());

                danhSach.Add(hh);
                Console.Write("Tiep tuc nhap? (y/n): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            // 2. Xuất danh sách
            Console.WriteLine("\n--- DANH SACH HANG HOA ---");
            XuatDanhSach(danhSach);

            // 3. Tìm và xóa
            Console.Write("\nNhap Ma MH can tim va xoa: ");
            int maXoa = int.Parse(Console.ReadLine());
            if (TimMatHang(danhSach, maXoa))
            {
                XoaMatHang(danhSach, maXoa);
                Console.WriteLine("Da xoa thanh cong! Danh sach sau khi xoa:");
                XuatDanhSach(danhSach);
            }
            else
            {
                Console.WriteLine("Khong tim thay Ma MH nay!");
            }

            Console.ReadKey();
        }

        static void XuatDanhSach(List<HangHoa> ds)
        {
            foreach (var hh in ds)
            {
                Console.WriteLine("Ma: {0} - Ten: {1} - SL: {2} - Don Gia: {3} - Thanh Tien: {4}",
                    hh.MaMH, hh.TenMH, hh.SoLuong, hh.DonGia, hh.ThanhTien());
            }
        }

        static bool TimMatHang(List<HangHoa> ds, int ma)
        {
            foreach (var hh in ds)
                if (hh.MaMH == ma) return true;
            return false;
        }

        static void XoaMatHang(List<HangHoa> ds, int ma)
        {
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaMH == ma)
                {
                    ds.RemoveAt(i);
                    break;
                }
            }
        }
    }
}