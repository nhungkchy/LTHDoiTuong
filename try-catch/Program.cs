// exception
using System;

namespace try_catch
{
    public class NumberUtility
    {
        public static int GetIntFromString(string pInput)
        {
            int result = 0;
            try
            {
                result = int.Parse(pInput);
            }
            catch (ArgumentNullException ane)
            {
                Console.Write("Your string is null, " + ane.ToString());
            }
            // Ngoại lệ FormatException xảy ra khi người dùng nhập giá trị không phải số
            catch (FormatException fe)
            {
                Console.Write("Your string is not in the correct format. , " + fe.ToString());
            }
            // Ngoại lệ OverflowException xảy ra khi người dùng nhập vượt quá kiểu int
            // Giới hạn của Int trong C# : 	-2,147,483,648 to 2,147,483,647
            catch (OverflowException ofE)
            {
                Console.Write("Your string represents a number less than MinValue or greater than MaxValue. , " + ofE.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Your string is invalid, " + ex.ToString());
            }
            return result;
        }
        public static int GetIntFromStringOneCatch(string pInput)
        {
            int result = 0;
            try
            {
                result = int.Parse(pInput);
            }
            // Ngoại lệ ArgumentNullException xảy ra khi người dùng không nhập dữ liệu
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    Console.Write("Your string is null, " + ex.ToString());
                else if (ex is ArgumentNullException)
                    Console.Write("Your string is not in the correct format. , " + ex.ToString());
                else if (ex is OverflowException)
                    Console.Write("Your string represents a number less than MinValue or greater than MaxValue. , " + ex.ToString());
                else
                    Console.Write("Your string is invalid, " + ex.ToString());
            }
        
            return result;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập 1 chuỗi từ bàn phím
            Console.Write("Enter Your string:");
            string input1 = Console.ReadLine();
        
            int soChuyenDoi1 = NumberUtility.GetIntFromString(input1);
        
            Console.WriteLine("Your string is " + soChuyenDoi1);

            Console.Write("Enter Your string:");
            string input2 = Console.ReadLine();
        
            int soChuyenDoi2 = NumberUtility.GetIntFromStringOneCatch(input2);
        
            Console.WriteLine("Your string is " + soChuyenDoi2);
        
        
            Console.ReadLine();
        }
    }
}

