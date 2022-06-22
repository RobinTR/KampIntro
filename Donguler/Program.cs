using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazılım kamp","Programlama giriş","Java"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar )
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
