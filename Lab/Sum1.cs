using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Sum1
    {
        // sum of all digits of number 123>>>>> 1+2+3 = 6
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
