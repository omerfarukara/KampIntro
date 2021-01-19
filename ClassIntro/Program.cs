using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ömer Faruk Kara";
            kurs1.IzlenmeOranı = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Göktuğ Talha Coşkunsoy";
            kurs2.IzlenmeOranı = 65;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Emirhan Yıldırım";
            kurs3.IzlenmeOranı = 60;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Egitmen = "Metehan İnan";
            kurs4.IzlenmeOranı = 60;


            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };
            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " kursunun eğitmeni : " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
