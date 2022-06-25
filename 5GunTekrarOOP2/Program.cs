using System;

namespace _5GunTekrarOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 2;
            musteri1.Adi = "Robin";

            Musteri musteri2 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri3);
        }
    }
}
