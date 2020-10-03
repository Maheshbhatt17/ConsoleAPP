using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Hello Welcome to the basics");
            string a = Console.ReadLine();
            try
            {
                if (a.Length > 10)
            {
               throw new Exception("Name should be less than 10");
                    
            }
            Console.WriteLine("Enter the age");
            int c = 0;
            
                c = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("The name is" + a + "The value is" + c);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                Console.ReadLine();
            }*/

            // takes the input form user
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt16(Console.ReadLine());
            //for loop to print the all values till the variable n
            for(int i=n; i>=0;i--)
            {
                Console.WriteLine(i);
               
            }
            Console.ReadLine();
        }
    }
}
