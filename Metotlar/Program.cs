using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyati = 15;
            string açıklama = "Amasya elması";
            */
            
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Bursa elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 150;
            urun2.Aciklama = "Bursa Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("---------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,1);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,3);
            sepetManager.Ekle2("Karpuz", "Bursa Karpuzu", 12,2);
        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice