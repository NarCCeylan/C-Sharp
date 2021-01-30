using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReferansTipliDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = DegerVer(ref a);
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}",b);

        }

        private static int DegerVer(ref int a)
        {
            a = 20;
            return a;
        }
    }
}
