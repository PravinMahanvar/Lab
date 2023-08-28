using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    internal class Array_display
    {
        // display al the vowels 
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'e', 'i', 'o', 'u' };

            string vowels = "";
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {

                    vowels = vowels + arr[i];

                    count++;
                }

                


            }
            Console.WriteLine($"the vowels is the array is {count} this vowels is" + vowels);


        }
       
    }
}