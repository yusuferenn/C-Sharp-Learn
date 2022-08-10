using System;
using System.Collections.Generic;
using System.Text;

namespace MathEx
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int topla = sayi1 + sayi2;
            Console.WriteLine("Toplam Sonucunuz; " + topla);
        }

        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Çıkarma Sonucunuz; " + cikar);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int carp = sayi1 * sayi2;
            Console.WriteLine("Çarpma Sonucunuz; " + carp);
        }

        public void Böl(double sayi1, double sayi2)
        {
            double böl = sayi1 / sayi2;
            Console.WriteLine("Bölme Sonucunuz; " + böl);
        }


    }
}
