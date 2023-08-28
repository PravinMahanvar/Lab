using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public  class Condition
    {
        static void Main(string[]args)
        {
            Console.WriteLine("percentage ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            // 75----> A+
            // 50-75---->A
            // 40.50---->B+
            // <40------->fail

            if (percentage > 75)
            {
                Console.WriteLine("grade a");
            }
            else if (percentage > 50 && percentage<= 75)
            {
                Console.WriteLine("grade A");
            }
            else if(percentage>40 && percentage<= 50)
            {
                Console.WriteLine("grade");
            }
            else
            {
                Console.WriteLine("fail");
            }
            
                
            

        }
    }
}
