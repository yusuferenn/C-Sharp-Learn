using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Yusuf Eren";         //bununla zaman kaybetmek yerine class yazıp tasaruf yaparsın çok iyi
            int yas = 18;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmen = "Engin";
            kurs1.IzlemeOranı = 15;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmen = "Yusuf";
            kurs2.IzlemeOranı = 10;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmen = "Eren";
            kurs3.IzlemeOranı = 50;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmen = "Emre";
            kurs4.IzlemeOranı = 75;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "C";
            kurs5.KursEgitmen = "John";
            kurs5.IzlemeOranı = 34;

            Kurs kurs6 = new Kurs();
            kurs6.KursAdi = "GoLang";
            kurs6.KursEgitmen = "Camella";
            kurs6.IzlemeOranı = 20;

            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.KursEgitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5, kurs6 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("########################");

                Console.WriteLine("Kursun Adi; " + kurs.KursAdi);

                Console.WriteLine("Kurs Eğitmeni; " + kurs.KursEgitmen);

                Console.WriteLine("Kursun Tamamlama Değeri; " + kurs.IzlemeOranı);

            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int IzlemeOranı { get; set; }


    }
}
