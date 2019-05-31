using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
  public class Tax
  {
    public decimal Value { get; }


    public Tax(decimal value)
    {
      Value = value;
    }
  }
}
