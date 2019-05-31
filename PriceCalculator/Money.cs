using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
  public class Money
  {
    public decimal Value { get; }

    public Money(decimal amount)
    {
      Value = amount;
    }
  }
}
