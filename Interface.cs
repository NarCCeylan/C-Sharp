using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Interface (Arayüz)
             * 1) Interfaceler sınıflara rehber olmak için kullanlırlar.
             * 2) .Net te çoklu kalıtım yoktur. Ancak  Interfaceler sayesinde
             *    çoklu arayüz kullanımı vardır.
             * 3) Interfaceler interface anahtar kellimesiyle bildirilirler.
             * 4) Interfaceler classlar ile aynı seviyededirler. Bu yüzden
             *    class içersinde ınterface tanımlaması yapılamaz.
             * 5) Interfaceler geleneksel olarak I harfiyle başlarlar.
             * 6) Interfaceler yapısal olarak publictirler.
             * 7) Interfacelerin kendine özgü işleri olamaz. Dolayısıyla  
             *    Interfacelerin fieldları yazılmaz.
             * 8) Interfacelerin propertiesleri yazılabilir. Ancak fieldlar 
             *    olmadığından propertieslerin get ve set blokları boş bırakılır.
             * 9) Interfacelerin elemanlaörı yapısal olarak public olduğundan 
             *    ayrıca public erişim belirteci kullanılmaz.
             * 10) Interfacelerin constructorları yazılmaz.
             * 11) Interfacelerin metotları olabilir. parametre alabilir, geriye 
             *     değer döndürebilir. Ancak metotların kesinlikle metot gövdeleri
             *     yazılamaz. Dolayısıyla {  } gövde belirteci kullanılamaz.
             * 12) Interfaceleri miras alan classlarda interfacenin elemanlarınının
             *     kullanılabilmesi için implement edilmeleri gerekir.
             */
            Dortgen d = new Dortgen();
            d.Boy = 3;
            d.En = 4;
            Yaz(d.Alan());
            Yaz(d.Cevre());
            Yaz(d.SelikNedir());
            

        }

        private static void Yaz(string p)
        {
            Console.WriteLine(p);
        }

        private static void Yaz(float p)
        {
            Console.WriteLine("Sonuç :{0}",p);
        }
    }
}
