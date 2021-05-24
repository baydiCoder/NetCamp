using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      CarManager carManager = new CarManager(new InMemoryCarDal());
      Console.WriteLine("------------Araçlar-------------");
      foreach (var item in carManager.GetAll())
      {
        Console.WriteLine("{0} - {1}",item.CarId,item.Description);
      }

      var car = carManager.GetById(2);
      Console.WriteLine("\n--------Seçilen araç ------- \n{0} - {1}", car.CarId, car.Description);

    }
  }
}
