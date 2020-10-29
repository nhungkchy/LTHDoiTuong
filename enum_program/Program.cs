// enum
using System;

namespace EnumApplication 
{
   class EnumProgram 
   {
      enum Days 
      { 
          Sun = 8, 
          Mon = 2, 
          Tue = 3, 
          Wed = 4, 
          Thu = 5, 
          Fri = 6, 
          Sat = 7
        };
      public enum Color: byte
      {
          red = 1,
          blue = 2,
          green = 3
      }
    

      static void Main(string[] args) 
      {
         int weekdayStart = (int)Days.Mon;
         int weekdayEnd = (int)Days.Fri;
         var red = Color.red;
         
         Console.WriteLine("Monday: {0}", weekdayStart);
         Console.WriteLine("Friday: {0}", weekdayEnd);
         Console.WriteLine("Red: {0}", red);
         Console.ReadKey();
      }
   }
}
