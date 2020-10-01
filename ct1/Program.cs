// class
using System;

namespace ct1
{
    class Animal    
    {

        public double Weight;
        public double Height;
        public void Info()
        {
            Console.WriteLine(" Height: " + Height + " Weight: " + Weight);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Animal();
            Cat.Weight = 1;
            Cat.Height = 30;
            Cat.Info();
            Console.ReadLine();
        }
    }
}
