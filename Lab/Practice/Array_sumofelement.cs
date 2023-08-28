using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_sumofelement
    {
        // sum of element from the array
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Console.WriteLine("enter the array list");
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

                sum = sum + array[i];
            }
            Console.WriteLine("the sum of element array" + sum);
        }
    }
}
