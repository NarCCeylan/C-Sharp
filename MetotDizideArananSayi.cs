using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DizideArananSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 5, 6 };
            Console.Write("Aranan Sayı ...:");
            int sayi = int.Parse(Console.ReadLine());
            Yaz(Bul(sayi, dizi));

        }

        private static void Yaz(bool b)
        {
            if (b)
            {
                Console.WriteLine("Buldum");
            }
            else
            {
                Console.WriteLine("Bulamadım");
            }
        }

        private static bool Bul(int sayi, int[] dizi)
        {
            bool b = false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]==sayi)
                {
                    b = true;
                }
            }
            return b;
        }
    }
}
