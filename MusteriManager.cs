using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + "--> Numarali müşteri başarıyla eklendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo + "--> Numarali müşteri başarıyla silindi.");
        }
        public void Listele(Musteri musteri)
        {
            

            Console.WriteLine("Musteri No:" + musteri.MusteriNo + "\n" + "Musteri Adi:" + musteri.Adi + "\n" + "Musteri Soyadi:" + musteri.Soyadi);

        }
    }
}
