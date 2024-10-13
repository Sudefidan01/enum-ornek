using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _20230826_Enum_Ornek
{
    enum Aylar
    {
        Ocak=1,
        Subat,
        Mart,
        Nisan,
        Mayis,
        Haziran,
        Temmuz,
        Agustos,
        Eylul,
        Ekim,
        Kasim,
        Aralik
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 1-12 arasında bir sayı talep edelim
            //Girmiş olduğu sayıyıya göre o ayın hangi mevsimde olduğunu ekrana yazdıralım
            //Enum yapısı kullanarak  yapalım
            Console.WriteLine("1-12 arası sayı giriniz");
            int secim=int.Parse(Console.ReadLine());
            switch (secim)
            {
                case (int)Aylar.Aralik:
                case (int)Aylar.Ocak:
                case (int)Aylar.Subat:
                    Console.WriteLine("Kış Mevisimi");
                    break;
                case (int)Aylar.Mart:
                case (int)Aylar.Nisan:
                case (int)Aylar.Mayis:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case (int)Aylar.Haziran:
                case (int)Aylar.Temmuz:
                case (int)Aylar.Agustos:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case (int)Aylar.Eylul:
                case (int)Aylar.Ekim:
                case (int)Aylar.Kasim:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;

            }

            Console.ReadKey();
        }
    }
}
