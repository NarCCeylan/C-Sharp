using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxMinNotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Klavyeden üç not girişi yapılacak. Bu notlardan max ve min
             * olanı, notların ortalaması ekrana yazdırılacak.
             * NOT: Notların uygunluğu kontrol edilecektir.
             */
            int max = 0, min = 0, ortanca = 0, toplam;
            float ort;
            int adet = 3;
            int yedek = 0;
            int not=0;
            for (int i = 0; i < adet; i++)
            {

                //if (not < 0 || not > 100)
                //{
                //    Console.WriteLine("Geçersiz not girişi...");
                //}
                //else
                //{
                while (not <= -1 && not > 100)
                {
                    Console.Write("{0}. Notu Giriniz...:", i + 1);
                   not = Convert.ToInt16(Console.ReadLine());
                    min = not;

                    
                }
                if (min > ortanca)
                    {
                        yedek = min;
                        min = ortanca;
                        ortanca = yedek;
                    }
                    if (ortanca > max)
                    {
                        yedek = ortanca;
                        ortanca = max;
                        max = yedek;
                    }
                //}
            }
            Console.WriteLine("Max....:{0}", max);
            Console.WriteLine("Min....:{0}", min);
            Console.WriteLine("Ortalama:{0}", (float)(max + ortanca + min) / adet);
        }
    }
}
