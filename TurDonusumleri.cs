using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tür dönüşümleri 2 şekilde yapılır.
             * 1)Bilinçsiz tür dönüşümü : Convert sınıfının static dönüşüm metotları kullanılarak yapılır.
             * Örnek:
             */
            int a = 20;
            Console.WriteLine("Tam sayı a = {0}",a);
            float b = a;
            a =Convert.ToInt16(b);
            Console.WriteLine("a nın floata dönüşmüş hali={0}",a);
            Console.WriteLine("float b = {0}",b);
            float c = 15.6f;
            Console.WriteLine("float c = {0}",c);
            double d = c;
            Console.WriteLine("double d = {0}", d);
            Console.WriteLine("******");
            int f = 65;
            char g = Convert.ToChar(f);
            Console.WriteLine("char g={0}",g);

            bool h = true;
            Console.WriteLine("h={0}",h);
            int i = Convert.ToInt16(h);
            Console.WriteLine("bool h ın int i ={0}",i);
            string j = Convert.ToString(h);
            Console.WriteLine("j={0}",j);
            /*
             * 2)Bilinçli Tür Dönüşümü:Büyük türün küçük türe dönüşümünün yapılması gerektiği durumlarda kullanılır.
             * Bu durumda büyük olan tür küçük olan türe cast operatörü kullanılarak dönüştürülür.
             * Örnek:
             */
            double k = 10.6;
            int l = (int)k;// cast işlemi
            Console.WriteLine("l={0}", l);
            double m = 9000000000000;
            checked
            {
                int n = (int)m;
                Console.WriteLine("n={0}", n);
                
            }
           
         //ÖRNEK:Dört İşlem ,
            int sayi1 = 10, sayi2 = 6;
            Console.WriteLine("Toplam  :{0}", sayi1 + sayi2);
            Console.WriteLine("Fark    :{0}", sayi1 - sayi2);
            Console.WriteLine("Çarpım  :{0}", sayi1 * sayi2);
            Console.WriteLine("Bölüm   :{0}", ((float)(sayi1) / sayi2));
            /*
             * GEREKSİZ TÜR DÖNÜŞÜMÜ:
             * aynı türün aynı türe dönüştürülmesidir.Derleyici hata vermez ancak
             * ram fazla ama gereksiz işlem yapmış olur.
             */
            sayi2 = Convert.ToInt16(sayi1);//gereksiz tür dönüşümü

        }
    }
}
