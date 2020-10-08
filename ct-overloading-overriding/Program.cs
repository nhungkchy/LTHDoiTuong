// C# program to demonstrate the method overriding  
// without using 'virtual' and 'override' modifiers 
using System; 

namespace ct_overloading_overriding
{
    
    class baseClass 
    
    { 
        private int a = 3;
        private int b;
        public int B
        {
            get{return B;}
            set
            {
                try
                {
                    
                    B = value;
                    Console.WriteLine("b đã được gán gtr");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("b không được gán");
                    throw;
                }
            }
        }

        public virtual void show() 
        { 
            Console.WriteLine("Base class"); 
        } 
    } 
    
    class derived : baseClass 
    { 
        

        public override void show()  
        { 
            Console.WriteLine("Derived class"); 
        } 
    } 
    
    class Program
    {
        private const string V = "string";

        static void Main(string[] args)
        {
            baseClass obj = new baseClass(); 
            obj.show(); 
            obj.B = 1000;
            
            obj = new derived(); 
            obj.show(); 
            
        }
    }
}
