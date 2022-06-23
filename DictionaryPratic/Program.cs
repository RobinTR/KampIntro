using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace DictionaryPratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1,"Robin");
            ogrenci.Add(2,"Test");
            Console.WriteLine(ogrenci.Count);
            ogrenci.Listele();

        }
    }

}
