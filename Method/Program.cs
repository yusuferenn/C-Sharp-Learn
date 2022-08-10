using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string ÜrünAdi = "Elma";
            double ÜrünFiyati = 15;
            string ÜrünAciklamasi = "Amasya elması";

            string[] meyveler = new string[] { "elma", "karpuz" };

            Product urun1 = new Product();
            urun1.ÜrünAdi = "Elma";
            urun1.ÜrünFiyati = 15;
            urun1.ÜrünAciklamasi = "Amasya elamsı";

            Product urun2 = new Product();
            urun2.ÜrünAdi = "Elma";
            urun2.ÜrünFiyati = 15;
            urun2.ÜrünAciklamasi = "Amasya elamsı";
            

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.ÜrünAdi);
                Console.WriteLine(urun.ÜrünFiyati);
                Console.WriteLine(urun.ÜrünAciklamasi);
                Console.WriteLine("------------");
            }

            Console.WriteLine("-------------Metodlar------------");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sepetManager.Ekle2("Armut", "Yaşil armut", 12);
            
        }
    }
}