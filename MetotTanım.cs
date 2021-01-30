using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetotlarGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Metotlar: Program parçacıklarıdır.
             * Programların hızlı çalışmasını sağlayan yapılardır.
             * Metot Tanımlamalarında Dikkat Edilecek Hususlar 
             * - Her metot bir iş yapacak şekilde tasarlanır
             * - Metotlar mümkün olduğu kadar az iş yapmalıdırlar.
             * - Console uygulamalarında metotlar static olarak yazılırlar.
             * TANIMLAMA :
             * - Her metodun mutlaka bir adı olmalıdır.
             * - Metotlar geriye değer döndürebilirler.
             * - Eğer metotlar geriye değer döndürmezlerse geri dönüşüm veri tipi void olarak yazılır.
             * - Metotların geriye dönüş değerleri varsa ,dönen değer hangi veri türüne sahip ise mutlaka aynı veri türü tanımlanmalıdır.
             * - Metotların metot adından sonra () leri yazılmalıdır.
             * - Her metodun mutlaka metot gövdesi olmak zorundadır.
             * ( Bazı özel Metotlar hariç )
             * - Metotların rivate ve public olmak üzere iki farklı erişim belirteçleri vardır.Metodun tanımlandığı class  
             *  içerisinde her iki erişim belirtici kullanılabilir.Ancak başka bir classtan metodun tanımlandığı classtaki metot kullanılacaksa  
             *  erişim belirteci kesinlikle public olmalıdır. Eğer hiç bir erişim belirteci yazılmamış ise default olarak metot private dir.
             * 
             * 
             * Erişim Belirteci Geridönüştipi MetotAdı()
             * {
             *    Metot gövdesi
             * }
             * 
             * - Metotlar classın elemanları olduğundan dolayı metot tanımlamları kesinlikle class içerisinde olmalıdır.
             * - Metot içerisinde metot tanımlaması yapılamaz ...
             * - Ancak bir metot başka bir metot içerisinde çağrılabilir.
             * - Metotlar çağrılmadıkları zaman iş yapmazlar.
             * - Metotlar çağrılırken metot adı +() leri yazılmalıdır.
             * - Programın akışı metodun icrasından sonra,metodun çağrıldığı noktadan sonra devam eder.
             * - Metotlar parametre(değişken) alabilirler. Metotların parametre tanımlamalarında değişken tanımlama kuralları geçerlidir.
             * - Metotların parametreleri metodun () leri arasına yazılır.
             * - Metotların geriye dönüş değerleri return komutu ile yapılır ...
             * - Metot içerisinde return ifadesei ile karşılaşıldığında return ifadesinden sonraki komutlar icra etmez ...
             */

            Yaz();// Metotların çağrılması
            Console.WriteLine("Nasılsınız kuzum :D     ");
            Topla(10, 15);
            int c = Cikar(15,10);
            Console.WriteLine("İlk olan {0}",c);
            Console.WriteLine(Cikar(15,10));
            

        }
        static private void Yaz()
        {
            Console.WriteLine("Metotlar Anlatılıyor **** ");
            
        }
        // Geriye değer döndürmeyen ama parametre alan metotlar 
        static private void Topla(int a,int b)
         {
             Console.WriteLine("Toplam...{0}",a+b);
    
         }
        // Geriye değer döndüren parametre alan metotlar
        static int Cikar(int a, int b)
        {

            int sonuc = a - b;
            return sonuc;
            


            
        }
    }
}
