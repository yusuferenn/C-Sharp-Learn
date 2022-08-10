using System;

namespace DenemeVeTekrarV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale();
            sale1.productPhoneName = "Apple";
            sale1.productShop = "HepsiBurada";
            sale1.productPhoneSale = 14000;

            Sale sale2 = new Sale();
            sale2.productPhoneName = "Apple";
            sale2.productShop = "Trendyol";
            sale2.productPhoneSale = 16235;

            Sale sale3 = new Sale();
            sale3.productPhoneName = "Apple";
            sale3.productShop = "N11";
            sale3.productPhoneSale = 15024;

            Sale sale4 = new Sale();
            sale4.productPhoneName = "Apple";
            sale4.productShop = "GittiGidiyor";
            sale4.productPhoneSale = 15124;

            Sale[] Sales = new Sale[] { sale1, sale2, sale3, sale4 };

            foreach (var sales in Sales)
            {
                Console.WriteLine("####################");
                Console.WriteLine("Cihaz Adi; " + sales.productPhoneName);
                Console.WriteLine("Mağaza Adi; " + sales.productShop);
                Console.WriteLine("Satış Fiyati; " + sales.productPhoneSale);
            }
        }
    }
    class Sale
    {
        public string productPhoneName { get; set; }
        public string productShop { get; set; }
        public int productPhoneSale { get; set; }
    }
}
