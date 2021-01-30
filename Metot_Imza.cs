using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metotlarda_ImzaKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //İmza Kavramında Önemli Sıralamalar
            /*
             * 1) Bir metodun ismi imza kavramında en önemli etkendir.
             *    Yani metot adlarının farklı olması metotların farklı
             *    olması demektir.
             * 2) Metot isimleri aynı olabilir. Bu durumda metot adları metotları
             * ayırt edici özellik taşımaz. Bu durumda metotların parametrelerine bakılır.
             * 3) Parametrelerin sayısına bakılır.
             * 4) Parametre sayıları aynı ise parmetrelerin veri türlerine bakılır
             * 5) Metotların geriye dönüş tipleri metotların imzası konusunda hiç bir belirleyici
             * özelliğe sahip değildir.
             */
            Topla();
            Topla(2, 5);
            Topla(2, 3, 5);
            Topla(2, 3, "ahmet");

        }

        private static void Topla(int p, int p_2, string p_3)
        {
            throw new NotImplementedException();
        }

        private static void Topla(int p, int p_2, int p_3)
        {
            throw new NotImplementedException();
        }

        private static void Topla()
        {
            throw new NotImplementedException();
        }

        private static int Topla(int b,int c)
        {
            throw new NotImplementedException();
        }
        
    }
}
