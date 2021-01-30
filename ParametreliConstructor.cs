using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParametreliConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen en ve boy bilgilerine göre şeklin kare mi, 
            //dikdörtgen mi oldunu bulan program
            Sekil s = new Sekil(5, 5);
            s.SekilNedir();
            
          
        }
        
        
    }
}
