using System;
using System.Collections.Generic;
using System.Text;

namespace GameWeb
{
  class Discount
  {
    public Discount()
    {

    }

    public Discount(String description, int discountPercent, DateTime deadline)
    {

      this.Description = description;
      this.DiscountPercent = discountPercent;
      this.Deadline = deadline;
    }
    public string Description { get; set; }
    public int DiscountPercent { get; set; }
    public DateTime Deadline { get; set; }
  }
}
