using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Sum21
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            Console.WriteLine("enter any number");
                num = Convert.ToInt32(Console.ReadLine());

            int last  = num % 10;
            int first  = num;

            while (num > 10)
            {
                num = num % 10;
            }
            first = last;
            sum = first + last;
            Console.WriteLine("sum of 1 st last number :"+sum);
        }
    }
}
