using System;

namespace DenemeVeTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string isim = "Yusuf";
            //  int sayi1 = 14;
            //  double sayi2 = 12.5;
            //  bool sistemegiris = true;

            //###############################################################

            //  if (sistemegiris == true)
            //  {
            //       Console.WriteLine("Sisteme Giriş Yaptı");
            //  }
            //  else
            //  {
            //    Console.WriteLine("Sisteme Giriş Yanlış");
            //  }

            //#############################################################3

            //  double dolarDün = 14.5;
            //  double dolarBügün = 14.5;

            //  if (dolarDün > dolarBügün)
            //  {
            //      Console.WriteLine("Dolar Düştü");
            //  }
            //  else if (dolarDün<dolarBügün)
            //  {
            //      Console.WriteLine("Dolar Yükseldi");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Dolar Sabit");
            //  }

            Kurslar kurs1 = new Kurslar();
            kurs1.KursAdi = "Matematik Kursu";
            kurs1.IzlemeSayisi = 15;
            kurs1.HocaİIsmi = "Yusuf";

            Kurslar kurs2 = new Kurslar();
            kurs2.KursAdi = "İngilizce Kursu";
            kurs2.IzlemeSayisi = 10;
            kurs2.HocaİIsmi = "Eren";

            Kurslar kurs3 = new Kurslar();
            kurs3.KursAdi = "Türkçe Kursu";
            kurs3.IzlemeSayisi = 10;
            kurs3.HocaİIsmi = "Gülhan";

            Kurslar kurs4 = new Kurslar();
            kurs4.KursAdi = "Kimya Kursu";
            kurs4.IzlemeSayisi = 10;
            kurs4.HocaİIsmi = "Eyüp";

            Kurslar kurs5 = new Kurslar();
            kurs5.KursAdi = "Biyoloji Kursu";
            kurs5.IzlemeSayisi = 10;
            kurs5.HocaİIsmi = "Ezgi";

            Kurslar[] kurs = new Kurslar[] { kurs1, kurs2, kurs3, kurs4, kurs5 };
            foreach (var Kurs in kurs)
            {
                Console.WriteLine("##################");

                Console.WriteLine("Hoca İsmi; " + Kurs.HocaİIsmi);
                Console.WriteLine("İzleme Sayisi; " + Kurs.IzlemeSayisi);
                Console.WriteLine("Hoca İsmi; " + Kurs.HocaİIsmi);
            }


        }



    }

    class Kurslar
    {
        public string KursAdi { get; set; }
        public int IzlemeSayisi { get; set; }
        public string HocaİIsmi { get; set; }
    }

}