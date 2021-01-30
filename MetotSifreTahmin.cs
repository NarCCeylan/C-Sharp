using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sifretahminmetot
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sifre = 333;
            while (i<=3)
            {
                Console.Write("Dandana Dam ");
                int girilen = int.Parse(Console.ReadLine());
                bool b=Tahmin(sifre,girilen ,i);
                if (b)
                {
                    break;
                }
                i++;
            }
        }
        static bool Tahmin(int sifre, int girilen,int i)
        {
            bool b = false;
            if (sifre==girilen)
            {
                YazBildiniz(i);
                b = true ;
            }
            if (i==3 && b==false)
            {
                YazBilemediniz(); 
            }
            return b;
        }
        static void YazBildiniz(int i)
        {
            Console.WriteLine("{0}.defada bildiniz",i);
        }
        static void YazBilemediniz()
        {
            Console.WriteLine("Bitti hakkın senin\nHakkın bitti senin\nSenin hakkın bitti");
        }
    }
}
