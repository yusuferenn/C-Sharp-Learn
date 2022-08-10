using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //  (i++) = (i=i+1) = (i+=2)
            //          
            //          {
            //              for (int i = 1; i <= 100; i+=2)
            //                  {
            //                      Console.WriteLine(i);
            //                  }
            //          }


            //####################################################################

            // Array -Dizi

            string kurs1 = "Yazılım 1";
            string kurs2 = "Yazılım 2";
            string kurs3 = "Yazılım 3";

            //yazmak yerine

            string[] kurslar = new string[]
            {
            "Yazılım Geliştirme Kampı", "Programlamaya Giriş Kampı", "3D Tasarım Kampı","Developer Olma Kampı",
            "ebeebs", "öküzün", "assdllfkdkfj"
            };

            for (int i = 0; i < kurslar.Length; i++)   //Sayı ile girseydik ekleme yaptıkça onu değiştirmen gerekti
                                                       // Biz burada (Length) kullandığımız için ne kadar string oluşturusan oluştur ona göre hareket edecek.
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("#############################");

            //Çok iyi yöntem Kurlar yukarda yazdığımız string dosyası, kurs bizim tanımladığımız string, string yazan ne olduğu

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
