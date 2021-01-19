using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
         /*
            string kurs1 = "Yazılım Geliştirici Yerleştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java"; 
         */

            string[] kurslar = new string[] { "Yazılım Geliştirici Yerleştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs","Java","Pyhton","C++","C#"};
            
         
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }

            Console.WriteLine("For Bitti - Foreach Başlıyor!!!!");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("|-------- Sayfa Sonu - footer --------| ");
        }
    }
}
