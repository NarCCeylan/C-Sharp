using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metotlarin_AsiriYuklenmesi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aynı metot adına sahip fakat imzaları farklı metotlara
             * aşırı yüklenmiş (overloading) metot denir.
             * */
            int c = Topla(1, 2);
            string d = Topla("ali");
            Topla('f');
           
           
        }

        private static void Topla(char p)
        {
            throw new NotImplementedException();
        }

        private static string Topla(string p)
        {
            throw new NotImplementedException();
        }

        private static int Topla(int p, int p_2)
        {
            throw new NotImplementedException();
        }
    }
}
