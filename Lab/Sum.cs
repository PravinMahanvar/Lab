using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for( int i =10; i>=1; i--)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum); 
            

        } 
    }
}
