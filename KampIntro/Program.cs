using System;
using System.Threading.Channels;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 17.35;
            double dolarBugun = 17.45;

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Düşüş oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar artış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap");
            }
        }
    }
}
