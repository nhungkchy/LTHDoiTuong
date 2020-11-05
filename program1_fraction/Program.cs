using System;

namespace program1_fraction
{
    class Fraction 
    {
        public int numerator;
        public int denominator;

        public int Numnerator
        {
            get {return numerator;}
            set {numerator = value;}
        }

        public int Denominator
        {
            get {return denominator == 0 ? 1 : denominator;}
            set
            {
                if (value == 0)
                {
                    throw new Exception("denominator must be nonzero");
                }
                denominator = value;
            }
        }

        public Fraction(){}
        public Fraction(int num)
        {
            numerator = num;
            denominator = 1;
            Reduce();
        }

        public Fraction(int num, int deno)
        {
            if (deno == 0)
            {
                throw new Exception("denominator must be nonzero");
            }
            numerator = num;
            denominator = deno;
            Reduce();
        }

        private void Reduce()
        {
            try
            {
                if (numerator == 0)
                {
                    denominator = 1;
                    return;
                }

                int iGCD = GCD(numerator, denominator);
                numerator /= iGCD;
                denominator /= iGCD;

                if (denominator < 0)
                {
                    numerator *= -1;
                    denominator *= -1;
                }
            }
            catch (Exception exp)
            {
                throw new Exception("Cannot reduce Fraction: " + exp.Message);
            }
        }

        private static int GCD(int num1, int num2)
        {
            if (num1 < 0) num1 = -num1;
            if (num2 < 0) num2 = -num2;

            do
            {
                if (num1 < num2)
                {
                    int tmp = num1;
                    num1 = num2;
                    num2 = tmp;
                }
                num1 = num1 % num2;
            }
            while (num1 != 0);

            return num2;
        }
        public override string ToString()
        {
            return  numerator + "/" + denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction sum_f = new Fraction();
            sum_f.numerator = a.numerator*b.denominator + a.denominator*b.numerator;
            sum_f.denominator = a.denominator * b.denominator;
            sum_f.Reduce();
            return sum_f;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            bool status = false;
            int a1 = a.numerator * b.denominator;
            int b1 = b.numerator * a.denominator;

            if (a1 > b1)
            {
                status = true;
            }
            return status;
        }
           public static bool operator <(Fraction a, Fraction b)
        {
            bool status = false;
            int a1 = a.numerator * b.denominator;
            int b1 = b.numerator * a.denominator;

            if (a1 < b1)
            {
                status = true;
            }
            return status;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction[] fracs = {new Fraction(10,9),new Fraction(8,9),
                                new Fraction(7,19),new Fraction(7,6),
                                new Fraction(8,2),new Fraction(1,2),
                                new Fraction(10,19),new Fraction(17,9),
                                new Fraction(5,15),new Fraction(4,11)};
            Fraction sum_fracs = new Fraction(0,1);  

            for(int i=0; i<fracs.Length-1; i++)
            {
                for(int j=i; j<fracs.Length; j++)
                {
                    if(fracs[i]>fracs[j])
                    {
                        Fraction tmp = fracs[i];
                        fracs[i] = fracs[j];
                        fracs[j] = tmp;
                    }
                }
            }

            Console.WriteLine("Phan so duoc sap xep tang dan: ");
            for (int i=0; i<fracs.Length; i++)
            {
                Console.WriteLine(fracs[i]);
                sum_fracs = sum_fracs + fracs[i];
            }

            Console.WriteLine("Max: "+fracs[fracs.Length-1]);
            Console.WriteLine("Min: "+fracs[0]);
            Console.WriteLine("Sum: "+ sum_fracs);

        }
    }
}
