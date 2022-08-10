using System;

namespace IlkBakis
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - Tip Güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            // string = yaptığımız şey değer tutucu - alias
            {
                string kategoriEtiketi = "Kategori";
                Console.WriteLine(kategoriEtiketi);

                int sayıEtiketi = 2;
                Console.WriteLine(sayıEtiketi);

                double noktalıSayı = 3.14;
                Console.WriteLine(noktalıSayı);

                bool sistemeGirisYaptiMi = false;


                if (sistemeGirisYaptiMi == true)
                {
                    Console.WriteLine("Sisteme Giriş Yaptı");
                }
                else
                {
                    Console.WriteLine("Sisteme Giriş Yapmadı");
                }

                //#########################################################################


                double dolarDun = 14.65;
                double dolarBugun = 17.65;

                if (dolarDun > dolarBugun)
                {
                    Console.WriteLine("Dolar Düştü");
                }
                else if (dolarDun < dolarBugun)
                {
                    Console.WriteLine("Dolar Yükseldi");
                }
                else
                {
                    Console.WriteLine("Dolar Sabit");
                }
            }
        }
    }
}
