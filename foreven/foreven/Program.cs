using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //Console.WriteLine("print all even numbers between 100 to 500");
            for (i = 100; i <= 500; i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine("{0} is divisible by 2", i);
                }
                else
                {
                    Console.WriteLine("{0} is not divisible by 2", i);
                }

                Console.ReadLine();
            }
        }
    }
}

