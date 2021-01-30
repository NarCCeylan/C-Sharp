using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometriUcgenDortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Virtual Methods (Sanal Metlar):
             * 1) Metotların sanal olduğu virtual anahtar kelimesiyle belirlenir.
             * 2) Sanal Metotlar başka classlar tarafından kullanılacaksa 
             *    public tanımlanmalı
             * 3) Sanal metotlar kalıtım yolu ile başka classlara miras olarak 
             *    devredilecekse miras alan classta ezilerek (override) kullanılmalıdır.
             * 4) Sanal Metotların miras verilen classlarda kullanılabilmesi için
             *    ilgili class içerisinde implement(açığa çıkartmak) edilmelidirler.
             * 5) Sanal metotlar parametre alabilir, geriye değer döndürebilirler.
             * 
             */
            Ucgen u = new Ucgen(3, 4);
            Yaz(u.Alan());
            Yaz(u.Cevre());
            Dortgen d = new Dortgen(3, 4);
            Yaz(d.Alan());
            Yaz(d.Cevre());
            Geometri geo = new Geometri();
            Console.WriteLine(geo.Yazdir());
            Console.WriteLine(u.Yazdir());
        }

        private static void Yaz(float p)
        {
            Console.WriteLine("Sonuç...:{0}",p);
        }
    }
}
