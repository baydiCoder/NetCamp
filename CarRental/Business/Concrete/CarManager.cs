using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class CarManager : ICarService
  {

    ICarDal _iCarDal;

    public CarManager(ICarDal iCarDal)
    {
      _iCarDal = iCarDal;
    }

    public void Add(Car car)
    {
      bool isPriceOk = car.DailyPrice > 0;
      bool isNameOk = car.Description.Length > 2;

      if (isPriceOk && isNameOk)
      {
        _iCarDal.Add(car);
        Console.WriteLine("araç eklendi");
        return;
      }
      Console.WriteLine(!isNameOk?"geçerli açıklama giriniz:":(!isPriceOk?"Geçerli fiyat bilgisi giriniz.":""));
     
    }

    public void Delete(Car car)
    {
      _iCarDal.Delete(car);
    }

    public List<Car> GetAll()
    {
      return _iCarDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
      return _iCarDal.GetCarsByBrandId(brandId);
    }

    public List<Car> GetCarsByColorsId(int colorId)
    {
      return _iCarDal.GetCarsByColorsId(colorId);
    }

    //public Car GetById(int carId)
    //{
    //  return _iCarDal.GetById(carId);
    //}

    public void Update(Car car)
    {
      _iCarDal.Update(car);
    }
  }
}
