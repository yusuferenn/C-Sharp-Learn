using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    //Naming Convertion ----- Normal bir parantez görürsen o metod
    //syntax

    class SepetManager
    {
        public void Ekle(Product urunadı)
        {
            Console.WriteLine("Ürün Sepete Eklendi, Ürün Adı; " + urunadı.ÜrünAdi);
        }

        //public void Ekle2(string ÜrünAdi, string ÜrünAciklamasi, double ÜrünFiyati)  #Bunu yapma uzun sürer
        //{
        //    Console.WriteLine("Ürün Sepete Eklendi, Ürün Adı; " + ÜrünAdi);

        //}
    }
}
