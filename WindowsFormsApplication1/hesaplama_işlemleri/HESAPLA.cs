using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplama_işlemleri
{
    class HESAPLA
    {
        public void tekSayılar()
        {
            Console.WriteLine("lütfen bir sayı giriniz");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                for (int i = 0; i < x; i+=2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(" girilen sayı ciftir");
                
            }
            else
            {
                for (int i = 1; i < x; i += 2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("girilen sayı tektir");
                
            }
            Console.ReadKey();
        }
        public void çitSayılar()
        {

        }
    }
}
