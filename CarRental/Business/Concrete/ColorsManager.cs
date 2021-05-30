using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
  public class ColorsManager : IColorsService
  {
    private IColorsDal colorsDal;
    public ColorsManager(IColorsDal colorsDal)
    {
      this.colorsDal = colorsDal;
    }
    public List<Colors> GetAll()
    {
      return this.colorsDal.GetAll();
    }
  }
}
