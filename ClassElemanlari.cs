using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classın_elemanları
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * clasların elemanları üç çeşittir.
             * 1 Fielsds--> alanlar
             * 2 Properties --->özellikler
             * 3 Constuructor-->Yapıcı metodlar
             * 
             * 1-Fields(Alanlar)
             * a- Alanlar class içinde tanımlanan kulanıcı tipli ve referans tipli değişkenlerdir.
             * b- Alanların tanımlamalarında  değişken tanımlama kuralları geçerlidir.
             * c- Alan adlarının ilk harfleri küçük yazılır.
             * d- Alanlar class'ların özel işlerini yaptıklarından dolayı dışarıdan erişilmemelidir.Bu yüzden erişim belirteçleri private dir
             *
             * 
             * 2-Propertes(özellikler)
             * a- Propertiesler alanlara kontrollü veri aktarmak için kullanılır.
             * b- Propertiesler tanımlanırken değişken tanımlama kuralları geçerlidir.
             * c- Propertiesler hangi alanda yazılıyorsa ilgili alanı hatırlatır türden olmalı..
             * d- Propertieslerin properties adınn ilk harfi büyük yazılır.
             * e- Properties classın dışından erişilen elemanlar olduklarından  erişim belirteçleri public olmak zorundadır.
             * f- Propertieslerin metot gövdesi gibi gövdesi olur.
             * g- Propertiesler hangi field için yazılmış ise ilgili fielda değer atarken gövde içerisinde set yapısı kullanılır...
             * h- Eğer fielddan atanan değer okunacaksa get yapısı kulanılır...
             
               3) CONSTRUCTORLAR(Yapıcı Metotlar)
             *  Constructorlar üç kategoriye ayrılır
             *  a) Default Constructorlar
             *  b) Copy Constructorlar (Parametreli metotlar)
             *  c) DeConstructorlar (Yıkıcı metotlar)
               */
            /*
             * A) Default Constructor
             * Tanım: Clasın elemanlarınının (field ve propertires)
             * alması gereken default değerlerin tanımlandığı özel metottur.
             * 1)Constructorlar classın dışarıdan erişilebilir elemanlarındandır.
             * Bu yüzden public erişim belirtecine sahiptirler.
             * 2)Constructorların geriye dönüş tipleri yoktur.
             * 3)Constructorlarda fieldlara default değerler properties üzerinden verilir.
             * 4)Constructor içerisinde propertieslere değer atanırken 
             * this anahtar kelimesi kullanılır.
             * 5)Constructorların adları Class adı ile aynı olmalıdır.
             */
            Ogrenci ogr = new Ogrenci();
            Console.WriteLine(ogr.Adi);
            Console.WriteLine(ogr.Numarasi);
            Console.WriteLine(ogr.Uyruk);
            Console.WriteLine("değer \n atıyoruz");
            ogr.Adi = "Hasan";
            ogr.Cinsiyet = true;
            ogr.Numarasi = 12;
            ogr.Soyadi = "YILMAZ";
            ogr.Uyruk = "TC";

            Console.WriteLine(ogr.Adi);
            Console.WriteLine(ogr.Soyadi);
            Console.WriteLine(ogr.Numarasi);
            Console.WriteLine(ogr.Cinsiyet);
            Console.WriteLine(ogr.Uyruk);

        }
    }
}
