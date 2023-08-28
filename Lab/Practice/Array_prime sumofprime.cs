using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_prime_sumofprime
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int count = 0;
            Console.WriteLine("enter the number");

            for(int i= 0; i<array.Length; i++)
            {
                bool isprime = true;
                for(int j =2; j<array.Length; j++)
                {
                    if (array[i]% j ==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime)
                {
                    sum = sum + array[i];

                    count++;
                }
             
              

            }
            int avg = sum / count;
            Console.WriteLine("the prime number avg is" + avg);
            
        }
    }
}
