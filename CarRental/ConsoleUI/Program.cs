using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      CarManager carManager = new CarManager(new EFCarDal());
      BrandManager brandManager = new BrandManager(new EFBrandDal());
      Console.WriteLine("------------Araçlar-------------");
      foreach (var item in carManager.GetAll())
      {
        Console.WriteLine("{0} - {1}",item.CarId,item.Description);
      }

      Console.WriteLine("\n------------Markalar-------------\n");
      foreach (var item in brandManager.GetAll())
      {
        Console.WriteLine("{0} - {1}", item.BrandId, item.Name);
      }

      Console.WriteLine("\n--------Seçilen araç ------- \n");
      foreach (var item in carManager.GetCarsByBrandId(3))
      {
        Console.WriteLine("{0} - {1}", item.CarId, item.Description);
      }

      carManager.Add(new Car { BrandId = 1, ColorId = 2, Description = "Yaris",DailyPrice=1,ModelYear="2010" });

      carManager.Add(new Car { BrandId = 1, ColorId = 2, Description = "a", DailyPrice = 500, ModelYear = "2010" });
      carManager.Add(new Car { BrandId = 1, ColorId = 2, Description = "Hilux", DailyPrice = 0, ModelYear = "2010" });


      Console.WriteLine("------------Araçlar-------------");
      foreach (var item in carManager.GetAll())
      {
        Console.WriteLine("{0} - {1}", item.CarId, item.Description);
      }

      //foreach (var item in carManager.GetAll())
      //{
      //  Console.WriteLine("{0} - {1}", item.CarId, item.Description);
      //}

    }
  }
}
