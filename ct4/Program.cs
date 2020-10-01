using System;

// static
namespace ct4
{
    class Car
    {
        public string color;
        public string maker;
        public static int Count = 0;
        public Car(string color, string maker)
        {  
            this.color = color;
            this.maker = maker;
            Count++;
        }
        public static int NumberOldCar(int number)
        {
            return number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car("black", "Audi");
            Car Car2 = new Car("red", "Audi");
            Console.WriteLine("so xe khoi tao: " + Car.Count);
            Console.WriteLine("so xe cu: " + Car.NumberOldCar(5));

        }
    }
}
