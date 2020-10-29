using System;

namespace static_program
{
    public static class MyMath
    {
        public static int Max(params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Khong co gia tri de so sanh", "numbers");
            }
            int max = numbers[0];
            foreach (var number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        public static int Min(params int[] numbers)
        {
            if(numbers.Length == 0)
            {
                throw new ArgumentException("Khong co gia tri de so sanh", " numbers");
            }
            int min = numbers[0];
            foreach(var number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] {1,2,7,3,9,30,5,35};

            int max = MyMath.Max(numbers);
            int min = MyMath.Min(numbers);

            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
        }
    }

}
