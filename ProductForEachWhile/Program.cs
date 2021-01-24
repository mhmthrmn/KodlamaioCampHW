using System;

namespace ProductForEachWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "elma";
            urun1.UrunInfo = "kırmızı elma";
            urun1.StokAdet = 3;

            Product urun2 = new Product();
            urun2.UrunAdi = "armut";
            urun2.UrunInfo = "ekşi armut";
            urun2.StokAdet = 4;

            Product urun3 = new Product();
            urun3.UrunAdi = "kivi";
            urun3.UrunInfo = "yerli kivi";
            urun3.StokAdet = 5;

            Product[] urunler = new Product[] {urun1,urun2,urun3 };

            Console.WriteLine("----------FOREACH DÖNGÜSÜ----------");
            foreach (Product product in urunler)
            {
                Console.WriteLine(product.UrunAdi+" "+product.UrunInfo+" "+product.StokAdet);
            }
            Console.WriteLine("----------FOR DÖNGÜSÜ----------");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].UrunInfo + " " + urunler[i].StokAdet);
            }
            Console.WriteLine("----------WHILE DÖNGÜSÜ----------");
            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine(urunler[x].UrunAdi + " " + urunler[x].UrunInfo + " " + urunler[x].StokAdet);
                x++;
            }
        }
    }
}
