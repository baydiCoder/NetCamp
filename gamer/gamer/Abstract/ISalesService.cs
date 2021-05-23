using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb.Abstract
{
  interface ISalesService
  {
    void Sold(Game game, User user);

    void Sold(Game game, User user, Discount discount);
  }
}
