using System;

namespace csart_odevlerim1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mobilyalar = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "tv ünitesi";
            urun1.Fiyati = 600;
            urun1.Aciklama = "%5 indirim";

            Urun urun2 = new Urun();
            urun2.Adi = "kanepe";
            urun2.Fiyati = 2.000;
            urun2.Aciklama = "%10 indirim";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            int i = 0;
            for (i = 0; i < urunler.Length; i++)

            {
                Console.WriteLine(urunler[i].Adi);
            }

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }

            
            while (i < urunler.Length)
            {

                Console.WriteLine("ürünün adı :" + urunler[i].Adi);
                Console.WriteLine("ürünün fiyatı:" + urunler[i].Fiyati);
                Console.WriteLine("ürürnün açıklaması:" + urunler[i].Aciklama);
                i++;
            }

        }

    }
}

