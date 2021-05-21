using System;

namespace ClassMetotDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Musteri musteri1 = new Musteri();
      musteri1.MusteriId = 1;
      musteri1.KimlikNo = "123456123456";
      musteri1.Ad = "Eli";
      musteri1.Soyad = "Bayd";

      Musteri musteri2 = new Musteri(2,"El","Bay","14785236911");
      Musteri musteri3 = new Musteri(3, "Aa", "Bb", "14785236911");
      Musteri musteri4 = new Musteri(4, "Cc", "Dd", "14785236911");

      MusteriManager musteriManager = new MusteriManager();
      musteriManager.Ekle(musteri1);
      musteriManager.Ekle(musteri2);
      musteriManager.Ekle(musteri3);
      musteriManager.Ekle(musteri4);
      musteriManager.Listele();

      musteriManager.Sil(musteri1);
      musteriManager.Listele();
    }
  }
}
