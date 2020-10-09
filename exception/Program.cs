﻿// exception
using System;

namespace exception
{
    class TinhChia
    {
        int x;
        int y;
        private int div = 0;
        private int c;

        public int C
        {
            get{return C;}
            set
            {
                try
                {
                    C = value;
                    Console.WriteLine("C dc gan gtr");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("error!!");
                }
            }
        }
        public TinhChia(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Chia()
        {
            try
            {
                div = x/y;
                Console.WriteLine("phan nguyen x/y = " + div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error!!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TinhChia so1 = new TinhChia(6,4);
            TinhChia so2 = new TinhChia(4,0);
            so1.Chia();
            so2.Chia();
        }
    }
}
