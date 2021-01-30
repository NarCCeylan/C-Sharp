using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icicefordonguleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * İç içe for döngülerinde en dışarıdaki for döngüsü
             * 1 defa iş yaparken, içerideki döngü bütün döngüsünü tamamlar
             * NOT: iç içe for döngülerinin sayaç isimleri birbirinden farklıolmalıdır.
             */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nBen dışarıdaki döngüyüm {0}. İşlem\n",i+1);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("İçerideki Döngüyüm {0}. İşlem",j+1);
                }
            }
        }
    }
}
