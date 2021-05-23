using GameWeb.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Concrete
{
  class DiscountManager:IDiscountService
	{ 
	public void Add(Discount discount)
		{
			Console.WriteLine(discount.Description + " kampanyası tanımlandı");

		}

	public void Update(Discount discount)
		{
			Console.WriteLine(discount.Description + " kampanyası güncellendi");

		}

	public void Delete(Discount discount)
		{
      Console.WriteLine(discount.Description + " kampanyası silindi");
		}

	public bool Validate(Discount discount)
		{
			return DateTime.Now < discount.Deadline;

		}
	}
}
