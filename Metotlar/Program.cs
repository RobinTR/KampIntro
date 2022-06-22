using System;
using System.Threading.Channels;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun okunanUrun in urunler)
            {
                Console.WriteLine(okunanUrun.Adi);
                Console.WriteLine(okunanUrun.Fiyati);
                Console.WriteLine(okunanUrun.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("---------Metotlar--------------");

            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
