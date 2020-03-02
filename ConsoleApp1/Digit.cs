using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Digit
    {
        public Digit()
        {
        }


        int i;
        int j;
        int sum , count ; 

        public Array GetDigits()
        {
            Console.WriteLine(" Please Enter Your Count of Numbers ");
            count = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int [count]; 
            Console.WriteLine(" Please Enter Your Numbers ");
            for (i = 0; i <= count; i++)
            {
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }
            return digits;
        }

        public void Sum()
        {
            
            
            
        }

        public void Show()
        {
            Console.WriteLine(" the sum of your numbers is " + sum);
        }

    }
}
