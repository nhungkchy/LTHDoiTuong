// constructor
using System;

namespace access_modijiens
{
    class phone
    {
        public string color;
        public int RAM;
        public string HDH;
        public void Phone(string color, int RAM, string HDH)
        {
            this.color = color;
            this.RAM = RAM;
            this.HDH = HDH;
        }

        class iphone: Phone
        {
               
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
