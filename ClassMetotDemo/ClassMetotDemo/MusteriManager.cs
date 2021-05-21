using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
  class MusteriManager
  {
    List<Musteri> musteriler;
    public MusteriManager()
    {
      musteriler = new List<Musteri>();
    }
    public void Ekle(Musteri musteri)
    {
      musteriler.Add(musteri);
      Console.WriteLine(musteri.Ad+" "+musteri.Soyad +" kişisi eklendi ");
    }

    public void Sil(Musteri musteri)
    {
      musteriler.Remove(musteri);
      Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " kişisi silindi ");
    }

    public void Listele()
    {
      Console.WriteLine("\n Müşteriler \n");
      foreach (Musteri musteri in musteriler)
      {
        Console.WriteLine(musteri.MusteriId+" - "+musteri.Ad + " " + musteri.Soyad);
      }
    }
  }
}
