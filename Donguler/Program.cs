using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"Yazilim Gelistirici Yetistirme Kampi", "Programlamaya Baslangic Icin Temel Kurs", "Java", "Python"};



            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {

            }
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
