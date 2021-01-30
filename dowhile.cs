using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sifretahmin_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Do-While : icra şekli mantık açısından while döngüsü ile aynıdır.
             * Ancak while döngüsünde şart döngüye başlarken yazılır.
             * Do while döngüsünde ise döngü bloğunun sonuda yazılır.
             * Dolayısı ile döngününün şartı false olsa bile döngü en az
             * 1 defa icra görür.
             */
            int sifre = 12345;
            int giris;
            int i = 0;
            bool b = true;
            do
            {
                i++;
                Console.Write("Şifre Giriniz...:");
                giris = Convert.ToInt16(Console.ReadLine());
                if (giris == sifre)
                {
                    Console.WriteLine("Tebrikler...{0}. defada bildiniz", i);
                    b = false;
                }
                if (i == 3 && b == true)
                {
                    Console.WriteLine("Hakkınız Bitti...");
                    b = false;
                }
            }
            while (b);
            
        }
    }
}
