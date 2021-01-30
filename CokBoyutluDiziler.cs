using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             */
            int[] dizi = { 1, 3, 5, 13 };// tek boyutlu
            int[,] dizi2 = { {1, 2, 3} , {4, 5, 6 }, { 7, 8, 9 } }; // çift boyutlu
            for (int i = 0; i < dizi2.GetLength (0); i++)
            {
                for (int j = 0; j < dizi2.GetLength (1); j++)
                {
                    Console.WriteLine(dizi2[i,j]);
                }
                
            }
            
            
        }
    }
}
