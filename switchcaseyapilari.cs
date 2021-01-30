using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchcaseyapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * if-else if gibi çok şartlı durumlarda kullanılan
             * yapılar yerine switch case kullanılabilir.
             * swtich (değişken adı)
             * {
             * case tercih :
             *    yapılcak işler
             *    break;
             * }
             * 1)Eğer tercih sayısal ifade ise direkt sayı yazılır.
             * Ancak tercih sayısı ondalıklı olamaz. Eğer tercih metin ise
             * tercih "tercih" şeklinde kullanılır.
             * 2)Her case 'in mutlaka sonlandığını belirten break ifadesi
             * kullanılmalıdır.
             * 3)Hiç bir case geçerli değilse yapılcak işler
             * default:
             *    yapılacak işler
             *    break; 
             *    şeklinde kullanılır.
             */
            Console.Write("1. Sayıyı giriniz...:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz...:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toplama [t]:");
            Console.WriteLine("Çıkarma [ç]:");
            Console.WriteLine("Çarpma  [x]:");
            Console.WriteLine("Bölme   [b]:");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "t":
                    Console.WriteLine("Toplam...:{0}",sayi1+sayi2);
                    break;
                case "ç":
                    Console.WriteLine("Fark.....:{0}",sayi1-sayi2);
                    break;
                case "x":
                    Console.WriteLine("Çarpım...:{0}",sayi1*sayi2);
                    break;
                case "b":
                    switch (sayi2)
                    {
                        case  0:
                            Console.WriteLine("Tanımsız işlem");
                            break;
                        default:
                            Console.WriteLine("Bölüm...:{0}",(float)sayi1/sayi2);
                            break;
                    }
                    //if (sayi2!=0)
                    //{
                    //    Console.WriteLine("Bölüm..:{0}",(float)sayi1/sayi2);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Tanımsız İşlem");
                    //}
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim...");
                    break;
            }

        }
    }
}
