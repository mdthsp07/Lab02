using System;

namespace Baitap04 //Xử lý ngoại lệ (File 2 - Bài 1)
{
    // Tự tạo lớp ngoại lệ
    class NotNegativeException : Exception
    {
        public NotNegativeException() : base("Gia tri duoi dau can < 0") { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Nhap y: ");
                double y = double.Parse(Console.ReadLine());

                double tuSo = 3 * x + 2 * y;
                double mauSo = 2 * x - y;

                if (mauSo == 0)
                    throw new DivideByZeroException();

                double giaTriTrongCan = tuSo / mauSo;
                if (giaTriTrongCan < 0)
                    throw new NotNegativeException();

                double H = Math.Sqrt(giaTriTrongCan);
                Console.WriteLine("Gia tri H = " + H);
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Ban phai nhap so!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi: Mau so (2x - y) bang 0, khong the chia cho 0!");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khong xac dinh: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}