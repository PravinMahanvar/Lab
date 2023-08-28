using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_max
    {

        // find the max char from array
        static void Main(string[] args)
        {
            char[] array = { 'a', 'b', 'c', 'd', 'f', 'g' };

            char maxchar = array[0];

            for(int i= 1; i<array.Length; i++)
            {
                if (array[i] > maxchar)
                {
                    maxchar = array[i];
                }
            }
            Console.WriteLine("the maxximum character is " + maxchar);
        }
       
    }
}

