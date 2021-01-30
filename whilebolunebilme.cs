using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bolunebilme
{
    class Program
    {
        static void Main(string[] args)
        {
            // 25 ten 100 ye kadar olan sayılardan 7 ye bölünebilen
            // 5 'e bölünemeyen sayıları listeleyen prog.
            /*1)Sayaç tanımla ve 25 ten başlat
             *2)döngüyü 100 ye kadar döndür
             *3)eğer sayaçtaki sayı 7 ye bölünebiliyorsa aynı zamanda
             *  5' e bölünemiyorsa  bu sayıyı ekrana yaz.
             * 
             */
            int i = 25;
            while (i < 100)
            {
                if (i%7==0 && i%5!=0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }
        }
    }
}
