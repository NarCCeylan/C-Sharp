using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KonrolluNotGirisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ogrencinin adını soyadını numarasını ve matematik dersine ait
             * 3 notu alarak ortalam hesaplayan program.
             * Ortalama hesaplayan metot Ogrenci classı içerisinde olmalıdır.
             */
            Ogrenci ogr = new Ogrenci();

            Console.Write("Adı.....:");
            ogr.Adi = Console.ReadLine();
            Console.Write("Soyadı..:");
            ogr.Soyadi = Console.ReadLine();
            Console.Write("Numara..:");
            try
            {
                ogr.Numara = int.Parse(Console.ReadLine());
                Console.Write("1. Not..:");
                ogr.Not1 = int.Parse(Console.ReadLine());
                Console.Write("2. Not..:");
                ogr.Not2 = int.Parse(Console.ReadLine());
                Console.Write("3. Not..:");
                ogr.Not3 = int.Parse(Console.ReadLine());
                Yaz(ogr.OrtalamaHesapla());
                
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
        }

        private static void Yaz(float p)
        {
            Console.WriteLine("Ortalama...:{0}",p);
        }
    }
}
