using System;

namespace Baitap03 //Lập trình hướng đối tượng (File 1 - Bài 3)
{
    // 1.1 Lớp Sinh Viên
    class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        // Constructor không tham số
        public SinhVien() { }

        // Constructor có tham số
        public SinhVien(int ma, string ten, DateTime ns, string dc, string dt)
        {
            MaSV = ma; HoTen = ten; NgaySinh = ns; DiaChi = dc; DienThoai = dt;
        }

        // Property chỉ đọc tính Tuổi
        public int Tuoi
        {
            get { return DateTime.Now.Year - NgaySinh.Year; }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - NS: {2:dd/MM/yyyy} - Tuoi: {3} - DC: {4} - DT: {5}",
                MaSV, HoTen, NgaySinh, Tuoi, DiaChi, DienThoai);
        }
    }

    // 1.2 Lớp Hình Chữ Nhật
    class HinhChuNhat
    {
        public double mChieuDai { get; set; }
        public double mChieuRong { get; set; }

        public HinhChuNhat() { }
        public HinhChuNhat(double dai, double rong)
        {
            mChieuDai = dai; mChieuRong = rong;
        }

        public double TinhChuVi() { return (mChieuDai + mChieuRong) * 2; }
        public double TinhDienTich() { return mChieuDai * mChieuRong; }

        public void Xuat()
        {
            Console.WriteLine("Dai: {0}, Rong: {1}, Chu vi: {2}, Dien tich: {3}",
                mChieuDai, mChieuRong, TinhChuVi(), TinhDienTich());
        }

        public bool KiemTraHinhVuong()
        {
            return mChieuDai == mChieuRong;
        }
    }

    // 1.3 Lớp Sản Phẩm
    class SanPham
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public double Gia { get; set; }

        public SanPham() { }
        public SanPham(string ma, string ten, double gia)
        {
            Ma = ma; Ten = ten; Gia = gia;
        }

        public double TinhVAT() { return Gia * 0.1; } // Giả sử VAT 10%

        public void Nhap()
        {
            Console.Write("Nhap Ma SP: "); Ma = Console.ReadLine();
            Console.Write("Nhap Ten SP: "); Ten = Console.ReadLine();
            Console.Write("Nhap Gia SP: "); Gia = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Ma: {0} - Ten: {1} - Gia: {2} - Thue VAT: {3}", Ma, Ten, Gia, TinhVAT());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test Sinh Viên
            Console.WriteLine("--- TEST SINH VIEN ---");
            SinhVien sv = new SinhVien(1, "Hoang Khai Duy", new DateTime(2003, 5, 20), "HCM", "0123456789");
            Console.WriteLine(sv.ToString());

            // Test Hình Chữ Nhật
            Console.WriteLine("\n--- TEST HINH CHU NHAT ---");
            HinhChuNhat hcn = new HinhChuNhat(5, 5);
            hcn.Xuat();
            Console.WriteLine("Co phai hinh vuong? " + (hcn.KiemTraHinhVuong() ? "Co" : "Khong"));

            // Test Sản Phẩm
            Console.WriteLine("\n--- TEST SAN PHAM ---");
            SanPham sp1 = new SanPham();
            Console.WriteLine("Nhap SP 1:");
            sp1.Nhap();
            SanPham sp2 = new SanPham("SP2", "But bi", 5000);

            Console.WriteLine("\nXuat 2 san pham:");
            sp1.Xuat();
            sp2.Xuat();

            Console.ReadKey();
        }
    }
}