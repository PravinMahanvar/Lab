using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{



    internal class Maximun
    {
        static void Main(string[]args)
        {
            int num1 = 12;
            int num2 = 2;
            int num3 = 20;

            if (num1> num2 && num3> num1)
            {
                Console.WriteLine("the greatest number is " + num1);
            }
            else if(num2> num3)
            {
                Console.WriteLine("the greatest number is " + num2);

            }
            else
            {
                Console.WriteLine("the greatest number is " + num3);
            }

        }
    }
}
