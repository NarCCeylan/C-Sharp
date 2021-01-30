using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziliSayi2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,3}",j);
                }
                Console.WriteLine();
            }
        }
    }
}
