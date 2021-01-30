using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parametrelerde_ParamsOzelligi
{
    class Program
    {
        static void Main(string[] args)
        {
            Topla(3, 5);
            Topla(3, 5, 8);
            Topla(3, 6, 9, 5, 80, 4);
        }

        private static void Topla(params int [] dizi)
        {
            int toplam = 0;
            foreach (var item in dizi)
            {
                toplam = toplam + item;
            }
            Console.WriteLine(toplam);
        }

        
    }
}
