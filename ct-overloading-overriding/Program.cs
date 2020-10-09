// array as obj
// the method overloading and overriding  
// without using 'virtual' and 'override' modifiers 
using System; 

namespace ct_overloading_overriding
{
    
    class baseClass 
    
    { 
        public int a;
        public int b;
        public baseClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void sum()
        {
            int c = a+b;
            Console.WriteLine("Sum: "+ c);
        }

        public virtual void show() 
        { 
            Console.WriteLine("Base class"); 
        } 
    } 
    
    class derived : baseClass 
    { 
        public derived(int a, int b) : base(a, b)
        {
            this.a = a;
            this.b = b;
        }

        public void div()
        {
            float c = a/b;
            Console.WriteLine("Div: "+ c);
        }

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
            baseClass obj1 = new baseClass(3,5); 
            obj1.show(); 
            obj1.sum();
            baseClass[] array = new baseClass[4]; 
            derived obj2 = new derived(5,7); 
            obj2.show(); 
            obj2.div();
            
        }
    }
}
