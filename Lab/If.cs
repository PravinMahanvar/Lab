using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class If
    {

        // 0--sun
        // 1-- mon
        // 2-- tue
        // 5-- sat
        // wrong number ?
        public void Main(string[]args)
        {
            Console.WriteLine("Enter no");
            int no = int.Parse(Console.ReadLine());

            if(no == 0)
            {
                Console.WriteLine("sunday");

            }
            else  if(no== 1)
            {
                Console.WriteLine("monday");
            }
            else if(no == 2)
            {
                Console.WriteLine("tuesday");
            }
            else if(no== 3)
            {
                Console.WriteLine("wesnday");
            }
            else if(no == 4)
            {
                Console.WriteLine("thues");
            }
            else if(no == 5)
            {
                Console.WriteLine("friday");
            }
            else if(no == 6)
            {
                Console.WriteLine("sat");
            }
            else
            {
                Console.WriteLine("wrong no");
            }
            
        }

    }
}
