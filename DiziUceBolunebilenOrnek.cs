using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UceBolunebilenlerCiftlerinOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden kaç sayı girileceği istecek.
             * Girilen sayılar diziye aktarılacak.
             * 3'e bölünebilenlerin sayısını bulacak
             * Çift sayıların ortalamasını bulacak.
             * 
             */
            Console.Write("Kaç Sayı Girilecek...:");
            int adet = Convert.ToInt16(Console.ReadLine());
            int sayi = new int();
            int[] dizi = new int[adet];
            int ciftadet=0;
           double cifttoplam = 0;
            //float ortalama = 0;
            for (int i = 0; i < adet; i++)
            {
                Console.Write("Dizinin {0}. Elemanı...:",i+1);
                dizi[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i <dizi.Length; i++)
            {
                if (dizi[i]%3==0)
                {
                    sayi++;
                }
                if (dizi[i]%2==0)
                {
                    cifttoplam += dizi[i];
                    ciftadet++;
                }
            }
            Console.WriteLine("Üçe bölünebilenlerin sayısı:{0}",sayi);
            Console.WriteLine("Çiftlerin ortalaması.......:{0}",(float)(cifttoplam)/ciftadet);

        }
    }
}
