using System;

namespace tryintry
{
    class Program
    {
        public static void main(String[] args){
      //main try-block
        try
        {
    	//try-block2
            try
            {     
            //try-block3
                try
                {
            	int[] arr= {1,2,3,4};
            	/* I'm trying to display the value of
            	 * an element which doesn't exist. The
            	 * code should throw an exception
            	 */
            	Console.WriteLine(arr[10]);
                }
                catch(ArithmeticException e)
                {
                    Console.WriteLine("Arithmetic Exception");
                    Console.WriteLine(" handled in try-block3");
                }
            }
            catch(ArithmeticException e)
            {
            Console.WriteLine("Arithmetic Exception");
            Console.WriteLine(" handled in try-block2");
            }
        }
        catch(ArithmeticException e3)
        {
            Console.WriteLine("Arithmetic Exception");
            Console.WriteLine(" handled in main try-block");
        }
        catch(ArrayIndexOutOfBoundsException e4)
        {
            Console.WriteLine("ArrayIndexOutOfBoundsException");
            Console.WriteLine(" handled in main try-block");
        }
    }
    }
}

