using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetotlarinOverride_edilmesi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Metotların override edilmesi override ifadesi ile bildirilir.
            // 2) Ezilmiş olan metot asıl görevini bırakıp yeni yüklenen görevi 
            // icra eder
            Ogrenci ogr = new Ogrenci("hasan", "yılmaz", 123, "12TB");
            Console.WriteLine(ogr.ToString());
            
        }
    }
}
