using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator
{
  public class Product
  {
    public string Name { get; set; }
    public int Upc { get; set; }
    public Money Price { get; set; }
  }
}
