using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BesinKatlari6lisutun
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i%5==0)
                {
                    Console.Write("{0,5}", i);
                    adet++;

                }
                if (adet==6)
                {
                    Console.WriteLine();
                    adet = 0;
                }

            }
        }
    }
}
