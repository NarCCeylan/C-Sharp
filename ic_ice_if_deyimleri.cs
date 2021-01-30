using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ic_ice_if_deyimleri
{
    class Program
    {
        static void Main(string[] args)

        {
            /*
             * İstenilen sayıda program mantığına göre iç içe if kullanılabilir.
             * İf(Şart1)
             * {
             *     İf(şart2)
             *     {
             *      Kod
             *     }
             *     if(Şart3)
             *     {
             *        if(Şart4)
             *        {
             *        
             *        }
             *        else
             *        {
             *          if(Şart5)
             *          {
             *          
             *          }
             *          else if(Şart6)
             *          {
             *             if(Şart7)
             *             {
             *             
             *             }
             *          }
             *          else if(Şart8)
             *          {
             *          
             *          }
             *          else
             *          {
             *          }
             *        }
             *     }
             * }
             * Dört işlem menüsü hazırlanacak.Kullanıcı istediği işlemi seçebilecek.Bölme isleminde tanımsız bölmeye
             * dikkat edecek.
             */
            
           
            Console.WriteLine("1.sayıyı giriniz:");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.sayıyı giriniz:");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Toplama için 't' ya basınız");
            Console.WriteLine("Çıkarma için 'ç' ye basınız");
            Console.WriteLine("Çarpma için 'x' ye basınız");
            Console.WriteLine("Bölme için 'b'ye basınız");
            Console.WriteLine("************"); 
            Console.Write("Seçim yapınız :");
            string islem = Console.ReadLine();
            double sonuc = 0;
            if (islem == "t")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç:{0}", sonuc);
                Console.ReadLine();

            }
            else if (islem=="ç")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç:{0}", sonuc);


            }
            else if (islem=="x")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç:{0}", sonuc);

            }
            else if (islem=="b")
	         {
                 if (sayi2==0)
                 {
                     Console.WriteLine("Tanımsız işlem!");
                 }
                 else
                 {
                     sonuc = (double)(sayi1) / sayi2;
                    Console.ReadLine();

                 }
	         }
            else
            {
                Console.WriteLine("Yanlış seçim !") ;
            }
       
                       
        }
    }
}
