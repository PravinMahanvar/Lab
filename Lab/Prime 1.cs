using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Prime_1
    {  /// print the prime bet 11 to 21 
        static void Main(string[] args)
        {
            for (int i=11; i<= 21; i++)
            {
                bool isPrime1 = true;
                for (int j = 2; j<i; j++)
                {
                    if(i%j== 0)
                    {
                        isPrime1 = false;
                        break;
                    }
                }
                if (isPrime1= true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
