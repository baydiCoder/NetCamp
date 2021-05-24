using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
  public class InMemoryCarDal : ICarDal
  {
    List<Car> _cars;
    public InMemoryCarDal()
    {
      _cars = new List<Car> {
      new Car{ BrandId=1,CarId=1,ColorId=1,DailyPrice=18.25,Description="Mavi Sedan Ford",ModelYear="2015"},
       new Car{ BrandId=2,CarId=2,ColorId=3,DailyPrice=20,Description="Kırmızı SUV Toyota",ModelYear="2000"},
        new Car{ BrandId=3,CarId=3,ColorId=4,DailyPrice=15,Description="Gri Sedan Volvo",ModelYear="2019"},
         new Car{ BrandId=1,CarId=4,ColorId=2,DailyPrice=12,Description="Yeşil Sedan Ford",ModelYear="1980"},
      };
    }
    public void Add(Car car)
    {
      _cars.Add(car);
    }

    public void Delete(Car car)
    {
      //_cars.RemoveAt(_cars.FindIndex(a => a.CarId == car.CarId));
      _cars.Remove(_cars.SingleOrDefault(a=>a.CarId==car.CarId));
    }

    public List<Car> GetAll()
    {
      return _cars;
    }

    public Car GetById(int carId)
    {
      return _cars.Find(a => a.CarId == carId);
    }

    public void Update(Car car)
    {
      Car updateCar = _cars.SingleOrDefault(a => a.CarId == car.CarId);
      updateCar.BrandId = car.BrandId;
      updateCar.ColorId = car.ColorId;
      updateCar.DailyPrice = car.DailyPrice;
      updateCar.Description = car.Description;
      updateCar.ModelYear = car.ModelYear;
      
    }
  }
}
