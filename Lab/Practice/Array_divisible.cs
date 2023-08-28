using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_divisible
    {

        // WAP replce element by 0 if element is divisible by 5
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for(int i =0; i<array.Length; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            for(int i =0; i<array.Length; i++)
            {
                if (array[i]%5==0)
                    Console.WriteLine(array[i]);
            }


        }
    }
}
