using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Abstract
{
  interface IDiscountService
  {
    void Add(Discount discount);

    void Update(Discount discount);

    void Delete(Discount discount);

    bool Validate(Discount discount);
  }
}
