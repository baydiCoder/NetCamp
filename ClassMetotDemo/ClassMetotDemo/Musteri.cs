using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
  class Musteri
  {
    public int MusteriId { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string KimlikNo { get; set; }


    public Musteri()
    { }

    public Musteri(int musteriId,string ad, string soyad,string kimlikNo)
    {
      this.MusteriId = musteriId;
      this.Ad = ad;
      this.Soyad = soyad;
      this.KimlikNo = kimlikNo;
    }


  }
}
