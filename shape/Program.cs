using System;

namespace shape
{
    // interface PermeterShape
    // {
    //     double getPermeter();
    // }
    abstract class Shape
    {

        public abstract string ToString();
    }
    class Triangle: Shape
    {
        protected double edge_1;
        protected double edge_2;
        protected double edge_3;
        public double Edge_1
        {
            get {return edge_1;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_1 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double Edge_2
        {
            get {return edge_2;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_2 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double Edge_3
        {
            get {return edge_3;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_3 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
         
        public Triangle(){}
        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
            }
            if( a+b<=c || b+c<=a || a+c<=b)
            {
            throw new Exception("The sum of any two edges must be greater than the remaining side!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public double getPermeter()
        {
            double C = this.edge_1 + this.edge_2 + this.edge_3;
            return C;
        }

        public virtual double getArea()
        {
            double S;
            double p = getPermeter()/2;
            S = Math.Sqrt(p*(p-this.edge_1)*(p-this.edge_2)*(p-this.edge_3));
            return S;
        }
        public double getHeight(double edge)
        {
            double h;
            double s = getArea();
            h = 2*getArea()/edge;
            return h;
        }

        public override string ToString()
        {
            return "Triaghle ("+edge_1 +", "+edge_2+", "+edge_3+")";
        }
    }
    class RightTriaghle: Triangle
    {
        private bool CheckCondition(double a, double b, double c)
        {
            bool flat;
            if(Math.Pow(a,2)+Math.Pow(b,2) == Math.Pow(c,2))
            {
                flat = true;
            }
            else if(Math.Pow(c,2)+Math.Pow(b,2) == Math.Pow(a,2))
            {
                flat = true;
            }
            else if(Math.Pow(c,2)+Math.Pow(a,2) == Math.Pow(b,2))
            {
                flat = true;
            }
            else
            {
                flat = false;
            }
            return flat;
        }
        public RightTriaghle(double a, double b, double c):base(a,b,c)
        {
            if(CheckCondition(a, b, c) == false)
            {
                throw new Exception("The three unsatisfied sides are the right triangle!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public RightTriaghle(){}
        public RightTriaghle(double a, double b)
        {
            if(a <= 0 || b <= 0)
            {
                throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override double getArea()
        {
            double S;
            if((Math.Pow(this.edge_1,2)+Math.Pow(this.edge_2,2)) == Math.Pow(this.edge_3,2))
            {
                S = 0.5*this.edge_1*this.edge_2;
            }
            else if((Math.Pow(this.edge_2,2)+Math.Pow(this.edge_3,2)) == Math.Pow(this.edge_1,2))
            {
                S = 0.5*this.edge_3*this.edge_2;
            }
            else
            {
                S = 0.5*this.edge_3*this.edge_1;   
            }
            return S;
        }
        public override string ToString()
        {
            return "Right_Triaghle ("+edge_1 +", "+edge_2+", "+edge_3+")";
        }
    }
    class IsoscelesTriaghle: Triangle
    {
        private bool CheckCondition(double a, double b, double c)
        {
            bool flat;
            if(a == b || a == c || b == c)
            {
                flat = true;
            }
            else
            {
                flat = false;
            }
            return flat;
        }
        public IsoscelesTriaghle(double a, double b, double c):base(a,b,c)
        {
            if(CheckCondition(a, b, c) == false)
            {
                throw new Exception("The three unsatisfied sides are the isosceles triangle!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public IsoscelesTriaghle(){}
        public override double getArea()
        {
            return base.getArea();
        }
        public override string ToString()
        {
            return "Isosceles_Triaghle ("+edge_1 +", "+edge_2+", "+edge_3+")";
        }
    }
    class EquiateralTriaghle: Triangle
    {
        private bool CheckCondition(double a, double b, double c)
        {
            bool flat;
            if(a == b & a == c)
            {
                flat = true;
            }
            else
            {
                flat = false;
            }
            return flat;
        }
        public EquiateralTriaghle(double a, double b, double c):base(a,b,c)
        {
            if(CheckCondition(a, b, c) == false)
            {
                throw new Exception("The three unsatisfied sides are the equiateral triangle!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public EquiateralTriaghle(){}
        public EquiateralTriaghle(double a)
        {
            if(a <= 0)
            {
                throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = a;
                this.edge_3 = a;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override double getArea()
        {
            double S;
            S = Math.Sqrt(3)*Math.Pow(edge_1,2)/4;
            return S;
        }
        public override string ToString()
        {
            return "Equiateral_Triaghle ("+edge_1 +", "+edge_2+", "+edge_3+")";
        }
    }
    class Quadrilateral: Shape, PermeterShape
    {
        protected double edge_1;
        protected double edge_2;
        protected double edge_3;
        protected double edge_4;
        public double Edge_1
        {
            get {return edge_1;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_1 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double Edge_2
        {
            get {return edge_2;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_2 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
        }
        public double Edge_3
        {
            get {return edge_3;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_3 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public double Edge_4
        {
            get {return edge_4;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge lengths, it cannot be less than 0!");
                }
                try
                {
                    edge_4 = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Quadrilateral(double a, double b, double c, double d)
        {
            if(a<=0 || b<=0 || c<=0 || d<=0)
            {
                throw new Exception("Because of the edge lengths, it cannot be less than 0!");
            }
            try
            {
                this.edge_1 = a; 
                this.edge_2 = b;
                this.edge_3 = c;
                this.edge_4 = d;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Quadrilateral(){}
        public double getPermeter()
        {
            double C;
            C = edge_1 + edge_2 + edge_3 + edge_4;
            return C;
        }
        public override string ToString()
        {
            return "Quadrilateral ("+edge_1 +", "+edge_2+", "+edge_3+","+edge_4+")";
        }
    }
    class Trapezoid: Quadrilateral
    {
        public Trapezoid(double a, double b, double c, double d):base(a,b,c,d)
        {
            this.edge_1 = a;
            this.edge_2 = b;
            this.edge_3 = c;
            this.edge_4 = d;
        }
        public double getHeight()
        {
            double x, h;
            x = 0.5*(((Math.Pow(edge_2,2)+Math.Pow(edge_4,2))/(edge_1-edge_3))+edge_1-edge_3);
            h = Math.Sqrt(Math.Pow(edge_4,2)-Math.Pow(x,2));
            return h;
        }
        public Trapezoid(){}
        public double getArea()
        {
            double S;
            S = 0.5*(edge_1+edge_3)*getHeight();
            return S;
        }
        public override string ToString()
        {
            return "Trapezoid ("+edge_1 +", "+edge_2+", "+edge_3+","+edge_4+")";
        }
    }
    class Parallelogram: Quadrilateral
    {
        public Parallelogram(double a, double b, double c, double d):base(a,b,c,d)
        {
            if(a!=c || b!=d)
            {
                throw new Exception("The four unsatisfied sides are the Parallelogram");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
                this.edge_4 = d;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Parallelogram(double a, double b)
        {
            if(a <= 0 || b <= 0)
            {
                throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = a;
                this.edge_4 = b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Parallelogram(){}
        public override string ToString()
        {
            return "Parallelogram ("+edge_1 +", "+edge_2+", "+edge_3+","+edge_4+")";
        }
    }
    class Rectangle: Parallelogram
    {
        public Rectangle(double a, double b, double c, double d):base(a,b,c,d)
        {
            this.edge_1 = a;
            this.edge_2 = b;
            this.edge_3 = c;
            this.edge_4 = d;
        }
        public Rectangle(double a, double b):base(a,b)
        {
            this.edge_1 = a;
            this.edge_2 = b;
            this.edge_3 = a;
            this.edge_4 = b;
        }
        public Rectangle(){}
        public virtual double getArea()
        {
            double S;
            S = edge_1*edge_2;
            return S;
        }
        public override string ToString()
        {
            return "Rectangle ("+edge_1 +", "+edge_2+", "+edge_3+","+edge_4+")";
        }
    }
    class Square: Rectangle
    {
        public Square(double a, double b, double c, double d):base(a,b,c,d)
        {
            if(a!=b || b!=c || c!=d)
            {
                throw new Exception("The four unsatisfied sides are the Square");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = c;
                this.edge_4 = d;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Square(double a, double b):base(a,b)
        {
            if(a != b)
            {
                throw new Exception("The four unsatisfied sides are the Square");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = b;
                this.edge_3 = a;
                this.edge_4 = b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Square(double a)
        {
            if(a <= 0)
            {
                throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
            }
            try
            {
                this.edge_1 = a;
                this.edge_2 = a;
                this.edge_3 = a;
                this.edge_4 = a;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public override double getArea()
        {
            double S;
            S = Math.Pow(edge_1,2);
            return S;
        }
        public override string ToString()
        {
            return "Square ("+edge_1 +", "+edge_2+", "+edge_3+","+edge_4+")";
        }
    }
    class Elip: Shape
    {
        protected double large_axis;
        protected double small_axis;
        public double Large_axis
        {
            get {return large_axis;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge central lengths, it cannot be less than 0!");
                }
                try
                {
                    large_axis = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
        }
        public double Small_axis
        {
            get {return small_axis;}
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Because of the edge lengths, it cannot be less than 0!");
                }
                try
                {
                    small_axis = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Elip(double a, double b)
        {
            if( a<=0 || b<=0)
            {
                throw new Exception("The axis cannot be less than 0!");
            }
            try
            {
                this.large_axis = a;
                this.small_axis = b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Elip(){}
        public virtual double getPermeter()
        {
            double lamda, F, C;
            lamda = (large_axis-small_axis)/(large_axis+small_axis);
            F = 1 + 3*Math.Pow(lamda,2)/(10+Math.Sqrt(4-3*Math.Pow(lamda,2)));
            C = 2*Math.PI*(large_axis+small_axis)*F;
            return C;
        }
        public virtual double getArea()
        {
            double S;
            S = Math.PI*large_axis*small_axis;
            return S;
        }
        public override string ToString()
        {
            return "Elip ("+large_axis+","+small_axis+")";
        }
    }
    class Cricle: Elip
    {
        public Cricle(double a, double b):base(a,b)
        {
            if(small_axis != large_axis)
            {
                throw new Exception("The two axis must be equal!");
            }
            try
            {
                this.large_axis = a;
                this.small_axis = b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Cricle(double a)
        {
            if(a<=0)
            {
                throw new Exception("The axis cannot be less than 0!");
            }
            try 
            {
                this.small_axis = a;
                this.large_axis = a;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Cricle(){}
        public override double getPermeter()
        {
            double C;
            C = 2*Math.PI*large_axis;
            return C;
        }
        public override double getArea()
        {
            double S;
            S = Math.PI*Math.Pow(large_axis,2);
            return S;
        }
        public override string ToString()
        {
            return "Cricle ("+large_axis+")";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //class Triaghle
            Triangle triangle = new Triangle(7,6,9);

            Console.WriteLine(triangle);
            Console.WriteLine("The Permeter of the triangle is: {0:F3}",triangle.getPermeter());
            Console.WriteLine("The Area of the triangle is: {0:F3}",triangle.getArea());
            Console.WriteLine("The height corresponds to the edge ({0}) of the triangle is: {1:F3}",triangle.Edge_1,triangle.getHeight(triangle.Edge_1));
            
            //class RightTriaghle
            RightTriaghle Rtriangle1 = new RightTriaghle(10,8,6);
            RightTriaghle Rtriangle2 = new RightTriaghle(9,10);

            Console.WriteLine(Rtriangle1);
            Console.WriteLine("The Permeter of the triangle is: {0:F3}",Rtriangle1.getPermeter());
            Console.WriteLine("The Area of the triangle is: {0:F3}",Rtriangle1.getArea());
            Console.WriteLine("The height corresponds to the edge ({0}) of the triangle is: {1:F3}",Rtriangle1.Edge_1,Rtriangle1.getHeight(Rtriangle1.Edge_1));

            Console.WriteLine(Rtriangle2);
            Console.WriteLine("The Permeter of the triangle is: {0:F3}",Rtriangle2.getPermeter());
            Console.WriteLine("The Area of the triangle is: {0:F3}",Rtriangle2.getArea());
            Console.WriteLine("The height corresponds to the edge ({0}) of the triangle is: {1:F3}",Rtriangle2.Edge_1,Rtriangle2.getHeight(Rtriangle2.Edge_1));

            //class square
            Square sq = new Square(10);
            Square sq1 = new Square(9,9);
            Square sq2 = new Square(8,8,8,8);
            Console.WriteLine("Square: "+ sq);
            Console.WriteLine("Square 1: "+ sq1);
            Console.WriteLine("Square 2: "+ sq2);
            Console.WriteLine("The permeter of the square: "+sq.getPermeter());
            Console.WriteLine("The permeter of the square: "+sq.getArea());

        }
    }
}
