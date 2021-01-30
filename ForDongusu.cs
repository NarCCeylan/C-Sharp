using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * FOR: En çok kullanılan döngüdür.
             * döngü içerisinde sayaç,şartiartış miktarı olmalıdır. 
             * Kullnımı:
             * for(sayac=değeri;Şart cümlesi;sayacınartışmiktarı)
             * {
             *   İcra edilecek kodlar
             * }
             * NOT: sayacın veri tipi fordan önce belirtilmemiş ise
             * tip tanımlaması for içerisinde yapılabilir.
             */
            //1 den 10'a kadar sayıları listeleyelim.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i < 10; i++)
            {
                i++;
                Console.WriteLine(i);
            }

        }
    }
}
