using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziyeRasgeleSayilarAt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Kaç Sayı Üretilecek...:");
            int adet = int.Parse(Console.ReadLine());
            Console.Write("Minimum Değer....:");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Maximum Değer....:");
            int max = int.Parse(Console.ReadLine());
            
            int[] dizi = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                dizi[i]=rnd.Next(min, max);
            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
