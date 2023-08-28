using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Evenodd
    {
        static void Main(string[]args)
        {
            Console.WriteLine("ENTER THE NEW NUMBER ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("the number is even ");

            }
            else
            {
                Console.WriteLine("the number is odd");
            }

        }
        
    }
}
