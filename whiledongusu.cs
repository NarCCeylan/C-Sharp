using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace whilegiris
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while : 1)belirli işlemleri istenilen sayıda tekrar etmek
             * için kullanılan yapılara döngü denir.
             * 2)Her döngünün mutlaka bir sayaca ihtiyacı vardır.
             * 3)while döngüsünde sayaç döngüye girmeden tanımlanır.
             * 4)Kullanımı:
             * while(Şart cümlesi)
             * {
             *      İcra edilecek kodlar
             * }
             * 5)While döngüsnde kullanılan sayaç döngü içerisnde 
             * uygun şekilde arttırılmalı veya eksiltilmelidir. Aksi taktirde
             * sonsuz döngü olacaktır.
             */
            // Birden 10 'a kadar olan sayıları listeleyen prog.
            int i = 0;
            while (i<10)
            {
                i++;
                Console.WriteLine("i...:{0}",i);
            }
        }
    }
}
