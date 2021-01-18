using ClassMetotDemo;
using System;

namespace MetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriNo = 123456;
            musteri1.Adi = "Stanley";
            musteri1.Soyadi = "Kubrick";


            Musteri musteri2 = new Musteri();
            musteri2.MusteriNo = 654321;
            musteri2.Adi = "Andrey";
            musteri2.Soyadi = "Tarkovsky";


            Musteri musteri3 = new Musteri();
            musteri3.MusteriNo = 354521;
            musteri3.Adi = "David";
            musteri3.Soyadi = "Lynch";

            //Array for DRY coding
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("------MÜŞTERİ BİLGİLERİ------");
                Console.WriteLine("MÜŞTERİ No:" + musteri.MusteriNo + "\nMÜŞTERİ ADI :" + musteri.Adi + "\nMÜŞTERİ SOYADI :" + musteri.Soyadi);
                Console.WriteLine("-------------********************-------------");
            }
            //Modules involving the console

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri2);

            Console.WriteLine("---------------MUSTERI LISTESI---------------");
            Console.WriteLine("1. Musteri:");
            musteriManager.Listele(musteri1);

            Console.WriteLine("2. Musteri:");
            musteriManager.Listele(musteri3);
            Console.ReadLine();
        }
        
    }
}
