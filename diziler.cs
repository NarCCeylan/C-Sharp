using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dizi Tanım;
             * 1)  Aynı türden verilerin saklandığı kümelere "dizi" denir.
             * 2)  Dizilerde en önemli kavramlardan bir tanesi indis kavramlardır.
             * 3)  Her indis bilginin dizide hangi bölgede olduğunu gösterir.
             * 4)  Dizinin indis sayısı dizinin eleman sayısının 1 eksiği kadardır.
             * 5)  Dizilerin indisleri sıfır(0)'dan başlar.
             * 6)  Diziler "ArrayList" sınıfından türemişlerdir.
             * 7)  Diziler kullanılırken "System.Collections" namespace'si referans edilmelidir.
             * 8)  Dizilerin boyutları sonradan değiştirilemez.
             * 9)  Dizilere değerler ilk atama ya da sonradan atama şeklinde yapılabilir.
             * 10) Dizi tanımlanırken değişken tanımlama kuralları geçerlidir.
             * 11) Diziler "[]" şeklinde belirtilirler.
             * 
             * TANIMLAMA;
             * - İlk Atama;
             * 
             * VeriTürü [] DeğişkenAdı = {değer1,değer2,değer3,...};
             * 
             * - Sonradan Atama;
             * 
             * VeriTürü [] DeğişkenAdı = new Veritürü[ElemanSayısı];
             */

            int[] sayilar = { 3, 5, 7, 9, 12, 15 };
            string[] isimler = { "Ceylan", "Hakan", "Kemal", "Yunus" };
            char[] karekter = {'a','b','c'};
            bool[] mantiksal = { true, true, false, true };
            Console.WriteLine("--------Sayılar     Yazdırılıyor--------");
            // Length özelliği dizinin eleman sayısını verir.
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("---------İsimler     Yazdırılıyo---------");
            // Count metoddur. Length ile arasındaki fark parantezdir.
            for (int i = 0; i < isimler.Count(); i++)
            {
                Console.WriteLine(isimler[i]);
            }

            /*
             * Foreach Döngüsü: Koleksiyon tarzındaki değişkenlerin değerlerini
             * yazdırmak için kullanılır. "Foreach" döngüsünde dizi değişkenlere
             * değer ataması yapılamaz.
             */

            // Var : Tipsiz olan tiplerin tiplendirilmesinde kullanılan tiptir.
            Console.WriteLine("---------Karekterler Yazdırılıyor--------");
            foreach (var item in karekter)
            {
                Console.WriteLine(item);
            }




        }
    }
}
