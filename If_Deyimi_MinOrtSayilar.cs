using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinOrtMaxSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 3 sayı sırasıyla min,ort,max olacak şekilde sıralayan program.
            Console.Write("1.sayıyı giriniz :");
            int s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.sayıyı giriniz :");
            int s2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3.sayıyı giriniz :");
            int s3 = Convert.ToInt16(Console.ReadLine());
            int yedek;
            if (s1>s2)
            {
                yedek = s1;
                s1 = s2;
                s2 = yedek;
            }
            if (s1>s3)
            {
                yedek = s1;
                s1 = s3;
                s3 = yedek;
            }
            if (s2>s3)
            {
                yedek = s2;
                s2 = s3;
                s3 = yedek;

            }
            Console.WriteLine("Minimum:{0}",s1);
            Console.WriteLine("Ortanca:{0}",s2);
            Console.WriteLine("Maximum:{0}",s3);
        }

    }
}
