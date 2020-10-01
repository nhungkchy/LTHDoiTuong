// namespace
using System;
using Animal;

namespace Animal
{
    class Cat
    {
        public void Info()
        {
            Console.WriteLine("I'm Cat!");
        }
    }
    class Dog
    {
        public void Info()
        {
            Console.WriteLine("I'm Dog!");
        }
    }
}

namespace ct5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Info();
            dog.Info();
        }
    }
}
