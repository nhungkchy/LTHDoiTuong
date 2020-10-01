// get, set
using System;

namespace ct2
{
    class SinhVien
    {
        private double diemLy;
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();

            SV1.DiemLy = 8;

            Console.WriteLine(" Diem ly: " + SV1.DiemLy); 
        }
    }
}
