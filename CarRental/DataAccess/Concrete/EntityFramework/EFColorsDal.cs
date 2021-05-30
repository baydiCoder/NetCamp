using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public class EFColorsDal : IColorsDal
  {
    public void Add(Colors entity)
    {
      using (CarRentalContext context = new CarRentalContext())
      {
        var addedEntity = context.Entry(entity);
        addedEntity.State = EntityState.Added;
        context.SaveChanges();
      }
    }

    public void Delete(Colors entity)
    {
      using (CarRentalContext context = new CarRentalContext())
      {
        var deletedEntity = context.Entry(entity);
        deletedEntity.State = EntityState.Deleted;
        context.SaveChanges();
      }
    }

    public Colors Get(Expression<Func<Colors, bool>> filter)
    {
      using (CarRentalContext context = new CarRentalContext())
      {
        return context.Set<Colors>().SingleOrDefault(filter);
      }
    }

    public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
    {
      using (CarRentalContext context = new CarRentalContext())
      {
        return filter == null ? context.Set<Colors>().ToList() : context.Set<Colors>().Where(filter).ToList();
          }
    }

    public void Update(Colors entity)
    {
      using (CarRentalContext context = new CarRentalContext())
      {
        var updatedEntity = context.Entry(entity);
        updatedEntity.State = EntityState.Modified;
        context.SaveChanges();
      }
    }
  }
}
