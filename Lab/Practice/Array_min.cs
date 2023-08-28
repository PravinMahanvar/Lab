using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_min
    {
        static void Main(string[] args)
        {
            char[] array = { 'a', 'b', 'c', 'd', 'f' };

            char minchar = array[0];

            for(int i =0; i<array.Length; i++)
            {
                if (array[i] < minchar)
                {
                    minchar = array[i];
                }

            }

            Console.WriteLine("the min char is " + minchar);
        }


    }
}
