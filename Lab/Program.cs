using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());

            if(Number % 2 == 0)
            {
                Console.WriteLine("The number is even ");

            }
            else
            {
                Console.WriteLine("the number is odd");

            }
           
           
                

        }
    }
}
