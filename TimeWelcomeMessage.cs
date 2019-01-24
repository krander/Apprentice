using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                if (DateTime.Now.Hour < 12)
                {
                    Console.WriteLine("Good Morning");
                }

                else if (DateTime.Now.Hour < 17)
                {
                    Console.WriteLine("Good Afternoon");
                }

                else
                {
                    Console.WriteLine("Good Evening");
                }
                Console.ReadLine();
            }
        }
    }
}
