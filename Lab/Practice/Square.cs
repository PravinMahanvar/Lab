using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice
{
    public  class Square
    {
        static void Main(string[] args)
        {
             for(int i= 1; i<=20; i++)
                if(i%1 ==0)
                {
                    int square = i * i;
                    Console.WriteLine(square);
                }
        }
    }
}
