// attribute, method, public, private

using System;

namespace ct3
{
    class TinhTong
    {
        public int a;
        public int b;
        private int c;
        public TinhTong(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Tong()
        {
            c = a + b;
            Console.WriteLine("Tong: " + c);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TinhTong ab = new TinhTong(4, 6);
            ab.Tong();
            Console.ReadLine();
        }
    }
}
