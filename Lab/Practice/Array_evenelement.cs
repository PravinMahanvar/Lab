using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_evenelement
    {
        static void Main(string[] args)
        {
            // calculate avg of even element from array
            int[] array = { 1, 2, 3, 4, 5, 6, 7, };
            int sum = 0;
            int count = 0;

            for(int i= 0; i<array.Length; i++)
            {
                if (array[i]%2 ==0)
                {
                    count++;
                    sum= sum + array[i];
                }
            }
            int avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
