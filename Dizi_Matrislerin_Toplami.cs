using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrislerinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] dizi1 = new int[2,2];
            int[,] dizi2 = new int[2, 2];
            int [,]dizi3=new int[2,2];

            
            for (int i = 0; i < dizi1.GetLength(0); i++)
            {
                for (int j = 0; j < dizi1.GetLength(1); j++)
                {
                    Console.Write("Dizi {0}. satırı {1}.sütunu elemanı :",i+1,j+1);
                    dizi1[i, j] = int.Parse(Console.ReadLine());

                }
            }
            for (int i = 0; i < dizi2.GetLength(0); i++)
            {
                for (int j = 0;j < dizi2.GetLength(1); j++)
                {
                    Console.Write("Dizi {0}.satırı {1}.sütunu elemanı :", i + 1, j + 1);
                    dizi2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < dizi3.GetLength(0); i++)
            {
                for (int j = 0; j < dizi3.GetLength(1); j++)
                {
                    dizi3[i, j] = dizi1[i, j] + dizi2[i, j];
                  
                }
            }
            for (int i = 0; i < dizi3.GetLength(0); i++)
            {
                for (int j = 0; j < dizi3.GetLength(1); j++)
                {
                    Console.Write("{0,3}",dizi3[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
