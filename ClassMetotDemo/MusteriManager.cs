using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : "+musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi);
        }
        public void Güncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi : " + musteri.Adi);
        }
        public void Bilgileri(int Id, string adi, int yas, double HarcamaLimiti)
        {
            Console.WriteLine("Müşteri bilgiler şunlardır : " + "İd = " + Id + " İsim =  " + adi + " Yaş =  " + yas + " Harcama Limiti =  " + HarcamaLimiti);
        }
    }
}
